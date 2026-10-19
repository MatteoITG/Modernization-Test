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
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
			Wisej.Web.ComponentTool componentTool2 = new Wisej.Web.ComponentTool();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelSummary = new Wisej.Web.Label();
			this.segmentedView = new Wisej.Web.SegmentedButton();
			this.buttonNew = new Wisej.Web.Button();
			this.panelFilterHost = new Wisej.Web.Panel();
			this.panelFilters = new Wisej.Web.Panel();
			this.comboBoxOwner = new Wisej.Web.ComboBox();
			this.dateTimePickerFrom = new Wisej.Web.DateTimePicker();
			this.dateTimePickerTo = new Wisej.Web.DateTimePicker();
			this.numericMin = new Wisej.Web.NumericUpDown();
			this.numericMax = new Wisej.Web.NumericUpDown();
			this.linkClear = new Wisej.Web.LinkLabel();
			this.panelCaption = new Wisej.Web.Panel();
			this.labelCaption = new Wisej.Web.Label();
			this.panelBody = new Wisej.Web.Panel();
			this.kanbanBoard = new Wisej.Web.KanbanBoard();
			this.panelList = new Wisej.Web.Panel();
			this.dataGridView = new Wisej.Web.DataGridView();
			this.colTitle = new Wisej.Web.DataGridViewSubtitleColumn();
			this.colAmount = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStage = new Wisej.Web.DataGridViewChipColumn();
			this.colProbability = new Wisej.Web.DataGridViewMeterColumn();
			this.colOwner = new Wisej.Web.DataGridViewAvatarColumn();
			this.colClose = new Wisej.Web.DataGridViewTextBoxColumn();
			this.emptyStateList = new Wisej.Web.EmptyState();
			this.panelHeader.SuspendLayout();
			this.panelFilterHost.SuspendLayout();
			this.panelFilters.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMin)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMax)).BeginInit();
			this.panelCaption.SuspendLayout();
			this.panelBody.SuspendLayout();
			this.panelList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.buttonNew);
			this.panelHeader.Controls.Add(this.segmentedView);
			this.panelHeader.Controls.Add(this.labelSummary);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1100, 48);
			this.panelHeader.TabIndex = 0;
			//
			// labelSummary
			//
			this.labelSummary.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.labelSummary.CssClass = "relay-muted";
			this.labelSummary.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelSummary.Location = new System.Drawing.Point(0, 0);
			this.labelSummary.Name = "labelSummary";
			this.labelSummary.Size = new System.Drawing.Size(776, 48);
			this.labelSummary.TabIndex = 1;
			this.labelSummary.Text = "0 deals";
			this.labelSummary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// segmentedView
			//
			this.segmentedView.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			segment1.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/columns-gap.svg";
			segment1.Text = "Board";
			segment2.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/list-ul.svg";
			segment2.Text = "List";
			this.segmentedView.Items.Add(segment1);
			this.segmentedView.Items.Add(segment2);
			this.segmentedView.Location = new System.Drawing.Point(792, 6);
			this.segmentedView.Name = "segmentedView";
			this.segmentedView.SegmentSize = Wisej.Web.SegmentSize.Small;
			this.segmentedView.SelectedIndex = 0;
			this.segmentedView.Size = new System.Drawing.Size(172, 36);
			this.segmentedView.TabIndex = 2;
			this.segmentedView.SelectedIndexChanged += new System.EventHandler(this.segmentedView_SelectedIndexChanged);
			//
			// buttonNew
			//
			this.buttonNew.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonNew.CssClass = "relay-primary";
			this.buttonNew.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus-lg.svg";
			this.buttonNew.Location = new System.Drawing.Point(980, 6);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(120, 36);
			this.buttonNew.TabIndex = 3;
			this.buttonNew.Text = "New deal";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// panelFilterHost
			//
			this.panelFilterHost.Controls.Add(this.panelFilters);
			this.panelFilterHost.Dock = Wisej.Web.DockStyle.Top;
			this.panelFilterHost.Location = new System.Drawing.Point(0, 48);
			this.panelFilterHost.Name = "panelFilterHost";
			this.panelFilterHost.Padding = new Wisej.Web.Padding(0, 0, 0, 16);
			this.panelFilterHost.Size = new System.Drawing.Size(1100, 112);
			this.panelFilterHost.TabIndex = 1;
			//
			// panelFilters
			//
			this.panelFilters.Controls.Add(this.linkClear);
			this.panelFilters.Controls.Add(this.numericMax);
			this.panelFilters.Controls.Add(this.numericMin);
			this.panelFilters.Controls.Add(this.dateTimePickerTo);
			this.panelFilters.Controls.Add(this.dateTimePickerFrom);
			this.panelFilters.Controls.Add(this.comboBoxOwner);
			this.panelFilters.CssClass = "relay-card";
			this.panelFilters.Dock = Wisej.Web.DockStyle.Fill;
			this.panelFilters.Location = new System.Drawing.Point(0, 0);
			this.panelFilters.Name = "panelFilters";
			this.panelFilters.Padding = new Wisej.Web.Padding(20);
			this.panelFilters.Size = new System.Drawing.Size(1100, 96);
			this.panelFilters.TabIndex = 0;
			//
			// comboBoxOwner
			//
			this.comboBoxOwner.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOwner.LabelText = "Owner";
			this.comboBoxOwner.Location = new System.Drawing.Point(20, 20);
			this.comboBoxOwner.Name = "comboBoxOwner";
			this.comboBoxOwner.Size = new System.Drawing.Size(200, 56);
			this.comboBoxOwner.TabIndex = 0;
			this.comboBoxOwner.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
			//
			// dateTimePickerFrom
			//
			componentTool1.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/x-lg.svg";
			componentTool1.Name = "clear";
			componentTool1.ToolTipText = "Clear";
			this.dateTimePickerFrom.CustomFormat = "MMM d, yyyy";
			this.dateTimePickerFrom.Format = Wisej.Web.DateTimePickerFormat.Custom;
			this.dateTimePickerFrom.LabelText = "Close date from";
			this.dateTimePickerFrom.Location = new System.Drawing.Point(236, 20);
			this.dateTimePickerFrom.Name = "dateTimePickerFrom";
			this.dateTimePickerFrom.Size = new System.Drawing.Size(160, 56);
			this.dateTimePickerFrom.TabIndex = 1;
			this.dateTimePickerFrom.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool1});
			this.dateTimePickerFrom.Watermark = "Any";
			this.dateTimePickerFrom.ToolClick += new Wisej.Web.ToolClickEventHandler(this.dateTimePicker_ToolClick);
			this.dateTimePickerFrom.ValueChanged += new System.EventHandler(this.filter_Changed);
			//
			// dateTimePickerTo
			//
			componentTool2.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/x-lg.svg";
			componentTool2.Name = "clear";
			componentTool2.ToolTipText = "Clear";
			this.dateTimePickerTo.CustomFormat = "MMM d, yyyy";
			this.dateTimePickerTo.Format = Wisej.Web.DateTimePickerFormat.Custom;
			this.dateTimePickerTo.LabelText = "Close date to";
			this.dateTimePickerTo.Location = new System.Drawing.Point(404, 20);
			this.dateTimePickerTo.Name = "dateTimePickerTo";
			this.dateTimePickerTo.Size = new System.Drawing.Size(160, 56);
			this.dateTimePickerTo.TabIndex = 2;
			this.dateTimePickerTo.Tools.AddRange(new Wisej.Web.ComponentTool[] {
            componentTool2});
			this.dateTimePickerTo.Watermark = "Any";
			this.dateTimePickerTo.ToolClick += new Wisej.Web.ToolClickEventHandler(this.dateTimePicker_ToolClick);
			this.dateTimePickerTo.ValueChanged += new System.EventHandler(this.filter_Changed);
			//
			// numericMin
			//
			this.numericMin.AllowEmptyText = true;
			this.numericMin.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numericMin.LabelText = "Min amount";
			this.numericMin.Location = new System.Drawing.Point(580, 20);
			this.numericMin.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.numericMin.Name = "numericMin";
			this.numericMin.Size = new System.Drawing.Size(140, 56);
			this.numericMin.TabIndex = 3;
			this.numericMin.ThousandsSeparator = true;
			this.numericMin.ValueChanged += new System.EventHandler(this.filter_Changed);
			//
			// numericMax
			//
			this.numericMax.AllowEmptyText = true;
			this.numericMax.Increment = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.numericMax.LabelText = "Max amount";
			this.numericMax.Location = new System.Drawing.Point(728, 20);
			this.numericMax.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.numericMax.Name = "numericMax";
			this.numericMax.Size = new System.Drawing.Size(140, 56);
			this.numericMax.TabIndex = 4;
			this.numericMax.ThousandsSeparator = true;
			this.numericMax.ValueChanged += new System.EventHandler(this.filter_Changed);
			//
			// linkClear
			//
			this.linkClear.Location = new System.Drawing.Point(884, 40);
			this.linkClear.Name = "linkClear";
			this.linkClear.Size = new System.Drawing.Size(90, 36);
			this.linkClear.TabIndex = 5;
			this.linkClear.Text = "Clear filters";
			this.linkClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.linkClear.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
			//
			// panelCaption
			//
			this.panelCaption.Controls.Add(this.labelCaption);
			this.panelCaption.Dock = Wisej.Web.DockStyle.Top;
			this.panelCaption.Location = new System.Drawing.Point(0, 160);
			this.panelCaption.Name = "panelCaption";
			this.panelCaption.Padding = new Wisej.Web.Padding(0, 0, 0, 8);
			this.panelCaption.Size = new System.Drawing.Size(1100, 36);
			this.panelCaption.TabIndex = 2;
			this.panelCaption.Visible = false;
			//
			// labelCaption
			//
			this.labelCaption.CssClass = "relay-title";
			this.labelCaption.Dock = Wisej.Web.DockStyle.Fill;
			this.labelCaption.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelCaption.Location = new System.Drawing.Point(0, 0);
			this.labelCaption.Name = "labelCaption";
			this.labelCaption.Size = new System.Drawing.Size(1100, 28);
			this.labelCaption.TabIndex = 0;
			this.labelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// panelBody
			//
			this.panelBody.Controls.Add(this.panelList);
			this.panelBody.Controls.Add(this.kanbanBoard);
			this.panelBody.Dock = Wisej.Web.DockStyle.Fill;
			this.panelBody.Location = new System.Drawing.Point(0, 196);
			this.panelBody.Name = "panelBody";
			this.panelBody.Size = new System.Drawing.Size(1100, 564);
			this.panelBody.TabIndex = 3;
			//
			// kanbanBoard
			//
			this.kanbanBoard.AllowDrag = true;
			this.kanbanBoard.AllowReorder = true;
			this.kanbanBoard.AutoSizeColumns = true;
			this.kanbanBoard.AvatarMember = "OwnerName";
			this.kanbanBoard.ColumnWidth = 200;
			this.kanbanBoard.Dock = Wisej.Web.DockStyle.Fill;
			this.kanbanBoard.Location = new System.Drawing.Point(0, 0);
			this.kanbanBoard.MetaMember = "Meta";
			this.kanbanBoard.Name = "kanbanBoard";
			this.kanbanBoard.OrderMember = "BoardOrder";
			this.kanbanBoard.Size = new System.Drawing.Size(1100, 564);
			this.kanbanBoard.StatusMember = "Status";
			this.kanbanBoard.TabIndex = 0;
			this.kanbanBoard.TagMember = "CloseTag";
			this.kanbanBoard.TagToneMember = "CloseTone";
			this.kanbanBoard.TitleMember = "Title";
			this.kanbanBoard.CardMoving += new System.EventHandler<Wisej.Web.KanbanCardMoveEventArgs>(this.kanbanBoard_CardMoving);
			this.kanbanBoard.CardMoved += new System.EventHandler<Wisej.Web.KanbanCardMoveEventArgs>(this.kanbanBoard_CardMoved);
			this.kanbanBoard.CardDoubleClick += new System.EventHandler<Wisej.Web.KanbanCardEventArgs>(this.kanbanBoard_CardDoubleClick);
			this.kanbanBoard.Resize += new System.EventHandler(this.kanbanBoard_Resize);
			//
			// panelList
			//
			this.panelList.Controls.Add(this.emptyStateList);
			this.panelList.Controls.Add(this.dataGridView);
			this.panelList.CssClass = "relay-card";
			this.panelList.Dock = Wisej.Web.DockStyle.Fill;
			this.panelList.Location = new System.Drawing.Point(0, 0);
			this.panelList.Name = "panelList";
			this.panelList.Padding = new Wisej.Web.Padding(20);
			this.panelList.Size = new System.Drawing.Size(1100, 564);
			this.panelList.TabIndex = 1;
			this.panelList.Visible = false;
			//
			// dataGridView
			//
			this.dataGridView.BorderStyle = Wisej.Web.BorderStyle.None;
			this.dataGridView.CellBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.Horizontal;
			dataGridViewCellStyle5.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.dataGridView.ColumnHeadersHeight = 40;
			this.dataGridView.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colTitle,
            this.colAmount,
            this.colStage,
            this.colProbability,
            this.colOwner,
            this.colClose});
			this.dataGridView.CssClass = "relay-grid";
			dataGridViewCellStyle4.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.dataGridView.DefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView.Dock = Wisej.Web.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(20, 20);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.RowTemplate.Height = 52;
			this.dataGridView.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(1060, 524);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
			//
			// colTitle
			//
			this.colTitle.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTitle.DataPropertyName = "Title";
			this.colTitle.HeaderText = "Deal";
			this.colTitle.MinimumWidth = 200;
			this.colTitle.Monospace = false;
			this.colTitle.Name = "colTitle";
			this.colTitle.SubtitleFont = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.colTitle.SubtitleMember = "CompanyName";
			//
			// colAmount
			//
			dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colAmount.DataPropertyName = "AmountText";
			this.colAmount.DefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle2.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.colAmount.HeaderStyle = dataGridViewCellStyle2;
			this.colAmount.HeaderText = "Amount";
			this.colAmount.Name = "colAmount";
			this.colAmount.Width = 110;
			//
			// colStage
			//
			this.colStage.DataPropertyName = "StageName";
			this.colStage.HeaderText = "Stage";
			this.colStage.Name = "colStage";
			this.colStage.ShowDot = true;
			this.colStage.Width = 130;
			//
			// colProbability
			//
			this.colProbability.DataPropertyName = "Probability";
			dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.colProbability.HeaderStyle = dataGridViewCellStyle3;
			this.colProbability.HeaderText = "Probability";
			this.colProbability.Maximum = 100D;
			this.colProbability.Name = "colProbability";
			this.colProbability.ShowText = true;
			this.colProbability.TextMember = "ProbabilityText";
			this.colProbability.Width = 130;
			//
			// colOwner
			//
			this.colOwner.AutoColor = true;
			this.colOwner.DataPropertyName = "OwnerName";
			this.colOwner.HeaderText = "Owner";
			this.colOwner.Name = "colOwner";
			this.colOwner.Width = 170;
			//
			// colClose
			//
			this.colClose.DataPropertyName = "CloseText";
			this.colClose.HeaderText = "Expected close";
			this.colClose.Name = "colClose";
			this.colClose.Width = 130;
			//
			// emptyStateList
			//
			this.emptyStateList.ActionText = "Clear filters";
			this.emptyStateList.Description = "No deal matches these filters. Try other filters or clear them.";
			this.emptyStateList.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/funnel.svg";
			this.emptyStateList.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyStateList.Location = new System.Drawing.Point(400, 200);
			this.emptyStateList.Name = "emptyStateList";
			this.emptyStateList.Size = new System.Drawing.Size(320, 200);
			this.emptyStateList.TabIndex = 1;
			this.emptyStateList.TargetControl = this.dataGridView;
			this.emptyStateList.Title = "No deals found";
			this.emptyStateList.ActionClick += new System.EventHandler(this.emptyStateList_ActionClick);
			//
			// DealsView
			//
			this.Controls.Add(this.panelBody);
			this.Controls.Add(this.panelCaption);
			this.Controls.Add(this.panelFilterHost);
			this.Controls.Add(this.panelHeader);
			this.Name = "DealsView";
			this.Size = new System.Drawing.Size(1100, 760);
			this.panelHeader.ResumeLayout(false);
			this.panelFilterHost.ResumeLayout(false);
			this.panelFilters.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericMin)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMax)).EndInit();
			this.panelCaption.ResumeLayout(false);
			this.panelBody.ResumeLayout(false);
			this.panelList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelSummary;
		private Wisej.Web.SegmentedButton segmentedView;
		private Wisej.Web.Button buttonNew;
		private Wisej.Web.Panel panelFilterHost;
		private Wisej.Web.Panel panelFilters;
		private Wisej.Web.ComboBox comboBoxOwner;
		private Wisej.Web.DateTimePicker dateTimePickerFrom;
		private Wisej.Web.DateTimePicker dateTimePickerTo;
		private Wisej.Web.NumericUpDown numericMin;
		private Wisej.Web.NumericUpDown numericMax;
		private Wisej.Web.LinkLabel linkClear;
		private Wisej.Web.Panel panelCaption;
		private Wisej.Web.Label labelCaption;
		private Wisej.Web.Panel panelBody;
		private Wisej.Web.KanbanBoard kanbanBoard;
		private Wisej.Web.Panel panelList;
		private Wisej.Web.DataGridView dataGridView;
		private Wisej.Web.DataGridViewSubtitleColumn colTitle;
		private Wisej.Web.DataGridViewTextBoxColumn colAmount;
		private Wisej.Web.DataGridViewChipColumn colStage;
		private Wisej.Web.DataGridViewMeterColumn colProbability;
		private Wisej.Web.DataGridViewAvatarColumn colOwner;
		private Wisej.Web.DataGridViewTextBoxColumn colClose;
		private Wisej.Web.EmptyState emptyStateList;
	}
}
