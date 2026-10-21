using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RelayCrm.Dialogs;
using RelayCrm.Services;

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
		private readonly ObservableCollection<TimelineEntry> timeline = new ObservableCollection<TimelineEntry>();

		public CompanyDetailView()
		{
			InitializeComponent();

			this.listActivity.ItemsSource = this.timeline;
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
				this.runWebsite.Text = "";
				this.labelInitials.Text = "?";
				this.panelActions.IsEnabled = false;
				this.tabControl.IsEnabled = false;
				return;
			}

			ShowHeader();
			ShowKpis();
			ShowOverview();

			this.gridContacts.ItemsSource = contacts;
			this.gridDeals.ItemsSource = deals;
			this.gridTasks.ItemsSource = tasks;
			this.emptyContacts.Visibility = contacts.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
			this.emptyDeals.Visibility = deals.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
			this.emptyTasks.Visibility = tasks.Count == 0 ? Visibility.Visible : Visibility.Collapsed;

			this.tabContacts.Header = "Contacts (" + contacts.Count + ")";
			this.tabDeals.Header = "Deals (" + deals.Count + ")";
			this.tabActivity.Header = "Activity (" + this.activities.Count + ")";
			this.tabTasks.Header = "Tasks (" + tasks.Count(t => t.Status != "Done") + ")";

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
			this.labelInitials.Text = RelayCrm.Text.Initials(c.Name);
			this.labelName.Text = c.Name;

			var place = string.Join(", ", new[] { c.City, c.Country }.Where(s => !string.IsNullOrWhiteSpace(s)));
			this.runSubtitle.Text = string.Join(" · ", new[] { c.Industry, place }.Where(s => !string.IsNullOrWhiteSpace(s)));

			this.runWebsite.Text = string.IsNullOrWhiteSpace(c.Website) ? "No website" : DisplayUrl(c.Website);
			this.linkWebsite.IsEnabled = !string.IsNullOrWhiteSpace(c.Website);

			var tags = RelayCrm.Text.Tags(c.Tags);
			this.labelOwner.Text = "Owner: " + (string.IsNullOrEmpty(c.OwnerName) ? "No owner" : c.OwnerName)
				+ (tags.Length == 0 ? "" : "   ·   Tags: " + string.Join(", ", tags));
		}

		private void ShowKpis()
		{
			var c = this.company;

			this.kpiOpenPipeline.Show(Fmt.MoneyShort(c.OpenPipeline), c.OpenDeals == 1 ? "1 open deal" : c.OpenDeals + " open deals", null);
			this.kpiWonThisYear.Show(Fmt.MoneyShort(c.WonThisYear),
				(c.WonThisYearCount == 1 ? "1 deal won" : c.WonThisYearCount + " deals won") + " in " + DateTime.Today.Year, c.WonTrend);
			this.kpiContacts.Show(c.ContactCount.ToString(Fmt.Culture), c.ContactCount == 1 ? "person at this company" : "people at this company", null);
			this.kpiLastActivity.Show(c.LastActivity == null ? "Never" : Capitalize(Fmt.Relative(c.LastActivity)),
				c.LastActivity == null ? "No activity logged" : Fmt.DateAndTime(c.LastActivity.Value), null);
			this.kpiLastActivity.Tone = c.LastActivity == null || c.LastActivity < DateTime.Today.AddDays(-60) ? Tone.Warning : Tone.Neutral;
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
			this.timeline.Clear();
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
			foreach (var a in this.activities.Skip(this.timeline.Count).Take(TimelinePageSize))
			{
				var details = new List<string>();
				if (!string.IsNullOrWhiteSpace(a.Body))
					details.Add(a.Body);
				var who = string.Join(" · ", new[] { a.ContactName, string.IsNullOrEmpty(a.UserName) ? null : "by " + a.UserName }
					.Where(s => !string.IsNullOrWhiteSpace(s)));
				if (who.Length > 0)
					details.Add(who);

				this.timeline.Add(new TimelineEntry(a.Date, a.Type + ": " + a.Subject, string.Join("\n", details))
				{
					// planned activities stand out with the accent.
					TitleBrush = a.Date > now ? Tone.Primary.ToBrush() : SystemColors.ControlTextBrush,
					Tag = a.Id,
				});
			}
			this.buttonMore.Visibility = this.timeline.Count < this.activities.Count ? Visibility.Visible : Visibility.Collapsed;
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

		private void linkBack_Click(object sender, RoutedEventArgs e)
		{
			Navigator.Back();
		}

		private void linkWebsite_Click(object sender, RoutedEventArgs e)
		{
			UiHelper.OpenUrl(this.company?.Website);
		}

		private void buttonMore_Click(object sender, RoutedEventArgs e)
		{
			AppendTimeline();
		}

		private void buttonLogActivity_Click(object sender, RoutedEventArgs e)
		{
			if (LogActivityDialog.Log(companyId: this.companyId))
			{
				Reload();
				this.tabControl.SelectedItem = this.tabActivity;
			}
		}

		private void buttonNewContact_Click(object sender, RoutedEventArgs e)
		{
			if (ContactEditDialog.Edit(null, this.companyId))
			{
				Reload();
				this.tabControl.SelectedItem = this.tabContacts;
			}
		}

		private void buttonNewDeal_Click(object sender, RoutedEventArgs e)
		{
			if (DealEditDialog.Edit(null, this.companyId))
			{
				Reload();
				this.tabControl.SelectedItem = this.tabDeals;
			}
		}

		private void buttonAddTask_Click(object sender, RoutedEventArgs e)
		{
			if (TaskEditDialog.Edit(null, null, this.companyId))
			{
				Reload();
				Navigator.RefreshBadges();
				this.tabControl.SelectedItem = this.tabTasks;
			}
		}

		private void buttonEdit_Click(object sender, RoutedEventArgs e)
		{
			if (CompanyEditDialog.Edit(this.companyId))
				Reload();
		}

		private void buttonDelete_Click(object sender, RoutedEventArgs e)
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

		private void gridContacts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<CompanyContactRow>(e) is CompanyContactRow row)
				Navigator.OpenContact(row.Id);
		}

		private void gridDeals_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<CompanyDealRow>(e) is CompanyDealRow row && Navigator.OpenDeal(row.Id))
				Reload();
		}

		private void gridTasks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<CompanyTaskRow>(e) is CompanyTaskRow row && TaskEditDialog.Edit(row.Id))
			{
				Reload();
				Navigator.RefreshBadges();
			}
		}

		#endregion
	}
}
