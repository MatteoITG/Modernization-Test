using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// The page of one company: header with actions, KPIs, and tabs with its overview, contacts,
	/// deals, activities and tasks.
	/// </summary>
	public partial class CompanyDetailView : UserControl, IRefreshable
	{
		private int companyId;
		private CompanyDetail company;
		private List<StageItem> stages = new List<StageItem>();

		public CompanyDetailView()
		{
			InitializeComponent();

			this.gridContacts.AutoGenerateColumns = false;
			this.gridDeals.AutoGenerateColumns = false;
			this.gridTasks.AutoGenerateColumns = false;
			this.gridDeals.DefaultCellStyle.FormatProvider = Fmt.Culture;
			this.gridTasks.DefaultCellStyle.FormatProvider = Fmt.Culture;

			IconImages.Apply(this.toolStrip);
			IconImages.Apply(this.contactsStrip);
			IconImages.Apply(this.dealsStrip);
			IconImages.Apply(this.activityStrip);
			IconImages.Apply(this.tasksStrip);
			this.listViewActivity.SmallImageList = IconImages.List(16, "telephone", "envelope", "people", "sticky");
		}

		/// <summary>
		/// Shows the company <paramref name="companyId"/>.
		/// </summary>
		public void LoadCompany(int companyId)
		{
			this.companyId = companyId;

			List<CompanyContactRow> contacts = null;
			List<CompanyDealRow> deals = null;
			List<CompanyActivityRow> activities = null;
			List<CompanyTaskRow> tasks = null;
			var loaded = Notify.Try(() =>
			{
				this.company = CompanyService.Detail(companyId);
				if (this.company == null)
					return;
				this.stages = LookupService.Stages();
				contacts = CompanyService.Contacts(companyId);
				deals = CompanyService.Deals(companyId);
				activities = CompanyService.Activities(companyId);
				tasks = CompanyService.Tasks(companyId);
			}, "Loading the company");

			if (!loaded)
				return;

			if (this.company == null)
			{
				Notify.Warning("The company no longer exists.");
				this.labelName.Text = "Company not found";
				this.flowSubtitle.Visible = false;
				this.tabControl.Enabled = false;
				foreach (ToolStripItem item in this.toolStrip.Items)
					item.Enabled = false;
				return;
			}

			ShowHeader();
			ShowKpis();
			ShowOverview();

			this.gridContacts.DataSource = contacts;
			this.gridDeals.DataSource = deals;
			this.gridTasks.DataSource = tasks;
			this.labelNoContacts.Visible = contacts.Count == 0;
			this.labelNoDeals.Visible = deals.Count == 0;
			this.labelNoTasks.Visible = tasks.Count == 0;

			this.tabContacts.Text = "Contacts (" + contacts.Count + ")";
			this.tabDeals.Text = "Deals (" + deals.Count + ")";
			this.tabActivity.Text = "Activity (" + activities.Count + ")";
			this.tabTasks.Text = "Tasks (" + tasks.Count(t => t.Status != "Done") + ")";

			ShowActivities(activities);
		}

		/// <summary>Reloads the company (F5).</summary>
		public void RefreshData()
		{
			LoadCompany(this.companyId);
		}

		#region Display

		private void ShowHeader()
		{
			var c = this.company;
			this.labelName.Text = c.Name;
			var old = this.pictureAvatar.Image;
			this.pictureAvatar.Image = Avatars.Create(c.Name, SettingsService.AvatarPalette[c.Id % SettingsService.AvatarPalette.Length],
				this.LogicalToDeviceUnits(52));
			old?.Dispose();

			var place = string.Join(", ", new[] { c.City, c.Country }.Where(s => !string.IsNullOrWhiteSpace(s)));
			this.labelSubtitle.Text = string.Join(" · ", new[] { c.Industry, place }.Where(s => !string.IsNullOrWhiteSpace(s)));

			this.linkWebsite.Text = string.IsNullOrWhiteSpace(c.Website) ? "No website" : DisplayUrl(c.Website);
			this.linkWebsite.Enabled = !string.IsNullOrWhiteSpace(c.Website);
			this.labelOwner.Text = "Owner: " + (string.IsNullOrEmpty(c.OwnerName) ? "none" : c.OwnerName);

			var tags = RelayCrm.Text.Tags(c.Tags);
			this.labelTags.Text = string.Join(", ", tags);
			this.labelTags.Visible = this.labelDot3.Visible = tags.Length > 0;
		}

		private void ShowKpis()
		{
			var c = this.company;

			this.labelOpenPipelineValue.Text = Fmt.MoneyShort(c.OpenPipeline);
			this.labelOpenPipelineCaption.Text = c.OpenDeals == 1 ? "1 open deal" : c.OpenDeals + " open deals";

			this.labelWonThisYearValue.Text = Fmt.MoneyShort(c.WonThisYear);
			this.labelWonThisYearCaption.Text = (c.WonThisYearCount == 1 ? "1 deal won" : c.WonThisYearCount + " deals won") + " in " + DateTime.Today.Year;

			this.labelContactsValue.Text = c.ContactCount.ToString(Fmt.Culture);
			this.labelContactsCaption.Text = c.ContactCount == 1 ? "person at this company" : "people at this company";

			this.labelLastActivityValue.Text = c.LastActivity == null ? "Never" : Capitalize(Fmt.Relative(c.LastActivity));
			this.labelLastActivityCaption.Text = c.LastActivity == null ? "No activity logged" : Fmt.DateAndTime(c.LastActivity.Value);
			// no activity for two months: the account needs attention.
			this.labelLastActivityValue.ForeColor = c.LastActivity == null || c.LastActivity < DateTime.Today.AddDays(-60)
				? Tone.Warning.ToColor()
				: this.ForeColor;
		}

		private void ShowOverview()
		{
			var c = this.company;
			this.textBoxIndustry.Text = c.Industry;
			this.textBoxSize.Text = c.Size;
			this.textBoxRevenue.Text = c.AnnualRevenue > 0 ? Fmt.Money(c.AnnualRevenue) : "";
			this.textBoxWebsite.Text = c.Website;
			this.textBoxPhone.Text = c.Phone;
			this.textBoxOwner.Text = c.OwnerName;
			this.textBoxAddress.Text = c.Address;
			this.textBoxCity.Text = c.City;
			this.textBoxCountry.Text = c.Country;
			this.textBoxTagList.Text = string.Join(", ", RelayCrm.Text.Tags(c.Tags));
			this.textBoxCreated.Text = Fmt.Date(c.CreatedAt);
			this.textBoxUpdated.Text = Fmt.Relative(c.UpdatedAt) + " (" + Fmt.Date(c.UpdatedAt) + ")";
		}

		private void ShowActivities(List<CompanyActivityRow> activities)
		{
			var now = DateTime.Now;
			this.listViewActivity.BeginUpdate();
			this.listViewActivity.Items.Clear();
			foreach (var a in activities)
			{
				var item = new ListViewItem(Fmt.DateAndTime(a.Date), Icons.NameOf(ActivityLogService.Icon(a.Type))) { Tag = a.Id };
				item.SubItems.Add(a.Type.ToString());
				item.SubItems.Add(a.Subject ?? "");
				item.SubItems.Add(a.ContactName ?? "");
				item.SubItems.Add(a.UserName ?? "");
				item.SubItems.Add((a.Body ?? "").Replace("\r", " ").Replace("\n", " "));
				item.ToolTipText = a.Body;
				// planned activities stand out.
				if (a.Date > now)
					item.ForeColor = Tone.Primary.ToColor();
				this.listViewActivity.Items.Add(item);
			}
			this.listViewActivity.EndUpdate();
			this.labelNoActivity.Visible = activities.Count == 0;

			var past = activities.Count(a => a.Date <= now);
			var planned = activities.Count - past;
			this.labelActivityCount.Text = activities.Count == 0
				? "No activities yet"
				: past + (past == 1 ? " activity" : " activities") + (planned > 0 ? ", " + planned + " planned" : "");
		}

		private static string DisplayUrl(string url)
		{
			var text = url.Trim();
			var scheme = text.IndexOf("://", StringComparison.Ordinal);
			if (scheme >= 0)
				text = text.Substring(scheme + 3);
			return text.TrimEnd('/');
		}

		private static string Capitalize(string text)
		{
			return string.IsNullOrEmpty(text) ? text : char.ToUpperInvariant(text[0]) + text.Substring(1);
		}

		#endregion

		#region Handlers

		private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Navigator.Back();
		}

		private void linkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var url = this.company?.Website;
			if (string.IsNullOrWhiteSpace(url))
				return;
			if (!url.Contains("://"))
				url = "https://" + url;
			Notify.Try(() => Process.Start(new ProcessStartInfo(url) { UseShellExecute = true }), "Opening the website");
		}

		private void buttonLogActivity_Click(object sender, EventArgs e)
		{
			if (LogActivityDialog.Show(companyId: this.companyId))
			{
				RefreshData();
				this.tabControl.SelectedTab = this.tabActivity;
			}
		}

		private void buttonNewContact_Click(object sender, EventArgs e)
		{
			if (ContactEditDialog.Edit(null, this.companyId))
			{
				RefreshData();
				this.tabControl.SelectedTab = this.tabContacts;
			}
		}

		private void buttonNewDeal_Click(object sender, EventArgs e)
		{
			if (DealEditDialog.Edit(null, this.companyId))
			{
				RefreshData();
				this.tabControl.SelectedTab = this.tabDeals;
			}
		}

		private void buttonAddTask_Click(object sender, EventArgs e)
		{
			if (TaskEditDialog.Edit(null, null, this.companyId))
			{
				RefreshData();
				Navigator.RefreshBadges();
				this.tabControl.SelectedTab = this.tabTasks;
			}
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (CompanyEditDialog.Edit(this.companyId))
				RefreshData();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (this.company == null)
				return;

			var message = "Delete " + this.company.Name + "? Its contacts, deals, activities and tasks are kept but no longer linked to a company.";
			if (!ConfirmDialog.Ask("Delete company", message, "Delete"))
				return;

			if (Notify.Try(() => CompanyService.Delete(this.companyId), "Deleting the company"))
			{
				Notify.Success(this.company.Name + " deleted.");
				Navigator.RefreshBadges();
				Navigator.Back();
			}
		}

		private void gridContacts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = GridHelper.RowAt<CompanyContactRow>(this.gridContacts, e.RowIndex);
			if (row != null)
				Navigator.OpenContact(row.Id);
		}

		private void gridContacts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex == this.colContactStage.Index)
				e.CellStyle.ForeColor = ToneExtensions.StageTone(e.Value as string).ToColor();
		}

		private void gridDeals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = GridHelper.RowAt<CompanyDealRow>(this.gridDeals, e.RowIndex);
			if (row != null && Navigator.OpenDeal(row.Id) && !this.IsDisposed)
				RefreshData();
		}

		private void gridDeals_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex != this.colDealStage.Index)
				return;

			var stage = this.stages.FirstOrDefault(s => s.Name == e.Value as string);
			if (stage != null)
				e.CellStyle.ForeColor = ToneExtensions.DealStageTone(stage.IsWon, stage.IsLost).ToColor();
		}

		private void gridTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = GridHelper.RowAt<CompanyTaskRow>(this.gridTasks, e.RowIndex);
			if (row != null && TaskEditDialog.Edit(row.Id))
			{
				RefreshData();
				Navigator.RefreshBadges();
			}
		}

		private void gridTasks_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex != this.colTaskStatus.Index)
				return;

			switch (e.Value as string)
			{
				case "Overdue": e.CellStyle.ForeColor = Tone.Danger.ToColor(); break;
				case "Due soon": e.CellStyle.ForeColor = Tone.Warning.ToColor(); break;
				case "Done": e.CellStyle.ForeColor = Tone.Success.ToColor(); break;
			}
		}

		#endregion
	}
}
