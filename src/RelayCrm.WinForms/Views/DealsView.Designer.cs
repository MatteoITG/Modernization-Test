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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelList = new System.Windows.Forms.Panel();
			this.linkEmpty = new System.Windows.Forms.LinkLabel();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colProbability = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colClose = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCloseTag = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.flowBoard = new System.Windows.Forms.FlowLayoutPanel();
			this.panelCaption = new System.Windows.Forms.Panel();
			this.linkCaptionClear = new System.Windows.Forms.LinkLabel();
			this.labelCaption = new System.Windows.Forms.Label();
			this.panelFilters = new System.Windows.Forms.Panel();
			this.labelOwner = new System.Windows.Forms.Label();
			this.comboBoxOwner = new System.Windows.Forms.ComboBox();
			this.labelFrom = new System.Windows.Forms.Label();
			this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
			this.labelTo = new System.Windows.Forms.Label();
			this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
			this.labelMin = new System.Windows.Forms.Label();
			this.textBoxMin = new System.Windows.Forms.TextBox();
			this.labelMax = new System.Windows.Forms.Label();
			this.textBoxMax = new System.Windows.Forms.TextBox();
			this.linkClear = new System.Windows.Forms.LinkLabel();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.buttonNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonBoard = new System.Windows.Forms.ToolStripButton();
			this.buttonList = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonRefresh = new System.Windows.Forms.ToolStripButton();
			this.labelSummary = new System.Windows.Forms.ToolStripLabel();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuMoveTo = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.panelList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.flowBoard.SuspendLayout();
			this.panelCaption.SuspendLayout();
			this.panelFilters.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.contextMenu.SuspendLayout();
			this.SuspendLayout();
			//
			// panelList
			//
			this.panelList.Controls.Add(this.linkEmpty);
			this.panelList.Controls.Add(this.dataGridView);
			this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelList.Location = new System.Drawing.Point(0, 98);
			this.panelList.Name = "panelList";
			this.panelList.Size = new System.Drawing.Size(1000, 502);
			this.panelList.TabIndex = 4;
			this.panelList.Visible = false;
			//
			// linkEmpty
			//
			this.linkEmpty.BackColor = System.Drawing.SystemColors.Window;
			this.linkEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkEmpty.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
			this.linkEmpty.Location = new System.Drawing.Point(0, 0);
			this.linkEmpty.Name = "linkEmpty";
			this.linkEmpty.Size = new System.Drawing.Size(1000, 502);
			this.linkEmpty.TabIndex = 1;
			this.linkEmpty.Text = "No deals found.";
			this.linkEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkEmpty.Visible = false;
			this.linkEmpty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
			//
			// dataGridView
			//
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(400, 200);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.ContextMenuStrip = this.contextMenu;
			this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
			this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
			this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
			this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
			//
			// colTitle
			//
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.colTitle.DataPropertyName = "Title";
			this.colTitle.DefaultCellStyle = dataGridViewCellStyle1;
			this.colTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
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
			this.colStage.Width = 100;
			//
			// colProbability
			//
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
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
			this.colOwner.Width = 130;
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
			//
			// flowBoard
			//
			this.flowBoard.AutoScroll = true;
			this.flowBoard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowBoard.Location = new System.Drawing.Point(0, 98);
			this.flowBoard.Name = "flowBoard";
			this.flowBoard.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
			this.flowBoard.Size = new System.Drawing.Size(1000, 502);
			this.flowBoard.TabIndex = 3;
			this.flowBoard.WrapContents = false;
			this.flowBoard.Resize += new System.EventHandler(this.flowBoard_Resize);
			//
			// panelCaption
			//
			this.panelCaption.Controls.Add(this.linkCaptionClear);
			this.panelCaption.Controls.Add(this.labelCaption);
			this.panelCaption.BackColor = System.Drawing.SystemColors.Info;
			this.panelCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelCaption.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCaption.Location = new System.Drawing.Point(0, 70);
			this.panelCaption.Name = "panelCaption";
			this.panelCaption.Size = new System.Drawing.Size(1000, 28);
			this.panelCaption.TabIndex = 2;
			this.panelCaption.Visible = false;
			//
			// linkCaptionClear
			//
			this.linkCaptionClear.Anchor = ((System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right));
			this.linkCaptionClear.AutoSize = true;
			this.linkCaptionClear.Location = new System.Drawing.Point(890, 6);
			this.linkCaptionClear.Name = "linkCaptionClear";
			this.linkCaptionClear.Size = new System.Drawing.Size(100, 15);
			this.linkCaptionClear.TabIndex = 1;
			this.linkCaptionClear.TabStop = true;
			this.linkCaptionClear.Text = "Show all deals";
			this.linkCaptionClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
			//
			// labelCaption
			//
			this.labelCaption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
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
			this.panelFilters.Dock = System.Windows.Forms.DockStyle.Top;
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
			this.comboBoxOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
			this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
			this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
			this.textBoxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBoxMin.Leave += new System.EventHandler(this.amount_Leave);
			this.textBoxMin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.amount_KeyDown);
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
			this.textBoxMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.textBoxMax.Leave += new System.EventHandler(this.amount_Leave);
			this.textBoxMax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.amount_KeyDown);
			//
			// linkClear
			//
			this.linkClear.AutoSize = true;
			this.linkClear.Location = new System.Drawing.Point(902, 10);
			this.linkClear.Name = "linkClear";
			this.linkClear.Size = new System.Drawing.Size(70, 15);
			this.linkClear.TabStop = true;
			this.linkClear.Text = "Clear filters";
			this.linkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClear_LinkClicked);
			//
			// toolStrip
			//
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonNew,
			this.toolStripSeparator1,
			this.buttonBoard,
			this.buttonList,
			this.toolStripSeparator2,
			this.buttonRefresh,
			this.labelSummary});
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
			this.buttonNew.Text = "New deal...";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			//
			// buttonBoard
			//
			this.buttonBoard.Checked = true;
			this.buttonBoard.CheckState = System.Windows.Forms.CheckState.Checked;
			this.buttonBoard.Tag = "layout-three-columns";
			this.buttonBoard.Name = "buttonBoard";
			this.buttonBoard.Text = "Board";
			this.buttonBoard.Click += new System.EventHandler(this.buttonMode_Click);
			//
			// buttonList
			//
			this.buttonList.Tag = "briefcase";
			this.buttonList.Name = "buttonList";
			this.buttonList.Text = "List";
			this.buttonList.Click += new System.EventHandler(this.buttonMode_Click);
			//
			// toolStripSeparator2
			//
			this.toolStripSeparator2.Name = "toolStripSeparator2";
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
			this.labelSummary.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.labelSummary.Name = "labelSummary";
			this.labelSummary.Text = "0 deals";
			//
			// contextMenu
			//
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuOpen,
			this.menuEdit,
			this.menuMoveTo,
			this.menuSeparator1,
			this.menuDelete});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(181, 98);
			this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
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
			//
			// menuDelete
			//
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Text = "&Delete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// DealsView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelList);
			this.Controls.Add(this.flowBoard);
			this.Controls.Add(this.panelCaption);
			this.Controls.Add(this.panelFilters);
			this.Controls.Add(this.toolStrip);
			this.Name = "DealsView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.contextMenu.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.panelFilters.ResumeLayout(false);
			this.panelFilters.PerformLayout();
			this.panelCaption.ResumeLayout(false);
			this.panelCaption.PerformLayout();
			this.flowBoard.ResumeLayout(false);
			this.flowBoard.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.panelList.ResumeLayout(false);
			this.panelList.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelList;
		private System.Windows.Forms.LinkLabel linkEmpty;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
		private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStage;
		private System.Windows.Forms.DataGridViewTextBoxColumn colProbability;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOwner;
		private System.Windows.Forms.DataGridViewTextBoxColumn colClose;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCloseTag;
		private System.Windows.Forms.FlowLayoutPanel flowBoard;
		private System.Windows.Forms.Panel panelCaption;
		private System.Windows.Forms.LinkLabel linkCaptionClear;
		private System.Windows.Forms.Label labelCaption;
		private System.Windows.Forms.Panel panelFilters;
		private System.Windows.Forms.Label labelOwner;
		private System.Windows.Forms.ComboBox comboBoxOwner;
		private System.Windows.Forms.Label labelFrom;
		private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
		private System.Windows.Forms.Label labelTo;
		private System.Windows.Forms.DateTimePicker dateTimePickerTo;
		private System.Windows.Forms.Label labelMin;
		private System.Windows.Forms.TextBox textBoxMin;
		private System.Windows.Forms.Label labelMax;
		private System.Windows.Forms.TextBox textBoxMax;
		private System.Windows.Forms.LinkLabel linkClear;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton buttonNew;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton buttonBoard;
		private System.Windows.Forms.ToolStripButton buttonList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton buttonRefresh;
		private System.Windows.Forms.ToolStripLabel labelSummary;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem menuOpen;
		private System.Windows.Forms.ToolStripMenuItem menuEdit;
		private System.Windows.Forms.ToolStripMenuItem menuMoveTo;
		private System.Windows.Forms.ToolStripSeparator menuSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuDelete;
	}
}
