using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// The page of one company: header with actions, KPIs, and tabs with its overview, contacts,
	/// deals, activity timeline and tasks.
	/// </summary>
	public partial class CompanyDetailView : UserControl
	{
		private const int TimelinePageSize = 30;

		private int companyId;
		private CompanyDetail company;
		private List<CompanyActivityRow> activities = new List<CompanyActivityRow>();
		private int activitiesShown;

		public CompanyDetailView()
		{
			InitializeComponent();

			foreach (Control kpi in this.flexKpis.Controls)
				this.flexKpis.SetFillWeight(kpi, 1);

			this.colContactStage.ToneMap["Lead"] = ChipTone.Neutral;
			this.colContactStage.ToneMap["Prospect"] = ChipTone.Warning;
			this.colContactStage.ToneMap["Customer"] = ChipTone.Success;
			this.colContactStage.ToneMap["Churned"] = ChipTone.Danger;

			this.colTaskStatus.ToneMap["Open"] = ChipTone.Neutral;
			this.colTaskStatus.ToneMap["Due soon"] = ChipTone.Warning;
			this.colTaskStatus.ToneMap["Overdue"] = ChipTone.Danger;
			this.colTaskStatus.ToneMap["Done"] = ChipTone.Success;
		}

		/// <summary>
		/// Shows the company <paramref name="companyId"/>.
		/// </summary>
		public void LoadCompany(int companyId)
		{
			this.companyId = companyId;

			List<StageItem> stages = null;
			List<CompanyContactRow> contacts = null;
			List<CompanyDealRow> deals = null;
			List<CompanyTaskRow> tasks = null;
			var loaded = Notify.Try(() =>
			{
				this.company = CompanyService.Detail(companyId);
				if (this.company == null)
					return;
				stages = LookupService.Stages();
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
				this.labelSubtitle.Text = "";
				this.linkWebsite.Text = "";
				this.flexActions.Enabled = false;
				return;
			}

			ShowHeader();
			ShowKpis();
			ShowOverview();

			foreach (var stage in stages)
				this.colDealStage.ToneMap[stage.Name] = stage.IsWon ? ChipTone.Success : stage.IsLost ? ChipTone.Danger : ChipTone.Primary;

			this.gridContacts.DataSource = contacts;
			this.gridDeals.DataSource = deals;
			this.gridTasks.DataSource = tasks;
			this.emptyContacts.RefreshTarget();
			this.emptyDeals.RefreshTarget();
			this.emptyTasks.RefreshTarget();

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
			this.avatarCompany.Text = RelayCrm.Text.Initials(c.Name);
			this.labelName.Text = c.Name;

			var place = string.Join(", ", new[] { c.City, c.Country }.Where(s => !string.IsNullOrWhiteSpace(s)));
			this.labelSubtitle.Text = string.Join(" · ", new[] { c.Industry, place }.Where(s => !string.IsNullOrWhiteSpace(s)));

			this.linkWebsite.Text = string.IsNullOrWhiteSpace(c.Website) ? "No website" : DisplayUrl(c.Website);
			this.linkWebsite.Enabled = !string.IsNullOrWhiteSpace(c.Website);
			FitHeader();

			this.avatarOwner.Text = string.IsNullOrEmpty(c.OwnerName) ? "?" : RelayCrm.Text.Initials(c.OwnerName);
			this.avatarOwner.Label = string.IsNullOrEmpty(c.OwnerName) ? "No owner" : c.OwnerName;

			// tag chips are created from the data, next to the name.
			foreach (var chip in this.flexTags.Controls.OfType<ChipLabel>().ToList())
				chip.Dispose();
			foreach (var tag in RelayCrm.Text.Tags(c.Tags))
			{
				this.flexTags.Controls.Add(new ChipLabel
				{
					Text = tag,
					Tone = ChipTone.Primary,
					Variant = ChipVariant.Soft,
					ChipSize = ChipSize.Small,
					AutoSize = true,
				});
			}
		}

		private void ShowKpis()
		{
			var c = this.company;

			this.kpiOpenPipeline.Value = Fmt.MoneyShort(c.OpenPipeline);
			this.kpiOpenPipeline.Caption = c.OpenDeals == 1 ? "1 open deal" : c.OpenDeals + " open deals";

			this.kpiWonThisYear.Value = Fmt.MoneyShort(c.WonThisYear);
			this.kpiWonThisYear.Caption = (c.WonThisYearCount == 1 ? "1 deal won" : c.WonThisYearCount + " deals won") + " in " + DateTime.Today.Year;
			this.kpiWonThisYear.SparklineValues = c.WonTrend;

			this.kpiContacts.Value = c.ContactCount.ToString(Fmt.Culture);
			this.kpiContacts.Caption = c.ContactCount == 1 ? "person at this company" : "people at this company";

			this.kpiLastActivity.Value = c.LastActivity == null ? "Never" : Capitalize(Fmt.Relative(c.LastActivity));
			this.kpiLastActivity.Caption = c.LastActivity == null ? "No activity logged" : Fmt.DateAndTime(c.LastActivity.Value);
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
			this.textBoxCreated.Text = Fmt.Date(c.CreatedAt);
			this.textBoxUpdated.Text = Fmt.Relative(c.UpdatedAt) + " (" + Fmt.Date(c.UpdatedAt) + ")";
		}

		private void ShowTimeline()
		{
			this.timeline.Items.Clear();
			this.activitiesShown = 0;
			AppendTimeline();

			var past = this.activities.Count(a => a.Date <= DateTime.Now);
			var planned = this.activities.Count - past;
			this.labelActivityCount.Text = this.activities.Count == 0
				? "No activities yet"
				: past + (past == 1 ? " activity" : " activities") + (planned > 0 ? ", " + planned + " planned" : "");
		}

		private void AppendTimeline()
		{
			var now = DateTime.Now;
			foreach (var a in this.activities.Skip(this.activitiesShown).Take(TimelinePageSize))
			{
				var details = new List<string>();
				if (!string.IsNullOrWhiteSpace(a.Body))
					details.Add(a.Body);
				var who = string.Join(" · ", new[] { a.ContactName, string.IsNullOrEmpty(a.UserName) ? null : "by " + a.UserName }
					.Where(s => !string.IsNullOrWhiteSpace(s)));
				if (who.Length > 0)
					details.Add(who);

				this.timeline.Items.Add(new TimelineItem(a.Date, a.Type + ": " + a.Subject)
				{
					Description = string.Join("\n", details),
					Icon = ActivityLogService.Icon(a.Type),
					// planned activities stand out with the accent.
					Tone = a.Date > now ? TimelineTone.Primary : TimelineTone.Neutral,
					Tag = a.Id,
				});
				this.activitiesShown++;
			}
			this.timeline.HasMoreItems = this.activitiesShown < this.activities.Count;
		}

		/// <summary>
		/// Shows the website next to the subtitle only when both fit beside the actions
		/// (the Overview tab always shows it).
		/// </summary>
		private void FitHeader()
		{
			// about 7.5 px per character of 14 px text, plus the gap.
			var needed = (this.labelSubtitle.Text.Length + this.linkWebsite.Text.Length) * 7.5 + 12;
			this.linkWebsite.Visible = needed <= this.flexSubtitle.Width;
		}

		private void flexSubtitle_Resize(object sender, EventArgs e)
		{
			FitHeader();
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
			Application.Navigate(url, "_blank");
		}

		private void buttonLogActivity_Click(object sender, EventArgs e)
		{
			if (LogActivityDialog.Show(companyId: this.companyId))
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
			if (e.RowIndex >= 0 && this.gridContacts.Rows[e.RowIndex].DataBoundItem is CompanyContactRow row)
				Navigator.OpenContact(row.Id);
		}

		private void gridDeals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && this.gridDeals.Rows[e.RowIndex].DataBoundItem is CompanyDealRow row)
			{
				if (Navigator.OpenDeal(row.Id))
					Reload();
			}
		}

		private void gridTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && this.gridTasks.Rows[e.RowIndex].DataBoundItem is CompanyTaskRow row)
			{
				if (TaskEditDialog.Edit(row.Id))
				{
					Reload();
					Navigator.RefreshBadges();
				}
			}
		}

		private void timeline_LoadMore(object sender, EventArgs e)
		{
			AppendTimeline();
		}

		#endregion
	}
}
