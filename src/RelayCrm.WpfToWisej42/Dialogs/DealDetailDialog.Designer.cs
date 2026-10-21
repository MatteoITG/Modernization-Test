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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panelHeader = new Wisej.Web.Panel();
			this.flowHeaderLine = new Wisej.Web.FlowLayoutPanel();
			this.linkCompany = new Wisej.Web.LinkLabel();
			this.labelSeparator1 = new Wisej.Web.Label();
			this.runAmount = new Wisej.Web.Label();
			this.labelSeparator2 = new Wisej.Web.Label();
			this.chipStage = new Wisej.Web.ChipLabel();
			this.labelOwnerCaption = new Wisej.Web.Label();
			this.runOwner = new Wisej.Web.Label();
			this.labelTitle = new Wisej.Web.Label();
			this.stepperStages = new Wisej.Web.Stepper();
			this.panelButtons = new Wisej.Web.Panel();
			this.flowActions = new Wisej.Web.FlowLayoutPanel();
			this.buttonEdit = new Wisej.Web.Button();
			this.buttonLogActivity = new Wisej.Web.Button();
			this.buttonAddTask = new Wisej.Web.Button();
			this.buttonDelete = new Wisej.Web.Button();
			this.buttonClose = new Wisej.Web.Button();
			this.tableBody = new Wisej.Web.TableLayoutPanel();
			this.groupDetails = new Wisej.Web.GroupBox();
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
			this.groupContacts = new Wisej.Web.GroupBox();
			this.emptyContacts = new Wisej.Web.EmptyState();
			this.listContacts = new Wisej.Web.ActionCardList();
			this.tabControl = new Wisej.Web.TabControl();
			this.tabActivity = new Wisej.Web.TabPage();
			this.emptyActivity = new Wisej.Web.EmptyState();
			this.timelineActivity = new Wisej.Web.Timeline();
			this.tabTasks = new Wisej.Web.TabPage();
			this.emptyTasks = new Wisej.Web.EmptyState();
			this.listTasks = new Wisej.Web.ActionCardList();
			this.panelHeader.SuspendLayout();
			this.flowHeaderLine.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.flowActions.SuspendLayout();
			this.tableBody.SuspendLayout();
			this.groupDetails.SuspendLayout();
			this.tableDetails.SuspendLayout();
			this.groupContacts.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabActivity.SuspendLayout();
			this.tabTasks.SuspendLayout();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.flowHeaderLine);
			this.panelHeader.Controls.Add(this.labelTitle);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(12, 12);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(780, 60);
			this.panelHeader.TabIndex = 0;
			//
			// flowHeaderLine
			//
			this.flowHeaderLine.Controls.Add(this.linkCompany);
			this.flowHeaderLine.Controls.Add(this.labelSeparator1);
			this.flowHeaderLine.Controls.Add(this.runAmount);
			this.flowHeaderLine.Controls.Add(this.labelSeparator2);
			this.flowHeaderLine.Controls.Add(this.chipStage);
			this.flowHeaderLine.Controls.Add(this.labelOwnerCaption);
			this.flowHeaderLine.Controls.Add(this.runOwner);
			this.flowHeaderLine.Dock = Wisej.Web.DockStyle.Top;
			this.flowHeaderLine.Location = new System.Drawing.Point(0, 32);
			this.flowHeaderLine.Name = "flowHeaderLine";
			this.flowHeaderLine.Padding = new Wisej.Web.Padding(0, 4, 0, 0);
			this.flowHeaderLine.Size = new System.Drawing.Size(780, 26);
			this.flowHeaderLine.TabIndex = 1;
			this.flowHeaderLine.TabStop = true;
			//
			// linkCompany
			//
			this.linkCompany.AutoSize = true;
			this.linkCompany.Location = new System.Drawing.Point(0, 4);
			this.linkCompany.Margin = new Wisej.Web.Padding(0);
			this.linkCompany.Name = "linkCompany";
			this.linkCompany.Size = new System.Drawing.Size(66, 16);
			this.linkCompany.TabIndex = 0;
			this.linkCompany.TabStop = true;
			this.linkCompany.Text = "Company";
			this.linkCompany.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkCompany_LinkClicked);
			//
			// labelSeparator1
			//
			this.labelSeparator1.AutoSize = true;
			this.labelSeparator1.Location = new System.Drawing.Point(66, 4);
			this.labelSeparator1.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
			this.labelSeparator1.Name = "labelSeparator1";
			this.labelSeparator1.Size = new System.Drawing.Size(8, 16);
			this.labelSeparator1.TabIndex = 1;
			this.labelSeparator1.Text = "·";
			//
			// runAmount
			//
			this.runAmount.AutoSize = true;
			this.runAmount.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.runAmount.Location = new System.Drawing.Point(82, 4);
			this.runAmount.Margin = new Wisej.Web.Padding(0);
			this.runAmount.Name = "runAmount";
			this.runAmount.Size = new System.Drawing.Size(60, 17);
			this.runAmount.TabIndex = 2;
			//
			// labelSeparator2
			//
			this.labelSeparator2.AutoSize = true;
			this.labelSeparator2.Location = new System.Drawing.Point(146, 4);
			this.labelSeparator2.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
			this.labelSeparator2.Name = "labelSeparator2";
			this.labelSeparator2.Size = new System.Drawing.Size(8, 16);
			this.labelSeparator2.TabIndex = 3;
			this.labelSeparator2.Text = "·";
			//
			// chipStage
			//
			this.chipStage.Location = new System.Drawing.Point(162, 0);
			this.chipStage.Margin = new Wisej.Web.Padding(0);
			this.chipStage.Name = "chipStage";
			this.chipStage.ShowDot = true;
			this.chipStage.Size = new System.Drawing.Size(110, 22);
			this.chipStage.TabIndex = 4;
			this.chipStage.Variant = Wisej.Web.ChipVariant.Soft;
			//
			// labelOwnerCaption
			//
			this.labelOwnerCaption.AutoSize = true;
			this.labelOwnerCaption.Location = new System.Drawing.Point(226, 4);
			this.labelOwnerCaption.Margin = new Wisej.Web.Padding(4, 0, 4, 0);
			this.labelOwnerCaption.Name = "labelOwnerCaption";
			this.labelOwnerCaption.Size = new System.Drawing.Size(56, 16);
			this.labelOwnerCaption.TabIndex = 5;
			this.labelOwnerCaption.Text = "· Owner:";
			//
			// runOwner
			//
			this.runOwner.AutoSize = true;
			this.runOwner.Location = new System.Drawing.Point(286, 4);
			this.runOwner.Margin = new Wisej.Web.Padding(0);
			this.runOwner.Name = "runOwner";
			this.runOwner.Size = new System.Drawing.Size(60, 16);
			this.runOwner.TabIndex = 6;
			//
			// labelTitle
			//
			this.labelTitle.AutoEllipsis = true;
			this.labelTitle.Dock = Wisej.Web.DockStyle.Top;
			this.labelTitle.AppearanceKey = "relay-page-title";
			this.labelTitle.Location = new System.Drawing.Point(0, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(780, 32);
			this.labelTitle.TabIndex = 0;
			//
			// stepperStages
			//
			this.stepperStages.AllowStepClick = false;
			this.stepperStages.Dock = Wisej.Web.DockStyle.Top;
			this.stepperStages.Location = new System.Drawing.Point(12, 72);
			this.stepperStages.Name = "stepperStages";
			this.stepperStages.Padding = new Wisej.Web.Padding(0, 8, 0, 8);
			this.stepperStages.Size = new System.Drawing.Size(780, 80);
			this.stepperStages.TabIndex = 1;
			//
			// panelButtons
			//
			this.panelButtons.Controls.Add(this.flowActions);
			this.panelButtons.Controls.Add(this.buttonClose);
			this.panelButtons.Dock = Wisej.Web.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(12, 549);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Padding = new Wisej.Web.Padding(0, 10, 0, 0);
			this.panelButtons.Size = new System.Drawing.Size(780, 44);
			this.panelButtons.TabIndex = 3;
			//
			// flowActions
			//
			this.flowActions.Controls.Add(this.buttonEdit);
			this.flowActions.Controls.Add(this.buttonLogActivity);
			this.flowActions.Controls.Add(this.buttonAddTask);
			this.flowActions.Controls.Add(this.buttonDelete);
			this.flowActions.Dock = Wisej.Web.DockStyle.Fill;
			this.flowActions.Location = new System.Drawing.Point(0, 10);
			this.flowActions.Name = "flowActions";
			this.flowActions.Size = new System.Drawing.Size(692, 30);
			this.flowActions.TabIndex = 0;
			this.flowActions.TabStop = true;
			//
			// buttonEdit
			//
			this.buttonEdit.CssClass = "relay-primary";
			this.buttonEdit.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/pencil.svg";
			this.buttonEdit.Location = new System.Drawing.Point(0, 0);
			this.buttonEdit.Margin = new Wisej.Web.Padding(0, 0, 8, 0);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(108, 32);
			this.buttonEdit.TabIndex = 0;
			this.buttonEdit.Text = "Edit...";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			//
			// buttonLogActivity
			//
			this.buttonLogActivity.CssClass = "relay-secondary";
			this.buttonLogActivity.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/journal-plus.svg";
			this.buttonLogActivity.Location = new System.Drawing.Point(96, 0);
			this.buttonLogActivity.Margin = new Wisej.Web.Padding(0, 0, 8, 0);
			this.buttonLogActivity.Name = "buttonLogActivity";
			this.buttonLogActivity.Size = new System.Drawing.Size(130, 32);
			this.buttonLogActivity.TabIndex = 1;
			this.buttonLogActivity.Text = "Log activity...";
			this.buttonLogActivity.Click += new System.EventHandler(this.buttonLogActivity_Click);
			//
			// buttonAddTask
			//
			this.buttonAddTask.CssClass = "relay-secondary";
			this.buttonAddTask.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
			this.buttonAddTask.Location = new System.Drawing.Point(214, 0);
			this.buttonAddTask.Margin = new Wisej.Web.Padding(0, 0, 8, 0);
			this.buttonAddTask.Name = "buttonAddTask";
			this.buttonAddTask.Size = new System.Drawing.Size(116, 32);
			this.buttonAddTask.TabIndex = 2;
			this.buttonAddTask.Text = "Add task...";
			this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
			//
			// buttonDelete
			//
			this.buttonDelete.CssClass = "relay-secondary";
			this.buttonDelete.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			this.buttonDelete.Location = new System.Drawing.Point(318, 0);
			this.buttonDelete.Margin = new Wisej.Web.Padding(0);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(108, 32);
			this.buttonDelete.TabIndex = 3;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			//
			// buttonClose
			//
			this.buttonClose.CssClass = "relay-secondary";
			this.buttonClose.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonClose.Dock = Wisej.Web.DockStyle.Right;
			this.buttonClose.Location = new System.Drawing.Point(692, 10);
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.Size = new System.Drawing.Size(88, 32);
			this.buttonClose.TabIndex = 1;
			this.buttonClose.Text = "Close";
			this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
			//
			// tableBody
			//
			this.tableBody.ColumnCount = 2;
			this.tableBody.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableBody.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableBody.Controls.Add(this.groupDetails, 0, 0);
			this.tableBody.Controls.Add(this.groupContacts, 1, 0);
			this.tableBody.Controls.Add(this.tabControl, 0, 1);
			this.tableBody.Dock = Wisej.Web.DockStyle.Fill;
			this.tableBody.Location = new System.Drawing.Point(12, 136);
			this.tableBody.Name = "tableBody";
			this.tableBody.RowCount = 2;
			this.tableBody.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 200F));
			this.tableBody.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableBody.Size = new System.Drawing.Size(780, 413);
			this.tableBody.TabIndex = 2;
			this.tableBody.TabStop = true;
			//
			// groupDetails
			//
			this.groupDetails.Controls.Add(this.tableDetails);
			this.groupDetails.CssClass = "relay-card";
			this.groupDetails.Dock = Wisej.Web.DockStyle.Fill;
			this.groupDetails.Location = new System.Drawing.Point(0, 0);
			this.groupDetails.Margin = new Wisej.Web.Padding(0, 0, 4, 8);
			this.groupDetails.Name = "groupDetails";
			this.groupDetails.Padding = new Wisej.Web.Padding(8, 4, 8, 4);
			this.groupDetails.Size = new System.Drawing.Size(386, 192);
			this.groupDetails.TabIndex = 0;
			this.groupDetails.Text = "Details";
			//
			// tableDetails
			//
			this.tableDetails.ColumnCount = 2;
			this.tableDetails.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
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
			this.tableDetails.Location = new System.Drawing.Point(8, 23);
			this.tableDetails.Name = "tableDetails";
			this.tableDetails.RowCount = 7;
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 22F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 22F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 22F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 22F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 22F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 22F));
			this.tableDetails.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 22F));
			this.tableDetails.Size = new System.Drawing.Size(370, 165);
			this.tableDetails.TabIndex = 0;
			this.tableDetails.TabStop = true;
			//
			// labelCapAmount
			//
			this.labelCapAmount.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelCapAmount.AutoSize = true;
			this.labelCapAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelCapAmount.Location = new System.Drawing.Point(0, 3);
			this.labelCapAmount.Margin = new Wisej.Web.Padding(0, 0, 16, 0);
			this.labelCapAmount.Name = "labelCapAmount";
			this.labelCapAmount.Size = new System.Drawing.Size(50, 16);
			this.labelCapAmount.TabIndex = 0;
			this.labelCapAmount.Text = "Amount";
			//
			// labelAmountValue
			//
			this.labelAmountValue.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.labelAmountValue.AutoEllipsis = true;
			this.labelAmountValue.Location = new System.Drawing.Point(114, 3);
			this.labelAmountValue.Margin = new Wisej.Web.Padding(0);
			this.labelAmountValue.Name = "labelAmountValue";
			this.labelAmountValue.Size = new System.Drawing.Size(256, 16);
			this.labelAmountValue.TabIndex = 1;
			//
			// labelCapClose
			//
			this.labelCapClose.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelCapClose.AutoSize = true;
			this.labelCapClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelCapClose.Location = new System.Drawing.Point(0, 25);
			this.labelCapClose.Margin = new Wisej.Web.Padding(0, 0, 16, 0);
			this.labelCapClose.Name = "labelCapClose";
			this.labelCapClose.Size = new System.Drawing.Size(94, 16);
			this.labelCapClose.TabIndex = 2;
			this.labelCapClose.Text = "Expected close";
			//
			// labelCloseValue
			//
			this.labelCloseValue.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.labelCloseValue.AutoEllipsis = true;
			this.labelCloseValue.Location = new System.Drawing.Point(114, 25);
			this.labelCloseValue.Margin = new Wisej.Web.Padding(0);
			this.labelCloseValue.Name = "labelCloseValue";
			this.labelCloseValue.Size = new System.Drawing.Size(256, 16);
			this.labelCloseValue.TabIndex = 3;
			//
			// labelCapProbability
			//
			this.labelCapProbability.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelCapProbability.AutoSize = true;
			this.labelCapProbability.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelCapProbability.Location = new System.Drawing.Point(0, 47);
			this.labelCapProbability.Margin = new Wisej.Web.Padding(0, 0, 16, 0);
			this.labelCapProbability.Name = "labelCapProbability";
			this.labelCapProbability.Size = new System.Drawing.Size(70, 16);
			this.labelCapProbability.TabIndex = 4;
			this.labelCapProbability.Text = "Probability";
			//
			// labelProbabilityValue
			//
			this.labelProbabilityValue.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.labelProbabilityValue.AutoEllipsis = true;
			this.labelProbabilityValue.Location = new System.Drawing.Point(114, 47);
			this.labelProbabilityValue.Margin = new Wisej.Web.Padding(0);
			this.labelProbabilityValue.Name = "labelProbabilityValue";
			this.labelProbabilityValue.Size = new System.Drawing.Size(256, 16);
			this.labelProbabilityValue.TabIndex = 5;
			//
			// labelCapContact
			//
			this.labelCapContact.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelCapContact.AutoSize = true;
			this.labelCapContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelCapContact.Location = new System.Drawing.Point(0, 69);
			this.labelCapContact.Margin = new Wisej.Web.Padding(0, 0, 16, 0);
			this.labelCapContact.Name = "labelCapContact";
			this.labelCapContact.Size = new System.Drawing.Size(98, 16);
			this.labelCapContact.TabIndex = 6;
			this.labelCapContact.Text = "Primary contact";
			//
			// linkContact
			//
			this.linkContact.Anchor = Wisej.Web.AnchorStyles.Left;
			this.linkContact.AutoSize = true;
			this.linkContact.Location = new System.Drawing.Point(114, 69);
			this.linkContact.Margin = new Wisej.Web.Padding(0);
			this.linkContact.Name = "linkContact";
			this.linkContact.Size = new System.Drawing.Size(48, 16);
			this.linkContact.TabIndex = 7;
			this.linkContact.TabStop = true;
			this.linkContact.Text = "Contact";
			this.linkContact.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkContact_LinkClicked);
			//
			// labelCapCreated
			//
			this.labelCapCreated.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelCapCreated.AutoSize = true;
			this.labelCapCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelCapCreated.Location = new System.Drawing.Point(0, 91);
			this.labelCapCreated.Margin = new Wisej.Web.Padding(0, 0, 16, 0);
			this.labelCapCreated.Name = "labelCapCreated";
			this.labelCapCreated.Size = new System.Drawing.Size(52, 16);
			this.labelCapCreated.TabIndex = 8;
			this.labelCapCreated.Text = "Created";
			//
			// labelCreatedValue
			//
			this.labelCreatedValue.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.labelCreatedValue.AutoEllipsis = true;
			this.labelCreatedValue.Location = new System.Drawing.Point(114, 91);
			this.labelCreatedValue.Margin = new Wisej.Web.Padding(0);
			this.labelCreatedValue.Name = "labelCreatedValue";
			this.labelCreatedValue.Size = new System.Drawing.Size(256, 16);
			this.labelCreatedValue.TabIndex = 9;
			//
			// labelCapClosed
			//
			this.labelCapClosed.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelCapClosed.AutoSize = true;
			this.labelCapClosed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelCapClosed.Location = new System.Drawing.Point(0, 113);
			this.labelCapClosed.Margin = new Wisej.Web.Padding(0, 0, 16, 0);
			this.labelCapClosed.Name = "labelCapClosed";
			this.labelCapClosed.Size = new System.Drawing.Size(46, 16);
			this.labelCapClosed.TabIndex = 10;
			this.labelCapClosed.Text = "Closed";
			//
			// labelClosedValue
			//
			this.labelClosedValue.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.labelClosedValue.AutoEllipsis = true;
			this.labelClosedValue.Location = new System.Drawing.Point(114, 113);
			this.labelClosedValue.Margin = new Wisej.Web.Padding(0);
			this.labelClosedValue.Name = "labelClosedValue";
			this.labelClosedValue.Size = new System.Drawing.Size(256, 16);
			this.labelClosedValue.TabIndex = 11;
			//
			// labelCapLost
			//
			this.labelCapLost.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelCapLost.AutoSize = true;
			this.labelCapLost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelCapLost.Location = new System.Drawing.Point(0, 135);
			this.labelCapLost.Margin = new Wisej.Web.Padding(0, 0, 16, 0);
			this.labelCapLost.Name = "labelCapLost";
			this.labelCapLost.Size = new System.Drawing.Size(74, 16);
			this.labelCapLost.TabIndex = 12;
			this.labelCapLost.Text = "Lost reason";
			//
			// labelLostValue
			//
			this.labelLostValue.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.labelLostValue.AutoEllipsis = true;
			this.labelLostValue.Location = new System.Drawing.Point(114, 135);
			this.labelLostValue.Margin = new Wisej.Web.Padding(0);
			this.labelLostValue.Name = "labelLostValue";
			this.labelLostValue.Size = new System.Drawing.Size(256, 16);
			this.labelLostValue.TabIndex = 13;
			//
			// groupContacts
			//
			this.groupContacts.Controls.Add(this.emptyContacts);
			this.groupContacts.Controls.Add(this.listContacts);
			this.groupContacts.CssClass = "relay-card";
			this.groupContacts.Dock = Wisej.Web.DockStyle.Fill;
			this.groupContacts.Location = new System.Drawing.Point(394, 0);
			this.groupContacts.Margin = new Wisej.Web.Padding(4, 0, 0, 8);
			this.groupContacts.Name = "groupContacts";
			this.groupContacts.Padding = new Wisej.Web.Padding(6);
			this.groupContacts.Size = new System.Drawing.Size(386, 192);
			this.groupContacts.TabIndex = 1;
			this.groupContacts.Text = "Contacts";
			//
			// emptyContacts
			//
			this.emptyContacts.Compact = true;
			this.emptyContacts.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyContacts.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/person.svg";
			this.emptyContacts.Location = new System.Drawing.Point(6, 25);
			this.emptyContacts.Name = "emptyContacts";
			this.emptyContacts.Size = new System.Drawing.Size(374, 161);
			this.emptyContacts.TabIndex = 1;
			this.emptyContacts.Title = "No contacts at this company.";
			this.emptyContacts.Visible = false;
			//
			// listContacts
			//
			this.listContacts.Dock = Wisej.Web.DockStyle.Fill;
			this.listContacts.ItemHeight = 64;
			this.listContacts.ItemSpacing = 6;
			this.listContacts.Location = new System.Drawing.Point(6, 25);
			this.listContacts.Name = "listContacts";
			this.listContacts.Size = new System.Drawing.Size(374, 161);
			this.listContacts.TabIndex = 0;
			this.listContacts.ToolTipText = "Click a contact to open it";
			this.listContacts.ItemClick += new System.EventHandler<Wisej.Web.ActionCardListItemEventArgs>(this.listContacts_ItemClick);
			//
			// tabControl
			//
			this.tableBody.SetColumnSpan(this.tabControl, 2);
			this.tabControl.Controls.Add(this.tabActivity);
			this.tabControl.Controls.Add(this.tabTasks);
			this.tabControl.Dock = Wisej.Web.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 200);
			this.tabControl.Margin = new Wisej.Web.Padding(0);
			this.tabControl.Name = "tabControl";
			this.tabControl.Size = new System.Drawing.Size(780, 213);
			this.tabControl.TabIndex = 2;
			//
			// tabActivity
			//
			this.tabActivity.Controls.Add(this.emptyActivity);
			this.tabActivity.Controls.Add(this.timelineActivity);
			this.tabActivity.Location = new System.Drawing.Point(1, 35);
			this.tabActivity.Name = "tabActivity";
			this.tabActivity.Size = new System.Drawing.Size(778, 177);
			this.tabActivity.Text = "Activity";
			//
			// emptyActivity
			//
			this.emptyActivity.Compact = true;
			this.emptyActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyActivity.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.emptyActivity.Location = new System.Drawing.Point(0, 0);
			this.emptyActivity.Name = "emptyActivity";
			this.emptyActivity.Size = new System.Drawing.Size(778, 177);
			this.emptyActivity.TabIndex = 1;
			this.emptyActivity.Title = "No activities logged for this deal yet.";
			this.emptyActivity.Visible = false;
			//
			// timelineActivity
			//
			this.timelineActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.timelineActivity.HasMoreItems = false;
			this.timelineActivity.Location = new System.Drawing.Point(0, 0);
			this.timelineActivity.Name = "timelineActivity";
			this.timelineActivity.Padding = new Wisej.Web.Padding(8);
			this.timelineActivity.Size = new System.Drawing.Size(778, 177);
			this.timelineActivity.TabIndex = 0;
			this.timelineActivity.TimeFormat = "MMM d, HH:mm";
			//
			// tabTasks
			//
			this.tabTasks.Controls.Add(this.emptyTasks);
			this.tabTasks.Controls.Add(this.listTasks);
			this.tabTasks.Location = new System.Drawing.Point(1, 35);
			this.tabTasks.Name = "tabTasks";
			this.tabTasks.Size = new System.Drawing.Size(778, 177);
			this.tabTasks.Text = "Tasks";
			//
			// emptyTasks
			//
			this.emptyTasks.Compact = true;
			this.emptyTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyTasks.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
			this.emptyTasks.Location = new System.Drawing.Point(0, 0);
			this.emptyTasks.Name = "emptyTasks";
			this.emptyTasks.Size = new System.Drawing.Size(778, 177);
			this.emptyTasks.TabIndex = 1;
			this.emptyTasks.Title = "No tasks for this deal.";
			this.emptyTasks.Visible = false;
			//
			// listTasks
			//
			this.listTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.listTasks.ItemHeight = 72;
			this.listTasks.ItemSpacing = 6;
			this.listTasks.Location = new System.Drawing.Point(0, 0);
			this.listTasks.Name = "listTasks";
			this.listTasks.Padding = new Wisej.Web.Padding(8);
			this.listTasks.Size = new System.Drawing.Size(778, 177);
			this.listTasks.TabIndex = 0;
			this.listTasks.ToolTipText = "Click a task to edit it";
			this.listTasks.ItemClick += new System.EventHandler<Wisej.Web.ActionCardListItemEventArgs>(this.listTasks_ItemClick);
			//
			// DealDetailDialog
			//
			this.CancelButton = this.buttonClose;
			this.ClientSize = new System.Drawing.Size(804, 640);
			this.Controls.Add(this.tableBody);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.stepperStages);
			this.Controls.Add(this.panelHeader);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(640, 480);
			this.Name = "DealDetailDialog";
			this.Padding = new Wisej.Web.Padding(12);
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Deal";
			this.panelHeader.ResumeLayout(false);
			this.flowHeaderLine.ResumeLayout(false);
			this.flowHeaderLine.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.flowActions.ResumeLayout(false);
			this.tableBody.ResumeLayout(false);
			this.groupDetails.ResumeLayout(false);
			this.tableDetails.ResumeLayout(false);
			this.tableDetails.PerformLayout();
			this.groupContacts.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabActivity.ResumeLayout(false);
			this.tabTasks.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelTitle;
		private Wisej.Web.FlowLayoutPanel flowHeaderLine;
		private Wisej.Web.LinkLabel linkCompany;
		private Wisej.Web.Label labelSeparator1;
		private Wisej.Web.Label runAmount;
		private Wisej.Web.Label labelSeparator2;
		private Wisej.Web.ChipLabel chipStage;
		private Wisej.Web.Label labelOwnerCaption;
		private Wisej.Web.Label runOwner;
		private Wisej.Web.Stepper stepperStages;
		private Wisej.Web.Panel panelButtons;
		private Wisej.Web.FlowLayoutPanel flowActions;
		private Wisej.Web.Button buttonEdit;
		private Wisej.Web.Button buttonLogActivity;
		private Wisej.Web.Button buttonAddTask;
		private Wisej.Web.Button buttonDelete;
		private Wisej.Web.Button buttonClose;
		private Wisej.Web.TableLayoutPanel tableBody;
		private Wisej.Web.GroupBox groupDetails;
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
		private Wisej.Web.GroupBox groupContacts;
		private Wisej.Web.ActionCardList listContacts;
		private Wisej.Web.EmptyState emptyContacts;
		private Wisej.Web.TabControl tabControl;
		private Wisej.Web.TabPage tabActivity;
		private Wisej.Web.Timeline timelineActivity;
		private Wisej.Web.EmptyState emptyActivity;
		private Wisej.Web.TabPage tabTasks;
		private Wisej.Web.ActionCardList listTasks;
		private Wisej.Web.EmptyState emptyTasks;
	}
}
