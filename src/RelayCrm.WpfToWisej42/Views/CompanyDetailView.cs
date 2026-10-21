using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// The page of one company: header with actions, KPIs, and tabs with its overview, contacts,
	/// deals, activity timeline and tasks.
	/// </summary>
	/// <remarks>
	/// Migration step 2: the round initials label became an Avatar, the KpiTile user controls KpiPanel cards, the HTML
	/// activity list a Timeline (its "Load more" button replaces the "Show more" button), the empty labels EmptyStates,
	/// and the grids got avatar, chip and meter columns.
	/// </remarks>
	public partial class CompanyDetailView : UserControl
	{
		private const int TimelinePageSize = 30;

		private int companyId;
		private CompanyDetail company;
		private List<CompanyActivityRow> activities = new List<CompanyActivityRow>();

		public CompanyDetailView()
		{
			InitializeComponent();
			GridHelper.UseConverters(this.gridContacts);
			GridHelper.UseConverters(this.gridDeals);
			GridHelper.UseConverters(this.gridTasks);
			ToneExtensions.AddStageTones(this.colContactStage.ToneMap);
			ToneExtensions.AddTaskStatusTones(this.colTaskStatus.ToneMap);
			ToneExtensions.AddPriorityTones(this.colTaskPriority.ToneMap);
			Notify.Try(() =>
			{
				foreach (var stage in LookupService.Stages())
					this.colDealStage.ToneMap[stage.Name] = ToneExtensions.DealStageTone(stage.IsWon, stage.IsLost).ToChip();
			}, "Loading the stages");
		}

		/// <summary>
		/// Shows the company <paramref name="companyId"/>.
		/// </summary>
		public void LoadCompany(int companyId)
		{
			this.companyId = companyId;

			List<CompanyContactRow> contacts = null;
			List<CompanyDealRow> deals = null;
			List<CompanyTaskRow> tasks = null;
			var loaded = Notify.Try(() =>
			{
				this.company = CompanyService.Detail(companyId);
				if (this.company == null)
					return;
				contacts = CompanyService.Contacts(companyId);
				deals = CompanyService.Deals(companyId);
				this.activities = CompanyService.Activities(companyId);
				tasks = CompanyService.Tasks(companyId);
			}, "Loading the company");

			if (!loaded)
				return;

			if (this.company == null)
			{
				Notify.Warning("The company no longer exists.");
				this.labelName.Text = "Company not found";
				this.runSubtitle.Text = "";
				this.linkWebsite.Text = "";
				this.avatar.Text = "?";
				this.panelActions.Enabled = false;
				this.tabControl.Enabled = false;
				return;
			}

			ShowHeader();
			ShowKpis();
			ShowOverview();

			this.gridContacts.DataSource = contacts;
			this.gridDeals.DataSource = deals;
			this.gridTasks.DataSource = tasks;
			this.emptyContacts.Visible = contacts.Count == 0;
			this.emptyDeals.Visible = deals.Count == 0;
			this.emptyTasks.Visible = tasks.Count == 0;

			this.tabContacts.Text = "Contacts (" + contacts.Count + ")";
			this.tabDeals.Text = "Deals (" + deals.Count + ")";
			this.tabActivity.Text = "Activity (" + this.activities.Count + ")";
			this.tabTasks.Text = "Tasks (" + tasks.Count(t => t.Status != "Done") + ")";

			ShowTimeline();
		}

		private void Reload()
		{
			LoadCompany(this.companyId);
		}

		#region Display

		private void ShowHeader()
		{
			var c = this.company;
			this.avatar.Text = c.Name;
			this.avatar.ImageSource = Avatars.Source(c.Name, SettingsService.AvatarPalette[c.Id % SettingsService.AvatarPalette.Length], rounded: true);
			this.labelName.Text = c.Name;

			var place = string.Join(", ", new[] { c.City, c.Country }.Where(s => !string.IsNullOrWhiteSpace(s)));
			this.runSubtitle.Text = string.Join(" · ", new[] { c.Industry, place }.Where(s => !string.IsNullOrWhiteSpace(s)));

			this.linkWebsite.Text = string.IsNullOrWhiteSpace(c.Website) ? "No website" : DisplayUrl(c.Website);
			this.linkWebsite.Enabled = !string.IsNullOrWhiteSpace(c.Website);

			var tags = RelayCrm.Text.Tags(c.Tags);
			this.labelOwner.Text = "Owner: " + (string.IsNullOrEmpty(c.OwnerName) ? "No owner" : c.OwnerName)
				+ (tags.Length == 0 ? "" : "   ·   Tags: " + string.Join(", ", tags));
		}

		private void ShowKpis()
		{
			var c = this.company;

			this.kpiOpenPipeline.Value = Fmt.MoneyShort(c.OpenPipeline);
			this.kpiOpenPipeline.Caption = c.OpenDeals == 1 ? "1 open deal" : c.OpenDeals + " open deals";

			this.kpiWonThisYear.Value = Fmt.MoneyShort(c.WonThisYear);
			this.kpiWonThisYear.Caption = (c.WonThisYearCount == 1 ? "1 deal won" : c.WonThisYearCount + " deals won") + " in " + DateTime.Today.Year;
			this.kpiWonThisYear.SparklineValues = c.WonTrend ?? new double[0];

			this.kpiContacts.Value = c.ContactCount.ToString(Fmt.Culture);
			this.kpiContacts.Caption = c.ContactCount == 1 ? "person at this company" : "people at this company";

			this.kpiLastActivity.Value = c.LastActivity == null ? "Never" : Capitalize(Fmt.Relative(c.LastActivity));
			this.kpiLastActivity.Caption = c.LastActivity == null ? "No activity logged" : Fmt.DateAndTime(c.LastActivity.Value);
			// no activity for two months: the account needs attention.
			this.kpiLastActivity.Tone = c.LastActivity == null || c.LastActivity < DateTime.Today.AddDays(-60) ? KpiTone.Warning : KpiTone.Neutral;
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
			this.textBoxTags.Text = string.Join(", ", RelayCrm.Text.Tags(c.Tags));
			this.textBoxUpdated.Text = Fmt.Relative(c.UpdatedAt) + " (" + Fmt.Date(c.UpdatedAt) + "), created " + Fmt.Date(c.CreatedAt);
		}

		private void ShowTimeline()
		{
			this.timelineActivity.Items.Clear();
			AppendTimeline();

			var past = this.activities.Count(a => a.Date <= DateTime.Now);
			var planned = this.activities.Count - past;
			this.labelActivityCount.Text = this.activities.Count == 0
				? "No activities yet"
				: past + (past == 1 ? " activity" : " activities") + (planned > 0 ? ", " + planned + " planned" : "");
		}

		// adds the next page of activities to the timeline.
		private void AppendTimeline()
		{
			var now = DateTime.Now;
			foreach (var a in this.activities.Skip(this.timelineActivity.Items.Count).Take(TimelinePageSize))
			{
				var details = new List<string>();
				if (!string.IsNullOrWhiteSpace(a.Body))
					details.Add(a.Body);
				var who = string.Join(" · ", new[] { a.ContactName, string.IsNullOrEmpty(a.UserName) ? null : "by " + a.UserName }
					.Where(s => !string.IsNullOrWhiteSpace(s)));
				if (who.Length > 0)
					details.Add(who);

				this.timelineActivity.Items.Add(new TimelineItem
				{
					Time = a.Date,
					Title = a.Type + ": " + a.Subject,
					Description = string.Join(" · ", details),
					Icon = ActivityLogService.Icon(a.Type),
					// planned activities stand out with the accent.
					Tone = a.Date > now ? TimelineTone.Primary : TimelineTone.Neutral,
					Tag = a.Id,
				});
			}
			this.timelineActivity.HasMoreItems = this.timelineActivity.Items.Count < this.activities.Count;
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
			UiHelper.OpenUrl(this.company?.Website);
		}

		private void timelineActivity_LoadMore(object sender, EventArgs e)
		{
			AppendTimeline();
		}

		private void buttonLogActivity_Click(object sender, EventArgs e)
		{
			if (LogActivityDialog.Log(companyId: this.companyId))
			{
				Reload();
				this.tabControl.SelectedTab = this.tabActivity;
			}
		}

		private void buttonNewContact_Click(object sender, EventArgs e)
		{
			if (ContactEditDialog.Edit(null, this.companyId))
			{
				Reload();
				this.tabControl.SelectedTab = this.tabContacts;
			}
		}

		private void buttonNewDeal_Click(object sender, EventArgs e)
		{
			if (DealEditDialog.Edit(null, this.companyId))
			{
				Reload();
				this.tabControl.SelectedTab = this.tabDeals;
			}
		}

		private void buttonAddTask_Click(object sender, EventArgs e)
		{
			if (TaskEditDialog.Edit(null, null, this.companyId))
			{
				Reload();
				Navigator.RefreshBadges();
				this.tabControl.SelectedTab = this.tabTasks;
			}
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (CompanyEditDialog.Edit(this.companyId))
				Reload();
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
			if (UiHelper.RowItem<CompanyContactRow>(this.gridContacts, e) is CompanyContactRow row)
				Navigator.OpenContact(row.Id);
		}

		private void gridDeals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (UiHelper.RowItem<CompanyDealRow>(this.gridDeals, e) is CompanyDealRow row && Navigator.OpenDeal(row.Id))
				Reload();
		}

		private void gridTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (UiHelper.RowItem<CompanyTaskRow>(this.gridTasks, e) is CompanyTaskRow row && TaskEditDialog.Edit(row.Id))
			{
				Reload();
				Navigator.RefreshBadges();
			}
		}

		#endregion
	}
}
