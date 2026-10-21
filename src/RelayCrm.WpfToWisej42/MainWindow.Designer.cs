namespace RelayCrm
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
			this.navigationBar = new Wisej.Web.Ext.NavigationBar.NavigationBar();
			this.navDashboard = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
			this.navContacts = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
			this.navCompanies = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
			this.navDeals = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
			this.navActivities = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
			this.navTasks = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
			this.navReports = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
			this.navSettings = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelTitle = new Wisej.Web.Label();
			this.buttonBack = new Wisej.Web.Button();
			this.buttonMenu = new Wisej.Web.Button();
			this.flexTools = new Wisej.Web.FlexLayoutPanel();
			this.textSearch = new Wisej.Web.TextBox();
			this.buttonNew = new Wisej.Web.Button();
			this.menuNewContact = new Wisej.Web.MenuItem();
			this.menuNewCompany = new Wisej.Web.MenuItem();
			this.menuNewDeal = new Wisej.Web.MenuItem();
			this.menuNewTask = new Wisej.Web.MenuItem();
			this.menuNewSeparator = new Wisej.Web.MenuItem();
			this.menuLogActivity = new Wisej.Web.MenuItem();
			this.buttonNotifications = new Wisej.Web.Button();
			this.avatarUser = new Wisej.Web.Avatar();
			this.contextMenuUser = new Wisej.Web.ContextMenu(this.components);
			this.menuUserProfile = new Wisej.Web.MenuItem();
			this.menuUserSettings = new Wisej.Web.MenuItem();
			this.menuAbout = new Wisej.Web.MenuItem();
			this.menuUserSeparator = new Wisej.Web.MenuItem();
			this.menuUserSignOut = new Wisej.Web.MenuItem();
			this.menuExit = new Wisej.Web.MenuItem();
			this.contentHost = new Wisej.Web.Panel();
			this.commandPalette = new Wisej.Web.CommandPalette(this.components);
			this.panelHeader.SuspendLayout();
			this.flexTools.SuspendLayout();
			this.SuspendLayout();
			//
			// navigationBar
			//
			this.navigationBar.BackColor = System.Drawing.Color.White;
			this.navigationBar.CssClass = "relay-sidebar";
			this.navigationBar.Dock = Wisej.Web.DockStyle.Left;
			this.navigationBar.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] {
			this.navDashboard,
			this.navContacts,
			this.navCompanies,
			this.navDeals,
			this.navActivities,
			this.navTasks,
			this.navReports,
			this.navSettings});
			this.navigationBar.Logo = "Assets/Icons/relay-logo.svg";
			this.navigationBar.Name = "navigationBar";
			this.navigationBar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("navigationBar.ResponsiveProfiles"))));
			this.navigationBar.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("navigationBar.ResponsiveProfiles1"))));
			this.navigationBar.ShowUser = false;
			this.navigationBar.Size = new System.Drawing.Size(220, 820);
			this.navigationBar.TabIndex = 0;
			this.navigationBar.Text = "Relay CRM";
			this.navigationBar.TitleClick += new System.EventHandler(this.navigationBar_TitleClick);
			this.navigationBar.SelectedItemChanged += new System.EventHandler(this.navigationBar_SelectedItemChanged);
			//
			// navDashboard
			//
			this.navDashboard.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/speedometer2.svg";
			this.navDashboard.Name = "navDashboard";
			this.navDashboard.Tag = "DashboardView";
			this.navDashboard.Text = "Dashboard";
			//
			// navContacts
			//
			this.navContacts.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/person.svg";
			this.navContacts.Name = "navContacts";
			this.navContacts.Tag = "ContactsView";
			this.navContacts.Text = "Contacts";
			//
			// navCompanies
			//
			this.navCompanies.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/building.svg";
			this.navCompanies.Name = "navCompanies";
			this.navCompanies.Tag = "CompaniesView";
			this.navCompanies.Text = "Companies";
			//
			// navDeals
			//
			this.navDeals.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/briefcase.svg";
			this.navDeals.Name = "navDeals";
			this.navDeals.Tag = "DealsView";
			this.navDeals.Text = "Deals";
			//
			// navActivities
			//
			this.navActivities.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.navActivities.Name = "navActivities";
			this.navActivities.Tag = "ActivitiesView";
			this.navActivities.Text = "Activities";
			//
			// navTasks
			//
			this.navTasks.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
			this.navTasks.InfoTextBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
			this.navTasks.InfoTextForeColor = System.Drawing.Color.White;
			this.navTasks.Name = "navTasks";
			this.navTasks.Tag = "TasksView";
			this.navTasks.Text = "Tasks";
			//
			// navReports
			//
			this.navReports.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/bar-chart.svg";
			this.navReports.Name = "navReports";
			this.navReports.Tag = "ReportsView";
			this.navReports.Text = "Reports";
			//
			// navSettings
			//
			this.navSettings.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/gear.svg";
			this.navSettings.Name = "navSettings";
			this.navSettings.Tag = "SettingsView";
			this.navSettings.Text = "Settings";
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.labelTitle);
			this.panelHeader.Controls.Add(this.buttonBack);
			this.panelHeader.Controls.Add(this.buttonMenu);
			this.panelHeader.Controls.Add(this.flexTools);
			this.panelHeader.CssClass = "relay-header";
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(220, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Padding = new Wisej.Web.Padding(16, 12, 16, 12);
			this.panelHeader.Size = new System.Drawing.Size(1060, 64);
			this.panelHeader.TabIndex = 1;
			//
			// labelTitle
			//
			this.labelTitle.AppearanceKey = "relay-page-title";
			this.labelTitle.AutoEllipsis = true;
			this.labelTitle.Dock = Wisej.Web.DockStyle.Fill;
			this.labelTitle.Location = new System.Drawing.Point(152, 12);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Padding = new Wisej.Web.Padding(8, 0, 0, 0);
			this.labelTitle.Size = new System.Drawing.Size(404, 40);
			this.labelTitle.TabIndex = 2;
			this.labelTitle.Text = "Dashboard";
			this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonBack
			//
			this.buttonBack.CssClass = "relay-secondary";
			this.buttonBack.Dock = Wisej.Web.DockStyle.Left;
			this.buttonBack.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/arrow-left.svg";
			this.buttonBack.Location = new System.Drawing.Point(56, 12);
			this.buttonBack.Name = "buttonBack";
			this.buttonBack.Size = new System.Drawing.Size(96, 40);
			this.buttonBack.TabIndex = 1;
			this.buttonBack.Text = "Back";
			this.buttonBack.ToolTipText = "Back to the list (Alt+Left)";
			this.buttonBack.Visible = false;
			this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
			//
			// buttonMenu
			//
			this.buttonMenu.Display = Wisej.Web.Display.Icon;
			this.buttonMenu.Dock = Wisej.Web.DockStyle.Left;
			this.buttonMenu.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/list.svg";
			this.buttonMenu.Location = new System.Drawing.Point(16, 12);
			this.buttonMenu.Name = "buttonMenu";
			this.buttonMenu.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("buttonMenu.ResponsiveProfiles"))));
			this.buttonMenu.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("buttonMenu.ResponsiveProfiles1"))));
			this.buttonMenu.Size = new System.Drawing.Size(40, 40);
			this.buttonMenu.TabIndex = 0;
			this.buttonMenu.ToolTipText = "Menu";
			this.buttonMenu.Visible = false;
			this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
			//
			// flexTools
			//
			this.flexTools.Controls.Add(this.textSearch);
			this.flexTools.Controls.Add(this.buttonNew);
			this.flexTools.Controls.Add(this.buttonNotifications);
			this.flexTools.Controls.Add(this.avatarUser);
			this.flexTools.Dock = Wisej.Web.DockStyle.Right;
			this.flexTools.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
			this.flexTools.Location = new System.Drawing.Point(556, 12);
			this.flexTools.Name = "flexTools";
			this.flexTools.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flexTools.ResponsiveProfiles"))));
			this.flexTools.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flexTools.ResponsiveProfiles1"))));
			this.flexTools.Size = new System.Drawing.Size(488, 40);
			this.flexTools.Spacing = 12;
			this.flexTools.TabIndex = 3;
			//
			// textSearch
			//
			this.textSearch.CssClass = "relay-search";
			this.textSearch.Location = new System.Drawing.Point(0, 2);
			this.textSearch.Name = "textSearch";
			this.textSearch.ReadOnly = true;
			this.textSearch.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("textSearch.ResponsiveProfiles"))));
			this.textSearch.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("textSearch.ResponsiveProfiles1"))));
			this.textSearch.Size = new System.Drawing.Size(260, 36);
			this.textSearch.TabIndex = 0;
			this.textSearch.TabStop = false;
			componentTool1.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/search.svg";
			componentTool1.Name = "search";
			componentTool1.ToolTipText = "Search (Ctrl+K)";
			this.textSearch.Tools.AddRange(new Wisej.Web.ComponentTool[] {
			componentTool1});
			this.textSearch.ToolTipText = "Search pages, contacts, companies and deals (Ctrl+K)";
			this.textSearch.Watermark = "Search…   Ctrl+K";
			this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
			this.textSearch.ToolClick += new Wisej.Web.ToolClickEventHandler(this.textSearch_ToolClick);
			//
			// buttonNew
			//
			this.buttonNew.CssClass = "relay-primary";
			this.buttonNew.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus.svg";
			this.buttonNew.Location = new System.Drawing.Point(272, 2);
			this.buttonNew.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuNewContact,
			this.menuNewCompany,
			this.menuNewDeal,
			this.menuNewTask,
			this.menuNewSeparator,
			this.menuLogActivity});
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(92, 36);
			this.buttonNew.TabIndex = 1;
			this.buttonNew.Text = "New";
			//
			// menuNewContact
			//
			this.menuNewContact.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/person.svg";
			this.menuNewContact.Index = 0;
			this.menuNewContact.Name = "menuNewContact";
			this.menuNewContact.Text = "New contact...";
			this.menuNewContact.Click += new System.EventHandler(this.menuNewContact_Click);
			//
			// menuNewCompany
			//
			this.menuNewCompany.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/building.svg";
			this.menuNewCompany.Index = 1;
			this.menuNewCompany.Name = "menuNewCompany";
			this.menuNewCompany.Text = "New company...";
			this.menuNewCompany.Click += new System.EventHandler(this.menuNewCompany_Click);
			//
			// menuNewDeal
			//
			this.menuNewDeal.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/briefcase.svg";
			this.menuNewDeal.Index = 2;
			this.menuNewDeal.Name = "menuNewDeal";
			this.menuNewDeal.Text = "New deal...";
			this.menuNewDeal.Click += new System.EventHandler(this.menuNewDeal_Click);
			//
			// menuNewTask
			//
			this.menuNewTask.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
			this.menuNewTask.Index = 3;
			this.menuNewTask.Name = "menuNewTask";
			this.menuNewTask.Text = "New task...";
			this.menuNewTask.Click += new System.EventHandler(this.menuNewTask_Click);
			//
			// menuNewSeparator
			//
			this.menuNewSeparator.Index = 4;
			this.menuNewSeparator.Name = "menuNewSeparator";
			this.menuNewSeparator.Text = "-";
			//
			// menuLogActivity
			//
			this.menuLogActivity.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/journal-plus.svg";
			this.menuLogActivity.Index = 5;
			this.menuLogActivity.Name = "menuLogActivity";
			this.menuLogActivity.Text = "Log activity...";
			this.menuLogActivity.Click += new System.EventHandler(this.menuLogActivity_Click);
			//
			// buttonNotifications
			//
			this.buttonNotifications.CssClass = "relay-secondary";
			this.buttonNotifications.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/bell.svg";
			this.buttonNotifications.Location = new System.Drawing.Point(376, 2);
			this.buttonNotifications.Name = "buttonNotifications";
			this.buttonNotifications.Size = new System.Drawing.Size(56, 36);
			this.buttonNotifications.TabIndex = 2;
			this.buttonNotifications.ToolTipText = "Notifications";
			this.buttonNotifications.Click += new System.EventHandler(this.buttonNotifications_Click);
			//
			// avatarUser
			//
			this.avatarUser.AvatarSize = 36;
			this.avatarUser.Cursor = Wisej.Web.Cursors.Hand;
			this.avatarUser.Location = new System.Drawing.Point(444, 2);
			this.avatarUser.Name = "avatarUser";
			this.avatarUser.Size = new System.Drawing.Size(36, 36);
			this.avatarUser.TabIndex = 3;
			this.avatarUser.Text = "?";
			this.avatarUser.Click += new System.EventHandler(this.avatarUser_Click);
			//
			// contextMenuUser
			//
			this.contextMenuUser.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuUserProfile,
			this.menuUserSettings,
			this.menuAbout,
			this.menuUserSeparator,
			this.menuUserSignOut,
			this.menuExit});
			this.contextMenuUser.Name = "contextMenuUser";
			//
			// menuUserProfile
			//
			this.menuUserProfile.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/person.svg";
			this.menuUserProfile.Index = 0;
			this.menuUserProfile.Name = "menuUserProfile";
			this.menuUserProfile.Text = "Profile...";
			this.menuUserProfile.Click += new System.EventHandler(this.menuUserProfile_Click);
			//
			// menuUserSettings
			//
			this.menuUserSettings.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/gear.svg";
			this.menuUserSettings.Index = 1;
			this.menuUserSettings.Name = "menuUserSettings";
			this.menuUserSettings.Tag = "SettingsView";
			this.menuUserSettings.Text = "Settings";
			this.menuUserSettings.Click += new System.EventHandler(this.menuPage_Click);
			//
			// menuAbout
			//
			this.menuAbout.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/info-circle.svg";
			this.menuAbout.Index = 2;
			this.menuAbout.Name = "menuAbout";
			this.menuAbout.Text = "About Relay";
			this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
			//
			// menuUserSeparator
			//
			this.menuUserSeparator.Index = 3;
			this.menuUserSeparator.Name = "menuUserSeparator";
			this.menuUserSeparator.Text = "-";
			//
			// menuUserSignOut
			//
			this.menuUserSignOut.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/box-arrow-right.svg";
			this.menuUserSignOut.Index = 4;
			this.menuUserSignOut.Name = "menuUserSignOut";
			this.menuUserSignOut.Text = "Sign out";
			this.menuUserSignOut.Click += new System.EventHandler(this.menuSignOut_Click);
			//
			// menuExit
			//
			this.menuExit.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/x-circle.svg";
			this.menuExit.Index = 5;
			this.menuExit.Name = "menuExit";
			this.menuExit.Text = "Exit";
			this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
			//
			// contentHost
			//
			this.contentHost.CssClass = "relay-page";
			this.contentHost.Dock = Wisej.Web.DockStyle.Fill;
			this.contentHost.Location = new System.Drawing.Point(220, 64);
			this.contentHost.Name = "contentHost";
			this.contentHost.Padding = new Wisej.Web.Padding(12);
			this.contentHost.Size = new System.Drawing.Size(1060, 756);
			this.contentHost.TabIndex = 2;
			//
			// commandPalette
			//
			this.commandPalette.FilterMode = Wisej.Web.CommandFilterMode.Server;
			this.commandPalette.PlaceholderText = "Search pages, contacts, companies and deals";
			this.commandPalette.Shortcut = ((Wisej.Web.Keys)((Wisej.Web.Keys.Control | Wisej.Web.Keys.K)));
			this.commandPalette.QueryChanged += new System.EventHandler<Wisej.Web.CommandQueryEventArgs>(this.commandPalette_QueryChanged);
			this.commandPalette.CommandExecuted += new System.EventHandler<Wisej.Web.CommandEventArgs>(this.commandPalette_CommandExecuted);
			//
			// MainWindow
			//
			this.Accelerators = new Wisej.Web.Keys[] {
			Wisej.Web.Keys.F5,
			((Wisej.Web.Keys)((Wisej.Web.Keys.Alt | Wisej.Web.Keys.Left))),
			((Wisej.Web.Keys)((Wisej.Web.Keys.Control | Wisej.Web.Keys.D1))),
			((Wisej.Web.Keys)((Wisej.Web.Keys.Control | Wisej.Web.Keys.D2))),
			((Wisej.Web.Keys)((Wisej.Web.Keys.Control | Wisej.Web.Keys.D3))),
			((Wisej.Web.Keys)((Wisej.Web.Keys.Control | Wisej.Web.Keys.D4))),
			((Wisej.Web.Keys)((Wisej.Web.Keys.Control | Wisej.Web.Keys.D5))),
			((Wisej.Web.Keys)((Wisej.Web.Keys.Control | Wisej.Web.Keys.D6))),
			((Wisej.Web.Keys)((Wisej.Web.Keys.Control | Wisej.Web.Keys.D7))),
			((Wisej.Web.Keys)((Wisej.Web.Keys.Control | Wisej.Web.Keys.D8)))};
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
			this.Controls.Add(this.contentHost);
			this.Controls.Add(this.panelHeader);
			this.Controls.Add(this.navigationBar);
			this.Name = "MainWindow";
			this.Size = new System.Drawing.Size(1280, 820);
			this.Text = "Relay CRM";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.Appear += new System.EventHandler(this.MainWindow_Appear);
			this.Accelerator += new Wisej.Web.AcceleratorEventHandler(this.MainWindow_Accelerator);
			this.panelHeader.ResumeLayout(false);
			this.flexTools.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Ext.NavigationBar.NavigationBar navigationBar;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navDashboard;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navContacts;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navCompanies;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navDeals;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navActivities;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navTasks;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navReports;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navSettings;
		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelTitle;
		private Wisej.Web.Button buttonBack;
		private Wisej.Web.Button buttonMenu;
		private Wisej.Web.FlexLayoutPanel flexTools;
		private Wisej.Web.TextBox textSearch;
		private Wisej.Web.Button buttonNew;
		private Wisej.Web.MenuItem menuNewContact;
		private Wisej.Web.MenuItem menuNewCompany;
		private Wisej.Web.MenuItem menuNewDeal;
		private Wisej.Web.MenuItem menuNewTask;
		private Wisej.Web.MenuItem menuNewSeparator;
		private Wisej.Web.MenuItem menuLogActivity;
		private Wisej.Web.Button buttonNotifications;
		private Wisej.Web.Avatar avatarUser;
		private Wisej.Web.ContextMenu contextMenuUser;
		private Wisej.Web.MenuItem menuUserProfile;
		private Wisej.Web.MenuItem menuUserSettings;
		private Wisej.Web.MenuItem menuAbout;
		private Wisej.Web.MenuItem menuUserSeparator;
		private Wisej.Web.MenuItem menuUserSignOut;
		private Wisej.Web.MenuItem menuExit;
		private Wisej.Web.Panel contentHost;
		private Wisej.Web.CommandPalette commandPalette;
	}
}
