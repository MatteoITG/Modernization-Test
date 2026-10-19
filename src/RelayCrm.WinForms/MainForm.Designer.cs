namespace RelayCrm
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Dashboard");
			System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Contacts");
			System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Companies");
			System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Deals");
			System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Activities");
			System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Tasks");
			System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Reports");
			System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Settings");
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuNewContact = new System.Windows.Forms.ToolStripMenuItem();
			this.menuNewCompany = new System.Windows.Forms.ToolStripMenuItem();
			this.menuNewDeal = new System.Windows.Forms.ToolStripMenuItem();
			this.menuNewTask = new System.Windows.Forms.ToolStripMenuItem();
			this.menuLogActivity = new System.Windows.Forms.ToolStripMenuItem();
			this.menuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuSignOut = new System.Windows.Forms.ToolStripMenuItem();
			this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuView = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSearch = new System.Windows.Forms.ToolStripMenuItem();
			this.menuBack = new System.Windows.Forms.ToolStripMenuItem();
			this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
			this.menuViewSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuDashboard = new System.Windows.Forms.ToolStripMenuItem();
			this.menuContacts = new System.Windows.Forms.ToolStripMenuItem();
			this.menuCompanies = new System.Windows.Forms.ToolStripMenuItem();
			this.menuDeals = new System.Windows.Forms.ToolStripMenuItem();
			this.menuActivities = new System.Windows.Forms.ToolStripMenuItem();
			this.menuTasks = new System.Windows.Forms.ToolStripMenuItem();
			this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.buttonBack = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.textSearch = new System.Windows.Forms.ToolStripTextBox();
			this.buttonSearch = new System.Windows.Forms.ToolStripButton();
			this.dropDownUser = new System.Windows.Forms.ToolStripDropDownButton();
			this.menuUserProfile = new System.Windows.Forms.ToolStripMenuItem();
			this.menuUserSettings = new System.Windows.Forms.ToolStripMenuItem();
			this.menuUserSeparator = new System.Windows.Forms.ToolStripSeparator();
			this.menuUserSignOut = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonNotifications = new System.Windows.Forms.ToolStripButton();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.statusMessage = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusOverdue = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.treeNav = new System.Windows.Forms.TreeView();
			this.panelMain = new System.Windows.Forms.Panel();
			this.timerStatus = new System.Windows.Forms.Timer(this.components);
			this.menuStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.statusStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.SuspendLayout();
			//
			// menuStrip
			//
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuFile,
			this.menuView,
			this.menuHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1264, 24);
			this.menuStrip.TabIndex = 0;
			//
			// menuFile
			//
			this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuNewContact,
			this.menuNewCompany,
			this.menuNewDeal,
			this.menuNewTask,
			this.menuLogActivity,
			this.menuFileSeparator1,
			this.menuSignOut,
			this.menuExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Size = new System.Drawing.Size(37, 20);
			this.menuFile.Text = "&File";
			//
			// menuNewContact
			//
			this.menuNewContact.Name = "menuNewContact";
			this.menuNewContact.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
			this.menuNewContact.Size = new System.Drawing.Size(220, 22);
			this.menuNewContact.Tag = "person";
			this.menuNewContact.Text = "New &contact...";
			this.menuNewContact.Click += new System.EventHandler(this.menuNewContact_Click);
			//
			// menuNewCompany
			//
			this.menuNewCompany.Name = "menuNewCompany";
			this.menuNewCompany.Size = new System.Drawing.Size(220, 22);
			this.menuNewCompany.Tag = "building";
			this.menuNewCompany.Text = "New c&ompany...";
			this.menuNewCompany.Click += new System.EventHandler(this.menuNewCompany_Click);
			//
			// menuNewDeal
			//
			this.menuNewDeal.Name = "menuNewDeal";
			this.menuNewDeal.Size = new System.Drawing.Size(220, 22);
			this.menuNewDeal.Tag = "briefcase";
			this.menuNewDeal.Text = "New &deal...";
			this.menuNewDeal.Click += new System.EventHandler(this.menuNewDeal_Click);
			//
			// menuNewTask
			//
			this.menuNewTask.Name = "menuNewTask";
			this.menuNewTask.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
			this.menuNewTask.Size = new System.Drawing.Size(220, 22);
			this.menuNewTask.Tag = "check2-square";
			this.menuNewTask.Text = "New &task...";
			this.menuNewTask.Click += new System.EventHandler(this.menuNewTask_Click);
			//
			// menuLogActivity
			//
			this.menuLogActivity.Name = "menuLogActivity";
			this.menuLogActivity.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
			this.menuLogActivity.Size = new System.Drawing.Size(220, 22);
			this.menuLogActivity.Tag = "journal-plus";
			this.menuLogActivity.Text = "&Log activity...";
			this.menuLogActivity.Click += new System.EventHandler(this.menuLogActivity_Click);
			//
			// menuFileSeparator1
			//
			this.menuFileSeparator1.Name = "menuFileSeparator1";
			this.menuFileSeparator1.Size = new System.Drawing.Size(217, 6);
			//
			// menuSignOut
			//
			this.menuSignOut.Name = "menuSignOut";
			this.menuSignOut.Size = new System.Drawing.Size(220, 22);
			this.menuSignOut.Tag = "box-arrow-right";
			this.menuSignOut.Text = "&Sign out";
			this.menuSignOut.Click += new System.EventHandler(this.menuSignOut_Click);
			//
			// menuExit
			//
			this.menuExit.Name = "menuExit";
			this.menuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
			this.menuExit.Size = new System.Drawing.Size(220, 22);
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			//
			// menuView
			//
			this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuSearch,
			this.menuBack,
			this.menuRefresh,
			this.menuViewSeparator1,
			this.menuDashboard,
			this.menuContacts,
			this.menuCompanies,
			this.menuDeals,
			this.menuActivities,
			this.menuTasks,
			this.menuReports,
			this.menuSettings});
			this.menuView.Name = "menuView";
			this.menuView.Size = new System.Drawing.Size(44, 20);
			this.menuView.Text = "&View";
			//
			// menuSearch
			//
			this.menuSearch.Name = "menuSearch";
			this.menuSearch.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
			this.menuSearch.Size = new System.Drawing.Size(220, 22);
			this.menuSearch.Tag = "search";
			this.menuSearch.Text = "&Search...";
			this.menuSearch.Click += new System.EventHandler(this.menuSearch_Click);
			//
			// menuBack
			//
			this.menuBack.Name = "menuBack";
			this.menuBack.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
			this.menuBack.Size = new System.Drawing.Size(220, 22);
			this.menuBack.Tag = "arrow-left";
			this.menuBack.Text = "&Back";
			this.menuBack.Click += new System.EventHandler(this.buttonBack_Click);
			//
			// menuRefresh
			//
			this.menuRefresh.Name = "menuRefresh";
			this.menuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.menuRefresh.Size = new System.Drawing.Size(220, 22);
			this.menuRefresh.Tag = "arrow-clockwise";
			this.menuRefresh.Text = "&Refresh";
			this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
			//
			// menuViewSeparator1
			//
			this.menuViewSeparator1.Name = "menuViewSeparator1";
			this.menuViewSeparator1.Size = new System.Drawing.Size(217, 6);
			//
			// menuDashboard
			//
			this.menuDashboard.Name = "menuDashboard";
			this.menuDashboard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
			this.menuDashboard.Size = new System.Drawing.Size(220, 22);
			this.menuDashboard.Tag = "DashboardView";
			this.menuDashboard.Text = "&Dashboard";
			this.menuDashboard.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuContacts
			//
			this.menuContacts.Name = "menuContacts";
			this.menuContacts.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
			this.menuContacts.Size = new System.Drawing.Size(220, 22);
			this.menuContacts.Tag = "ContactsView";
			this.menuContacts.Text = "&Contacts";
			this.menuContacts.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuCompanies
			//
			this.menuCompanies.Name = "menuCompanies";
			this.menuCompanies.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
			this.menuCompanies.Size = new System.Drawing.Size(220, 22);
			this.menuCompanies.Tag = "CompaniesView";
			this.menuCompanies.Text = "C&ompanies";
			this.menuCompanies.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuDeals
			//
			this.menuDeals.Name = "menuDeals";
			this.menuDeals.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D4)));
			this.menuDeals.Size = new System.Drawing.Size(220, 22);
			this.menuDeals.Tag = "DealsView";
			this.menuDeals.Text = "D&eals";
			this.menuDeals.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuActivities
			//
			this.menuActivities.Name = "menuActivities";
			this.menuActivities.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D5)));
			this.menuActivities.Size = new System.Drawing.Size(220, 22);
			this.menuActivities.Tag = "ActivitiesView";
			this.menuActivities.Text = "&Activities";
			this.menuActivities.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuTasks
			//
			this.menuTasks.Name = "menuTasks";
			this.menuTasks.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D6)));
			this.menuTasks.Size = new System.Drawing.Size(220, 22);
			this.menuTasks.Tag = "TasksView";
			this.menuTasks.Text = "&Tasks";
			this.menuTasks.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuReports
			//
			this.menuReports.Name = "menuReports";
			this.menuReports.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D7)));
			this.menuReports.Size = new System.Drawing.Size(220, 22);
			this.menuReports.Tag = "ReportsView";
			this.menuReports.Text = "&Reports";
			this.menuReports.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuSettings
			//
			this.menuSettings.Name = "menuSettings";
			this.menuSettings.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D8)));
			this.menuSettings.Size = new System.Drawing.Size(220, 22);
			this.menuSettings.Tag = "SettingsView";
			this.menuSettings.Text = "&Settings";
			this.menuSettings.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuHelp
			//
			this.menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuAbout});
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Size = new System.Drawing.Size(44, 20);
			this.menuHelp.Text = "&Help";
			//
			// menuAbout
			//
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.Size = new System.Drawing.Size(180, 22);
			this.menuAbout.Text = "&About Relay...";
			this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
			//
			// toolStrip
			//
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonBack,
			this.toolStripSeparator1,
			this.textSearch,
			this.buttonSearch,
			this.dropDownUser,
			this.buttonNotifications});
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(1264, 29);
			this.toolStrip.TabIndex = 1;
			//
			// buttonBack
			//
			this.buttonBack.Enabled = false;
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(36, 22);
			this.buttonBack.Tag = "arrow-left";
			this.buttonBack.Text = "Back";
			this.buttonBack.ToolTipText = "Back to the list (Alt+Left)";
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			//
			// textSearch
			//
			this.textSearch.AutoSize = false;
			this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSearch.Name = "textSearch";
			this.textSearch.Size = new System.Drawing.Size(320, 23);
			this.textSearch.ToolTipText = "Search pages, contacts, companies and deals (Ctrl+K)";
			this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
			//
			// buttonSearch
			//
			this.buttonSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(23, 22);
			this.buttonSearch.Tag = "search";
			this.buttonSearch.Text = "Search";
			this.buttonSearch.ToolTipText = "Search (Ctrl+K)";
			this.buttonSearch.Click += new System.EventHandler(this.menuSearch_Click);
			//
			// dropDownUser
			//
			this.dropDownUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.dropDownUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuUserProfile,
			this.menuUserSettings,
			this.menuUserSeparator,
			this.menuUserSignOut});
			this.dropDownUser.Name = "dropDownUser";
			this.dropDownUser.Size = new System.Drawing.Size(60, 22);
			this.dropDownUser.Tag = "person";
			this.dropDownUser.Text = "User";
			//
			// menuUserProfile
			//
			this.menuUserProfile.Name = "menuUserProfile";
			this.menuUserProfile.Size = new System.Drawing.Size(180, 22);
			this.menuUserProfile.Text = "&Profile";
			this.menuUserProfile.Click += new System.EventHandler(this.menuUserProfile_Click);
			//
			// menuUserSettings
			//
			this.menuUserSettings.Name = "menuUserSettings";
			this.menuUserSettings.Size = new System.Drawing.Size(180, 22);
			this.menuUserSettings.Tag = "SettingsView";
			this.menuUserSettings.Text = "&Settings";
			this.menuUserSettings.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuUserSeparator
			//
			this.menuUserSeparator.Name = "menuUserSeparator";
			this.menuUserSeparator.Size = new System.Drawing.Size(177, 6);
			//
			// menuUserSignOut
			//
			this.menuUserSignOut.Name = "menuUserSignOut";
			this.menuUserSignOut.Size = new System.Drawing.Size(180, 22);
			this.menuUserSignOut.Text = "Sign &out";
			this.menuUserSignOut.Click += new System.EventHandler(this.menuSignOut_Click);
			//
			// buttonNotifications
			//
			this.buttonNotifications.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.buttonNotifications.Name = "buttonNotifications";
			this.buttonNotifications.Size = new System.Drawing.Size(23, 22);
			this.buttonNotifications.Tag = "bell";
			this.buttonNotifications.ToolTipText = "Notifications";
			this.buttonNotifications.Click += new System.EventHandler(this.buttonNotifications_Click);
			//
			// statusStrip
			//
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.statusMessage,
			this.statusOverdue,
			this.statusUser});
			this.statusStrip.Location = new System.Drawing.Point(0, 659);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.ShowItemToolTips = true;
			this.statusStrip.Size = new System.Drawing.Size(1264, 22);
			this.statusStrip.TabIndex = 3;
			//
			// statusMessage
			//
			this.statusMessage.Name = "statusMessage";
			this.statusMessage.Size = new System.Drawing.Size(1003, 17);
			this.statusMessage.Spring = true;
			this.statusMessage.Text = "Ready";
			this.statusMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// statusOverdue
			//
			this.statusOverdue.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.statusOverdue.IsLink = true;
			this.statusOverdue.Name = "statusOverdue";
			this.statusOverdue.Size = new System.Drawing.Size(110, 17);
			this.statusOverdue.Text = "No overdue tasks";
			this.statusOverdue.ToolTipText = "Open your tasks";
			this.statusOverdue.Click += new System.EventHandler(this.statusOverdue_Click);
			//
			// statusUser
			//
			this.statusUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
			this.statusUser.Name = "statusUser";
			this.statusUser.Size = new System.Drawing.Size(136, 17);
			this.statusUser.Text = "Not signed in";
			//
			// splitContainer
			//
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.Location = new System.Drawing.Point(0, 53);
			this.splitContainer.Name = "splitContainer";
			//
			// splitContainer.Panel1
			//
			this.splitContainer.Panel1.Controls.Add(this.treeNav);
			this.splitContainer.Panel1MinSize = 120;
			//
			// splitContainer.Panel2
			//
			this.splitContainer.Panel2.Controls.Add(this.panelMain);
			this.splitContainer.Size = new System.Drawing.Size(1264, 606);
			this.splitContainer.SplitterDistance = 170;
			this.splitContainer.TabIndex = 2;
			//
			// treeNav
			//
			this.treeNav.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeNav.FullRowSelect = true;
			this.treeNav.HideSelection = false;
			this.treeNav.ItemHeight = 28;
			this.treeNav.Location = new System.Drawing.Point(0, 0);
			this.treeNav.Name = "treeNav";
			treeNode1.ImageKey = "speedometer2";
			treeNode1.Name = "nodeDashboard";
			treeNode1.SelectedImageKey = "speedometer2";
			treeNode1.Tag = "DashboardView";
			treeNode1.Text = "Dashboard";
			treeNode2.ImageKey = "person";
			treeNode2.Name = "nodeContacts";
			treeNode2.SelectedImageKey = "person";
			treeNode2.Tag = "ContactsView";
			treeNode2.Text = "Contacts";
			treeNode3.ImageKey = "building";
			treeNode3.Name = "nodeCompanies";
			treeNode3.SelectedImageKey = "building";
			treeNode3.Tag = "CompaniesView";
			treeNode3.Text = "Companies";
			treeNode4.ImageKey = "briefcase";
			treeNode4.Name = "nodeDeals";
			treeNode4.SelectedImageKey = "briefcase";
			treeNode4.Tag = "DealsView";
			treeNode4.Text = "Deals";
			treeNode5.ImageKey = "calendar-event";
			treeNode5.Name = "nodeActivities";
			treeNode5.SelectedImageKey = "calendar-event";
			treeNode5.Tag = "ActivitiesView";
			treeNode5.Text = "Activities";
			treeNode6.ImageKey = "check2-square";
			treeNode6.Name = "nodeTasks";
			treeNode6.SelectedImageKey = "check2-square";
			treeNode6.Tag = "TasksView";
			treeNode6.Text = "Tasks";
			treeNode7.ImageKey = "bar-chart";
			treeNode7.Name = "nodeReports";
			treeNode7.SelectedImageKey = "bar-chart";
			treeNode7.Tag = "ReportsView";
			treeNode7.Text = "Reports";
			treeNode8.ImageKey = "gear";
			treeNode8.Name = "nodeSettings";
			treeNode8.SelectedImageKey = "gear";
			treeNode8.Tag = "SettingsView";
			treeNode8.Text = "Settings";
			this.treeNav.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
			treeNode1,
			treeNode2,
			treeNode3,
			treeNode4,
			treeNode5,
			treeNode6,
			treeNode7,
			treeNode8});
			this.treeNav.ShowLines = false;
			this.treeNav.ShowPlusMinus = false;
			this.treeNav.ShowRootLines = false;
			this.treeNav.Size = new System.Drawing.Size(170, 606);
			this.treeNav.TabIndex = 0;
			this.treeNav.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeNav_AfterSelect);
			//
			// panelMain
			//
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(1090, 606);
			this.panelMain.TabIndex = 0;
			//
			// timerStatus
			//
			this.timerStatus.Interval = 10000;
			this.timerStatus.Tick += new System.EventHandler(this.timerStatus_Tick);
			//
			// MainForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.MainMenuStrip = this.menuStrip;
			this.MinimumSize = new System.Drawing.Size(960, 600);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Relay CRM";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Shown += new System.EventHandler(this.MainForm_Shown);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem menuFile;
		private System.Windows.Forms.ToolStripMenuItem menuNewContact;
		private System.Windows.Forms.ToolStripMenuItem menuNewCompany;
		private System.Windows.Forms.ToolStripMenuItem menuNewDeal;
		private System.Windows.Forms.ToolStripMenuItem menuNewTask;
		private System.Windows.Forms.ToolStripMenuItem menuLogActivity;
		private System.Windows.Forms.ToolStripSeparator menuFileSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuSignOut;
		private System.Windows.Forms.ToolStripMenuItem menuExit;
		private System.Windows.Forms.ToolStripMenuItem menuView;
		private System.Windows.Forms.ToolStripMenuItem menuSearch;
		private System.Windows.Forms.ToolStripMenuItem menuBack;
		private System.Windows.Forms.ToolStripMenuItem menuRefresh;
		private System.Windows.Forms.ToolStripSeparator menuViewSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuDashboard;
		private System.Windows.Forms.ToolStripMenuItem menuContacts;
		private System.Windows.Forms.ToolStripMenuItem menuCompanies;
		private System.Windows.Forms.ToolStripMenuItem menuDeals;
		private System.Windows.Forms.ToolStripMenuItem menuActivities;
		private System.Windows.Forms.ToolStripMenuItem menuTasks;
		private System.Windows.Forms.ToolStripMenuItem menuReports;
		private System.Windows.Forms.ToolStripMenuItem menuSettings;
		private System.Windows.Forms.ToolStripMenuItem menuHelp;
		private System.Windows.Forms.ToolStripMenuItem menuAbout;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton buttonBack;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripTextBox textSearch;
		private System.Windows.Forms.ToolStripButton buttonSearch;
		private System.Windows.Forms.ToolStripDropDownButton dropDownUser;
		private System.Windows.Forms.ToolStripMenuItem menuUserProfile;
		private System.Windows.Forms.ToolStripMenuItem menuUserSettings;
		private System.Windows.Forms.ToolStripSeparator menuUserSeparator;
		private System.Windows.Forms.ToolStripMenuItem menuUserSignOut;
		private System.Windows.Forms.ToolStripButton buttonNotifications;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel statusMessage;
		private System.Windows.Forms.ToolStripStatusLabel statusOverdue;
		private System.Windows.Forms.ToolStripStatusLabel statusUser;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.TreeView treeNav;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Timer timerStatus;
	}
}
