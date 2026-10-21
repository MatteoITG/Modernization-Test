namespace RelayCrm.Views
{
	partial class CompaniesView
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompaniesView));
			Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment3 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment4 = new Wisej.Web.Segment();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelCount = new Wisej.Web.Label();
			this.buttonNew = new Wisej.Web.Button();
			this.flowTools = new Wisej.Web.FlowLayoutPanel();
			this.buttonAdvanced = new Wisej.Web.Button();
			this.buttonColumns = new Wisej.Web.Button();
			this.buttonExport = new Wisej.Web.Button();
			this.panelSearch = new Wisej.Web.Panel();
			this.chipsQuick = new Wisej.Web.ChipGroup();
			this.textBoxSearch = new Wisej.Web.TextBox();
			this.panelFilter = new Wisej.Web.FlowLayoutPanel();
			this.labelFilter = new Wisej.Web.Label();
			this.runFilter = new Wisej.Web.Label();
			this.linkClearFilter = new Wisej.Web.LinkLabel();
			this.panelPager = new Wisej.Web.Panel();
			this.labelPage = new Wisej.Web.Label();
			this.flowPager = new Wisej.Web.FlowLayoutPanel();
			this.buttonPrevious = new Wisej.Web.Button();
			this.buttonNext = new Wisej.Web.Button();
			this.panelGrid = new Wisej.Web.Panel();
			this.emptyState = new Wisej.Web.EmptyState();
			this.grid = new Wisej.Web.DataGridView();
			this.colName = new Wisej.Web.DataGridViewAvatarColumn();
			this.colIndustry = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colSize = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCountry = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCity = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOwner = new Wisej.Web.DataGridViewAvatarColumn();
			this.colContacts = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOpenDeals = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOpenValue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colWonRevenue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colWonTrend = new Wisej.Web.DataGridViewSparklineColumn();
			this.colAnnualRevenue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTag = new Wisej.Web.DataGridViewChipColumn();
			this.colTags = new Wisej.Web.DataGridViewTextBoxColumn();
			this.contextMenuGrid = new Wisej.Web.ContextMenu(this.components);
			this.menuOpen = new Wisej.Web.MenuItem();
			this.menuEdit = new Wisej.Web.MenuItem();
			this.menuSeparator1 = new Wisej.Web.MenuItem();
			this.menuLogActivity = new Wisej.Web.MenuItem();
			this.menuNewDeal = new Wisej.Web.MenuItem();
			this.menuSeparator2 = new Wisej.Web.MenuItem();
			this.menuDelete = new Wisej.Web.MenuItem();
			this.menuColumns = new Wisej.Web.ContextMenu(this.components);
			this.panelHeader.SuspendLayout();
			this.flowTools.SuspendLayout();
			this.panelSearch.SuspendLayout();
			this.panelFilter.SuspendLayout();
			this.panelPager.SuspendLayout();
			this.flowPager.SuspendLayout();
			this.panelGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.labelCount);
			this.panelHeader.Controls.Add(this.buttonNew);
			this.panelHeader.Controls.Add(this.flowTools);
			this.panelHeader.CssClass = "relay-toolbar";
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelHeader.ResponsiveProfiles"))));
			this.panelHeader.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelHeader.ResponsiveProfiles1"))));
			this.panelHeader.Padding = new Wisej.Web.Padding(12, 10, 12, 10);
			this.panelHeader.Size = new System.Drawing.Size(1000, 56);
			this.panelHeader.TabIndex = 0;
			//
			// labelCount
			//
			this.labelCount.AutoEllipsis = true;
			this.labelCount.CssClass = "relay-muted";
			this.labelCount.Dock = Wisej.Web.DockStyle.Fill;
			this.labelCount.Location = new System.Drawing.Point(162, 10);
			this.labelCount.Name = "labelCount";
			this.labelCount.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.labelCount.Size = new System.Drawing.Size(372, 36);
			this.labelCount.TabIndex = 1;
			this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonNew
			//
			this.buttonNew.CssClass = "relay-primary";
			this.buttonNew.Dock = Wisej.Web.DockStyle.Left;
			this.buttonNew.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus.svg";
			this.buttonNew.Location = new System.Drawing.Point(12, 10);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(150, 36);
			this.buttonNew.TabIndex = 0;
			this.buttonNew.Text = "New company...";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// flowTools
			//
			this.flowTools.Controls.Add(this.buttonAdvanced);
			this.flowTools.Controls.Add(this.buttonColumns);
			this.flowTools.Controls.Add(this.buttonExport);
			this.flowTools.Dock = Wisej.Web.DockStyle.Right;
			this.flowTools.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowTools.Location = new System.Drawing.Point(534, 10);
			this.flowTools.Name = "flowTools";
			this.flowTools.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flowTools.ResponsiveProfiles"))));
			this.flowTools.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flowTools.ResponsiveProfiles1"))));
			this.flowTools.Size = new System.Drawing.Size(454, 36);
			this.flowTools.TabIndex = 2;
			this.flowTools.TabStop = true;
			//
			// buttonAdvanced
			//
			this.buttonAdvanced.CssClass = "relay-secondary";
			this.buttonAdvanced.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/funnel.svg";
			this.buttonAdvanced.Location = new System.Drawing.Point(294, 0);
			this.buttonAdvanced.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonAdvanced.Name = "buttonAdvanced";
			this.buttonAdvanced.Size = new System.Drawing.Size(160, 36);
			this.buttonAdvanced.TabIndex = 2;
			this.buttonAdvanced.Text = "Advanced filter...";
			this.buttonAdvanced.Click += new System.EventHandler(this.buttonAdvanced_Click);
			//
			// buttonColumns
			//
			this.buttonColumns.CssClass = "relay-secondary";
			this.buttonColumns.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/layout-three-columns.svg";
			this.buttonColumns.Location = new System.Drawing.Point(166, 0);
			this.buttonColumns.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonColumns.Name = "buttonColumns";
			this.buttonColumns.Size = new System.Drawing.Size(120, 36);
			this.buttonColumns.TabIndex = 1;
			this.buttonColumns.Text = "Columns";
			this.buttonColumns.Click += new System.EventHandler(this.buttonColumns_Click);
			//
			// buttonExport
			//
			this.buttonExport.CssClass = "relay-secondary";
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/download.svg";
			this.buttonExport.Location = new System.Drawing.Point(18, 0);
			this.buttonExport.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(140, 36);
			this.buttonExport.TabIndex = 0;
			this.buttonExport.Text = "Export CSV";
			this.buttonExport.ToolTipText = "Exports every matching company, not only this page";
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			//
			// panelSearch
			//
			this.panelSearch.Controls.Add(this.chipsQuick);
			this.panelSearch.Controls.Add(this.textBoxSearch);
			this.panelSearch.Dock = Wisej.Web.DockStyle.Top;
			this.panelSearch.Location = new System.Drawing.Point(0, 56);
			this.panelSearch.Name = "panelSearch";
			this.panelSearch.Padding = new Wisej.Web.Padding(12, 8, 12, 8);
			this.panelSearch.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelSearch.ResponsiveProfiles"))));
			this.panelSearch.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelSearch.ResponsiveProfiles1"))));
			this.panelSearch.Size = new System.Drawing.Size(1000, 56);
			this.panelSearch.TabIndex = 1;
			//
			// chipsQuick
			//
			this.chipsQuick.Dock = Wisej.Web.DockStyle.Fill;
			segment1.Text = "All";
			segment2.Text = "My companies";
			segment3.Text = "With open deals";
			segment4.Text = "Customers";
			this.chipsQuick.Items.Add(segment1);
			this.chipsQuick.Items.Add(segment2);
			this.chipsQuick.Items.Add(segment3);
			this.chipsQuick.Items.Add(segment4);
			this.chipsQuick.Location = new System.Drawing.Point(292, 8);
			this.chipsQuick.Name = "chipsQuick";
			this.chipsQuick.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.chipsQuick.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("chipsQuick.ResponsiveProfiles"))));
			this.chipsQuick.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("chipsQuick.ResponsiveProfiles1"))));
			this.chipsQuick.SelectedIndex = 0;
			this.chipsQuick.ShowCounts = true;
			this.chipsQuick.Size = new System.Drawing.Size(696, 40);
			this.chipsQuick.TabIndex = 1;
			this.chipsQuick.SelectedIndexChanged += new System.EventHandler(this.chipsQuick_SelectedIndexChanged);
			//
			// textBoxSearch
			//
			this.textBoxSearch.CssClass = "relay-search";
			this.textBoxSearch.Dock = Wisej.Web.DockStyle.Left;
			this.textBoxSearch.Location = new System.Drawing.Point(12, 8);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("textBoxSearch.ResponsiveProfiles"))));
			this.textBoxSearch.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("textBoxSearch.ResponsiveProfiles1"))));
			this.textBoxSearch.Size = new System.Drawing.Size(280, 40);
			this.textBoxSearch.TabIndex = 0;
			componentTool1.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/x-lg.svg";
			componentTool1.Name = "clear";
			componentTool1.ToolTipText = "Clear the search";
			this.textBoxSearch.Tools.AddRange(new Wisej.Web.ComponentTool[] {
			componentTool1});
			this.textBoxSearch.Watermark = "Search name, industry, place, owner or tag";
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			this.textBoxSearch.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textBoxSearch_ToolClick);
			//
			// panelFilter
			//
			this.panelFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
			this.panelFilter.Controls.Add(this.labelFilter);
			this.panelFilter.Controls.Add(this.runFilter);
			this.panelFilter.Controls.Add(this.linkClearFilter);
			this.panelFilter.Dock = Wisej.Web.DockStyle.Top;
			this.panelFilter.Location = new System.Drawing.Point(0, 112);
			this.panelFilter.Name = "panelFilter";
			this.panelFilter.Padding = new Wisej.Web.Padding(12, 4, 12, 4);
			this.panelFilter.Size = new System.Drawing.Size(1000, 32);
			this.panelFilter.TabIndex = 2;
			this.panelFilter.TabStop = true;
			this.panelFilter.Visible = false;
			//
			// labelFilter
			//
			this.labelFilter.AutoSize = true;
			this.labelFilter.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelFilter.Location = new System.Drawing.Point(12, 7);
			this.labelFilter.Margin = new Wisej.Web.Padding(0, 3, 4, 0);
			this.labelFilter.Name = "labelFilter";
			this.labelFilter.Size = new System.Drawing.Size(38, 16);
			this.labelFilter.TabIndex = 0;
			this.labelFilter.Text = "Filter:";
			//
			// runFilter
			//
			this.runFilter.AutoSize = true;
			this.runFilter.Location = new System.Drawing.Point(54, 7);
			this.runFilter.Margin = new Wisej.Web.Padding(0, 3, 12, 0);
			this.runFilter.Name = "runFilter";
			this.runFilter.Size = new System.Drawing.Size(4, 16);
			this.runFilter.TabIndex = 1;
			//
			// linkClearFilter
			//
			this.linkClearFilter.AutoSize = true;
			this.linkClearFilter.Location = new System.Drawing.Point(70, 7);
			this.linkClearFilter.Margin = new Wisej.Web.Padding(0, 3, 0, 0);
			this.linkClearFilter.Name = "linkClearFilter";
			this.linkClearFilter.Size = new System.Drawing.Size(35, 16);
			this.linkClearFilter.TabIndex = 2;
			this.linkClearFilter.TabStop = true;
			this.linkClearFilter.Text = "Clear";
			this.linkClearFilter.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkClearFilter_LinkClicked);
			//
			// panelPager
			//
			this.panelPager.Controls.Add(this.labelPage);
			this.panelPager.Controls.Add(this.flowPager);
			this.panelPager.Dock = Wisej.Web.DockStyle.Bottom;
			this.panelPager.Location = new System.Drawing.Point(0, 592);
			this.panelPager.Name = "panelPager";
			this.panelPager.Padding = new Wisej.Web.Padding(12, 6, 12, 6);
			this.panelPager.Size = new System.Drawing.Size(1000, 48);
			this.panelPager.TabIndex = 4;
			//
			// labelPage
			//
			this.labelPage.CssClass = "relay-muted";
			this.labelPage.Dock = Wisej.Web.DockStyle.Fill;
			this.labelPage.Location = new System.Drawing.Point(12, 6);
			this.labelPage.Name = "labelPage";
			this.labelPage.Size = new System.Drawing.Size(756, 36);
			this.labelPage.TabIndex = 0;
			this.labelPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// flowPager
			//
			this.flowPager.Controls.Add(this.buttonPrevious);
			this.flowPager.Controls.Add(this.buttonNext);
			this.flowPager.Dock = Wisej.Web.DockStyle.Right;
			this.flowPager.Location = new System.Drawing.Point(768, 6);
			this.flowPager.Name = "flowPager";
			this.flowPager.Size = new System.Drawing.Size(220, 36);
			this.flowPager.TabIndex = 1;
			this.flowPager.TabStop = true;
			//
			// buttonPrevious
			//
			this.buttonPrevious.CssClass = "relay-secondary";
			this.buttonPrevious.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/chevron-left.svg";
			this.buttonPrevious.Location = new System.Drawing.Point(0, 0);
			this.buttonPrevious.Margin = new Wisej.Web.Padding(0, 0, 8, 0);
			this.buttonPrevious.Name = "buttonPrevious";
			this.buttonPrevious.Size = new System.Drawing.Size(110, 36);
			this.buttonPrevious.TabIndex = 0;
			this.buttonPrevious.Text = "Previous";
			this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
			//
			// buttonNext
			//
			this.buttonNext.CssClass = "relay-secondary";
			this.buttonNext.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/chevron-right.svg";
			this.buttonNext.Location = new System.Drawing.Point(118, 0);
			this.buttonNext.Margin = new Wisej.Web.Padding(0);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(100, 36);
			this.buttonNext.TabIndex = 1;
			this.buttonNext.Text = "Next";
			this.buttonNext.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			//
			// panelGrid
			//
			this.panelGrid.Controls.Add(this.emptyState);
			this.panelGrid.Controls.Add(this.grid);
			this.panelGrid.Dock = Wisej.Web.DockStyle.Fill;
			this.panelGrid.Location = new System.Drawing.Point(0, 144);
			this.panelGrid.Name = "panelGrid";
			this.panelGrid.Size = new System.Drawing.Size(1000, 448);
			this.panelGrid.TabIndex = 3;
			//
			// emptyState
			//
			this.emptyState.ActionText = "Clear the filters";
			this.emptyState.Description = "Try another search or clear the filters.";
			this.emptyState.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyState.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/building.svg";
			this.emptyState.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyState.Location = new System.Drawing.Point(0, 0);
			this.emptyState.Name = "emptyState";
			this.emptyState.Size = new System.Drawing.Size(1000, 448);
			this.emptyState.TabIndex = 1;
			this.emptyState.Title = "No companies match";
			this.emptyState.Visible = false;
			this.emptyState.ActionClick += new System.EventHandler(this.emptyState_ActionClick);
			//
			// grid
			//
			this.grid.AllowUserToResizeRows = false;
			this.grid.AutoGenerateColumns = false;
			this.grid.BorderStyle = Wisej.Web.BorderStyle.None;
			this.grid.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colName,
			this.colIndustry,
			this.colSize,
			this.colCountry,
			this.colCity,
			this.colOwner,
			this.colContacts,
			this.colOpenDeals,
			this.colOpenValue,
			this.colWonRevenue,
			this.colWonTrend,
			this.colAnnualRevenue,
			this.colTag,
			this.colTags});
			this.grid.ContextMenu = this.contextMenuGrid;
			this.grid.CssClass = "relay-grid";
			this.grid.Dock = Wisej.Web.DockStyle.Fill;
			this.grid.KeepSameRowHeight = true;
			this.grid.Location = new System.Drawing.Point(0, 0);
			this.grid.MultiSelect = false;
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersVisible = false;
			this.grid.RowTemplate.Height = 44;
			this.grid.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.grid.ShowColumnVisibilityMenu = false;
			this.grid.Size = new System.Drawing.Size(1000, 448);
			this.grid.TabIndex = 0;
			this.grid.ToolTipText = "Double-click to open the company; right-click for more";
			this.grid.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
			this.grid.CellMouseDown += new Wisej.Web.DataGridViewCellMouseEventHandler(this.grid_CellMouseDown);
			//
			// colName
			//
			this.colName.AutoColor = true;
			this.colName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.DataPropertyName = "Name";
			this.colName.FillWeight = 200F;
			this.colName.HeaderText = "Name";
			this.colName.MinimumWidth = 180;
			this.colName.Name = "colName";
			this.colName.Shape = Wisej.Web.AvatarShape.Rounded;
			this.colName.TextMember = "Name";
			//
			// colIndustry
			//
			this.colIndustry.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colIndustry.DataPropertyName = "Industry";
			this.colIndustry.FillWeight = 120F;
			this.colIndustry.HeaderText = "Industry";
			this.colIndustry.Name = "colIndustry";
			//
			// colSize
			//
			this.colSize.DataPropertyName = "Size";
			this.colSize.HeaderText = "Size";
			this.colSize.Name = "colSize";
			this.colSize.Visible = false;
			this.colSize.Width = 70;
			//
			// colCountry
			//
			this.colCountry.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colCountry.DataPropertyName = "Country";
			this.colCountry.HeaderText = "Country";
			this.colCountry.Name = "colCountry";
			//
			// colCity
			//
			this.colCity.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colCity.DataPropertyName = "City";
			this.colCity.HeaderText = "City";
			this.colCity.Name = "colCity";
			this.colCity.Visible = false;
			//
			// colOwner
			//
			this.colOwner.AutoColor = true;
			this.colOwner.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colOwner.DataPropertyName = "OwnerName";
			this.colOwner.FillWeight = 130F;
			this.colOwner.HeaderText = "Owner";
			this.colOwner.Name = "colOwner";
			this.colOwner.TextMember = "OwnerName";
			//
			// colContacts
			//
			dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colContacts.DataPropertyName = "Contacts";
			this.colContacts.DefaultCellStyle = dataGridViewCellStyle1;
			this.colContacts.HeaderText = "Contacts";
			this.colContacts.Name = "colContacts";
			this.colContacts.Width = 80;
			//
			// colOpenDeals
			//
			dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colOpenDeals.DataPropertyName = "OpenDeals";
			this.colOpenDeals.DefaultCellStyle = dataGridViewCellStyle2;
			this.colOpenDeals.HeaderText = "Open deals";
			this.colOpenDeals.Name = "colOpenDeals";
			this.colOpenDeals.Visible = false;
			this.colOpenDeals.Width = 90;
			//
			// colOpenValue
			//
			dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colOpenValue.DataPropertyName = "OpenValue";
			this.colOpenValue.DefaultCellStyle = dataGridViewCellStyle3;
			this.colOpenValue.HeaderText = "Open value";
			this.colOpenValue.Name = "colOpenValue";
			this.colOpenValue.Tag = "Fmt:Money";
			this.colOpenValue.Width = 110;
			//
			// colWonRevenue
			//
			dataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colWonRevenue.DataPropertyName = "WonRevenue";
			this.colWonRevenue.DefaultCellStyle = dataGridViewCellStyle4;
			this.colWonRevenue.HeaderText = "Won revenue";
			this.colWonRevenue.Name = "colWonRevenue";
			this.colWonRevenue.Tag = "Fmt:Money";
			this.colWonRevenue.Width = 110;
			//
			// colWonTrend
			//
			this.colWonTrend.DataPropertyName = "WonTrend";
			this.colWonTrend.HeaderText = "Won, 12 months";
			this.colWonTrend.Name = "colWonTrend";
			this.colWonTrend.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable;
			this.colWonTrend.Tone = Wisej.Web.SparklineTone.Primary;
			this.colWonTrend.Width = 120;
			//
			// colAnnualRevenue
			//
			dataGridViewCellStyle5.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colAnnualRevenue.DataPropertyName = "AnnualRevenue";
			this.colAnnualRevenue.DefaultCellStyle = dataGridViewCellStyle5;
			this.colAnnualRevenue.HeaderText = "Annual revenue";
			this.colAnnualRevenue.Name = "colAnnualRevenue";
			this.colAnnualRevenue.Tag = "Fmt:MoneyShort";
			this.colAnnualRevenue.Visible = false;
			this.colAnnualRevenue.Width = 110;
			//
			// colTag
			//
			this.colTag.DataPropertyName = "FirstTag";
			this.colTag.HeaderText = "Tag";
			this.colTag.Name = "colTag";
			this.colTag.Variant = Wisej.Web.ChipVariant.Soft;
			this.colTag.Width = 110;
			//
			// colTags
			//
			this.colTags.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTags.DataPropertyName = "Tags";
			this.colTags.HeaderText = "Tags";
			this.colTags.Name = "colTags";
			this.colTags.Visible = false;
			//
			// contextMenuGrid
			//
			this.contextMenuGrid.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuOpen,
			this.menuEdit,
			this.menuSeparator1,
			this.menuLogActivity,
			this.menuNewDeal,
			this.menuSeparator2,
			this.menuDelete});
			this.contextMenuGrid.Name = "contextMenuGrid";
			//
			// menuOpen
			//
			this.menuOpen.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.menuOpen.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/box-arrow-up-right.svg";
			this.menuOpen.Index = 0;
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Text = "Open";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			//
			// menuEdit
			//
			this.menuEdit.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/pencil.svg";
			this.menuEdit.Index = 1;
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Text = "Edit...";
			this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
			//
			// menuSeparator1
			//
			this.menuSeparator1.Index = 2;
			this.menuSeparator1.Name = "menuSeparator1";
			this.menuSeparator1.Text = "-";
			//
			// menuLogActivity
			//
			this.menuLogActivity.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/journal-plus.svg";
			this.menuLogActivity.Index = 3;
			this.menuLogActivity.Name = "menuLogActivity";
			this.menuLogActivity.Text = "Log activity...";
			this.menuLogActivity.Click += new System.EventHandler(this.menuLogActivity_Click);
			//
			// menuNewDeal
			//
			this.menuNewDeal.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/briefcase.svg";
			this.menuNewDeal.Index = 4;
			this.menuNewDeal.Name = "menuNewDeal";
			this.menuNewDeal.Text = "New deal...";
			this.menuNewDeal.Click += new System.EventHandler(this.menuNewDeal_Click);
			//
			// menuSeparator2
			//
			this.menuSeparator2.Index = 5;
			this.menuSeparator2.Name = "menuSeparator2";
			this.menuSeparator2.Text = "-";
			//
			// menuDelete
			//
			this.menuDelete.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			this.menuDelete.Index = 6;
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Text = "Delete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// menuColumns
			//
			this.menuColumns.Name = "menuColumns";
			//
			// CompaniesView
			//
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panelGrid);
			this.Controls.Add(this.panelPager);
			this.Controls.Add(this.panelFilter);
			this.Controls.Add(this.panelSearch);
			this.Controls.Add(this.panelHeader);
			this.CssClass = "relay-card";
			this.Name = "CompaniesView";
			this.Size = new System.Drawing.Size(1000, 640);
			this.panelHeader.ResumeLayout(false);
			this.flowTools.ResumeLayout(false);
			this.panelSearch.ResumeLayout(false);
			this.panelFilter.ResumeLayout(false);
			this.panelFilter.PerformLayout();
			this.panelPager.ResumeLayout(false);
			this.flowPager.ResumeLayout(false);
			this.panelGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelCount;
		private Wisej.Web.Button buttonNew;
		private Wisej.Web.FlowLayoutPanel flowTools;
		private Wisej.Web.Button buttonAdvanced;
		private Wisej.Web.Button buttonColumns;
		private Wisej.Web.Button buttonExport;
		private Wisej.Web.Panel panelSearch;
		private Wisej.Web.TextBox textBoxSearch;
		private Wisej.Web.ChipGroup chipsQuick;
		private Wisej.Web.FlowLayoutPanel panelFilter;
		private Wisej.Web.Label labelFilter;
		private Wisej.Web.Label runFilter;
		private Wisej.Web.LinkLabel linkClearFilter;
		private Wisej.Web.Panel panelPager;
		private Wisej.Web.Label labelPage;
		private Wisej.Web.FlowLayoutPanel flowPager;
		private Wisej.Web.Button buttonPrevious;
		private Wisej.Web.Button buttonNext;
		private Wisej.Web.Panel panelGrid;
		private Wisej.Web.EmptyState emptyState;
		private Wisej.Web.DataGridView grid;
		private Wisej.Web.DataGridViewAvatarColumn colName;
		private Wisej.Web.DataGridViewTextBoxColumn colIndustry;
		private Wisej.Web.DataGridViewTextBoxColumn colSize;
		private Wisej.Web.DataGridViewTextBoxColumn colCountry;
		private Wisej.Web.DataGridViewTextBoxColumn colCity;
		private Wisej.Web.DataGridViewAvatarColumn colOwner;
		private Wisej.Web.DataGridViewTextBoxColumn colContacts;
		private Wisej.Web.DataGridViewTextBoxColumn colOpenDeals;
		private Wisej.Web.DataGridViewTextBoxColumn colOpenValue;
		private Wisej.Web.DataGridViewTextBoxColumn colWonRevenue;
		private Wisej.Web.DataGridViewSparklineColumn colWonTrend;
		private Wisej.Web.DataGridViewTextBoxColumn colAnnualRevenue;
		private Wisej.Web.DataGridViewChipColumn colTag;
		private Wisej.Web.DataGridViewTextBoxColumn colTags;
		private Wisej.Web.ContextMenu contextMenuGrid;
		private Wisej.Web.MenuItem menuOpen;
		private Wisej.Web.MenuItem menuEdit;
		private Wisej.Web.MenuItem menuSeparator1;
		private Wisej.Web.MenuItem menuLogActivity;
		private Wisej.Web.MenuItem menuNewDeal;
		private Wisej.Web.MenuItem menuSeparator2;
		private Wisej.Web.MenuItem menuDelete;
		private Wisej.Web.ContextMenu menuColumns;
	}
}
