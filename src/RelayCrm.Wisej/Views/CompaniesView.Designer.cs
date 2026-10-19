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
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
			this.linkEmpty = new Wisej.Web.LinkLabel();
			this.grid = new Wisej.Web.DataGridView();
			this.colName = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colIndustry = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCountry = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCity = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOwner = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colContacts = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOpenValue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colWonRevenue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colWonTrend = new Wisej.Web.DataGridViewSparklineColumn();
			this.colTag = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTags = new Wisej.Web.DataGridViewTextBoxColumn();
			this.filterStrip = new Wisej.Web.ToolBar();
			this.labelSearch = new Wisej.Web.ToolBarButton();
			this.textSearch = new Wisej.Web.TextBox();
			this.textSearchHost = new Wisej.Web.ToolBarControl();
			this.filterSeparator1 = new Wisej.Web.ToolBarButton();
			this.quickAll = new Wisej.Web.ToolBarButton();
			this.quickMine = new Wisej.Web.ToolBarButton();
			this.quickOpenDeals = new Wisej.Web.ToolBarButton();
			this.quickCustomers = new Wisej.Web.ToolBarButton();
			this.filterSeparator2 = new Wisej.Web.ToolBarButton();
			this.labelAdvanced = new Wisej.Web.ToolBarButton();
			this.buttonClearFilter = new Wisej.Web.ToolBarButton();
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
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.filterStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.panelPaging.SuspendLayout();
			this.SuspendLayout();
			//
			// linkEmpty
			//
			this.linkEmpty.BackColor = System.Drawing.SystemColors.Window;
			this.linkEmpty.Dock = Wisej.Web.DockStyle.Fill;
			this.linkEmpty.LinkArea = new Wisej.Web.LinkArea(0, 0);
			this.linkEmpty.Location = new System.Drawing.Point(0, 54);
			this.linkEmpty.Name = "linkEmpty";
			this.linkEmpty.Size = new System.Drawing.Size(900, 500);
			this.linkEmpty.TabIndex = 3;
			this.linkEmpty.TabStop = true;
			this.linkEmpty.Text = "No companies match the search and the filters. Clear the filters";
			this.linkEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkEmpty.Visible = false;
			this.linkEmpty.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkEmpty_LinkClicked);
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
			//
			// colName
			//
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.colName.DataPropertyName = "Name";
			this.colName.DefaultCellStyle = dataGridViewCellStyle1;
			this.colName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.MinimumWidth = 160;
			this.colName.HeaderText = "Company";
			this.colName.Name = "colName";
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
			this.colOwner.Width = 120;
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
			this.colTag.Width = 80;
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
			this.filterStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.labelSearch,
			this.textSearchHost,
			this.filterSeparator1,
			this.quickAll,
			this.quickMine,
			this.quickOpenDeals,
			this.quickCustomers,
			this.filterSeparator2,
			this.labelAdvanced,
			this.buttonClearFilter});
			this.filterStrip.Location = new System.Drawing.Point(0, 27);
			this.filterStrip.Name = "filterStrip";
			this.filterStrip.Padding = new Wisej.Web.Padding(4, 2, 4, 2);
			this.filterStrip.Size = new System.Drawing.Size(800, 27);
			this.filterStrip.TabIndex = 1;
			this.filterStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			//
			// labelSearch
			//
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Text = "Search:";
			//
			// textSearch
			//
			this.textSearch.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.textSearch.Size = new System.Drawing.Size(240, 23);
			this.textSearch.Name = "textSearch";
			this.textSearchHost.Control = this.textSearch;
			this.textSearchHost.Name = "textSearchHost";
			this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
			//
			// filterSeparator1
			//
			this.filterSeparator1.Name = "filterSeparator1";
			this.filterSeparator1.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// quickAll
			//
			this.quickAll.Name = "quickAll";
			this.quickAll.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.quickAll.Text = "All";
			this.quickAll.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickMine
			//
			this.quickMine.Name = "quickMine";
			this.quickMine.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.quickMine.Text = "My companies";
			this.quickMine.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickOpenDeals
			//
			this.quickOpenDeals.Name = "quickOpenDeals";
			this.quickOpenDeals.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.quickOpenDeals.Text = "With open deals";
			this.quickOpenDeals.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickCustomers
			//
			this.quickCustomers.Name = "quickCustomers";
			this.quickCustomers.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.quickCustomers.Text = "Customers";
			this.quickCustomers.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// filterSeparator2
			//
			this.filterSeparator2.Name = "filterSeparator2";
			this.filterSeparator2.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// labelAdvanced
			//
			this.labelAdvanced.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelAdvanced.Name = "labelAdvanced";
			this.labelAdvanced.Text = "";
			//
			// buttonClearFilter
			//
			this.buttonClearFilter.Visible = false;
			this.buttonClearFilter.Name = "buttonClearFilter";
			this.buttonClearFilter.Text = "Clear filters";
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
			this.toolStrip.Size = new System.Drawing.Size(800, 27);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
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
			//
			// labelPage
			//
			this.labelPage.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.labelPage.Location = new System.Drawing.Point(8, 9);
			this.labelPage.Name = "labelPage";
			this.labelPage.Size = new System.Drawing.Size(800, 18);
			this.labelPage.TabIndex = 0;
			this.labelPage.Text = "0 of 0";
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.linkEmpty);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.filterStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.panelPaging);
			this.Name = "CompaniesView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.Load += new System.EventHandler(this.CompaniesView_Load);
			this.panelPaging.ResumeLayout(false);
			this.panelPaging.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.filterStrip.ResumeLayout(false);
			this.filterStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.LinkLabel linkEmpty;
		private Wisej.Web.DataGridView grid;
		private Wisej.Web.DataGridViewTextBoxColumn colName;
		private Wisej.Web.DataGridViewTextBoxColumn colIndustry;
		private Wisej.Web.DataGridViewTextBoxColumn colCountry;
		private Wisej.Web.DataGridViewTextBoxColumn colCity;
		private Wisej.Web.DataGridViewTextBoxColumn colOwner;
		private Wisej.Web.DataGridViewTextBoxColumn colContacts;
		private Wisej.Web.DataGridViewTextBoxColumn colOpenValue;
		private Wisej.Web.DataGridViewTextBoxColumn colWonRevenue;
		private Wisej.Web.DataGridViewSparklineColumn colWonTrend;
		private Wisej.Web.DataGridViewTextBoxColumn colTag;
		private Wisej.Web.DataGridViewTextBoxColumn colTags;
		private Wisej.Web.ToolBar filterStrip;
		private Wisej.Web.ToolBarButton labelSearch;
		private Wisej.Web.TextBox textSearch;
		private Wisej.Web.ToolBarControl textSearchHost;
		private Wisej.Web.ToolBarButton filterSeparator1;
		private Wisej.Web.ToolBarButton quickAll;
		private Wisej.Web.ToolBarButton quickMine;
		private Wisej.Web.ToolBarButton quickOpenDeals;
		private Wisej.Web.ToolBarButton quickCustomers;
		private Wisej.Web.ToolBarButton filterSeparator2;
		private Wisej.Web.ToolBarButton labelAdvanced;
		private Wisej.Web.ToolBarButton buttonClearFilter;
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
	}
}
