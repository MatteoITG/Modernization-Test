using System;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// Home page: KPIs, charts and lists of the selected period; every widget drills down to the list it summarizes.
	/// </summary>
	public partial class DashboardView : UserControl, IRefreshable
	{
		// the charts format axis ticks with the .NET standard formats only (no compact "$200K").
		private const string CurrencyAxis = "C0";

		// horizontal bars print the last tick at the right edge of the plot: whole dollars ("$800,000") are cut there,
		// so the bar charts plot thousands ("$800" with the axis title "$ thousands"); the tooltips show "$524.5K".
		private const double Thousand = 1000d;

		private DashboardData data;

		public DashboardView()
		{
			InitializeComponent();

			this.listTasks.DisplayMembers.Title = "Title";
			this.listTasks.DisplayMembers.Description = "Description";
			this.listTasks.DisplayMembers.Meta = "Meta";
			this.listTasks.DisplayMembers.Icon = "Icon";
			this.listTasks.DisplayMembers.IconTone = "IconTone";
			this.listTasks.DisplayMembers.Badge = "Badge";
			this.listTasks.DisplayMembers.BadgeTone = "BadgeTone";

			this.gridClosing.DefaultCellStyle.FormatProvider = Fmt.Culture;
			this.gridAccounts.DefaultCellStyle.FormatProvider = Fmt.Culture;

			ConfigureCharts();
		}

		/// <summary>Period shown by the dashboard.</summary>
		public DashboardPeriod Period
		{
			get { return (DashboardPeriod)Math.Max(0, this.segmentedPeriod.SelectedIndex); }
			set { this.segmentedPeriod.SelectedIndex = (int)value; }
		}

		/// <summary>Reloads every widget for the selected period.</summary>
		public void RefreshData()
		{
			DashboardData loaded = null;
			if (!Notify.Try(() => loaded = DashboardService.Load(this.Period), "Loading the dashboard"))
				return;

			this.data = loaded;
			this.labelGreeting.Text = CurrentUser.IsSignedIn
				? Greeting() + ", " + CurrentUser.Name.Split(' ')[0]
				: "Overview";
			this.labelPeriod.Text = this.data.PeriodName + (CurrentUser.SeesAll ? " · all deals" : " · my deals");

			ShowKpis();
			ShowPipeline();
			ShowWonRevenue();
			ShowOwners();
			ShowTasks();
			ShowActivity();
			ShowGrids();
		}

		private static string Greeting()
		{
			var hour = DateTime.Now.Hour;
			return hour < 12 ? "Good morning" : hour < 18 ? "Good afternoon" : "Good evening";
		}

		private void ConfigureCharts()
		{
			// the value axis is the Y axis also for horizontal bars (its ticks are drawn along the bottom).
			foreach (var chart in new[] { this.chartPipeline, this.chartWon, this.chartOwners })
			{
				chart.Palette = ChartColors.Palette;
				chart.YAxis.Format = CurrencyAxis;
				chart.YAxis.Min = 0;
				chart.YAxis.Gridlines = true;
			}
			this.chartPipeline.YAxis.Title = "$ thousands";
			this.chartOwners.YAxis.Title = "$ thousands";

			this.chartPipeline.Series[0].Color = ChartColors.Indigo;
			this.chartOwners.Series[0].Color = ChartColors.Indigo;
			this.chartWon.Series[0].Color = ChartColors.Indigo;
			this.chartWon.Series[1].Color = ChartColors.Neutral;
		}

		private void ShowKpis()
		{
			Apply(this.kpiPipeline, this.data.OpenPipeline);
			Apply(this.kpiWon, this.data.WonRevenue);
			Apply(this.kpiWinRate, this.data.WinRate);
			Apply(this.kpiAverage, this.data.AverageDeal);

			// only won revenue shows the change versus the previous period.
			this.kpiWon.Trend = this.data.WonRevenue.Trend;
		}

		private static void Apply(KpiPanel panel, DashboardKpi kpi)
		{
			panel.Value = kpi.Value;
			panel.Caption = kpi.Caption;
			panel.SparklineValues = kpi.Sparkline;
		}

		private void ShowPipeline()
		{
			var series = this.chartPipeline.Series[0];
			series.Points.Clear();
			foreach (var stage in this.data.PipelineByStage)
			{
				series.Points.Add(new ChartPoint
				{
					Category = stage.Name + " (" + stage.Count + ")",
					Value = (double)stage.Value / Thousand,
					Tag = stage,
				});
			}
			this.chartPipeline.YAxis.Max = ChartColors.NiceMax(series.Points.Select(p => p.Value));
		}

		private void ShowWonRevenue()
		{
			this.labelWon.Text = this.data.Period == DashboardPeriod.Month ? "Won revenue per week" : "Won revenue per month";

			var current = this.chartWon.Series[0];
			var previous = this.chartWon.Series[1];
			current.Name = this.data.CurrentSeriesName;
			previous.Name = this.data.PreviousSeriesName;
			current.Points.Clear();
			previous.Points.Clear();
			foreach (var bucket in this.data.WonByBucket)
			{
				current.Points.Add(new ChartPoint { Category = bucket.Label, Value = (double)bucket.Value, Tag = bucket });
				previous.Points.Add(new ChartPoint { Category = bucket.Label, Value = (double)bucket.PreviousValue, Tag = bucket });
			}
			this.chartWon.YAxis.Max = ChartColors.NiceMax(current.Points.Concat(previous.Points).Select(p => p.Value));
		}

		private void ShowOwners()
		{
			var series = this.chartOwners.Series[0];
			series.Points.Clear();
			foreach (var owner in this.data.DealsByOwner)
			{
				series.Points.Add(new ChartPoint
				{
					Category = owner.Name,
					Value = (double)owner.Value / Thousand,
					Tag = owner,
				});
			}
			this.chartOwners.YAxis.Max = ChartColors.NiceMax(series.Points.Select(p => p.Value));
		}

		private void ShowTasks()
		{
			this.listTasks.DataSource = this.data.MyTasks;
			this.emptyTasks.Visible = this.data.MyTasks.Count == 0;
			this.labelTasks.Text = this.data.MyTasks.Count == 0 ? "My tasks today" : "My tasks today (" + this.data.MyTasks.Count + ")";
		}

		private void ShowActivity()
		{
			this.timelineActivity.Items.Clear();
			foreach (var a in this.data.RecentActivity)
			{
				this.timelineActivity.Items.Add(new TimelineItem
				{
					Time = a.Date,
					Title = a.Subject,
					Description = a.Description,
					Icon = ActivityLogService.Icon(a.Type),
					Tone = a.Type == ActivityType.Meeting ? TimelineTone.Primary : TimelineTone.Neutral,
					Tag = a,
				});
			}
			this.emptyActivity.Visible = this.data.RecentActivity.Count == 0;
		}

		private void ShowGrids()
		{
			this.gridClosing.DataSource = this.data.ClosingSoon;
			this.emptyClosing.Visible = this.data.ClosingSoon.Count == 0;

			this.labelAccounts.Text = "Top accounts · " + this.data.PeriodName;
			this.gridAccounts.DataSource = this.data.TopAccounts;
			this.emptyAccounts.Visible = this.data.TopAccounts.Count == 0;
		}

		/// <summary>Deals of the current user only, for Sales.</summary>
		private static int? ScopeOwner => CurrentUser.SeesAll ? (int?)null : CurrentUser.Id;

		private void DashboardView_Load(object sender, EventArgs e)
		{
			if (this.DesignMode)
				return;

			RefreshData();
		}

		private void segmentedPeriod_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.data != null)
				RefreshData();
		}

		private void kpiPipeline_Click(object sender, EventArgs e)
		{
			Navigator.OpenDeals(new DealFilter { OpenOnly = true, OwnerId = ScopeOwner, Caption = "Open pipeline" });
		}

		private void kpiWon_Click(object sender, EventArgs e)
		{
			if (this.data == null)
				return;

			Navigator.OpenDeals(new DealFilter
			{
				WonOnly = true,
				OwnerId = ScopeOwner,
				CloseFrom = this.data.Start,
				CloseTo = this.data.End.AddDays(-1),
				Caption = "Won in " + this.data.PeriodName,
			});
		}

		private void kpiWinRate_Click(object sender, EventArgs e)
		{
			if (this.data == null)
				return;

			Navigator.OpenDeals(new DealFilter
			{
				OwnerId = ScopeOwner,
				CloseFrom = this.data.Start,
				CloseTo = this.data.End.AddDays(-1),
				Caption = "Deals closing in " + this.data.PeriodName,
			});
		}

		private void kpiAverage_Click(object sender, EventArgs e)
		{
			kpiWon_Click(sender, e);
		}

		private void chartPipeline_PointClick(object sender, SeriesPointEventArgs e)
		{
			if (e.Point?.Tag is DashboardStage stage)
			{
				Navigator.OpenDeals(new DealFilter
				{
					StageId = stage.StageId,
					OpenOnly = true,
					OwnerId = ScopeOwner,
					Caption = "Open deals in " + stage.Name,
				});
			}
		}

		private void chartWon_PointClick(object sender, SeriesPointEventArgs e)
		{
			if (!(e.Point?.Tag is DashboardRevenueBucket bucket))
				return;

			var previous = e.SeriesIndex == 1;
			var from = previous ? bucket.PreviousFrom : bucket.From;
			var to = previous ? bucket.PreviousTo : bucket.To;
			if (from >= to)
				return;

			Navigator.OpenDeals(new DealFilter
			{
				WonOnly = true,
				OwnerId = ScopeOwner,
				CloseFrom = from,
				CloseTo = to.AddDays(-1),
				Caption = previous ? bucket.PreviousCaption : bucket.Caption,
			});
		}

		private void chartOwners_PointClick(object sender, SeriesPointEventArgs e)
		{
			if (e.Point?.Tag is DashboardOwner owner)
			{
				Navigator.OpenDeals(new DealFilter
				{
					OwnerId = owner.OwnerId,
					OpenOnly = true,
					Caption = "Open deals of " + owner.Name,
				});
			}
		}

		private void listTasks_ItemClick(object sender, ActionCardListItemEventArgs e)
		{
			if (!(e.DataItem is DashboardTask task))
				return;

			if (TaskEditDialog.Edit(task.Id))
			{
				RefreshData();
				Navigator.RefreshBadges();
			}
		}

		private void timelineActivity_ItemClick(object sender, TimelineItemEventArgs e)
		{
			var entry = (e.Item?.Tag ?? e.DataItem) as DashboardActivity;
			if (entry == null)
				return;

			if (entry.DealId != null)
			{
				if (Navigator.OpenDeal(entry.DealId.Value))
					RefreshData();
			}
			else if (entry.ContactId != null)
			{
				Navigator.OpenContact(entry.ContactId.Value);
			}
			else if (entry.CompanyId != null)
			{
				Navigator.OpenCompany(entry.CompanyId.Value);
			}
		}

		private void linkTasksAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Navigator.ShowPage("TasksView");
		}

		private void linkActivityAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Navigator.ShowPage("ActivitiesView");
		}

		private void gridClosing_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (this.gridClosing.Rows[e.RowIndex].DataBoundItem is DashboardClosingDeal row && Navigator.OpenDeal(row.Id))
				RefreshData();
		}

		private void gridAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (this.gridAccounts.Rows[e.RowIndex].DataBoundItem is DashboardAccount row)
				Navigator.OpenCompany(row.CompanyId);
		}
	}
}
