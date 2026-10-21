namespace RelayCrm.Views
{
	partial class ContactDetailView
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
			this.linkBack = new Wisej.Web.LinkLabel();
			this.panelHeader = new Wisej.Web.Panel();
			this.panelInfo = new Wisej.Web.Panel();
			this.labelOwner = new Wisej.Web.Label();
			this.labelTitleAt = new Wisej.Web.FlowLayoutPanel();
			this.runTitleAt = new Wisej.Web.Label();
			this.linkCompany = new Wisej.Web.LinkLabel();
			this.flowName = new Wisej.Web.FlowLayoutPanel();
			this.runName = new Wisej.Web.Label();
			this.chipStage = new Wisej.Web.ChipLabel();
			this.flowActions = new Wisej.Web.FlowLayoutPanel();
			this.buttonLogActivity = new Wisej.Web.Button();
			this.buttonEdit = new Wisej.Web.Button();
			this.buttonNewDeal = new Wisej.Web.Button();
			this.buttonAddTask = new Wisej.Web.Button();
			this.buttonDelete = new Wisej.Web.Button();
			this.panelAvatar = new Wisej.Web.Panel();
			this.avatar = new Wisej.Web.Avatar();
			this.tabControl = new Wisej.Web.TabControl();
			this.tabOverview = new Wisej.Web.TabPage();
			this.tableOverview = new Wisej.Web.TableLayoutPanel();
			this.labelEmail = new Wisej.Web.Label();
			this.textBoxEmail = new Wisej.Web.TextBox();
			this.labelPhone = new Wisej.Web.Label();
			this.textBoxPhone = new Wisej.Web.TextBox();
			this.labelCompany = new Wisej.Web.Label();
			this.textBoxCompany = new Wisej.Web.TextBox();
			this.labelJobTitle = new Wisej.Web.Label();
			this.textBoxJobTitle = new Wisej.Web.TextBox();
			this.labelStage = new Wisej.Web.Label();
			this.textBoxStage = new Wisej.Web.TextBox();
			this.labelLeadSource = new Wisej.Web.Label();
			this.textBoxLeadSource = new Wisej.Web.TextBox();
			this.labelOwnerField = new Wisej.Web.Label();
			this.textBoxOwner = new Wisej.Web.TextBox();
			this.labelCreated = new Wisej.Web.Label();
			this.textBoxCreated = new Wisej.Web.TextBox();
			this.labelLastContacted = new Wisej.Web.Label();
			this.textBoxLastContacted = new Wisej.Web.TextBox();
			this.labelTags = new Wisej.Web.Label();
			this.textBoxTags = new Wisej.Web.TextBox();
			this.tabActivity = new Wisej.Web.TabPage();
			this.emptyActivity = new Wisej.Web.EmptyState();
			this.timelineActivity = new Wisej.Web.Timeline();
			this.tabDeals = new Wisej.Web.TabPage();
			this.emptyDeals = new Wisej.Web.EmptyState();
			this.listDeals = new Wisej.Web.ActionCardList();
			this.tabTasks = new Wisej.Web.TabPage();
			this.emptyTasks = new Wisej.Web.EmptyState();
			this.gridTasks = new Wisej.Web.DataGridView();
			this.colTaskTitle = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTaskDue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTaskPriority = new Wisej.Web.DataGridViewChipColumn();
			this.colTaskStatus = new Wisej.Web.DataGridViewChipColumn();
			this.colTaskAssignee = new Wisej.Web.DataGridViewAvatarColumn();
			this.panelHeader.SuspendLayout();
			this.panelInfo.SuspendLayout();
			this.labelTitleAt.SuspendLayout();
			this.flowName.SuspendLayout();
			this.flowActions.SuspendLayout();
			this.panelAvatar.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabOverview.SuspendLayout();
			this.tableOverview.SuspendLayout();
			this.tabActivity.SuspendLayout();
			this.tabDeals.SuspendLayout();
			this.tabTasks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
			this.SuspendLayout();
			//
			// linkBack
			//
			this.linkBack.Dock = Wisej.Web.DockStyle.Top;
			this.linkBack.Location = new System.Drawing.Point(16, 10);
			this.linkBack.Name = "linkBack";
			this.linkBack.Padding = new Wisej.Web.Padding(0, 0, 0, 8);
			this.linkBack.Size = new System.Drawing.Size(1058, 26);
			this.linkBack.TabIndex = 0;
			this.linkBack.TabStop = true;
			this.linkBack.Text = "◀ Back to contacts";
			this.linkBack.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.panelInfo);
			this.panelHeader.Controls.Add(this.flowActions);
			this.panelHeader.Controls.Add(this.panelAvatar);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(16, 36);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Padding = new Wisej.Web.Padding(0, 0, 0, 10);
			this.panelHeader.Size = new System.Drawing.Size(1058, 82);
			this.panelHeader.TabIndex = 1;
			//
			// panelInfo
			//
			this.panelInfo.Controls.Add(this.labelOwner);
			this.panelInfo.Controls.Add(this.labelTitleAt);
			this.panelInfo.Controls.Add(this.flowName);
			this.panelInfo.Dock = Wisej.Web.DockStyle.Fill;
			this.panelInfo.Location = new System.Drawing.Point(64, 0);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Size = new System.Drawing.Size(550, 72);
			this.panelInfo.TabIndex = 1;
			//
			// labelOwner
			//
			this.labelOwner.Dock = Wisej.Web.DockStyle.Top;
			this.labelOwner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelOwner.Location = new System.Drawing.Point(0, 52);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Padding = new Wisej.Web.Padding(0, 2, 0, 0);
			this.labelOwner.Size = new System.Drawing.Size(550, 20);
			this.labelOwner.TabIndex = 2;
			//
			// labelTitleAt
			//
			this.labelTitleAt.Controls.Add(this.runTitleAt);
			this.labelTitleAt.Controls.Add(this.linkCompany);
			this.labelTitleAt.Dock = Wisej.Web.DockStyle.Top;
			this.labelTitleAt.Location = new System.Drawing.Point(0, 30);
			this.labelTitleAt.Name = "labelTitleAt";
			this.labelTitleAt.Size = new System.Drawing.Size(550, 22);
			this.labelTitleAt.TabIndex = 1;
			this.labelTitleAt.TabStop = true;
			//
			// runTitleAt
			//
			this.runTitleAt.AutoSize = true;
			this.runTitleAt.Location = new System.Drawing.Point(0, 2);
			this.runTitleAt.Margin = new Wisej.Web.Padding(0, 2, 4, 0);
			this.runTitleAt.Name = "runTitleAt";
			this.runTitleAt.Size = new System.Drawing.Size(4, 16);
			this.runTitleAt.TabIndex = 0;
			//
			// linkCompany
			//
			this.linkCompany.AutoSize = true;
			this.linkCompany.Location = new System.Drawing.Point(8, 2);
			this.linkCompany.Margin = new Wisej.Web.Padding(0, 2, 0, 0);
			this.linkCompany.Name = "linkCompany";
			this.linkCompany.Size = new System.Drawing.Size(4, 16);
			this.linkCompany.TabIndex = 1;
			this.linkCompany.TabStop = true;
			this.linkCompany.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkCompany_LinkClicked);
			//
			// flowName
			//
			this.flowName.Controls.Add(this.runName);
			this.flowName.Controls.Add(this.chipStage);
			this.flowName.Dock = Wisej.Web.DockStyle.Top;
			this.flowName.Location = new System.Drawing.Point(0, 0);
			this.flowName.Name = "flowName";
			this.flowName.Size = new System.Drawing.Size(550, 30);
			this.flowName.TabIndex = 0;
			this.flowName.TabStop = true;
			//
			// runName
			//
			this.runName.AutoSize = true;
			this.runName.AppearanceKey = "relay-page-title";
			this.runName.Location = new System.Drawing.Point(0, 0);
			this.runName.Margin = new Wisej.Web.Padding(0);
			this.runName.Name = "runName";
			this.runName.Size = new System.Drawing.Size(4, 27);
			this.runName.TabIndex = 0;
			//
			// chipStage
			//
			this.chipStage.Location = new System.Drawing.Point(12, 4);
			this.chipStage.Margin = new Wisej.Web.Padding(10, 4, 0, 0);
			this.chipStage.Name = "chipStage";
			this.chipStage.ShowDot = true;
			this.chipStage.Size = new System.Drawing.Size(100, 24);
			this.chipStage.TabIndex = 1;
			this.chipStage.Variant = Wisej.Web.ChipVariant.Soft;
			//
			// flowActions
			//
			this.flowActions.Controls.Add(this.buttonLogActivity);
			this.flowActions.Controls.Add(this.buttonEdit);
			this.flowActions.Controls.Add(this.buttonNewDeal);
			this.flowActions.Controls.Add(this.buttonAddTask);
			this.flowActions.Controls.Add(this.buttonDelete);
			this.flowActions.Dock = Wisej.Web.DockStyle.Right;
			this.flowActions.Location = new System.Drawing.Point(614, 0);
			this.flowActions.Name = "flowActions";
			this.flowActions.Size = new System.Drawing.Size(600, 72);
			this.flowActions.TabIndex = 2;
			this.flowActions.TabStop = true;
			//
			// buttonLogActivity
			//
			this.buttonLogActivity.CssClass = "relay-primary";
			this.buttonLogActivity.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/journal-plus.svg";
			this.buttonLogActivity.Location = new System.Drawing.Point(0, 0);
			this.buttonLogActivity.Margin = new Wisej.Web.Padding(0, 0, 6, 0);
			this.buttonLogActivity.Name = "buttonLogActivity";
			this.buttonLogActivity.Size = new System.Drawing.Size(130, 34);
			this.buttonLogActivity.TabIndex = 0;
			this.buttonLogActivity.Text = "Log activity...";
			this.buttonLogActivity.Click += new System.EventHandler(this.buttonLogActivity_Click);
			//
			// buttonEdit
			//
			this.buttonEdit.CssClass = "relay-secondary";
			this.buttonEdit.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/pencil.svg";
			this.buttonEdit.Location = new System.Drawing.Point(106, 0);
			this.buttonEdit.Margin = new Wisej.Web.Padding(0, 0, 6, 0);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(90, 34);
			this.buttonEdit.TabIndex = 1;
			this.buttonEdit.Text = "Edit...";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			//
			// buttonNewDeal
			//
			this.buttonNewDeal.CssClass = "relay-secondary";
			this.buttonNewDeal.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/briefcase.svg";
			this.buttonNewDeal.Location = new System.Drawing.Point(182, 0);
			this.buttonNewDeal.Margin = new Wisej.Web.Padding(0, 0, 6, 0);
			this.buttonNewDeal.Name = "buttonNewDeal";
			this.buttonNewDeal.Size = new System.Drawing.Size(120, 34);
			this.buttonNewDeal.TabIndex = 2;
			this.buttonNewDeal.Text = "New deal...";
			this.buttonNewDeal.Click += new System.EventHandler(this.buttonNewDeal_Click);
			//
			// buttonAddTask
			//
			this.buttonAddTask.CssClass = "relay-secondary";
			this.buttonAddTask.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
			this.buttonAddTask.Location = new System.Drawing.Point(278, 0);
			this.buttonAddTask.Margin = new Wisej.Web.Padding(0, 0, 6, 0);
			this.buttonAddTask.Name = "buttonAddTask";
			this.buttonAddTask.Size = new System.Drawing.Size(120, 34);
			this.buttonAddTask.TabIndex = 3;
			this.buttonAddTask.Text = "Add task...";
			this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
			//
			// buttonDelete
			//
			this.buttonDelete.CssClass = "relay-secondary";
			this.buttonDelete.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			this.buttonDelete.Location = new System.Drawing.Point(374, 0);
			this.buttonDelete.Margin = new Wisej.Web.Padding(0);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(100, 34);
			this.buttonDelete.TabIndex = 4;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			//
			// panelAvatar
			//
			this.panelAvatar.Controls.Add(this.avatar);
			this.panelAvatar.Dock = Wisej.Web.DockStyle.Left;
			this.panelAvatar.Location = new System.Drawing.Point(0, 0);
			this.panelAvatar.Name = "panelAvatar";
			this.panelAvatar.Size = new System.Drawing.Size(64, 72);
			this.panelAvatar.TabIndex = 0;
			//
			// avatar
			//
			this.avatar.AvatarSize = 52;
			this.avatar.Location = new System.Drawing.Point(0, 0);
			this.avatar.Name = "avatar";
			this.avatar.Size = new System.Drawing.Size(52, 52);
			this.avatar.TabIndex = 0;
			this.avatar.Text = "?";
			//
			// tabControl
			//
			this.tabControl.Controls.Add(this.tabOverview);
			this.tabControl.Controls.Add(this.tabActivity);
			this.tabControl.Controls.Add(this.tabDeals);
			this.tabControl.Controls.Add(this.tabTasks);
			this.tabControl.Dock = Wisej.Web.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(16, 118);
			this.tabControl.Name = "tabControl";
			this.tabControl.Size = new System.Drawing.Size(1058, 598);
			this.tabControl.TabIndex = 2;
			//
			// tabOverview
			//
			this.tabOverview.AutoScroll = true;
			this.tabOverview.Controls.Add(this.tableOverview);
			this.tabOverview.Location = new System.Drawing.Point(1, 35);
			this.tabOverview.Name = "tabOverview";
			this.tabOverview.Size = new System.Drawing.Size(1056, 562);
			this.tabOverview.Text = "Overview";
			//
			// tableOverview
			//
			this.tableOverview.ColumnCount = 5;
			this.tableOverview.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
			this.tableOverview.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 260F));
			this.tableOverview.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 24F));
			this.tableOverview.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
			this.tableOverview.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 260F));
			this.tableOverview.Controls.Add(this.labelEmail, 0, 0);
			this.tableOverview.Controls.Add(this.textBoxEmail, 1, 0);
			this.tableOverview.Controls.Add(this.labelPhone, 3, 0);
			this.tableOverview.Controls.Add(this.textBoxPhone, 4, 0);
			this.tableOverview.Controls.Add(this.labelCompany, 0, 1);
			this.tableOverview.Controls.Add(this.textBoxCompany, 1, 1);
			this.tableOverview.Controls.Add(this.labelJobTitle, 3, 1);
			this.tableOverview.Controls.Add(this.textBoxJobTitle, 4, 1);
			this.tableOverview.Controls.Add(this.labelStage, 0, 2);
			this.tableOverview.Controls.Add(this.textBoxStage, 1, 2);
			this.tableOverview.Controls.Add(this.labelLeadSource, 3, 2);
			this.tableOverview.Controls.Add(this.textBoxLeadSource, 4, 2);
			this.tableOverview.Controls.Add(this.labelOwnerField, 0, 3);
			this.tableOverview.Controls.Add(this.textBoxOwner, 1, 3);
			this.tableOverview.Controls.Add(this.labelCreated, 3, 3);
			this.tableOverview.Controls.Add(this.textBoxCreated, 4, 3);
			this.tableOverview.Controls.Add(this.labelLastContacted, 0, 4);
			this.tableOverview.Controls.Add(this.textBoxLastContacted, 1, 4);
			this.tableOverview.Controls.Add(this.labelTags, 0, 5);
			this.tableOverview.Controls.Add(this.textBoxTags, 1, 5);
			this.tableOverview.Location = new System.Drawing.Point(10, 10);
			this.tableOverview.Name = "tableOverview";
			this.tableOverview.RowCount = 6;
			this.tableOverview.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableOverview.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableOverview.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableOverview.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableOverview.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableOverview.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableOverview.Size = new System.Drawing.Size(741, 228);
			this.tableOverview.TabIndex = 0;
			this.tableOverview.TabStop = true;
			//
			// labelEmail
			//
			this.labelEmail.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(3, 11);
			this.labelEmail.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(35, 16);
			this.labelEmail.TabIndex = 0;
			this.labelEmail.Text = "Email";
			//
			// textBoxEmail
			//
			this.textBoxEmail.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxEmail.Location = new System.Drawing.Point(107, 4);
			this.textBoxEmail.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.ReadOnly = true;
			this.textBoxEmail.Size = new System.Drawing.Size(260, 30);
			this.textBoxEmail.TabIndex = 1;
			//
			// labelPhone
			//
			this.labelPhone.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(391, 11);
			this.labelPhone.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(40, 16);
			this.labelPhone.TabIndex = 2;
			this.labelPhone.Text = "Phone";
			//
			// textBoxPhone
			//
			this.textBoxPhone.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxPhone.Location = new System.Drawing.Point(481, 4);
			this.textBoxPhone.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.ReadOnly = true;
			this.textBoxPhone.Size = new System.Drawing.Size(260, 30);
			this.textBoxPhone.TabIndex = 3;
			//
			// labelCompany
			//
			this.labelCompany.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelCompany.AutoSize = true;
			this.labelCompany.Location = new System.Drawing.Point(3, 49);
			this.labelCompany.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelCompany.Name = "labelCompany";
			this.labelCompany.Size = new System.Drawing.Size(57, 16);
			this.labelCompany.TabIndex = 4;
			this.labelCompany.Text = "Company";
			//
			// textBoxCompany
			//
			this.textBoxCompany.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxCompany.Location = new System.Drawing.Point(107, 42);
			this.textBoxCompany.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxCompany.Name = "textBoxCompany";
			this.textBoxCompany.ReadOnly = true;
			this.textBoxCompany.Size = new System.Drawing.Size(260, 30);
			this.textBoxCompany.TabIndex = 5;
			//
			// labelJobTitle
			//
			this.labelJobTitle.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelJobTitle.AutoSize = true;
			this.labelJobTitle.Location = new System.Drawing.Point(391, 49);
			this.labelJobTitle.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelJobTitle.Name = "labelJobTitle";
			this.labelJobTitle.Size = new System.Drawing.Size(51, 16);
			this.labelJobTitle.TabIndex = 6;
			this.labelJobTitle.Text = "Job title";
			//
			// textBoxJobTitle
			//
			this.textBoxJobTitle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxJobTitle.Location = new System.Drawing.Point(481, 42);
			this.textBoxJobTitle.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxJobTitle.Name = "textBoxJobTitle";
			this.textBoxJobTitle.ReadOnly = true;
			this.textBoxJobTitle.Size = new System.Drawing.Size(260, 30);
			this.textBoxJobTitle.TabIndex = 7;
			//
			// labelStage
			//
			this.labelStage.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelStage.AutoSize = true;
			this.labelStage.Location = new System.Drawing.Point(3, 87);
			this.labelStage.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelStage.Name = "labelStage";
			this.labelStage.Size = new System.Drawing.Size(92, 16);
			this.labelStage.TabIndex = 8;
			this.labelStage.Text = "Lifecycle stage";
			//
			// textBoxStage
			//
			this.textBoxStage.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxStage.Location = new System.Drawing.Point(107, 80);
			this.textBoxStage.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxStage.Name = "textBoxStage";
			this.textBoxStage.ReadOnly = true;
			this.textBoxStage.Size = new System.Drawing.Size(260, 30);
			this.textBoxStage.TabIndex = 9;
			//
			// labelLeadSource
			//
			this.labelLeadSource.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelLeadSource.AutoSize = true;
			this.labelLeadSource.Location = new System.Drawing.Point(391, 87);
			this.labelLeadSource.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelLeadSource.Name = "labelLeadSource";
			this.labelLeadSource.Size = new System.Drawing.Size(76, 16);
			this.labelLeadSource.TabIndex = 10;
			this.labelLeadSource.Text = "Lead source";
			//
			// textBoxLeadSource
			//
			this.textBoxLeadSource.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxLeadSource.Location = new System.Drawing.Point(481, 80);
			this.textBoxLeadSource.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxLeadSource.Name = "textBoxLeadSource";
			this.textBoxLeadSource.ReadOnly = true;
			this.textBoxLeadSource.Size = new System.Drawing.Size(260, 30);
			this.textBoxLeadSource.TabIndex = 11;
			//
			// labelOwnerField
			//
			this.labelOwnerField.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelOwnerField.AutoSize = true;
			this.labelOwnerField.Location = new System.Drawing.Point(3, 125);
			this.labelOwnerField.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelOwnerField.Name = "labelOwnerField";
			this.labelOwnerField.Size = new System.Drawing.Size(40, 16);
			this.labelOwnerField.TabIndex = 12;
			this.labelOwnerField.Text = "Owner";
			//
			// textBoxOwner
			//
			this.textBoxOwner.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxOwner.Location = new System.Drawing.Point(107, 118);
			this.textBoxOwner.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxOwner.Name = "textBoxOwner";
			this.textBoxOwner.ReadOnly = true;
			this.textBoxOwner.Size = new System.Drawing.Size(260, 30);
			this.textBoxOwner.TabIndex = 13;
			//
			// labelCreated
			//
			this.labelCreated.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelCreated.AutoSize = true;
			this.labelCreated.Location = new System.Drawing.Point(391, 125);
			this.labelCreated.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelCreated.Name = "labelCreated";
			this.labelCreated.Size = new System.Drawing.Size(49, 16);
			this.labelCreated.TabIndex = 14;
			this.labelCreated.Text = "Created";
			//
			// textBoxCreated
			//
			this.textBoxCreated.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxCreated.Location = new System.Drawing.Point(481, 118);
			this.textBoxCreated.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxCreated.Name = "textBoxCreated";
			this.textBoxCreated.ReadOnly = true;
			this.textBoxCreated.Size = new System.Drawing.Size(260, 30);
			this.textBoxCreated.TabIndex = 15;
			//
			// labelLastContacted
			//
			this.labelLastContacted.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelLastContacted.AutoSize = true;
			this.labelLastContacted.Location = new System.Drawing.Point(3, 163);
			this.labelLastContacted.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelLastContacted.Name = "labelLastContacted";
			this.labelLastContacted.Size = new System.Drawing.Size(91, 16);
			this.labelLastContacted.TabIndex = 16;
			this.labelLastContacted.Text = "Last contacted";
			//
			// textBoxLastContacted
			//
			this.textBoxLastContacted.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.tableOverview.SetColumnSpan(this.textBoxLastContacted, 4);
			this.textBoxLastContacted.Location = new System.Drawing.Point(107, 156);
			this.textBoxLastContacted.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxLastContacted.Name = "textBoxLastContacted";
			this.textBoxLastContacted.ReadOnly = true;
			this.textBoxLastContacted.Size = new System.Drawing.Size(634, 30);
			this.textBoxLastContacted.TabIndex = 17;
			//
			// labelTags
			//
			this.labelTags.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelTags.AutoSize = true;
			this.labelTags.Location = new System.Drawing.Point(3, 201);
			this.labelTags.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelTags.Name = "labelTags";
			this.labelTags.Size = new System.Drawing.Size(31, 16);
			this.labelTags.TabIndex = 18;
			this.labelTags.Text = "Tags";
			//
			// textBoxTags
			//
			this.textBoxTags.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.tableOverview.SetColumnSpan(this.textBoxTags, 4);
			this.textBoxTags.Location = new System.Drawing.Point(107, 194);
			this.textBoxTags.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxTags.Name = "textBoxTags";
			this.textBoxTags.ReadOnly = true;
			this.textBoxTags.Size = new System.Drawing.Size(634, 30);
			this.textBoxTags.TabIndex = 19;
			//
			// tabActivity
			//
			this.tabActivity.Controls.Add(this.emptyActivity);
			this.tabActivity.Controls.Add(this.timelineActivity);
			this.tabActivity.Location = new System.Drawing.Point(1, 35);
			this.tabActivity.Name = "tabActivity";
			this.tabActivity.Size = new System.Drawing.Size(1056, 562);
			this.tabActivity.Text = "Activity";
			//
			// emptyActivity
			//
			this.emptyActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyActivity.Description = "Log a call, an email or a meeting.";
			this.emptyActivity.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.emptyActivity.Location = new System.Drawing.Point(0, 0);
			this.emptyActivity.Name = "emptyActivity";
			this.emptyActivity.Size = new System.Drawing.Size(1056, 562);
			this.emptyActivity.TabIndex = 1;
			this.emptyActivity.Title = "No activities yet.";
			this.emptyActivity.Visible = false;
			//
			// timelineActivity
			//
			this.timelineActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.timelineActivity.HasMoreItems = false;
			this.timelineActivity.Grouping = Wisej.Web.TimelineGrouping.ByDay;
			this.timelineActivity.Location = new System.Drawing.Point(0, 0);
			this.timelineActivity.Name = "timelineActivity";
			this.timelineActivity.Padding = new Wisej.Web.Padding(12);
			this.timelineActivity.Size = new System.Drawing.Size(1056, 562);
			this.timelineActivity.TabIndex = 0;
			this.timelineActivity.TimeFormat = "HH:mm";
			//
			// tabDeals
			//
			this.tabDeals.Controls.Add(this.emptyDeals);
			this.tabDeals.Controls.Add(this.listDeals);
			this.tabDeals.Location = new System.Drawing.Point(1, 35);
			this.tabDeals.Name = "tabDeals";
			this.tabDeals.Size = new System.Drawing.Size(1056, 562);
			this.tabDeals.Text = "Deals";
			//
			// emptyDeals
			//
			this.emptyDeals.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyDeals.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/briefcase.svg";
			this.emptyDeals.Location = new System.Drawing.Point(0, 0);
			this.emptyDeals.Name = "emptyDeals";
			this.emptyDeals.Size = new System.Drawing.Size(1056, 562);
			this.emptyDeals.TabIndex = 1;
			this.emptyDeals.Title = "No deals with this contact as primary contact.";
			this.emptyDeals.Visible = false;
			//
			// listDeals
			//
			this.listDeals.Dock = Wisej.Web.DockStyle.Fill;
			this.listDeals.ItemHeight = 84;
			this.listDeals.ItemSpacing = 8;
			this.listDeals.Location = new System.Drawing.Point(0, 0);
			this.listDeals.Name = "listDeals";
			this.listDeals.Padding = new Wisej.Web.Padding(12);
			this.listDeals.Size = new System.Drawing.Size(1056, 562);
			this.listDeals.TabIndex = 0;
			this.listDeals.ToolTipText = "Click a deal to open it";
			this.listDeals.ItemClick += new System.EventHandler<Wisej.Web.ActionCardListItemEventArgs>(this.listDeals_ItemClick);
			//
			// tabTasks
			//
			this.tabTasks.Controls.Add(this.emptyTasks);
			this.tabTasks.Controls.Add(this.gridTasks);
			this.tabTasks.Location = new System.Drawing.Point(1, 35);
			this.tabTasks.Name = "tabTasks";
			this.tabTasks.Size = new System.Drawing.Size(1056, 562);
			this.tabTasks.Text = "Tasks";
			//
			// emptyTasks
			//
			this.emptyTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyTasks.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
			this.emptyTasks.Location = new System.Drawing.Point(0, 0);
			this.emptyTasks.Name = "emptyTasks";
			this.emptyTasks.Size = new System.Drawing.Size(1056, 562);
			this.emptyTasks.TabIndex = 1;
			this.emptyTasks.Title = "No tasks for this contact.";
			this.emptyTasks.Visible = false;
			//
			// gridTasks
			//
			this.gridTasks.AllowUserToResizeRows = false;
			this.gridTasks.AutoGenerateColumns = false;
			this.gridTasks.BorderStyle = Wisej.Web.BorderStyle.None;
			this.gridTasks.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colTaskTitle,
            this.colTaskDue,
            this.colTaskPriority,
            this.colTaskStatus,
            this.colTaskAssignee});
			this.gridTasks.CssClass = "relay-grid";
			this.gridTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.gridTasks.Location = new System.Drawing.Point(0, 0);
			this.gridTasks.MultiSelect = false;
			this.gridTasks.Name = "gridTasks";
			this.gridTasks.ReadOnly = true;
			this.gridTasks.RowHeadersVisible = false;
			this.gridTasks.RowTemplate.Height = 40;
			this.gridTasks.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.gridTasks.ShowColumnVisibilityMenu = false;
			this.gridTasks.Size = new System.Drawing.Size(1056, 562);
			this.gridTasks.TabIndex = 0;
			this.gridTasks.ToolTipText = "Double-click to edit the task";
			this.gridTasks.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.gridTasks_CellDoubleClick);
			//
			// colTaskTitle
			//
			this.colTaskTitle.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTaskTitle.DataPropertyName = "Title";
			this.colTaskTitle.FillWeight = 200F;
			this.colTaskTitle.HeaderText = "Task";
			this.colTaskTitle.Name = "colTaskTitle";
			//
			// colTaskDue
			//
			this.colTaskDue.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTaskDue.DataPropertyName = "Due";
			this.colTaskDue.FillWeight = 150F;
			this.colTaskDue.HeaderText = "Due";
			this.colTaskDue.Name = "colTaskDue";
			//
			// colTaskPriority
			//
			this.colTaskPriority.DataPropertyName = "Priority";
			this.colTaskPriority.HeaderText = "Priority";
			this.colTaskPriority.Name = "colTaskPriority";
			this.colTaskPriority.Width = 100;
			//
			// colTaskStatus
			//
			this.colTaskStatus.DataPropertyName = "Status";
			this.colTaskStatus.HeaderText = "Status";
			this.colTaskStatus.Name = "colTaskStatus";
			this.colTaskStatus.Width = 110;
			//
			// colTaskAssignee
			//
			this.colTaskAssignee.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTaskAssignee.DataPropertyName = "Assignee";
			this.colTaskAssignee.HeaderText = "Assignee";
			this.colTaskAssignee.Name = "colTaskAssignee";
			this.colTaskAssignee.AutoColor = true;
			this.colTaskAssignee.TextMember = "Assignee";
			//
			// ContactDetailView
			//
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.panelHeader);
			this.Controls.Add(this.linkBack);
			this.BackColor = System.Drawing.Color.White;
			this.CssClass = "relay-card";
			this.Name = "ContactDetailView";
			this.Padding = new Wisej.Web.Padding(16, 10, 16, 12);
			this.Size = new System.Drawing.Size(1090, 728);
			this.panelHeader.ResumeLayout(false);
			this.panelInfo.ResumeLayout(false);
			this.labelTitleAt.ResumeLayout(false);
			this.labelTitleAt.PerformLayout();
			this.flowName.ResumeLayout(false);
			this.flowName.PerformLayout();
			this.flowActions.ResumeLayout(false);
			this.panelAvatar.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabOverview.ResumeLayout(false);
			this.tableOverview.ResumeLayout(false);
			this.tableOverview.PerformLayout();
			this.tabActivity.ResumeLayout(false);
			this.tabDeals.ResumeLayout(false);
			this.tabTasks.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.LinkLabel linkBack;
		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Panel panelAvatar;
		private Wisej.Web.Avatar avatar;
		private Wisej.Web.FlowLayoutPanel flowActions;
		private Wisej.Web.Button buttonLogActivity;
		private Wisej.Web.Button buttonEdit;
		private Wisej.Web.Button buttonNewDeal;
		private Wisej.Web.Button buttonAddTask;
		private Wisej.Web.Button buttonDelete;
		private Wisej.Web.Panel panelInfo;
		private Wisej.Web.FlowLayoutPanel flowName;
		private Wisej.Web.Label runName;
		private Wisej.Web.ChipLabel chipStage;
		private Wisej.Web.FlowLayoutPanel labelTitleAt;
		private Wisej.Web.Label runTitleAt;
		private Wisej.Web.LinkLabel linkCompany;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.TabControl tabControl;
		private Wisej.Web.TabPage tabOverview;
		private Wisej.Web.TableLayoutPanel tableOverview;
		private Wisej.Web.Label labelEmail;
		private Wisej.Web.TextBox textBoxEmail;
		private Wisej.Web.Label labelPhone;
		private Wisej.Web.TextBox textBoxPhone;
		private Wisej.Web.Label labelCompany;
		private Wisej.Web.TextBox textBoxCompany;
		private Wisej.Web.Label labelJobTitle;
		private Wisej.Web.TextBox textBoxJobTitle;
		private Wisej.Web.Label labelStage;
		private Wisej.Web.TextBox textBoxStage;
		private Wisej.Web.Label labelLeadSource;
		private Wisej.Web.TextBox textBoxLeadSource;
		private Wisej.Web.Label labelOwnerField;
		private Wisej.Web.TextBox textBoxOwner;
		private Wisej.Web.Label labelCreated;
		private Wisej.Web.TextBox textBoxCreated;
		private Wisej.Web.Label labelLastContacted;
		private Wisej.Web.TextBox textBoxLastContacted;
		private Wisej.Web.Label labelTags;
		private Wisej.Web.TextBox textBoxTags;
		private Wisej.Web.TabPage tabActivity;
		private Wisej.Web.Timeline timelineActivity;
		private Wisej.Web.EmptyState emptyActivity;
		private Wisej.Web.TabPage tabDeals;
		private Wisej.Web.ActionCardList listDeals;
		private Wisej.Web.EmptyState emptyDeals;
		private Wisej.Web.TabPage tabTasks;
		private Wisej.Web.DataGridView gridTasks;
		private Wisej.Web.DataGridViewTextBoxColumn colTaskTitle;
		private Wisej.Web.DataGridViewTextBoxColumn colTaskDue;
		private Wisej.Web.DataGridViewChipColumn colTaskPriority;
		private Wisej.Web.DataGridViewChipColumn colTaskStatus;
		private Wisej.Web.DataGridViewAvatarColumn colTaskAssignee;
		private Wisej.Web.EmptyState emptyTasks;
	}
}
