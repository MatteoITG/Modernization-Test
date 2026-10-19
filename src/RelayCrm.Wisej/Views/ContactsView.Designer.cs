namespace RelayCrm.Views
{
	partial class ContactsView
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
			this.linkEmpty = new Wisej.Web.LinkLabel();
			this.dataGridView = new Wisej.Web.DataGridView();
			this.colName = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTitle = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCompany = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colPhone = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStage = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOwner = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colLastContacted = new Wisej.Web.DataGridViewTextBoxColumn();
			this.filterStrip = new Wisej.Web.ToolBar();
			this.labelSearch = new Wisej.Web.ToolBarButton();
			this.textSearch = new Wisej.Web.TextBox();
			this.textSearchHost = new Wisej.Web.ToolBarControl();
			this.filterSeparator1 = new Wisej.Web.ToolBarButton();
			this.quickAll = new Wisej.Web.ToolBarButton();
			this.quickLeads = new Wisej.Web.ToolBarButton();
			this.quickProspects = new Wisej.Web.ToolBarButton();
			this.quickCustomers = new Wisej.Web.ToolBarButton();
			this.quickMine = new Wisej.Web.ToolBarButton();
			this.filterSeparator2 = new Wisej.Web.ToolBarButton();
			this.labelAdvanced = new Wisej.Web.ToolBarButton();
			this.buttonClearFilter = new Wisej.Web.ToolBarButton();
			this.toolStrip = new Wisej.Web.ToolBar();
			this.buttonNew = new Wisej.Web.ToolBarButton();
			this.buttonEdit = new Wisej.Web.ToolBarButton();
			this.buttonDelete = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator1 = new Wisej.Web.ToolBarButton();
			this.buttonLogCall = new Wisej.Web.ToolBarButton();
			this.buttonLogEmail = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator2 = new Wisej.Web.ToolBarButton();
			this.buttonFilter = new Wisej.Web.ToolBarButton();
			this.dropDownColumns = new Wisej.Web.ToolBarButton();
			this.dropDownColumnsMenu = new Wisej.Web.ContextMenu(this.components);
			this.buttonExport = new Wisej.Web.ToolBarButton();
			this.labelCount = new Wisej.Web.ToolBarButton();
			this.contextMenu = new Wisej.Web.ContextMenu(this.components);
			this.menuOpen = new Wisej.Web.MenuItem();
			this.menuSeparator1 = new Wisej.Web.MenuItem();
			this.menuLogCall = new Wisej.Web.MenuItem();
			this.menuLogEmail = new Wisej.Web.MenuItem();
			this.menuSeparator2 = new Wisej.Web.MenuItem();
			this.menuEdit = new Wisej.Web.MenuItem();
			this.menuDelete = new Wisej.Web.MenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.filterStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
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
			this.linkEmpty.Text = "No contacts match the search and the filters. Clear the filters";
			this.linkEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkEmpty.Visible = false;
			this.linkEmpty.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkEmpty_LinkClicked);
			//
			// dataGridView
			//
			this.dataGridView.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colName,
			this.colTitle,
			this.colCompany,
			this.colEmail,
			this.colPhone,
			this.colStage,
			this.colOwner,
			this.colLastContacted});
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = Wisej.Web.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 54);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(1000, 546);
			this.dataGridView.TabIndex = 2;
			this.dataGridView.ContextMenu = this.contextMenu;
			this.dataGridView.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
			this.dataGridView.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
			this.dataGridView.CellMouseDown += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
			this.dataGridView.KeyDown += new Wisej.Web.KeyEventHandler(this.dataGridView_KeyDown);
			this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
			//
			// colName
			//
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.colName.DataPropertyName = "FullName";
			this.colName.DefaultCellStyle = dataGridViewCellStyle1;
			this.colName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.MinimumWidth = 150;
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			//
			// colTitle
			//
			this.colTitle.DataPropertyName = "Title";
			this.colTitle.HeaderText = "Job title";
			this.colTitle.Name = "colTitle";
			this.colTitle.Width = 150;
			//
			// colCompany
			//
			this.colCompany.DataPropertyName = "Company";
			this.colCompany.HeaderText = "Company";
			this.colCompany.Name = "colCompany";
			this.colCompany.Width = 170;
			//
			// colEmail
			//
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.HeaderText = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.Width = 210;
			//
			// colPhone
			//
			this.colPhone.DataPropertyName = "Phone";
			this.colPhone.HeaderText = "Phone";
			this.colPhone.Name = "colPhone";
			this.colPhone.Width = 120;
			//
			// colStage
			//
			this.colStage.DataPropertyName = "Stage";
			this.colStage.HeaderText = "Stage";
			this.colStage.Name = "colStage";
			this.colStage.Width = 80;
			//
			// colOwner
			//
			this.colOwner.DataPropertyName = "Owner";
			this.colOwner.HeaderText = "Owner";
			this.colOwner.Name = "colOwner";
			this.colOwner.Width = 120;
			//
			// colLastContacted
			//
			this.colLastContacted.DataPropertyName = "LastContactedText";
			this.colLastContacted.HeaderText = "Last contacted";
			this.colLastContacted.Name = "colLastContacted";
			this.colLastContacted.Width = 110;
			//
			// filterStrip
			//
			this.filterStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.labelSearch,
			this.textSearchHost,
			this.filterSeparator1,
			this.quickAll,
			this.quickLeads,
			this.quickProspects,
			this.quickCustomers,
			this.quickMine,
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
			// quickLeads
			//
			this.quickLeads.Name = "quickLeads";
			this.quickLeads.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.quickLeads.Text = "Leads";
			this.quickLeads.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickProspects
			//
			this.quickProspects.Name = "quickProspects";
			this.quickProspects.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.quickProspects.Text = "Prospects";
			this.quickProspects.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickCustomers
			//
			this.quickCustomers.Name = "quickCustomers";
			this.quickCustomers.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.quickCustomers.Text = "Customers";
			this.quickCustomers.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickMine
			//
			this.quickMine.Name = "quickMine";
			this.quickMine.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.quickMine.Text = "My contacts";
			this.quickMine.Click += new System.EventHandler(this.quickFilter_Click);
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
			this.buttonLogCall,
			this.buttonLogEmail,
			this.toolStripSeparator2,
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
			this.buttonNew.Text = "New contact...";
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
			// buttonLogCall
			//
			this.buttonLogCall.Tag = "telephone";
			this.buttonLogCall.Name = "buttonLogCall";
			this.buttonLogCall.Text = "Log call...";
			this.buttonLogCall.Click += new System.EventHandler(this.menuLogCall_Click);
			//
			// buttonLogEmail
			//
			this.buttonLogEmail.Tag = "envelope";
			this.buttonLogEmail.Name = "buttonLogEmail";
			this.buttonLogEmail.Text = "Log email...";
			this.buttonLogEmail.Click += new System.EventHandler(this.menuLogEmail_Click);
			//
			// toolStripSeparator2
			//
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Style = Wisej.Web.ToolBarButtonStyle.Separator;
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
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			//
			// labelCount
			//
			this.labelCount.Name = "labelCount";
			this.labelCount.Text = "0 contacts";
			//
			// contextMenu
			//
			this.contextMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuOpen,
			this.menuSeparator1,
			this.menuLogCall,
			this.menuLogEmail,
			this.menuSeparator2,
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
			// menuLogCall
			//
			this.menuLogCall.Name = "menuLogCall";
			this.menuLogCall.Text = "Log &call...";
			this.menuLogCall.Click += new System.EventHandler(this.menuLogCall_Click);
			//
			// menuLogEmail
			//
			this.menuLogEmail.Name = "menuLogEmail";
			this.menuLogEmail.Text = "Log &email...";
			this.menuLogEmail.Click += new System.EventHandler(this.menuLogEmail_Click);
			//
			// menuSeparator2
			//
			this.menuSeparator2.Name = "menuSeparator2";
			this.menuSeparator2.Text = "-";
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
			// ContactsView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.linkEmpty);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.filterStrip);
			this.Controls.Add(this.toolStrip);
			this.Name = "ContactsView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.Load += new System.EventHandler(this.ContactsView_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.filterStrip.ResumeLayout(false);
			this.filterStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.LinkLabel linkEmpty;
		private Wisej.Web.DataGridView dataGridView;
		private Wisej.Web.DataGridViewTextBoxColumn colName;
		private Wisej.Web.DataGridViewTextBoxColumn colTitle;
		private Wisej.Web.DataGridViewTextBoxColumn colCompany;
		private Wisej.Web.DataGridViewTextBoxColumn colEmail;
		private Wisej.Web.DataGridViewTextBoxColumn colPhone;
		private Wisej.Web.DataGridViewTextBoxColumn colStage;
		private Wisej.Web.DataGridViewTextBoxColumn colOwner;
		private Wisej.Web.DataGridViewTextBoxColumn colLastContacted;
		private Wisej.Web.ToolBar filterStrip;
		private Wisej.Web.ToolBarButton labelSearch;
		private Wisej.Web.TextBox textSearch;
		private Wisej.Web.ToolBarControl textSearchHost;
		private Wisej.Web.ToolBarButton filterSeparator1;
		private Wisej.Web.ToolBarButton quickAll;
		private Wisej.Web.ToolBarButton quickLeads;
		private Wisej.Web.ToolBarButton quickProspects;
		private Wisej.Web.ToolBarButton quickCustomers;
		private Wisej.Web.ToolBarButton quickMine;
		private Wisej.Web.ToolBarButton filterSeparator2;
		private Wisej.Web.ToolBarButton labelAdvanced;
		private Wisej.Web.ToolBarButton buttonClearFilter;
		private Wisej.Web.ToolBar toolStrip;
		private Wisej.Web.ToolBarButton buttonNew;
		private Wisej.Web.ToolBarButton buttonEdit;
		private Wisej.Web.ToolBarButton buttonDelete;
		private Wisej.Web.ToolBarButton toolStripSeparator1;
		private Wisej.Web.ToolBarButton buttonLogCall;
		private Wisej.Web.ToolBarButton buttonLogEmail;
		private Wisej.Web.ToolBarButton toolStripSeparator2;
		private Wisej.Web.ToolBarButton buttonFilter;
		private Wisej.Web.ToolBarButton dropDownColumns;
		private Wisej.Web.ContextMenu dropDownColumnsMenu;
		private Wisej.Web.ToolBarButton buttonExport;
		private Wisej.Web.ToolBarButton labelCount;
		private Wisej.Web.ContextMenu contextMenu;
		private Wisej.Web.MenuItem menuOpen;
		private Wisej.Web.MenuItem menuSeparator1;
		private Wisej.Web.MenuItem menuLogCall;
		private Wisej.Web.MenuItem menuLogEmail;
		private Wisej.Web.MenuItem menuSeparator2;
		private Wisej.Web.MenuItem menuEdit;
		private Wisej.Web.MenuItem menuDelete;
	}
}
