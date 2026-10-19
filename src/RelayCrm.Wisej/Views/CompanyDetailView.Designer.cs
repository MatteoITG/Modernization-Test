namespace RelayCrm.Views
{
	partial class CompanyDetailView
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
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
			this.tabControl = new Wisej.Web.TabControl();
			this.tableKpis = new Wisej.Web.TableLayoutPanel();
			this.kpiOpenPipeline = new Wisej.Web.KpiPanel();
			this.kpiWonThisYear = new Wisej.Web.KpiPanel();
			this.kpiContacts = new Wisej.Web.KpiPanel();
			this.kpiLastActivity = new Wisej.Web.KpiPanel();
			this.toolStrip = new Wisej.Web.ToolBar();
			this.buttonLogActivity = new Wisej.Web.ToolBarButton();
			this.buttonNewContact = new Wisej.Web.ToolBarButton();
			this.buttonNewDeal = new Wisej.Web.ToolBarButton();
			this.buttonAddTask = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator1 = new Wisej.Web.ToolBarButton();
			this.buttonEdit = new Wisej.Web.ToolBarButton();
			this.buttonDelete = new Wisej.Web.ToolBarButton();
			this.panelHeader = new Wisej.Web.Panel();
			this.linkBack = new Wisej.Web.LinkLabel();
			this.avatar = new Wisej.Web.Avatar();
			this.labelName = new Wisej.Web.Label();
			this.flowSubtitle = new Wisej.Web.FlowLayoutPanel();
			this.labelSubtitle = new Wisej.Web.Label();
			this.labelDot1 = new Wisej.Web.Label();
			this.linkWebsite = new Wisej.Web.LinkLabel();
			this.labelDot2 = new Wisej.Web.Label();
			this.labelOwner = new Wisej.Web.Label();
			this.labelDot3 = new Wisej.Web.Label();
			this.labelTags = new Wisej.Web.Label();
			this.tabOverview = new Wisej.Web.TabPage();
			this.labelCapIndustry = new Wisej.Web.Label();
			this.textBoxIndustry = new Wisej.Web.TextBox();
			this.labelCapSize = new Wisej.Web.Label();
			this.textBoxSize = new Wisej.Web.TextBox();
			this.labelCapRevenue = new Wisej.Web.Label();
			this.textBoxRevenue = new Wisej.Web.TextBox();
			this.labelCapWebsite = new Wisej.Web.Label();
			this.textBoxWebsite = new Wisej.Web.TextBox();
			this.labelCapPhone = new Wisej.Web.Label();
			this.textBoxPhone = new Wisej.Web.TextBox();
			this.labelCapOwner = new Wisej.Web.Label();
			this.textBoxOwner = new Wisej.Web.TextBox();
			this.labelCapAddress = new Wisej.Web.Label();
			this.textBoxAddress = new Wisej.Web.TextBox();
			this.labelCapCity = new Wisej.Web.Label();
			this.textBoxCity = new Wisej.Web.TextBox();
			this.labelCapCountry = new Wisej.Web.Label();
			this.textBoxCountry = new Wisej.Web.TextBox();
			this.labelCapTagList = new Wisej.Web.Label();
			this.textBoxTagList = new Wisej.Web.TextBox();
			this.labelCapCreated = new Wisej.Web.Label();
			this.textBoxCreated = new Wisej.Web.TextBox();
			this.labelCapUpdated = new Wisej.Web.Label();
			this.textBoxUpdated = new Wisej.Web.TextBox();
			this.tabContacts = new Wisej.Web.TabPage();
			this.emptyContacts = new Wisej.Web.EmptyState();
			this.gridContacts = new Wisej.Web.DataGridView();
			this.colContactName = new Wisej.Web.DataGridViewAvatarColumn();
			this.colContactTitle = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colContactEmail = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colContactPhone = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colContactStage = new Wisej.Web.DataGridViewChipColumn();
			this.colContactLast = new Wisej.Web.DataGridViewTextBoxColumn();
			this.contactsStrip = new Wisej.Web.ToolBar();
			this.buttonNewContactTab = new Wisej.Web.ToolBarButton();
			this.tabDeals = new Wisej.Web.TabPage();
			this.emptyDeals = new Wisej.Web.EmptyState();
			this.gridDeals = new Wisej.Web.DataGridView();
			this.colDealTitle = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colDealStage = new Wisej.Web.DataGridViewChipColumn();
			this.colDealAmount = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colDealClose = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colDealProbability = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colDealOwner = new Wisej.Web.DataGridViewAvatarColumn();
			this.dealsStrip = new Wisej.Web.ToolBar();
			this.buttonNewDealTab = new Wisej.Web.ToolBarButton();
			this.tabActivity = new Wisej.Web.TabPage();
			this.emptyActivity = new Wisej.Web.EmptyState();
			this.timelineActivity = new Wisej.Web.Timeline();
			this.activityStrip = new Wisej.Web.ToolBar();
			this.buttonLogActivityTab = new Wisej.Web.ToolBarButton();
			this.labelActivityCount = new Wisej.Web.ToolBarButton();
			this.tabTasks = new Wisej.Web.TabPage();
			this.emptyTasks = new Wisej.Web.EmptyState();
			this.gridTasks = new Wisej.Web.DataGridView();
			this.colTaskTitle = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTaskDue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTaskPriority = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTaskStatus = new Wisej.Web.DataGridViewChipColumn();
			this.colTaskAssignee = new Wisej.Web.DataGridViewAvatarColumn();
			this.tasksStrip = new Wisej.Web.ToolBar();
			this.buttonAddTaskTab = new Wisej.Web.ToolBarButton();
			this.tabControl.SuspendLayout();
			this.tableKpis.SuspendLayout();
			this.kpiOpenPipeline.SuspendLayout();
			this.kpiWonThisYear.SuspendLayout();
			this.kpiContacts.SuspendLayout();
			this.kpiLastActivity.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.panelHeader.SuspendLayout();
			this.flowSubtitle.SuspendLayout();
			this.tabOverview.SuspendLayout();
			this.tabContacts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridContacts)).BeginInit();
			this.contactsStrip.SuspendLayout();
			this.tabDeals.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDeals)).BeginInit();
			this.dealsStrip.SuspendLayout();
			this.tabActivity.SuspendLayout();
			this.activityStrip.SuspendLayout();
			this.tabTasks.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTasks)).BeginInit();
			this.tasksStrip.SuspendLayout();
			this.SuspendLayout();
			//
			// tabControl
			//
			this.tabControl.Controls.Add(this.tabOverview);
			this.tabControl.Controls.Add(this.tabContacts);
			this.tabControl.Controls.Add(this.tabDeals);
			this.tabControl.Controls.Add(this.tabActivity);
			this.tabControl.Controls.Add(this.tabTasks);
			this.tabControl.Dock = Wisej.Web.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 205);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1000, 435);
			this.tabControl.TabIndex = 3;
			//
			// tableKpis
			//
			this.tableKpis.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableKpis.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableKpis.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableKpis.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 25F));
			this.tableKpis.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableKpis.Controls.Add(this.kpiOpenPipeline, 0, 0);
			this.tableKpis.Controls.Add(this.kpiWonThisYear, 1, 0);
			this.tableKpis.Controls.Add(this.kpiContacts, 2, 0);
			this.tableKpis.Controls.Add(this.kpiLastActivity, 3, 0);
			this.tableKpis.ColumnCount = 4;
			this.tableKpis.Dock = Wisej.Web.DockStyle.Top;
			this.tableKpis.Location = new System.Drawing.Point(0, 117);
			this.tableKpis.Name = "tableKpis";
			this.tableKpis.Padding = new Wisej.Web.Padding(6, 4, 6, 4);
			this.tableKpis.RowCount = 1;
			this.tableKpis.Size = new System.Drawing.Size(1000, 150);
			this.tableKpis.TabIndex = 2;
			//
			// kpiOpenPipeline
			//
			this.kpiOpenPipeline.CssClass = "relay-card";
			this.kpiOpenPipeline.Dock = Wisej.Web.DockStyle.Fill;
			this.kpiOpenPipeline.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/funnel.svg";
			this.kpiOpenPipeline.Margin = new Wisej.Web.Padding(6);
			this.kpiOpenPipeline.Name = "kpiOpenPipeline";
			this.kpiOpenPipeline.Size = new System.Drawing.Size(232, 130);
			this.kpiOpenPipeline.TabIndex = 0;
			this.kpiOpenPipeline.Title = "Open pipeline";
			this.kpiOpenPipeline.Tone = Wisej.Web.KpiTone.Primary;
			this.kpiOpenPipeline.Value = "-";
			//
			// kpiWonThisYear
			//
			this.kpiWonThisYear.CssClass = "relay-card";
			this.kpiWonThisYear.Dock = Wisej.Web.DockStyle.Fill;
			this.kpiWonThisYear.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/trophy.svg";
			this.kpiWonThisYear.Margin = new Wisej.Web.Padding(6);
			this.kpiWonThisYear.Name = "kpiWonThisYear";
			this.kpiWonThisYear.Size = new System.Drawing.Size(232, 130);
			this.kpiWonThisYear.TabIndex = 1;
			this.kpiWonThisYear.Title = "Won this year";
			this.kpiWonThisYear.Tone = Wisej.Web.KpiTone.Success;
			this.kpiWonThisYear.Value = "-";
			//
			// kpiContacts
			//
			this.kpiContacts.CssClass = "relay-card";
			this.kpiContacts.Dock = Wisej.Web.DockStyle.Fill;
			this.kpiContacts.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/people.svg";
			this.kpiContacts.Margin = new Wisej.Web.Padding(6);
			this.kpiContacts.Name = "kpiContacts";
			this.kpiContacts.Size = new System.Drawing.Size(232, 130);
			this.kpiContacts.TabIndex = 2;
			this.kpiContacts.Title = "Contacts";
			this.kpiContacts.Tone = Wisej.Web.KpiTone.Neutral;
			this.kpiContacts.Value = "-";
			//
			// kpiLastActivity
			//
			this.kpiLastActivity.CssClass = "relay-card";
			this.kpiLastActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.kpiLastActivity.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/clock-history.svg";
			this.kpiLastActivity.Margin = new Wisej.Web.Padding(6);
			this.kpiLastActivity.Name = "kpiLastActivity";
			this.kpiLastActivity.Size = new System.Drawing.Size(232, 130);
			this.kpiLastActivity.TabIndex = 3;
			this.kpiLastActivity.Title = "Last activity";
			this.kpiLastActivity.Tone = Wisej.Web.KpiTone.Neutral;
			this.kpiLastActivity.Value = "-";
			//
			// toolStrip
			//
			this.toolStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonLogActivity,
			this.buttonNewContact,
			this.buttonNewDeal,
			this.buttonAddTask,
			this.toolStripSeparator1,
			this.buttonEdit,
			this.buttonDelete});
			this.toolStrip.Location = new System.Drawing.Point(0, 92);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new Wisej.Web.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(800, 27);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.toolStrip.CssClass = "relay-toolbar";
			//
			// buttonLogActivity
			//
			this.buttonLogActivity.Tag = "journal-plus";
			this.buttonLogActivity.Name = "buttonLogActivity";
			this.buttonLogActivity.Text = "Log activity...";
			this.buttonLogActivity.Click += new System.EventHandler(this.buttonLogActivity_Click);
			//
			// buttonNewContact
			//
			this.buttonNewContact.Tag = "person";
			this.buttonNewContact.Name = "buttonNewContact";
			this.buttonNewContact.Text = "New contact...";
			this.buttonNewContact.Click += new System.EventHandler(this.buttonNewContact_Click);
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
			// buttonEdit
			//
			this.buttonEdit.Tag = "pencil";
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Text = "Edit...";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
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
			this.panelHeader.Controls.Add(this.avatar);
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
			this.linkBack.Text = "‹ Back to companies";
			this.linkBack.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
			//
			// avatar
			//
			this.avatar.AvatarSize = 52;
			this.avatar.Location = new System.Drawing.Point(12, 28);
			this.avatar.Name = "avatar";
			this.avatar.Shape = Wisej.Web.AvatarShape.Rounded;
			this.avatar.Size = new System.Drawing.Size(52, 52);
			this.avatar.TabIndex = 1;
			//
			// labelName
			//
			this.labelName.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.labelName.AutoEllipsis = true;
			this.labelName.Location = new System.Drawing.Point(72, 26);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(900, 30);
			this.labelName.TabIndex = 2;
			this.labelName.Text = "Name";
			this.labelName.AppearanceKey = "relay-page-title";
			//
			// flowSubtitle
			//
			this.flowSubtitle.Controls.Add(this.labelSubtitle);
			this.flowSubtitle.Controls.Add(this.labelDot1);
			this.flowSubtitle.Controls.Add(this.linkWebsite);
			this.flowSubtitle.Controls.Add(this.labelDot2);
			this.flowSubtitle.Controls.Add(this.labelOwner);
			this.flowSubtitle.Controls.Add(this.labelDot3);
			this.flowSubtitle.Controls.Add(this.labelTags);
			this.flowSubtitle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right));
			this.flowSubtitle.Location = new System.Drawing.Point(74, 58);
			this.flowSubtitle.Name = "flowSubtitle";
			this.flowSubtitle.Size = new System.Drawing.Size(900, 24);
			this.flowSubtitle.TabIndex = 3;
			this.flowSubtitle.WrapContents = false;
			//
			// labelSubtitle
			//
			this.labelSubtitle.AutoSize = true;
			this.labelSubtitle.Margin = new Wisej.Web.Padding(0, 3, 4, 0);
			this.labelSubtitle.Name = "labelSubtitle";
			this.labelSubtitle.Size = new System.Drawing.Size(168, 15);
			this.labelSubtitle.Text = "Industry · City, Country";
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
			// linkWebsite
			//
			this.linkWebsite.AutoSize = true;
			this.linkWebsite.Margin = new Wisej.Web.Padding(0, 3, 4, 0);
			this.linkWebsite.Name = "linkWebsite";
			this.linkWebsite.Size = new System.Drawing.Size(105, 15);
			this.linkWebsite.Text = "www.example.com";
			this.linkWebsite.TabStop = true;
			this.linkWebsite.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkWebsite_LinkClicked);
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
			// labelDot3
			//
			this.labelDot3.AutoSize = true;
			this.labelDot3.Margin = new Wisej.Web.Padding(0, 3, 4, 0);
			this.labelDot3.Name = "labelDot3";
			this.labelDot3.Size = new System.Drawing.Size(7, 15);
			this.labelDot3.Text = "·";
			this.labelDot3.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// labelTags
			//
			this.labelTags.AutoSize = true;
			this.labelTags.Margin = new Wisej.Web.Padding(0, 3, 4, 0);
			this.labelTags.Name = "labelTags";
			this.labelTags.Size = new System.Drawing.Size(28, 15);
			this.labelTags.Text = "Tags";
			this.labelTags.ForeColor = System.Drawing.Color.FromArgb(0, 84, 166);
			//
			// tabOverview
			//
			this.tabOverview.Controls.Add(this.labelCapIndustry);
			this.tabOverview.Controls.Add(this.textBoxIndustry);
			this.tabOverview.Controls.Add(this.labelCapSize);
			this.tabOverview.Controls.Add(this.textBoxSize);
			this.tabOverview.Controls.Add(this.labelCapRevenue);
			this.tabOverview.Controls.Add(this.textBoxRevenue);
			this.tabOverview.Controls.Add(this.labelCapWebsite);
			this.tabOverview.Controls.Add(this.textBoxWebsite);
			this.tabOverview.Controls.Add(this.labelCapPhone);
			this.tabOverview.Controls.Add(this.textBoxPhone);
			this.tabOverview.Controls.Add(this.labelCapOwner);
			this.tabOverview.Controls.Add(this.textBoxOwner);
			this.tabOverview.Controls.Add(this.labelCapAddress);
			this.tabOverview.Controls.Add(this.textBoxAddress);
			this.tabOverview.Controls.Add(this.labelCapCity);
			this.tabOverview.Controls.Add(this.textBoxCity);
			this.tabOverview.Controls.Add(this.labelCapCountry);
			this.tabOverview.Controls.Add(this.textBoxCountry);
			this.tabOverview.Controls.Add(this.labelCapTagList);
			this.tabOverview.Controls.Add(this.textBoxTagList);
			this.tabOverview.Controls.Add(this.labelCapCreated);
			this.tabOverview.Controls.Add(this.textBoxCreated);
			this.tabOverview.Controls.Add(this.labelCapUpdated);
			this.tabOverview.Controls.Add(this.textBoxUpdated);
			this.tabOverview.Location = new System.Drawing.Point(4, 24);
			this.tabOverview.Name = "tabOverview";
			this.tabOverview.Padding = new Wisej.Web.Padding(3);
			this.tabOverview.Size = new System.Drawing.Size(992, 440);
			this.tabOverview.TabIndex = 0;
			this.tabOverview.Text = "Overview";
			//
			// labelCapIndustry
			//
			this.labelCapIndustry.AutoSize = true;
			this.labelCapIndustry.Location = new System.Drawing.Point(16, 19);
			this.labelCapIndustry.Name = "labelCapIndustry";
			this.labelCapIndustry.Size = new System.Drawing.Size(56, 15);
			this.labelCapIndustry.Text = "Industry";
			this.labelCapIndustry.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxIndustry
			//
			this.textBoxIndustry.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxIndustry.Location = new System.Drawing.Point(126, 16);
			this.textBoxIndustry.Name = "textBoxIndustry";
			this.textBoxIndustry.ReadOnly = true;
			this.textBoxIndustry.Size = new System.Drawing.Size(280, 23);
			this.textBoxIndustry.TabIndex = 0;
			//
			// labelCapSize
			//
			this.labelCapSize.AutoSize = true;
			this.labelCapSize.Location = new System.Drawing.Point(16, 51);
			this.labelCapSize.Name = "labelCapSize";
			this.labelCapSize.Size = new System.Drawing.Size(28, 15);
			this.labelCapSize.Text = "Size";
			this.labelCapSize.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxSize
			//
			this.textBoxSize.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxSize.Location = new System.Drawing.Point(126, 48);
			this.textBoxSize.Name = "textBoxSize";
			this.textBoxSize.ReadOnly = true;
			this.textBoxSize.Size = new System.Drawing.Size(280, 23);
			this.textBoxSize.TabIndex = 0;
			//
			// labelCapRevenue
			//
			this.labelCapRevenue.AutoSize = true;
			this.labelCapRevenue.Location = new System.Drawing.Point(16, 83);
			this.labelCapRevenue.Name = "labelCapRevenue";
			this.labelCapRevenue.Size = new System.Drawing.Size(98, 15);
			this.labelCapRevenue.Text = "Annual revenue";
			this.labelCapRevenue.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxRevenue
			//
			this.textBoxRevenue.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxRevenue.Location = new System.Drawing.Point(126, 80);
			this.textBoxRevenue.Name = "textBoxRevenue";
			this.textBoxRevenue.ReadOnly = true;
			this.textBoxRevenue.Size = new System.Drawing.Size(280, 23);
			this.textBoxRevenue.TabIndex = 0;
			//
			// labelCapWebsite
			//
			this.labelCapWebsite.AutoSize = true;
			this.labelCapWebsite.Location = new System.Drawing.Point(16, 115);
			this.labelCapWebsite.Name = "labelCapWebsite";
			this.labelCapWebsite.Size = new System.Drawing.Size(49, 15);
			this.labelCapWebsite.Text = "Website";
			this.labelCapWebsite.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxWebsite
			//
			this.textBoxWebsite.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxWebsite.Location = new System.Drawing.Point(126, 112);
			this.textBoxWebsite.Name = "textBoxWebsite";
			this.textBoxWebsite.ReadOnly = true;
			this.textBoxWebsite.Size = new System.Drawing.Size(280, 23);
			this.textBoxWebsite.TabIndex = 0;
			//
			// labelCapPhone
			//
			this.labelCapPhone.AutoSize = true;
			this.labelCapPhone.Location = new System.Drawing.Point(16, 147);
			this.labelCapPhone.Name = "labelCapPhone";
			this.labelCapPhone.Size = new System.Drawing.Size(35, 15);
			this.labelCapPhone.Text = "Phone";
			this.labelCapPhone.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxPhone
			//
			this.textBoxPhone.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxPhone.Location = new System.Drawing.Point(126, 144);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.ReadOnly = true;
			this.textBoxPhone.Size = new System.Drawing.Size(280, 23);
			this.textBoxPhone.TabIndex = 0;
			//
			// labelCapOwner
			//
			this.labelCapOwner.AutoSize = true;
			this.labelCapOwner.Location = new System.Drawing.Point(16, 179);
			this.labelCapOwner.Name = "labelCapOwner";
			this.labelCapOwner.Size = new System.Drawing.Size(35, 15);
			this.labelCapOwner.Text = "Owner";
			this.labelCapOwner.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxOwner
			//
			this.textBoxOwner.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxOwner.Location = new System.Drawing.Point(126, 176);
			this.textBoxOwner.Name = "textBoxOwner";
			this.textBoxOwner.ReadOnly = true;
			this.textBoxOwner.Size = new System.Drawing.Size(280, 23);
			this.textBoxOwner.TabIndex = 0;
			//
			// labelCapAddress
			//
			this.labelCapAddress.AutoSize = true;
			this.labelCapAddress.Location = new System.Drawing.Point(440, 19);
			this.labelCapAddress.Name = "labelCapAddress";
			this.labelCapAddress.Size = new System.Drawing.Size(49, 15);
			this.labelCapAddress.Text = "Address";
			this.labelCapAddress.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxAddress
			//
			this.textBoxAddress.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxAddress.Location = new System.Drawing.Point(550, 16);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.ReadOnly = true;
			this.textBoxAddress.Size = new System.Drawing.Size(280, 23);
			this.textBoxAddress.TabIndex = 0;
			//
			// labelCapCity
			//
			this.labelCapCity.AutoSize = true;
			this.labelCapCity.Location = new System.Drawing.Point(440, 51);
			this.labelCapCity.Name = "labelCapCity";
			this.labelCapCity.Size = new System.Drawing.Size(28, 15);
			this.labelCapCity.Text = "City";
			this.labelCapCity.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxCity
			//
			this.textBoxCity.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxCity.Location = new System.Drawing.Point(550, 48);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.ReadOnly = true;
			this.textBoxCity.Size = new System.Drawing.Size(280, 23);
			this.textBoxCity.TabIndex = 0;
			//
			// labelCapCountry
			//
			this.labelCapCountry.AutoSize = true;
			this.labelCapCountry.Location = new System.Drawing.Point(440, 83);
			this.labelCapCountry.Name = "labelCapCountry";
			this.labelCapCountry.Size = new System.Drawing.Size(49, 15);
			this.labelCapCountry.Text = "Country";
			this.labelCapCountry.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxCountry
			//
			this.textBoxCountry.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxCountry.Location = new System.Drawing.Point(550, 80);
			this.textBoxCountry.Name = "textBoxCountry";
			this.textBoxCountry.ReadOnly = true;
			this.textBoxCountry.Size = new System.Drawing.Size(280, 23);
			this.textBoxCountry.TabIndex = 0;
			//
			// labelCapTagList
			//
			this.labelCapTagList.AutoSize = true;
			this.labelCapTagList.Location = new System.Drawing.Point(440, 115);
			this.labelCapTagList.Name = "labelCapTagList";
			this.labelCapTagList.Size = new System.Drawing.Size(28, 15);
			this.labelCapTagList.Text = "Tags";
			this.labelCapTagList.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxTagList
			//
			this.textBoxTagList.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxTagList.Location = new System.Drawing.Point(550, 112);
			this.textBoxTagList.Name = "textBoxTagList";
			this.textBoxTagList.ReadOnly = true;
			this.textBoxTagList.Size = new System.Drawing.Size(280, 23);
			this.textBoxTagList.TabIndex = 0;
			//
			// labelCapCreated
			//
			this.labelCapCreated.AutoSize = true;
			this.labelCapCreated.Location = new System.Drawing.Point(440, 147);
			this.labelCapCreated.Name = "labelCapCreated";
			this.labelCapCreated.Size = new System.Drawing.Size(49, 15);
			this.labelCapCreated.Text = "Created";
			this.labelCapCreated.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxCreated
			//
			this.textBoxCreated.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxCreated.Location = new System.Drawing.Point(550, 144);
			this.textBoxCreated.Name = "textBoxCreated";
			this.textBoxCreated.ReadOnly = true;
			this.textBoxCreated.Size = new System.Drawing.Size(280, 23);
			this.textBoxCreated.TabIndex = 0;
			//
			// labelCapUpdated
			//
			this.labelCapUpdated.AutoSize = true;
			this.labelCapUpdated.Location = new System.Drawing.Point(440, 179);
			this.labelCapUpdated.Name = "labelCapUpdated";
			this.labelCapUpdated.Size = new System.Drawing.Size(84, 15);
			this.labelCapUpdated.Text = "Last updated";
			this.labelCapUpdated.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// textBoxUpdated
			//
			this.textBoxUpdated.BackColor = System.Drawing.SystemColors.Window;
			this.textBoxUpdated.Location = new System.Drawing.Point(550, 176);
			this.textBoxUpdated.Name = "textBoxUpdated";
			this.textBoxUpdated.ReadOnly = true;
			this.textBoxUpdated.Size = new System.Drawing.Size(280, 23);
			this.textBoxUpdated.TabIndex = 0;
			//
			// tabContacts
			//
			this.tabContacts.Controls.Add(this.emptyContacts);
			this.tabContacts.Controls.Add(this.gridContacts);
			this.tabContacts.Controls.Add(this.contactsStrip);
			this.tabContacts.Location = new System.Drawing.Point(4, 24);
			this.tabContacts.Name = "tabContacts";
			this.tabContacts.Padding = new Wisej.Web.Padding(3);
			this.tabContacts.Size = new System.Drawing.Size(992, 440);
			this.tabContacts.TabIndex = 0;
			this.tabContacts.Text = "Contacts";
			//
			// emptyContacts
			//
			this.emptyContacts.Compact = true;
			this.emptyContacts.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyContacts.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/people.svg";
			this.emptyContacts.Location = new System.Drawing.Point(3, 30);
			this.emptyContacts.Name = "emptyContacts";
			this.emptyContacts.Size = new System.Drawing.Size(900, 400);
			this.emptyContacts.TabIndex = 2;
			this.emptyContacts.Title = "No contacts yet.";
			this.emptyContacts.Visible = false;
			//
			// gridContacts
			//
			this.gridContacts.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colContactName,
			this.colContactTitle,
			this.colContactEmail,
			this.colContactPhone,
			this.colContactStage,
			this.colContactLast});
			this.gridContacts.AllowUserToAddRows = false;
			this.gridContacts.AllowUserToDeleteRows = false;
			this.gridContacts.AllowUserToResizeRows = false;
			this.gridContacts.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridContacts.Dock = Wisej.Web.DockStyle.Fill;
			this.gridContacts.Location = new System.Drawing.Point(3, 30);
			this.gridContacts.MultiSelect = false;
			this.gridContacts.Name = "gridContacts";
			this.gridContacts.ReadOnly = true;
			this.gridContacts.RowHeadersVisible = false;
			this.gridContacts.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.gridContacts.Size = new System.Drawing.Size(400, 200);
			this.gridContacts.TabIndex = 1;
			this.gridContacts.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.gridContacts_CellDoubleClick);
			this.gridContacts.BorderStyle = Wisej.Web.BorderStyle.None;
			this.gridContacts.CssClass = "relay-grid";
			this.gridContacts.RowTemplate.Height = 44;
			//
			// colContactName
			//
			this.colContactName.DataPropertyName = "FullName";
			this.colContactName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colContactName.MinimumWidth = 160;
			this.colContactName.HeaderText = "Name";
			this.colContactName.Name = "colContactName";
			this.colContactName.TextMember = "FullName";
			//
			// colContactTitle
			//
			this.colContactTitle.DataPropertyName = "Title";
			this.colContactTitle.HeaderText = "Job title";
			this.colContactTitle.Name = "colContactTitle";
			this.colContactTitle.Width = 160;
			//
			// colContactEmail
			//
			this.colContactEmail.DataPropertyName = "Email";
			this.colContactEmail.HeaderText = "Email";
			this.colContactEmail.Name = "colContactEmail";
			this.colContactEmail.Width = 210;
			//
			// colContactPhone
			//
			this.colContactPhone.DataPropertyName = "Phone";
			this.colContactPhone.HeaderText = "Phone";
			this.colContactPhone.Name = "colContactPhone";
			this.colContactPhone.Width = 120;
			//
			// colContactStage
			//
			this.colContactStage.DataPropertyName = "Stage";
			this.colContactStage.HeaderText = "Stage";
			this.colContactStage.Name = "colContactStage";
			this.colContactStage.Width = 80;
			//
			// colContactLast
			//
			this.colContactLast.DataPropertyName = "LastContacted";
			this.colContactLast.HeaderText = "Last contacted";
			this.colContactLast.Name = "colContactLast";
			this.colContactLast.Width = 110;
			//
			// contactsStrip
			//
			this.contactsStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonNewContactTab});
			this.contactsStrip.Location = new System.Drawing.Point(0, 0);
			this.contactsStrip.Name = "contactsStrip";
			this.contactsStrip.Padding = new Wisej.Web.Padding(2, 2, 2, 2);
			this.contactsStrip.Size = new System.Drawing.Size(800, 27);
			this.contactsStrip.TabIndex = 0;
			this.contactsStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.contactsStrip.BackColor = System.Drawing.SystemColors.Window;
			this.contactsStrip.CssClass = "relay-toolbar";
			//
			// buttonNewContactTab
			//
			this.buttonNewContactTab.Tag = "person";
			this.buttonNewContactTab.Name = "buttonNewContactTab";
			this.buttonNewContactTab.Text = "New contact...";
			this.buttonNewContactTab.Click += new System.EventHandler(this.buttonNewContact_Click);
			//
			// tabDeals
			//
			this.tabDeals.Controls.Add(this.emptyDeals);
			this.tabDeals.Controls.Add(this.gridDeals);
			this.tabDeals.Controls.Add(this.dealsStrip);
			this.tabDeals.Location = new System.Drawing.Point(4, 24);
			this.tabDeals.Name = "tabDeals";
			this.tabDeals.Padding = new Wisej.Web.Padding(3);
			this.tabDeals.Size = new System.Drawing.Size(992, 440);
			this.tabDeals.TabIndex = 0;
			this.tabDeals.Text = "Deals";
			//
			// emptyDeals
			//
			this.emptyDeals.Compact = true;
			this.emptyDeals.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyDeals.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/briefcase.svg";
			this.emptyDeals.Location = new System.Drawing.Point(3, 30);
			this.emptyDeals.Name = "emptyDeals";
			this.emptyDeals.Size = new System.Drawing.Size(900, 400);
			this.emptyDeals.TabIndex = 2;
			this.emptyDeals.Title = "No deals yet.";
			this.emptyDeals.Visible = false;
			//
			// gridDeals
			//
			this.gridDeals.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colDealTitle,
			this.colDealStage,
			this.colDealAmount,
			this.colDealClose,
			this.colDealProbability,
			this.colDealOwner});
			this.gridDeals.AllowUserToAddRows = false;
			this.gridDeals.AllowUserToDeleteRows = false;
			this.gridDeals.AllowUserToResizeRows = false;
			this.gridDeals.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridDeals.Dock = Wisej.Web.DockStyle.Fill;
			this.gridDeals.Location = new System.Drawing.Point(3, 30);
			this.gridDeals.MultiSelect = false;
			this.gridDeals.Name = "gridDeals";
			this.gridDeals.ReadOnly = true;
			this.gridDeals.RowHeadersVisible = false;
			this.gridDeals.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.gridDeals.Size = new System.Drawing.Size(400, 200);
			this.gridDeals.TabIndex = 1;
			this.gridDeals.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.gridDeals_CellDoubleClick);
			this.gridDeals.BorderStyle = Wisej.Web.BorderStyle.None;
			this.gridDeals.CssClass = "relay-grid";
			this.gridDeals.RowTemplate.Height = 44;
			//
			// colDealTitle
			//
			this.colDealTitle.DataPropertyName = "Title";
			this.colDealTitle.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colDealTitle.MinimumWidth = 200;
			this.colDealTitle.HeaderText = "Deal";
			this.colDealTitle.Name = "colDealTitle";
			//
			// colDealStage
			//
			this.colDealStage.DataPropertyName = "Stage";
			this.colDealStage.HeaderText = "Stage";
			this.colDealStage.Name = "colDealStage";
			this.colDealStage.Width = 100;
			//
			// colDealAmount
			//
			dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle1.Format = "C0";
			this.colDealAmount.DataPropertyName = "Amount";
			this.colDealAmount.DefaultCellStyle = dataGridViewCellStyle1;
			this.colDealAmount.HeaderText = "Amount";
			this.colDealAmount.Name = "colDealAmount";
			this.colDealAmount.Width = 100;
			//
			// colDealClose
			//
			dataGridViewCellStyle2.Format = "MMM d, yyyy";
			this.colDealClose.DataPropertyName = "CloseDate";
			this.colDealClose.DefaultCellStyle = dataGridViewCellStyle2;
			this.colDealClose.HeaderText = "Close date";
			this.colDealClose.Name = "colDealClose";
			this.colDealClose.Width = 100;
			//
			// colDealProbability
			//
			dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle3.Format = "0'%'";
			this.colDealProbability.DataPropertyName = "Probability";
			this.colDealProbability.DefaultCellStyle = dataGridViewCellStyle3;
			this.colDealProbability.HeaderText = "Probability";
			this.colDealProbability.Name = "colDealProbability";
			this.colDealProbability.Width = 80;
			//
			// colDealOwner
			//
			this.colDealOwner.DataPropertyName = "OwnerName";
			this.colDealOwner.HeaderText = "Owner";
			this.colDealOwner.Name = "colDealOwner";
			this.colDealOwner.Width = 130;
			this.colDealOwner.TextMember = "OwnerName";
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
			this.dealsStrip.CssClass = "relay-toolbar";
			//
			// buttonNewDealTab
			//
			this.buttonNewDealTab.Tag = "briefcase";
			this.buttonNewDealTab.Name = "buttonNewDealTab";
			this.buttonNewDealTab.Text = "New deal...";
			this.buttonNewDealTab.Click += new System.EventHandler(this.buttonNewDeal_Click);
			//
			// tabActivity
			//
			this.tabActivity.Controls.Add(this.emptyActivity);
			this.tabActivity.Controls.Add(this.timelineActivity);
			this.tabActivity.Controls.Add(this.activityStrip);
			this.tabActivity.Location = new System.Drawing.Point(4, 24);
			this.tabActivity.Name = "tabActivity";
			this.tabActivity.Padding = new Wisej.Web.Padding(3);
			this.tabActivity.Size = new System.Drawing.Size(992, 440);
			this.tabActivity.TabIndex = 0;
			this.tabActivity.Text = "Activity";
			//
			// emptyActivity
			//
			this.emptyActivity.Compact = true;
			this.emptyActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyActivity.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.emptyActivity.Location = new System.Drawing.Point(3, 30);
			this.emptyActivity.Name = "emptyActivity";
			this.emptyActivity.Size = new System.Drawing.Size(900, 400);
			this.emptyActivity.TabIndex = 2;
			this.emptyActivity.Title = "No activities yet.";
			this.emptyActivity.Visible = false;
			//
			// timelineActivity
			//
			this.timelineActivity.Dock = Wisej.Web.DockStyle.Fill;
			this.timelineActivity.Location = new System.Drawing.Point(3, 30);
			this.timelineActivity.Name = "timelineActivity";
			this.timelineActivity.Size = new System.Drawing.Size(900, 400);
			this.timelineActivity.TabIndex = 1;
			this.timelineActivity.TimeFormat = "MMM d, yyyy  HH:mm";
			//
			// activityStrip
			//
			this.activityStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonLogActivityTab,
			this.labelActivityCount});
			this.activityStrip.Location = new System.Drawing.Point(0, 0);
			this.activityStrip.Name = "activityStrip";
			this.activityStrip.Padding = new Wisej.Web.Padding(2, 2, 2, 2);
			this.activityStrip.Size = new System.Drawing.Size(800, 27);
			this.activityStrip.TabIndex = 0;
			this.activityStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.activityStrip.BackColor = System.Drawing.SystemColors.Window;
			this.activityStrip.CssClass = "relay-toolbar";
			//
			// buttonLogActivityTab
			//
			this.buttonLogActivityTab.Tag = "journal-plus";
			this.buttonLogActivityTab.Name = "buttonLogActivityTab";
			this.buttonLogActivityTab.Text = "Log activity...";
			this.buttonLogActivityTab.Click += new System.EventHandler(this.buttonLogActivity_Click);
			//
			// labelActivityCount
			//
			this.labelActivityCount.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelActivityCount.Name = "labelActivityCount";
			this.labelActivityCount.Text = "No activities yet";
			//
			// tabTasks
			//
			this.tabTasks.Controls.Add(this.emptyTasks);
			this.tabTasks.Controls.Add(this.gridTasks);
			this.tabTasks.Controls.Add(this.tasksStrip);
			this.tabTasks.Location = new System.Drawing.Point(4, 24);
			this.tabTasks.Name = "tabTasks";
			this.tabTasks.Padding = new Wisej.Web.Padding(3);
			this.tabTasks.Size = new System.Drawing.Size(992, 440);
			this.tabTasks.TabIndex = 0;
			this.tabTasks.Text = "Tasks";
			//
			// emptyTasks
			//
			this.emptyTasks.Compact = true;
			this.emptyTasks.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyTasks.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
			this.emptyTasks.Location = new System.Drawing.Point(3, 30);
			this.emptyTasks.Name = "emptyTasks";
			this.emptyTasks.Size = new System.Drawing.Size(900, 400);
			this.emptyTasks.TabIndex = 2;
			this.emptyTasks.Title = "No tasks.";
			this.emptyTasks.Visible = false;
			//
			// gridTasks
			//
			this.gridTasks.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colTaskTitle,
			this.colTaskDue,
			this.colTaskPriority,
			this.colTaskStatus,
			this.colTaskAssignee});
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
			this.gridTasks.BorderStyle = Wisej.Web.BorderStyle.None;
			this.gridTasks.CssClass = "relay-grid";
			this.gridTasks.RowTemplate.Height = 44;
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
			dataGridViewCellStyle4.Format = "MMM d, yyyy";
			this.colTaskDue.DataPropertyName = "DueDate";
			this.colTaskDue.DefaultCellStyle = dataGridViewCellStyle4;
			this.colTaskDue.HeaderText = "Due";
			this.colTaskDue.Name = "colTaskDue";
			this.colTaskDue.Width = 110;
			//
			// colTaskPriority
			//
			this.colTaskPriority.DataPropertyName = "Priority";
			this.colTaskPriority.HeaderText = "Priority";
			this.colTaskPriority.Name = "colTaskPriority";
			this.colTaskPriority.Width = 80;
			//
			// colTaskStatus
			//
			this.colTaskStatus.DataPropertyName = "Status";
			this.colTaskStatus.HeaderText = "Status";
			this.colTaskStatus.Name = "colTaskStatus";
			this.colTaskStatus.Width = 90;
			//
			// colTaskAssignee
			//
			this.colTaskAssignee.DataPropertyName = "AssigneeName";
			this.colTaskAssignee.HeaderText = "Assignee";
			this.colTaskAssignee.Name = "colTaskAssignee";
			this.colTaskAssignee.Width = 140;
			this.colTaskAssignee.TextMember = "AssigneeName";
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
			this.tasksStrip.CssClass = "relay-toolbar";
			//
			// buttonAddTaskTab
			//
			this.buttonAddTaskTab.Tag = "check2-square";
			this.buttonAddTaskTab.Name = "buttonAddTaskTab";
			this.buttonAddTaskTab.Text = "Add task...";
			this.buttonAddTaskTab.Click += new System.EventHandler(this.buttonAddTask_Click);
			//
			// CompanyDetailView
			//
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.tableKpis);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.panelHeader);
			this.CssClass = "relay-card";
			this.Name = "CompanyDetailView";
			this.Size = new System.Drawing.Size(1000, 640);
			this.tasksStrip.ResumeLayout(false);
			this.tasksStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTasks)).EndInit();
			this.tabTasks.ResumeLayout(false);
			this.tabTasks.PerformLayout();
			this.activityStrip.ResumeLayout(false);
			this.activityStrip.PerformLayout();
			this.tabActivity.ResumeLayout(false);
			this.tabActivity.PerformLayout();
			this.dealsStrip.ResumeLayout(false);
			this.dealsStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridDeals)).EndInit();
			this.tabDeals.ResumeLayout(false);
			this.tabDeals.PerformLayout();
			this.contactsStrip.ResumeLayout(false);
			this.contactsStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridContacts)).EndInit();
			this.tabContacts.ResumeLayout(false);
			this.tabContacts.PerformLayout();
			this.tabOverview.ResumeLayout(false);
			this.tabOverview.PerformLayout();
			this.flowSubtitle.ResumeLayout(false);
			this.flowSubtitle.PerformLayout();
			this.panelHeader.ResumeLayout(false);
			this.panelHeader.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.kpiLastActivity.ResumeLayout(false);
			this.kpiLastActivity.PerformLayout();
			this.kpiContacts.ResumeLayout(false);
			this.kpiContacts.PerformLayout();
			this.kpiWonThisYear.ResumeLayout(false);
			this.kpiWonThisYear.PerformLayout();
			this.kpiOpenPipeline.ResumeLayout(false);
			this.kpiOpenPipeline.PerformLayout();
			this.tableKpis.ResumeLayout(false);
			this.tableKpis.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.TabControl tabControl;
		private Wisej.Web.TableLayoutPanel tableKpis;
		private Wisej.Web.KpiPanel kpiOpenPipeline;
		private Wisej.Web.KpiPanel kpiWonThisYear;
		private Wisej.Web.KpiPanel kpiContacts;
		private Wisej.Web.KpiPanel kpiLastActivity;
		private Wisej.Web.ToolBar toolStrip;
		private Wisej.Web.ToolBarButton buttonLogActivity;
		private Wisej.Web.ToolBarButton buttonNewContact;
		private Wisej.Web.ToolBarButton buttonNewDeal;
		private Wisej.Web.ToolBarButton buttonAddTask;
		private Wisej.Web.ToolBarButton toolStripSeparator1;
		private Wisej.Web.ToolBarButton buttonEdit;
		private Wisej.Web.ToolBarButton buttonDelete;
		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.LinkLabel linkBack;
		private Wisej.Web.Avatar avatar;
		private Wisej.Web.Label labelName;
		private Wisej.Web.FlowLayoutPanel flowSubtitle;
		private Wisej.Web.Label labelSubtitle;
		private Wisej.Web.Label labelDot1;
		private Wisej.Web.LinkLabel linkWebsite;
		private Wisej.Web.Label labelDot2;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.Label labelDot3;
		private Wisej.Web.Label labelTags;
		private Wisej.Web.TabPage tabOverview;
		private Wisej.Web.Label labelCapIndustry;
		private Wisej.Web.TextBox textBoxIndustry;
		private Wisej.Web.Label labelCapSize;
		private Wisej.Web.TextBox textBoxSize;
		private Wisej.Web.Label labelCapRevenue;
		private Wisej.Web.TextBox textBoxRevenue;
		private Wisej.Web.Label labelCapWebsite;
		private Wisej.Web.TextBox textBoxWebsite;
		private Wisej.Web.Label labelCapPhone;
		private Wisej.Web.TextBox textBoxPhone;
		private Wisej.Web.Label labelCapOwner;
		private Wisej.Web.TextBox textBoxOwner;
		private Wisej.Web.Label labelCapAddress;
		private Wisej.Web.TextBox textBoxAddress;
		private Wisej.Web.Label labelCapCity;
		private Wisej.Web.TextBox textBoxCity;
		private Wisej.Web.Label labelCapCountry;
		private Wisej.Web.TextBox textBoxCountry;
		private Wisej.Web.Label labelCapTagList;
		private Wisej.Web.TextBox textBoxTagList;
		private Wisej.Web.Label labelCapCreated;
		private Wisej.Web.TextBox textBoxCreated;
		private Wisej.Web.Label labelCapUpdated;
		private Wisej.Web.TextBox textBoxUpdated;
		private Wisej.Web.TabPage tabContacts;
		private Wisej.Web.EmptyState emptyContacts;
		private Wisej.Web.DataGridView gridContacts;
		private Wisej.Web.DataGridViewAvatarColumn colContactName;
		private Wisej.Web.DataGridViewTextBoxColumn colContactTitle;
		private Wisej.Web.DataGridViewTextBoxColumn colContactEmail;
		private Wisej.Web.DataGridViewTextBoxColumn colContactPhone;
		private Wisej.Web.DataGridViewChipColumn colContactStage;
		private Wisej.Web.DataGridViewTextBoxColumn colContactLast;
		private Wisej.Web.ToolBar contactsStrip;
		private Wisej.Web.ToolBarButton buttonNewContactTab;
		private Wisej.Web.TabPage tabDeals;
		private Wisej.Web.EmptyState emptyDeals;
		private Wisej.Web.DataGridView gridDeals;
		private Wisej.Web.DataGridViewTextBoxColumn colDealTitle;
		private Wisej.Web.DataGridViewChipColumn colDealStage;
		private Wisej.Web.DataGridViewTextBoxColumn colDealAmount;
		private Wisej.Web.DataGridViewTextBoxColumn colDealClose;
		private Wisej.Web.DataGridViewTextBoxColumn colDealProbability;
		private Wisej.Web.DataGridViewAvatarColumn colDealOwner;
		private Wisej.Web.ToolBar dealsStrip;
		private Wisej.Web.ToolBarButton buttonNewDealTab;
		private Wisej.Web.TabPage tabActivity;
		private Wisej.Web.EmptyState emptyActivity;
		private Wisej.Web.Timeline timelineActivity;
		private Wisej.Web.ToolBar activityStrip;
		private Wisej.Web.ToolBarButton buttonLogActivityTab;
		private Wisej.Web.ToolBarButton labelActivityCount;
		private Wisej.Web.TabPage tabTasks;
		private Wisej.Web.EmptyState emptyTasks;
		private Wisej.Web.DataGridView gridTasks;
		private Wisej.Web.DataGridViewTextBoxColumn colTaskTitle;
		private Wisej.Web.DataGridViewTextBoxColumn colTaskDue;
		private Wisej.Web.DataGridViewTextBoxColumn colTaskPriority;
		private Wisej.Web.DataGridViewChipColumn colTaskStatus;
		private Wisej.Web.DataGridViewAvatarColumn colTaskAssignee;
		private Wisej.Web.ToolBar tasksStrip;
		private Wisej.Web.ToolBarButton buttonAddTaskTab;
	}
}
