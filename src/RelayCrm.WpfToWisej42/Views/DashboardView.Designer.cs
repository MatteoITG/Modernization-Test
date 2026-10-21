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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Wisej.Web.ChartSeries chartSeries1 = new Wisej.Web.ChartSeries();
			Wisej.Web.ChartSeries chartSeries2 = new Wisej.Web.ChartSeries();
			Wisej.Web.ChartSeries chartSeries3 = new Wisej.Web.ChartSeries();
			Wisej.Web.ChartSeries chartSeries4 = new Wisej.Web.ChartSeries();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment3 = new Wisej.Web.Segment();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelPeriod = new Wisej.Web.Label();
			this.labelGreeting = new Wisej.Web.Label();
			this.segmentedPeriod = new Wisej.Web.SegmentedButton();
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
			this.tableLists = new Wisej.Web.TableLayoutPanel();
			this.groupOwners = new Wisej.Web.GroupBox();
			this.chartOwners = new Wisej.Web.ChartView();
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
			this.panelHeader.SuspendLayout();
			this.panelScroll.SuspendLayout();
			this.tableMain.SuspendLayout();
			this.tableKpis.SuspendLayout();
			this.tableCharts.SuspendLayout();
			this.groupPipeline.SuspendLayout();
			this.groupWon.SuspendLayout();
			this.tableLists.SuspendLayout();
			this.groupOwners.SuspendLayout();
			this.groupTasks.SuspendLayout();
			this.groupActivity.SuspendLayout();
			this.tableGrids.SuspendLayout();
			this.groupClosing.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridClosing)).BeginInit();
			this.groupAccounts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).BeginInit();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.labelPeriod);
			this.panelHeader.Controls.Add(this.labelGreeting);
			this.panelHeader.Controls.Add(this.segmentedPeriod);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Padding = new Wisej.Web.Padding(16, 12, 16, 4);
			this.panelHeader.Size = new System.Drawing.Size(1090, 56);
			this.panelHeader.TabIndex = 0;
			//
			// labelPeriod
			//
			this.labelPeriod.CssClass = "relay-muted";
			this.labelPeriod.Dock = Wisej.Web.DockStyle.Fill;
			this.labelPeriod.Location = new System.Drawing.Point(316, 12);
			this.labelPeriod.Name = "labelPeriod";
			this.labelPeriod.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.labelPeriod.Size = new System.Drawing.Size(426, 40);
			this.labelPeriod.TabIndex = 1;
			this.labelPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// labelGreeting
			//
			this.labelGreeting.AppearanceKey = "relay-card-title";
			this.labelGreeting.Dock = Wisej.Web.DockStyle.Left;
			this.labelGreeting.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelGreeting.Location = new System.Drawing.Point(16, 12);
			this.labelGreeting.Name = "labelGreeting";
			this.labelGreeting.Size = new System.Drawing.Size(300, 40);
			this.labelGreeting.TabIndex = 0;
			this.labelGreeting.Text = "Overview";
			this.labelGreeting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// segmentedPeriod
			//
			this.segmentedPeriod.Dock = Wisej.Web.DockStyle.Right;
			segment1.Text = "This month";
			segment2.Text = "This quarter";
			segment3.Text = "This year";
			this.segmentedPeriod.Items.Add(segment1);
			this.segmentedPeriod.Items.Add(segment2);
			this.segmentedPeriod.Items.Add(segment3);
			this.segmentedPeriod.Location = new System.Drawing.Point(742, 12);
			this.segmentedPeriod.Name = "segmentedPeriod";
			this.segmentedPeriod.Padding = new Wisej.Web.Padding(12, 2, 0, 2);
			this.segmentedPeriod.SelectedIndex = 0;
			this.segmentedPeriod.Size = new System.Drawing.Size(332, 40);
			this.segmentedPeriod.TabIndex = 2;
			this.segmentedPeriod.ToolTipText = "Period";
			this.segmentedPeriod.SelectedIndexChanged += new System.EventHandler(this.segmentedPeriod_SelectedIndexChanged);
			//
			// panelScroll
			//
			this.panelScroll.AutoScroll = true;
			this.panelScroll.AutoScrollMinSize = new System.Drawing.Size(900, 1170);
			this.panelScroll.Controls.Add(this.tableMain);
			this.panelScroll.Dock = Wisej.Web.DockStyle.Fill;
			this.panelScroll.Location = new System.Drawing.Point(0, 56);
			this.panelScroll.Name = "panelScroll";
			this.panelScroll.Size = new System.Drawing.Size(1090, 672);
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
			this.tableMain.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 340F));
			this.tableMain.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 330F));
			this.tableMain.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 310F));
			this.tableMain.Size = new System.Drawing.Size(1073, 1170);
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
			this.tableKpis.Size = new System.Drawing.Size(1053, 170);
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
			this.kpiPipeline.Size = new System.Drawing.Size(251, 158);
			this.kpiPipeline.TabIndex = 0;
			this.kpiPipeline.Title = "Open pipeline";
			this.kpiPipeline.ToolTipText = "Show the open deals";
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
			this.kpiWon.Size = new System.Drawing.Size(251, 158);
			this.kpiWon.TabIndex = 1;
			this.kpiWon.Title = "Won revenue";
			this.kpiWon.Tone = Wisej.Web.KpiTone.Success;
			this.kpiWon.ToolTipText = "Show the deals won in the period";
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
			this.kpiWinRate.Size = new System.Drawing.Size(251, 158);
			this.kpiWinRate.TabIndex = 2;
			this.kpiWinRate.Title = "Win rate";
			this.kpiWinRate.Tone = Wisej.Web.KpiTone.Warning;
			this.kpiWinRate.ToolTipText = "Show the deals closing in the period";
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
			this.kpiAverage.Size = new System.Drawing.Size(251, 158);
			this.kpiAverage.TabIndex = 3;
			this.kpiAverage.Title = "Average deal size";
			this.kpiAverage.ToolTipText = "Show the deals won in the period";
			this.kpiAverage.Value = "$0";
			this.kpiAverage.Visual = Wisej.Web.KpiVisual.Sparkline;
			this.kpiAverage.Click += new System.EventHandler(this.kpi_Click);
			//
			// tableCharts
			//
			this.tableCharts.ColumnCount = 2;
			this.tableCharts.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableCharts.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableCharts.Controls.Add(this.groupPipeline, 0, 0);
			this.tableCharts.Controls.Add(this.groupWon, 1, 0);
			this.tableCharts.Dock = Wisej.Web.DockStyle.Fill;
			this.tableCharts.Location = new System.Drawing.Point(10, 180);
			this.tableCharts.Margin = new Wisej.Web.Padding(0);
			this.tableCharts.Name = "tableCharts";
			this.tableCharts.RowCount = 1;
			this.tableCharts.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableCharts.Size = new System.Drawing.Size(1053, 340);
			this.tableCharts.TabIndex = 1;
			//
			// groupPipeline
			//
			this.groupPipeline.Controls.Add(this.chartPipeline);
			this.groupPipeline.CssClass = "relay-card";
			this.groupPipeline.Dock = Wisej.Web.DockStyle.Fill;
			this.groupPipeline.Margin = new Wisej.Web.Padding(6);
			this.groupPipeline.Name = "groupPipeline";
			this.groupPipeline.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupPipeline.Size = new System.Drawing.Size(514, 328);
			this.groupPipeline.TabIndex = 0;
			this.groupPipeline.Text = "Pipeline by stage";
			//
			// chartPipeline
			//
			chartSeries1.ChartType = Wisej.Web.ChartType.Bar;
			chartSeries1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
			chartSeries1.Name = "Open value";
			this.chartPipeline.Dock = Wisej.Web.DockStyle.Fill;
			this.chartPipeline.EmptyState = "No open stages";
			this.chartPipeline.Legend = Wisej.Web.ChartLegend.Hidden;
			this.chartPipeline.Name = "chartPipeline";
			this.chartPipeline.Series.Add(chartSeries1);
			this.chartPipeline.Size = new System.Drawing.Size(498, 298);
			this.chartPipeline.TabIndex = 0;
			this.chartPipeline.PointClick += new System.EventHandler<Wisej.Web.SeriesPointEventArgs>(this.chart_PointClick);
			//
			// groupWon
			//
			this.groupWon.Controls.Add(this.chartWon);
			this.groupWon.CssClass = "relay-card";
			this.groupWon.Dock = Wisej.Web.DockStyle.Fill;
			this.groupWon.Margin = new Wisej.Web.Padding(6);
			this.groupWon.Name = "groupWon";
			this.groupWon.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupWon.Size = new System.Drawing.Size(515, 328);
			this.groupWon.TabIndex = 1;
			this.groupWon.Text = "Won revenue per week";
			//
			// chartWon
			//
			chartSeries2.ChartType = Wisej.Web.ChartType.Column;
			chartSeries2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
			chartSeries2.Name = "Current";
			chartSeries3.ChartType = Wisej.Web.ChartType.Column;
			chartSeries3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
			chartSeries3.Name = "Previous";
			this.chartWon.Dock = Wisej.Web.DockStyle.Fill;
			this.chartWon.EmptyState = "No won deals";
			this.chartWon.Legend = Wisej.Web.ChartLegend.Bottom;
			this.chartWon.Name = "chartWon";
			this.chartWon.Series.Add(chartSeries2);
			this.chartWon.Series.Add(chartSeries3);
			this.chartWon.Size = new System.Drawing.Size(499, 298);
			this.chartWon.TabIndex = 0;
			this.chartWon.PointClick += new System.EventHandler<Wisej.Web.SeriesPointEventArgs>(this.chart_PointClick);
			//
			// tableLists
			//
			this.tableLists.ColumnCount = 3;
			this.tableLists.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.33F));
			this.tableLists.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.34F));
			this.tableLists.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.33F));
			this.tableLists.Controls.Add(this.groupOwners, 0, 0);
			this.tableLists.Controls.Add(this.groupTasks, 1, 0);
			this.tableLists.Controls.Add(this.groupActivity, 2, 0);
			this.tableLists.Dock = Wisej.Web.DockStyle.Fill;
			this.tableLists.Location = new System.Drawing.Point(10, 520);
			this.tableLists.Margin = new Wisej.Web.Padding(0);
			this.tableLists.Name = "tableLists";
			this.tableLists.RowCount = 1;
			this.tableLists.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableLists.Size = new System.Drawing.Size(1053, 330);
			this.tableLists.TabIndex = 2;
			//
			// groupOwners
			//
			this.groupOwners.Controls.Add(this.chartOwners);
			this.groupOwners.CssClass = "relay-card";
			this.groupOwners.Dock = Wisej.Web.DockStyle.Fill;
			this.groupOwners.Margin = new Wisej.Web.Padding(6);
			this.groupOwners.Name = "groupOwners";
			this.groupOwners.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupOwners.Size = new System.Drawing.Size(339, 318);
			this.groupOwners.TabIndex = 0;
			this.groupOwners.Text = "Open pipeline by owner";
			//
			// chartOwners
			//
			chartSeries4.ChartType = Wisej.Web.ChartType.Bar;
			chartSeries4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
			chartSeries4.Name = "Open value";
			this.chartOwners.Dock = Wisej.Web.DockStyle.Fill;
			this.chartOwners.EmptyState = "No open deals";
			this.chartOwners.Legend = Wisej.Web.ChartLegend.Hidden;
			this.chartOwners.Name = "chartOwners";
			this.chartOwners.Series.Add(chartSeries4);
			this.chartOwners.Size = new System.Drawing.Size(323, 288);
			this.chartOwners.TabIndex = 0;
			this.chartOwners.PointClick += new System.EventHandler<Wisej.Web.SeriesPointEventArgs>(this.chart_PointClick);
			//
			// groupTasks
			//
			this.groupTasks.Controls.Add(this.linkTasksAll);
			this.groupTasks.Controls.Add(this.emptyTasks);
			this.groupTasks.Controls.Add(this.listTasks);
			this.groupTasks.CssClass = "relay-card";
			this.groupTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.groupTasks.Margin = new Wisej.Web.Padding(6);
			this.groupTasks.Name = "groupTasks";
			this.groupTasks.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupTasks.Size = new System.Drawing.Size(339, 318);
			this.groupTasks.TabIndex = 1;
			this.groupTasks.Text = "My tasks today";
			//
			// linkTasksAll
			//
			this.linkTasksAll.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.linkTasksAll.AutoSize = true;
			this.linkTasksAll.Location = new System.Drawing.Point(270, 0);
			this.linkTasksAll.Name = "linkTasksAll";
			this.linkTasksAll.Size = new System.Drawing.Size(55, 15);
			this.linkTasksAll.TabIndex = 2;
			this.linkTasksAll.TabStop = true;
			this.linkTasksAll.Text = "All tasks";
			this.linkTasksAll.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkTasksAll_LinkClicked);
			//
			// emptyTasks
			//
			this.emptyTasks.Compact = true;
			this.emptyTasks.Description = "Nothing due today. Enjoy the calm.";
			this.emptyTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyTasks.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
			this.emptyTasks.Name = "emptyTasks";
			this.emptyTasks.Size = new System.Drawing.Size(323, 288);
			this.emptyTasks.TabIndex = 1;
			this.emptyTasks.Title = "You are all caught up.";
			this.emptyTasks.Visible = false;
			//
			// listTasks
			//
			this.listTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.listTasks.ItemHeight = 80;
			this.listTasks.ItemSpacing = 8;
			this.listTasks.Name = "listTasks";
			this.listTasks.Size = new System.Drawing.Size(323, 288);
			this.listTasks.TabIndex = 0;
			this.listTasks.ToolTipText = "Click a task to edit it";
			this.listTasks.ItemClick += new System.EventHandler<Wisej.Web.ActionCardListItemEventArgs>(this.listTasks_ItemClick);
			//
			// groupActivity
			//
			this.groupActivity.Controls.Add(this.linkActivityAll);
			this.groupActivity.Controls.Add(this.emptyActivity);
			this.groupActivity.Controls.Add(this.timelineActivity);
			this.groupActivity.CssClass = "relay-card";
			this.groupActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.groupActivity.Margin = new Wisej.Web.Padding(6);
			this.groupActivity.Name = "groupActivity";
			this.groupActivity.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupActivity.Size = new System.Drawing.Size(339, 318);
			this.groupActivity.TabIndex = 2;
			this.groupActivity.Text = "Recent activity";
			//
			// linkActivityAll
			//
			this.linkActivityAll.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.linkActivityAll.AutoSize = true;
			this.linkActivityAll.Location = new System.Drawing.Point(254, 0);
			this.linkActivityAll.Name = "linkActivityAll";
			this.linkActivityAll.Size = new System.Drawing.Size(71, 15);
			this.linkActivityAll.TabIndex = 2;
			this.linkActivityAll.TabStop = true;
			this.linkActivityAll.Text = "All activities";
			this.linkActivityAll.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkActivityAll_LinkClicked);
			//
			// emptyActivity
			//
			this.emptyActivity.Compact = true;
			this.emptyActivity.Description = "Calls, emails, meetings and notes appear here.";
			this.emptyActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyActivity.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.emptyActivity.Name = "emptyActivity";
			this.emptyActivity.Size = new System.Drawing.Size(323, 288);
			this.emptyActivity.TabIndex = 1;
			this.emptyActivity.Title = "No activity yet.";
			this.emptyActivity.Visible = false;
			//
			// timelineActivity
			//
			this.timelineActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.timelineActivity.HasMoreItems = false;
			this.timelineActivity.Name = "timelineActivity";
			this.timelineActivity.Size = new System.Drawing.Size(323, 288);
			this.timelineActivity.TabIndex = 0;
			this.timelineActivity.TimeFormat = "MMM d";
			this.timelineActivity.ToolTipText = "Click an activity to open the related record";
			this.timelineActivity.ItemClick += new System.EventHandler<Wisej.Web.TimelineItemEventArgs>(this.timelineActivity_ItemClick);
			//
			// tableGrids
			//
			this.tableGrids.ColumnCount = 2;
			this.tableGrids.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 60F));
			this.tableGrids.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 40F));
			this.tableGrids.Controls.Add(this.groupClosing, 0, 0);
			this.tableGrids.Controls.Add(this.groupAccounts, 1, 0);
			this.tableGrids.Dock = Wisej.Web.DockStyle.Fill;
			this.tableGrids.Location = new System.Drawing.Point(10, 850);
			this.tableGrids.Margin = new Wisej.Web.Padding(0);
			this.tableGrids.Name = "tableGrids";
			this.tableGrids.RowCount = 1;
			this.tableGrids.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableGrids.Size = new System.Drawing.Size(1053, 310);
			this.tableGrids.TabIndex = 3;
			//
			// groupClosing
			//
			this.groupClosing.Controls.Add(this.emptyClosing);
			this.groupClosing.Controls.Add(this.gridClosing);
			this.groupClosing.CssClass = "relay-card";
			this.groupClosing.Dock = Wisej.Web.DockStyle.Fill;
			this.groupClosing.Margin = new Wisej.Web.Padding(6);
			this.groupClosing.Name = "groupClosing";
			this.groupClosing.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupClosing.Size = new System.Drawing.Size(620, 298);
			this.groupClosing.TabIndex = 0;
			this.groupClosing.Text = "Deals closing in the next 30 days";
			//
			// emptyClosing
			//
			this.emptyClosing.Compact = true;
			this.emptyClosing.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyClosing.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/briefcase.svg";
			this.emptyClosing.Name = "emptyClosing";
			this.emptyClosing.Size = new System.Drawing.Size(604, 268);
			this.emptyClosing.TabIndex = 1;
			this.emptyClosing.Title = "No open deals close in the next 30 days.";
			this.emptyClosing.Visible = false;
			//
			// gridClosing
			//
			this.gridClosing.AllowUserToAddRows = false;
			this.gridClosing.AllowUserToDeleteRows = false;
			this.gridClosing.AllowUserToResizeRows = false;
			this.gridClosing.AutoGenerateColumns = false;
			this.gridClosing.BorderStyle = Wisej.Web.BorderStyle.None;
			this.gridClosing.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colClosingDeal,
			this.colClosingAmount,
			this.colClosingDate,
			this.colClosingProbability});
			this.gridClosing.CssClass = "relay-grid";
			this.gridClosing.Dock = Wisej.Web.DockStyle.Fill;
			this.gridClosing.MultiSelect = false;
			this.gridClosing.Name = "gridClosing";
			this.gridClosing.ReadOnly = true;
			this.gridClosing.RowHeadersVisible = false;
			this.gridClosing.RowTemplate.Height = 48;
			this.gridClosing.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.gridClosing.ShowColumnVisibilityMenu = false;
			this.gridClosing.Size = new System.Drawing.Size(604, 268);
			this.gridClosing.TabIndex = 0;
			this.gridClosing.ToolTipText = "Double-click to open the deal";
			this.gridClosing.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.gridClosing_CellDoubleClick);
			//
			// colClosingDeal
			//
			this.colClosingDeal.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colClosingDeal.DataPropertyName = "Title";
			this.colClosingDeal.HeaderText = "Deal";
			this.colClosingDeal.MinimumWidth = 160;
			this.colClosingDeal.Name = "colClosingDeal";
			this.colClosingDeal.SubtitleMember = "CompanyName";
			//
			// colClosingAmount
			//
			dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colClosingAmount.DataPropertyName = "Amount";
			this.colClosingAmount.DefaultCellStyle = dataGridViewCellStyle1;
			this.colClosingAmount.HeaderText = "Amount";
			this.colClosingAmount.Name = "colClosingAmount";
			this.colClosingAmount.Tag = "Fmt:Money";
			this.colClosingAmount.Width = 100;
			//
			// colClosingDate
			//
			this.colClosingDate.DataPropertyName = "CloseDate";
			this.colClosingDate.HeaderText = "Close date";
			this.colClosingDate.Name = "colClosingDate";
			this.colClosingDate.Tag = "Fmt:Date";
			this.colClosingDate.Width = 110;
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
			this.groupAccounts.Margin = new Wisej.Web.Padding(6);
			this.groupAccounts.Name = "groupAccounts";
			this.groupAccounts.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupAccounts.Size = new System.Drawing.Size(409, 298);
			this.groupAccounts.TabIndex = 1;
			this.groupAccounts.Text = "Top accounts";
			//
			// emptyAccounts
			//
			this.emptyAccounts.Compact = true;
			this.emptyAccounts.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyAccounts.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/building.svg";
			this.emptyAccounts.Name = "emptyAccounts";
			this.emptyAccounts.Size = new System.Drawing.Size(393, 268);
			this.emptyAccounts.TabIndex = 1;
			this.emptyAccounts.Title = "No deals won in this period yet.";
			this.emptyAccounts.Visible = false;
			//
			// gridAccounts
			//
			this.gridAccounts.AllowUserToAddRows = false;
			this.gridAccounts.AllowUserToDeleteRows = false;
			this.gridAccounts.AllowUserToResizeRows = false;
			this.gridAccounts.AutoGenerateColumns = false;
			this.gridAccounts.BorderStyle = Wisej.Web.BorderStyle.None;
			this.gridAccounts.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colAccountCompany,
			this.colAccountRevenue,
			this.colAccountDeals});
			this.gridAccounts.CssClass = "relay-grid";
			this.gridAccounts.Dock = Wisej.Web.DockStyle.Fill;
			this.gridAccounts.MultiSelect = false;
			this.gridAccounts.Name = "gridAccounts";
			this.gridAccounts.ReadOnly = true;
			this.gridAccounts.RowHeadersVisible = false;
			this.gridAccounts.RowTemplate.Height = 48;
			this.gridAccounts.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.gridAccounts.ShowColumnVisibilityMenu = false;
			this.gridAccounts.Size = new System.Drawing.Size(393, 268);
			this.gridAccounts.TabIndex = 0;
			this.gridAccounts.ToolTipText = "Double-click to open the company";
			this.gridAccounts.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.gridAccounts_CellDoubleClick);
			//
			// colAccountCompany
			//
			this.colAccountCompany.AutoColor = true;
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
			dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colAccountRevenue.DataPropertyName = "WonRevenue";
			this.colAccountRevenue.DefaultCellStyle = dataGridViewCellStyle2;
			this.colAccountRevenue.HeaderText = "Won revenue";
			this.colAccountRevenue.Name = "colAccountRevenue";
			this.colAccountRevenue.Tag = "Fmt:Money";
			this.colAccountRevenue.Width = 110;
			//
			// colAccountDeals
			//
			dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colAccountDeals.DataPropertyName = "Deals";
			this.colAccountDeals.DefaultCellStyle = dataGridViewCellStyle3;
			this.colAccountDeals.HeaderText = "Deals";
			this.colAccountDeals.Name = "colAccountDeals";
			this.colAccountDeals.Width = 64;
			//
			// DashboardView
			//
			this.Controls.Add(this.panelScroll);
			this.Controls.Add(this.panelHeader);
			this.Name = "DashboardView";
			this.Size = new System.Drawing.Size(1090, 728);
			this.Load += new System.EventHandler(this.DashboardView_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelScroll.ResumeLayout(false);
			this.tableMain.ResumeLayout(false);
			this.tableKpis.ResumeLayout(false);
			this.tableCharts.ResumeLayout(false);
			this.groupPipeline.ResumeLayout(false);
			this.groupWon.ResumeLayout(false);
			this.tableLists.ResumeLayout(false);
			this.groupOwners.ResumeLayout(false);
			this.groupTasks.ResumeLayout(false);
			this.groupTasks.PerformLayout();
			this.groupActivity.ResumeLayout(false);
			this.groupActivity.PerformLayout();
			this.tableGrids.ResumeLayout(false);
			this.groupClosing.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridClosing)).EndInit();
			this.groupAccounts.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridAccounts)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelGreeting;
		private Wisej.Web.Label labelPeriod;
		private Wisej.Web.SegmentedButton segmentedPeriod;
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
		private Wisej.Web.TableLayoutPanel tableLists;
		private Wisej.Web.GroupBox groupOwners;
		private Wisej.Web.ChartView chartOwners;
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
	}
}
