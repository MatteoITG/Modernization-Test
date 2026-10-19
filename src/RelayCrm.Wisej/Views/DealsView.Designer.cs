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
			this.panelList = new Wisej.Web.Panel();
			this.emptyState = new Wisej.Web.EmptyState();
			this.dataGridView = new Wisej.Web.DataGridView();
			this.colTitle = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCompany = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colAmount = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStage = new Wisej.Web.DataGridViewChipColumn();
			this.colProbability = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOwner = new Wisej.Web.DataGridViewAvatarColumn();
			this.colClose = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCloseTag = new Wisej.Web.DataGridViewChipColumn();
			this.kanbanBoard = new Wisej.Web.KanbanBoard();
			this.panelCaption = new Wisej.Web.Panel();
			this.linkCaptionClear = new Wisej.Web.LinkLabel();
			this.labelCaption = new Wisej.Web.Label();
			this.panelFilters = new Wisej.Web.Panel();
			this.labelOwner = new Wisej.Web.Label();
			this.comboBoxOwner = new Wisej.Web.ComboBox();
			this.labelFrom = new Wisej.Web.Label();
			this.dateTimePickerFrom = new Wisej.Web.DateTimePicker();
			this.labelTo = new Wisej.Web.Label();
			this.dateTimePickerTo = new Wisej.Web.DateTimePicker();
			this.labelMin = new Wisej.Web.Label();
			this.textBoxMin = new Wisej.Web.TextBox();
			this.labelMax = new Wisej.Web.Label();
			this.textBoxMax = new Wisej.Web.TextBox();
			this.linkClear = new Wisej.Web.LinkLabel();
			this.toolStrip = new Wisej.Web.ToolBar();
			this.buttonNew = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator1 = new Wisej.Web.ToolBarButton();
			this.buttonBoard = new Wisej.Web.ToolBarButton();
			this.buttonList = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator2 = new Wisej.Web.ToolBarButton();
			this.buttonRefresh = new Wisej.Web.ToolBarButton();
			this.labelSummary = new Wisej.Web.ToolBarButton();
			this.contextMenu = new Wisej.Web.ContextMenu(this.components);
			this.menuOpen = new Wisej.Web.MenuItem();
			this.menuEdit = new Wisej.Web.MenuItem();
			this.menuMoveTo = new Wisej.Web.MenuItem();
			this.menuSeparator1 = new Wisej.Web.MenuItem();
			this.menuDelete = new Wisej.Web.MenuItem();
			this.panelList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.panelCaption.SuspendLayout();
			this.panelFilters.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			//
			// panelList
			//
			this.panelList.Controls.Add(this.emptyState);
			this.panelList.Controls.Add(this.dataGridView);
			this.panelList.Dock = Wisej.Web.DockStyle.Fill;
			this.panelList.Location = new System.Drawing.Point(0, 98);
			this.panelList.Name = "panelList";
			this.panelList.Size = new System.Drawing.Size(1000, 502);
			this.panelList.TabIndex = 4;
			this.panelList.Visible = false;
			//
			// emptyState
			//
			this.emptyState.ActionText = "Clear filters";
			this.emptyState.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyState.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/briefcase.svg";
			this.emptyState.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyState.Location = new System.Drawing.Point(0, 0);
			this.emptyState.Name = "emptyState";
			this.emptyState.Size = new System.Drawing.Size(1000, 502);
			this.emptyState.TabIndex = 1;
			this.emptyState.Title = "No deals match the filters.";
			this.emptyState.Visible = false;
			this.emptyState.ActionClick += new System.EventHandler(this.emptyState_ActionClick);
			//
			// dataGridView
			//
			this.dataGridView.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colTitle,
			this.colCompany,
			this.colAmount,
			this.colStage,
			this.colProbability,
			this.colOwner,
			this.colClose,
			this.colCloseTag});
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = Wisej.Web.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(400, 200);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.ContextMenu = this.contextMenu;
			this.dataGridView.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
			this.dataGridView.CellMouseDown += new Wisej.Web.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
			this.dataGridView.KeyDown += new Wisej.Web.KeyEventHandler(this.dataGridView_KeyDown);
			this.dataGridView.BorderStyle = Wisej.Web.BorderStyle.None;
			this.dataGridView.CssClass = "relay-grid";
			this.dataGridView.RowTemplate.Height = 44;
			//
			// colTitle
			//
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.colTitle.DataPropertyName = "Title";
			this.colTitle.DefaultCellStyle = dataGridViewCellStyle1;
			this.colTitle.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTitle.MinimumWidth = 200;
			this.colTitle.HeaderText = "Deal";
			this.colTitle.Name = "colTitle";
			//
			// colCompany
			//
			this.colCompany.DataPropertyName = "CompanyName";
			this.colCompany.HeaderText = "Company";
			this.colCompany.Name = "colCompany";
			this.colCompany.Width = 170;
			//
			// colAmount
			//
			dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Format = "C0";
			this.colAmount.DataPropertyName = "Amount";
			this.colAmount.DefaultCellStyle = dataGridViewCellStyle2;
			this.colAmount.HeaderText = "Amount";
			this.colAmount.Name = "colAmount";
			this.colAmount.Width = 100;
			//
			// colStage
			//
			this.colStage.DataPropertyName = "StageName";
			this.colStage.HeaderText = "Stage";
			this.colStage.Name = "colStage";
			this.colStage.Width = 120;
			//
			// colProbability
			//
			dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colProbability.DataPropertyName = "ProbabilityText";
			this.colProbability.DefaultCellStyle = dataGridViewCellStyle3;
			this.colProbability.HeaderText = "Probability";
			this.colProbability.Name = "colProbability";
			this.colProbability.Width = 80;
			//
			// colOwner
			//
			this.colOwner.DataPropertyName = "OwnerName";
			this.colOwner.HeaderText = "Owner";
			this.colOwner.Name = "colOwner";
			this.colOwner.Width = 150;
			this.colOwner.TextMember = "OwnerName";
			//
			// colClose
			//
			dataGridViewCellStyle4.Format = "MMM d, yyyy";
			this.colClose.DataPropertyName = "ExpectedCloseDate";
			this.colClose.DefaultCellStyle = dataGridViewCellStyle4;
			this.colClose.HeaderText = "Expected close";
			this.colClose.Name = "colClose";
			this.colClose.Width = 110;
			//
			// colCloseTag
			//
			this.colCloseTag.DataPropertyName = "CloseTag";
			this.colCloseTag.HeaderText = "Status";
			this.colCloseTag.Name = "colCloseTag";
			this.colCloseTag.Width = 150;
			this.colCloseTag.ToneMember = "CloseTone";
			//
			// kanbanBoard
			//
			this.kanbanBoard.AllowDrag = true;
			this.kanbanBoard.AllowReorder = true;
			this.kanbanBoard.AutoSizeColumns = true;
			this.kanbanBoard.AvatarMember = "OwnerName";
			this.kanbanBoard.ColumnWidth = 220;
			this.kanbanBoard.ContextMenu = this.contextMenu;
			this.kanbanBoard.Dock = Wisej.Web.DockStyle.Fill;
			this.kanbanBoard.Location = new System.Drawing.Point(0, 98);
			this.kanbanBoard.MetaMember = "Meta";
			this.kanbanBoard.Name = "kanbanBoard";
			this.kanbanBoard.OrderMember = "BoardOrder";
			this.kanbanBoard.Size = new System.Drawing.Size(1000, 502);
			this.kanbanBoard.StatusMember = "Status";
			this.kanbanBoard.TabIndex = 3;
			this.kanbanBoard.TagMember = "CloseTag";
			this.kanbanBoard.TagToneMember = "CloseTone";
			this.kanbanBoard.TitleMember = "Title";
			this.kanbanBoard.CardMoving += new System.EventHandler<Wisej.Web.KanbanCardMoveEventArgs>(this.kanbanBoard_CardMoving);
			this.kanbanBoard.CardMoved += new System.EventHandler<Wisej.Web.KanbanCardMoveEventArgs>(this.kanbanBoard_CardMoved);
			this.kanbanBoard.CardClick += new System.EventHandler<Wisej.Web.KanbanCardEventArgs>(this.kanbanBoard_CardClick);
			this.kanbanBoard.CardDoubleClick += new System.EventHandler<Wisej.Web.KanbanCardEventArgs>(this.kanbanBoard_CardDoubleClick);
			this.kanbanBoard.Resize += new System.EventHandler(this.kanbanBoard_Resize);
			//
			// panelCaption
			//
			this.panelCaption.Controls.Add(this.linkCaptionClear);
			this.panelCaption.Controls.Add(this.labelCaption);
			this.panelCaption.BackColor = System.Drawing.SystemColors.Info;
			this.panelCaption.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.panelCaption.Dock = Wisej.Web.DockStyle.Top;
			this.panelCaption.Location = new System.Drawing.Point(0, 70);
			this.panelCaption.Name = "panelCaption";
			this.panelCaption.Size = new System.Drawing.Size(1000, 28);
			this.panelCaption.TabIndex = 2;
			this.panelCaption.Visible = false;
			//
			// linkCaptionClear
			//
			this.linkCaptionClear.Anchor = ((Wisej.Web.AnchorStyles)(Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right));
			this.linkCaptionClear.AutoSize = true;
			this.linkCaptionClear.Location = new System.Drawing.Point(890, 6);
			this.linkCaptionClear.Name = "linkCaptionClear";
			this.linkCaptionClear.Size = new System.Drawing.Size(100, 15);
			this.linkCaptionClear.TabIndex = 1;
			this.linkCaptionClear.TabStop = true;
			this.linkCaptionClear.Text = "Show all deals";
			this.linkCaptionClear.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
			//
			// labelCaption
			//
			this.labelCaption.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.labelCaption.AutoEllipsis = true;
			this.labelCaption.ForeColor = System.Drawing.SystemColors.InfoText;
			this.labelCaption.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.labelCaption.Location = new System.Drawing.Point(8, 6);
			this.labelCaption.Name = "labelCaption";
			this.labelCaption.Size = new System.Drawing.Size(860, 16);
			this.labelCaption.TabIndex = 0;
			this.labelCaption.Text = "Caption";
			//
			// panelFilters
			//
			this.panelFilters.Controls.Add(this.labelOwner);
			this.panelFilters.Controls.Add(this.comboBoxOwner);
			this.panelFilters.Controls.Add(this.labelFrom);
			this.panelFilters.Controls.Add(this.dateTimePickerFrom);
			this.panelFilters.Controls.Add(this.labelTo);
			this.panelFilters.Controls.Add(this.dateTimePickerTo);
			this.panelFilters.Controls.Add(this.labelMin);
			this.panelFilters.Controls.Add(this.textBoxMin);
			this.panelFilters.Controls.Add(this.labelMax);
			this.panelFilters.Controls.Add(this.textBoxMax);
			this.panelFilters.Controls.Add(this.linkClear);
			this.panelFilters.Dock = Wisej.Web.DockStyle.Top;
			this.panelFilters.Location = new System.Drawing.Point(0, 27);
			this.panelFilters.Name = "panelFilters";
			this.panelFilters.Size = new System.Drawing.Size(1000, 36);
			this.panelFilters.TabIndex = 1;
			//
			// labelOwner
			//
			this.labelOwner.AutoSize = true;
			this.labelOwner.Location = new System.Drawing.Point(8, 10);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Size = new System.Drawing.Size(44, 15);
			this.labelOwner.Text = "&Owner:";
			//
			// comboBoxOwner
			//
			this.comboBoxOwner.Location = new System.Drawing.Point(56, 6);
			this.comboBoxOwner.Name = "comboBoxOwner";
			this.comboBoxOwner.Size = new System.Drawing.Size(150, 23);
			this.comboBoxOwner.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOwner.FormattingEnabled = true;
			this.comboBoxOwner.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
			//
			// labelFrom
			//
			this.labelFrom.AutoSize = true;
			this.labelFrom.Location = new System.Drawing.Point(220, 10);
			this.labelFrom.Name = "labelFrom";
			this.labelFrom.Size = new System.Drawing.Size(66, 15);
			this.labelFrom.Text = "Close &from:";
			//
			// dateTimePickerFrom
			//
			this.dateTimePickerFrom.Location = new System.Drawing.Point(290, 6);
			this.dateTimePickerFrom.Name = "dateTimePickerFrom";
			this.dateTimePickerFrom.Size = new System.Drawing.Size(130, 23);
			this.dateTimePickerFrom.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.dateTimePickerFrom.ShowCheckBox = true;
			this.dateTimePickerFrom.Checked = false;
			this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.filter_Changed);
			//
			// labelTo
			//
			this.labelTo.AutoSize = true;
			this.labelTo.Location = new System.Drawing.Point(434, 10);
			this.labelTo.Name = "labelTo";
			this.labelTo.Size = new System.Drawing.Size(20, 15);
			this.labelTo.Text = "&to:";
			//
			// dateTimePickerTo
			//
			this.dateTimePickerTo.Location = new System.Drawing.Point(458, 6);
			this.dateTimePickerTo.Name = "dateTimePickerTo";
			this.dateTimePickerTo.Size = new System.Drawing.Size(130, 23);
			this.dateTimePickerTo.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.dateTimePickerTo.ShowCheckBox = true;
			this.dateTimePickerTo.Checked = false;
			this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.filter_Changed);
			//
			// labelMin
			//
			this.labelMin.AutoSize = true;
			this.labelMin.Location = new System.Drawing.Point(602, 10);
			this.labelMin.Name = "labelMin";
			this.labelMin.Size = new System.Drawing.Size(74, 15);
			this.labelMin.Text = "Amount &min:";
			//
			// textBoxMin
			//
			this.textBoxMin.Location = new System.Drawing.Point(680, 6);
			this.textBoxMin.Name = "textBoxMin";
			this.textBoxMin.Size = new System.Drawing.Size(80, 23);
			this.textBoxMin.TextAlign = Wisej.Web.HorizontalAlignment.Right;
			this.textBoxMin.Leave += new System.EventHandler(this.amount_Leave);
			this.textBoxMin.KeyDown += new Wisej.Web.KeyEventHandler(this.amount_KeyDown);
			//
			// labelMax
			//
			this.labelMax.AutoSize = true;
			this.labelMax.Location = new System.Drawing.Point(774, 10);
			this.labelMax.Name = "labelMax";
			this.labelMax.Size = new System.Drawing.Size(30, 15);
			this.labelMax.Text = "m&ax:";
			//
			// textBoxMax
			//
			this.textBoxMax.Location = new System.Drawing.Point(808, 6);
			this.textBoxMax.Name = "textBoxMax";
			this.textBoxMax.Size = new System.Drawing.Size(80, 23);
			this.textBoxMax.TextAlign = Wisej.Web.HorizontalAlignment.Right;
			this.textBoxMax.Leave += new System.EventHandler(this.amount_Leave);
			this.textBoxMax.KeyDown += new Wisej.Web.KeyEventHandler(this.amount_KeyDown);
			//
			// linkClear
			//
			this.linkClear.AutoSize = true;
			this.linkClear.Location = new System.Drawing.Point(902, 10);
			this.linkClear.Name = "linkClear";
			this.linkClear.Size = new System.Drawing.Size(70, 15);
			this.linkClear.TabStop = true;
			this.linkClear.Text = "Clear filters";
			this.linkClear.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
			//
			// toolStrip
			//
			this.toolStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonNew,
			this.toolStripSeparator1,
			this.buttonBoard,
			this.buttonList,
			this.toolStripSeparator2,
			this.buttonRefresh,
			this.labelSummary});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new Wisej.Web.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(800, 27);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.toolStrip.CssClass = "relay-toolbar";
			//
			// buttonNew
			//
			this.buttonNew.Tag = "plus";
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Text = "New deal...";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// buttonBoard
			//
			this.buttonBoard.Pushed = true;
			this.buttonBoard.Tag = "layout-three-columns";
			this.buttonBoard.Name = "buttonBoard";
			this.buttonBoard.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.buttonBoard.Text = "Board";
			this.buttonBoard.Click += new System.EventHandler(this.buttonMode_Click);
			//
			// buttonList
			//
			this.buttonList.Tag = "briefcase";
			this.buttonList.Name = "buttonList";
			this.buttonList.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.buttonList.Text = "List";
			this.buttonList.Click += new System.EventHandler(this.buttonMode_Click);
			//
			// toolStripSeparator2
			//
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// buttonRefresh
			//
			this.buttonRefresh.Tag = "arrow-clockwise";
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			//
			// labelSummary
			//
			this.labelSummary.Name = "labelSummary";
			this.labelSummary.Text = "0 deals";
			//
			// contextMenu
			//
			this.contextMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuOpen,
			this.menuEdit,
			this.menuMoveTo,
			this.menuSeparator1,
			this.menuDelete});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Popup += new System.EventHandler(this.contextMenu_Opening);
			//
			// menuOpen
			//
			this.menuOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Text = "&Open...";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			//
			// menuEdit
			//
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Text = "&Edit...";
			this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
			//
			// menuMoveTo
			//
			this.menuMoveTo.Name = "menuMoveTo";
			this.menuMoveTo.Text = "&Move to stage";
			//
			// menuSeparator1
			//
			this.menuSeparator1.Name = "menuSeparator1";
			this.menuSeparator1.Text = "-";
			//
			// menuDelete
			//
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Text = "&Delete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// DealsView
			//
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panelList);
			this.Controls.Add(this.kanbanBoard);
			this.Controls.Add(this.panelCaption);
			this.Controls.Add(this.panelFilters);
			this.Controls.Add(this.toolStrip);
			this.CssClass = "relay-card";
			this.Name = "DealsView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.panelFilters.ResumeLayout(false);
			this.panelFilters.PerformLayout();
			this.panelCaption.ResumeLayout(false);
			this.panelCaption.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.panelList.ResumeLayout(false);
			this.panelList.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Panel panelList;
		private Wisej.Web.EmptyState emptyState;
		private Wisej.Web.DataGridView dataGridView;
		private Wisej.Web.DataGridViewTextBoxColumn colTitle;
		private Wisej.Web.DataGridViewTextBoxColumn colCompany;
		private Wisej.Web.DataGridViewTextBoxColumn colAmount;
		private Wisej.Web.DataGridViewChipColumn colStage;
		private Wisej.Web.DataGridViewTextBoxColumn colProbability;
		private Wisej.Web.DataGridViewAvatarColumn colOwner;
		private Wisej.Web.DataGridViewTextBoxColumn colClose;
		private Wisej.Web.DataGridViewChipColumn colCloseTag;
		private Wisej.Web.Panel panelCaption;
		private Wisej.Web.LinkLabel linkCaptionClear;
		private Wisej.Web.Label labelCaption;
		private Wisej.Web.Panel panelFilters;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.ComboBox comboBoxOwner;
		private Wisej.Web.Label labelFrom;
		private Wisej.Web.DateTimePicker dateTimePickerFrom;
		private Wisej.Web.Label labelTo;
		private Wisej.Web.DateTimePicker dateTimePickerTo;
		private Wisej.Web.Label labelMin;
		private Wisej.Web.TextBox textBoxMin;
		private Wisej.Web.Label labelMax;
		private Wisej.Web.TextBox textBoxMax;
		private Wisej.Web.LinkLabel linkClear;
		private Wisej.Web.ToolBar toolStrip;
		private Wisej.Web.ToolBarButton buttonNew;
		private Wisej.Web.ToolBarButton toolStripSeparator1;
		private Wisej.Web.ToolBarButton buttonBoard;
		private Wisej.Web.ToolBarButton buttonList;
		private Wisej.Web.ToolBarButton toolStripSeparator2;
		private Wisej.Web.ToolBarButton buttonRefresh;
		private Wisej.Web.ToolBarButton labelSummary;
		private Wisej.Web.ContextMenu contextMenu;
		private Wisej.Web.MenuItem menuOpen;
		private Wisej.Web.MenuItem menuEdit;
		private Wisej.Web.MenuItem menuMoveTo;
		private Wisej.Web.MenuItem menuSeparator1;
		private Wisej.Web.MenuItem menuDelete;
		private Wisej.Web.KanbanBoard kanbanBoard;
	}
}
