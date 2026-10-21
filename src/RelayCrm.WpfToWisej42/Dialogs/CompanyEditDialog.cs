using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Creates or edits a company: name (required, unique warning), industry, size, website, phone,
	/// address, city, country, annual revenue, tags and owner.
	/// </summary>
	/// <remarks>
	/// The tags were an ItemsControl with a CheckBox template bound to <see cref="TagChoice"/>: they are now
	/// check boxes added to a FlowLayoutPanel that write their state back to the TagChoice.
	/// </remarks>
	public partial class CompanyEditDialog : Form
	{
		/// <summary>A tag with its check box.</summary>
		public class TagChoice
		{
			public string Name { get; set; }
			public bool Selected { get; set; }
		}

		private int? companyId;
		private List<TagChoice> tags = new List<TagChoice>();

		public CompanyEditDialog()
		{
			InitializeComponent();
			DialogHelper.KeepOpenOnAccept(this);
		}

		/// <summary>
		/// Shows the dialog for a new company (null) or an existing one; returns true when it was saved.
		/// </summary>
		public static bool Edit(int? companyId)
		{
			var dialog = new CompanyEditDialog();
			if (!dialog.LoadCompany(companyId))
			{
				dialog.Dispose();
				return false;
			}
			return DialogHelper.ShowModal(dialog);
		}

		private bool LoadCompany(int? id)
		{
			this.companyId = id;

			List<UserItem> users = null;
			List<string> allTags = null;
			Company company = null;
			var loaded = Notify.Try(() =>
			{
				users = LookupService.Users(activeOnly: true);
				allTags = LookupService.Tags();
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

			this.comboIndustry.DataSource = LookupService.Industries;
			this.comboSize.DataSource = LookupService.CompanySizes;
			this.comboOwner.DataSource = users;

			var selectedTags = RelayCrm.Text.Tags(company?.Tags);
			this.tags = allTags.Union(selectedTags, StringComparer.OrdinalIgnoreCase)
				.Select(t => new TagChoice { Name = t, Selected = selectedTags.Contains(t, StringComparer.OrdinalIgnoreCase) })
				.ToList();
			this.listTags.Controls.Clear();
			foreach (var tag in this.tags)
			{
				// the item template: a check box bound to Name and Selected.
				var check = new CheckBox { AutoSize = true, Text = tag.Name, Checked = tag.Selected, Margin = new Padding(0, 2, 14, 2) };
				check.CheckedChanged += (s, e) => tag.Selected = check.Checked;
				this.listTags.Controls.Add(check);
			}

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
				this.textBoxRevenue.Text = company.AnnualRevenue > 0 ? company.AnnualRevenue.ToString("N0", Fmt.Culture) : "";
				if (company.OwnerId != null)
					this.comboOwner.SelectedValue = company.OwnerId.Value;
				else
					this.comboOwner.SelectedIndex = -1;
			}
			this.labelNameWarning.Visible = false;
			this.Load += (s, e) => this.textBoxName.Focus();
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
			DialogHelper.ClearError(this.labelError);
			if (this.labelNameWarning != null)
				this.labelNameWarning.Visible = false;
		}

		private void textBoxName_LostFocus(object sender, EventArgs e)
		{
			CheckDuplicate();
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			DialogHelper.ClearError(this.labelError);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			var name = this.textBoxName.Text.Trim();
			if (name.Length == 0)
			{
				DialogHelper.ShowError(this.labelError, "Enter the company name.", this.textBoxName);
				return;
			}

			var revenueText = this.textBoxRevenue.Text.Trim().TrimStart('$');
			decimal revenue = 0;
			if (revenueText.Length > 0
				&& (!decimal.TryParse(revenueText, NumberStyles.Number, Fmt.Culture, out revenue) || revenue < 0))
			{
				DialogHelper.ShowError(this.labelError, "Enter the annual revenue as a positive number, like 2,500,000.", this.textBoxRevenue);
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
				AnnualRevenue = revenue,
				Tags = string.Join(",", this.tags.Where(t => t.Selected).Select(t => t.Name)),
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
