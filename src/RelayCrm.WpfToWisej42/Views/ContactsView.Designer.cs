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

		#region Wisej Designer generated code

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
			this.panelGrid = new Wisej.Web.Panel();
			this.emptyState = new Wisej.Web.EmptyState();
			this.dataGrid = new Wisej.Web.DataGridView();
			this.colName = new Wisej.Web.DataGridViewAvatarColumn();
			this.colTitle = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCompany = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colPhone = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStage = new Wisej.Web.DataGridViewChipColumn();
			this.colLeadSource = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOwner = new Wisej.Web.DataGridViewAvatarColumn();
			this.colTags = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colLastContacted = new Wisej.Web.DataGridViewTextBoxColumn();
			this.menuGrid = new Wisej.Web.ContextMenu(this.components);
			this.menuOpen = new Wisej.Web.MenuItem();
			this.menuSeparator1 = new Wisej.Web.MenuItem();
			this.menuCall = new Wisej.Web.MenuItem();
			this.menuEmail = new Wisej.Web.MenuItem();
			this.menuSeparator2 = new Wisej.Web.MenuItem();
			this.menuEdit = new Wisej.Web.MenuItem();
			this.menuDelete = new Wisej.Web.MenuItem();
			this.panelHeader.SuspendLayout();
			this.flowTools.SuspendLayout();
			this.panelSearch.SuspendLayout();
			this.panelFilter.SuspendLayout();
			this.panelGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
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
			this.panelHeader.Size = new System.Drawing.Size(1058, 56);
			this.panelHeader.TabIndex = 0;
			//
			// labelCount
			//
			this.labelCount.AutoEllipsis = true;
			this.labelCount.CssClass = "relay-muted";
			this.labelCount.Dock = Wisej.Web.DockStyle.Fill;
			this.labelCount.Location = new System.Drawing.Point(142, 10);
			this.labelCount.Name = "labelCount";
			this.labelCount.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.labelCount.Size = new System.Drawing.Size(450, 36);
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
			this.buttonNew.Size = new System.Drawing.Size(130, 36);
			this.buttonNew.TabIndex = 0;
			this.buttonNew.Text = "New contact...";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// flowTools
			//
			this.flowTools.Controls.Add(this.buttonAdvanced);
			this.flowTools.Controls.Add(this.buttonColumns);
			this.flowTools.Controls.Add(this.buttonExport);
			this.flowTools.Dock = Wisej.Web.DockStyle.Right;
			this.flowTools.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowTools.Location = new System.Drawing.Point(592, 10);
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
			this.buttonAdvanced.Location = new System.Drawing.Point(8, 0);
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
			this.buttonColumns.Location = new System.Drawing.Point(176, 0);
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
			this.buttonExport.Location = new System.Drawing.Point(304, 0);
			this.buttonExport.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(140, 36);
			this.buttonExport.TabIndex = 0;
			this.buttonExport.Text = "Export CSV";
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
			this.panelSearch.Size = new System.Drawing.Size(1058, 56);
			this.panelSearch.TabIndex = 1;
			//
			// chipsQuick
			//
			this.chipsQuick.Dock = Wisej.Web.DockStyle.Fill;
			segment1.Text = "All";
			segment2.Text = "Leads";
			segment3.Text = "Prospects";
			segment4.Text = "Customers";
			segment5.Text = "My contacts";
			this.chipsQuick.Items.Add(segment1);
			this.chipsQuick.Items.Add(segment2);
			this.chipsQuick.Items.Add(segment3);
			this.chipsQuick.Items.Add(segment4);
			this.chipsQuick.Items.Add(segment5);
			this.chipsQuick.Location = new System.Drawing.Point(292, 8);
			this.chipsQuick.Name = "chipsQuick";
			this.chipsQuick.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.chipsQuick.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("chipsQuick.ResponsiveProfiles"))));
			this.chipsQuick.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("chipsQuick.ResponsiveProfiles1"))));
			this.chipsQuick.SelectedIndex = 0;
			this.chipsQuick.ShowCounts = true;
			this.chipsQuick.Size = new System.Drawing.Size(754, 40);
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
			this.textBoxSearch.Watermark = "Search name, title, company, email, phone or tag";
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
			this.panelFilter.Size = new System.Drawing.Size(1058, 32);
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
			// panelGrid
			//
			this.panelGrid.Controls.Add(this.emptyState);
			this.panelGrid.Controls.Add(this.dataGrid);
			this.panelGrid.Dock = Wisej.Web.DockStyle.Fill;
			this.panelGrid.Location = new System.Drawing.Point(0, 144);
			this.panelGrid.Name = "panelGrid";
			this.panelGrid.Size = new System.Drawing.Size(1058, 572);
			this.panelGrid.TabIndex = 3;
			//
			// emptyState
			//
			this.emptyState.ActionText = "Clear the filters";
			this.emptyState.Description = "Try another search or clear the filters.";
			this.emptyState.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyState.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/person.svg";
			this.emptyState.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyState.Location = new System.Drawing.Point(0, 0);
			this.emptyState.Name = "emptyState";
			this.emptyState.Size = new System.Drawing.Size(1058, 572);
			this.emptyState.TabIndex = 1;
			this.emptyState.Title = "No contacts match";
			this.emptyState.Visible = false;
			this.emptyState.ActionClick += new System.EventHandler(this.emptyState_ActionClick);
			//
			// dataGrid
			//
			this.dataGrid.AllowUserToResizeRows = false;
			this.dataGrid.AutoGenerateColumns = false;
			this.dataGrid.BorderStyle = Wisej.Web.BorderStyle.None;
			this.dataGrid.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colName,
			this.colTitle,
			this.colCompany,
			this.colEmail,
			this.colPhone,
			this.colStage,
			this.colLeadSource,
			this.colOwner,
			this.colTags,
			this.colLastContacted});
			this.dataGrid.ContextMenu = this.menuGrid;
			this.dataGrid.CssClass = "relay-grid";
			this.dataGrid.Dock = Wisej.Web.DockStyle.Fill;
			this.dataGrid.KeepSameRowHeight = true;
			this.dataGrid.Location = new System.Drawing.Point(0, 0);
			this.dataGrid.MultiSelect = false;
			this.dataGrid.Name = "dataGrid";
			this.dataGrid.ReadOnly = true;
			this.dataGrid.RightClickSelection = true;
			this.dataGrid.RowHeadersVisible = false;
			this.dataGrid.RowTemplate.Height = 44;
			this.dataGrid.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.dataGrid.ShowColumnVisibilityMenu = false;
			this.dataGrid.Size = new System.Drawing.Size(1058, 572);
			this.dataGrid.TabIndex = 0;
			this.dataGrid.ToolTipText = "Double-click to open the contact; right-click for more";
			this.dataGrid.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
			//
			// colName
			//
			this.colName.AutoColor = true;
			this.colName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.DataPropertyName = "FullName";
			this.colName.FillWeight = 200F;
			this.colName.HeaderText = "Name";
			this.colName.MinimumWidth = 180;
			this.colName.Name = "colName";
			this.colName.TextMember = "FullName";
			//
			// colTitle
			//
			this.colTitle.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTitle.DataPropertyName = "Title";
			this.colTitle.FillWeight = 150F;
			this.colTitle.HeaderText = "Job title";
			this.colTitle.Name = "colTitle";
			this.colTitle.Visible = false;
			//
			// colCompany
			//
			this.colCompany.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colCompany.DataPropertyName = "Company";
			this.colCompany.FillWeight = 150F;
			this.colCompany.HeaderText = "Company";
			this.colCompany.Name = "colCompany";
			//
			// colEmail
			//
			this.colEmail.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.FillWeight = 200F;
			this.colEmail.HeaderText = "Email";
			this.colEmail.Name = "colEmail";
			//
			// colPhone
			//
			this.colPhone.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colPhone.DataPropertyName = "Phone";
			this.colPhone.FillWeight = 120F;
			this.colPhone.HeaderText = "Phone";
			this.colPhone.Name = "colPhone";
			//
			// colStage
			//
			this.colStage.DataPropertyName = "Stage";
			this.colStage.HeaderText = "Stage";
			this.colStage.Name = "colStage";
			this.colStage.Width = 110;
			//
			// colLeadSource
			//
			this.colLeadSource.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colLeadSource.DataPropertyName = "LeadSource";
			this.colLeadSource.HeaderText = "Lead source";
			this.colLeadSource.Name = "colLeadSource";
			this.colLeadSource.Visible = false;
			//
			// colOwner
			//
			this.colOwner.AutoColor = true;
			this.colOwner.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colOwner.DataPropertyName = "Owner";
			this.colOwner.FillWeight = 140F;
			this.colOwner.HeaderText = "Owner";
			this.colOwner.Name = "colOwner";
			this.colOwner.TextMember = "Owner";
			//
			// colTags
			//
			this.colTags.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTags.DataPropertyName = "Tags";
			this.colTags.HeaderText = "Tags";
			this.colTags.Name = "colTags";
			this.colTags.Visible = false;
			//
			// colLastContacted
			//
			this.colLastContacted.DataPropertyName = "LastContacted";
			this.colLastContacted.HeaderText = "Last contacted";
			this.colLastContacted.Name = "colLastContacted";
			this.colLastContacted.Tag = "Fmt:Relative";
			this.colLastContacted.Width = 120;
			//
			// menuGrid
			//
			this.menuGrid.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuOpen,
			this.menuSeparator1,
			this.menuCall,
			this.menuEmail,
			this.menuSeparator2,
			this.menuEdit,
			this.menuDelete});
			this.menuGrid.Name = "menuGrid";
			//
			// menuOpen
			//
			this.menuOpen.AllowHtml = true;
			this.menuOpen.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/box-arrow-up-right.svg";
			this.menuOpen.Index = 0;
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Text = "<b>Open</b>";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			//
			// menuSeparator1
			//
			this.menuSeparator1.Index = 1;
			this.menuSeparator1.Name = "menuSeparator1";
			this.menuSeparator1.Text = "-";
			//
			// menuCall
			//
			this.menuCall.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/telephone.svg";
			this.menuCall.Index = 2;
			this.menuCall.Name = "menuCall";
			this.menuCall.Text = "Log call...";
			this.menuCall.Click += new System.EventHandler(this.menuCall_Click);
			//
			// menuEmail
			//
			this.menuEmail.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/envelope.svg";
			this.menuEmail.Index = 3;
			this.menuEmail.Name = "menuEmail";
			this.menuEmail.Text = "Log email...";
			this.menuEmail.Click += new System.EventHandler(this.menuEmail_Click);
			//
			// menuSeparator2
			//
			this.menuSeparator2.Index = 4;
			this.menuSeparator2.Name = "menuSeparator2";
			this.menuSeparator2.Text = "-";
			//
			// menuEdit
			//
			this.menuEdit.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/pencil.svg";
			this.menuEdit.Index = 5;
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Text = "Edit...";
			this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
			//
			// menuDelete
			//
			this.menuDelete.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			this.menuDelete.Index = 6;
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Text = "Delete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// ContactsView
			//
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panelGrid);
			this.Controls.Add(this.panelFilter);
			this.Controls.Add(this.panelSearch);
			this.Controls.Add(this.panelHeader);
			this.CssClass = "relay-card";
			this.Name = "ContactsView";
			this.Size = new System.Drawing.Size(1058, 716);
			this.panelHeader.ResumeLayout(false);
			this.flowTools.ResumeLayout(false);
			this.panelSearch.ResumeLayout(false);
			this.panelFilter.ResumeLayout(false);
			this.panelFilter.PerformLayout();
			this.panelGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
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
		private Wisej.Web.Panel panelGrid;
		private Wisej.Web.EmptyState emptyState;
		private Wisej.Web.DataGridView dataGrid;
		private Wisej.Web.DataGridViewAvatarColumn colName;
		private Wisej.Web.DataGridViewTextBoxColumn colTitle;
		private Wisej.Web.DataGridViewTextBoxColumn colCompany;
		private Wisej.Web.DataGridViewTextBoxColumn colEmail;
		private Wisej.Web.DataGridViewTextBoxColumn colPhone;
		private Wisej.Web.DataGridViewChipColumn colStage;
		private Wisej.Web.DataGridViewTextBoxColumn colLeadSource;
		private Wisej.Web.DataGridViewAvatarColumn colOwner;
		private Wisej.Web.DataGridViewTextBoxColumn colTags;
		private Wisej.Web.DataGridViewTextBoxColumn colLastContacted;
		private Wisej.Web.ContextMenu menuGrid;
		private Wisej.Web.MenuItem menuOpen;
		private Wisej.Web.MenuItem menuSeparator1;
		private Wisej.Web.MenuItem menuCall;
		private Wisej.Web.MenuItem menuEmail;
		private Wisej.Web.MenuItem menuSeparator2;
		private Wisej.Web.MenuItem menuEdit;
		private Wisej.Web.MenuItem menuDelete;
	}
}
