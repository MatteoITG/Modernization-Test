using System;
using System.Linq;
using Wisej.Web;
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
		// money axes: "$800K" (the trailing comma of the format divides by 1000).
		private const string ThousandsAxis = "$#,##0,K";

		private DashboardData data;

		public DashboardView()
		{
			InitializeComponent();

			this.gridClosing.AutoGenerateColumns = false;
			this.gridAccounts.AutoGenerateColumns = false;
			this.gridClosing.DefaultCellStyle.FormatProvider = Fmt.Culture;
			this.gridAccounts.DefaultCellStyle.FormatProvider = Fmt.Culture;
			// the task cards show these properties of DashboardTask.
			this.listTasks.DisplayMembers.Title = "Title";
			this.listTasks.DisplayMembers.Description = "Description";
			this.listTasks.DisplayMembers.Meta = "Meta";
			this.listTasks.DisplayMembers.Icon = "Icon";
			this.listTasks.DisplayMembers.IconTone = "IconTone";
			this.listTasks.DisplayMembers.Badge = "Badge";
			this.listTasks.DisplayMembers.BadgeTone = "BadgeTone";

			ConfigureCharts();
			Reflow(Application.ActiveProfile?.Name);
		}

		#region Responsive layout

		/// <summary>
		/// Rearranges the cards for the client profile (ClientProfiles.json): four KPI tiles and three charts in a row on a
		/// desktop, two by two and one chart per row on a tablet, one card per row on a phone.
		/// </summary>
		/// <remarks>The cells of a TableLayoutPanel are extender properties that the responsive profiles of the designer cannot hold.</remarks>
		protected override void OnResponsiveProfileChanged(ResponsiveProfileChangedEventArgs e)
		{
			base.OnResponsiveProfileChanged(e);
			Reflow(e.CurrentProfile?.Name);
		}

		private void Reflow(string profile)
		{
			var phone = profile == "Phone";
			var tablet = profile == "Tablet";

			// the header: on a phone the period selector goes under the greeting.
			this.panelHeader.Height = phone ? 100 : 56;
			this.labelGreeting.Dock = phone ? DockStyle.Top : DockStyle.Left;
			this.segmentedPeriod.Dock = phone ? DockStyle.Bottom : DockStyle.Right;
			this.segmentedPeriod.Padding = phone ? new Padding(0, 2, 44, 2) : new Padding(12, 2, 0, 2);
			this.labelPeriod.Visible = !phone;
			var heights = new[]
			{
				Arrange(this.tableKpis, phone ? 1 : tablet ? 2 : 4, 170),
				Arrange(this.tableCharts, phone || tablet ? 1 : 3, 360),
				Arrange(this.tableLists, phone ? 1 : 2, 320),
				Arrange(this.tableGrids, phone ? 1 : 2, 320),
			};

			this.tableMain.SuspendLayout();
			for (var i = 0; i < heights.Length; i++)
				this.tableMain.RowStyles[i] = new RowStyle(SizeType.Absolute, heights[i]);
			this.tableMain.ResumeLayout();
			this.panelScroll.AutoScrollMinSize = new System.Drawing.Size(phone ? 320 : 900, heights.Sum() + this.tableMain.Padding.Vertical);
		}

		// puts the cards of a table in <paramref name="columns"/> columns; returns the height of the table.
		private static int Arrange(TableLayoutPanel table, int columns, int rowHeight)
		{
			var cards = table.Controls.Cast<Control>().OrderBy(c => table.GetColumn(c) + table.GetRow(c) * 10).ToList();
			var rows = (cards.Count + columns - 1) / columns;

			table.SuspendLayout();
			table.ColumnStyles.Clear();
			table.RowStyles.Clear();
			table.ColumnCount = columns;
			table.RowCount = rows;
			for (var c = 0; c < columns; c++)
				table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / columns));
			for (var r = 0; r < rows; r++)
				table.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));
			for (var i = 0; i < cards.Count; i++)
				table.SetCellPosition(cards[i], new TableLayoutPanelCellPosition(i % columns, i / columns));
			table.ResumeLayout();
			return rows * rowHeight;
		}

		#endregion

		/// <summary>Period shown by the dashboard.</summary>
		private DashboardPeriod Period => (DashboardPeriod)Math.Max(0, this.segmentedPeriod.SelectedIndex);

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
			ChartStyle.Apply(this.chartPipeline, ThousandsAxis);
			ChartStyle.Apply(this.chartWon, ThousandsAxis);
			ChartStyle.Apply(this.chartOwners, ThousandsAxis);
		}

		private void ShowKpis()
		{
			Apply(this.kpiPipeline, this.data.OpenPipeline, false);
			Apply(this.kpiWon, this.data.WonRevenue, true);
			Apply(this.kpiWinRate, this.data.WinRate, false);
			Apply(this.kpiAverage, this.data.AverageDeal, false);
		}

		private static void Apply(KpiPanel panel, DashboardKpi kpi, bool showTrend)
		{
			panel.Value = kpi.Value;
			panel.Caption = kpi.Caption;
			panel.SparklineValues = kpi.Sparkline ?? new double[0];

			// only won revenue shows the change versus the previous period.
			panel.Trend = showTrend ? kpi.Trend : null;
		}

		private void ShowPipeline()
		{
			var series = this.chartPipeline.Series[0];
			series.Points.Clear();
			// Wisej: the chart draws the bars top-down, in the order of the points.
			foreach (var stage in this.data.PipelineByStage)
			{
				var index = series.Points.AddXY(stage.Name + " (" + stage.Count + ")", (double)stage.Value);
				series.Points[index].Tag = stage;
			}
			ChartStyle.SetMaximum(this.chartPipeline, ChartColors.NiceMax(this.data.PipelineByStage.Select(s => (double)s.Value)));
		}

		private void ShowWonRevenue()
		{
			this.groupWon.Text = this.data.Period == DashboardPeriod.Month ? "Won revenue per week" : "Won revenue per month";

			var current = this.chartWon.Series[0];
			var previous = this.chartWon.Series[1];
			current.Name = this.data.CurrentSeriesName;
			previous.Name = this.data.PreviousSeriesName;
			current.Points.Clear();
			previous.Points.Clear();
			foreach (var bucket in this.data.WonByBucket)
			{
				current.Points[current.Points.AddXY(bucket.Label, (double)bucket.Value)].Tag = bucket;
				previous.Points[previous.Points.AddXY(bucket.Label, (double)bucket.PreviousValue)].Tag = bucket;
			}
			ChartStyle.SetMaximum(this.chartWon, ChartColors.NiceMax(this.data.WonByBucket.SelectMany(b => new[] { (double)b.Value, (double)b.PreviousValue })));
		}

		private void ShowOwners()
		{
			var series = this.chartOwners.Series[0];
			series.Points.Clear();
			foreach (var owner in this.data.DealsByOwner)
			{
				var index = series.Points.AddXY(owner.Name, (double)owner.Value);
				series.Points[index].Tag = owner;
			}
			ChartStyle.SetMaximum(this.chartOwners, ChartColors.NiceMax(this.data.DealsByOwner.Select(o => (double)o.Value)));
		}

		private void ShowTasks()
		{
			this.listTasks.DataSource = this.data.MyTasks;
			this.emptyTasks.Visible = this.data.MyTasks.Count == 0;
			this.groupTasks.Text = this.data.MyTasks.Count == 0 ? "My tasks today" : "My tasks today (" + this.data.MyTasks.Count + ")";
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
					Description = a.Type + (string.IsNullOrEmpty(a.Description) ? "" : " · " + a.Description),
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

			this.groupAccounts.Text = "Top accounts · " + this.data.PeriodName;
			this.gridAccounts.DataSource = this.data.TopAccounts;
			this.emptyAccounts.Visible = this.data.TopAccounts.Count == 0;
		}

		/// <summary>Deals of the current user only, for Sales.</summary>
		private static int? ScopeOwner => CurrentUser.SeesAll ? (int?)null : CurrentUser.Id;

		#region Drill-downs

		private void kpi_Click(object sender, EventArgs e)
		{
			if (this.data == null)
				return;

			var box = sender;
			if (box == this.kpiPipeline)
			{
				Navigator.OpenDeals(new DealFilter { OpenOnly = true, OwnerId = ScopeOwner, Caption = "Open pipeline" });
			}
			else if (box == this.kpiWon || box == this.kpiAverage)
			{
				Navigator.OpenDeals(new DealFilter
				{
					WonOnly = true,
					OwnerId = ScopeOwner,
					CloseFrom = this.data.Start,
					CloseTo = this.data.End.AddDays(-1),
					Caption = "Won in " + this.data.PeriodName,
				});
			}
			else if (box == this.kpiWinRate)
			{
				Navigator.OpenDeals(new DealFilter
				{
					OwnerId = ScopeOwner,
					CloseFrom = this.data.Start,
					CloseTo = this.data.End.AddDays(-1),
					Caption = "Deals closing in " + this.data.PeriodName,
				});
			}
		}

		private void chart_PointClick(object sender, SeriesPointEventArgs e)
		{
			var point = e.Point;
			var seriesIndex = e.SeriesIndex;
			switch (point?.Tag)
			{
				case DashboardStage stage:
					Navigator.OpenDeals(new DealFilter
					{
						StageId = stage.StageId,
						OpenOnly = true,
						OwnerId = ScopeOwner,
						Caption = "Open deals in " + stage.Name,
					});
					break;

				case DashboardRevenueBucket bucket:
					var previous = seriesIndex == 1;
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
					break;

				case DashboardOwner owner:
					Navigator.OpenDeals(new DealFilter
					{
						OwnerId = owner.OwnerId,
						OpenOnly = true,
						Caption = "Open deals of " + owner.Name,
					});
					break;
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
			if (!(e.Item?.Tag is DashboardActivity entry))
				return;

			if (entry.DealId != null)
			{
				if (Navigator.OpenDeal(entry.DealId.Value) && !this.IsDisposed)
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
			var row = GridHelper.RowAt<DashboardClosingDeal>(this.gridClosing, e.RowIndex);
			if (row != null && Navigator.OpenDeal(row.Id) && !this.IsDisposed)
				RefreshData();
		}

		private void gridAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = GridHelper.RowAt<DashboardAccount>(this.gridAccounts, e.RowIndex);
			if (row != null)
				Navigator.OpenCompany(row.CompanyId);
		}

		#endregion

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

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			RefreshData();
		}
	}
}
