using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using RelayCrm.Services;
using Wisej.Web;

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
			DialogHelper.KeepOpenOnAccept(this);
		}

		/// <summary>
		/// Shows the dialog; returns true when the deal was saved.
		/// </summary>
		/// <param name="dealId">The deal to edit, or null for a new deal.</param>
		/// <param name="companyId">Company preselected for a new deal.</param>
		/// <param name="contactId">Primary contact preselected for a new deal.</param>
		public static bool Edit(int? dealId, int? companyId = null, int? contactId = null)
		{
			var dialog = new DealEditDialog();
			if (!dialog.LoadDeal(dealId, companyId, contactId))
			{
				dialog.Dispose();
				return false;
			}
			return DialogHelper.ShowModal(dialog);
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
					this.comboBoxCompany.DataSource = companies;
					this.comboBoxCompany.SelectedValue = this.deal.CompanyId ?? 0;

					LoadContacts();
					this.comboBoxContact.SelectedValue = this.deal.PrimaryContactId ?? 0;
					if (this.comboBoxContact.SelectedIndex < 0)
						this.comboBoxContact.SelectedIndex = 0;

					this.comboBoxStage.DataSource = this.stages;
					this.comboBoxStage.SelectedValue = this.deal.StageId;

					// active users, plus the current owner when inactive.
					var users = LookupService.Users().Where(u => u.Active || u.Id == this.deal.OwnerId)
						.Select(u => new ListItem(u.Id, u.Name)).ToList();
					users.Insert(0, new ListItem(0, "Unassigned"));
					this.comboBoxOwner.DataSource = users;
					this.comboBoxOwner.SelectedValue = this.deal.OwnerId ?? 0;

					this.textBoxTitle.Text = this.deal.Title ?? "";
					this.textBoxAmount.Text = this.deal.Amount > 0 ? this.deal.Amount.ToString("N0", Fmt.Culture) : "";
					this.datePickerClose.NullableValue = this.deal.ExpectedCloseDate == default ? DateTime.Today.AddDays(30) : this.deal.ExpectedCloseDate;
				}
				finally
				{
					this.loading = false;
				}

				this.Load += (s, e) => this.textBoxTitle.Focus();
			}, "Loading the deal");
		}

		private void LoadContacts()
		{
			var companyId = DialogHelper.SelectedId(this.comboBoxCompany);
			var contacts = companyId == null ? LookupService.Contacts() : LookupService.Contacts(companyId);
			contacts.Insert(0, new ListItem(0, "(No contact)"));
			this.comboBoxContact.DataSource = contacts;
		}

		private void comboBoxCompany_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.loading || this.comboBoxContact == null)
				return;

			// keep the contact when it belongs to the new company.
			var contactId = DialogHelper.SelectedId(this.comboBoxContact);
			Notify.Try(LoadContacts, "Loading the contacts");
			this.comboBoxContact.SelectedValue = contactId ?? 0;
			if (this.comboBoxContact.SelectedIndex < 0)
				this.comboBoxContact.SelectedIndex = 0;
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			DialogHelper.ClearError(this.labelError);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var title = this.textBoxTitle.Text.Trim();
			if (title.Length == 0)
			{
				DialogHelper.ShowError(this.labelError, "Enter a title.", this.textBoxTitle);
				return;
			}

			if (!decimal.TryParse(this.textBoxAmount.Text.Trim().TrimStart('$'), NumberStyles.Number, Fmt.Culture, out var amount) || amount <= 0)
			{
				DialogHelper.ShowError(this.labelError, "The amount must be a number greater than zero.", this.textBoxAmount);
				return;
			}

			if (!(this.comboBoxStage.SelectedItem is StageItem stage))
			{
				DialogHelper.ShowError(this.labelError, "Pick a stage.", this.comboBoxStage);
				return;
			}

			if (this.datePickerClose.NullableValue == null)
			{
				DialogHelper.ShowError(this.labelError, "Enter the expected close date.", this.datePickerClose);
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
			this.deal.CompanyId = DialogHelper.SelectedId(this.comboBoxCompany);
			this.deal.PrimaryContactId = DialogHelper.SelectedId(this.comboBoxContact);
			this.deal.Amount = amount;
			this.deal.StageId = stage.Id;
			this.deal.ExpectedCloseDate = this.datePickerClose.NullableValue.Value.Date;
			this.deal.OwnerId = DialogHelper.SelectedId(this.comboBoxOwner);
			this.deal.LostReason = lostReason;

			var isNew = this.deal.Id == null;
			if (Notify.Try(() => this.deal.Id = DealService.Save(this.deal), "Saving the deal"))
			{
				if (stage.IsWon && !wasWon)
					Notify.Success("🎉 Deal won: " + title + " · " + Fmt.Money(this.deal.Amount));
				else
					Notify.Success(isNew ? "Deal created." : "Deal saved.");

				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
