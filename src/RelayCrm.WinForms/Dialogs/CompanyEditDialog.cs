using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RelayCrm.Data;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Creates or edits a company: name (required, unique warning), industry, size, website, phone,
	/// address, city, country, annual revenue, tags and owner.
	/// </summary>
	public partial class CompanyEditDialog : Form
	{
		private int? companyId;

		public CompanyEditDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Shows the dialog for a new company (null) or an existing one; returns true when it was saved.
		/// </summary>
		public static bool Edit(int? companyId)
		{
			using (var dialog = new CompanyEditDialog())
			{
				if (!dialog.LoadCompany(companyId))
					return false;
				return dialog.ShowDialog(Form.ActiveForm) == DialogResult.OK;
			}
		}

		private bool LoadCompany(int? id)
		{
			this.companyId = id;

			List<UserItem> users = null;
			List<string> tags = null;
			Company company = null;
			var loaded = Notify.Try(() =>
			{
				users = LookupService.Users(activeOnly: true);
				tags = LookupService.Tags();
				if (id != null)
					company = CompanyService.Get(id.Value);
			}, "Loading the company");
			if (!loaded)
				return false;

			if (id != null && company == null)
			{
				Notify.Warning("The company no longer exists.");
				return false;
			}

			// keep an inactive owner selectable on the companies they still own.
			if (company?.OwnerId != null && users.All(u => u.Id != company.OwnerId))
			{
				var owner = LookupService.User(company.OwnerId.Value);
				if (owner != null)
					users.Add(owner);
			}

			this.comboIndustry.Items.AddRange(LookupService.Industries);
			this.comboSize.Items.AddRange(LookupService.CompanySizes);
			this.comboOwner.DisplayMember = "Name";
			this.comboOwner.ValueMember = "Id";
			this.comboOwner.DataSource = users;

			var selectedTags = RelayCrm.Text.Tags(company?.Tags);
			foreach (var tag in tags.Union(selectedTags, StringComparer.OrdinalIgnoreCase))
				this.checkedListTags.Items.Add(tag, selectedTags.Contains(tag, StringComparer.OrdinalIgnoreCase));

			if (company == null)
			{
				this.Text = "New company";
				this.comboOwner.SelectedValue = CurrentUser.Id;
			}
			else
			{
				this.Text = "Edit company";
				this.textBoxName.Text = company.Name;
				this.comboIndustry.Text = company.Industry;
				this.comboSize.SelectedItem = company.Size;
				this.textBoxWebsite.Text = company.Website;
				this.textBoxPhone.Text = company.Phone;
				this.textBoxAddress.Text = company.Address;
				this.textBoxCity.Text = company.City;
				this.textBoxCountry.Text = company.Country;
				this.numericRevenue.Value = Math.Min(this.numericRevenue.Maximum, Math.Max(0, company.AnnualRevenue));
				if (company.OwnerId != null)
					this.comboOwner.SelectedValue = company.OwnerId.Value;
				else
					this.comboOwner.SelectedIndex = -1;
			}
			this.errorProvider.SetError(this.textBoxName, "");
			return true;
		}

		private bool CheckDuplicate()
		{
			var exists = false;
			Notify.Try(() => exists = CompanyService.NameExists(this.textBoxName.Text, this.companyId), "Checking the name");
			this.labelNameWarning.Visible = exists;
			return exists;
		}

		private void textBoxName_TextChanged(object sender, EventArgs e)
		{
			this.errorProvider.SetError(this.textBoxName, "");
			this.labelNameWarning.Visible = false;
		}

		private void textBoxName_Leave(object sender, EventArgs e)
		{
			CheckDuplicate();
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var name = this.textBoxName.Text.Trim();
			if (name.Length == 0)
			{
				this.errorProvider.SetError(this.textBoxName, "Enter the company name.");
				this.textBoxName.Focus();
				return;
			}

			if (CheckDuplicate() && !ConfirmDialog.Ask("Duplicate name", "A company named \"" + name + "\" already exists. Save anyway?", "Save"))
				return;

			var website = this.textBoxWebsite.Text.Trim();
			if (website.Length > 0 && !website.Contains("://"))
				website = "https://" + website;

			var values = new Company
			{
				Id = this.companyId ?? 0,
				Name = name,
				Industry = this.comboIndustry.Text.Trim(),
				Size = this.comboSize.SelectedItem as string,
				Website = website,
				Phone = this.textBoxPhone.Text.Trim(),
				Address = this.textBoxAddress.Text.Trim(),
				City = this.textBoxCity.Text.Trim(),
				Country = this.textBoxCountry.Text.Trim(),
				AnnualRevenue = this.numericRevenue.Value,
				Tags = string.Join(",", this.checkedListTags.CheckedItems.Cast<string>()),
				OwnerId = this.comboOwner.SelectedValue is int ownerId ? ownerId : (int?)null,
			};

			if (Notify.Try(() => CompanyService.Save(values), "Saving the company"))
			{
				Notify.Success(this.companyId == null ? "Company created." : "Company saved.");
				this.DialogResult = DialogResult.OK;
			}
		}
	}
}
