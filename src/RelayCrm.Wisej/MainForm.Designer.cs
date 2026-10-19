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
			Wisej.Web.TreeNode treeNode1 = new Wisej.Web.TreeNode("Dashboard");
			Wisej.Web.TreeNode treeNode2 = new Wisej.Web.TreeNode("Contacts");
			Wisej.Web.TreeNode treeNode3 = new Wisej.Web.TreeNode("Companies");
			Wisej.Web.TreeNode treeNode4 = new Wisej.Web.TreeNode("Deals");
			Wisej.Web.TreeNode treeNode5 = new Wisej.Web.TreeNode("Activities");
			Wisej.Web.TreeNode treeNode6 = new Wisej.Web.TreeNode("Tasks");
			Wisej.Web.TreeNode treeNode7 = new Wisej.Web.TreeNode("Reports");
			Wisej.Web.TreeNode treeNode8 = new Wisej.Web.TreeNode("Settings");
			this.menuStrip = new Wisej.Web.MenuBar();
			this.menuFile = new Wisej.Web.MenuItem();
			this.menuNewContact = new Wisej.Web.MenuItem();
			this.menuNewCompany = new Wisej.Web.MenuItem();
			this.menuNewDeal = new Wisej.Web.MenuItem();
			this.menuNewTask = new Wisej.Web.MenuItem();
			this.menuLogActivity = new Wisej.Web.MenuItem();
			this.menuFileSeparator1 = new Wisej.Web.MenuItem();
			this.menuSignOut = new Wisej.Web.MenuItem();
			this.menuExit = new Wisej.Web.MenuItem();
			this.menuView = new Wisej.Web.MenuItem();
			this.menuSearch = new Wisej.Web.MenuItem();
			this.menuBack = new Wisej.Web.MenuItem();
			this.menuRefresh = new Wisej.Web.MenuItem();
			this.menuViewSeparator1 = new Wisej.Web.MenuItem();
			this.menuDashboard = new Wisej.Web.MenuItem();
			this.menuContacts = new Wisej.Web.MenuItem();
			this.menuCompanies = new Wisej.Web.MenuItem();
			this.menuDeals = new Wisej.Web.MenuItem();
			this.menuActivities = new Wisej.Web.MenuItem();
			this.menuTasks = new Wisej.Web.MenuItem();
			this.menuReports = new Wisej.Web.MenuItem();
			this.menuSettings = new Wisej.Web.MenuItem();
			this.menuHelp = new Wisej.Web.MenuItem();
			this.menuAbout = new Wisej.Web.MenuItem();
			this.toolStrip = new Wisej.Web.ToolBar();
			this.buttonBack = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator1 = new Wisej.Web.ToolBarButton();
			this.textSearch = new Wisej.Web.TextBox();
			this.textSearchHost = new Wisej.Web.ToolBarControl();
			this.buttonSearch = new Wisej.Web.ToolBarButton();
			this.dropDownUser = new Wisej.Web.ToolBarButton();
			this.dropDownUserMenu = new Wisej.Web.ContextMenu(this.components);
			this.menuUserProfile = new Wisej.Web.MenuItem();
			this.menuUserSettings = new Wisej.Web.MenuItem();
			this.menuUserSeparator = new Wisej.Web.MenuItem();
			this.menuUserSignOut = new Wisej.Web.MenuItem();
			this.buttonNotifications = new Wisej.Web.ToolBarButton();
			this.statusStrip = new Wisej.Web.StatusBar();
			this.statusMessage = new Wisej.Web.StatusBarPanel();
			this.statusOverdue = new Wisej.Web.StatusBarPanel();
			this.statusUser = new Wisej.Web.StatusBarPanel();
			this.splitContainer = new Wisej.Web.SplitContainer();
			this.treeNav = new Wisej.Web.TreeView();
			this.panelMain = new Wisej.Web.Panel();
			this.timerStatus = new Wisej.Web.Timer(this.components);
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
			this.menuStrip.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuFile,
			this.menuView,
			this.menuHelp});
			this.menuStrip.Dock = Wisej.Web.DockStyle.Top;
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(1264, 24);
			this.menuStrip.TabIndex = 0;
			//
			// menuFile
			//
			this.menuFile.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuNewContact,
			this.menuNewCompany,
			this.menuNewDeal,
			this.menuNewTask,
			this.menuLogActivity,
			this.menuFileSeparator1,
			this.menuSignOut,
			this.menuExit});
			this.menuFile.Name = "menuFile";
			this.menuFile.Text = "&File";
			//
			// menuNewContact
			//
			this.menuNewContact.Name = "menuNewContact";
			this.menuNewContact.Shortcut = Wisej.Web.Shortcut.CtrlN;
			this.menuNewContact.Tag = "person";
			this.menuNewContact.Text = "New &contact...";
			this.menuNewContact.Click += new System.EventHandler(this.menuNewContact_Click);
			//
			// menuNewCompany
			//
			this.menuNewCompany.Name = "menuNewCompany";
			this.menuNewCompany.Tag = "building";
			this.menuNewCompany.Text = "New c&ompany...";
			this.menuNewCompany.Click += new System.EventHandler(this.menuNewCompany_Click);
			//
			// menuNewDeal
			//
			this.menuNewDeal.Name = "menuNewDeal";
			this.menuNewDeal.Tag = "briefcase";
			this.menuNewDeal.Text = "New &deal...";
			this.menuNewDeal.Click += new System.EventHandler(this.menuNewDeal_Click);
			//
			// menuNewTask
			//
			this.menuNewTask.Name = "menuNewTask";
			this.menuNewTask.Shortcut = Wisej.Web.Shortcut.CtrlT;
			this.menuNewTask.Tag = "check2-square";
			this.menuNewTask.Text = "New &task...";
			this.menuNewTask.Click += new System.EventHandler(this.menuNewTask_Click);
			//
			// menuLogActivity
			//
			this.menuLogActivity.Name = "menuLogActivity";
			this.menuLogActivity.Shortcut = Wisej.Web.Shortcut.CtrlL;
			this.menuLogActivity.Tag = "journal-plus";
			this.menuLogActivity.Text = "&Log activity...";
			this.menuLogActivity.Click += new System.EventHandler(this.menuLogActivity_Click);
			//
			// menuFileSeparator1
			//
			this.menuFileSeparator1.Name = "menuFileSeparator1";
			this.menuFileSeparator1.Text = "-";
			//
			// menuSignOut
			//
			this.menuSignOut.Name = "menuSignOut";
			this.menuSignOut.Tag = "box-arrow-right";
			this.menuSignOut.Text = "&Sign out";
			this.menuSignOut.Click += new System.EventHandler(this.menuSignOut_Click);
			//
			// menuExit
			//
			this.menuExit.Name = "menuExit";
			this.menuExit.Shortcut = Wisej.Web.Shortcut.AltF4;
			this.menuExit.Text = "E&xit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			//
			// menuView
			//
			this.menuView.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
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
			this.menuView.Text = "&View";
			//
			// menuSearch
			//
			this.menuSearch.Name = "menuSearch";
			this.menuSearch.Shortcut = Wisej.Web.Shortcut.CtrlK;
			this.menuSearch.Tag = "search";
			this.menuSearch.Text = "&Search...";
			this.menuSearch.Click += new System.EventHandler(this.menuSearch_Click);
			//
			// menuBack
			//
			this.menuBack.Name = "menuBack";
			this.menuBack.Shortcut = Wisej.Web.Shortcut.AltLeftArrow;
			this.menuBack.Tag = "arrow-left";
			this.menuBack.Text = "&Back";
			this.menuBack.Click += new System.EventHandler(this.buttonBack_Click);
			//
			// menuRefresh
			//
			this.menuRefresh.Name = "menuRefresh";
			this.menuRefresh.Shortcut = Wisej.Web.Shortcut.F5;
			this.menuRefresh.Tag = "arrow-clockwise";
			this.menuRefresh.Text = "&Refresh";
			this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
			//
			// menuViewSeparator1
			//
			this.menuViewSeparator1.Name = "menuViewSeparator1";
			this.menuViewSeparator1.Text = "-";
			//
			// menuDashboard
			//
			this.menuDashboard.Name = "menuDashboard";
			this.menuDashboard.Shortcut = Wisej.Web.Shortcut.Ctrl1;
			this.menuDashboard.Tag = "DashboardView";
			this.menuDashboard.Text = "&Dashboard";
			this.menuDashboard.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuContacts
			//
			this.menuContacts.Name = "menuContacts";
			this.menuContacts.Shortcut = Wisej.Web.Shortcut.Ctrl2;
			this.menuContacts.Tag = "ContactsView";
			this.menuContacts.Text = "&Contacts";
			this.menuContacts.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuCompanies
			//
			this.menuCompanies.Name = "menuCompanies";
			this.menuCompanies.Shortcut = Wisej.Web.Shortcut.Ctrl3;
			this.menuCompanies.Tag = "CompaniesView";
			this.menuCompanies.Text = "C&ompanies";
			this.menuCompanies.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuDeals
			//
			this.menuDeals.Name = "menuDeals";
			this.menuDeals.Shortcut = Wisej.Web.Shortcut.Ctrl4;
			this.menuDeals.Tag = "DealsView";
			this.menuDeals.Text = "D&eals";
			this.menuDeals.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuActivities
			//
			this.menuActivities.Name = "menuActivities";
			this.menuActivities.Shortcut = Wisej.Web.Shortcut.Ctrl5;
			this.menuActivities.Tag = "ActivitiesView";
			this.menuActivities.Text = "&Activities";
			this.menuActivities.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuTasks
			//
			this.menuTasks.Name = "menuTasks";
			this.menuTasks.Shortcut = Wisej.Web.Shortcut.Ctrl6;
			this.menuTasks.Tag = "TasksView";
			this.menuTasks.Text = "&Tasks";
			this.menuTasks.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuReports
			//
			this.menuReports.Name = "menuReports";
			this.menuReports.Shortcut = Wisej.Web.Shortcut.Ctrl7;
			this.menuReports.Tag = "ReportsView";
			this.menuReports.Text = "&Reports";
			this.menuReports.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuSettings
			//
			this.menuSettings.Name = "menuSettings";
			this.menuSettings.Shortcut = Wisej.Web.Shortcut.Ctrl8;
			this.menuSettings.Tag = "SettingsView";
			this.menuSettings.Text = "&Settings";
			this.menuSettings.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuHelp
			//
			this.menuHelp.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuAbout});
			this.menuHelp.Name = "menuHelp";
			this.menuHelp.Text = "&Help";
			//
			// menuAbout
			//
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.Text = "&About Relay...";
			this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
			//
			// toolStrip
			//
			this.toolStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonBack,
			this.toolStripSeparator1,
			this.textSearchHost,
			this.buttonSearch,
			this.dropDownUser,
			this.buttonNotifications});
			this.toolStrip.Location = new System.Drawing.Point(0, 24);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new Wisej.Web.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(1264, 29);
			this.toolStrip.TabIndex = 1;
			this.toolStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			//
			// buttonBack
			//
			this.buttonBack.Enabled = false;
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Tag = "arrow-left";
			this.buttonBack.Text = "Back";
			this.buttonBack.ToolTipText = "Back to the list (Alt+Left)";
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// textSearch
			//
			this.textSearch.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.textSearch.Name = "textSearch";
			this.textSearchHost.Control = this.textSearch;
			this.textSearchHost.Name = "textSearchHost";
			this.textSearch.Size = new System.Drawing.Size(320, 23);
			this.textSearch.ToolTipText = "Search pages, contacts, companies and deals (Ctrl+K)";
			this.textSearch.KeyDown += new Wisej.Web.KeyEventHandler(this.textSearch_KeyDown);
			//
			// buttonSearch
			//
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Tag = "search";
			this.buttonSearch.Text = "Search";
			this.buttonSearch.ToolTipText = "Search (Ctrl+K)";
			this.buttonSearch.Click += new System.EventHandler(this.menuSearch_Click);
			//
			// dropDownUser
			//
			this.dropDownUserMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuUserProfile,
			this.menuUserSettings,
			this.menuUserSeparator,
			this.menuUserSignOut});
			this.dropDownUser.Name = "dropDownUser";
			this.dropDownUser.DropDownMenu = this.dropDownUserMenu;
			this.dropDownUser.Style = Wisej.Web.ToolBarButtonStyle.DropDownButton;
			this.dropDownUser.Tag = "person";
			this.dropDownUser.Text = "User";
			//
			// menuUserProfile
			//
			this.menuUserProfile.Name = "menuUserProfile";
			this.menuUserProfile.Text = "&Profile";
			this.menuUserProfile.Click += new System.EventHandler(this.menuUserProfile_Click);
			//
			// menuUserSettings
			//
			this.menuUserSettings.Name = "menuUserSettings";
			this.menuUserSettings.Tag = "SettingsView";
			this.menuUserSettings.Text = "&Settings";
			this.menuUserSettings.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuUserSeparator
			//
			this.menuUserSeparator.Name = "menuUserSeparator";
			this.menuUserSeparator.Text = "-";
			//
			// menuUserSignOut
			//
			this.menuUserSignOut.Name = "menuUserSignOut";
			this.menuUserSignOut.Text = "Sign &out";
			this.menuUserSignOut.Click += new System.EventHandler(this.menuSignOut_Click);
			//
			// buttonNotifications
			//
			this.buttonNotifications.Name = "buttonNotifications";
			this.buttonNotifications.Tag = "bell";
			this.buttonNotifications.ToolTipText = "Notifications";
			this.buttonNotifications.Click += new System.EventHandler(this.buttonNotifications_Click);
			//
			// statusStrip
			//
			this.statusStrip.Panels.AddRange(new Wisej.Web.StatusBarPanel[] {
			this.statusMessage,
			this.statusOverdue,
			this.statusUser});
			this.statusStrip.Location = new System.Drawing.Point(0, 659);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(1264, 22);
			this.statusStrip.TabIndex = 3;
			//
			// statusMessage
			//
			this.statusMessage.Name = "statusMessage";
			this.statusMessage.AutoSize = Wisej.Web.StatusBarPanelAutoSize.Spring;
			this.statusMessage.Text = "Ready";
			//
			// statusOverdue
			//
			this.statusOverdue.Name = "statusOverdue";
			this.statusOverdue.Text = "No overdue tasks";
			this.statusOverdue.ToolTipText = "Open your tasks";
			this.statusOverdue.Click += new System.EventHandler(this.statusOverdue_Click);
			//
			// statusUser
			//
			this.statusUser.Name = "statusUser";
			this.statusUser.Text = "Not signed in";
			//
			// splitContainer
			//
			this.splitContainer.Dock = Wisej.Web.DockStyle.Fill;
			this.splitContainer.FixedPanel = Wisej.Web.FixedPanel.Panel1;
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
			this.treeNav.Dock = Wisej.Web.DockStyle.Fill;
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
			this.treeNav.Nodes.AddRange(new Wisej.Web.TreeNode[] {
			treeNode1,
			treeNode2,
			treeNode3,
			treeNode4,
			treeNode5,
			treeNode6,
			treeNode7,
			treeNode8});
			this.treeNav.ShowPlusMinus = false;
			this.treeNav.ShowRootLines = false;
			this.treeNav.Size = new System.Drawing.Size(170, 606);
			this.treeNav.TabIndex = 0;
			this.treeNav.AfterSelect += new Wisej.Web.TreeViewEventHandler(this.treeNav_AfterSelect);
			//
			// panelMain
			//
			this.panelMain.Dock = Wisej.Web.DockStyle.Fill;
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
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 681);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(960, 600);
			this.Name = "MainForm";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "Relay CRM";
			this.WindowState = Wisej.Web.FormWindowState.Maximized;
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

		private Wisej.Web.MenuBar menuStrip;
		private Wisej.Web.MenuItem menuFile;
		private Wisej.Web.MenuItem menuNewContact;
		private Wisej.Web.MenuItem menuNewCompany;
		private Wisej.Web.MenuItem menuNewDeal;
		private Wisej.Web.MenuItem menuNewTask;
		private Wisej.Web.MenuItem menuLogActivity;
		private Wisej.Web.MenuItem menuFileSeparator1;
		private Wisej.Web.MenuItem menuSignOut;
		private Wisej.Web.MenuItem menuExit;
		private Wisej.Web.MenuItem menuView;
		private Wisej.Web.MenuItem menuSearch;
		private Wisej.Web.MenuItem menuBack;
		private Wisej.Web.MenuItem menuRefresh;
		private Wisej.Web.MenuItem menuViewSeparator1;
		private Wisej.Web.MenuItem menuDashboard;
		private Wisej.Web.MenuItem menuContacts;
		private Wisej.Web.MenuItem menuCompanies;
		private Wisej.Web.MenuItem menuDeals;
		private Wisej.Web.MenuItem menuActivities;
		private Wisej.Web.MenuItem menuTasks;
		private Wisej.Web.MenuItem menuReports;
		private Wisej.Web.MenuItem menuSettings;
		private Wisej.Web.MenuItem menuHelp;
		private Wisej.Web.MenuItem menuAbout;
		private Wisej.Web.ToolBar toolStrip;
		private Wisej.Web.ToolBarButton buttonBack;
		private Wisej.Web.ToolBarButton toolStripSeparator1;
		private Wisej.Web.TextBox textSearch;
		private Wisej.Web.ToolBarControl textSearchHost;
		private Wisej.Web.ToolBarButton buttonSearch;
		private Wisej.Web.ToolBarButton dropDownUser;
		private Wisej.Web.ContextMenu dropDownUserMenu;
		private Wisej.Web.MenuItem menuUserProfile;
		private Wisej.Web.MenuItem menuUserSettings;
		private Wisej.Web.MenuItem menuUserSeparator;
		private Wisej.Web.MenuItem menuUserSignOut;
		private Wisej.Web.ToolBarButton buttonNotifications;
		private Wisej.Web.StatusBar statusStrip;
		private Wisej.Web.StatusBarPanel statusMessage;
		private Wisej.Web.StatusBarPanel statusOverdue;
		private Wisej.Web.StatusBarPanel statusUser;
		private Wisej.Web.SplitContainer splitContainer;
		private Wisej.Web.TreeView treeNav;
		private Wisej.Web.Panel panelMain;
		private Wisej.Web.Timer timerStatus;
	}
}
