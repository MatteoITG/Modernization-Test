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

		#region Component Designer generated code

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
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
			this.grid = new Wisej.Web.DataGridView();
			this.colName = new Wisej.Web.DataGridViewAvatarColumn();
			this.colIndustry = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCountry = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCity = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOwner = new Wisej.Web.DataGridViewAvatarColumn();
			this.colContacts = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOpenValue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colWonRevenue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colWonTrend = new Wisej.Web.DataGridViewSparklineColumn();
			this.colTag = new Wisej.Web.DataGridViewChipColumn();
			this.colTags = new Wisej.Web.DataGridViewTextBoxColumn();
			this.filterStrip = new Wisej.Web.Panel();
			this.textSearch = new Wisej.Web.TextBox();
			this.labelAdvanced = new Wisej.Web.Label();
			this.buttonClearFilter = new Wisej.Web.Button();
			this.toolStrip = new Wisej.Web.ToolBar();
			this.buttonNew = new Wisej.Web.ToolBarButton();
			this.buttonEdit = new Wisej.Web.ToolBarButton();
			this.buttonDelete = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator1 = new Wisej.Web.ToolBarButton();
			this.buttonFilter = new Wisej.Web.ToolBarButton();
			this.dropDownColumns = new Wisej.Web.ToolBarButton();
			this.dropDownColumnsMenu = new Wisej.Web.ContextMenu(this.components);
			this.buttonExport = new Wisej.Web.ToolBarButton();
			this.labelCount = new Wisej.Web.ToolBarButton();
			this.panelPaging = new Wisej.Web.Panel();
			this.buttonNext = new Wisej.Web.Button();
			this.buttonPrevious = new Wisej.Web.Button();
			this.labelPage = new Wisej.Web.Label();
			this.contextMenu = new Wisej.Web.ContextMenu(this.components);
			this.menuOpen = new Wisej.Web.MenuItem();
			this.menuSeparator1 = new Wisej.Web.MenuItem();
			this.menuEdit = new Wisej.Web.MenuItem();
			this.menuDelete = new Wisej.Web.MenuItem();
			this.segmentedQuick = new Wisej.Web.ChipGroup();
			this.emptyState = new Wisej.Web.EmptyState();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.filterStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.panelPaging.SuspendLayout();
			this.SuspendLayout();
			//
			// emptyState
			//
			this.emptyState.ActionText = "Clear the filters";
			this.emptyState.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyState.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/building.svg";
			this.emptyState.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyState.Location = new System.Drawing.Point(0, 100);
			this.emptyState.Name = "emptyState";
			this.emptyState.Size = new System.Drawing.Size(1000, 424);
			this.emptyState.TabIndex = 3;
			this.emptyState.Title = "No companies match the search and the filters.";
			this.emptyState.Visible = false;
			this.emptyState.ActionClick += new System.EventHandler(this.emptyState_ActionClick);
			//
			// grid
			//
			this.grid.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colName,
			this.colIndustry,
			this.colCountry,
			this.colCity,
			this.colOwner,
			this.colContacts,
			this.colOpenValue,
			this.colWonRevenue,
			this.colWonTrend,
			this.colTag,
			this.colTags});
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.AllowUserToResizeRows = false;
			this.grid.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Dock = Wisej.Web.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(0, 54);
			this.grid.MultiSelect = false;
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersVisible = false;
			this.grid.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.grid.Size = new System.Drawing.Size(1000, 510);
			this.grid.TabIndex = 2;
			this.grid.ContextMenu = this.contextMenu;
			this.grid.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
			this.grid.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
			this.grid.CellMouseDown += new Wisej.Web.DataGridViewCellMouseEventHandler(this.grid_CellMouseDown);
			this.grid.KeyDown += new Wisej.Web.KeyEventHandler(this.grid_KeyDown);
			this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
			this.grid.BorderStyle = Wisej.Web.BorderStyle.None;
			this.grid.CssClass = "relay-grid";
			this.grid.RowTemplate.Height = 48;
			//
			// colName
			//
			this.colName.DataPropertyName = "Name";
			this.colName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.MinimumWidth = 160;
			this.colName.HeaderText = "Company";
			this.colName.Name = "colName";
			this.colName.Shape = Wisej.Web.AvatarShape.Rounded;
			this.colName.TextMember = "Name";
			this.colName.SubTextMember = "Industry";
			//
			// colIndustry
			//
			this.colIndustry.DataPropertyName = "Industry";
			this.colIndustry.HeaderText = "Industry";
			this.colIndustry.Name = "colIndustry";
			this.colIndustry.Width = 100;
			//
			// colCountry
			//
			this.colCountry.DataPropertyName = "Country";
			this.colCountry.HeaderText = "Country";
			this.colCountry.Name = "colCountry";
			this.colCountry.Width = 110;
			//
			// colCity
			//
			this.colCity.DataPropertyName = "City";
			this.colCity.HeaderText = "City";
			this.colCity.Name = "colCity";
			this.colCity.Width = 100;
			//
			// colOwner
			//
			this.colOwner.DataPropertyName = "OwnerName";
			this.colOwner.HeaderText = "Owner";
			this.colOwner.Name = "colOwner";
			this.colOwner.Width = 150;
			this.colOwner.TextMember = "OwnerName";
			//
			// colContacts
			//
			dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colContacts.DataPropertyName = "Contacts";
			this.colContacts.DefaultCellStyle = dataGridViewCellStyle2;
			this.colContacts.HeaderText = "Contacts";
			this.colContacts.Name = "colContacts";
			this.colContacts.Width = 70;
			//
			// colOpenValue
			//
			dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "C0";
			this.colOpenValue.DataPropertyName = "OpenValue";
			this.colOpenValue.DefaultCellStyle = dataGridViewCellStyle3;
			this.colOpenValue.HeaderText = "Open deals";
			this.colOpenValue.Name = "colOpenValue";
			this.colOpenValue.Width = 100;
			//
			// colWonRevenue
			//
			dataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "C0";
			this.colWonRevenue.DataPropertyName = "WonRevenue";
			this.colWonRevenue.DefaultCellStyle = dataGridViewCellStyle4;
			this.colWonRevenue.HeaderText = "Won revenue";
			this.colWonRevenue.Name = "colWonRevenue";
			this.colWonRevenue.Width = 100;
			//
			// colWonTrend
			//
			this.colWonTrend.ChartType = Wisej.Web.SparklineChartType.Bar;
			this.colWonTrend.DataPropertyName = "WonTrend";
			this.colWonTrend.HeaderText = "Won, 12 months";
			this.colWonTrend.Name = "colWonTrend";
			this.colWonTrend.Width = 110;
			//
			// colTag
			//
			this.colTag.DataPropertyName = "FirstTag";
			this.colTag.HeaderText = "Tag";
			this.colTag.Name = "colTag";
			this.colTag.Width = 110;
			this.colTag.Variant = Wisej.Web.ChipVariant.Soft;
			//
			// colTags
			//
			this.colTags.DataPropertyName = "Tags";
			this.colTags.HeaderText = "All tags";
			this.colTags.Name = "colTags";
			this.colTags.Visible = false;
			this.colTags.Width = 150;
			//
			// filterStrip
			//
			this.filterStrip.Controls.Add(this.labelAdvanced);
			this.filterStrip.Controls.Add(this.buttonClearFilter);
			this.filterStrip.Controls.Add(this.segmentedQuick);
			this.filterStrip.Controls.Add(this.textSearch);
			this.filterStrip.Dock = Wisej.Web.DockStyle.Top;
			this.filterStrip.Location = new System.Drawing.Point(0, 44);
			this.filterStrip.Name = "filterStrip";
			this.filterStrip.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("filterStrip.ResponsiveProfiles"))));
			this.filterStrip.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("filterStrip.ResponsiveProfiles1"))));
			this.filterStrip.Padding = new Wisej.Web.Padding(12, 8, 12, 8);
			this.filterStrip.Size = new System.Drawing.Size(1000, 56);
			this.filterStrip.TabIndex = 1;
			//
			// textSearch
			//
			this.textSearch.CssClass = "relay-search";
			this.textSearch.Dock = Wisej.Web.DockStyle.Left;
			this.textSearch.Location = new System.Drawing.Point(12, 8);
			this.textSearch.Name = "textSearch";
			this.textSearch.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("textSearch.ResponsiveProfiles"))));
			this.textSearch.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("textSearch.ResponsiveProfiles1"))));
			this.textSearch.Size = new System.Drawing.Size(280, 40);
			this.textSearch.TabIndex = 0;
			componentTool1.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/x-lg.svg";
			componentTool1.Name = "clear";
			componentTool1.ToolTipText = "Clear the search";
			this.textSearch.Tools.AddRange(new Wisej.Web.ComponentTool[] {
			componentTool1});
			this.textSearch.Watermark = "Name, industry, place, owner or tag";
			this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
			this.textSearch.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textSearch_ToolClick);
			//
			// segmentedQuick
			//
			this.segmentedQuick.Dock = Wisej.Web.DockStyle.Left;
			segment1.Text = "All";
			segment2.Text = "My companies";
			segment3.Text = "With open deals";
			segment4.Text = "Customers";
			this.segmentedQuick.Items.Add(segment1);
			this.segmentedQuick.Items.Add(segment2);
			this.segmentedQuick.Items.Add(segment3);
			this.segmentedQuick.Items.Add(segment4);
			this.segmentedQuick.Location = new System.Drawing.Point(292, 8);
			this.segmentedQuick.Name = "segmentedQuick";
			this.segmentedQuick.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("segmentedQuick.ResponsiveProfiles"))));
			this.segmentedQuick.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("segmentedQuick.ResponsiveProfiles1"))));
			this.segmentedQuick.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.segmentedQuick.ShowCounts = true;
			this.segmentedQuick.Size = new System.Drawing.Size(470, 40);
			this.segmentedQuick.TabIndex = 1;
			this.segmentedQuick.SelectedIndexChanged += new System.EventHandler(this.segmentedQuick_SelectedIndexChanged);
			//
			// labelAdvanced
			//
			this.labelAdvanced.AutoEllipsis = true;
			this.labelAdvanced.CssClass = "relay-muted";
			this.labelAdvanced.Dock = Wisej.Web.DockStyle.Fill;
			this.labelAdvanced.Location = new System.Drawing.Point(762, 8);
			this.labelAdvanced.Name = "labelAdvanced";
			this.labelAdvanced.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.labelAdvanced.Size = new System.Drawing.Size(106, 40);
			this.labelAdvanced.TabIndex = 2;
			this.labelAdvanced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonClearFilter
			//
			this.buttonClearFilter.CssClass = "relay-secondary";
			this.buttonClearFilter.Dock = Wisej.Web.DockStyle.Right;
			this.buttonClearFilter.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/x-circle.svg";
			this.buttonClearFilter.Location = new System.Drawing.Point(868, 8);
			this.buttonClearFilter.Name = "buttonClearFilter";
			this.buttonClearFilter.Size = new System.Drawing.Size(120, 40);
			this.buttonClearFilter.TabIndex = 3;
			this.buttonClearFilter.Text = "Clear filters";
			this.buttonClearFilter.Visible = false;
			this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
			//
			// toolStrip
			//
			this.toolStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonNew,
			this.buttonEdit,
			this.buttonDelete,
			this.toolStripSeparator1,
			this.buttonFilter,
			this.dropDownColumns,
			this.buttonExport,
			this.labelCount});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new Wisej.Web.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(1000, 44);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.toolStrip.CssClass = "relay-toolbar";
			//
			// buttonNew
			//
			this.buttonNew.Tag = "plus";
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Text = "New company...";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// buttonEdit
			//
			this.buttonEdit.Tag = "pencil";
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Text = "Edit...";
			this.buttonEdit.Click += new System.EventHandler(this.menuEdit_Click);
			//
			// buttonDelete
			//
			this.buttonDelete.Tag = "trash";
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// buttonFilter
			//
			this.buttonFilter.Tag = "funnel";
			this.buttonFilter.Name = "buttonFilter";
			this.buttonFilter.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.buttonFilter.Text = "Filter...";
			this.buttonFilter.ToolTipText = "Advanced filter";
			this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
			//
			// dropDownColumns
			//
			this.dropDownColumns.Tag = "layout-three-columns";
			this.dropDownColumns.Name = "dropDownColumns";
			this.dropDownColumns.DropDownMenu = this.dropDownColumnsMenu;
			this.dropDownColumns.Style = Wisej.Web.ToolBarButtonStyle.DropDownButton;
			this.dropDownColumns.Text = "Columns";
			this.dropDownColumnsMenu.Popup += new System.EventHandler(this.dropDownColumns_DropDownOpening);
			//
			// buttonExport
			//
			this.buttonExport.Tag = "download";
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Text = "Export CSV...";
			this.buttonExport.ToolTipText = "Exports every matching company, not only this page";
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			//
			// labelCount
			//
			this.labelCount.Name = "labelCount";
			this.labelCount.Text = "0 companies";
			//
			// panelPaging
			//
			this.panelPaging.Controls.Add(this.buttonNext);
			this.panelPaging.Controls.Add(this.buttonPrevious);
			this.panelPaging.Controls.Add(this.labelPage);
			this.panelPaging.Dock = Wisej.Web.DockStyle.Bottom;
			this.panelPaging.Location = new System.Drawing.Point(0, 564);
			this.panelPaging.Name = "panelPaging";
			this.panelPaging.Padding = new Wisej.Web.Padding(6);
			this.panelPaging.Size = new System.Drawing.Size(1000, 36);
			this.panelPaging.TabIndex = 4;
			//
			// buttonNext
			//
			this.buttonNext.Anchor = ((Wisej.Web.AnchorStyles)(Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right));
			this.buttonNext.Location = new System.Drawing.Point(912, 5);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(80, 26);
			this.buttonNext.TabIndex = 2;
			this.buttonNext.Text = "Next ›";
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			this.buttonNext.CssClass = "relay-secondary";
			//
			// buttonPrevious
			//
			this.buttonPrevious.Anchor = ((Wisej.Web.AnchorStyles)(Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right));
			this.buttonPrevious.Location = new System.Drawing.Point(826, 5);
			this.buttonPrevious.Name = "buttonPrevious";
			this.buttonPrevious.Size = new System.Drawing.Size(80, 26);
			this.buttonPrevious.TabIndex = 1;
			this.buttonPrevious.Text = "‹ Previous";
			this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
			this.buttonPrevious.CssClass = "relay-secondary";
			//
			// labelPage
			//
			this.labelPage.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.labelPage.Location = new System.Drawing.Point(8, 9);
			this.labelPage.Name = "labelPage";
			this.labelPage.Size = new System.Drawing.Size(800, 18);
			this.labelPage.TabIndex = 0;
			this.labelPage.Text = "0 of 0";
			this.labelPage.CssClass = "relay-muted";
			//
			// contextMenu
			//
			this.contextMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuOpen,
			this.menuSeparator1,
			this.menuEdit,
			this.menuDelete});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Popup += new System.EventHandler(this.contextMenu_Opening);
			//
			// menuOpen
			//
			this.menuOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Text = "&Open";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			//
			// menuSeparator1
			//
			this.menuSeparator1.Name = "menuSeparator1";
			this.menuSeparator1.Text = "-";
			//
			// menuEdit
			//
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Text = "E&dit...";
			this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
			//
			// menuDelete
			//
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Text = "De&lete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// CompaniesView
			//
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.emptyState);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.filterStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.panelPaging);
			this.CssClass = "relay-card";
			this.Name = "CompaniesView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.Load += new System.EventHandler(this.CompaniesView_Load);
			this.panelPaging.ResumeLayout(false);
			this.panelPaging.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.filterStrip.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.DataGridView grid;
		private Wisej.Web.DataGridViewAvatarColumn colName;
		private Wisej.Web.DataGridViewTextBoxColumn colIndustry;
		private Wisej.Web.DataGridViewTextBoxColumn colCountry;
		private Wisej.Web.DataGridViewTextBoxColumn colCity;
		private Wisej.Web.DataGridViewAvatarColumn colOwner;
		private Wisej.Web.DataGridViewTextBoxColumn colContacts;
		private Wisej.Web.DataGridViewTextBoxColumn colOpenValue;
		private Wisej.Web.DataGridViewTextBoxColumn colWonRevenue;
		private Wisej.Web.DataGridViewSparklineColumn colWonTrend;
		private Wisej.Web.DataGridViewChipColumn colTag;
		private Wisej.Web.DataGridViewTextBoxColumn colTags;
		private Wisej.Web.Panel filterStrip;
		private Wisej.Web.TextBox textSearch;
		private Wisej.Web.Label labelAdvanced;
		private Wisej.Web.Button buttonClearFilter;
		private Wisej.Web.ToolBar toolStrip;
		private Wisej.Web.ToolBarButton buttonNew;
		private Wisej.Web.ToolBarButton buttonEdit;
		private Wisej.Web.ToolBarButton buttonDelete;
		private Wisej.Web.ToolBarButton toolStripSeparator1;
		private Wisej.Web.ToolBarButton buttonFilter;
		private Wisej.Web.ToolBarButton dropDownColumns;
		private Wisej.Web.ContextMenu dropDownColumnsMenu;
		private Wisej.Web.ToolBarButton buttonExport;
		private Wisej.Web.ToolBarButton labelCount;
		private Wisej.Web.Panel panelPaging;
		private Wisej.Web.Button buttonNext;
		private Wisej.Web.Button buttonPrevious;
		private Wisej.Web.Label labelPage;
		private Wisej.Web.ContextMenu contextMenu;
		private Wisej.Web.MenuItem menuOpen;
		private Wisej.Web.MenuItem menuSeparator1;
		private Wisej.Web.MenuItem menuEdit;
		private Wisej.Web.MenuItem menuDelete;
		private Wisej.Web.ChipGroup segmentedQuick;
		private Wisej.Web.EmptyState emptyState;
	}
}
