using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Creates or edits a deal: title, company, primary contact, amount, stage, expected close date and owner.
	/// </summary>
	public partial class DealEditDialog : Form
	{
		private DealInput deal;
		private List<StageItem> stages;
		private bool loading;

		public DealEditDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Shows the dialog; returns true when the deal was saved.
		/// </summary>
		/// <param name="dealId">The deal to edit, or null for a new deal.</param>
		/// <param name="companyId">Company preselected for a new deal.</param>
		/// <param name="contactId">Primary contact preselected for a new deal.</param>
		public static bool Edit(int? dealId, int? companyId = null, int? contactId = null)
		{
			using (var dialog = new DealEditDialog())
			{
				if (!dialog.LoadDeal(dealId, companyId, contactId))
					return false;

				return dialog.ShowDialog(Form.ActiveForm) == DialogResult.OK;
			}
		}

		private bool LoadDeal(int? dealId, int? companyId, int? contactId)
		{
			return Notify.Try(() =>
			{
				this.stages = LookupService.Stages();

				if (dealId != null)
				{
					this.deal = DealService.Get(dealId.Value);
					if (this.deal == null)
						throw new InvalidOperationException("The deal no longer exists.");
				}
				else
				{
					// a new deal with the company of its contact, in the first stage, owned by the current user.
					if (companyId == null && contactId != null)
						companyId = DealService.CompanyOfContact(contactId.Value);

					var first = this.stages.FirstOrDefault(s => !s.IsWon && !s.IsLost) ?? this.stages.First();
					this.deal = new DealInput
					{
						CompanyId = companyId,
						PrimaryContactId = contactId,
						StageId = first.Id,
						ExpectedCloseDate = DateTime.Today.AddDays(30),
						OwnerId = CurrentUser.IsSignedIn ? CurrentUser.Id : (int?)null,
					};
				}

				this.loading = true;
				try
				{
					this.Text = dealId == null ? "New deal" : "Edit deal";
					this.buttonSave.Text = dealId == null ? "Create deal" : "Save";

					var companies = LookupService.Companies();
					companies.Insert(0, new ListItem(0, "(No company)"));
					this.comboBoxCompany.DisplayMember = "Text";
					this.comboBoxCompany.ValueMember = "Id";
					this.comboBoxCompany.DataSource = companies;
					this.comboBoxCompany.SelectedValue = this.deal.CompanyId ?? 0;

					LoadContacts();
					this.comboBoxContact.SelectedValue = this.deal.PrimaryContactId ?? 0;
					if (this.comboBoxContact.SelectedIndex < 0)
						this.comboBoxContact.SelectedIndex = 0;

					this.comboBoxStage.DisplayMember = "Name";
					this.comboBoxStage.ValueMember = "Id";
					this.comboBoxStage.DataSource = this.stages;
					this.comboBoxStage.SelectedValue = this.deal.StageId;

					// active users, plus the current owner when inactive.
					var users = LookupService.Users().Where(u => u.Active || u.Id == this.deal.OwnerId)
						.Select(u => new ListItem(u.Id, u.Name)).ToList();
					users.Insert(0, new ListItem(0, "(Unassigned)"));
					this.comboBoxOwner.DisplayMember = "Text";
					this.comboBoxOwner.ValueMember = "Id";
					this.comboBoxOwner.DataSource = users;
					this.comboBoxOwner.SelectedValue = this.deal.OwnerId ?? 0;

					this.textBoxTitle.Text = this.deal.Title ?? "";
					this.numericAmount.Value = Math.Min(this.numericAmount.Maximum, Math.Max(0, this.deal.Amount));
					this.dateTimePickerClose.Value = this.deal.ExpectedCloseDate == default ? DateTime.Today.AddDays(30) : this.deal.ExpectedCloseDate;
				}
				finally
				{
					this.loading = false;
				}
			}, "Loading the deal");
		}

		private int? SelectedId(ComboBox combo)
		{
			var id = combo.SelectedValue is int value ? value : 0;
			return id == 0 ? (int?)null : id;
		}

		private void LoadContacts()
		{
			var companyId = SelectedId(this.comboBoxCompany);
			var contacts = companyId == null ? LookupService.Contacts() : LookupService.Contacts(companyId);
			contacts.Insert(0, new ListItem(0, "(No contact)"));
			this.comboBoxContact.DisplayMember = "Text";
			this.comboBoxContact.ValueMember = "Id";
			this.comboBoxContact.DataSource = contacts;
		}

		private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.loading)
				return;

			// keep the contact when it belongs to the new company.
			var contactId = SelectedId(this.comboBoxContact);
			Notify.Try(LoadContacts, "Loading the contacts");
			this.comboBoxContact.SelectedValue = contactId ?? 0;
			if (this.comboBoxContact.SelectedIndex < 0)
				this.comboBoxContact.SelectedIndex = 0;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var title = this.textBoxTitle.Text.Trim();
			if (title.Length == 0)
			{
				this.errorProvider.SetError(this.textBoxTitle, "Enter a title.");
				this.textBoxTitle.Focus();
				return;
			}

			if (this.numericAmount.Value <= 0)
			{
				this.errorProvider.SetError(this.numericAmount, "The amount must be greater than zero.");
				this.numericAmount.Focus();
				return;
			}

			var stage = this.comboBoxStage.SelectedItem as StageItem;
			if (stage == null)
			{
				this.errorProvider.SetError(this.comboBoxStage, "Pick a stage.");
				return;
			}

			// moving the deal to Lost asks why.
			var lostReason = this.deal.LostReason;
			if (stage.IsLost && (stage.Id != this.deal.StageId || string.IsNullOrEmpty(lostReason)))
			{
				lostReason = LostReasonDialog.Ask(title);
				if (lostReason == null)
					return;
			}

			var wasWon = this.deal.Id != null && this.stages.Any(s => s.Id == this.deal.StageId && s.IsWon);

			this.deal.Title = title;
			this.deal.CompanyId = SelectedId(this.comboBoxCompany);
			this.deal.PrimaryContactId = SelectedId(this.comboBoxContact);
			this.deal.Amount = this.numericAmount.Value;
			this.deal.StageId = stage.Id;
			this.deal.ExpectedCloseDate = this.dateTimePickerClose.Value.Date;
			this.deal.OwnerId = SelectedId(this.comboBoxOwner);
			this.deal.LostReason = lostReason;

			var isNew = this.deal.Id == null;
			if (Notify.Try(() => this.deal.Id = DealService.Save(this.deal), "Saving the deal"))
			{
				if (stage.IsWon && !wasWon)
					Notify.Success("Deal won: " + title + " · " + Fmt.Money(this.deal.Amount));
				else
					Notify.Success(isNew ? "Deal created." : "Deal saved.");

				this.DialogResult = DialogResult.OK;
			}
		}

		private void textBoxTitle_TextChanged(object sender, EventArgs e)
		{
			this.errorProvider.SetError(this.textBoxTitle, "");
		}

		private void numericAmount_ValueChanged(object sender, EventArgs e)
		{
			this.errorProvider.SetError(this.numericAmount, "");
		}
	}
}
