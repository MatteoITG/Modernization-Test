using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// Reports page: sales forecast, win/loss analysis, activity per user and lead source conversion.
	/// Each report shows a chart and a table with the same numbers, and exports the table to CSV.
	/// </summary>
	public partial class ReportsView : UserControl, IRefreshable
	{
		// money axes: "$800K" (the trailing comma of the format divides by 1000).
		private const string ThousandsAxis = "$#,##0,K";

		private readonly bool[] loaded = new bool[4];

		/// <summary>Header summary of each report, kept while switching between them.</summary>
		private readonly string[] summaries = new string[4];

		public ReportsView()
		{
			InitializeComponent();

			foreach (var grid in new[] { this.gridForecast, this.gridWinLoss, this.gridReasons, this.gridActivity, this.gridLeadSource })
			{
				grid.AutoGenerateColumns = false;
				grid.DefaultCellStyle.FormatProvider = Fmt.Culture;
			}
			IconImages.Apply(this.toolStrip);

			ConfigureCharts();
		}

		/// <summary>Reloads the report on show; the others reload when they are selected.</summary>
		public void RefreshData()
		{
			Array.Clear(this.loaded, 0, this.loaded.Length);
			ShowReport(this.tabControl.SelectedIndex);
		}

		private void ConfigureCharts()
		{
			ChartStyle.Apply(this.chartForecast, ThousandsAxis);
			ChartStyle.Apply(this.chartWinLoss);
			ChartStyle.Apply(this.chartReasons);
			ChartStyle.Apply(this.chartActivity);
			ChartStyle.Apply(this.chartLeadSource);

			foreach (var series in this.chartForecast.Series)
				series.ToolTip = "#SERIESNAME, #VALX: #VAL{C0}";
			foreach (var chart in new[] { this.chartWinLoss, this.chartReasons, this.chartActivity, this.chartLeadSource })
			{
				foreach (var series in chart.Series)
					series.ToolTip = "#SERIESNAME, #VALX: #VAL{N0}";
			}
		}

		private void ShowReport(int index)
		{
			if (index < 0)
				index = 0;

			if (!this.loaded[index])
			{
				System.Windows.Forms.Cursor.Current = Cursors.WaitCursor;
				switch (index)
				{
					case 0: this.loaded[index] = Notify.Try(LoadForecast, "Loading the sales forecast"); break;
					case 1: this.loaded[index] = Notify.Try(LoadWinLoss, "Loading the win/loss analysis"); break;
					case 2: this.loaded[index] = Notify.Try(LoadActivity, "Loading the activity report"); break;
					case 3: this.loaded[index] = Notify.Try(LoadLeadSources, "Loading the lead source report"); break;
				}
				System.Windows.Forms.Cursor.Current = Cursors.Default;
			}

			this.labelSummary.Text = this.tabControl.TabPages[index].Text + (this.summaries[index] == null ? "" : ":  " + this.summaries[index]);
		}

		/// <summary>"1 deal", "80 deals".</summary>
		private static string Plural(int count, string noun, string plural = null)
		{
			return count.ToString("N0", Fmt.Culture) + " " + (count == 1 ? noun : plural ?? noun + "s");
		}

		private string ScopeText => CurrentUser.SeesAll ? "" : " Showing your records.";

		private static void AddPoint(Series series, string category, double value, object tag)
		{
			series.Points[series.Points.AddXY(category, value)].Tag = tag;
		}

		private void LoadForecast()
		{
			var rows = ReportService.SalesForecast();
			this.gridForecast.DataSource = rows;

			ChartStyle.Clear(this.chartForecast);
			foreach (var row in rows)
			{
				var category = row.MonthStart.ToString("MMM", Fmt.Culture);
				AddPoint(this.chartForecast.Series[0], category, (double)row.Pipeline, row);
				AddPoint(this.chartForecast.Series[1], category, (double)row.Weighted, row);
			}
			ChartStyle.SetMaximum(this.chartForecast, ChartColors.NiceMax(rows.Select(r => (double)r.Pipeline)));

			this.summaries[0] = Plural(rows.Sum(r => r.Deals), "open deal") + " · " + Fmt.MoneyShort(rows.Sum(r => r.Pipeline));
			this.labelForecastDescription.Text =
				"Open deals by expected close month for the next " + ReportService.ForecastMonths + " months; weighted = amount × probability. " +
				"Weighted total " + Fmt.Money(rows.Sum(r => r.Weighted)) + " of " + Fmt.Money(rows.Sum(r => r.Pipeline)) + "." + this.ScopeText +
				" Click a column to see its deals.";
		}

		private void LoadWinLoss()
		{
			List<LostReasonRow> reasons;
			var rows = ReportService.WinLoss(out reasons);
			this.gridWinLoss.DataSource = rows;
			this.gridReasons.DataSource = reasons;

			ChartStyle.Clear(this.chartWinLoss);
			foreach (var row in rows)
			{
				var category = row.MonthStart.ToString("MMM yy", Fmt.Culture);
				AddPoint(this.chartWinLoss.Series[0], category, row.Won, row);
				AddPoint(this.chartWinLoss.Series[1], category, row.Lost, row);
			}
			ChartStyle.SetMaximum(this.chartWinLoss, ChartColors.NiceMax(rows.SelectMany(r => new[] { (double)r.Won, (double)r.Lost }), true));

			ChartStyle.Clear(this.chartReasons);
			foreach (var reason in reasons.AsEnumerable().Reverse())
				AddPoint(this.chartReasons.Series[0], reason.Reason, reason.Deals, reason);
			ChartStyle.SetMaximum(this.chartReasons, ChartColors.NiceMax(reasons.Select(r => (double)r.Deals), true));

			var totalWon = rows.Sum(r => r.Won);
			var totalLost = rows.Sum(r => r.Lost);
			this.summaries[1] = Plural(totalWon + totalLost, "closed deal") + " · " + ReportService.WinLossMonths + " months";
			this.labelWinLossDescription.Text =
				"Deals won and lost per month over the last " + ReportService.WinLossMonths + " months: " + totalWon + " won, " + totalLost + " lost" +
				(totalWon + totalLost > 0 ? " (win rate " + Fmt.Percent(totalWon * 100d / (totalWon + totalLost)) + ")." : ".") + this.ScopeText +
				" Click a column to see its deals.";
		}

		private void LoadActivity()
		{
			var rows = ReportService.ActivityPerUser();
			this.gridActivity.DataSource = rows;

			ChartStyle.Clear(this.chartActivity);
			foreach (var row in rows.AsEnumerable().Reverse())
			{
				AddPoint(this.chartActivity.Series[0], row.User, row.Calls, row);
				AddPoint(this.chartActivity.Series[1], row.User, row.Emails, row);
				AddPoint(this.chartActivity.Series[2], row.User, row.Meetings, row);
				AddPoint(this.chartActivity.Series[3], row.User, row.Notes, row);
			}
			ChartStyle.SetMaximum(this.chartActivity, ChartColors.NiceMax(rows.Select(r => (double)r.Total), true));

			this.summaries[2] = Plural(rows.Sum(r => r.Total), "activity", "activities") + " · " + Plural(rows.Count, "user");
			this.labelActivityDescription.Text =
				"Calls, emails, meetings and notes logged by each user in the last " + ReportService.ActivityDays + " days: " +
				rows.Sum(r => r.Total) + " activities." + this.ScopeText;
		}

		private void LoadLeadSources()
		{
			var rows = ReportService.LeadSourceConversion();
			this.gridLeadSource.DataSource = rows;

			ChartStyle.Clear(this.chartLeadSource);
			foreach (var row in rows)
			{
				AddPoint(this.chartLeadSource.Series[0], row.Source, row.Contacts, row);
				AddPoint(this.chartLeadSource.Series[1], row.Source, row.Customers, row);
			}

			var total = rows.Sum(r => r.Contacts);
			var converted = rows.Sum(r => r.Customers);
			ChartStyle.SetMaximum(this.chartLeadSource, ChartColors.NiceMax(rows.Select(r => (double)r.Contacts), true));
			this.summaries[3] = Plural(total, "contact") + " · " + Plural(rows.Count, "source");
			this.labelLeadSourceDescription.Text =
				"Contacts per lead source and how many became customers: " + converted + " of " + total +
				(total > 0 ? " (" + Fmt.Percent(converted * 100d / total) + ")." : ".") + this.ScopeText;
		}

		private void ReportsView_Load(object sender, EventArgs e)
		{
			if (this.DesignMode)
				return;

			ShowReport(this.tabControl.SelectedIndex);
		}

		private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowReport(this.tabControl.SelectedIndex);
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			switch (this.tabControl.SelectedIndex)
			{
				case 1: CsvExport.Save(this.gridWinLoss, "win-loss-analysis.csv"); break;
				case 2: CsvExport.Save(this.gridActivity, "activity-per-user.csv"); break;
				case 3: CsvExport.Save(this.gridLeadSource, "lead-source-conversion.csv"); break;
				default: CsvExport.Save(this.gridForecast, "sales-forecast.csv"); break;
			}
		}

		private void chart_MouseMove(object sender, MouseEventArgs e)
		{
			ChartStyle.UpdateCursor((Chart)sender, e.Location);
		}

		private void chart_MouseClick(object sender, MouseEventArgs e)
		{
			var point = ChartStyle.PointAt((Chart)sender, e.Location, out var seriesIndex);
			var scope = CurrentUser.SeesAll ? (int?)null : CurrentUser.Id;

			if (point?.Tag is ForecastRow forecast)
			{
				// the current month also holds the overdue deals: open the list from the past.
				var first = forecast.MonthStart == new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
				Navigator.OpenDeals(new DealFilter
				{
					OpenOnly = true,
					OwnerId = scope,
					CloseFrom = first ? (DateTime?)null : forecast.MonthStart,
					CloseTo = forecast.MonthStart.AddMonths(1).AddDays(-1),
					Caption = "Open deals closing " + (first ? "by the end of " : "in ") + forecast.MonthStart.ToString("MMMM yyyy", Fmt.Culture),
				});
			}
			else if (point?.Tag is WinLossRow winLoss)
			{
				var won = seriesIndex == 0;
				Navigator.OpenDeals(new DealFilter
				{
					WonOnly = won,
					OwnerId = scope,
					CloseFrom = winLoss.MonthStart,
					CloseTo = winLoss.MonthStart.AddMonths(1).AddDays(-1),
					Caption = (won ? "Won in " : "Deals closing in ") + winLoss.MonthStart.ToString("MMMM yyyy", Fmt.Culture),
				});
			}
		}
	}
}
