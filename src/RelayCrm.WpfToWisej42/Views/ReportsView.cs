using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Controls;
using RelayCrm.Services;
using Wisej.Web;
using ChartSeries = RelayCrm.Controls.ChartSeries;

namespace RelayCrm.Views
{
	/// <summary>
	/// Reports page: sales forecast, win/loss analysis, activity per user and lead source conversion.
	/// Each report shows a chart and a table with the same numbers, and exports the table to CSV.
	/// </summary>
	/// <remarks>
	/// The axis of the forecast chart takes a .NET format ("C0") instead of Fmt.MoneyShort.
	/// </remarks>
	public partial class ReportsView : UserControl, IRefreshable
	{
		private readonly bool[] loaded = new bool[4];

		/// <summary>Header summary of each report, kept while switching between them.</summary>
		private readonly string[] summaries = new string[4];

		private bool ready;

		public ReportsView()
		{
			InitializeComponent();

			ConfigureCharts();
			GridHelper.UseConverters(this.gridForecast);
			GridHelper.UseConverters(this.gridWinLoss);
			GridHelper.UseConverters(this.gridReasons);
			GridHelper.UseConverters(this.gridActivity);
			GridHelper.UseConverters(this.gridLeadSource);
			this.ready = true;
			ShowReport(this.tabReports.SelectedIndex);
		}

		/// <summary>Reloads the report on show; the others reload when they are selected.</summary>
		public void RefreshData()
		{
			Array.Clear(this.loaded, 0, this.loaded.Length);
			ShowReport(this.tabReports.SelectedIndex);
		}

		private void ConfigureCharts()
		{
			this.chartForecast.AxisFormat = "C0";
			this.chartForecast.ValueFormat = v => Fmt.Money((decimal)v);
			this.chartForecast.PointClick += chartForecast_PointClick;
			this.chartWinLoss.PointClick += chartWinLoss_PointClick;
			this.chartReasons.EmptyText = "No lost deals";
			this.chartActivity.EmptyText = "No activities";
		}

		private void ShowReport(int index)
		{
			if (!this.ready)
				return;
			if (index < 0)
				index = 0;

			if (!this.loaded[index])
			{
				switch (index)
				{
					case 0: this.loaded[index] = Notify.Try(LoadForecast, "Loading the sales forecast"); break;
					case 1: this.loaded[index] = Notify.Try(LoadWinLoss, "Loading the win/loss analysis"); break;
					case 2: this.loaded[index] = Notify.Try(LoadActivity, "Loading the activity report"); break;
					case 3: this.loaded[index] = Notify.Try(LoadLeadSources, "Loading the lead source report"); break;
				}
			}

			this.labelSummary.Text = this.summaries[index] ?? "";
		}

		/// <summary>"1 deal", "80 deals".</summary>
		private static string Plural(int count, string noun, string plural = null)
		{
			return count.ToString("N0", Fmt.Culture) + " " + (count == 1 ? noun : plural ?? noun + "s");
		}

		private string ScopeText => CurrentUser.SeesAll ? "" : " Showing your records.";

		private void LoadForecast()
		{
			var rows = ReportService.SalesForecast();
			this.gridForecast.DataSource = rows;

			this.chartForecast.SetData(rows.Select(r => r.MonthStart.ToString("MMM", Fmt.Culture)), rows,
				new ChartSeries("Pipeline", ChartColors.Neutral, rows.Select(r => (double)r.Pipeline)),
				new ChartSeries("Weighted", ChartColors.Indigo, rows.Select(r => (double)r.Weighted)));

			this.summaries[0] = Plural(rows.Sum(r => r.Deals), "open deal") + " · " + Fmt.MoneyShort(rows.Sum(r => r.Pipeline));
			this.labelForecastDescription.Text =
				"Open deals by expected close month for the next " + ReportService.ForecastMonths + " months; weighted = amount × probability. " +
				"Weighted total " + Fmt.Money(rows.Sum(r => r.Weighted)) + " of " + Fmt.Money(rows.Sum(r => r.Pipeline)) + "." + this.ScopeText;
		}

		private void LoadWinLoss()
		{
			var rows = ReportService.WinLoss(out List<LostReasonRow> reasons);
			this.gridWinLoss.DataSource = rows;
			this.gridReasons.DataSource = reasons;

			this.chartWinLoss.SetData(rows.Select(r => r.MonthStart.ToString("MMM yy", Fmt.Culture)), rows,
				new ChartSeries("Won", ChartColors.Indigo, rows.Select(r => (double)r.Won)),
				new ChartSeries("Lost", ChartColors.Neutral, rows.Select(r => (double)r.Lost)));

			this.chartReasons.SetData(reasons.Select(r => r.Reason), reasons,
				new ChartSeries("Lost deals", ChartColors.Indigo, reasons.Select(r => (double)r.Deals)));

			var totalWon = rows.Sum(r => r.Won);
			var totalLost = rows.Sum(r => r.Lost);
			this.summaries[1] = Plural(totalWon + totalLost, "closed deal") + " · " + ReportService.WinLossMonths + " months";
			this.labelWinLossDescription.Text =
				"Deals won and lost per month over the last " + ReportService.WinLossMonths + " months: " + totalWon + " won, " + totalLost + " lost" +
				(totalWon + totalLost > 0 ? " (win rate " + Fmt.Percent(totalWon * 100d / (totalWon + totalLost)) + ")." : ".") + this.ScopeText;
		}

		private void LoadActivity()
		{
			var rows = ReportService.ActivityPerUser();
			this.gridActivity.DataSource = rows;

			this.chartActivity.SetData(rows.Select(r => r.User), rows,
				new ChartSeries("Calls", ChartColors.Indigo, rows.Select(r => (double)r.Calls)),
				new ChartSeries("Emails", ChartColors.Sky, rows.Select(r => (double)r.Emails)),
				new ChartSeries("Meetings", ChartColors.Emerald, rows.Select(r => (double)r.Meetings)),
				new ChartSeries("Notes", ChartColors.Amber, rows.Select(r => (double)r.Notes)));

			this.summaries[2] = Plural(rows.Sum(r => r.Total), "activity", "activities") + " · " + Plural(rows.Count, "user");
			this.labelActivityDescription.Text =
				"Calls, emails, meetings and notes logged by each user in the last " + ReportService.ActivityDays + " days: " +
				rows.Sum(r => r.Total) + " activities." + this.ScopeText;
		}

		private void LoadLeadSources()
		{
			var rows = ReportService.LeadSourceConversion();
			this.gridLeadSource.DataSource = rows;

			this.chartLeadSource.SetData(rows.Select(r => r.Source), rows,
				new ChartSeries("Contacts", ChartColors.Neutral, rows.Select(r => (double)r.Contacts)),
				new ChartSeries("Customers", ChartColors.Indigo, rows.Select(r => (double)r.Customers)));

			var total = rows.Sum(r => r.Contacts);
			var converted = rows.Sum(r => r.Customers);
			this.summaries[3] = Plural(total, "contact") + " · " + Plural(rows.Count, "source");
			this.labelLeadSourceDescription.Text =
				"Contacts per lead source and how many became customers: " + converted + " of " + total +
				(total > 0 ? " (" + Fmt.Percent(converted * 100d / total) + ")." : ".") + this.ScopeText;
		}

		private void tabReports_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowReport(this.tabReports.SelectedIndex);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			switch (this.tabReports.SelectedIndex)
			{
				case 1: CsvExport.Save(this.gridWinLoss, "win-loss-analysis.csv"); break;
				case 2: CsvExport.Save(this.gridActivity, "activity-per-user.csv"); break;
				case 3: CsvExport.Save(this.gridLeadSource, "lead-source-conversion.csv"); break;
				default: CsvExport.Save(this.gridForecast, "sales-forecast.csv"); break;
			}
		}

		private void chartForecast_PointClick(object sender, ChartPointEventArgs e)
		{
			if (!(e.Tag is ForecastRow row))
				return;

			// the current month also holds the overdue deals: open the list from the past.
			var first = row.MonthStart == new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
			Navigator.OpenDeals(new DealFilter
			{
				OpenOnly = true,
				OwnerId = CurrentUser.SeesAll ? (int?)null : CurrentUser.Id,
				CloseFrom = first ? (DateTime?)null : row.MonthStart,
				CloseTo = row.MonthStart.AddMonths(1).AddDays(-1),
				Caption = "Open deals closing " + (first ? "by the end of " : "in ") + row.MonthStart.ToString("MMMM yyyy", Fmt.Culture),
			});
		}

		private void chartWinLoss_PointClick(object sender, ChartPointEventArgs e)
		{
			if (!(e.Tag is WinLossRow row))
				return;

			var won = e.SeriesIndex == 0;
			Navigator.OpenDeals(new DealFilter
			{
				WonOnly = won,
				OwnerId = CurrentUser.SeesAll ? (int?)null : CurrentUser.Id,
				CloseFrom = row.MonthStart,
				CloseTo = row.MonthStart.AddMonths(1).AddDays(-1),
				Caption = (won ? "Won in " : "Deals closing in ") + row.MonthStart.ToString("MMMM yyyy", Fmt.Culture),
			});
		}
	}
}
