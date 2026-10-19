namespace RelayCrm.Views
{
	partial class DashboardView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Wisej.Web.ChartSeries series5 = new Wisej.Web.ChartSeries();
			Wisej.Web.ChartSeries series6 = new Wisej.Web.ChartSeries();
			Wisej.Web.ChartSeries series7 = new Wisej.Web.ChartSeries();
			Wisej.Web.ChartSeries series8 = new Wisej.Web.ChartSeries();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment3 = new Wisej.Web.Segment();
			this.panelScroll = new Wisej.Web.Panel();
			this.tableMain = new Wisej.Web.TableLayoutPanel();
			this.tableKpis = new Wisej.Web.TableLayoutPanel();
			this.kpiPipeline = new Wisej.Web.KpiPanel();
			this.kpiWon = new Wisej.Web.KpiPanel();
			this.kpiWinRate = new Wisej.Web.KpiPanel();
			this.kpiAverage = new Wisej.Web.KpiPanel();
			this.tableCharts = new Wisej.Web.TableLayoutPanel();
			this.groupPipeline = new Wisej.Web.GroupBox();
			this.chartPipeline = new Wisej.Web.ChartView();
			this.groupWon = new Wisej.Web.GroupBox();
			this.chartWon = new Wisej.Web.ChartView();
			this.groupOwners = new Wisej.Web.GroupBox();
			this.chartOwners = new Wisej.Web.ChartView();
			this.tableLists = new Wisej.Web.TableLayoutPanel();
			this.groupTasks = new Wisej.Web.GroupBox();
			this.linkTasksAll = new Wisej.Web.LinkLabel();
			this.emptyTasks = new Wisej.Web.EmptyState();
			this.listTasks = new Wisej.Web.ActionCardList();
			this.groupActivity = new Wisej.Web.GroupBox();
			this.linkActivityAll = new Wisej.Web.LinkLabel();
			this.emptyActivity = new Wisej.Web.EmptyState();
			this.timelineActivity = new Wisej.Web.Timeline();
			this.tableGrids = new Wisej.Web.TableLayoutPanel();
			this.groupClosing = new Wisej.Web.GroupBox();
			this.emptyClosing = new Wisej.Web.EmptyState();
			this.gridClosing = new Wisej.Web.DataGridView();
			this.colClosingDeal = new Wisej.Web.DataGridViewSubtitleColumn();
			this.colClosingAmount = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colClosingDate = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colClosingProbability = new Wisej.Web.DataGridViewMeterColumn();
			this.groupAccounts = new Wisej.Web.GroupBox();
			this.emptyAccounts = new Wisej.Web.EmptyState();
			this.gridAccounts = new Wisej.Web.DataGridView();
			this.colAccountCompany = new Wisej.Web.DataGridViewAvatarColumn();
			this.colAccountRevenue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colAccountDeals = new Wisej.Web.DataGridViewTextBoxColumn();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelPeriod = new Wisej.Web.Label();
			this.labelGreeting = new Wisej.Web.Label();
			this.buttonRefresh = new Wisej.Web.Button();
			this.segmentedPeriod = new Wisej.Web.SegmentedButton();
			this.panelScroll.SuspendLayout();
			this.tableMain.SuspendLayout();
			this.tableKpis.SuspendLayout();
			this.tableCharts.SuspendLayout();
			this.groupPipeline.SuspendLayout();
			this.groupWon.SuspendLayout();
			this.groupOwners.SuspendLayout();
			this.tableLists.SuspendLayout();
			this.groupTasks.SuspendLayout();
			this.groupActivity.SuspendLayout();
			this.tableGrids.SuspendLayout();
			this.groupClosing.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridClosing)).BeginInit();
			this.groupAccounts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).BeginInit();
			this.panelHeader.SuspendLayout();
			this.SuspendLayout();
			//
			// panelScroll
			//
			this.panelScroll.AutoScroll = true;
			this.panelScroll.AutoScrollMinSize = new System.Drawing.Size(900, 1180);
			this.panelScroll.Controls.Add(this.tableMain);
			this.panelScroll.Dock = Wisej.Web.DockStyle.Fill;
			this.panelScroll.Location = new System.Drawing.Point(0, 56);
			this.panelScroll.Name = "panelScroll";
			this.panelScroll.Size = new System.Drawing.Size(1000, 584);
			this.panelScroll.TabIndex = 1;
			//
			// tableMain
			//
			this.tableMain.ColumnCount = 1;
			this.tableMain.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableMain.Controls.Add(this.tableKpis, 0, 0);
			this.tableMain.Controls.Add(this.tableCharts, 0, 1);
			this.tableMain.Controls.Add(this.tableLists, 0, 2);
			this.tableMain.Controls.Add(this.tableGrids, 0, 3);
			this.tableMain.Dock = Wisej.Web.DockStyle.Fill;
			this.tableMain.Location = new System.Drawing.Point(0, 0);
			this.tableMain.Name = "tableMain";
			this.tableMain.Padding = new Wisej.Web.Padding(10);
			this.tableMain.RowCount = 4;
			this.tableMain.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 170F));
			this.tableMain.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 36F));
			this.tableMain.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 32F));
			this.tableMain.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 32F));
			this.tableMain.Size = new System.Drawing.Size(983, 1180);
			this.tableMain.TabIndex = 0;
			//
			// tableKpis
			//
			this.tableKpis.ColumnCount = 4;
			this.tableKpis.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableKpis.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableKpis.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableKpis.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableKpis.Controls.Add(this.kpiPipeline, 0, 0);
			this.tableKpis.Controls.Add(this.kpiWon, 1, 0);
			this.tableKpis.Controls.Add(this.kpiWinRate, 2, 0);
			this.tableKpis.Controls.Add(this.kpiAverage, 3, 0);
			this.tableKpis.Dock = Wisej.Web.DockStyle.Fill;
			this.tableKpis.Location = new System.Drawing.Point(10, 10);
			this.tableKpis.Margin = new Wisej.Web.Padding(0);
			this.tableKpis.Name = "tableKpis";
			this.tableKpis.RowCount = 1;
			this.tableKpis.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableKpis.Size = new System.Drawing.Size(963, 170);
			this.tableKpis.TabIndex = 0;
			//
			// kpiPipeline
			//
			this.kpiPipeline.Clickable = true;
			this.kpiPipeline.CssClass = "relay-card";
			this.kpiPipeline.Dock = Wisej.Web.DockStyle.Fill;
			this.kpiPipeline.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/funnel.svg";
			this.kpiPipeline.Margin = new Wisej.Web.Padding(6);
			this.kpiPipeline.Name = "kpiPipeline";
			this.kpiPipeline.Size = new System.Drawing.Size(228, 158);
			this.kpiPipeline.TabIndex = 0;
			this.kpiPipeline.Title = "Open pipeline";
			this.kpiPipeline.Tone = Wisej.Web.KpiTone.Primary;
			this.kpiPipeline.Value = "$0";
			this.kpiPipeline.Visual = Wisej.Web.KpiVisual.Sparkline;
			this.kpiPipeline.Click += new System.EventHandler(this.kpi_Click);
			//
			// kpiWon
			//
			this.kpiWon.Clickable = true;
			this.kpiWon.CssClass = "relay-card";
			this.kpiWon.Dock = Wisej.Web.DockStyle.Fill;
			this.kpiWon.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/trophy.svg";
			this.kpiWon.Margin = new Wisej.Web.Padding(6);
			this.kpiWon.Name = "kpiWon";
			this.kpiWon.Size = new System.Drawing.Size(228, 158);
			this.kpiWon.TabIndex = 1;
			this.kpiWon.Title = "Won revenue";
			this.kpiWon.Tone = Wisej.Web.KpiTone.Success;
			this.kpiWon.TrendFormat = "+0.#\'%\';-0.#\'%\';0\'%\'";
			this.kpiWon.Value = "$0";
			this.kpiWon.Visual = Wisej.Web.KpiVisual.Sparkline;
			this.kpiWon.Click += new System.EventHandler(this.kpi_Click);
			//
			// kpiWinRate
			//
			this.kpiWinRate.Clickable = true;
			this.kpiWinRate.CssClass = "relay-card";
			this.kpiWinRate.Dock = Wisej.Web.DockStyle.Fill;
			this.kpiWinRate.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/bullseye.svg";
			this.kpiWinRate.Margin = new Wisej.Web.Padding(6);
			this.kpiWinRate.Name = "kpiWinRate";
			this.kpiWinRate.Size = new System.Drawing.Size(228, 158);
			this.kpiWinRate.TabIndex = 2;
			this.kpiWinRate.Title = "Win rate";
			this.kpiWinRate.Tone = Wisej.Web.KpiTone.Warning;
			this.kpiWinRate.Value = "0%";
			this.kpiWinRate.Visual = Wisej.Web.KpiVisual.Sparkline;
			this.kpiWinRate.Click += new System.EventHandler(this.kpi_Click);
			//
			// kpiAverage
			//
			this.kpiAverage.Clickable = true;
			this.kpiAverage.CssClass = "relay-card";
			this.kpiAverage.Dock = Wisej.Web.DockStyle.Fill;
			this.kpiAverage.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/cash-stack.svg";
			this.kpiAverage.Margin = new Wisej.Web.Padding(6);
			this.kpiAverage.Name = "kpiAverage";
			this.kpiAverage.Size = new System.Drawing.Size(228, 158);
			this.kpiAverage.TabIndex = 3;
			this.kpiAverage.Title = "Average deal size";
			this.kpiAverage.Value = "$0";
			this.kpiAverage.Visual = Wisej.Web.KpiVisual.Sparkline;
			this.kpiAverage.Click += new System.EventHandler(this.kpi_Click);
			//
			// tableCharts
			//
			this.tableCharts.ColumnCount = 3;
			this.tableCharts.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.333F));
			this.tableCharts.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.333F));
			this.tableCharts.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.333F));
			this.tableCharts.Controls.Add(this.groupPipeline, 0, 0);
			this.tableCharts.Controls.Add(this.groupWon, 1, 0);
			this.tableCharts.Controls.Add(this.groupOwners, 2, 0);
			this.tableCharts.Dock = Wisej.Web.DockStyle.Fill;
			this.tableCharts.Location = new System.Drawing.Point(10, 180);
			this.tableCharts.Margin = new Wisej.Web.Padding(0);
			this.tableCharts.Name = "tableCharts";
			this.tableCharts.RowCount = 1;
			this.tableCharts.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableCharts.Size = new System.Drawing.Size(963, 356);
			this.tableCharts.TabIndex = 1;
			//
			// groupPipeline
			//
			this.groupPipeline.Controls.Add(this.chartPipeline);
			this.groupPipeline.CssClass = "relay-card";
			this.groupPipeline.Dock = Wisej.Web.DockStyle.Fill;
			this.groupPipeline.Location = new System.Drawing.Point(6, 6);
			this.groupPipeline.Margin = new Wisej.Web.Padding(6);
			this.groupPipeline.Name = "groupPipeline";
			this.groupPipeline.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupPipeline.Size = new System.Drawing.Size(309, 344);
			this.groupPipeline.TabIndex = 0;
			this.groupPipeline.Text = "Pipeline by stage (open deals)";
			//
			// chartPipeline
			//
			series5.ChartType = Wisej.Web.ChartType.Bar;
			series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
			series5.Name = "Pipeline";
			this.chartPipeline.Dock = Wisej.Web.DockStyle.Fill;
			this.chartPipeline.EmptyState = "No open deals";
			this.chartPipeline.Legend = Wisej.Web.ChartLegend.Hidden;
			this.chartPipeline.Location = new System.Drawing.Point(8, 22);
			this.chartPipeline.Name = "chartPipeline";
			this.chartPipeline.Series.Add(series5);
			this.chartPipeline.Size = new System.Drawing.Size(293, 314);
			this.chartPipeline.TabIndex = 0;
			this.chartPipeline.PointClick += new System.EventHandler<Wisej.Web.SeriesPointEventArgs>(this.chart_PointClick);
			//
			// groupWon
			//
			this.groupWon.Controls.Add(this.chartWon);
			this.groupWon.CssClass = "relay-card";
			this.groupWon.Dock = Wisej.Web.DockStyle.Fill;
			this.groupWon.Location = new System.Drawing.Point(327, 6);
			this.groupWon.Margin = new Wisej.Web.Padding(6);
			this.groupWon.Name = "groupWon";
			this.groupWon.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupWon.Size = new System.Drawing.Size(309, 344);
			this.groupWon.TabIndex = 1;
			this.groupWon.Text = "Won revenue";
			//
			// chartWon
			//
			series6.ChartType = Wisej.Web.ChartType.Column;
			series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
			series6.Name = "Current";
			series7.ChartType = Wisej.Web.ChartType.Column;
			series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			series7.Name = "Previous";
			this.chartWon.Dock = Wisej.Web.DockStyle.Fill;
			this.chartWon.EmptyState = "No won deals";
			this.chartWon.Legend = Wisej.Web.ChartLegend.Bottom;
			this.chartWon.Location = new System.Drawing.Point(8, 22);
			this.chartWon.Name = "chartWon";
			this.chartWon.Series.Add(series6);
			this.chartWon.Series.Add(series7);
			this.chartWon.Size = new System.Drawing.Size(293, 314);
			this.chartWon.TabIndex = 0;
			this.chartWon.Tooltip = Wisej.Web.ChartTooltip.Shared;
			this.chartWon.PointClick += new System.EventHandler<Wisej.Web.SeriesPointEventArgs>(this.chart_PointClick);
			//
			// groupOwners
			//
			this.groupOwners.Controls.Add(this.chartOwners);
			this.groupOwners.CssClass = "relay-card";
			this.groupOwners.Dock = Wisej.Web.DockStyle.Fill;
			this.groupOwners.Location = new System.Drawing.Point(648, 6);
			this.groupOwners.Margin = new Wisej.Web.Padding(6);
			this.groupOwners.Name = "groupOwners";
			this.groupOwners.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupOwners.Size = new System.Drawing.Size(309, 344);
			this.groupOwners.TabIndex = 2;
			this.groupOwners.Text = "Open deals by owner";
			//
			// chartOwners
			//
			series8.ChartType = Wisej.Web.ChartType.Bar;
			series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
			series8.Name = "Owners";
			this.chartOwners.Dock = Wisej.Web.DockStyle.Fill;
			this.chartOwners.EmptyState = "No open deals";
			this.chartOwners.Legend = Wisej.Web.ChartLegend.Hidden;
			this.chartOwners.Location = new System.Drawing.Point(8, 22);
			this.chartOwners.Name = "chartOwners";
			this.chartOwners.Series.Add(series8);
			this.chartOwners.Size = new System.Drawing.Size(293, 314);
			this.chartOwners.TabIndex = 0;
			this.chartOwners.PointClick += new System.EventHandler<Wisej.Web.SeriesPointEventArgs>(this.chart_PointClick);
			//
			// tableLists
			//
			this.tableLists.ColumnCount = 2;
			this.tableLists.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLists.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableLists.Controls.Add(this.groupTasks, 0, 0);
			this.tableLists.Controls.Add(this.groupActivity, 1, 0);
			this.tableLists.Dock = Wisej.Web.DockStyle.Fill;
			this.tableLists.Location = new System.Drawing.Point(10, 536);
			this.tableLists.Margin = new Wisej.Web.Padding(0);
			this.tableLists.Name = "tableLists";
			this.tableLists.RowCount = 1;
			this.tableLists.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableLists.Size = new System.Drawing.Size(963, 317);
			this.tableLists.TabIndex = 2;
			//
			// groupTasks
			//
			this.groupTasks.Controls.Add(this.linkTasksAll);
			this.groupTasks.Controls.Add(this.emptyTasks);
			this.groupTasks.Controls.Add(this.listTasks);
			this.groupTasks.CssClass = "relay-card";
			this.groupTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.groupTasks.Location = new System.Drawing.Point(6, 6);
			this.groupTasks.Margin = new Wisej.Web.Padding(6);
			this.groupTasks.Name = "groupTasks";
			this.groupTasks.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupTasks.Size = new System.Drawing.Size(469, 305);
			this.groupTasks.TabIndex = 0;
			this.groupTasks.Text = "My tasks today";
			//
			// linkTasksAll
			//
			this.linkTasksAll.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.linkTasksAll.AutoSize = true;
			this.linkTasksAll.Location = new System.Drawing.Point(405, 0);
			this.linkTasksAll.Name = "linkTasksAll";
			this.linkTasksAll.Size = new System.Drawing.Size(50, 15);
			this.linkTasksAll.TabIndex = 8;
			this.linkTasksAll.TabStop = true;
			this.linkTasksAll.Text = "View all";
			this.linkTasksAll.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkTasksAll_LinkClicked);
			//
			// emptyTasks
			//
			this.emptyTasks.Compact = true;
			this.emptyTasks.Description = "No open tasks are due today.";
			this.emptyTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyTasks.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
			this.emptyTasks.Location = new System.Drawing.Point(8, 22);
			this.emptyTasks.Name = "emptyTasks";
			this.emptyTasks.Size = new System.Drawing.Size(453, 275);
			this.emptyTasks.TabIndex = 9;
			this.emptyTasks.Title = "You are all caught up.";
			this.emptyTasks.Visible = false;
			//
			// listTasks
			//
			this.listTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.listTasks.ItemHeight = 80;
			this.listTasks.ItemSpacing = 8;
			this.listTasks.Location = new System.Drawing.Point(8, 22);
			this.listTasks.Name = "listTasks";
			this.listTasks.Size = new System.Drawing.Size(453, 275);
			this.listTasks.TabIndex = 0;
			this.listTasks.ItemClick += new System.EventHandler<Wisej.Web.ActionCardListItemEventArgs>(this.listTasks_ItemClick);
			//
			// groupActivity
			//
			this.groupActivity.Controls.Add(this.linkActivityAll);
			this.groupActivity.Controls.Add(this.emptyActivity);
			this.groupActivity.Controls.Add(this.timelineActivity);
			this.groupActivity.CssClass = "relay-card";
			this.groupActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.groupActivity.Location = new System.Drawing.Point(487, 6);
			this.groupActivity.Margin = new Wisej.Web.Padding(6);
			this.groupActivity.Name = "groupActivity";
			this.groupActivity.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupActivity.Size = new System.Drawing.Size(470, 305);
			this.groupActivity.TabIndex = 1;
			this.groupActivity.Text = "Recent activity";
			//
			// linkActivityAll
			//
			this.linkActivityAll.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.linkActivityAll.AutoSize = true;
			this.linkActivityAll.Location = new System.Drawing.Point(406, 0);
			this.linkActivityAll.Name = "linkActivityAll";
			this.linkActivityAll.Size = new System.Drawing.Size(50, 15);
			this.linkActivityAll.TabIndex = 8;
			this.linkActivityAll.TabStop = true;
			this.linkActivityAll.Text = "View all";
			this.linkActivityAll.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkActivityAll_LinkClicked);
			//
			// emptyActivity
			//
			this.emptyActivity.Compact = true;
			this.emptyActivity.Description = "Calls, emails, meetings and notes appear here.";
			this.emptyActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyActivity.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.emptyActivity.Location = new System.Drawing.Point(8, 22);
			this.emptyActivity.Name = "emptyActivity";
			this.emptyActivity.Size = new System.Drawing.Size(454, 275);
			this.emptyActivity.TabIndex = 9;
			this.emptyActivity.Title = "No recent activity.";
			this.emptyActivity.Visible = false;
			//
			// timelineActivity
			//
			this.timelineActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.timelineActivity.Location = new System.Drawing.Point(8, 22);
			this.timelineActivity.Name = "timelineActivity";
			this.timelineActivity.Size = new System.Drawing.Size(454, 275);
			this.timelineActivity.TabIndex = 0;
			this.timelineActivity.TimeFormat = "MMM d, HH:mm";
			this.timelineActivity.ItemClick += new System.EventHandler<Wisej.Web.TimelineItemEventArgs>(this.timelineActivity_ItemClick);
			//
			// tableGrids
			//
			this.tableGrids.ColumnCount = 2;
			this.tableGrids.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableGrids.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableGrids.Controls.Add(this.groupClosing, 0, 0);
			this.tableGrids.Controls.Add(this.groupAccounts, 1, 0);
			this.tableGrids.Dock = Wisej.Web.DockStyle.Fill;
			this.tableGrids.Location = new System.Drawing.Point(10, 853);
			this.tableGrids.Margin = new Wisej.Web.Padding(0);
			this.tableGrids.Name = "tableGrids";
			this.tableGrids.RowCount = 1;
			this.tableGrids.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableGrids.Size = new System.Drawing.Size(963, 317);
			this.tableGrids.TabIndex = 3;
			//
			// groupClosing
			//
			this.groupClosing.Controls.Add(this.emptyClosing);
			this.groupClosing.Controls.Add(this.gridClosing);
			this.groupClosing.CssClass = "relay-card";
			this.groupClosing.Dock = Wisej.Web.DockStyle.Fill;
			this.groupClosing.Location = new System.Drawing.Point(6, 6);
			this.groupClosing.Margin = new Wisej.Web.Padding(6);
			this.groupClosing.Name = "groupClosing";
			this.groupClosing.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupClosing.Size = new System.Drawing.Size(469, 305);
			this.groupClosing.TabIndex = 0;
			this.groupClosing.Text = "Deals closing soon";
			//
			// emptyClosing
			//
			this.emptyClosing.Compact = true;
			this.emptyClosing.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyClosing.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/briefcase.svg";
			this.emptyClosing.Location = new System.Drawing.Point(8, 22);
			this.emptyClosing.Name = "emptyClosing";
			this.emptyClosing.Size = new System.Drawing.Size(453, 275);
			this.emptyClosing.TabIndex = 9;
			this.emptyClosing.Title = "No deals closing soon.";
			this.emptyClosing.Visible = false;
			//
			// gridClosing
			//
			this.gridClosing.AllowUserToAddRows = false;
			this.gridClosing.AllowUserToDeleteRows = false;
			this.gridClosing.AllowUserToResizeRows = false;
			this.gridClosing.BorderStyle = Wisej.Web.BorderStyle.None;
			this.gridClosing.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colClosingDeal,
			this.colClosingAmount,
			this.colClosingDate,
			this.colClosingProbability});
			this.gridClosing.CssClass = "relay-grid";
			this.gridClosing.Dock = Wisej.Web.DockStyle.Fill;
			this.gridClosing.Location = new System.Drawing.Point(8, 22);
			this.gridClosing.MultiSelect = false;
			this.gridClosing.Name = "gridClosing";
			this.gridClosing.ReadOnly = true;
			this.gridClosing.RowHeadersVisible = false;
			this.gridClosing.RowTemplate.Height = 48;
			this.gridClosing.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.gridClosing.Size = new System.Drawing.Size(453, 275);
			this.gridClosing.TabIndex = 0;
			this.gridClosing.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.gridClosing_CellDoubleClick);
			//
			// colClosingDeal
			//
			this.colClosingDeal.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colClosingDeal.DataPropertyName = "Title";
			this.colClosingDeal.HeaderText = "Deal";
			this.colClosingDeal.MinimumWidth = 140;
			this.colClosingDeal.Name = "colClosingDeal";
			this.colClosingDeal.SubtitleMember = "CompanyName";
			//
			// colClosingAmount
			//
			dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "C0";
			this.colClosingAmount.DataPropertyName = "Amount";
			this.colClosingAmount.DefaultCellStyle = dataGridViewCellStyle1;
			this.colClosingAmount.HeaderText = "Amount";
			this.colClosingAmount.Name = "colClosingAmount";
			this.colClosingAmount.Width = 90;
			//
			// colClosingDate
			//
			dataGridViewCellStyle2.Format = "MMM d";
			this.colClosingDate.DataPropertyName = "CloseDate";
			this.colClosingDate.DefaultCellStyle = dataGridViewCellStyle2;
			this.colClosingDate.HeaderText = "Close date";
			this.colClosingDate.Name = "colClosingDate";
			this.colClosingDate.Width = 90;
			//
			// colClosingProbability
			//
			this.colClosingProbability.DataPropertyName = "Probability";
			this.colClosingProbability.HeaderText = "Probability";
			this.colClosingProbability.Maximum = 100D;
			this.colClosingProbability.Name = "colClosingProbability";
			this.colClosingProbability.ShowText = true;
			this.colClosingProbability.TextMember = "ProbabilityText";
			this.colClosingProbability.Width = 110;
			//
			// groupAccounts
			//
			this.groupAccounts.Controls.Add(this.emptyAccounts);
			this.groupAccounts.Controls.Add(this.gridAccounts);
			this.groupAccounts.CssClass = "relay-card";
			this.groupAccounts.Dock = Wisej.Web.DockStyle.Fill;
			this.groupAccounts.Location = new System.Drawing.Point(487, 6);
			this.groupAccounts.Margin = new Wisej.Web.Padding(6);
			this.groupAccounts.Name = "groupAccounts";
			this.groupAccounts.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupAccounts.Size = new System.Drawing.Size(470, 305);
			this.groupAccounts.TabIndex = 1;
			this.groupAccounts.Text = "Top accounts";
			//
			// emptyAccounts
			//
			this.emptyAccounts.Compact = true;
			this.emptyAccounts.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyAccounts.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/building.svg";
			this.emptyAccounts.Location = new System.Drawing.Point(8, 22);
			this.emptyAccounts.Name = "emptyAccounts";
			this.emptyAccounts.Size = new System.Drawing.Size(454, 275);
			this.emptyAccounts.TabIndex = 9;
			this.emptyAccounts.Title = "No won revenue in this period.";
			this.emptyAccounts.Visible = false;
			//
			// gridAccounts
			//
			this.gridAccounts.AllowUserToAddRows = false;
			this.gridAccounts.AllowUserToDeleteRows = false;
			this.gridAccounts.AllowUserToResizeRows = false;
			this.gridAccounts.BorderStyle = Wisej.Web.BorderStyle.None;
			this.gridAccounts.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colAccountCompany,
			this.colAccountRevenue,
			this.colAccountDeals});
			this.gridAccounts.CssClass = "relay-grid";
			this.gridAccounts.Dock = Wisej.Web.DockStyle.Fill;
			this.gridAccounts.Location = new System.Drawing.Point(8, 22);
			this.gridAccounts.MultiSelect = false;
			this.gridAccounts.Name = "gridAccounts";
			this.gridAccounts.ReadOnly = true;
			this.gridAccounts.RowHeadersVisible = false;
			this.gridAccounts.RowTemplate.Height = 48;
			this.gridAccounts.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.gridAccounts.Size = new System.Drawing.Size(454, 275);
			this.gridAccounts.TabIndex = 0;
			this.gridAccounts.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.gridAccounts_CellDoubleClick);
			//
			// colAccountCompany
			//
			this.colAccountCompany.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colAccountCompany.DataPropertyName = "Company";
			this.colAccountCompany.HeaderText = "Company";
			this.colAccountCompany.MinimumWidth = 140;
			this.colAccountCompany.Name = "colAccountCompany";
			this.colAccountCompany.Shape = Wisej.Web.AvatarShape.Rounded;
			this.colAccountCompany.TextMember = "Company";
			//
			// colAccountRevenue
			//
			dataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "C0";
			this.colAccountRevenue.DataPropertyName = "WonRevenue";
			this.colAccountRevenue.DefaultCellStyle = dataGridViewCellStyle4;
			this.colAccountRevenue.HeaderText = "Won revenue";
			this.colAccountRevenue.Name = "colAccountRevenue";
			this.colAccountRevenue.Width = 110;
			//
			// colAccountDeals
			//
			dataGridViewCellStyle5.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colAccountDeals.DataPropertyName = "Deals";
			this.colAccountDeals.DefaultCellStyle = dataGridViewCellStyle5;
			this.colAccountDeals.HeaderText = "Deals";
			this.colAccountDeals.Name = "colAccountDeals";
			this.colAccountDeals.Width = 60;
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.labelPeriod);
			this.panelHeader.Controls.Add(this.labelGreeting);
			this.panelHeader.Controls.Add(this.buttonRefresh);
			this.panelHeader.Controls.Add(this.segmentedPeriod);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Padding = new Wisej.Web.Padding(16, 12, 16, 4);
			this.panelHeader.Size = new System.Drawing.Size(1000, 56);
			this.panelHeader.TabIndex = 0;
			//
			// labelPeriod
			//
			this.labelPeriod.CssClass = "relay-muted";
			this.labelPeriod.Dock = Wisej.Web.DockStyle.Fill;
			this.labelPeriod.Location = new System.Drawing.Point(316, 12);
			this.labelPeriod.Name = "labelPeriod";
			this.labelPeriod.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.labelPeriod.Size = new System.Drawing.Size(296, 40);
			this.labelPeriod.TabIndex = 1;
			this.labelPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// labelGreeting
			//
			this.labelGreeting.AppearanceKey = "relay-card-title";
						this.labelGreeting.Dock = Wisej.Web.DockStyle.Left;
			this.labelGreeting.Location = new System.Drawing.Point(16, 12);
			this.labelGreeting.Name = "labelGreeting";
			this.labelGreeting.Size = new System.Drawing.Size(300, 40);
			this.labelGreeting.TabIndex = 0;
			this.labelGreeting.Text = "Overview";
			this.labelGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonRefresh
			//
			this.buttonRefresh.CssClass = "relay-secondary";
			this.buttonRefresh.Display = Wisej.Web.Display.Icon;
			this.buttonRefresh.Dock = Wisej.Web.DockStyle.Right;
			this.buttonRefresh.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/arrow-clockwise.svg";
			this.buttonRefresh.Location = new System.Drawing.Point(612, 12);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(40, 40);
			this.buttonRefresh.TabIndex = 2;
			this.buttonRefresh.ToolTipText = "Refresh";
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			//
			// segmentedPeriod
			//
			this.segmentedPeriod.Dock = Wisej.Web.DockStyle.Right;
			segment1.Text = "This month";
			segment2.Text = "Quarter";
			segment3.Text = "Year";
			this.segmentedPeriod.Items.Add(segment1);
			this.segmentedPeriod.Items.Add(segment2);
			this.segmentedPeriod.Items.Add(segment3);
			this.segmentedPeriod.Location = new System.Drawing.Point(652, 12);
			this.segmentedPeriod.Name = "segmentedPeriod";
			this.segmentedPeriod.Padding = new Wisej.Web.Padding(12, 2, 0, 2);
			this.segmentedPeriod.SelectedIndex = 0;
			this.segmentedPeriod.Size = new System.Drawing.Size(332, 40);
			this.segmentedPeriod.TabIndex = 3;
			this.segmentedPeriod.SelectedIndexChanged += new System.EventHandler(this.segmentedPeriod_SelectedIndexChanged);
			//
			// DashboardView
			//
			this.Controls.Add(this.panelScroll);
			this.Controls.Add(this.panelHeader);
			this.Name = "DashboardView";
			this.Size = new System.Drawing.Size(1000, 640);
			this.Load += new System.EventHandler(this.DashboardView_Load);
			this.panelScroll.ResumeLayout(false);
			this.tableMain.ResumeLayout(false);
			this.tableKpis.ResumeLayout(false);
			this.tableCharts.ResumeLayout(false);
			this.groupPipeline.ResumeLayout(false);
			this.groupWon.ResumeLayout(false);
			this.groupOwners.ResumeLayout(false);
			this.tableLists.ResumeLayout(false);
			this.groupTasks.ResumeLayout(false);
			this.groupTasks.PerformLayout();
			this.groupActivity.ResumeLayout(false);
			this.groupActivity.PerformLayout();
			this.tableGrids.ResumeLayout(false);
			this.groupClosing.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridClosing)).EndInit();
			this.groupAccounts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).EndInit();
			this.panelHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelScroll;
		private Wisej.Web.TableLayoutPanel tableMain;
		private Wisej.Web.TableLayoutPanel tableKpis;
		private Wisej.Web.KpiPanel kpiPipeline;
		private Wisej.Web.KpiPanel kpiWon;
		private Wisej.Web.KpiPanel kpiWinRate;
		private Wisej.Web.KpiPanel kpiAverage;
		private Wisej.Web.TableLayoutPanel tableCharts;
		private Wisej.Web.GroupBox groupPipeline;
		private Wisej.Web.ChartView chartPipeline;
		private Wisej.Web.GroupBox groupWon;
		private Wisej.Web.ChartView chartWon;
		private Wisej.Web.GroupBox groupOwners;
		private Wisej.Web.ChartView chartOwners;
		private Wisej.Web.TableLayoutPanel tableLists;
		private Wisej.Web.GroupBox groupTasks;
		private Wisej.Web.LinkLabel linkTasksAll;
		private Wisej.Web.EmptyState emptyTasks;
		private Wisej.Web.ActionCardList listTasks;
		private Wisej.Web.GroupBox groupActivity;
		private Wisej.Web.LinkLabel linkActivityAll;
		private Wisej.Web.EmptyState emptyActivity;
		private Wisej.Web.Timeline timelineActivity;
		private Wisej.Web.TableLayoutPanel tableGrids;
		private Wisej.Web.GroupBox groupClosing;
		private Wisej.Web.EmptyState emptyClosing;
		private Wisej.Web.DataGridView gridClosing;
		private Wisej.Web.DataGridViewSubtitleColumn colClosingDeal;
		private Wisej.Web.DataGridViewTextBoxColumn colClosingAmount;
		private Wisej.Web.DataGridViewTextBoxColumn colClosingDate;
		private Wisej.Web.DataGridViewMeterColumn colClosingProbability;
		private Wisej.Web.GroupBox groupAccounts;
		private Wisej.Web.EmptyState emptyAccounts;
		private Wisej.Web.DataGridView gridAccounts;
		private Wisej.Web.DataGridViewAvatarColumn colAccountCompany;
		private Wisej.Web.DataGridViewTextBoxColumn colAccountRevenue;
		private Wisej.Web.DataGridViewTextBoxColumn colAccountDeals;
		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelPeriod;
		private Wisej.Web.Label labelGreeting;
		private Wisej.Web.Button buttonRefresh;
		private Wisej.Web.SegmentedButton segmentedPeriod;
	}
}
