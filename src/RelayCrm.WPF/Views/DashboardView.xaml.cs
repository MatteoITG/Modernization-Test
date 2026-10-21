using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RelayCrm.Controls;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// Home page: KPIs, charts and lists of the selected period; every widget drills down to the list it summarizes.
	/// </summary>
	public partial class DashboardView : UserControl, IRefreshable
	{
		private DashboardData data;
		private bool loading;

		public DashboardView()
		{
			InitializeComponent();

			ConfigureCharts();
			this.kpiPipeline.Click += kpiPipeline_Click;
			this.kpiWon.Click += kpiWon_Click;
			this.kpiWinRate.Click += kpiWinRate_Click;
			this.kpiAverage.Click += kpiWon_Click;

			this.loading = true;
			this.comboPeriod.SelectedIndex = 0;
			this.loading = false;

			RefreshData();
		}

		/// <summary>Period shown by the dashboard.</summary>
		public DashboardPeriod Period
		{
			get { return (DashboardPeriod)Math.Max(0, this.comboPeriod.SelectedIndex); }
			set { this.comboPeriod.SelectedIndex = (int)value; }
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
			ShowCharts();
			ShowLists();
		}

		private static string Greeting()
		{
			var hour = DateTime.Now.Hour;
			return hour < 12 ? "Good morning" : hour < 18 ? "Good afternoon" : "Good evening";
		}

		private void ConfigureCharts()
		{
			foreach (var chart in new[] { this.chartPipeline, this.chartWon, this.chartOwners })
			{
				chart.AxisFormat = v => Fmt.MoneyShort((decimal)v);
				chart.ValueFormat = v => Fmt.Money((decimal)v);
			}
			this.chartPipeline.EmptyText = "No open stages";
			this.chartOwners.EmptyText = "No open deals";

			this.chartPipeline.PointClick += chartPipeline_PointClick;
			this.chartWon.PointClick += chartWon_PointClick;
			this.chartOwners.PointClick += chartOwners_PointClick;
		}

		private void ShowKpis()
		{
			Apply(this.kpiPipeline, this.data.OpenPipeline, false);
			// only won revenue shows the change versus the previous period.
			Apply(this.kpiWon, this.data.WonRevenue, true);
			Apply(this.kpiWinRate, this.data.WinRate, false);
			Apply(this.kpiAverage, this.data.AverageDeal, false);
		}

		private static void Apply(KpiTile tile, DashboardKpi kpi, bool trend)
		{
			tile.Show(kpi.Value, kpi.Caption, kpi.Sparkline, trend ? kpi.Trend : null);
		}

		private void ShowCharts()
		{
			var indigo = ChartColors.Indigo.ToMedia();

			var stages = this.data.PipelineByStage;
			this.chartPipeline.SetData(stages.Select(s => s.Name + " (" + s.Count + ")"), stages,
				new ChartSeries("Open value", indigo, stages.Select(s => (double)s.Value)));

			this.groupWon.Header = this.data.Period == DashboardPeriod.Month ? "Won revenue per week" : "Won revenue per month";
			var buckets = this.data.WonByBucket;
			this.chartWon.SetData(buckets.Select(b => b.Label), buckets,
				new ChartSeries(this.data.CurrentSeriesName, indigo, buckets.Select(b => (double)b.Value)),
				new ChartSeries(this.data.PreviousSeriesName, ChartColors.Neutral.ToMedia(), buckets.Select(b => (double)b.PreviousValue)));

			var owners = this.data.DealsByOwner;
			this.chartOwners.SetData(owners.Select(o => o.Name), owners,
				new ChartSeries("Open value", indigo, owners.Select(o => (double)o.Value)));
		}

		private void ShowLists()
		{
			var tasks = this.data.MyTasks;
			this.listTasks.ItemsSource = tasks;
			this.emptyTasks.Visibility = tasks.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
			this.labelTasks.Text = tasks.Count == 0 ? "My tasks today" : "My tasks today (" + tasks.Count + ")";

			this.listActivity.ItemsSource = this.data.RecentActivity.Select(a => new TimelineEntry(a.Date, a.Subject, a.Type + " · " + a.Description)
			{
				TitleBrush = a.Type == ActivityType.Meeting ? Tone.Primary.ToBrush() : SystemColors.ControlTextBrush,
				Tag = a,
			}).ToList();
			this.emptyActivity.Visibility = this.data.RecentActivity.Count == 0 ? Visibility.Visible : Visibility.Collapsed;

			this.gridClosing.ItemsSource = this.data.ClosingSoon;
			this.emptyClosing.Visibility = this.data.ClosingSoon.Count == 0 ? Visibility.Visible : Visibility.Collapsed;

			this.labelAccounts.Text = "Top accounts · " + this.data.PeriodName;
			this.gridAccounts.ItemsSource = this.data.TopAccounts;
			this.emptyAccounts.Visibility = this.data.TopAccounts.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
		}

		/// <summary>Deals of the current user only, for Sales.</summary>
		private static int? ScopeOwner => CurrentUser.SeesAll ? (int?)null : CurrentUser.Id;

		private void comboPeriod_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (!this.loading && this.data != null)
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

		private void chartPipeline_PointClick(object sender, ChartPointEventArgs e)
		{
			if (e.Tag is DashboardStage stage)
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

		private void chartWon_PointClick(object sender, ChartPointEventArgs e)
		{
			if (!(e.Tag is DashboardRevenueBucket bucket))
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

		private void chartOwners_PointClick(object sender, ChartPointEventArgs e)
		{
			if (e.Tag is DashboardOwner owner)
			{
				Navigator.OpenDeals(new DealFilter
				{
					OwnerId = owner.OwnerId,
					OpenOnly = true,
					Caption = "Open deals of " + owner.Name,
				});
			}
		}

		private void listTasks_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<DashboardTask>(e) is DashboardTask task && TaskEditDialog.Edit(task.Id))
			{
				RefreshData();
				Navigator.RefreshBadges();
			}
		}

		private void listActivity_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (!(UiHelper.RowItem<TimelineEntry>(e)?.Tag is DashboardActivity entry))
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

		private void linkTasksAll_Click(object sender, RoutedEventArgs e)
		{
			Navigator.ShowPage("TasksView");
		}

		private void linkActivityAll_Click(object sender, RoutedEventArgs e)
		{
			Navigator.ShowPage("ActivitiesView");
		}

		private void gridClosing_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<DashboardClosingDeal>(e) is DashboardClosingDeal row && Navigator.OpenDeal(row.Id))
				RefreshData();
		}

		private void gridAccounts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<DashboardAccount>(e) is DashboardAccount row)
				Navigator.OpenCompany(row.CompanyId);
		}
	}
}
