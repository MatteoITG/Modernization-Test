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
	/// <remarks>
	/// Migration step 2: the KpiTile user controls became KpiPanel cards, the BarChart subclass plain ChartViews with
	/// their series in the designer, the HTML list boxes an ActionCardList (tasks) and a Timeline (activity), the period
	/// combo box a SegmentedButton, and the grids got subtitle, meter and avatar columns. The cards reflow for the
	/// Tablet and Phone client profiles (ClientProfiles.json).
	/// </remarks>
	public partial class DashboardView : UserControl, IRefreshable
	{
		private DashboardData data;

		public DashboardView()
		{
			InitializeComponent();

			GridHelper.UseConverters(this.gridClosing);
			GridHelper.UseConverters(this.gridAccounts);

			// the task cards show these properties of DashboardTask (the XAML item template).
			this.listTasks.DisplayMembers.Title = "Title";
			this.listTasks.DisplayMembers.Description = "Description";
			this.listTasks.DisplayMembers.Meta = "Meta";
			this.listTasks.DisplayMembers.Icon = "Icon";
			this.listTasks.DisplayMembers.IconTone = "IconTone";
			this.listTasks.DisplayMembers.Badge = "Badge";
			this.listTasks.DisplayMembers.BadgeTone = "BadgeTone";

			ChartStyle.Apply(this.chartPipeline);
			ChartStyle.Apply(this.chartWon);
			ChartStyle.Apply(this.chartOwners);
			Reflow(Application.ActiveProfile?.Name);
		}

		/// <summary>Period shown by the dashboard.</summary>
		public DashboardPeriod Period
		{
			get { return (DashboardPeriod)Math.Max(0, this.segmentedPeriod.SelectedIndex); }
			set { this.segmentedPeriod.SelectedIndex = (int)value; }
		}

		#region Responsive layout

		/// <summary>
		/// Rearranges the cards for the client profile (ClientProfiles.json): the desktop layout of the WPF page,
		/// two by two on a tablet, one card per row on a phone.
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
			this.segmentedPeriod.Padding = phone ? new Padding(0, 2, 0, 2) : new Padding(12, 2, 0, 2);
			this.labelPeriod.Visible = !phone;

			var heights = new[]
			{
				Arrange(this.tableKpis, phone ? 1 : tablet ? 2 : 4, 170),
				Arrange(this.tableCharts, phone || tablet ? 1 : 2, 340),
				Arrange(this.tableLists, phone || tablet ? 1 : 3, 330),
				Arrange(this.tableGrids, phone || tablet ? 1 : 2, 310, 60f, 40f),
			};

			this.tableMain.SuspendLayout();
			for (var i = 0; i < heights.Length; i++)
				this.tableMain.RowStyles[i] = new RowStyle(SizeType.Absolute, heights[i]);
			this.tableMain.ResumeLayout();
			this.panelScroll.AutoScrollMinSize = new System.Drawing.Size(phone ? 320 : 900, heights.Sum() + this.tableMain.Padding.Vertical);
		}

		// puts the cards of a table in <paramref name="columns"/> columns (of the percent <paramref name="widths"/> when
		// they are as many); returns the height of the table.
		private static int Arrange(TableLayoutPanel table, int columns, int rowHeight, params float[] widths)
		{
			var cards = table.Controls.Cast<Control>().OrderBy(c => table.GetColumn(c) + table.GetRow(c) * 10).ToList();
			var rows = (cards.Count + columns - 1) / columns;
			if (widths.Length != columns)
				widths = null;

			table.SuspendLayout();
			table.ColumnStyles.Clear();
			table.RowStyles.Clear();
			table.ColumnCount = columns;
			table.RowCount = rows;
			for (var c = 0; c < columns; c++)
				table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, widths?[c] ?? 100f / columns));
			for (var r = 0; r < rows; r++)
				table.RowStyles.Add(new RowStyle(SizeType.Percent, 100f / rows));
			for (var i = 0; i < cards.Count; i++)
				table.SetCellPosition(cards[i], new TableLayoutPanelCellPosition(i % columns, i / columns));
			table.ResumeLayout();
			return rows * rowHeight;
		}

		#endregion

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

		private void ShowKpis()
		{
			Apply(this.kpiPipeline, this.data.OpenPipeline, false);
			// only won revenue shows the change versus the previous period.
			Apply(this.kpiWon, this.data.WonRevenue, true);
			Apply(this.kpiWinRate, this.data.WinRate, false);
			Apply(this.kpiAverage, this.data.AverageDeal, false);
		}

		private static void Apply(KpiPanel panel, DashboardKpi kpi, bool trend)
		{
			panel.Value = kpi.Value;
			panel.Caption = kpi.Caption;
			panel.SparklineValues = kpi.Sparkline ?? new double[0];
			panel.Trend = trend ? kpi.Trend : null;
		}

		private void ShowCharts()
		{
			var stages = this.data.PipelineByStage;
			ChartStyle.SetPoints(this.chartPipeline.Series[0], stages, s => s.Name + " (" + s.Count + ")", s => (double)s.Value);
			ChartStyle.SetMaximum(this.chartPipeline);

			this.groupWon.Text = this.data.Period == DashboardPeriod.Month ? "Won revenue per week" : "Won revenue per month";
			var buckets = this.data.WonByBucket;
			this.chartWon.Series[0].Name = this.data.CurrentSeriesName;
			this.chartWon.Series[1].Name = this.data.PreviousSeriesName;
			ChartStyle.SetPoints(this.chartWon.Series[0], buckets, b => b.Label, b => (double)b.Value);
			ChartStyle.SetPoints(this.chartWon.Series[1], buckets, b => b.Label, b => (double)b.PreviousValue);
			ChartStyle.SetMaximum(this.chartWon);

			var owners = this.data.DealsByOwner;
			ChartStyle.SetPoints(this.chartOwners.Series[0], owners, o => o.Name, o => (double)o.Value);
			ChartStyle.SetMaximum(this.chartOwners);
		}

		private void ShowLists()
		{
			var tasks = this.data.MyTasks;
			this.listTasks.DataSource = tasks;
			this.emptyTasks.Visible = tasks.Count == 0;
			this.groupTasks.Text = tasks.Count == 0 ? "My tasks today" : "My tasks today (" + tasks.Count + ")";

			this.timelineActivity.Items.Clear();
			foreach (var a in this.data.RecentActivity)
			{
				this.timelineActivity.Items.Add(new TimelineItem
				{
					Time = a.Date,
					Title = a.Subject,
					Description = a.Type + (string.IsNullOrEmpty(a.Description) ? "" : " · " + a.Description),
					Icon = ActivityLogService.Icon(a.Type),
					// meetings in the accent colour (the TitleBrush of the WPF template).
					Tone = a.Type == ActivityType.Meeting ? TimelineTone.Primary : TimelineTone.Neutral,
					Tag = a,
				});
			}
			this.emptyActivity.Visible = this.data.RecentActivity.Count == 0;

			this.gridClosing.DataSource = this.data.ClosingSoon;
			this.emptyClosing.Visible = this.data.ClosingSoon.Count == 0;

			this.groupAccounts.Text = "Top accounts · " + this.data.PeriodName;
			this.gridAccounts.DataSource = this.data.TopAccounts;
			this.emptyAccounts.Visible = this.data.TopAccounts.Count == 0;
		}

		/// <summary>Deals of the current user only, for Sales.</summary>
		private static int? ScopeOwner => CurrentUser.SeesAll ? (int?)null : CurrentUser.Id;

		#region Drill-downs

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

		private void kpi_Click(object sender, EventArgs e)
		{
			if (this.data == null)
				return;

			if (sender == this.kpiPipeline)
			{
				Navigator.OpenDeals(new DealFilter { OpenOnly = true, OwnerId = ScopeOwner, Caption = "Open pipeline" });
			}
			else if (sender == this.kpiWon || sender == this.kpiAverage)
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
			else if (sender == this.kpiWinRate)
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
			switch (e.Point?.Tag)
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
			if (e.DataItem is DashboardTask task && TaskEditDialog.Edit(task.Id))
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
			if (UiHelper.RowItem<DashboardClosingDeal>(this.gridClosing, e) is DashboardClosingDeal row && Navigator.OpenDeal(row.Id) && !this.IsDisposed)
				RefreshData();
		}

		private void gridAccounts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (UiHelper.RowItem<DashboardAccount>(this.gridAccounts, e) is DashboardAccount row)
				Navigator.OpenCompany(row.CompanyId);
		}

		#endregion
	}
}
