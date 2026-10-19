namespace RelayCrm.Dialogs
{
	partial class DealDetailDialog
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelHeader = new System.Windows.Forms.Panel();
			this.labelStages = new System.Windows.Forms.Label();
			this.labelOwner = new System.Windows.Forms.Label();
			this.labelStage = new System.Windows.Forms.Label();
			this.labelAmount = new System.Windows.Forms.Label();
			this.linkCompany = new System.Windows.Forms.LinkLabel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.buttonEdit = new System.Windows.Forms.ToolStripButton();
			this.buttonDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonLogActivity = new System.Windows.Forms.ToolStripButton();
			this.buttonAddTask = new System.Windows.Forms.ToolStripButton();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.groupBoxContacts = new System.Windows.Forms.GroupBox();
			this.listViewContacts = new System.Windows.Forms.ListView();
			this.columnContactName = new System.Windows.Forms.ColumnHeader();
			this.columnContactTitle = new System.Windows.Forms.ColumnHeader();
			this.labelNoContacts = new System.Windows.Forms.Label();
			this.groupBoxDetails = new System.Windows.Forms.GroupBox();
			this.tableDetails = new System.Windows.Forms.TableLayoutPanel();
			this.labelCapAmount = new System.Windows.Forms.Label();
			this.labelAmountValue = new System.Windows.Forms.Label();
			this.labelCapClose = new System.Windows.Forms.Label();
			this.labelCloseValue = new System.Windows.Forms.Label();
			this.labelCapProbability = new System.Windows.Forms.Label();
			this.labelProbabilityValue = new System.Windows.Forms.Label();
			this.labelCapContact = new System.Windows.Forms.Label();
			this.linkContact = new System.Windows.Forms.LinkLabel();
			this.labelCapCreated = new System.Windows.Forms.Label();
			this.labelCreatedValue = new System.Windows.Forms.Label();
			this.labelCapClosed = new System.Windows.Forms.Label();
			this.labelClosedValue = new System.Windows.Forms.Label();
			this.labelCapLost = new System.Windows.Forms.Label();
			this.labelLostValue = new System.Windows.Forms.Label();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageActivity = new System.Windows.Forms.TabPage();
			this.listViewActivity = new System.Windows.Forms.ListView();
			this.columnActivityDate = new System.Windows.Forms.ColumnHeader();
			this.columnActivityType = new System.Windows.Forms.ColumnHeader();
			this.columnActivitySubject = new System.Windows.Forms.ColumnHeader();
			this.columnActivityUser = new System.Windows.Forms.ColumnHeader();
			this.columnActivityNotes = new System.Windows.Forms.ColumnHeader();
			this.tabPageTasks = new System.Windows.Forms.TabPage();
			this.listViewTasks = new System.Windows.Forms.ListView();
			this.columnTaskTitle = new System.Windows.Forms.ColumnHeader();
			this.columnTaskDue = new System.Windows.Forms.ColumnHeader();
			this.columnTaskPriority = new System.Windows.Forms.ColumnHeader();
			this.columnTaskAssignee = new System.Windows.Forms.ColumnHeader();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.buttonClose = new System.Windows.Forms.Button();
			this.panelHeader.SuspendLayout();
			this.toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.groupBoxContacts.SuspendLayout();
			this.groupBoxDetails.SuspendLayout();
			this.tableDetails.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageActivity.SuspendLayout();
			this.tabPageTasks.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.labelStages);
			this.panelHeader.Controls.Add(this.labelOwner);
			this.panelHeader.Controls.Add(this.labelStage);
			this.panelHeader.Controls.Add(this.labelAmount);
			this.panelHeader.Controls.Add(this.linkCompany);
			this.panelHeader.Controls.Add(this.labelTitle);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(844, 100);
			this.panelHeader.TabIndex = 0;
			//
			// labelStages
			//
			this.labelStages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelStages.AutoEllipsis = true;
			this.labelStages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelStages.Location = new System.Drawing.Point(12, 68);
			this.labelStages.Name = "labelStages";
			this.labelStages.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelStages.Size = new System.Drawing.Size(820, 24);
			this.labelStages.TabIndex = 5;
			this.labelStages.Text = "Stages";
			this.labelStages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// labelOwner
			//
			this.labelOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelOwner.Location = new System.Drawing.Point(592, 42);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Size = new System.Drawing.Size(240, 18);
			this.labelOwner.TabIndex = 4;
			this.labelOwner.Text = "Owner";
			this.labelOwner.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// labelStage
			//
			this.labelStage.AutoSize = true;
			this.labelStage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.labelStage.Location = new System.Drawing.Point(14, 44);
			this.labelStage.Name = "labelStage";
			this.labelStage.Size = new System.Drawing.Size(39, 15);
			this.labelStage.TabIndex = 2;
			this.labelStage.Text = "Stage";
			//
			// labelAmount
			//
			this.labelAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.labelAmount.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.labelAmount.Location = new System.Drawing.Point(592, 10);
			this.labelAmount.Name = "labelAmount";
			this.labelAmount.Size = new System.Drawing.Size(240, 30);
			this.labelAmount.TabIndex = 3;
			this.labelAmount.Text = "$0";
			this.labelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// linkCompany
			//
			this.linkCompany.AutoSize = true;
			this.linkCompany.Location = new System.Drawing.Point(120, 44);
			this.linkCompany.Name = "linkCompany";
			this.linkCompany.Size = new System.Drawing.Size(59, 15);
			this.linkCompany.TabIndex = 1;
			this.linkCompany.TabStop = true;
			this.linkCompany.Text = "Company";
			this.linkCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCompany_LinkClicked);
			//
			// labelTitle
			//
			this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelTitle.AutoEllipsis = true;
			this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
			this.labelTitle.Location = new System.Drawing.Point(10, 10);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(576, 30);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Deal";
			//
			// toolStrip
			//
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonEdit,
			this.buttonDelete,
			this.toolStripSeparator1,
			this.buttonLogActivity,
			this.buttonAddTask});
			this.toolStrip.Location = new System.Drawing.Point(0, 100);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(844, 25);
			this.toolStrip.TabIndex = 1;
			//
			// buttonEdit
			//
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(39, 22);
			this.buttonEdit.Tag = "pencil";
			this.buttonEdit.Text = "&Edit...";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			//
			// buttonDelete
			//
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(44, 22);
			this.buttonDelete.Tag = "trash";
			this.buttonDelete.Text = "&Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			//
			// buttonLogActivity
			//
			this.buttonLogActivity.Name = "buttonLogActivity";
			this.buttonLogActivity.Size = new System.Drawing.Size(80, 22);
			this.buttonLogActivity.Tag = "journal-plus";
			this.buttonLogActivity.Text = "&Log activity...";
			this.buttonLogActivity.Click += new System.EventHandler(this.buttonLogActivity_Click);
			//
			// buttonAddTask
			//
			this.buttonAddTask.Name = "buttonAddTask";
			this.buttonAddTask.Size = new System.Drawing.Size(64, 22);
			this.buttonAddTask.Tag = "check2-square";
			this.buttonAddTask.Text = "&Add task...";
			this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
			//
			// splitContainer
			//
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.Location = new System.Drawing.Point(0, 125);
			this.splitContainer.Name = "splitContainer";
			//
			// splitContainer.Panel1
			//
			this.splitContainer.Panel1.Controls.Add(this.groupBoxContacts);
			this.splitContainer.Panel1.Controls.Add(this.groupBoxDetails);
			this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(8, 4, 0, 8);
			//
			// splitContainer.Panel2
			//
			this.splitContainer.Panel2.Controls.Add(this.tabControl);
			this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(0, 8, 8, 8);
			this.splitContainer.Size = new System.Drawing.Size(844, 360);
			this.splitContainer.SplitterDistance = 300;
			this.splitContainer.TabIndex = 2;
			//
			// groupBoxContacts
			//
			this.groupBoxContacts.Controls.Add(this.listViewContacts);
			this.groupBoxContacts.Controls.Add(this.labelNoContacts);
			this.groupBoxContacts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxContacts.Location = new System.Drawing.Point(8, 208);
			this.groupBoxContacts.Name = "groupBoxContacts";
			this.groupBoxContacts.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
			this.groupBoxContacts.Size = new System.Drawing.Size(292, 144);
			this.groupBoxContacts.TabIndex = 1;
			this.groupBoxContacts.TabStop = false;
			this.groupBoxContacts.Text = "Related contacts";
			//
			// listViewContacts
			//
			this.listViewContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnContactName,
			this.columnContactTitle});
			this.listViewContacts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewContacts.FullRowSelect = true;
			this.listViewContacts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewContacts.Location = new System.Drawing.Point(8, 20);
			this.listViewContacts.MultiSelect = false;
			this.listViewContacts.Name = "listViewContacts";
			this.listViewContacts.ShowItemToolTips = true;
			this.listViewContacts.Size = new System.Drawing.Size(276, 116);
			this.listViewContacts.TabIndex = 0;
			this.listViewContacts.UseCompatibleStateImageBehavior = false;
			this.listViewContacts.View = System.Windows.Forms.View.Details;
			this.listViewContacts.ItemActivate += new System.EventHandler(this.listViewContacts_ItemActivate);
			//
			// columnContactName
			//
			this.columnContactName.Text = "Name";
			this.columnContactName.Width = 130;
			//
			// columnContactTitle
			//
			this.columnContactTitle.Text = "Title";
			this.columnContactTitle.Width = 120;
			//
			// labelNoContacts
			//
			this.labelNoContacts.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelNoContacts.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelNoContacts.Location = new System.Drawing.Point(8, 20);
			this.labelNoContacts.Name = "labelNoContacts";
			this.labelNoContacts.Size = new System.Drawing.Size(276, 24);
			this.labelNoContacts.TabIndex = 1;
			this.labelNoContacts.Text = "No contacts at this company yet.";
			this.labelNoContacts.Visible = false;
			//
			// groupBoxDetails
			//
			this.groupBoxDetails.Controls.Add(this.tableDetails);
			this.groupBoxDetails.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxDetails.Location = new System.Drawing.Point(8, 4);
			this.groupBoxDetails.Name = "groupBoxDetails";
			this.groupBoxDetails.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
			this.groupBoxDetails.Size = new System.Drawing.Size(292, 204);
			this.groupBoxDetails.TabIndex = 0;
			this.groupBoxDetails.TabStop = false;
			this.groupBoxDetails.Text = "Details";
			//
			// tableDetails
			//
			this.tableDetails.ColumnCount = 2;
			this.tableDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
			this.tableDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableDetails.Controls.Add(this.labelCapAmount, 0, 0);
			this.tableDetails.Controls.Add(this.labelAmountValue, 1, 0);
			this.tableDetails.Controls.Add(this.labelCapClose, 0, 1);
			this.tableDetails.Controls.Add(this.labelCloseValue, 1, 1);
			this.tableDetails.Controls.Add(this.labelCapProbability, 0, 2);
			this.tableDetails.Controls.Add(this.labelProbabilityValue, 1, 2);
			this.tableDetails.Controls.Add(this.labelCapContact, 0, 3);
			this.tableDetails.Controls.Add(this.linkContact, 1, 3);
			this.tableDetails.Controls.Add(this.labelCapCreated, 0, 4);
			this.tableDetails.Controls.Add(this.labelCreatedValue, 1, 4);
			this.tableDetails.Controls.Add(this.labelCapClosed, 0, 5);
			this.tableDetails.Controls.Add(this.labelClosedValue, 1, 5);
			this.tableDetails.Controls.Add(this.labelCapLost, 0, 6);
			this.tableDetails.Controls.Add(this.labelLostValue, 1, 6);
			this.tableDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableDetails.Location = new System.Drawing.Point(8, 20);
			this.tableDetails.Name = "tableDetails";
			this.tableDetails.RowCount = 7;
			this.tableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
			this.tableDetails.Size = new System.Drawing.Size(276, 176);
			this.tableDetails.TabIndex = 0;
			//
			// labelCapAmount
			//
			this.labelCapAmount.AutoSize = true;
			this.labelCapAmount.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelCapAmount.Location = new System.Drawing.Point(3, 4);
			this.labelCapAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelCapAmount.Name = "labelCapAmount";
			this.labelCapAmount.Size = new System.Drawing.Size(51, 15);
			this.labelCapAmount.TabIndex = 0;
			this.labelCapAmount.Text = "Amount";
			//
			// labelAmountValue
			//
			this.labelAmountValue.AutoSize = true;
			this.labelAmountValue.Location = new System.Drawing.Point(107, 4);
			this.labelAmountValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelAmountValue.Name = "labelAmountValue";
			this.labelAmountValue.Size = new System.Drawing.Size(19, 15);
			this.labelAmountValue.TabIndex = 1;
			this.labelAmountValue.Text = "$0";
			//
			// labelCapClose
			//
			this.labelCapClose.AutoSize = true;
			this.labelCapClose.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelCapClose.Location = new System.Drawing.Point(3, 28);
			this.labelCapClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelCapClose.Name = "labelCapClose";
			this.labelCapClose.Size = new System.Drawing.Size(86, 15);
			this.labelCapClose.TabIndex = 2;
			this.labelCapClose.Text = "Expected close";
			//
			// labelCloseValue
			//
			this.labelCloseValue.AutoSize = true;
			this.labelCloseValue.Location = new System.Drawing.Point(107, 28);
			this.labelCloseValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelCloseValue.Name = "labelCloseValue";
			this.labelCloseValue.Size = new System.Drawing.Size(12, 15);
			this.labelCloseValue.TabIndex = 3;
			this.labelCloseValue.Text = "-";
			//
			// labelCapProbability
			//
			this.labelCapProbability.AutoSize = true;
			this.labelCapProbability.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelCapProbability.Location = new System.Drawing.Point(3, 52);
			this.labelCapProbability.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelCapProbability.Name = "labelCapProbability";
			this.labelCapProbability.Size = new System.Drawing.Size(65, 15);
			this.labelCapProbability.TabIndex = 4;
			this.labelCapProbability.Text = "Probability";
			//
			// labelProbabilityValue
			//
			this.labelProbabilityValue.AutoSize = true;
			this.labelProbabilityValue.Location = new System.Drawing.Point(107, 52);
			this.labelProbabilityValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelProbabilityValue.Name = "labelProbabilityValue";
			this.labelProbabilityValue.Size = new System.Drawing.Size(23, 15);
			this.labelProbabilityValue.TabIndex = 5;
			this.labelProbabilityValue.Text = "0%";
			//
			// labelCapContact
			//
			this.labelCapContact.AutoSize = true;
			this.labelCapContact.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelCapContact.Location = new System.Drawing.Point(3, 76);
			this.labelCapContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelCapContact.Name = "labelCapContact";
			this.labelCapContact.Size = new System.Drawing.Size(92, 15);
			this.labelCapContact.TabIndex = 6;
			this.labelCapContact.Text = "Primary contact";
			//
			// linkContact
			//
			this.linkContact.AutoSize = true;
			this.linkContact.Location = new System.Drawing.Point(107, 76);
			this.linkContact.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.linkContact.Name = "linkContact";
			this.linkContact.Size = new System.Drawing.Size(36, 15);
			this.linkContact.TabIndex = 7;
			this.linkContact.TabStop = true;
			this.linkContact.Text = "None";
			this.linkContact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkContact_LinkClicked);
			//
			// labelCapCreated
			//
			this.labelCapCreated.AutoSize = true;
			this.labelCapCreated.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelCapCreated.Location = new System.Drawing.Point(3, 100);
			this.labelCapCreated.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelCapCreated.Name = "labelCapCreated";
			this.labelCapCreated.Size = new System.Drawing.Size(48, 15);
			this.labelCapCreated.TabIndex = 8;
			this.labelCapCreated.Text = "Created";
			//
			// labelCreatedValue
			//
			this.labelCreatedValue.AutoSize = true;
			this.labelCreatedValue.Location = new System.Drawing.Point(107, 100);
			this.labelCreatedValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelCreatedValue.Name = "labelCreatedValue";
			this.labelCreatedValue.Size = new System.Drawing.Size(12, 15);
			this.labelCreatedValue.TabIndex = 9;
			this.labelCreatedValue.Text = "-";
			//
			// labelCapClosed
			//
			this.labelCapClosed.AutoSize = true;
			this.labelCapClosed.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelCapClosed.Location = new System.Drawing.Point(3, 124);
			this.labelCapClosed.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelCapClosed.Name = "labelCapClosed";
			this.labelCapClosed.Size = new System.Drawing.Size(43, 15);
			this.labelCapClosed.TabIndex = 10;
			this.labelCapClosed.Text = "Closed";
			//
			// labelClosedValue
			//
			this.labelClosedValue.AutoSize = true;
			this.labelClosedValue.Location = new System.Drawing.Point(107, 124);
			this.labelClosedValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelClosedValue.Name = "labelClosedValue";
			this.labelClosedValue.Size = new System.Drawing.Size(12, 15);
			this.labelClosedValue.TabIndex = 11;
			this.labelClosedValue.Text = "-";
			//
			// labelCapLost
			//
			this.labelCapLost.AutoSize = true;
			this.labelCapLost.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelCapLost.Location = new System.Drawing.Point(3, 148);
			this.labelCapLost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelCapLost.Name = "labelCapLost";
			this.labelCapLost.Size = new System.Drawing.Size(67, 15);
			this.labelCapLost.TabIndex = 12;
			this.labelCapLost.Text = "Lost reason";
			//
			// labelLostValue
			//
			this.labelLostValue.AutoEllipsis = true;
			this.labelLostValue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelLostValue.Location = new System.Drawing.Point(107, 148);
			this.labelLostValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
			this.labelLostValue.Name = "labelLostValue";
			this.labelLostValue.Size = new System.Drawing.Size(166, 28);
			this.labelLostValue.TabIndex = 13;
			this.labelLostValue.Text = "-";
			//
			// tabControl
			//
			this.tabControl.Controls.Add(this.tabPageActivity);
			this.tabControl.Controls.Add(this.tabPageTasks);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 8);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(532, 344);
			this.tabControl.TabIndex = 0;
			//
			// tabPageActivity
			//
			this.tabPageActivity.Controls.Add(this.listViewActivity);
			this.tabPageActivity.Location = new System.Drawing.Point(4, 24);
			this.tabPageActivity.Name = "tabPageActivity";
			this.tabPageActivity.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageActivity.Size = new System.Drawing.Size(524, 316);
			this.tabPageActivity.TabIndex = 0;
			this.tabPageActivity.Text = "Activity";
			this.tabPageActivity.UseVisualStyleBackColor = true;
			//
			// listViewActivity
			//
			this.listViewActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnActivityDate,
			this.columnActivityType,
			this.columnActivitySubject,
			this.columnActivityUser,
			this.columnActivityNotes});
			this.listViewActivity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewActivity.FullRowSelect = true;
			this.listViewActivity.Location = new System.Drawing.Point(3, 3);
			this.listViewActivity.Name = "listViewActivity";
			this.listViewActivity.ShowItemToolTips = true;
			this.listViewActivity.Size = new System.Drawing.Size(518, 310);
			this.listViewActivity.TabIndex = 0;
			this.listViewActivity.UseCompatibleStateImageBehavior = false;
			this.listViewActivity.View = System.Windows.Forms.View.Details;
			//
			// columnActivityDate
			//
			this.columnActivityDate.Text = "Date";
			this.columnActivityDate.Width = 150;
			//
			// columnActivityType
			//
			this.columnActivityType.Text = "Type";
			this.columnActivityType.Width = 64;
			//
			// columnActivitySubject
			//
			this.columnActivitySubject.Text = "Subject";
			this.columnActivitySubject.Width = 150;
			//
			// columnActivityUser
			//
			this.columnActivityUser.Text = "By";
			this.columnActivityUser.Width = 100;
			//
			// columnActivityNotes
			//
			this.columnActivityNotes.Text = "Notes";
			this.columnActivityNotes.Width = 200;
			//
			// tabPageTasks
			//
			this.tabPageTasks.Controls.Add(this.listViewTasks);
			this.tabPageTasks.Location = new System.Drawing.Point(4, 24);
			this.tabPageTasks.Name = "tabPageTasks";
			this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTasks.Size = new System.Drawing.Size(524, 316);
			this.tabPageTasks.TabIndex = 1;
			this.tabPageTasks.Text = "Tasks";
			this.tabPageTasks.UseVisualStyleBackColor = true;
			//
			// listViewTasks
			//
			this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnTaskTitle,
			this.columnTaskDue,
			this.columnTaskPriority,
			this.columnTaskAssignee});
			this.listViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewTasks.FullRowSelect = true;
			this.listViewTasks.Location = new System.Drawing.Point(3, 3);
			this.listViewTasks.MultiSelect = false;
			this.listViewTasks.Name = "listViewTasks";
			this.listViewTasks.Size = new System.Drawing.Size(518, 310);
			this.listViewTasks.TabIndex = 0;
			this.listViewTasks.UseCompatibleStateImageBehavior = false;
			this.listViewTasks.View = System.Windows.Forms.View.Details;
			this.listViewTasks.ItemActivate += new System.EventHandler(this.listViewTasks_ItemActivate);
			//
			// columnTaskTitle
			//
			this.columnTaskTitle.Text = "Task";
			this.columnTaskTitle.Width = 220;
			//
			// columnTaskDue
			//
			this.columnTaskDue.Text = "Due";
			this.columnTaskDue.Width = 140;
			//
			// columnTaskPriority
			//
			this.columnTaskPriority.Text = "Priority";
			this.columnTaskPriority.Width = 64;
			//
			// columnTaskAssignee
			//
			this.columnTaskAssignee.Text = "Assignee";
			this.columnTaskAssignee.Width = 110;
			//
			// panelButtons
			//
			this.panelButtons.Controls.Add(this.buttonClose);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(0, 485);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(844, 44);
			this.panelButtons.TabIndex = 3;
			//
			// buttonClose
			//
			this.buttonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonClose.Location = new System.Drawing.Point(740, 8);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(92, 27);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.Text = "Close";
			this.buttonClose.UseVisualStyleBackColor = true;
			//
			// DealDetailDialog
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new System.Drawing.Size(844, 529);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.panelHeader);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(700, 480);
			this.Name = "DealDetailDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Deal";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DealDetailDialog_FormClosed);
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.groupBoxContacts.ResumeLayout(false);
			this.groupBoxDetails.ResumeLayout(false);
			this.tableDetails.ResumeLayout(false);
			this.tableDetails.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageActivity.ResumeLayout(false);
			this.tabPageTasks.ResumeLayout(false);
			this.panelButtons.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label labelStages;
		private System.Windows.Forms.Label labelOwner;
		private System.Windows.Forms.Label labelStage;
		private System.Windows.Forms.Label labelAmount;
		private System.Windows.Forms.LinkLabel linkCompany;
		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton buttonEdit;
		private System.Windows.Forms.ToolStripButton buttonDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton buttonLogActivity;
		private System.Windows.Forms.ToolStripButton buttonAddTask;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.GroupBox groupBoxContacts;
		private System.Windows.Forms.ListView listViewContacts;
		private System.Windows.Forms.ColumnHeader columnContactName;
		private System.Windows.Forms.ColumnHeader columnContactTitle;
		private System.Windows.Forms.Label labelNoContacts;
		private System.Windows.Forms.GroupBox groupBoxDetails;
		private System.Windows.Forms.TableLayoutPanel tableDetails;
		private System.Windows.Forms.Label labelCapAmount;
		private System.Windows.Forms.Label labelAmountValue;
		private System.Windows.Forms.Label labelCapClose;
		private System.Windows.Forms.Label labelCloseValue;
		private System.Windows.Forms.Label labelCapProbability;
		private System.Windows.Forms.Label labelProbabilityValue;
		private System.Windows.Forms.Label labelCapContact;
		private System.Windows.Forms.LinkLabel linkContact;
		private System.Windows.Forms.Label labelCapCreated;
		private System.Windows.Forms.Label labelCreatedValue;
		private System.Windows.Forms.Label labelCapClosed;
		private System.Windows.Forms.Label labelClosedValue;
		private System.Windows.Forms.Label labelCapLost;
		private System.Windows.Forms.Label labelLostValue;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageActivity;
		private System.Windows.Forms.ListView listViewActivity;
		private System.Windows.Forms.ColumnHeader columnActivityDate;
		private System.Windows.Forms.ColumnHeader columnActivityType;
		private System.Windows.Forms.ColumnHeader columnActivitySubject;
		private System.Windows.Forms.ColumnHeader columnActivityUser;
		private System.Windows.Forms.ColumnHeader columnActivityNotes;
		private System.Windows.Forms.TabPage tabPageTasks;
		private System.Windows.Forms.ListView listViewTasks;
		private System.Windows.Forms.ColumnHeader columnTaskTitle;
		private System.Windows.Forms.ColumnHeader columnTaskDue;
		private System.Windows.Forms.ColumnHeader columnTaskPriority;
		private System.Windows.Forms.ColumnHeader columnTaskAssignee;
		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button buttonClose;
	}
}
