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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsView));
			Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment3 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment4 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment5 = new Wisej.Web.Segment();
			this.emptyState = new Wisej.Web.EmptyState();
			this.dataGridView = new Wisej.Web.DataGridView();
			this.colName = new Wisej.Web.DataGridViewAvatarColumn();
			this.colTitle = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCompany = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colPhone = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStage = new Wisej.Web.DataGridViewChipColumn();
			this.colOwner = new Wisej.Web.DataGridViewAvatarColumn();
			this.colLastContacted = new Wisej.Web.DataGridViewTextBoxColumn();
			this.panelFilters = new Wisej.Web.Panel();
			this.labelAdvanced = new Wisej.Web.Label();
			this.buttonClearFilter = new Wisej.Web.Button();
			this.segmentedQuick = new Wisej.Web.ChipGroup();
			this.textSearch = new Wisej.Web.TextBox();
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
			this.panelFilters.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			//
			// emptyState
			//
			this.emptyState.ActionText = "Clear the filters";
			this.emptyState.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyState.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/person.svg";
			this.emptyState.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyState.Location = new System.Drawing.Point(0, 100);
			this.emptyState.Name = "emptyState";
			this.emptyState.Size = new System.Drawing.Size(1000, 500);
			this.emptyState.TabIndex = 3;
			this.emptyState.Title = "No contacts match the search and the filters.";
			this.emptyState.Visible = false;
			this.emptyState.ActionClick += new System.EventHandler(this.emptyState_ActionClick);
			//
			// dataGridView
			//
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.BorderStyle = Wisej.Web.BorderStyle.None;
			this.dataGridView.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colName,
			this.colTitle,
			this.colCompany,
			this.colEmail,
			this.colPhone,
			this.colStage,
			this.colOwner,
			this.colLastContacted});
			this.dataGridView.ContextMenu = this.contextMenu;
			this.dataGridView.CssClass = "relay-grid";
			this.dataGridView.Dock = Wisej.Web.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 100);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowTemplate.Height = 44;
			this.dataGridView.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(1000, 500);
			this.dataGridView.TabIndex = 2;
			this.dataGridView.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
			this.dataGridView.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
			this.dataGridView.CellMouseDown += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
			this.dataGridView.KeyDown += new Wisej.Web.KeyEventHandler(this.dataGridView_KeyDown);
			this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
			//
			// colName
			//
			this.colName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.DataPropertyName = "FullName";
			this.colName.HeaderText = "Name";
			this.colName.MinimumWidth = 180;
			this.colName.Name = "colName";
			this.colName.TextMember = "FullName";
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
			this.colStage.Width = 100;
			//
			// colOwner
			//
			this.colOwner.DataPropertyName = "Owner";
			this.colOwner.HeaderText = "Owner";
			this.colOwner.Name = "colOwner";
			this.colOwner.TextMember = "Owner";
			this.colOwner.Width = 150;
			//
			// colLastContacted
			//
			this.colLastContacted.DataPropertyName = "LastContactedText";
			this.colLastContacted.HeaderText = "Last contacted";
			this.colLastContacted.Name = "colLastContacted";
			this.colLastContacted.Width = 110;
			//
			// panelFilters
			//
			this.panelFilters.Controls.Add(this.labelAdvanced);
			this.panelFilters.Controls.Add(this.buttonClearFilter);
			this.panelFilters.Controls.Add(this.segmentedQuick);
			this.panelFilters.Controls.Add(this.textSearch);
			this.panelFilters.Dock = Wisej.Web.DockStyle.Top;
			this.panelFilters.Location = new System.Drawing.Point(0, 44);
			this.panelFilters.Name = "panelFilters";
			this.panelFilters.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelFilters.ResponsiveProfiles"))));
			this.panelFilters.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelFilters.ResponsiveProfiles1"))));
			this.panelFilters.Padding = new Wisej.Web.Padding(12, 8, 12, 8);
			this.panelFilters.Size = new System.Drawing.Size(1000, 56);
			this.panelFilters.TabIndex = 1;
			//
			// labelAdvanced
			//
			this.labelAdvanced.AutoEllipsis = true;
			this.labelAdvanced.CssClass = "relay-muted";
			this.labelAdvanced.Dock = Wisej.Web.DockStyle.Fill;
			this.labelAdvanced.Location = new System.Drawing.Point(744, 8);
			this.labelAdvanced.Name = "labelAdvanced";
			this.labelAdvanced.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.labelAdvanced.Size = new System.Drawing.Size(124, 40);
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
			// segmentedQuick
			//
			this.segmentedQuick.Dock = Wisej.Web.DockStyle.Left;
			segment1.Text = "All";
			segment2.Text = "Leads";
			segment3.Text = "Prospects";
			segment4.Text = "Customers";
			segment5.Text = "My contacts";
			this.segmentedQuick.Items.Add(segment1);
			this.segmentedQuick.Items.Add(segment2);
			this.segmentedQuick.Items.Add(segment3);
			this.segmentedQuick.Items.Add(segment4);
			this.segmentedQuick.Items.Add(segment5);
			this.segmentedQuick.Location = new System.Drawing.Point(292, 8);
			this.segmentedQuick.Name = "segmentedQuick";
			this.segmentedQuick.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("segmentedQuick.ResponsiveProfiles"))));
			this.segmentedQuick.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("segmentedQuick.ResponsiveProfiles1"))));
			this.segmentedQuick.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.segmentedQuick.ShowCounts = true;
			this.segmentedQuick.Size = new System.Drawing.Size(452, 40);
			this.segmentedQuick.TabIndex = 1;
			this.segmentedQuick.SelectedIndexChanged += new System.EventHandler(this.segmentedQuick_SelectedIndexChanged);
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
			this.textSearch.Watermark = "Name, title, company, email, phone or tag";
			this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
			this.textSearch.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textSearch_ToolClick);
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
			this.toolStrip.CssClass = "relay-toolbar";
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new Wisej.Web.Padding(8, 4, 8, 4);
			this.toolStrip.Size = new System.Drawing.Size(1000, 44);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			//
			// buttonNew
			//
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Tag = "plus";
			this.buttonNew.Text = "New contact...";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// buttonEdit
			//
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Tag = "pencil";
			this.buttonEdit.Text = "Edit...";
			this.buttonEdit.Click += new System.EventHandler(this.menuEdit_Click);
			//
			// buttonDelete
			//
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Tag = "trash";
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
			this.buttonLogCall.Name = "buttonLogCall";
			this.buttonLogCall.Tag = "telephone";
			this.buttonLogCall.Text = "Log call...";
			this.buttonLogCall.Click += new System.EventHandler(this.menuLogCall_Click);
			//
			// buttonLogEmail
			//
			this.buttonLogEmail.Name = "buttonLogEmail";
			this.buttonLogEmail.Tag = "envelope";
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
			this.buttonFilter.Name = "buttonFilter";
			this.buttonFilter.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.buttonFilter.Tag = "funnel";
			this.buttonFilter.Text = "Filter...";
			this.buttonFilter.ToolTipText = "Advanced filter";
			this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
			//
			// dropDownColumns
			//
			this.dropDownColumns.DropDownMenu = this.dropDownColumnsMenu;
			this.dropDownColumns.Name = "dropDownColumns";
			this.dropDownColumns.Style = Wisej.Web.ToolBarButtonStyle.DropDownButton;
			this.dropDownColumns.Tag = "layout-three-columns";
			this.dropDownColumns.Text = "Columns";
			//
			// dropDownColumnsMenu
			//
			this.dropDownColumnsMenu.Name = "dropDownColumnsMenu";
			this.dropDownColumnsMenu.Popup += new System.EventHandler(this.dropDownColumns_DropDownOpening);
			//
			// buttonExport
			//
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Tag = "download";
			this.buttonExport.Text = "Export CSV";
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
			this.menuOpen.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.menuOpen.Index = 0;
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Text = "&Open";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			//
			// menuSeparator1
			//
			this.menuSeparator1.Index = 1;
			this.menuSeparator1.Name = "menuSeparator1";
			this.menuSeparator1.Text = "-";
			//
			// menuLogCall
			//
			this.menuLogCall.Index = 2;
			this.menuLogCall.Name = "menuLogCall";
			this.menuLogCall.Text = "Log &call...";
			this.menuLogCall.Click += new System.EventHandler(this.menuLogCall_Click);
			//
			// menuLogEmail
			//
			this.menuLogEmail.Index = 3;
			this.menuLogEmail.Name = "menuLogEmail";
			this.menuLogEmail.Text = "Log &email...";
			this.menuLogEmail.Click += new System.EventHandler(this.menuLogEmail_Click);
			//
			// menuSeparator2
			//
			this.menuSeparator2.Index = 4;
			this.menuSeparator2.Name = "menuSeparator2";
			this.menuSeparator2.Text = "-";
			//
			// menuEdit
			//
			this.menuEdit.Index = 5;
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Text = "E&dit...";
			this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
			//
			// menuDelete
			//
			this.menuDelete.Index = 6;
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Text = "De&lete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// ContactsView
			//
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.emptyState);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.panelFilters);
			this.Controls.Add(this.toolStrip);
			this.CssClass = "relay-card";
			this.Margin = new Wisej.Web.Padding(16);
			this.Name = "ContactsView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.Load += new System.EventHandler(this.ContactsView_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.panelFilters.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.EmptyState emptyState;
		private Wisej.Web.DataGridView dataGridView;
		private Wisej.Web.DataGridViewAvatarColumn colName;
		private Wisej.Web.DataGridViewTextBoxColumn colTitle;
		private Wisej.Web.DataGridViewTextBoxColumn colCompany;
		private Wisej.Web.DataGridViewTextBoxColumn colEmail;
		private Wisej.Web.DataGridViewTextBoxColumn colPhone;
		private Wisej.Web.DataGridViewChipColumn colStage;
		private Wisej.Web.DataGridViewAvatarColumn colOwner;
		private Wisej.Web.DataGridViewTextBoxColumn colLastContacted;
		private Wisej.Web.Panel panelFilters;
		private Wisej.Web.Label labelAdvanced;
		private Wisej.Web.Button buttonClearFilter;
		private Wisej.Web.ChipGroup segmentedQuick;
		private Wisej.Web.TextBox textSearch;
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
