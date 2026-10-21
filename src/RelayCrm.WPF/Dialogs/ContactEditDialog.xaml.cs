using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using RelayCrm.Data;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Creates or edits a contact: name, title, email (validated, with a duplicate warning), phone,
	/// company, lifecycle stage, lead source, owner and tags.
	/// </summary>
	public partial class ContactEditDialog : Window
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
			var dialog = new ContactEditDialog();
			if (!dialog.LoadData(contactId, companyId))
				return false;
			return DialogHelper.ShowModal(dialog);
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
			this.comboBoxCompany.ItemsSource = companies;

			// keep an inactive owner of an existing contact selectable.
			if (contact?.OwnerId != null && users.All(u => u.Id != contact.OwnerId))
			{
				var owner = LookupService.User(contact.OwnerId.Value);
				if (owner != null)
					users.Add(owner);
			}
			users.Insert(0, new UserItem { Id = 0, Name = "(Unassigned)" });
			this.comboBoxOwner.ItemsSource = users;

			this.comboBoxStage.ItemsSource = Enum.GetValues(typeof(LifecycleStage));
			this.comboBoxLeadSource.ItemsSource = LookupService.LeadSources;
			this.labelTagsHint.Text = tags.Count == 0 ? "" : "Existing tags: " + string.Join(", ", tags);

			if (contact == null)
			{
				this.Title = "New contact";
				this.comboBoxStage.SelectedItem = LifecycleStage.Lead;
				this.comboBoxCompany.SelectedValue = companyId ?? 0;
				this.comboBoxOwner.SelectedValue = CurrentUser.IsSignedIn ? CurrentUser.Id : 0;
			}
			else
			{
				this.contactId = contact.Id;
				this.Title = "Edit contact";
				this.textBoxFirstName.Text = contact.FirstName ?? "";
				this.textBoxLastName.Text = contact.LastName ?? "";
				this.textBoxTitle.Text = contact.Title ?? "";
				this.textBoxEmail.Text = contact.Email ?? "";
				this.textBoxPhone.Text = contact.Phone ?? "";
				this.textBoxTags.Text = contact.Tags ?? "";
				this.comboBoxStage.SelectedItem = contact.Stage;
				this.comboBoxLeadSource.Text = contact.LeadSource ?? "";
				this.comboBoxCompany.SelectedValue = contact.CompanyId ?? 0;
				this.comboBoxOwner.SelectedValue = contact.OwnerId ?? 0;
			}
			if (this.comboBoxCompany.SelectedIndex < 0)
				this.comboBoxCompany.SelectedIndex = 0;

			this.Loaded += (s, e) => this.textBoxFirstName.Focus();
			return true;
		}

		private void buttonSave_Click(object sender, RoutedEventArgs e)
		{
			if (!ContactService.HasName(this.textBoxFirstName.Text, this.textBoxLastName.Text))
			{
				DialogHelper.ShowError(this.labelError, "Enter a first or last name.", this.textBoxFirstName);
				return;
			}

			var email = this.textBoxEmail.Text.Trim();
			if (!ContactService.IsValidEmail(email))
			{
				DialogHelper.ShowError(this.labelError, "Enter a valid email address, like name@company.com.", this.textBoxEmail);
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
				CompanyId = DialogHelper.SelectedId(this.comboBoxCompany),
				Stage = this.comboBoxStage.SelectedItem is LifecycleStage stage ? stage : LifecycleStage.Lead,
				LeadSource = this.comboBoxLeadSource.Text,
				OwnerId = DialogHelper.SelectedId(this.comboBoxOwner),
				Tags = this.textBoxTags.Text,
			};

			if (Notify.Try(() => ContactService.Save(contact), "Saving the contact"))
			{
				Notify.Success(this.contactId == 0 ? "Contact created." : "Contact saved.");
				this.DialogResult = true;
			}
		}

		private void textBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			DialogHelper.ClearError(this.labelError);
		}
	}
}
