namespace RelayCrm.Views
{
	partial class DealsView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DealsView));
			this.components = new System.ComponentModel.Container();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelSummary = new Wisej.Web.Label();
			this.buttonNew = new Wisej.Web.Button();
			this.segmentedMode = new Wisej.Web.SegmentedButton();
			this.flowFilters = new Wisej.Web.FlowLayoutPanel();
			this.labelOwner = new Wisej.Web.Label();
			this.comboBoxOwner = new Wisej.Web.ComboBox();
			this.labelFrom = new Wisej.Web.Label();
			this.datePickerFrom = new Wisej.Web.DateTimePicker();
			this.labelTo = new Wisej.Web.Label();
			this.datePickerTo = new Wisej.Web.DateTimePicker();
			this.labelAmountFrom = new Wisej.Web.Label();
			this.textBoxMin = new Wisej.Web.TextBox();
			this.labelAmountTo = new Wisej.Web.Label();
			this.textBoxMax = new Wisej.Web.TextBox();
			this.linkClear = new Wisej.Web.LinkLabel();
			this.panelCaption = new Wisej.Web.Panel();
			this.linkShowAll = new Wisej.Web.LinkLabel();
			this.runCaption = new Wisej.Web.Label();
			this.panelBody = new Wisej.Web.Panel();
			this.panelList = new Wisej.Web.Panel();
			this.emptyList = new Wisej.Web.EmptyState();
			this.dataGrid = new Wisej.Web.DataGridView();
			this.colTitle = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCompany = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colContact = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStage = new Wisej.Web.DataGridViewChipColumn();
			this.colAmount = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colClose = new Wisej.Web.DataGridViewChipColumn();
			this.colProbability = new Wisej.Web.DataGridViewMeterColumn();
			this.colOwner = new Wisej.Web.DataGridViewAvatarColumn();
			this.listMenu = new Wisej.Web.ContextMenu(this.components);
			this.menuOpen = new Wisej.Web.MenuItem();
			this.menuEdit = new Wisej.Web.MenuItem();
			this.menuMoveTo = new Wisej.Web.MenuItem();
			this.panelBoard = new Wisej.Web.Panel();
			this.kanbanBoard = new Wisej.Web.KanbanBoard();
			this.menuCard = new Wisej.Web.ContextMenu(this.components);
			this.menuCardOpen = new Wisej.Web.MenuItem();
			this.menuCardEdit = new Wisej.Web.MenuItem();
			this.menuCardSeparator = new Wisej.Web.MenuItem();
			this.menuCardMoveTo = new Wisej.Web.MenuItem();
			this.panelHeader.SuspendLayout();
			this.flowFilters.SuspendLayout();
			this.panelCaption.SuspendLayout();
			this.panelBody.SuspendLayout();
			this.panelList.SuspendLayout();
			this.panelBoard.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.labelSummary);
			this.panelHeader.Controls.Add(this.buttonNew);
			this.panelHeader.Controls.Add(this.segmentedMode);
			this.panelHeader.CssClass = "relay-toolbar";
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelHeader.ResponsiveProfiles"))));
			this.panelHeader.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelHeader.ResponsiveProfiles1"))));
			this.panelHeader.Padding = new Wisej.Web.Padding(12, 8, 12, 8);
			this.panelHeader.Size = new System.Drawing.Size(1066, 56);
			this.panelHeader.TabIndex = 0;
			//
			// labelSummary
			//
			this.labelSummary.AutoEllipsis = true;
			this.labelSummary.CssClass = "relay-muted";
			this.labelSummary.Dock = Wisej.Web.DockStyle.Fill;
			this.labelSummary.Location = new System.Drawing.Point(132, 8);
			this.labelSummary.Name = "labelSummary";
			this.labelSummary.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.labelSummary.Size = new System.Drawing.Size(702, 40);
			this.labelSummary.TabIndex = 1;
			this.labelSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonNew
			//
			this.buttonNew.CssClass = "relay-primary";
			this.buttonNew.Dock = Wisej.Web.DockStyle.Left;
			this.buttonNew.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus.svg";
			this.buttonNew.Location = new System.Drawing.Point(12, 8);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(120, 40);
			this.buttonNew.TabIndex = 0;
			this.buttonNew.Text = "New deal...";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// segmentedMode
			//
			this.segmentedMode.Dock = Wisej.Web.DockStyle.Right;
			segment1.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/kanban.svg";
			segment1.Text = "Board";
			segment2.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/list-ul.svg";
			segment2.Text = "List";
			this.segmentedMode.Items.Add(segment1);
			this.segmentedMode.Items.Add(segment2);
			this.segmentedMode.Location = new System.Drawing.Point(834, 8);
			this.segmentedMode.Name = "segmentedMode";
			this.segmentedMode.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("segmentedMode.ResponsiveProfiles"))));
			this.segmentedMode.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("segmentedMode.ResponsiveProfiles1"))));
			this.segmentedMode.SelectedIndex = 0;
			this.segmentedMode.Size = new System.Drawing.Size(220, 40);
			this.segmentedMode.TabIndex = 2;
			this.segmentedMode.SelectedIndexChanged += new System.EventHandler(this.segmentedMode_SelectedIndexChanged);
			//
			// flowFilters
			//
			this.flowFilters.AutoSize = true;
			this.flowFilters.Controls.Add(this.labelOwner);
			this.flowFilters.Controls.Add(this.comboBoxOwner);
			this.flowFilters.Controls.Add(this.labelFrom);
			this.flowFilters.Controls.Add(this.datePickerFrom);
			this.flowFilters.Controls.Add(this.labelTo);
			this.flowFilters.Controls.Add(this.datePickerTo);
			this.flowFilters.Controls.Add(this.labelAmountFrom);
			this.flowFilters.Controls.Add(this.textBoxMin);
			this.flowFilters.Controls.Add(this.labelAmountTo);
			this.flowFilters.Controls.Add(this.textBoxMax);
			this.flowFilters.Controls.Add(this.linkClear);
			this.flowFilters.Dock = Wisej.Web.DockStyle.Top;
			this.flowFilters.Location = new System.Drawing.Point(0, 56);
			this.flowFilters.Name = "flowFilters";
			this.flowFilters.Padding = new Wisej.Web.Padding(12, 8, 12, 8);
			this.flowFilters.Size = new System.Drawing.Size(1066, 50);
			this.flowFilters.TabIndex = 1;
			this.flowFilters.TabStop = true;
			//
			// labelOwner
			//
			this.labelOwner.AutoSize = true;
			this.labelOwner.CssClass = "relay-muted";
			this.labelOwner.Location = new System.Drawing.Point(12, 15);
			this.labelOwner.Margin = new Wisej.Web.Padding(0, 7, 6, 0);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Size = new System.Drawing.Size(44, 16);
			this.labelOwner.TabIndex = 0;
			this.labelOwner.Text = "Owner:";
			//
			// comboBoxOwner
			//
			this.comboBoxOwner.DisplayMember = "Text";
			this.comboBoxOwner.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOwner.Location = new System.Drawing.Point(62, 8);
			this.comboBoxOwner.Margin = new Wisej.Web.Padding(0, 0, 0, 4);
			this.comboBoxOwner.Name = "comboBoxOwner";
			this.comboBoxOwner.Size = new System.Drawing.Size(150, 30);
			this.comboBoxOwner.TabIndex = 1;
			this.comboBoxOwner.ValueMember = "Id";
			this.comboBoxOwner.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
			//
			// labelFrom
			//
			this.labelFrom.AutoSize = true;
			this.labelFrom.CssClass = "relay-muted";
			this.labelFrom.Location = new System.Drawing.Point(228, 15);
			this.labelFrom.Margin = new Wisej.Web.Padding(16, 7, 6, 0);
			this.labelFrom.Name = "labelFrom";
			this.labelFrom.Size = new System.Drawing.Size(70, 16);
			this.labelFrom.TabIndex = 2;
			this.labelFrom.Text = "Close from:";
			//
			// datePickerFrom
			//
			this.datePickerFrom.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.datePickerFrom.Location = new System.Drawing.Point(304, 8);
			this.datePickerFrom.Margin = new Wisej.Web.Padding(0, 0, 0, 4);
			this.datePickerFrom.Name = "datePickerFrom";
			this.datePickerFrom.Size = new System.Drawing.Size(150, 30);
			this.datePickerFrom.TabIndex = 3;
			this.datePickerFrom.ValueChanged += new System.EventHandler(this.filter_Changed);
			//
			// labelTo
			//
			this.labelTo.AutoSize = true;
			this.labelTo.CssClass = "relay-muted";
			this.labelTo.Location = new System.Drawing.Point(460, 15);
			this.labelTo.Margin = new Wisej.Web.Padding(6, 7, 6, 0);
			this.labelTo.Name = "labelTo";
			this.labelTo.Size = new System.Drawing.Size(18, 16);
			this.labelTo.TabIndex = 4;
			this.labelTo.Text = "to:";
			//
			// datePickerTo
			//
			this.datePickerTo.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.datePickerTo.Location = new System.Drawing.Point(484, 8);
			this.datePickerTo.Margin = new Wisej.Web.Padding(0, 0, 0, 4);
			this.datePickerTo.Name = "datePickerTo";
			this.datePickerTo.Size = new System.Drawing.Size(150, 30);
			this.datePickerTo.TabIndex = 5;
			this.datePickerTo.ValueChanged += new System.EventHandler(this.filter_Changed);
			//
			// labelAmountFrom
			//
			this.labelAmountFrom.AutoSize = true;
			this.labelAmountFrom.CssClass = "relay-muted";
			this.labelAmountFrom.Location = new System.Drawing.Point(650, 15);
			this.labelAmountFrom.Margin = new Wisej.Web.Padding(16, 7, 6, 0);
			this.labelAmountFrom.Name = "labelAmountFrom";
			this.labelAmountFrom.Size = new System.Drawing.Size(84, 16);
			this.labelAmountFrom.TabIndex = 6;
			this.labelAmountFrom.Text = "Amount from:";
			//
			// textBoxMin
			//
			this.textBoxMin.Location = new System.Drawing.Point(740, 8);
			this.textBoxMin.Margin = new Wisej.Web.Padding(0, 0, 0, 4);
			this.textBoxMin.Name = "textBoxMin";
			this.textBoxMin.Size = new System.Drawing.Size(90, 30);
			this.textBoxMin.TabIndex = 7;
			this.textBoxMin.Watermark = "$ min";
			this.textBoxMin.TextChanged += new System.EventHandler(this.filter_Changed);
			//
			// labelAmountTo
			//
			this.labelAmountTo.AutoSize = true;
			this.labelAmountTo.CssClass = "relay-muted";
			this.labelAmountTo.Location = new System.Drawing.Point(836, 15);
			this.labelAmountTo.Margin = new Wisej.Web.Padding(6, 7, 6, 0);
			this.labelAmountTo.Name = "labelAmountTo";
			this.labelAmountTo.Size = new System.Drawing.Size(18, 16);
			this.labelAmountTo.TabIndex = 8;
			this.labelAmountTo.Text = "to:";
			//
			// textBoxMax
			//
			this.textBoxMax.Location = new System.Drawing.Point(860, 8);
			this.textBoxMax.Margin = new Wisej.Web.Padding(0, 0, 0, 4);
			this.textBoxMax.Name = "textBoxMax";
			this.textBoxMax.Size = new System.Drawing.Size(90, 30);
			this.textBoxMax.TabIndex = 9;
			this.textBoxMax.Watermark = "$ max";
			this.textBoxMax.TextChanged += new System.EventHandler(this.filter_Changed);
			//
			// linkClear
			//
			this.linkClear.AutoSize = true;
			this.linkClear.Location = new System.Drawing.Point(966, 15);
			this.linkClear.Margin = new Wisej.Web.Padding(16, 7, 0, 0);
			this.linkClear.Name = "linkClear";
			this.linkClear.Size = new System.Drawing.Size(76, 16);
			this.linkClear.TabIndex = 10;
			this.linkClear.TabStop = true;
			this.linkClear.Text = "Clear filters";
			this.linkClear.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkClear_Click);
			//
			// panelCaption
			//
			this.panelCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(240)))), ((int)(((byte)(254)))));
			this.panelCaption.Controls.Add(this.linkShowAll);
			this.panelCaption.Controls.Add(this.runCaption);
			this.panelCaption.Dock = Wisej.Web.DockStyle.Top;
			this.panelCaption.Location = new System.Drawing.Point(0, 106);
			this.panelCaption.Name = "panelCaption";
			this.panelCaption.Padding = new Wisej.Web.Padding(12, 4, 12, 4);
			this.panelCaption.Size = new System.Drawing.Size(1066, 32);
			this.panelCaption.TabIndex = 2;
			this.panelCaption.Visible = false;
			//
			// linkShowAll
			//
			this.linkShowAll.AutoSize = true;
			this.linkShowAll.Dock = Wisej.Web.DockStyle.Left;
			this.linkShowAll.Location = new System.Drawing.Point(16, 4);
			this.linkShowAll.Name = "linkShowAll";
			this.linkShowAll.Padding = new Wisej.Web.Padding(10, 0, 0, 0);
			this.linkShowAll.Size = new System.Drawing.Size(100, 24);
			this.linkShowAll.TabIndex = 1;
			this.linkShowAll.TabStop = true;
			this.linkShowAll.Text = "Show all deals";
			this.linkShowAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkShowAll.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkClear_Click);
			//
			// runCaption
			//
			this.runCaption.AutoSize = true;
			this.runCaption.Dock = Wisej.Web.DockStyle.Left;
			this.runCaption.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.runCaption.Location = new System.Drawing.Point(12, 4);
			this.runCaption.Name = "runCaption";
			this.runCaption.Size = new System.Drawing.Size(4, 24);
			this.runCaption.TabIndex = 0;
			this.runCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// panelBody
			//
			this.panelBody.Controls.Add(this.panelList);
			this.panelBody.Controls.Add(this.panelBoard);
			this.panelBody.Dock = Wisej.Web.DockStyle.Fill;
			this.panelBody.Location = new System.Drawing.Point(0, 138);
			this.panelBody.Name = "panelBody";
			this.panelBody.Padding = new Wisej.Web.Padding(8, 8, 8, 0);
			this.panelBody.Size = new System.Drawing.Size(1066, 566);
			this.panelBody.TabIndex = 3;
			//
			// panelList
			//
			this.panelList.Controls.Add(this.emptyList);
			this.panelList.Controls.Add(this.dataGrid);
			this.panelList.Dock = Wisej.Web.DockStyle.Fill;
			this.panelList.Location = new System.Drawing.Point(8, 8);
			this.panelList.Name = "panelList";
			this.panelList.Size = new System.Drawing.Size(1050, 558);
			this.panelList.TabIndex = 1;
			this.panelList.Visible = false;
			//
			// emptyList
			//
			this.emptyList.ActionText = "Clear the filters";
			this.emptyList.Description = "Clear the filters to see all deals.";
			this.emptyList.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyList.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/briefcase.svg";
			this.emptyList.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyList.Location = new System.Drawing.Point(0, 0);
			this.emptyList.Name = "emptyList";
			this.emptyList.Size = new System.Drawing.Size(1050, 558);
			this.emptyList.TabIndex = 1;
			this.emptyList.Title = "No deals match";
			this.emptyList.Visible = false;
			this.emptyList.ActionClick += new System.EventHandler(this.emptyList_ActionClick);
			//
			// dataGrid
			//
			this.dataGrid.AllowUserToResizeRows = false;
			this.dataGrid.AutoGenerateColumns = false;
			this.dataGrid.BorderStyle = Wisej.Web.BorderStyle.None;
			this.dataGrid.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colTitle,
			this.colCompany,
			this.colContact,
			this.colStage,
			this.colAmount,
			this.colClose,
			this.colProbability,
			this.colOwner});
			this.dataGrid.ContextMenu = this.listMenu;
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
			this.dataGrid.Size = new System.Drawing.Size(1050, 558);
			this.dataGrid.TabIndex = 0;
			this.dataGrid.ToolTipText = "Double-click to open the deal; right-click for more";
			this.dataGrid.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGrid_CellDoubleClick);
			this.dataGrid.CellToolTipTextNeeded += new Wisej.Web.DataGridViewCellToolTipTextNeededEventHandler(this.dataGrid_CellToolTipTextNeeded);
			//
			// colTitle
			//
			this.colTitle.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTitle.DataPropertyName = "Title";
			this.colTitle.FillWeight = 200F;
			this.colTitle.HeaderText = "Deal";
			this.colTitle.MinimumWidth = 160;
			this.colTitle.Name = "colTitle";
			this.colTitle.Tag = "Bold";
			//
			// colCompany
			//
			this.colCompany.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colCompany.DataPropertyName = "CompanyName";
			this.colCompany.FillWeight = 150F;
			this.colCompany.HeaderText = "Company";
			this.colCompany.Name = "colCompany";
			//
			// colContact
			//
			this.colContact.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colContact.DataPropertyName = "ContactName";
			this.colContact.FillWeight = 120F;
			this.colContact.HeaderText = "Contact";
			this.colContact.Name = "colContact";
			//
			// colStage
			//
			this.colStage.DataPropertyName = "StageName";
			this.colStage.HeaderText = "Stage";
			this.colStage.Name = "colStage";
			this.colStage.Width = 130;
			//
			// colAmount
			//
			dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colAmount.DataPropertyName = "Amount";
			this.colAmount.DefaultCellStyle = dataGridViewCellStyle1;
			this.colAmount.HeaderText = "Amount";
			this.colAmount.Name = "colAmount";
			this.colAmount.Tag = "Fmt:Money";
			this.colAmount.Width = 100;
			//
			// colClose
			//
			this.colClose.DataPropertyName = "CloseTag";
			this.colClose.HeaderText = "Expected close";
			this.colClose.Name = "colClose";
			this.colClose.ToneMember = "CloseTone";
			this.colClose.Variant = Wisej.Web.ChipVariant.Soft;
			this.colClose.Width = 150;
			//
			// colProbability
			//
			this.colProbability.DataPropertyName = "Probability";
			this.colProbability.HeaderText = "Probability";
			this.colProbability.Maximum = 100D;
			this.colProbability.Name = "colProbability";
			this.colProbability.ShowText = true;
			this.colProbability.TextMember = "ProbabilityText";
			this.colProbability.Width = 110;
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
			// listMenu
			//
			this.listMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuOpen,
			this.menuEdit,
			this.menuMoveTo});
			this.listMenu.Name = "listMenu";
			this.listMenu.Popup += new System.EventHandler(this.listMenu_Opened);
			//
			// menuOpen
			//
			this.menuOpen.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
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
			// menuMoveTo
			//
			this.menuMoveTo.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/arrow-right-square.svg";
			this.menuMoveTo.Index = 2;
			this.menuMoveTo.Name = "menuMoveTo";
			this.menuMoveTo.Text = "Move to";
			//
			// panelBoard
			//
			this.panelBoard.AutoScroll = true;
			this.panelBoard.Controls.Add(this.kanbanBoard);
			this.panelBoard.Dock = Wisej.Web.DockStyle.Fill;
			this.panelBoard.Location = new System.Drawing.Point(8, 8);
			this.panelBoard.Name = "panelBoard";
			this.panelBoard.ScrollBars = Wisej.Web.ScrollBars.Horizontal;
			this.panelBoard.Size = new System.Drawing.Size(1050, 558);
			this.panelBoard.TabIndex = 0;
			this.panelBoard.Resize += new System.EventHandler(this.panelBoard_Resize);
			//
			// kanbanBoard
			//
			this.kanbanBoard.AllowDrag = true;
			this.kanbanBoard.AllowReorder = true;
			this.kanbanBoard.AutoSizeColumns = true;
			this.kanbanBoard.AvatarMember = "OwnerName";
			this.kanbanBoard.ColumnWidth = 220;
			this.kanbanBoard.ContextMenu = this.menuCard;
			this.kanbanBoard.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left)));
			this.kanbanBoard.Location = new System.Drawing.Point(0, 0);
			this.kanbanBoard.MetaMember = "Meta";
			this.kanbanBoard.Name = "kanbanBoard";
			this.kanbanBoard.OrderMember = "BoardOrder";
			this.kanbanBoard.Size = new System.Drawing.Size(1050, 558);
			this.kanbanBoard.StatusMember = "Status";
			this.kanbanBoard.TabIndex = 0;
			this.kanbanBoard.TagMember = "CloseTag";
			this.kanbanBoard.TagToneMember = "CloseTone";
			this.kanbanBoard.TitleMember = "Title";
			this.kanbanBoard.ToolTipText = "Drag a card to another stage, double-click to open, right-click for more";
			this.kanbanBoard.CardMoving += new System.EventHandler<Wisej.Web.KanbanCardMoveEventArgs>(this.kanbanBoard_CardMoving);
			this.kanbanBoard.CardMoved += new System.EventHandler<Wisej.Web.KanbanCardMoveEventArgs>(this.kanbanBoard_CardMoved);
			this.kanbanBoard.CardClick += new System.EventHandler<Wisej.Web.KanbanCardEventArgs>(this.kanbanBoard_CardClick);
			this.kanbanBoard.CardDoubleClick += new System.EventHandler<Wisej.Web.KanbanCardEventArgs>(this.kanbanBoard_CardDoubleClick);
			//
			// menuCard
			//
			this.menuCard.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuCardOpen,
			this.menuCardEdit,
			this.menuCardSeparator,
			this.menuCardMoveTo});
			this.menuCard.Name = "menuCard";
			this.menuCard.Popup += new System.EventHandler(this.menuCard_Popup);
			//
			// menuCardOpen
			//
			this.menuCardOpen.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.menuCardOpen.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/box-arrow-up-right.svg";
			this.menuCardOpen.Index = 0;
			this.menuCardOpen.Name = "menuCardOpen";
			this.menuCardOpen.Text = "Open";
			this.menuCardOpen.Click += new System.EventHandler(this.menuCardOpen_Click);
			//
			// menuCardEdit
			//
			this.menuCardEdit.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/pencil.svg";
			this.menuCardEdit.Index = 1;
			this.menuCardEdit.Name = "menuCardEdit";
			this.menuCardEdit.Text = "Edit...";
			this.menuCardEdit.Click += new System.EventHandler(this.menuCardEdit_Click);
			//
			// menuCardSeparator
			//
			this.menuCardSeparator.Index = 2;
			this.menuCardSeparator.Name = "menuCardSeparator";
			this.menuCardSeparator.Text = "-";
			//
			// menuCardMoveTo
			//
			this.menuCardMoveTo.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/arrow-right-square.svg";
			this.menuCardMoveTo.Index = 3;
			this.menuCardMoveTo.Name = "menuCardMoveTo";
			this.menuCardMoveTo.Text = "Move to";
			//
			// DealsView
			//
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panelBody);
			this.Controls.Add(this.panelCaption);
			this.Controls.Add(this.flowFilters);
			this.Controls.Add(this.panelHeader);
			this.CssClass = "relay-card";
			this.Name = "DealsView";
			this.Size = new System.Drawing.Size(1066, 704);
			this.panelHeader.ResumeLayout(false);
			this.flowFilters.ResumeLayout(false);
			this.flowFilters.PerformLayout();
			this.panelCaption.ResumeLayout(false);
			this.panelCaption.PerformLayout();
			this.panelBody.ResumeLayout(false);
			this.panelList.ResumeLayout(false);
			this.panelBoard.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelSummary;
		private Wisej.Web.Button buttonNew;
		private Wisej.Web.SegmentedButton segmentedMode;
		private Wisej.Web.FlowLayoutPanel flowFilters;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.ComboBox comboBoxOwner;
		private Wisej.Web.Label labelFrom;
		private Wisej.Web.DateTimePicker datePickerFrom;
		private Wisej.Web.Label labelTo;
		private Wisej.Web.DateTimePicker datePickerTo;
		private Wisej.Web.Label labelAmountFrom;
		private Wisej.Web.TextBox textBoxMin;
		private Wisej.Web.Label labelAmountTo;
		private Wisej.Web.TextBox textBoxMax;
		private Wisej.Web.LinkLabel linkClear;
		private Wisej.Web.Panel panelCaption;
		private Wisej.Web.Label runCaption;
		private Wisej.Web.LinkLabel linkShowAll;
		private Wisej.Web.Panel panelBody;
		private Wisej.Web.Panel panelBoard;
		private Wisej.Web.KanbanBoard kanbanBoard;
		private Wisej.Web.Panel panelList;
		private Wisej.Web.DataGridView dataGrid;
		private Wisej.Web.DataGridViewTextBoxColumn colTitle;
		private Wisej.Web.DataGridViewTextBoxColumn colCompany;
		private Wisej.Web.DataGridViewTextBoxColumn colContact;
		private Wisej.Web.DataGridViewChipColumn colStage;
		private Wisej.Web.DataGridViewTextBoxColumn colAmount;
		private Wisej.Web.DataGridViewChipColumn colClose;
		private Wisej.Web.DataGridViewMeterColumn colProbability;
		private Wisej.Web.DataGridViewAvatarColumn colOwner;
		private Wisej.Web.EmptyState emptyList;
		private Wisej.Web.ContextMenu listMenu;
		private Wisej.Web.MenuItem menuOpen;
		private Wisej.Web.MenuItem menuEdit;
		private Wisej.Web.MenuItem menuMoveTo;
		private Wisej.Web.ContextMenu menuCard;
		private Wisej.Web.MenuItem menuCardOpen;
		private Wisej.Web.MenuItem menuCardEdit;
		private Wisej.Web.MenuItem menuCardSeparator;
		private Wisej.Web.MenuItem menuCardMoveTo;
	}
}
