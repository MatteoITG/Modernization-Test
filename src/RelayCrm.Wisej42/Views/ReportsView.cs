using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// Reports page: sales forecast, win/loss analysis, activity per user and lead source conversion.
	/// Each report shows a chart and a table with the same numbers, and exports the table to CSV.
	/// </summary>
	public partial class ReportsView : UserControl, IRefreshable
	{
		// the charts format axis ticks with the .NET standard formats only (no compact "$200K").
		private const string CurrencyAxis = "C0";

		// whole dollars ("$2,000,000") do not fit the value axis: the forecast plots thousands, the tooltips show "$854K".
		private const double Thousand = 1000d;

		private readonly bool[] loaded = new bool[4];

		/// <summary>Header summary of each report, kept while switching between them.</summary>
		private readonly string[] summaries = new string[4];

		public ReportsView()
		{
			InitializeComponent();

			foreach (var grid in new[] { this.gridForecast, this.gridWinLoss, this.gridReasons, this.gridActivity, this.gridLeadSource })
				grid.DefaultCellStyle.FormatProvider = Fmt.Culture;

			ConfigureCharts();
		}

		/// <summary>Reloads the report on show; the others reload when they are selected.</summary>
		public void RefreshData()
		{
			Array.Clear(this.loaded, 0, this.loaded.Length);
			ShowReport(this.segmentedReport.SelectedIndex);
		}

		private void ConfigureCharts()
		{
			foreach (var chart in new[] { this.chartForecast, this.chartWinLoss, this.chartReasons, this.chartActivity, this.chartLeadSource })
			{
				chart.Palette = ChartColors.Palette;
				chart.YAxis.Gridlines = true;
			}

			// forecast: total in neutral grey behind the weighted value in the accent.
			this.chartForecast.YAxis.Format = CurrencyAxis;
			this.chartForecast.YAxis.Min = 0;
			this.chartForecast.YAxis.Title = "$ thousands";
			this.chartForecast.Series[0].Color = ChartColors.Neutral;
			this.chartForecast.Series[1].Color = ChartColors.Indigo;

			// win/loss counts: won in the accent, lost in neutral grey.
			this.chartWinLoss.YAxis.Format = "N0";
			this.chartWinLoss.Series[0].Color = ChartColors.Indigo;
			this.chartWinLoss.Series[1].Color = ChartColors.Neutral;
			this.chartReasons.YAxis.Format = "N0";
			this.chartReasons.Series[0].Color = ChartColors.Indigo;

			// activity types in the fixed categorical order.
			this.chartActivity.YAxis.Format = "N0";
			this.chartActivity.Series[0].Color = ChartColors.Indigo;
			this.chartActivity.Series[1].Color = ChartColors.Sky;
			this.chartActivity.Series[2].Color = ChartColors.Emerald;
			this.chartActivity.Series[3].Color = ChartColors.Amber;

			this.chartLeadSource.YAxis.Format = "N0";
			this.chartLeadSource.Series[0].Color = ChartColors.Neutral;
			this.chartLeadSource.Series[1].Color = ChartColors.Indigo;
		}

		private void ShowReport(int index)
		{
			if (index < 0)
				index = 0;

			this.panelForecast.Visible = index == 0;
			this.panelWinLoss.Visible = index == 1;
			this.panelActivity.Visible = index == 2;
			this.panelLeadSource.Visible = index == 3;

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

			this.labelSummary.Text = this.summaries[index] ?? "Reports";
		}

		/// <summary>Horizontal bars leave about 80 pixels to the category labels: longer ones are cut with an ellipsis (the table shows them in full).</summary>
		private static string Shorten(string text, int length)
		{
			return text == null || text.Length <= length ? text : text.Substring(0, length - 1).TrimEnd() + "…";
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

			var total = this.chartForecast.Series[0];
			var weighted = this.chartForecast.Series[1];
			total.Points.Clear();
			weighted.Points.Clear();
			foreach (var row in rows)
			{
				var category = row.MonthStart.ToString("MMM", Fmt.Culture);
				total.Points.Add(new ChartPoint { Category = category, Value = (double)row.Pipeline / Thousand, Tag = row });
				weighted.Points.Add(new ChartPoint { Category = category, Value = (double)row.Weighted / Thousand, Tag = row });
			}

			this.chartForecast.YAxis.Max = ChartColors.NiceMax(rows.Select(r => (double)r.Pipeline / Thousand));
			this.summaries[0] = Plural(rows.Sum(r => r.Deals), "open deal") + " · " + Fmt.MoneyShort(rows.Sum(r => r.Pipeline));

			this.labelForecastDescription.Text =
				"Open deals by expected close month for the next " + ReportService.ForecastMonths + " months; weighted = amount × probability. " +
				"Weighted total " + Fmt.Money(rows.Sum(r => r.Weighted)) + " of " + Fmt.Money(rows.Sum(r => r.Pipeline)) + "." + this.ScopeText;
		}

		private void LoadWinLoss()
		{
			List<LostReasonRow> reasons;
			var rows = ReportService.WinLoss(out reasons);
			this.gridWinLoss.DataSource = rows;
			this.gridReasons.DataSource = reasons;

			var won = this.chartWinLoss.Series[0];
			var lost = this.chartWinLoss.Series[1];
			won.Points.Clear();
			lost.Points.Clear();
			foreach (var row in rows)
			{
				var category = row.MonthStart.ToString("MMM yy", Fmt.Culture);
				won.Points.Add(new ChartPoint { Category = category, Value = row.Won, Tag = row });
				lost.Points.Add(new ChartPoint { Category = category, Value = row.Lost, Tag = row });
			}

			this.chartWinLoss.YAxis.Max = ChartColors.NiceMax(rows.Select(r => (double)(r.Won + r.Lost)), true);

			var reasonSeries = this.chartReasons.Series[0];
			reasonSeries.Points.Clear();
			foreach (var reason in reasons)
				reasonSeries.Points.Add(new ChartPoint { Category = Shorten(reason.Reason, 14), Value = reason.Deals, Tag = reason });
			this.chartReasons.YAxis.Max = ChartColors.NiceMax(reasons.Select(r => (double)r.Deals), true);

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

			for (int i = 0; i < 4; i++)
				this.chartActivity.Series[i].Points.Clear();

			foreach (var row in rows)
			{
				this.chartActivity.Series[0].Points.Add(new ChartPoint { Category = row.User, Value = row.Calls, Tag = row });
				this.chartActivity.Series[1].Points.Add(new ChartPoint { Category = row.User, Value = row.Emails, Tag = row });
				this.chartActivity.Series[2].Points.Add(new ChartPoint { Category = row.User, Value = row.Meetings, Tag = row });
				this.chartActivity.Series[3].Points.Add(new ChartPoint { Category = row.User, Value = row.Notes, Tag = row });
			}

			this.chartActivity.YAxis.Max = ChartColors.NiceMax(rows.Select(r => (double)r.Total), true);
			this.summaries[2] = Plural(rows.Sum(r => r.Total), "activity", "activities") + " · " + Plural(rows.Count, "user");

			this.labelActivityDescription.Text =
				"Calls, emails, meetings and notes logged by each user in the last " + ReportService.ActivityDays + " days: " +
				rows.Sum(r => r.Total) + " activities." + this.ScopeText;
		}

		private void LoadLeadSources()
		{
			var rows = ReportService.LeadSourceConversion();
			this.gridLeadSource.DataSource = rows;

			var contacts = this.chartLeadSource.Series[0];
			var customers = this.chartLeadSource.Series[1];
			contacts.Points.Clear();
			customers.Points.Clear();
			foreach (var row in rows)
			{
				contacts.Points.Add(new ChartPoint { Category = row.Source, Value = row.Contacts, Tag = row });
				customers.Points.Add(new ChartPoint { Category = row.Source, Value = row.Customers, Tag = row });
			}

			var total = rows.Sum(r => r.Contacts);
			var converted = rows.Sum(r => r.Customers);
			this.chartLeadSource.YAxis.Max = ChartColors.NiceMax(rows.Select(r => (double)r.Contacts), true);
			this.summaries[3] = Plural(total, "contact") + " · " + Plural(rows.Count, "source");
			this.labelLeadSourceDescription.Text =
				"Contacts per lead source and how many became customers: " + converted + " of " + total +
				(total > 0 ? " (" + Fmt.Percent(converted * 100d / total) + ")." : ".") + this.ScopeText;
		}

		private void ReportsView_Load(object sender, EventArgs e)
		{
			if (this.DesignMode)
				return;

			ShowReport(this.segmentedReport.SelectedIndex);
		}

		private void segmentedReport_SelectedIndexChanged(object sender, EventArgs e)
		{
			ShowReport(this.segmentedReport.SelectedIndex);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			switch (this.segmentedReport.SelectedIndex)
			{
				case 1: CsvExport.Download(this.gridWinLoss, "win-loss-analysis.csv"); break;
				case 2: CsvExport.Download(this.gridActivity, "activity-per-user.csv"); break;
				case 3: CsvExport.Download(this.gridLeadSource, "lead-source-conversion.csv"); break;
				default: CsvExport.Download(this.gridForecast, "sales-forecast.csv"); break;
			}
		}

		private void chartForecast_PointClick(object sender, SeriesPointEventArgs e)
		{
			if (!(e.Point?.Tag is ForecastRow row))
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

		private void chartWinLoss_PointClick(object sender, SeriesPointEventArgs e)
		{
			if (!(e.Point?.Tag is WinLossRow row))
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
