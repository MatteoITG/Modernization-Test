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
			this.panelHeader = new Wisej.Web.Panel();
			this.labelStages = new Wisej.Web.Label();
			this.labelOwner = new Wisej.Web.Label();
			this.labelStage = new Wisej.Web.Label();
			this.labelAmount = new Wisej.Web.Label();
			this.linkCompany = new Wisej.Web.LinkLabel();
			this.labelTitle = new Wisej.Web.Label();
			this.toolStrip = new Wisej.Web.ToolBar();
			this.buttonEdit = new Wisej.Web.ToolBarButton();
			this.buttonDelete = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator1 = new Wisej.Web.ToolBarButton();
			this.buttonLogActivity = new Wisej.Web.ToolBarButton();
			this.buttonAddTask = new Wisej.Web.ToolBarButton();
			this.splitContainer = new Wisej.Web.SplitContainer();
			this.groupBoxContacts = new Wisej.Web.GroupBox();
			this.listViewContacts = new Wisej.Web.ListView();
			this.columnContactName = new Wisej.Web.ColumnHeader();
			this.columnContactTitle = new Wisej.Web.ColumnHeader();
			this.labelNoContacts = new Wisej.Web.Label();
			this.groupBoxDetails = new Wisej.Web.GroupBox();
			this.tableDetails = new Wisej.Web.TableLayoutPanel();
			this.labelCapAmount = new Wisej.Web.Label();
			this.labelAmountValue = new Wisej.Web.Label();
			this.labelCapClose = new Wisej.Web.Label();
			this.labelCloseValue = new Wisej.Web.Label();
			this.labelCapProbability = new Wisej.Web.Label();
			this.labelProbabilityValue = new Wisej.Web.Label();
			this.labelCapContact = new Wisej.Web.Label();
			this.linkContact = new Wisej.Web.LinkLabel();
			this.labelCapCreated = new Wisej.Web.Label();
			this.labelCreatedValue = new Wisej.Web.Label();
			this.labelCapClosed = new Wisej.Web.Label();
			this.labelClosedValue = new Wisej.Web.Label();
			this.labelCapLost = new Wisej.Web.Label();
			this.labelLostValue = new Wisej.Web.Label();
			this.tabControl = new Wisej.Web.TabControl();
			this.tabPageActivity = new Wisej.Web.TabPage();
			this.listViewActivity = new Wisej.Web.ListView();
			this.columnActivityDate = new Wisej.Web.ColumnHeader();
			this.columnActivityType = new Wisej.Web.ColumnHeader();
			this.columnActivitySubject = new Wisej.Web.ColumnHeader();
			this.columnActivityUser = new Wisej.Web.ColumnHeader();
			this.columnActivityNotes = new Wisej.Web.ColumnHeader();
			this.tabPageTasks = new Wisej.Web.TabPage();
			this.listViewTasks = new Wisej.Web.ListView();
			this.columnTaskTitle = new Wisej.Web.ColumnHeader();
			this.columnTaskDue = new Wisej.Web.ColumnHeader();
			this.columnTaskPriority = new Wisej.Web.ColumnHeader();
			this.columnTaskAssignee = new Wisej.Web.ColumnHeader();
			this.panelButtons = new Wisej.Web.Panel();
			this.buttonClose = new Wisej.Web.Button();
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
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(844, 100);
			this.panelHeader.TabIndex = 0;
			//
			// labelStages
			//
			this.labelStages.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
			| Wisej.Web.AnchorStyles.Right)));
			this.labelStages.AutoEllipsis = true;
			this.labelStages.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.labelStages.Location = new System.Drawing.Point(12, 68);
			this.labelStages.Name = "labelStages";
			this.labelStages.Padding = new Wisej.Web.Padding(4, 0, 4, 0);
			this.labelStages.Size = new System.Drawing.Size(820, 24);
			this.labelStages.TabIndex = 5;
			this.labelStages.Text = "Stages";
			this.labelStages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// labelOwner
			//
			this.labelOwner.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
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
			this.labelAmount.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
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
			this.linkCompany.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkCompany_LinkClicked);
			//
			// labelTitle
			//
			this.labelTitle.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
			| Wisej.Web.AnchorStyles.Right)));
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
			this.toolStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonEdit,
			this.buttonDelete,
			this.toolStripSeparator1,
			this.buttonLogActivity,
			this.buttonAddTask});
			this.toolStrip.Location = new System.Drawing.Point(0, 100);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new System.Drawing.Size(844, 25);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			//
			// buttonEdit
			//
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Tag = "pencil";
			this.buttonEdit.Text = "Edit...";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			//
			// buttonDelete
			//
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Tag = "trash";
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// buttonLogActivity
			//
			this.buttonLogActivity.Name = "buttonLogActivity";
			this.buttonLogActivity.Tag = "journal-plus";
			this.buttonLogActivity.Text = "Log activity...";
			this.buttonLogActivity.Click += new System.EventHandler(this.buttonLogActivity_Click);
			//
			// buttonAddTask
			//
			this.buttonAddTask.Name = "buttonAddTask";
			this.buttonAddTask.Tag = "check2-square";
			this.buttonAddTask.Text = "Add task...";
			this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
			//
			// splitContainer
			//
			this.splitContainer.Dock = Wisej.Web.DockStyle.Fill;
			this.splitContainer.FixedPanel = Wisej.Web.FixedPanel.Panel1;
			this.splitContainer.Location = new System.Drawing.Point(0, 125);
			this.splitContainer.Name = "splitContainer";
			//
			// splitContainer.Panel1
			//
			this.splitContainer.Panel1.Controls.Add(this.groupBoxContacts);
			this.splitContainer.Panel1.Controls.Add(this.groupBoxDetails);
			this.splitContainer.Panel1.Padding = new Wisej.Web.Padding(8, 4, 0, 8);
			//
			// splitContainer.Panel2
			//
			this.splitContainer.Panel2.Controls.Add(this.tabControl);
			this.splitContainer.Panel2.Padding = new Wisej.Web.Padding(0, 8, 8, 8);
			this.splitContainer.Size = new System.Drawing.Size(844, 360);
			this.splitContainer.SplitterDistance = 300;
			this.splitContainer.TabIndex = 2;
			//
			// groupBoxContacts
			//
			this.groupBoxContacts.Controls.Add(this.listViewContacts);
			this.groupBoxContacts.Controls.Add(this.labelNoContacts);
			this.groupBoxContacts.Dock = Wisej.Web.DockStyle.Fill;
			this.groupBoxContacts.Location = new System.Drawing.Point(8, 208);
			this.groupBoxContacts.Name = "groupBoxContacts";
			this.groupBoxContacts.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupBoxContacts.Size = new System.Drawing.Size(292, 144);
			this.groupBoxContacts.TabIndex = 1;
			this.groupBoxContacts.TabStop = false;
			this.groupBoxContacts.Text = "Related contacts";
			//
			// listViewContacts
			//
			this.listViewContacts.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
			this.columnContactName,
			this.columnContactTitle});
			this.listViewContacts.Dock = Wisej.Web.DockStyle.Fill;
			this.listViewContacts.HeaderStyle = Wisej.Web.ColumnHeaderStyle.None;
			this.listViewContacts.Location = new System.Drawing.Point(8, 20);
			this.listViewContacts.MultiSelect = false;
			this.listViewContacts.Name = "listViewContacts";
			this.listViewContacts.ShowItemToolTips = true;
			this.listViewContacts.Size = new System.Drawing.Size(276, 116);
			this.listViewContacts.TabIndex = 0;
			this.listViewContacts.View = Wisej.Web.View.Details;
			this.listViewContacts.ItemDoubleClick += new Wisej.Web.ItemClickEventHandler(this.listViewContacts_ItemActivate);
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
			this.labelNoContacts.Dock = Wisej.Web.DockStyle.Top;
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
			this.groupBoxDetails.Dock = Wisej.Web.DockStyle.Top;
			this.groupBoxDetails.Location = new System.Drawing.Point(8, 4);
			this.groupBoxDetails.Name = "groupBoxDetails";
			this.groupBoxDetails.Padding = new Wisej.Web.Padding(8, 4, 8, 8);
			this.groupBoxDetails.Size = new System.Drawing.Size(292, 204);
			this.groupBoxDetails.TabIndex = 0;
			this.groupBoxDetails.TabStop = false;
			this.groupBoxDetails.Text = "Details";
			//
			// tableDetails
			//
			this.tableDetails.ColumnCount = 2;
			this.tableDetails.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 104F));
			this.tableDetails.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
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
			this.tableDetails.Dock = Wisej.Web.DockStyle.Fill;
			this.tableDetails.Location = new System.Drawing.Point(8, 20);
			this.tableDetails.Name = "tableDetails";
			this.tableDetails.RowCount = 7;
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 24F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 24F));
			this.tableDetails.Size = new System.Drawing.Size(276, 176);
			this.tableDetails.TabIndex = 0;
			//
			// labelCapAmount
			//
			this.labelCapAmount.AutoSize = true;
			this.labelCapAmount.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelCapAmount.Location = new System.Drawing.Point(3, 4);
			this.labelCapAmount.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
			this.labelCapAmount.Name = "labelCapAmount";
			this.labelCapAmount.Size = new System.Drawing.Size(51, 15);
			this.labelCapAmount.TabIndex = 0;
			this.labelCapAmount.Text = "Amount";
			//
			// labelAmountValue
			//
			this.labelAmountValue.AutoSize = true;
			this.labelAmountValue.Location = new System.Drawing.Point(107, 4);
			this.labelAmountValue.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
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
			this.labelCapClose.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
			this.labelCapClose.Name = "labelCapClose";
			this.labelCapClose.Size = new System.Drawing.Size(86, 15);
			this.labelCapClose.TabIndex = 2;
			this.labelCapClose.Text = "Expected close";
			//
			// labelCloseValue
			//
			this.labelCloseValue.AutoSize = true;
			this.labelCloseValue.Location = new System.Drawing.Point(107, 28);
			this.labelCloseValue.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
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
			this.labelCapProbability.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
			this.labelCapProbability.Name = "labelCapProbability";
			this.labelCapProbability.Size = new System.Drawing.Size(65, 15);
			this.labelCapProbability.TabIndex = 4;
			this.labelCapProbability.Text = "Probability";
			//
			// labelProbabilityValue
			//
			this.labelProbabilityValue.AutoSize = true;
			this.labelProbabilityValue.Location = new System.Drawing.Point(107, 52);
			this.labelProbabilityValue.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
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
			this.labelCapContact.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
			this.labelCapContact.Name = "labelCapContact";
			this.labelCapContact.Size = new System.Drawing.Size(92, 15);
			this.labelCapContact.TabIndex = 6;
			this.labelCapContact.Text = "Primary contact";
			//
			// linkContact
			//
			this.linkContact.AutoSize = true;
			this.linkContact.Location = new System.Drawing.Point(107, 76);
			this.linkContact.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
			this.linkContact.Name = "linkContact";
			this.linkContact.Size = new System.Drawing.Size(36, 15);
			this.linkContact.TabIndex = 7;
			this.linkContact.TabStop = true;
			this.linkContact.Text = "None";
			this.linkContact.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkContact_LinkClicked);
			//
			// labelCapCreated
			//
			this.labelCapCreated.AutoSize = true;
			this.labelCapCreated.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelCapCreated.Location = new System.Drawing.Point(3, 100);
			this.labelCapCreated.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
			this.labelCapCreated.Name = "labelCapCreated";
			this.labelCapCreated.Size = new System.Drawing.Size(48, 15);
			this.labelCapCreated.TabIndex = 8;
			this.labelCapCreated.Text = "Created";
			//
			// labelCreatedValue
			//
			this.labelCreatedValue.AutoSize = true;
			this.labelCreatedValue.Location = new System.Drawing.Point(107, 100);
			this.labelCreatedValue.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
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
			this.labelCapClosed.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
			this.labelCapClosed.Name = "labelCapClosed";
			this.labelCapClosed.Size = new System.Drawing.Size(43, 15);
			this.labelCapClosed.TabIndex = 10;
			this.labelCapClosed.Text = "Closed";
			//
			// labelClosedValue
			//
			this.labelClosedValue.AutoSize = true;
			this.labelClosedValue.Location = new System.Drawing.Point(107, 124);
			this.labelClosedValue.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
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
			this.labelCapLost.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
			this.labelCapLost.Name = "labelCapLost";
			this.labelCapLost.Size = new System.Drawing.Size(67, 15);
			this.labelCapLost.TabIndex = 12;
			this.labelCapLost.Text = "Lost reason";
			//
			// labelLostValue
			//
			this.labelLostValue.AutoEllipsis = true;
			this.labelLostValue.Dock = Wisej.Web.DockStyle.Fill;
			this.labelLostValue.Location = new System.Drawing.Point(107, 148);
			this.labelLostValue.Margin = new Wisej.Web.Padding(3, 4, 3, 0);
			this.labelLostValue.Name = "labelLostValue";
			this.labelLostValue.Size = new System.Drawing.Size(166, 28);
			this.labelLostValue.TabIndex = 13;
			this.labelLostValue.Text = "-";
			//
			// tabControl
			//
			this.tabControl.Controls.Add(this.tabPageActivity);
			this.tabControl.Controls.Add(this.tabPageTasks);
			this.tabControl.Dock = Wisej.Web.DockStyle.Fill;
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
			this.tabPageActivity.Padding = new Wisej.Web.Padding(3);
			this.tabPageActivity.Size = new System.Drawing.Size(524, 316);
			this.tabPageActivity.TabIndex = 0;
			this.tabPageActivity.Text = "Activity";
			//
			// listViewActivity
			//
			this.listViewActivity.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
			this.columnActivityDate,
			this.columnActivityType,
			this.columnActivitySubject,
			this.columnActivityUser,
			this.columnActivityNotes});
			this.listViewActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.listViewActivity.Location = new System.Drawing.Point(3, 3);
			this.listViewActivity.Name = "listViewActivity";
			this.listViewActivity.ShowItemToolTips = true;
			this.listViewActivity.Size = new System.Drawing.Size(518, 310);
			this.listViewActivity.TabIndex = 0;
			this.listViewActivity.View = Wisej.Web.View.Details;
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
			this.tabPageTasks.Padding = new Wisej.Web.Padding(3);
			this.tabPageTasks.Size = new System.Drawing.Size(524, 316);
			this.tabPageTasks.TabIndex = 1;
			this.tabPageTasks.Text = "Tasks";
			//
			// listViewTasks
			//
			this.listViewTasks.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
			this.columnTaskTitle,
			this.columnTaskDue,
			this.columnTaskPriority,
			this.columnTaskAssignee});
			this.listViewTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.listViewTasks.Location = new System.Drawing.Point(3, 3);
			this.listViewTasks.MultiSelect = false;
			this.listViewTasks.Name = "listViewTasks";
			this.listViewTasks.Size = new System.Drawing.Size(518, 310);
			this.listViewTasks.TabIndex = 0;
			this.listViewTasks.View = Wisej.Web.View.Details;
			this.listViewTasks.ItemDoubleClick += new Wisej.Web.ItemClickEventHandler(this.listViewTasks_ItemActivate);
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
			this.panelButtons.Dock = Wisej.Web.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(0, 485);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(844, 44);
			this.panelButtons.TabIndex = 3;
			//
			// buttonClose
			//
			this.buttonClose.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonClose.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonClose.Location = new System.Drawing.Point(740, 8);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(92, 27);
			this.buttonClose.TabIndex = 0;
			this.buttonClose.Text = "Close";
			//
			// DealDetailDialog
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.CancelButton = this.buttonClose;
			this.ClientSize = new System.Drawing.Size(844, 529);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.panelHeader);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(700, 480);
			this.Name = "DealDetailDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Deal";
			this.FormClosed += new Wisej.Web.FormClosedEventHandler(this.DealDetailDialog_FormClosed);
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

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelStages;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.Label labelStage;
		private Wisej.Web.Label labelAmount;
		private Wisej.Web.LinkLabel linkCompany;
		private Wisej.Web.Label labelTitle;
		private Wisej.Web.ToolBar toolStrip;
		private Wisej.Web.ToolBarButton buttonEdit;
		private Wisej.Web.ToolBarButton buttonDelete;
		private Wisej.Web.ToolBarButton toolStripSeparator1;
		private Wisej.Web.ToolBarButton buttonLogActivity;
		private Wisej.Web.ToolBarButton buttonAddTask;
		private Wisej.Web.SplitContainer splitContainer;
		private Wisej.Web.GroupBox groupBoxContacts;
		private Wisej.Web.ListView listViewContacts;
		private Wisej.Web.ColumnHeader columnContactName;
		private Wisej.Web.ColumnHeader columnContactTitle;
		private Wisej.Web.Label labelNoContacts;
		private Wisej.Web.GroupBox groupBoxDetails;
		private Wisej.Web.TableLayoutPanel tableDetails;
		private Wisej.Web.Label labelCapAmount;
		private Wisej.Web.Label labelAmountValue;
		private Wisej.Web.Label labelCapClose;
		private Wisej.Web.Label labelCloseValue;
		private Wisej.Web.Label labelCapProbability;
		private Wisej.Web.Label labelProbabilityValue;
		private Wisej.Web.Label labelCapContact;
		private Wisej.Web.LinkLabel linkContact;
		private Wisej.Web.Label labelCapCreated;
		private Wisej.Web.Label labelCreatedValue;
		private Wisej.Web.Label labelCapClosed;
		private Wisej.Web.Label labelClosedValue;
		private Wisej.Web.Label labelCapLost;
		private Wisej.Web.Label labelLostValue;
		private Wisej.Web.TabControl tabControl;
		private Wisej.Web.TabPage tabPageActivity;
		private Wisej.Web.ListView listViewActivity;
		private Wisej.Web.ColumnHeader columnActivityDate;
		private Wisej.Web.ColumnHeader columnActivityType;
		private Wisej.Web.ColumnHeader columnActivitySubject;
		private Wisej.Web.ColumnHeader columnActivityUser;
		private Wisej.Web.ColumnHeader columnActivityNotes;
		private Wisej.Web.TabPage tabPageTasks;
		private Wisej.Web.ListView listViewTasks;
		private Wisej.Web.ColumnHeader columnTaskTitle;
		private Wisej.Web.ColumnHeader columnTaskDue;
		private Wisej.Web.ColumnHeader columnTaskPriority;
		private Wisej.Web.ColumnHeader columnTaskAssignee;
		private Wisej.Web.Panel panelButtons;
		private Wisej.Web.Button buttonClose;
	}
}
