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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl = new Wisej.Web.TabControl();
			this.toolStrip = new Wisej.Web.ToolBar();
			this.buttonLogActivity = new Wisej.Web.ToolBarButton();
			this.buttonEdit = new Wisej.Web.ToolBarButton();
			this.buttonNewDeal = new Wisej.Web.ToolBarButton();
			this.buttonAddTask = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator1 = new Wisej.Web.ToolBarButton();
			this.buttonDelete = new Wisej.Web.ToolBarButton();
			this.panelHeader = new Wisej.Web.Panel();
			this.linkBack = new Wisej.Web.LinkLabel();
			this.pictureAvatar = new Wisej.Web.PictureBox();
			this.labelName = new Wisej.Web.Label();
			this.flowSubtitle = new Wisej.Web.FlowLayoutPanel();
			this.labelTitleAt = new Wisej.Web.Label();
			this.linkCompany = new Wisej.Web.LinkLabel();
			this.labelDot1 = new Wisej.Web.Label();
			this.labelStage = new Wisej.Web.Label();
			this.labelDot2 = new Wisej.Web.Label();
			this.labelOwner = new Wisej.Web.Label();
			this.tabPageOverview = new Wisej.Web.TabPage();
			this.labelCapEmail = new Wisej.Web.Label();
			this.textBoxEmail = new Wisej.Web.TextBox();
			this.labelCapPhone = new Wisej.Web.Label();
			this.textBoxPhone = new Wisej.Web.TextBox();
			this.labelCapCompany = new Wisej.Web.Label();
			this.textBoxCompany = new Wisej.Web.TextBox();
			this.labelCapJobTitle = new Wisej.Web.Label();
			this.textBoxJobTitle = new Wisej.Web.TextBox();
			this.labelCapStage = new Wisej.Web.Label();
			this.textBoxStage = new Wisej.Web.TextBox();
			this.labelCapLeadSource = new Wisej.Web.Label();
			this.textBoxLeadSource = new Wisej.Web.TextBox();
			this.labelCapOwner = new Wisej.Web.Label();
			this.textBoxOwner = new Wisej.Web.TextBox();
			this.labelCapLastContacted = new Wisej.Web.Label();
			this.textBoxLastContacted = new Wisej.Web.TextBox();
			this.labelCapCreated = new Wisej.Web.Label();
			this.textBoxCreated = new Wisej.Web.TextBox();
			this.labelCapTags = new Wisej.Web.Label();
			this.textBoxTags = new Wisej.Web.TextBox();
			this.buttonEditOverview = new Wisej.Web.Button();
			this.tabPageActivity = new Wisej.Web.TabPage();
			this.labelNoActivity = new Wisej.Web.Label();
			this.listViewActivity = new Wisej.Web.ListView();
			this.columnActivityDate = new Wisej.Web.ColumnHeader();
			this.columnActivityType = new Wisej.Web.ColumnHeader();
			this.columnActivitySubject = new Wisej.Web.ColumnHeader();
			this.columnActivityDuration = new Wisej.Web.ColumnHeader();
			this.columnActivityUser = new Wisej.Web.ColumnHeader();
			this.columnActivityNotes = new Wisej.Web.ColumnHeader();
			this.activityStrip = new Wisej.Web.ToolBar();
			this.buttonLogActivityTab = new Wisej.Web.ToolBarButton();
			this.tabPageDeals = new Wisej.Web.TabPage();
			this.labelNoDeals = new Wisej.Web.Label();
			this.listViewDeals = new Wisej.Web.ListView();
			this.columnDealTitle = new Wisej.Web.ColumnHeader();
			this.columnDealStage = new Wisej.Web.ColumnHeader();
			this.columnDealDescription = new Wisej.Web.ColumnHeader();
			this.columnDealMeta = new Wisej.Web.ColumnHeader();
			this.dealsStrip = new Wisej.Web.ToolBar();
			this.buttonNewDealTab = new Wisej.Web.ToolBarButton();
			this.tabPageTasks = new Wisej.Web.TabPage();
			this.labelNoTasks = new Wisej.Web.Label();
			this.gridTasks = new Wisej.Web.DataGridView();
			this.colTaskTitle = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTaskDue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTaskPriority = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTaskAssignee = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTaskStatus = new Wisej.Web.DataGridViewTextBoxColumn();
			this.tasksStrip = new Wisej.Web.ToolBar();
			this.buttonAddTaskTab = new Wisej.Web.ToolBarButton();
			this.tabControl.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).BeginInit();
			this.flowSubtitle.SuspendLayout();
			this.tabPageOverview.SuspendLayout();
			this.tabPageActivity.SuspendLayout();
			this.activityStrip.SuspendLayout();
			this.tabPageDeals.SuspendLayout();
			this.dealsStrip.SuspendLayout();
			this.tabPageTasks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
			this.tasksStrip.SuspendLayout();
			this.SuspendLayout();
			//
			// tabControl
			//
			this.tabControl.Controls.Add(this.tabPageOverview);
			this.tabControl.Controls.Add(this.tabPageActivity);
			this.tabControl.Controls.Add(this.tabPageDeals);
			this.tabControl.Controls.Add(this.tabPageTasks);
			this.tabControl.Dock = Wisej.Web.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 117);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1000, 483);
			this.tabControl.TabIndex = 2;
			//
			// toolStrip
			//
			this.toolStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonLogActivity,
			this.buttonEdit,
			this.buttonNewDeal,
			this.buttonAddTask,
			this.toolStripSeparator1,
			this.buttonDelete});
			this.toolStrip.Location = new System.Drawing.Point(0, 92);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new Wisej.Web.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(800, 27);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			//
			// buttonLogActivity
			//
			this.buttonLogActivity.Tag = "journal-plus";
			this.buttonLogActivity.Name = "buttonLogActivity";
			this.buttonLogActivity.Text = "Log activity...";
			this.buttonLogActivity.Click += new System.EventHandler(this.buttonLogActivity_Click);
			//
			// buttonEdit
			//
			this.buttonEdit.Tag = "pencil";
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Text = "Edit...";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			//
			// buttonNewDeal
			//
			this.buttonNewDeal.Tag = "briefcase";
			this.buttonNewDeal.Name = "buttonNewDeal";
			this.buttonNewDeal.Text = "New deal...";
			this.buttonNewDeal.Click += new System.EventHandler(this.buttonNewDeal_Click);
			//
			// buttonAddTask
			//
			this.buttonAddTask.Tag = "check2-square";
			this.buttonAddTask.Name = "buttonAddTask";
			this.buttonAddTask.Text = "Add task...";
			this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// buttonDelete
			//
			this.buttonDelete.Tag = "trash";
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.linkBack);
			this.panelHeader.Controls.Add(this.pictureAvatar);
			this.panelHeader.Controls.Add(this.labelName);
			this.panelHeader.Controls.Add(this.flowSubtitle);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1000, 92);
			this.panelHeader.TabIndex = 0;
			//
			// linkBack
			//
			this.linkBack.AutoSize = true;
			this.linkBack.Location = new System.Drawing.Point(12, 6);
			this.linkBack.Name = "linkBack";
			this.linkBack.Size = new System.Drawing.Size(120, 15);
			this.linkBack.TabIndex = 0;
			this.linkBack.TabStop = true;
			this.linkBack.Text = "‹ Back to contacts";
			this.linkBack.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
			//
			// pictureAvatar
			//
			this.pictureAvatar.Location = new System.Drawing.Point(12, 28);
			this.pictureAvatar.Name = "pictureAvatar";
			this.pictureAvatar.Size = new System.Drawing.Size(52, 52);
			this.pictureAvatar.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			this.pictureAvatar.TabIndex = 1;
			this.pictureAvatar.TabStop = false;
			//
			// labelName
			//
			this.labelName.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.labelName.AutoEllipsis = true;
			this.labelName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.labelName.Location = new System.Drawing.Point(72, 26);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(900, 30);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "Name";
			//
			// flowSubtitle
			//
			this.flowSubtitle.Controls.Add(this.labelTitleAt);
			this.flowSubtitle.Controls.Add(this.linkCompany);
			this.flowSubtitle.Controls.Add(this.labelDot1);
			this.flowSubtitle.Controls.Add(this.labelStage);
			this.flowSubtitle.Controls.Add(this.labelDot2);
			this.flowSubtitle.Controls.Add(this.labelOwner);
			this.flowSubtitle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.flowSubtitle.Location = new System.Drawing.Point(74, 58);
			this.flowSubtitle.Name = "flowSubtitle";
			this.flowSubtitle.Size = new System.Drawing.Size(900, 24);
			this.flowSubtitle.TabIndex = 3;
			this.flowSubtitle.WrapContents = false;
			//
			// labelTitleAt
			//
			this.labelTitleAt.AutoSize = true;
			this.labelTitleAt.Margin = new Wisej.Web.Padding(0, 3, 4, 0);
			this.labelTitleAt.Name = "labelTitleAt";
			this.labelTitleAt.Size = new System.Drawing.Size(56, 15);
			this.labelTitleAt.Text = "Title at";
			//
			// linkCompany
			//
			this.linkCompany.AutoSize = true;
			this.linkCompany.Margin = new Wisej.Web.Padding(0, 3, 4, 0);
			this.linkCompany.Name = "linkCompany";
			this.linkCompany.Size = new System.Drawing.Size(49, 15);
			this.linkCompany.Text = "Company";
			this.linkCompany.TabStop = true;
			this.linkCompany.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkCompany_LinkClicked);
			//
			// labelDot1
			//
			this.labelDot1.AutoSize = true;
			this.labelDot1.Margin = new Wisej.Web.Padding(0, 3, 4, 0);
			this.labelDot1.Name = "labelDot1";
			this.labelDot1.Size = new System.Drawing.Size(7, 15);
			this.labelDot1.Text = "·";
			this.labelDot1.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// labelStage
			//
			this.labelStage.AutoSize = true;
			this.labelStage.Margin = new Wisej.Web.Padding(0, 3, 4, 0);
			this.labelStage.Name = "labelStage";
			this.labelStage.Size = new System.Drawing.Size(28, 15);
			this.labelStage.Text = "Lead";
			this.labelStage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			//
			// labelDot2
			//
			this.labelDot2.AutoSize = true;
			this.labelDot2.Margin = new Wisej.Web.Padding(0, 3, 4, 0);
			this.labelDot2.Name = "labelDot2";
			this.labelDot2.Size = new System.Drawing.Size(7, 15);
			this.labelDot2.Text = "·";
			this.labelDot2.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// labelOwner
			//
			this.labelOwner.AutoSize = true;
			this.labelOwner.Margin = new Wisej.Web.Padding(0, 3, 4, 0);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Size = new System.Drawing.Size(35, 15);
			this.labelOwner.Text = "Owner";
			this.labelOwner.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// tabPageOverview
			//
			this.tabPageOverview.Controls.Add(this.labelCapEmail);
			this.tabPageOverview.Controls.Add(this.textBoxEmail);
			this.tabPageOverview.Controls.Add(this.labelCapPhone);
			this.tabPageOverview.Controls.Add(this.textBoxPhone);
			this.tabPageOverview.Controls.Add(this.labelCapCompany);
			this.tabPageOverview.Controls.Add(this.textBoxCompany);
			this.tabPageOverview.Controls.Add(this.labelCapJobTitle);
			this.tabPageOverview.Controls.Add(this.textBoxJobTitle);
			this.tabPageOverview.Controls.Add(this.labelCapStage);
			this.tabPageOverview.Controls.Add(this.textBoxStage);
			this.tabPageOverview.Controls.Add(this.labelCapLeadSource);
			this.tabPageOverview.Controls.Add(this.textBoxLeadSource);
			this.tabPageOverview.Controls.Add(this.labelCapOwner);
			this.tabPageOverview.Controls.Add(this.textBoxOwner);
			this.tabPageOverview.Controls.Add(this.labelCapLastContacted);
			this.tabPageOverview.Controls.Add(this.textBoxLastContacted);
			this.tabPageOverview.Controls.Add(this.labelCapCreated);
			this.tabPageOverview.Controls.Add(this.textBoxCreated);
			this.tabPageOverview.Controls.Add(this.labelCapTags);
			this.tabPageOverview.Controls.Add(this.textBoxTags);
			this.tabPageOverview.Controls.Add(this.buttonEditOverview);
			this.tabPageOverview.Location = new System.Drawing.Point(4, 24);
			this.tabPageOverview.Name = "tabPageOverview";
			this.tabPageOverview.Padding = new Wisej.Web.Padding(3);
			this.tabPageOverview.Size = new System.Drawing.Size(992, 440);
			this.tabPageOverview.TabIndex = 0;
			this.tabPageOverview.Text = "Overview";
			//
			// labelCapEmail
			//
			this.labelCapEmail.AutoSize = true;
			this.labelCapEmail.Location = new System.Drawing.Point(16, 19);
			this.labelCapEmail.Name = "labelCapEmail";
			this.labelCapEmail.Size = new System.Drawing.Size(35, 15);
			this.labelCapEmail.Text = "Email";
			this.labelCapEmail.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxEmail
			//
			this.textBoxEmail.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxEmail.Location = new System.Drawing.Point(126, 16);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.ReadOnly = true;
			this.textBoxEmail.Size = new System.Drawing.Size(280, 23);
			this.textBoxEmail.TabIndex = 0;
			//
			// labelCapPhone
			//
			this.labelCapPhone.AutoSize = true;
			this.labelCapPhone.Location = new System.Drawing.Point(16, 51);
			this.labelCapPhone.Name = "labelCapPhone";
			this.labelCapPhone.Size = new System.Drawing.Size(35, 15);
			this.labelCapPhone.Text = "Phone";
			this.labelCapPhone.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxPhone
			//
			this.textBoxPhone.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxPhone.Location = new System.Drawing.Point(126, 48);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.ReadOnly = true;
			this.textBoxPhone.Size = new System.Drawing.Size(280, 23);
			this.textBoxPhone.TabIndex = 0;
			//
			// labelCapCompany
			//
			this.labelCapCompany.AutoSize = true;
			this.labelCapCompany.Location = new System.Drawing.Point(16, 83);
			this.labelCapCompany.Name = "labelCapCompany";
			this.labelCapCompany.Size = new System.Drawing.Size(49, 15);
			this.labelCapCompany.Text = "Company";
			this.labelCapCompany.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxCompany
			//
			this.textBoxCompany.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxCompany.Location = new System.Drawing.Point(126, 80);
			this.textBoxCompany.Name = "textBoxCompany";
			this.textBoxCompany.ReadOnly = true;
			this.textBoxCompany.Size = new System.Drawing.Size(280, 23);
			this.textBoxCompany.TabIndex = 0;
			//
			// labelCapJobTitle
			//
			this.labelCapJobTitle.AutoSize = true;
			this.labelCapJobTitle.Location = new System.Drawing.Point(16, 115);
			this.labelCapJobTitle.Name = "labelCapJobTitle";
			this.labelCapJobTitle.Size = new System.Drawing.Size(63, 15);
			this.labelCapJobTitle.Text = "Job title";
			this.labelCapJobTitle.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxJobTitle
			//
			this.textBoxJobTitle.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxJobTitle.Location = new System.Drawing.Point(126, 112);
			this.textBoxJobTitle.Name = "textBoxJobTitle";
			this.textBoxJobTitle.ReadOnly = true;
			this.textBoxJobTitle.Size = new System.Drawing.Size(280, 23);
			this.textBoxJobTitle.TabIndex = 0;
			//
			// labelCapStage
			//
			this.labelCapStage.AutoSize = true;
			this.labelCapStage.Location = new System.Drawing.Point(16, 147);
			this.labelCapStage.Name = "labelCapStage";
			this.labelCapStage.Size = new System.Drawing.Size(105, 15);
			this.labelCapStage.Text = "Lifecycle stage";
			this.labelCapStage.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxStage
			//
			this.textBoxStage.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxStage.Location = new System.Drawing.Point(126, 144);
			this.textBoxStage.Name = "textBoxStage";
			this.textBoxStage.ReadOnly = true;
			this.textBoxStage.Size = new System.Drawing.Size(280, 23);
			this.textBoxStage.TabIndex = 0;
			//
			// labelCapLeadSource
			//
			this.labelCapLeadSource.AutoSize = true;
			this.labelCapLeadSource.Location = new System.Drawing.Point(440, 19);
			this.labelCapLeadSource.Name = "labelCapLeadSource";
			this.labelCapLeadSource.Size = new System.Drawing.Size(77, 15);
			this.labelCapLeadSource.Text = "Lead source";
			this.labelCapLeadSource.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxLeadSource
			//
			this.textBoxLeadSource.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxLeadSource.Location = new System.Drawing.Point(550, 16);
			this.textBoxLeadSource.Name = "textBoxLeadSource";
			this.textBoxLeadSource.ReadOnly = true;
			this.textBoxLeadSource.Size = new System.Drawing.Size(280, 23);
			this.textBoxLeadSource.TabIndex = 0;
			//
			// labelCapOwner
			//
			this.labelCapOwner.AutoSize = true;
			this.labelCapOwner.Location = new System.Drawing.Point(440, 51);
			this.labelCapOwner.Name = "labelCapOwner";
			this.labelCapOwner.Size = new System.Drawing.Size(35, 15);
			this.labelCapOwner.Text = "Owner";
			this.labelCapOwner.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxOwner
			//
			this.textBoxOwner.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxOwner.Location = new System.Drawing.Point(550, 48);
			this.textBoxOwner.Name = "textBoxOwner";
			this.textBoxOwner.ReadOnly = true;
			this.textBoxOwner.Size = new System.Drawing.Size(280, 23);
			this.textBoxOwner.TabIndex = 0;
			//
			// labelCapLastContacted
			//
			this.labelCapLastContacted.AutoSize = true;
			this.labelCapLastContacted.Location = new System.Drawing.Point(440, 83);
			this.labelCapLastContacted.Name = "labelCapLastContacted";
			this.labelCapLastContacted.Size = new System.Drawing.Size(98, 15);
			this.labelCapLastContacted.Text = "Last contacted";
			this.labelCapLastContacted.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxLastContacted
			//
			this.textBoxLastContacted.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxLastContacted.Location = new System.Drawing.Point(550, 80);
			this.textBoxLastContacted.Name = "textBoxLastContacted";
			this.textBoxLastContacted.ReadOnly = true;
			this.textBoxLastContacted.Size = new System.Drawing.Size(280, 23);
			this.textBoxLastContacted.TabIndex = 0;
			//
			// labelCapCreated
			//
			this.labelCapCreated.AutoSize = true;
			this.labelCapCreated.Location = new System.Drawing.Point(440, 115);
			this.labelCapCreated.Name = "labelCapCreated";
			this.labelCapCreated.Size = new System.Drawing.Size(49, 15);
			this.labelCapCreated.Text = "Created";
			this.labelCapCreated.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxCreated
			//
			this.textBoxCreated.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxCreated.Location = new System.Drawing.Point(550, 112);
			this.textBoxCreated.Name = "textBoxCreated";
			this.textBoxCreated.ReadOnly = true;
			this.textBoxCreated.Size = new System.Drawing.Size(280, 23);
			this.textBoxCreated.TabIndex = 0;
			//
			// labelCapTags
			//
			this.labelCapTags.AutoSize = true;
			this.labelCapTags.Location = new System.Drawing.Point(16, 179);
			this.labelCapTags.Name = "labelCapTags";
			this.labelCapTags.Size = new System.Drawing.Size(28, 15);
			this.labelCapTags.Text = "Tags";
			this.labelCapTags.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxTags
			//
			this.textBoxTags.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxTags.Location = new System.Drawing.Point(126, 176);
			this.textBoxTags.Name = "textBoxTags";
			this.textBoxTags.ReadOnly = true;
			this.textBoxTags.Size = new System.Drawing.Size(704, 23);
			this.textBoxTags.TabIndex = 0;
			//
			// buttonEditOverview
			//
			this.buttonEditOverview.Location = new System.Drawing.Point(126, 212);
			this.buttonEditOverview.Name = "buttonEditOverview";
			this.buttonEditOverview.Size = new System.Drawing.Size(110, 27);
			this.buttonEditOverview.TabIndex = 20;
			this.buttonEditOverview.Text = "Edit details...";
			this.buttonEditOverview.Click += new System.EventHandler(this.buttonEdit_Click);
			//
			// tabPageActivity
			//
			this.tabPageActivity.Controls.Add(this.labelNoActivity);
			this.tabPageActivity.Controls.Add(this.listViewActivity);
			this.tabPageActivity.Controls.Add(this.activityStrip);
			this.tabPageActivity.Location = new System.Drawing.Point(4, 24);
			this.tabPageActivity.Name = "tabPageActivity";
			this.tabPageActivity.Padding = new Wisej.Web.Padding(3);
			this.tabPageActivity.Size = new System.Drawing.Size(992, 440);
			this.tabPageActivity.TabIndex = 0;
			this.tabPageActivity.Text = "Activity";
			//
			// labelNoActivity
			//
			this.labelNoActivity.BackColor = System.Drawing.SystemColors.Window;
			this.labelNoActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.labelNoActivity.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelNoActivity.Location = new System.Drawing.Point(3, 30);
			this.labelNoActivity.Name = "labelNoActivity";
			this.labelNoActivity.Size = new System.Drawing.Size(900, 400);
			this.labelNoActivity.TabIndex = 2;
			this.labelNoActivity.Text = "No activity yet. Log a call, an email, a meeting or a note.";
			this.labelNoActivity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelNoActivity.Visible = false;
			//
			// listViewActivity
			//
			this.listViewActivity.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
			this.columnActivityDate,
			this.columnActivityType,
			this.columnActivitySubject,
			this.columnActivityDuration,
			this.columnActivityUser,
			this.columnActivityNotes});
			this.listViewActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.listViewActivity.Location = new System.Drawing.Point(3, 30);
			this.listViewActivity.MultiSelect = false;
			this.listViewActivity.Name = "listViewActivity";
			this.listViewActivity.ShowItemToolTips = true;
			this.listViewActivity.Size = new System.Drawing.Size(900, 400);
			this.listViewActivity.TabIndex = 1;
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
			this.columnActivityType.Width = 70;
			//
			// columnActivitySubject
			//
			this.columnActivitySubject.Text = "Subject";
			this.columnActivitySubject.Width = 220;
			//
			// columnActivityDuration
			//
			this.columnActivityDuration.Text = "Duration";
			this.columnActivityDuration.TextAlign = Wisej.Web.HorizontalAlignment.Right;
			this.columnActivityDuration.Width = 70;
			//
			// columnActivityUser
			//
			this.columnActivityUser.Text = "By";
			this.columnActivityUser.Width = 120;
			//
			// columnActivityNotes
			//
			this.columnActivityNotes.Text = "Notes";
			this.columnActivityNotes.Width = 360;
			//
			// activityStrip
			//
			this.activityStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonLogActivityTab});
			this.activityStrip.Location = new System.Drawing.Point(0, 0);
			this.activityStrip.Name = "activityStrip";
			this.activityStrip.Padding = new Wisej.Web.Padding(2, 2, 2, 2);
			this.activityStrip.Size = new System.Drawing.Size(800, 27);
			this.activityStrip.TabIndex = 0;
			this.activityStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.activityStrip.BackColor = System.Drawing.SystemColors.Window;
			//
			// buttonLogActivityTab
			//
			this.buttonLogActivityTab.Tag = "journal-plus";
			this.buttonLogActivityTab.Name = "buttonLogActivityTab";
			this.buttonLogActivityTab.Text = "Log activity...";
			this.buttonLogActivityTab.Click += new System.EventHandler(this.buttonLogActivity_Click);
			//
			// tabPageDeals
			//
			this.tabPageDeals.Controls.Add(this.labelNoDeals);
			this.tabPageDeals.Controls.Add(this.listViewDeals);
			this.tabPageDeals.Controls.Add(this.dealsStrip);
			this.tabPageDeals.Location = new System.Drawing.Point(4, 24);
			this.tabPageDeals.Name = "tabPageDeals";
			this.tabPageDeals.Padding = new Wisej.Web.Padding(3);
			this.tabPageDeals.Size = new System.Drawing.Size(992, 440);
			this.tabPageDeals.TabIndex = 0;
			this.tabPageDeals.Text = "Deals";
			//
			// labelNoDeals
			//
			this.labelNoDeals.BackColor = System.Drawing.SystemColors.Window;
			this.labelNoDeals.Dock = Wisej.Web.DockStyle.Fill;
			this.labelNoDeals.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelNoDeals.Location = new System.Drawing.Point(3, 30);
			this.labelNoDeals.Name = "labelNoDeals";
			this.labelNoDeals.Size = new System.Drawing.Size(900, 400);
			this.labelNoDeals.TabIndex = 2;
			this.labelNoDeals.Text = "No deals yet.";
			this.labelNoDeals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelNoDeals.Visible = false;
			//
			// listViewDeals
			//
			this.listViewDeals.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
			this.columnDealTitle,
			this.columnDealStage,
			this.columnDealDescription,
			this.columnDealMeta});
			this.listViewDeals.Dock = Wisej.Web.DockStyle.Fill;
			this.listViewDeals.Location = new System.Drawing.Point(3, 30);
			this.listViewDeals.MultiSelect = false;
			this.listViewDeals.Name = "listViewDeals";
			this.listViewDeals.ShowItemToolTips = true;
			this.listViewDeals.Size = new System.Drawing.Size(900, 400);
			this.listViewDeals.TabIndex = 1;
			this.listViewDeals.View = Wisej.Web.View.Details;
			this.listViewDeals.ItemDoubleClick += new Wisej.Web.ItemClickEventHandler(this.listViewDeals_ItemActivate);
			//
			// columnDealTitle
			//
			this.columnDealTitle.Text = "Deal";
			this.columnDealTitle.Width = 260;
			//
			// columnDealStage
			//
			this.columnDealStage.Text = "Stage";
			this.columnDealStage.Width = 110;
			//
			// columnDealDescription
			//
			this.columnDealDescription.Text = "Amount and company";
			this.columnDealDescription.Width = 260;
			//
			// columnDealMeta
			//
			this.columnDealMeta.Text = "Close";
			this.columnDealMeta.Width = 200;
			//
			// dealsStrip
			//
			this.dealsStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonNewDealTab});
			this.dealsStrip.Location = new System.Drawing.Point(0, 0);
			this.dealsStrip.Name = "dealsStrip";
			this.dealsStrip.Padding = new Wisej.Web.Padding(2, 2, 2, 2);
			this.dealsStrip.Size = new System.Drawing.Size(800, 27);
			this.dealsStrip.TabIndex = 0;
			this.dealsStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.dealsStrip.BackColor = System.Drawing.SystemColors.Window;
			//
			// buttonNewDealTab
			//
			this.buttonNewDealTab.Tag = "briefcase";
			this.buttonNewDealTab.Name = "buttonNewDealTab";
			this.buttonNewDealTab.Text = "New deal...";
			this.buttonNewDealTab.Click += new System.EventHandler(this.buttonNewDeal_Click);
			//
			// tabPageTasks
			//
			this.tabPageTasks.Controls.Add(this.labelNoTasks);
			this.tabPageTasks.Controls.Add(this.gridTasks);
			this.tabPageTasks.Controls.Add(this.tasksStrip);
			this.tabPageTasks.Location = new System.Drawing.Point(4, 24);
			this.tabPageTasks.Name = "tabPageTasks";
			this.tabPageTasks.Padding = new Wisej.Web.Padding(3);
			this.tabPageTasks.Size = new System.Drawing.Size(992, 440);
			this.tabPageTasks.TabIndex = 0;
			this.tabPageTasks.Text = "Tasks";
			//
			// labelNoTasks
			//
			this.labelNoTasks.BackColor = System.Drawing.SystemColors.Window;
			this.labelNoTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.labelNoTasks.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelNoTasks.Location = new System.Drawing.Point(3, 30);
			this.labelNoTasks.Name = "labelNoTasks";
			this.labelNoTasks.Size = new System.Drawing.Size(900, 400);
			this.labelNoTasks.TabIndex = 2;
			this.labelNoTasks.Text = "No tasks.";
			this.labelNoTasks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelNoTasks.Visible = false;
			//
			// gridTasks
			//
			this.gridTasks.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colTaskTitle,
			this.colTaskDue,
			this.colTaskPriority,
			this.colTaskAssignee,
			this.colTaskStatus});
			this.gridTasks.AllowUserToAddRows = false;
			this.gridTasks.AllowUserToDeleteRows = false;
			this.gridTasks.AllowUserToResizeRows = false;
			this.gridTasks.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.gridTasks.Location = new System.Drawing.Point(3, 30);
			this.gridTasks.MultiSelect = false;
			this.gridTasks.Name = "gridTasks";
			this.gridTasks.ReadOnly = true;
			this.gridTasks.RowHeadersVisible = false;
			this.gridTasks.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.gridTasks.Size = new System.Drawing.Size(400, 200);
			this.gridTasks.TabIndex = 1;
			this.gridTasks.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.gridTasks_CellDoubleClick);
			this.gridTasks.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.gridTasks_CellFormatting);
			//
			// colTaskTitle
			//
			this.colTaskTitle.DataPropertyName = "Title";
			this.colTaskTitle.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTaskTitle.MinimumWidth = 200;
			this.colTaskTitle.HeaderText = "Task";
			this.colTaskTitle.Name = "colTaskTitle";
			//
			// colTaskDue
			//
			this.colTaskDue.DataPropertyName = "Due";
			this.colTaskDue.HeaderText = "Due";
			this.colTaskDue.Name = "colTaskDue";
			this.colTaskDue.Width = 200;
			//
			// colTaskPriority
			//
			this.colTaskPriority.DataPropertyName = "Priority";
			this.colTaskPriority.HeaderText = "Priority";
			this.colTaskPriority.Name = "colTaskPriority";
			this.colTaskPriority.Width = 80;
			//
			// colTaskAssignee
			//
			this.colTaskAssignee.DataPropertyName = "Assignee";
			this.colTaskAssignee.HeaderText = "Assignee";
			this.colTaskAssignee.Name = "colTaskAssignee";
			this.colTaskAssignee.Width = 140;
			//
			// colTaskStatus
			//
			this.colTaskStatus.DataPropertyName = "Status";
			this.colTaskStatus.HeaderText = "Status";
			this.colTaskStatus.Name = "colTaskStatus";
			this.colTaskStatus.Width = 90;
			//
			// tasksStrip
			//
			this.tasksStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonAddTaskTab});
			this.tasksStrip.Location = new System.Drawing.Point(0, 0);
			this.tasksStrip.Name = "tasksStrip";
			this.tasksStrip.Padding = new Wisej.Web.Padding(2, 2, 2, 2);
			this.tasksStrip.Size = new System.Drawing.Size(800, 27);
			this.tasksStrip.TabIndex = 0;
			this.tasksStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.tasksStrip.BackColor = System.Drawing.SystemColors.Window;
			//
			// buttonAddTaskTab
			//
			this.buttonAddTaskTab.Tag = "check2-square";
			this.buttonAddTaskTab.Name = "buttonAddTaskTab";
			this.buttonAddTaskTab.Text = "Add task...";
			this.buttonAddTaskTab.Click += new System.EventHandler(this.buttonAddTask_Click);
			//
			// ContactDetailView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.panelHeader);
			this.Name = "ContactDetailView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.tasksStrip.ResumeLayout(false);
			this.tasksStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
			this.tabPageTasks.ResumeLayout(false);
			this.tabPageTasks.PerformLayout();
			this.dealsStrip.ResumeLayout(false);
			this.dealsStrip.PerformLayout();
			this.tabPageDeals.ResumeLayout(false);
			this.tabPageDeals.PerformLayout();
			this.activityStrip.ResumeLayout(false);
			this.activityStrip.PerformLayout();
			this.tabPageActivity.ResumeLayout(false);
			this.tabPageActivity.PerformLayout();
			this.tabPageOverview.ResumeLayout(false);
			this.tabPageOverview.PerformLayout();
			this.flowSubtitle.ResumeLayout(false);
			this.flowSubtitle.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureAvatar)).EndInit();
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.TabControl tabControl;
		private Wisej.Web.ToolBar toolStrip;
		private Wisej.Web.ToolBarButton buttonLogActivity;
		private Wisej.Web.ToolBarButton buttonEdit;
		private Wisej.Web.ToolBarButton buttonNewDeal;
		private Wisej.Web.ToolBarButton buttonAddTask;
		private Wisej.Web.ToolBarButton toolStripSeparator1;
		private Wisej.Web.ToolBarButton buttonDelete;
		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.LinkLabel linkBack;
		private Wisej.Web.PictureBox pictureAvatar;
		private Wisej.Web.Label labelName;
		private Wisej.Web.FlowLayoutPanel flowSubtitle;
		private Wisej.Web.Label labelTitleAt;
		private Wisej.Web.LinkLabel linkCompany;
		private Wisej.Web.Label labelDot1;
		private Wisej.Web.Label labelStage;
		private Wisej.Web.Label labelDot2;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.TabPage tabPageOverview;
		private Wisej.Web.Label labelCapEmail;
		private Wisej.Web.TextBox textBoxEmail;
		private Wisej.Web.Label labelCapPhone;
		private Wisej.Web.TextBox textBoxPhone;
		private Wisej.Web.Label labelCapCompany;
		private Wisej.Web.TextBox textBoxCompany;
		private Wisej.Web.Label labelCapJobTitle;
		private Wisej.Web.TextBox textBoxJobTitle;
		private Wisej.Web.Label labelCapStage;
		private Wisej.Web.TextBox textBoxStage;
		private Wisej.Web.Label labelCapLeadSource;
		private Wisej.Web.TextBox textBoxLeadSource;
		private Wisej.Web.Label labelCapOwner;
		private Wisej.Web.TextBox textBoxOwner;
		private Wisej.Web.Label labelCapLastContacted;
		private Wisej.Web.TextBox textBoxLastContacted;
		private Wisej.Web.Label labelCapCreated;
		private Wisej.Web.TextBox textBoxCreated;
		private Wisej.Web.Label labelCapTags;
		private Wisej.Web.TextBox textBoxTags;
		private Wisej.Web.Button buttonEditOverview;
		private Wisej.Web.TabPage tabPageActivity;
		private Wisej.Web.Label labelNoActivity;
		private Wisej.Web.ListView listViewActivity;
		private Wisej.Web.ColumnHeader columnActivityDate;
		private Wisej.Web.ColumnHeader columnActivityType;
		private Wisej.Web.ColumnHeader columnActivitySubject;
		private Wisej.Web.ColumnHeader columnActivityDuration;
		private Wisej.Web.ColumnHeader columnActivityUser;
		private Wisej.Web.ColumnHeader columnActivityNotes;
		private Wisej.Web.ToolBar activityStrip;
		private Wisej.Web.ToolBarButton buttonLogActivityTab;
		private Wisej.Web.TabPage tabPageDeals;
		private Wisej.Web.Label labelNoDeals;
		private Wisej.Web.ListView listViewDeals;
		private Wisej.Web.ColumnHeader columnDealTitle;
		private Wisej.Web.ColumnHeader columnDealStage;
		private Wisej.Web.ColumnHeader columnDealDescription;
		private Wisej.Web.ColumnHeader columnDealMeta;
		private Wisej.Web.ToolBar dealsStrip;
		private Wisej.Web.ToolBarButton buttonNewDealTab;
		private Wisej.Web.TabPage tabPageTasks;
		private Wisej.Web.Label labelNoTasks;
		private Wisej.Web.DataGridView gridTasks;
		private Wisej.Web.DataGridViewTextBoxColumn colTaskTitle;
		private Wisej.Web.DataGridViewTextBoxColumn colTaskDue;
		private Wisej.Web.DataGridViewTextBoxColumn colTaskPriority;
		private Wisej.Web.DataGridViewTextBoxColumn colTaskAssignee;
		private Wisej.Web.DataGridViewTextBoxColumn colTaskStatus;
		private Wisej.Web.ToolBar tasksStrip;
		private Wisej.Web.ToolBarButton buttonAddTaskTab;
	}
}
