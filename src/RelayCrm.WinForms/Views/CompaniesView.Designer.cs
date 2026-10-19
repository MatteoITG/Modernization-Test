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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.linkEmpty = new System.Windows.Forms.LinkLabel();
			this.grid = new System.Windows.Forms.DataGridView();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colIndustry = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colContacts = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOpenValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colWonRevenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colWonTrend = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTags = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filterStrip = new System.Windows.Forms.ToolStrip();
			this.labelSearch = new System.Windows.Forms.ToolStripLabel();
			this.textSearch = new System.Windows.Forms.ToolStripTextBox();
			this.filterSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.quickAll = new System.Windows.Forms.ToolStripButton();
			this.quickMine = new System.Windows.Forms.ToolStripButton();
			this.quickOpenDeals = new System.Windows.Forms.ToolStripButton();
			this.quickCustomers = new System.Windows.Forms.ToolStripButton();
			this.filterSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.labelAdvanced = new System.Windows.Forms.ToolStripLabel();
			this.buttonClearFilter = new System.Windows.Forms.ToolStripButton();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.buttonNew = new System.Windows.Forms.ToolStripButton();
			this.buttonEdit = new System.Windows.Forms.ToolStripButton();
			this.buttonDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonFilter = new System.Windows.Forms.ToolStripButton();
			this.dropDownColumns = new System.Windows.Forms.ToolStripDropDownButton();
			this.buttonExport = new System.Windows.Forms.ToolStripButton();
			this.labelCount = new System.Windows.Forms.ToolStripLabel();
			this.panelPaging = new System.Windows.Forms.Panel();
			this.buttonNext = new System.Windows.Forms.Button();
			this.buttonPrevious = new System.Windows.Forms.Button();
			this.labelPage = new System.Windows.Forms.Label();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.filterStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.panelPaging.SuspendLayout();
			this.contextMenu.SuspendLayout();
			this.SuspendLayout();
			//
			// linkEmpty
			//
			this.linkEmpty.BackColor = System.Drawing.SystemColors.Window;
			this.linkEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkEmpty.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
			this.linkEmpty.Location = new System.Drawing.Point(0, 54);
			this.linkEmpty.Name = "linkEmpty";
			this.linkEmpty.Size = new System.Drawing.Size(900, 500);
			this.linkEmpty.TabIndex = 3;
			this.linkEmpty.TabStop = true;
			this.linkEmpty.Text = "No companies match the search and the filters. Clear the filters";
			this.linkEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkEmpty.Visible = false;
			this.linkEmpty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEmpty_LinkClicked);
			//
			// grid
			//
			this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
			this.grid.BackgroundColor = System.Drawing.SystemColors.Window;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(0, 54);
			this.grid.MultiSelect = false;
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersVisible = false;
			this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid.Size = new System.Drawing.Size(1000, 510);
			this.grid.TabIndex = 2;
			this.grid.ContextMenuStrip = this.contextMenu;
			this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
			this.grid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_CellFormatting);
			this.grid.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.grid_CellPainting);
			this.grid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_CellMouseDown);
			this.grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_KeyDown);
			this.grid.SelectionChanged += new System.EventHandler(this.grid_SelectionChanged);
			//
			// colName
			//
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.colName.DataPropertyName = "Name";
			this.colName.DefaultCellStyle = dataGridViewCellStyle1;
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.colContacts.DataPropertyName = "Contacts";
			this.colContacts.DefaultCellStyle = dataGridViewCellStyle2;
			this.colContacts.HeaderText = "Contacts";
			this.colContacts.Name = "colContacts";
			this.colContacts.Width = 70;
			//
			// colOpenValue
			//
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "C0";
			this.colOpenValue.DataPropertyName = "OpenValue";
			this.colOpenValue.DefaultCellStyle = dataGridViewCellStyle3;
			this.colOpenValue.HeaderText = "Open deals";
			this.colOpenValue.Name = "colOpenValue";
			this.colOpenValue.Width = 100;
			//
			// colWonRevenue
			//
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle4.Format = "C0";
			this.colWonRevenue.DataPropertyName = "WonRevenue";
			this.colWonRevenue.DefaultCellStyle = dataGridViewCellStyle4;
			this.colWonRevenue.HeaderText = "Won revenue";
			this.colWonRevenue.Name = "colWonRevenue";
			this.colWonRevenue.Width = 100;
			//
			// colWonTrend
			//
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
			this.filterStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.labelSearch,
			this.textSearch,
			this.filterSeparator1,
			this.quickAll,
			this.quickMine,
			this.quickOpenDeals,
			this.quickCustomers,
			this.filterSeparator2,
			this.labelAdvanced,
			this.buttonClearFilter});
			this.filterStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.filterStrip.Location = new System.Drawing.Point(0, 27);
			this.filterStrip.Name = "filterStrip";
			this.filterStrip.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.filterStrip.Size = new System.Drawing.Size(800, 27);
			this.filterStrip.TabIndex = 1;
			//
			// labelSearch
			//
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Text = "Search:";
			//
			// textSearch
			//
			this.textSearch.AutoSize = false;
			this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSearch.Size = new System.Drawing.Size(240, 23);
			this.textSearch.Name = "textSearch";
			this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
			//
			// filterSeparator1
			//
			this.filterSeparator1.Name = "filterSeparator1";
			//
			// quickAll
			//
			this.quickAll.Name = "quickAll";
			this.quickAll.Text = "All";
			this.quickAll.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickMine
			//
			this.quickMine.Name = "quickMine";
			this.quickMine.Text = "My companies";
			this.quickMine.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickOpenDeals
			//
			this.quickOpenDeals.Name = "quickOpenDeals";
			this.quickOpenDeals.Text = "With open deals";
			this.quickOpenDeals.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickCustomers
			//
			this.quickCustomers.Name = "quickCustomers";
			this.quickCustomers.Text = "Customers";
			this.quickCustomers.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// filterSeparator2
			//
			this.filterSeparator2.Name = "filterSeparator2";
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
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonNew,
			this.buttonEdit,
			this.buttonDelete,
			this.toolStripSeparator1,
			this.buttonFilter,
			this.dropDownColumns,
			this.buttonExport,
			this.labelCount});
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(800, 27);
			this.toolStrip.TabIndex = 0;
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
			//
			// buttonFilter
			//
			this.buttonFilter.Tag = "funnel";
			this.buttonFilter.Name = "buttonFilter";
			this.buttonFilter.Text = "Filter...";
			this.buttonFilter.ToolTipText = "Advanced filter";
			this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
			//
			// dropDownColumns
			//
			this.dropDownColumns.Tag = "layout-three-columns";
			this.dropDownColumns.Name = "dropDownColumns";
			this.dropDownColumns.Text = "Columns";
			this.dropDownColumns.DropDownOpening += new System.EventHandler(this.dropDownColumns_DropDownOpening);
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
			this.labelCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.labelCount.Name = "labelCount";
			this.labelCount.Text = "0 companies";
			//
			// panelPaging
			//
			this.panelPaging.Controls.Add(this.buttonNext);
			this.panelPaging.Controls.Add(this.buttonPrevious);
			this.panelPaging.Controls.Add(this.labelPage);
			this.panelPaging.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelPaging.Location = new System.Drawing.Point(0, 564);
			this.panelPaging.Name = "panelPaging";
			this.panelPaging.Padding = new System.Windows.Forms.Padding(6);
			this.panelPaging.Size = new System.Drawing.Size(1000, 36);
			this.panelPaging.TabIndex = 4;
			//
			// buttonNext
			//
			this.buttonNext.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
			this.buttonNext.Location = new System.Drawing.Point(912, 5);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(80, 26);
			this.buttonNext.TabIndex = 2;
			this.buttonNext.Text = "Next ›";
			this.buttonNext.UseVisualStyleBackColor = true;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			//
			// buttonPrevious
			//
			this.buttonPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
			this.buttonPrevious.Location = new System.Drawing.Point(826, 5);
			this.buttonPrevious.Name = "buttonPrevious";
			this.buttonPrevious.Size = new System.Drawing.Size(80, 26);
			this.buttonPrevious.TabIndex = 1;
			this.buttonPrevious.Text = "‹ Previous";
			this.buttonPrevious.UseVisualStyleBackColor = true;
			this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
			//
			// labelPage
			//
			this.labelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
			this.labelPage.Location = new System.Drawing.Point(8, 9);
			this.labelPage.Name = "labelPage";
			this.labelPage.Size = new System.Drawing.Size(800, 18);
			this.labelPage.TabIndex = 0;
			this.labelPage.Text = "0 of 0";
			//
			// contextMenu
			//
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuOpen,
			this.menuSeparator1,
			this.menuEdit,
			this.menuDelete});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(181, 120);
			this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
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
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.linkEmpty);
			this.Controls.Add(this.grid);
			this.Controls.Add(this.filterStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.panelPaging);
			this.Name = "CompaniesView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.Load += new System.EventHandler(this.CompaniesView_Load);
			this.contextMenu.ResumeLayout(false);
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

		private System.Windows.Forms.LinkLabel linkEmpty;
		private System.Windows.Forms.DataGridView grid;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colIndustry;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCountry;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOwner;
		private System.Windows.Forms.DataGridViewTextBoxColumn colContacts;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOpenValue;
		private System.Windows.Forms.DataGridViewTextBoxColumn colWonRevenue;
		private System.Windows.Forms.DataGridViewTextBoxColumn colWonTrend;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTag;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTags;
		private System.Windows.Forms.ToolStrip filterStrip;
		private System.Windows.Forms.ToolStripLabel labelSearch;
		private System.Windows.Forms.ToolStripTextBox textSearch;
		private System.Windows.Forms.ToolStripSeparator filterSeparator1;
		private System.Windows.Forms.ToolStripButton quickAll;
		private System.Windows.Forms.ToolStripButton quickMine;
		private System.Windows.Forms.ToolStripButton quickOpenDeals;
		private System.Windows.Forms.ToolStripButton quickCustomers;
		private System.Windows.Forms.ToolStripSeparator filterSeparator2;
		private System.Windows.Forms.ToolStripLabel labelAdvanced;
		private System.Windows.Forms.ToolStripButton buttonClearFilter;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton buttonNew;
		private System.Windows.Forms.ToolStripButton buttonEdit;
		private System.Windows.Forms.ToolStripButton buttonDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton buttonFilter;
		private System.Windows.Forms.ToolStripDropDownButton dropDownColumns;
		private System.Windows.Forms.ToolStripButton buttonExport;
		private System.Windows.Forms.ToolStripLabel labelCount;
		private System.Windows.Forms.Panel panelPaging;
		private System.Windows.Forms.Button buttonNext;
		private System.Windows.Forms.Button buttonPrevious;
		private System.Windows.Forms.Label labelPage;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem menuOpen;
		private System.Windows.Forms.ToolStripSeparator menuSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuEdit;
		private System.Windows.Forms.ToolStripMenuItem menuDelete;
	}
}
