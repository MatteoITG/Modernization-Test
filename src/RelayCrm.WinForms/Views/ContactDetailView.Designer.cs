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
			this.tabControl = new System.Windows.Forms.TabControl();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.buttonLogActivity = new System.Windows.Forms.ToolStripButton();
			this.buttonEdit = new System.Windows.Forms.ToolStripButton();
			this.buttonNewDeal = new System.Windows.Forms.ToolStripButton();
			this.buttonAddTask = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonDelete = new System.Windows.Forms.ToolStripButton();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.linkBack = new System.Windows.Forms.LinkLabel();
			this.pictureAvatar = new System.Windows.Forms.PictureBox();
			this.labelName = new System.Windows.Forms.Label();
			this.flowSubtitle = new System.Windows.Forms.FlowLayoutPanel();
			this.labelTitleAt = new System.Windows.Forms.Label();
			this.linkCompany = new System.Windows.Forms.LinkLabel();
			this.labelDot1 = new System.Windows.Forms.Label();
			this.labelStage = new System.Windows.Forms.Label();
			this.labelDot2 = new System.Windows.Forms.Label();
			this.labelOwner = new System.Windows.Forms.Label();
			this.tabPageOverview = new System.Windows.Forms.TabPage();
			this.labelCapEmail = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelCapPhone = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.labelCapCompany = new System.Windows.Forms.Label();
			this.textBoxCompany = new System.Windows.Forms.TextBox();
			this.labelCapJobTitle = new System.Windows.Forms.Label();
			this.textBoxJobTitle = new System.Windows.Forms.TextBox();
			this.labelCapStage = new System.Windows.Forms.Label();
			this.textBoxStage = new System.Windows.Forms.TextBox();
			this.labelCapLeadSource = new System.Windows.Forms.Label();
			this.textBoxLeadSource = new System.Windows.Forms.TextBox();
			this.labelCapOwner = new System.Windows.Forms.Label();
			this.textBoxOwner = new System.Windows.Forms.TextBox();
			this.labelCapLastContacted = new System.Windows.Forms.Label();
			this.textBoxLastContacted = new System.Windows.Forms.TextBox();
			this.labelCapCreated = new System.Windows.Forms.Label();
			this.textBoxCreated = new System.Windows.Forms.TextBox();
			this.labelCapTags = new System.Windows.Forms.Label();
			this.textBoxTags = new System.Windows.Forms.TextBox();
			this.buttonEditOverview = new System.Windows.Forms.Button();
			this.tabPageActivity = new System.Windows.Forms.TabPage();
			this.labelNoActivity = new System.Windows.Forms.Label();
			this.listViewActivity = new System.Windows.Forms.ListView();
			this.columnActivityDate = new System.Windows.Forms.ColumnHeader();
			this.columnActivityType = new System.Windows.Forms.ColumnHeader();
			this.columnActivitySubject = new System.Windows.Forms.ColumnHeader();
			this.columnActivityDuration = new System.Windows.Forms.ColumnHeader();
			this.columnActivityUser = new System.Windows.Forms.ColumnHeader();
			this.columnActivityNotes = new System.Windows.Forms.ColumnHeader();
			this.activityStrip = new System.Windows.Forms.ToolStrip();
			this.buttonLogActivityTab = new System.Windows.Forms.ToolStripButton();
			this.tabPageDeals = new System.Windows.Forms.TabPage();
			this.labelNoDeals = new System.Windows.Forms.Label();
			this.listViewDeals = new System.Windows.Forms.ListView();
			this.columnDealTitle = new System.Windows.Forms.ColumnHeader();
			this.columnDealStage = new System.Windows.Forms.ColumnHeader();
			this.columnDealDescription = new System.Windows.Forms.ColumnHeader();
			this.columnDealMeta = new System.Windows.Forms.ColumnHeader();
			this.dealsStrip = new System.Windows.Forms.ToolStrip();
			this.buttonNewDealTab = new System.Windows.Forms.ToolStripButton();
			this.tabPageTasks = new System.Windows.Forms.TabPage();
			this.labelNoTasks = new System.Windows.Forms.Label();
			this.gridTasks = new System.Windows.Forms.DataGridView();
			this.colTaskTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTaskDue = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTaskPriority = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTaskAssignee = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTaskStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tasksStrip = new System.Windows.Forms.ToolStrip();
			this.buttonAddTaskTab = new System.Windows.Forms.ToolStripButton();
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
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 117);
			this.tabControl.Name = "tabControl";
			this.tabControl.Padding = new System.Drawing.Point(12, 4);
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1000, 483);
			this.tabControl.TabIndex = 2;
			//
			// toolStrip
			//
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonLogActivity,
			this.buttonEdit,
			this.buttonNewDeal,
			this.buttonAddTask,
			this.toolStripSeparator1,
			this.buttonDelete});
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Location = new System.Drawing.Point(0, 92);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(800, 27);
			this.toolStrip.TabIndex = 1;
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
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
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
			this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
			//
			// pictureAvatar
			//
			this.pictureAvatar.Location = new System.Drawing.Point(12, 28);
			this.pictureAvatar.Name = "pictureAvatar";
			this.pictureAvatar.Size = new System.Drawing.Size(52, 52);
			this.pictureAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureAvatar.TabIndex = 1;
			this.pictureAvatar.TabStop = false;
			//
			// labelName
			//
			this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
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
			this.flowSubtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right));
			this.flowSubtitle.Location = new System.Drawing.Point(74, 58);
			this.flowSubtitle.Name = "flowSubtitle";
			this.flowSubtitle.Size = new System.Drawing.Size(900, 24);
			this.flowSubtitle.TabIndex = 3;
			this.flowSubtitle.WrapContents = false;
			//
			// labelTitleAt
			//
			this.labelTitleAt.AutoSize = true;
			this.labelTitleAt.Margin = new System.Windows.Forms.Padding(0, 3, 4, 0);
			this.labelTitleAt.Name = "labelTitleAt";
			this.labelTitleAt.Size = new System.Drawing.Size(56, 15);
			this.labelTitleAt.Text = "Title at";
			//
			// linkCompany
			//
			this.linkCompany.AutoSize = true;
			this.linkCompany.Margin = new System.Windows.Forms.Padding(0, 3, 4, 0);
			this.linkCompany.Name = "linkCompany";
			this.linkCompany.Size = new System.Drawing.Size(49, 15);
			this.linkCompany.Text = "Company";
			this.linkCompany.TabStop = true;
			this.linkCompany.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCompany_LinkClicked);
			//
			// labelDot1
			//
			this.labelDot1.AutoSize = true;
			this.labelDot1.Margin = new System.Windows.Forms.Padding(0, 3, 4, 0);
			this.labelDot1.Name = "labelDot1";
			this.labelDot1.Size = new System.Drawing.Size(7, 15);
			this.labelDot1.Text = "·";
			this.labelDot1.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// labelStage
			//
			this.labelStage.AutoSize = true;
			this.labelStage.Margin = new System.Windows.Forms.Padding(0, 3, 4, 0);
			this.labelStage.Name = "labelStage";
			this.labelStage.Size = new System.Drawing.Size(28, 15);
			this.labelStage.Text = "Lead";
			this.labelStage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			//
			// labelDot2
			//
			this.labelDot2.AutoSize = true;
			this.labelDot2.Margin = new System.Windows.Forms.Padding(0, 3, 4, 0);
			this.labelDot2.Name = "labelDot2";
			this.labelDot2.Size = new System.Drawing.Size(7, 15);
			this.labelDot2.Text = "·";
			this.labelDot2.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// labelOwner
			//
			this.labelOwner.AutoSize = true;
			this.labelOwner.Margin = new System.Windows.Forms.Padding(0, 3, 4, 0);
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
			this.tabPageOverview.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageOverview.Size = new System.Drawing.Size(992, 440);
			this.tabPageOverview.TabIndex = 0;
			this.tabPageOverview.Text = "Overview";
			this.tabPageOverview.UseVisualStyleBackColor = true;
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
			this.buttonEditOverview.UseVisualStyleBackColor = true;
			this.buttonEditOverview.Click += new System.EventHandler(this.buttonEdit_Click);
			//
			// tabPageActivity
			//
			this.tabPageActivity.Controls.Add(this.labelNoActivity);
			this.tabPageActivity.Controls.Add(this.listViewActivity);
			this.tabPageActivity.Controls.Add(this.activityStrip);
			this.tabPageActivity.Location = new System.Drawing.Point(4, 24);
			this.tabPageActivity.Name = "tabPageActivity";
			this.tabPageActivity.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageActivity.Size = new System.Drawing.Size(992, 440);
			this.tabPageActivity.TabIndex = 0;
			this.tabPageActivity.Text = "Activity";
			this.tabPageActivity.UseVisualStyleBackColor = true;
			//
			// labelNoActivity
			//
			this.labelNoActivity.BackColor = System.Drawing.SystemColors.Window;
			this.labelNoActivity.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.listViewActivity.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnActivityDate,
			this.columnActivityType,
			this.columnActivitySubject,
			this.columnActivityDuration,
			this.columnActivityUser,
			this.columnActivityNotes});
			this.listViewActivity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewActivity.FullRowSelect = true;
			this.listViewActivity.HideSelection = false;
			this.listViewActivity.Location = new System.Drawing.Point(3, 30);
			this.listViewActivity.MultiSelect = false;
			this.listViewActivity.Name = "listViewActivity";
			this.listViewActivity.ShowItemToolTips = true;
			this.listViewActivity.Size = new System.Drawing.Size(900, 400);
			this.listViewActivity.TabIndex = 1;
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
			this.columnActivityDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			this.activityStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonLogActivityTab});
			this.activityStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.activityStrip.Location = new System.Drawing.Point(0, 0);
			this.activityStrip.Name = "activityStrip";
			this.activityStrip.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.activityStrip.Size = new System.Drawing.Size(800, 27);
			this.activityStrip.TabIndex = 0;
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
			this.tabPageDeals.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDeals.Size = new System.Drawing.Size(992, 440);
			this.tabPageDeals.TabIndex = 0;
			this.tabPageDeals.Text = "Deals";
			this.tabPageDeals.UseVisualStyleBackColor = true;
			//
			// labelNoDeals
			//
			this.labelNoDeals.BackColor = System.Drawing.SystemColors.Window;
			this.labelNoDeals.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.listViewDeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnDealTitle,
			this.columnDealStage,
			this.columnDealDescription,
			this.columnDealMeta});
			this.listViewDeals.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewDeals.FullRowSelect = true;
			this.listViewDeals.HideSelection = false;
			this.listViewDeals.Location = new System.Drawing.Point(3, 30);
			this.listViewDeals.MultiSelect = false;
			this.listViewDeals.Name = "listViewDeals";
			this.listViewDeals.ShowItemToolTips = true;
			this.listViewDeals.Size = new System.Drawing.Size(900, 400);
			this.listViewDeals.TabIndex = 1;
			this.listViewDeals.UseCompatibleStateImageBehavior = false;
			this.listViewDeals.View = System.Windows.Forms.View.Details;
			this.listViewDeals.ItemActivate += new System.EventHandler(this.listViewDeals_ItemActivate);
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
			this.dealsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonNewDealTab});
			this.dealsStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.dealsStrip.Location = new System.Drawing.Point(0, 0);
			this.dealsStrip.Name = "dealsStrip";
			this.dealsStrip.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.dealsStrip.Size = new System.Drawing.Size(800, 27);
			this.dealsStrip.TabIndex = 0;
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
			this.tabPageTasks.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTasks.Size = new System.Drawing.Size(992, 440);
			this.tabPageTasks.TabIndex = 0;
			this.tabPageTasks.Text = "Tasks";
			this.tabPageTasks.UseVisualStyleBackColor = true;
			//
			// labelNoTasks
			//
			this.labelNoTasks.BackColor = System.Drawing.SystemColors.Window;
			this.labelNoTasks.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.gridTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colTaskTitle,
			this.colTaskDue,
			this.colTaskPriority,
			this.colTaskAssignee,
			this.colTaskStatus});
			this.gridTasks.AllowUserToAddRows = false;
			this.gridTasks.AllowUserToDeleteRows = false;
			this.gridTasks.AllowUserToResizeRows = false;
			this.gridTasks.BackgroundColor = System.Drawing.SystemColors.Window;
			this.gridTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridTasks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridTasks.Location = new System.Drawing.Point(3, 30);
			this.gridTasks.MultiSelect = false;
			this.gridTasks.Name = "gridTasks";
			this.gridTasks.ReadOnly = true;
			this.gridTasks.RowHeadersVisible = false;
			this.gridTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.gridTasks.Size = new System.Drawing.Size(400, 200);
			this.gridTasks.TabIndex = 1;
			this.gridTasks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTasks_CellDoubleClick);
			this.gridTasks.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridTasks_CellFormatting);
			//
			// colTaskTitle
			//
			this.colTaskTitle.DataPropertyName = "Title";
			this.colTaskTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
			this.tasksStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonAddTaskTab});
			this.tasksStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tasksStrip.Location = new System.Drawing.Point(0, 0);
			this.tasksStrip.Name = "tasksStrip";
			this.tasksStrip.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.tasksStrip.Size = new System.Drawing.Size(800, 27);
			this.tasksStrip.TabIndex = 0;
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
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton buttonLogActivity;
		private System.Windows.Forms.ToolStripButton buttonEdit;
		private System.Windows.Forms.ToolStripButton buttonNewDeal;
		private System.Windows.Forms.ToolStripButton buttonAddTask;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton buttonDelete;
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.LinkLabel linkBack;
		private System.Windows.Forms.PictureBox pictureAvatar;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.FlowLayoutPanel flowSubtitle;
		private System.Windows.Forms.Label labelTitleAt;
		private System.Windows.Forms.LinkLabel linkCompany;
		private System.Windows.Forms.Label labelDot1;
		private System.Windows.Forms.Label labelStage;
		private System.Windows.Forms.Label labelDot2;
		private System.Windows.Forms.Label labelOwner;
		private System.Windows.Forms.TabPage tabPageOverview;
		private System.Windows.Forms.Label labelCapEmail;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label labelCapPhone;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label labelCapCompany;
		private System.Windows.Forms.TextBox textBoxCompany;
		private System.Windows.Forms.Label labelCapJobTitle;
		private System.Windows.Forms.TextBox textBoxJobTitle;
		private System.Windows.Forms.Label labelCapStage;
		private System.Windows.Forms.TextBox textBoxStage;
		private System.Windows.Forms.Label labelCapLeadSource;
		private System.Windows.Forms.TextBox textBoxLeadSource;
		private System.Windows.Forms.Label labelCapOwner;
		private System.Windows.Forms.TextBox textBoxOwner;
		private System.Windows.Forms.Label labelCapLastContacted;
		private System.Windows.Forms.TextBox textBoxLastContacted;
		private System.Windows.Forms.Label labelCapCreated;
		private System.Windows.Forms.TextBox textBoxCreated;
		private System.Windows.Forms.Label labelCapTags;
		private System.Windows.Forms.TextBox textBoxTags;
		private System.Windows.Forms.Button buttonEditOverview;
		private System.Windows.Forms.TabPage tabPageActivity;
		private System.Windows.Forms.Label labelNoActivity;
		private System.Windows.Forms.ListView listViewActivity;
		private System.Windows.Forms.ColumnHeader columnActivityDate;
		private System.Windows.Forms.ColumnHeader columnActivityType;
		private System.Windows.Forms.ColumnHeader columnActivitySubject;
		private System.Windows.Forms.ColumnHeader columnActivityDuration;
		private System.Windows.Forms.ColumnHeader columnActivityUser;
		private System.Windows.Forms.ColumnHeader columnActivityNotes;
		private System.Windows.Forms.ToolStrip activityStrip;
		private System.Windows.Forms.ToolStripButton buttonLogActivityTab;
		private System.Windows.Forms.TabPage tabPageDeals;
		private System.Windows.Forms.Label labelNoDeals;
		private System.Windows.Forms.ListView listViewDeals;
		private System.Windows.Forms.ColumnHeader columnDealTitle;
		private System.Windows.Forms.ColumnHeader columnDealStage;
		private System.Windows.Forms.ColumnHeader columnDealDescription;
		private System.Windows.Forms.ColumnHeader columnDealMeta;
		private System.Windows.Forms.ToolStrip dealsStrip;
		private System.Windows.Forms.ToolStripButton buttonNewDealTab;
		private System.Windows.Forms.TabPage tabPageTasks;
		private System.Windows.Forms.Label labelNoTasks;
		private System.Windows.Forms.DataGridView gridTasks;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTaskTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTaskDue;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTaskPriority;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTaskAssignee;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTaskStatus;
		private System.Windows.Forms.ToolStrip tasksStrip;
		private System.Windows.Forms.ToolStripButton buttonAddTaskTab;
	}
}
