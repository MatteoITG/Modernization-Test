using System;
using System.Drawing;
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
			IconImages.Apply(this.toolStrip);
			this.listViewTasks.SmallImageList = IconImages.List(16, "check2-square", "exclamation-circle");
			this.listViewActivity.SmallImageList = IconImages.List(16, "telephone", "envelope", "people", "sticky");

			this.comboPeriod.Items.AddRange(new object[] { "This month", "Quarter", "Year" });
			this.comboPeriod.SelectedIndex = 0;

			ConfigureCharts();
		}

		/// <summary>Period shown by the dashboard.</summary>
		private DashboardPeriod Period => (DashboardPeriod)Math.Max(0, this.comboPeriod.SelectedIndex);

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

			// sparklines: just the line, no axes.
			foreach (var spark in new[] { this.chartSparkPipeline, this.chartSparkWon, this.chartSparkWinRate, this.chartSparkAverage })
			{
				spark.Cursor = Cursors.Hand;
			}
		}

		private void ShowKpis()
		{
			Apply(this.labelKpiPipelineValue, this.labelKpiPipelineCaption, this.labelKpiPipelineTrend, this.chartSparkPipeline, this.data.OpenPipeline, false);
			Apply(this.labelKpiWonValue, this.labelKpiWonCaption, this.labelKpiWonTrend, this.chartSparkWon, this.data.WonRevenue, true);
			Apply(this.labelKpiWinRateValue, this.labelKpiWinRateCaption, this.labelKpiWinRateTrend, this.chartSparkWinRate, this.data.WinRate, false);
			Apply(this.labelKpiAverageValue, this.labelKpiAverageCaption, this.labelKpiAverageTrend, this.chartSparkAverage, this.data.AverageDeal, false);
		}

		private static void Apply(Label value, Label caption, Label trend, Sparkline spark, DashboardKpi kpi, bool showTrend)
		{
			value.Text = kpi.Value;
			caption.Text = kpi.Caption;

			// only won revenue shows the change versus the previous period.
			trend.Visible = showTrend && kpi.Trend != null;
			if (trend.Visible)
			{
				var t = kpi.Trend.Value;
				trend.Text = (t > 0 ? "▲ +" : t < 0 ? "▼ " : "") + t.ToString("0.#", Fmt.Culture) + "%";
				trend.ForeColor = t > 0 ? Tone.Success.ToColor() : t < 0 ? Tone.Danger.ToColor() : SystemColors.GrayText;
			}

			spark.Values = kpi.Sparkline ?? new double[0];
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
			this.listViewTasks.BeginUpdate();
			this.listViewTasks.Items.Clear();
			foreach (var task in this.data.MyTasks)
			{
				var item = new ListViewItem(task.Title, Icons.NameOf(task.Icon)) { Tag = task };
				item.SubItems.Add(task.Description);
				item.SubItems.Add(task.Meta, task.IconTone == Tone.Danger ? Tone.Danger.ToColor() : this.listViewTasks.ForeColor, item.BackColor, item.Font);
				item.SubItems.Add(task.Badge ?? "", task.BadgeTone.ToColor(), item.BackColor, item.Font);
				this.listViewTasks.Items.Add(item);
			}
			this.listViewTasks.EndUpdate();
			this.labelNoTasks.Visible = this.data.MyTasks.Count == 0;
			this.groupTasks.Text = this.data.MyTasks.Count == 0 ? "My tasks today" : "My tasks today (" + this.data.MyTasks.Count + ")";
		}

		private void ShowActivity()
		{
			this.listViewActivity.BeginUpdate();
			this.listViewActivity.Items.Clear();
			foreach (var a in this.data.RecentActivity)
			{
				var item = new ListViewItem(Fmt.Relative(a.Date) + ", " + a.Date.ToString("HH:mm", Fmt.Culture), Icons.NameOf(ActivityLogService.Icon(a.Type)))
				{
					Tag = a,
					ToolTipText = a.Type + " · " + Fmt.DateAndTime(a.Date),
				};
				item.SubItems.Add(a.Subject);
				item.SubItems.Add(a.Description);
				this.listViewActivity.Items.Add(item);
			}
			this.listViewActivity.EndUpdate();
			this.labelNoActivity.Visible = this.data.RecentActivity.Count == 0;
		}

		private void ShowGrids()
		{
			this.gridClosing.DataSource = this.data.ClosingSoon;
			this.labelNoClosing.Visible = this.data.ClosingSoon.Count == 0;

			this.groupAccounts.Text = "Top accounts · " + this.data.PeriodName;
			this.gridAccounts.DataSource = this.data.TopAccounts;
			this.labelNoAccounts.Visible = this.data.TopAccounts.Count == 0;
		}

		/// <summary>Deals of the current user only, for Sales.</summary>
		private static int? ScopeOwner => CurrentUser.SeesAll ? (int?)null : CurrentUser.Id;

		#region Drill-downs

		/// <summary>The KPI box a click came from (the box itself, a label or its sparkline).</summary>
		private GroupBox KpiOf(object sender)
		{
			var control = sender as Control;
			while (control != null && !(control is GroupBox))
				control = control.Parent;
			return control as GroupBox;
		}

		private void kpi_Click(object sender, EventArgs e)
		{
			if (this.data == null)
				return;

			var box = KpiOf(sender);
			if (box == this.groupKpiPipeline)
			{
				Navigator.OpenDeals(new DealFilter { OpenOnly = true, OwnerId = ScopeOwner, Caption = "Open pipeline" });
			}
			else if (box == this.groupKpiWon || box == this.groupKpiAverage)
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
			else if (box == this.groupKpiWinRate)
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

		private void chart_MouseClick(object sender, SeriesPointEventArgs e)
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

		private void listViewTasks_ItemActivate(object sender, EventArgs e)
		{
			if (this.listViewTasks.SelectedItems.Count == 0 || !(this.listViewTasks.SelectedItems[0].Tag is DashboardTask task))
				return;

			if (TaskEditDialog.Edit(task.Id))
			{
				RefreshData();
				Navigator.RefreshBadges();
			}
		}

		private void listViewActivity_ItemActivate(object sender, EventArgs e)
		{
			if (this.listViewActivity.SelectedItems.Count == 0 || !(this.listViewActivity.SelectedItems[0].Tag is DashboardActivity entry))
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

		private void comboPeriod_SelectedIndexChanged(object sender, EventArgs e)
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
