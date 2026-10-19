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
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment3 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment4 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment5 = new Wisej.Web.Segment();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.CardAction cardAction1 = new Wisej.Web.CardAction();
			Wisej.Web.CardAction cardAction2 = new Wisej.Web.CardAction();
			Wisej.Web.CardAction cardAction3 = new Wisej.Web.CardAction();
			Wisej.Web.CardAction cardAction4 = new Wisej.Web.CardAction();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelCount = new Wisej.Web.Label();
			this.buttonNew = new Wisej.Web.Button();
			this.panelToolbar = new Wisej.Web.Panel();
			this.textBoxSearch = new Wisej.Web.TextBox();
			this.chipGroupFilters = new Wisej.Web.ChipGroup();
			this.buttonAdvanced = new Wisej.Web.Button();
			this.buttonColumns = new Wisej.Web.Button();
			this.buttonExport = new Wisej.Web.Button();
			this.panelAdvanced = new Wisej.Web.Panel();
			this.panelAdvancedCard = new Wisej.Web.Panel();
			this.queryBuilder = new Wisej.Web.QueryBuilder();
			this.panelGrid = new Wisej.Web.Panel();
			this.dataGridView = new Wisej.Web.DataGridView();
			this.colName = new Wisej.Web.DataGridViewAvatarColumn();
			this.colCompany = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colPhone = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStage = new Wisej.Web.DataGridViewChipColumn();
			this.colOwner = new Wisej.Web.DataGridViewAvatarColumn();
			this.colLastContacted = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colActions = new Wisej.Web.DataGridViewActionsColumn();
			this.emptyState = new Wisej.Web.EmptyState();
			this.contextMenuColumns = new Wisej.Web.ContextMenu(this.components);
			this.panelHeader.SuspendLayout();
			this.panelToolbar.SuspendLayout();
			this.panelAdvanced.SuspendLayout();
			this.panelAdvancedCard.SuspendLayout();
			this.panelGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.buttonNew);
			this.panelHeader.Controls.Add(this.labelCount);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1100, 48);
			this.panelHeader.TabIndex = 0;
			//
			// labelCount
			//
			this.labelCount.CssClass = "relay-muted";
			this.labelCount.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelCount.Location = new System.Drawing.Point(0, 0);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(500, 48);
			this.labelCount.TabIndex = 0;
			this.labelCount.Text = "0 contacts";
			this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonNew
			//
			this.buttonNew.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonNew.CssClass = "relay-primary";
			this.buttonNew.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus-lg.svg";
			this.buttonNew.Location = new System.Drawing.Point(956, 6);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(144, 36);
			this.buttonNew.TabIndex = 1;
			this.buttonNew.Text = "New contact";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// panelToolbar
			//
			this.panelToolbar.Controls.Add(this.buttonExport);
			this.panelToolbar.Controls.Add(this.buttonColumns);
			this.panelToolbar.Controls.Add(this.buttonAdvanced);
			this.panelToolbar.Controls.Add(this.chipGroupFilters);
			this.panelToolbar.Controls.Add(this.textBoxSearch);
			this.panelToolbar.Dock = Wisej.Web.DockStyle.Top;
			this.panelToolbar.Location = new System.Drawing.Point(0, 48);
			this.panelToolbar.Name = "panelToolbar";
			this.panelToolbar.Size = new System.Drawing.Size(1100, 52);
			this.panelToolbar.TabIndex = 1;
			//
			// textBoxSearch
			//
			this.textBoxSearch.AutoSize = false;
			this.textBoxSearch.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.textBoxSearch.Location = new System.Drawing.Point(0, 0);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(280, 36);
			this.textBoxSearch.TabIndex = 0;
			this.textBoxSearch.Watermark = "Search contacts";
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			//
			// chipGroupFilters
			//
			this.chipGroupFilters.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			segment1.Text = "All";
			segment2.Text = "Leads";
			segment3.Text = "Prospects";
			segment4.Text = "Customers";
			segment5.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/person.svg";
			segment5.Text = "My contacts";
			this.chipGroupFilters.Items.Add(segment1);
			this.chipGroupFilters.Items.Add(segment2);
			this.chipGroupFilters.Items.Add(segment3);
			this.chipGroupFilters.Items.Add(segment4);
			this.chipGroupFilters.Items.Add(segment5);
			this.chipGroupFilters.Location = new System.Drawing.Point(296, 0);
			this.chipGroupFilters.Name = "chipGroupFilters";
			this.chipGroupFilters.SelectedIndex = 0;
			this.chipGroupFilters.ShowCounts = true;
			this.chipGroupFilters.Size = new System.Drawing.Size(664, 36);
			this.chipGroupFilters.TabIndex = 1;
			this.chipGroupFilters.SelectedIndexChanged += new System.EventHandler(this.chipGroupFilters_SelectedIndexChanged);
			//
			// buttonAdvanced
			//
			this.buttonAdvanced.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonAdvanced.CssClass = "relay-secondary";
			this.buttonAdvanced.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/funnel.svg";
			this.buttonAdvanced.Location = new System.Drawing.Point(976, 0);
			this.buttonAdvanced.Name = "buttonAdvanced";
			this.buttonAdvanced.Size = new System.Drawing.Size(36, 36);
			this.buttonAdvanced.TabIndex = 2;
			this.buttonAdvanced.ToolTipText = "Advanced filter";
			this.buttonAdvanced.Click += new System.EventHandler(this.buttonAdvanced_Click);
			//
			// buttonColumns
			//
			this.buttonColumns.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonColumns.CssClass = "relay-secondary";
			this.buttonColumns.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/columns-gap.svg";
			this.buttonColumns.Location = new System.Drawing.Point(1020, 0);
			this.buttonColumns.Name = "buttonColumns";
			this.buttonColumns.Size = new System.Drawing.Size(36, 36);
			this.buttonColumns.TabIndex = 3;
			this.buttonColumns.ToolTipText = "Choose columns";
			this.buttonColumns.Click += new System.EventHandler(this.buttonColumns_Click);
			//
			// buttonExport
			//
			this.buttonExport.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonExport.CssClass = "relay-secondary";
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/download.svg";
			this.buttonExport.Location = new System.Drawing.Point(1064, 0);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(36, 36);
			this.buttonExport.TabIndex = 4;
			this.buttonExport.ToolTipText = "Export to CSV";
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			//
			// panelAdvanced
			//
			this.panelAdvanced.Controls.Add(this.panelAdvancedCard);
			this.panelAdvanced.Dock = Wisej.Web.DockStyle.Top;
			this.panelAdvanced.Location = new System.Drawing.Point(0, 100);
			this.panelAdvanced.Name = "panelAdvanced";
			this.panelAdvanced.Padding = new Wisej.Web.Padding(0, 0, 0, 16);
			this.panelAdvanced.Size = new System.Drawing.Size(1100, 236);
			this.panelAdvanced.TabIndex = 2;
			this.panelAdvanced.Visible = false;
			//
			// panelAdvancedCard
			//
			this.panelAdvancedCard.Controls.Add(this.queryBuilder);
			this.panelAdvancedCard.CssClass = "relay-card";
			this.panelAdvancedCard.Dock = Wisej.Web.DockStyle.Fill;
			this.panelAdvancedCard.Location = new System.Drawing.Point(0, 0);
			this.panelAdvancedCard.Name = "panelAdvancedCard";
			this.panelAdvancedCard.Padding = new Wisej.Web.Padding(20);
			this.panelAdvancedCard.Size = new System.Drawing.Size(1100, 220);
			this.panelAdvancedCard.TabIndex = 0;
			//
			// queryBuilder
			//
			this.queryBuilder.Dock = Wisej.Web.DockStyle.Fill;
			this.queryBuilder.Location = new System.Drawing.Point(20, 20);
			this.queryBuilder.Name = "queryBuilder";
			this.queryBuilder.ShowPreview = true;
			this.queryBuilder.Size = new System.Drawing.Size(1060, 180);
			this.queryBuilder.TabIndex = 0;
			this.queryBuilder.QueryChanged += new System.EventHandler(this.queryBuilder_QueryChanged);
			//
			// panelGrid
			//
			this.panelGrid.Controls.Add(this.emptyState);
			this.panelGrid.Controls.Add(this.dataGridView);
			this.panelGrid.CssClass = "relay-card";
			this.panelGrid.Dock = Wisej.Web.DockStyle.Fill;
			this.panelGrid.Location = new System.Drawing.Point(0, 100);
			this.panelGrid.Name = "panelGrid";
			this.panelGrid.Padding = new Wisej.Web.Padding(20);
			this.panelGrid.Size = new System.Drawing.Size(1100, 660);
			this.panelGrid.TabIndex = 3;
			//
			// dataGridView
			//
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.BorderStyle = Wisej.Web.BorderStyle.None;
			this.dataGridView.CellBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.Horizontal;
			dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.ColumnHeadersHeight = 40;
			this.dataGridView.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colName,
            this.colCompany,
            this.colEmail,
            this.colPhone,
            this.colStage,
            this.colOwner,
            this.colLastContacted,
            this.colActions});
			this.dataGridView.CssClass = "relay-grid";
			dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView.Dock = Wisej.Web.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(20, 20);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowTemplate.Height = 52;
			this.dataGridView.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(1060, 620);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
			this.dataGridView.Resize += new System.EventHandler(this.dataGridView_Resize);
			//
			// colName
			//
			this.colName.AutoColor = true;
			this.colName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.DataPropertyName = "FullName";
			this.colName.HeaderText = "Name";
			this.colName.MinimumWidth = 200;
			this.colName.Name = "colName";
			this.colName.Size = 36;
			this.colName.SubTextMember = "Title";
			this.colName.AvatarClick += new System.EventHandler<Wisej.Web.DataGridViewVisualCellEventArgs>(this.colName_AvatarClick);
			//
			// colCompany
			//
			this.colCompany.DataPropertyName = "Company";
			this.colCompany.HeaderText = "Company";
			this.colCompany.Name = "colCompany";
			this.colCompany.Width = 140;
			//
			// colEmail
			//
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.HeaderText = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.Width = 190;
			//
			// colPhone
			//
			this.colPhone.DataPropertyName = "Phone";
			this.colPhone.HeaderText = "Phone";
			this.colPhone.Name = "colPhone";
			this.colPhone.Width = 130;
			//
			// colStage
			//
			this.colStage.DataPropertyName = "Stage";
			this.colStage.HeaderText = "Stage";
			this.colStage.Name = "colStage";
			this.colStage.ShowDot = true;
			this.colStage.Width = 112;
			//
			// colOwner
			//
			this.colOwner.AutoColor = true;
			this.colOwner.DataPropertyName = "Owner";
			this.colOwner.HeaderText = "Owner";
			this.colOwner.Name = "colOwner";
			this.colOwner.Size = 24;
			this.colOwner.Width = 144;
			//
			// colLastContacted
			//
			this.colLastContacted.DataPropertyName = "LastContactedText";
			this.colLastContacted.HeaderText = "Last contacted";
			this.colLastContacted.Name = "colLastContacted";
			this.colLastContacted.Width = 128;
			//
			// colActions
			//
			cardAction1.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/telephone.svg";
			cardAction1.Name = "call";
			cardAction1.Text = "Log call";
			cardAction2.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/envelope.svg";
			cardAction2.Name = "email";
			cardAction2.Text = "Log email";
			cardAction3.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/pencil.svg";
			cardAction3.Name = "edit";
			cardAction3.Text = "Edit";
			cardAction4.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			cardAction4.Name = "delete";
			cardAction4.Text = "Delete";
			this.colActions.Actions.Add(cardAction1);
			this.colActions.Actions.Add(cardAction2);
			this.colActions.Actions.Add(cardAction3);
			this.colActions.Actions.Add(cardAction4);
			this.colActions.HeaderText = "";
			this.colActions.IconOnly = true;
			this.colActions.Name = "colActions";
			this.colActions.Overflow = 2;
			this.colActions.Resizable = Wisej.Web.DataGridViewTriState.False;
			this.colActions.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable;
			this.colActions.Width = 112;
			this.colActions.ActionClick += new System.EventHandler<Wisej.Web.DataGridViewVisualCellEventArgs>(this.colActions_ActionClick);
			//
			// emptyState
			//
			this.emptyState.ActionText = "Clear filters";
			this.emptyState.Description = "Try another search, quick filter or advanced filter.";
			this.emptyState.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/people.svg";
			this.emptyState.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyState.Location = new System.Drawing.Point(400, 230);
			this.emptyState.Name = "emptyState";
			this.emptyState.Size = new System.Drawing.Size(300, 200);
			this.emptyState.TabIndex = 1;
			this.emptyState.TargetControl = this.dataGridView;
			this.emptyState.Title = "No contacts match";
			this.emptyState.ActionClick += new System.EventHandler(this.emptyState_ActionClick);
			//
			// contextMenuColumns
			//
			this.contextMenuColumns.Name = "contextMenuColumns";
			//
			// ContactsView
			//
			this.Controls.Add(this.panelGrid);
			this.Controls.Add(this.panelAdvanced);
			this.Controls.Add(this.panelToolbar);
			this.Controls.Add(this.panelHeader);
			this.Name = "ContactsView";
			this.Size = new System.Drawing.Size(1100, 760);
			this.panelHeader.ResumeLayout(false);
			this.panelToolbar.ResumeLayout(false);
			this.panelAdvanced.ResumeLayout(false);
			this.panelAdvancedCard.ResumeLayout(false);
			this.panelGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelCount;
		private Wisej.Web.Button buttonNew;
		private Wisej.Web.Panel panelToolbar;
		private Wisej.Web.TextBox textBoxSearch;
		private Wisej.Web.ChipGroup chipGroupFilters;
		private Wisej.Web.Button buttonAdvanced;
		private Wisej.Web.Button buttonColumns;
		private Wisej.Web.Button buttonExport;
		private Wisej.Web.Panel panelAdvanced;
		private Wisej.Web.Panel panelAdvancedCard;
		private Wisej.Web.QueryBuilder queryBuilder;
		private Wisej.Web.Panel panelGrid;
		private Wisej.Web.DataGridView dataGridView;
		private Wisej.Web.DataGridViewAvatarColumn colName;
		private Wisej.Web.DataGridViewTextBoxColumn colCompany;
		private Wisej.Web.DataGridViewTextBoxColumn colEmail;
		private Wisej.Web.DataGridViewTextBoxColumn colPhone;
		private Wisej.Web.DataGridViewChipColumn colStage;
		private Wisej.Web.DataGridViewAvatarColumn colOwner;
		private Wisej.Web.DataGridViewTextBoxColumn colLastContacted;
		private Wisej.Web.DataGridViewActionsColumn colActions;
		private Wisej.Web.EmptyState emptyState;
		private Wisej.Web.ContextMenu contextMenuColumns;
	}
}
