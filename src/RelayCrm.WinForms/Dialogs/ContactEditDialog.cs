using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RelayCrm.Data;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Creates or edits a contact: name, title, email (validated, with a duplicate warning), phone,
	/// company, lifecycle stage, lead source, owner and tags.
	/// </summary>
	public partial class ContactEditDialog : Form
	{
		private int contactId;

		public ContactEditDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Shows the dialog; returns true when the contact was saved.
		/// </summary>
		/// <param name="contactId">The contact to edit, or null for a new contact.</param>
		/// <param name="companyId">Company preselected for a new contact.</param>
		public static bool Edit(int? contactId, int? companyId = null)
		{
			using (var dialog = new ContactEditDialog())
			{
				if (!dialog.LoadData(contactId, companyId))
					return false;
				return dialog.ShowDialog(Form.ActiveForm) == DialogResult.OK;
			}
		}

		private bool LoadData(int? contactId, int? companyId)
		{
			Contact contact = null;
			List<ListItem> companies = null;
			List<UserItem> users = null;
			List<string> tags = null;
			var loaded = Notify.Try(() =>
			{
				companies = LookupService.Companies();
				users = LookupService.Users(activeOnly: true);
				tags = LookupService.Tags();
				if (contactId != null)
					contact = ContactService.Get(contactId.Value);
			}, "Loading the contact");

			if (!loaded)
				return false;
			if (contactId != null && contact == null)
			{
				Notify.Warning("The contact no longer exists.");
				return false;
			}

			companies.Insert(0, new ListItem(0, "(No company)"));
			this.comboBoxCompany.DisplayMember = "Text";
			this.comboBoxCompany.ValueMember = "Id";
			this.comboBoxCompany.DataSource = companies;

			// keep an inactive owner of an existing contact selectable.
			if (contact?.OwnerId != null && users.All(u => u.Id != contact.OwnerId))
			{
				var owner = LookupService.User(contact.OwnerId.Value);
				if (owner != null)
					users.Add(owner);
			}
			users.Insert(0, new UserItem { Id = 0, Name = "(Unassigned)" });
			this.comboBoxOwner.DisplayMember = "Name";
			this.comboBoxOwner.ValueMember = "Id";
			this.comboBoxOwner.DataSource = users;

			this.comboBoxLeadSource.Items.AddRange(LookupService.LeadSources);
			this.labelTagsHint.Text = tags.Count == 0 ? "" : "Existing tags: " + string.Join(", ", tags);

			if (contact == null)
			{
				this.Text = "New contact";
				this.comboBoxStage.SelectedIndex = (int)LifecycleStage.Lead;
				this.comboBoxCompany.SelectedValue = companyId ?? 0;
				this.comboBoxOwner.SelectedValue = CurrentUser.IsSignedIn ? CurrentUser.Id : 0;
			}
			else
			{
				this.contactId = contact.Id;
				this.Text = "Edit contact";
				this.textBoxFirstName.Text = contact.FirstName ?? "";
				this.textBoxLastName.Text = contact.LastName ?? "";
				this.textBoxTitle.Text = contact.Title ?? "";
				this.textBoxEmail.Text = contact.Email ?? "";
				this.textBoxPhone.Text = contact.Phone ?? "";
				this.textBoxTags.Text = contact.Tags ?? "";
				this.comboBoxStage.SelectedIndex = (int)contact.Stage;
				this.comboBoxLeadSource.Text = contact.LeadSource ?? "";
				this.comboBoxCompany.SelectedValue = contact.CompanyId ?? 0;
				this.comboBoxOwner.SelectedValue = contact.OwnerId ?? 0;
			}
			return true;
		}

		private static int? NullIfZero(object value)
		{
			var id = value is int i ? i : 0;
			return id == 0 ? (int?)null : id;
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (!ContactService.HasName(this.textBoxFirstName.Text, this.textBoxLastName.Text))
			{
				this.errorProvider.SetError(this.textBoxFirstName, "Enter a first or last name.");
				this.textBoxFirstName.Focus();
				return;
			}

			var email = this.textBoxEmail.Text.Trim();
			if (!ContactService.IsValidEmail(email))
			{
				this.errorProvider.SetError(this.textBoxEmail, "Enter a valid email address, like name@company.com.");
				this.textBoxEmail.Focus();
				return;
			}

			string usedBy = null;
			if (!Notify.Try(() => usedBy = ContactService.EmailUsedBy(email, this.contactId == 0 ? (int?)null : this.contactId), "Checking the email"))
				return;
			if (usedBy != null
				&& !ConfirmDialog.Ask("Email already in use", usedBy.Trim() + " already uses " + email + ". Save this contact anyway?", "Save anyway"))
			{
				this.textBoxEmail.Focus();
				return;
			}

			var contact = new Contact
			{
				Id = this.contactId,
				FirstName = this.textBoxFirstName.Text,
				LastName = this.textBoxLastName.Text,
				Title = this.textBoxTitle.Text,
				Email = email,
				Phone = this.textBoxPhone.Text,
				CompanyId = NullIfZero(this.comboBoxCompany.SelectedValue),
				Stage = (LifecycleStage)Math.Max(0, this.comboBoxStage.SelectedIndex),
				LeadSource = this.comboBoxLeadSource.Text,
				OwnerId = NullIfZero(this.comboBoxOwner.SelectedValue),
				Tags = this.textBoxTags.Text,
			};

			if (Notify.Try(() => ContactService.Save(contact), "Saving the contact"))
			{
				Notify.Success(this.contactId == 0 ? "Contact created." : "Contact saved.");
				this.DialogResult = DialogResult.OK;
			}
		}

		private void textBoxName_TextChanged(object sender, EventArgs e)
		{
			this.errorProvider.SetError(this.textBoxFirstName, "");
		}

		private void textBoxEmail_TextChanged(object sender, EventArgs e)
		{
			this.errorProvider.SetError(this.textBoxEmail, "");
		}
	}
}
