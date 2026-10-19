namespace RelayCrm
{
	partial class Page1
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
            components = new System.ComponentModel.Container();
            Wisej.Resources.ComponentResourceManager resources = new Wisej.Resources.ComponentResourceManager(typeof(Page1));
            Wisej.Web.ComponentTool componentTool1 = new Wisej.Web.ComponentTool();
            navigationBar = new Wisej.Web.Ext.NavigationBar.NavigationBar();
            navigationBarDashboard = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            navigationBarContacts = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            navigationBarCompanies = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            navigationBarDeals = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            navigationBarActivities = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            navigationBarTasks = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            navigationBarReports = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            navigationBarSettings = new Wisej.Web.Ext.NavigationBar.NavigationBarItem();
            panelTop = new Wisej.Web.Panel();
            flexLayoutTools = new Wisej.Web.FlexLayoutPanel();
            textBoxSearch = new Wisej.Web.TextBox();
            buttonNotifications = new Wisej.Web.Button();
            avatarUser = new Wisej.Web.Avatar();
            labelTitle = new Wisej.Web.Label();
            panelMain = new Wisej.Web.Panel();
            animationIn = new Wisej.Web.Animation(components);
            contextMenuUser = new Wisej.Web.ContextMenu(components);
            menuItemProfile = new Wisej.Web.MenuItem();
            menuItemSettings = new Wisej.Web.MenuItem();
            menuItemSignOut = new Wisej.Web.MenuItem();
            commandPalette = new Wisej.Web.CommandPalette(components);
            panelTop.SuspendLayout();
            flexLayoutTools.SuspendLayout();
            SuspendLayout();
            // 
            // navigationBar
            // 
            navigationBar.BackColor = System.Drawing.Color.White;
            navigationBar.CssStyle = "border-right: 1px solid #E6E8EF;";
            navigationBar.Dock = Wisej.Web.DockStyle.Left;
            navigationBar.ForeColor = System.Drawing.Color.FromArgb(75, 82, 102);
            navigationBar.Items.AddRange(new Wisej.Web.Ext.NavigationBar.NavigationBarItem[] { navigationBarDashboard, navigationBarContacts, navigationBarCompanies, navigationBarDeals, navigationBarActivities, navigationBarTasks, navigationBarReports, navigationBarSettings });
            navigationBar.Logo = "Assets\\Icons\\relay-logo.svg";
            navigationBar.Name = "navigationBar";
            navigationBar.ResponsiveProfiles.Add((Wisej.Base.ResponsiveProfile)resources.GetObject("navigationBar.ResponsiveProfiles"));
            navigationBar.ResponsiveProfiles.Add((Wisej.Base.ResponsiveProfile)resources.GetObject("navigationBar.ResponsiveProfiles1"));
            navigationBar.ShowHeader = false;
            navigationBar.ShowUser = false;
            navigationBar.Size = new System.Drawing.Size(232, 638);
            navigationBar.TabIndex = 0;
            navigationBar.Text = "Relay";
            navigationBar.TitleClick += navigationBar_TitleClick;
            navigationBar.SelectedItemChanged += navigationBar_SelectedItemChanged;
            // 
            // navigationBarDashboard
            // 
            navigationBarDashboard.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/speedometer2.svg";
            navigationBarDashboard.Name = "navigationBarDashboard";
            navigationBarDashboard.Tag = "DashboardView";
            navigationBarDashboard.Text = "Dashboard";
            // 
            // navigationBarContacts
            // 
            navigationBarContacts.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/person.svg";
            navigationBarContacts.Name = "navigationBarContacts";
            navigationBarContacts.Tag = "ContactsView";
            navigationBarContacts.Text = "Contacts";
            // 
            // navigationBarCompanies
            // 
            navigationBarCompanies.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/building.svg";
            navigationBarCompanies.Name = "navigationBarCompanies";
            navigationBarCompanies.Tag = "CompaniesView";
            navigationBarCompanies.Text = "Companies";
            // 
            // navigationBarDeals
            // 
            navigationBarDeals.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/briefcase.svg";
            navigationBarDeals.Name = "navigationBarDeals";
            navigationBarDeals.Tag = "DealsView";
            navigationBarDeals.Text = "Deals";
            // 
            // navigationBarActivities
            // 
            navigationBarActivities.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
            navigationBarActivities.Name = "navigationBarActivities";
            navigationBarActivities.Tag = "ActivitiesView";
            navigationBarActivities.Text = "Activities";
            // 
            // navigationBarTasks
            // 
            navigationBarTasks.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
            navigationBarTasks.Name = "navigationBarTasks";
            navigationBarTasks.Tag = "TasksView";
            navigationBarTasks.Text = "Tasks";
            // 
            // navigationBarReports
            // 
            navigationBarReports.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/bar-chart.svg";
            navigationBarReports.Name = "navigationBarReports";
            navigationBarReports.Tag = "ReportsView";
            navigationBarReports.Text = "Reports";
            // 
            // navigationBarSettings
            // 
            navigationBarSettings.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/gear.svg";
            navigationBarSettings.Name = "navigationBarSettings";
            navigationBarSettings.Tag = "SettingsView";
            navigationBarSettings.Text = "Settings";
            // 
            // panelTop
            // 
            panelTop.BackColor = System.Drawing.Color.White;
            panelTop.Controls.Add(flexLayoutTools);
            panelTop.Controls.Add(labelTitle);
            panelTop.CssStyle = "border-radius:0px; border-bottom: 1px solid #E6E8EF;";
            panelTop.Dock = Wisej.Web.DockStyle.Top;
            panelTop.Location = new System.Drawing.Point(232, 0);
            panelTop.Name = "panelTop";
            panelTop.ResponsiveProfiles.Add((Wisej.Base.ResponsiveProfile)resources.GetObject("panelTop.ResponsiveProfiles"));
            panelTop.ResponsiveProfiles.Add((Wisej.Base.ResponsiveProfile)resources.GetObject("panelTop.ResponsiveProfiles1"));
            panelTop.Size = new System.Drawing.Size(714, 64);
            panelTop.TabIndex = 1;
            // 
            // flexLayoutTools
            // 
            flexLayoutTools.Anchor = Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right;
            flexLayoutTools.Controls.Add(textBoxSearch);
            flexLayoutTools.Controls.Add(buttonNotifications);
            flexLayoutTools.Controls.Add(avatarUser);
            flexLayoutTools.LayoutStyle = Wisej.Web.FlexLayoutStyle.Horizontal;
            flexLayoutTools.Location = new System.Drawing.Point(286, 14);
            flexLayoutTools.Name = "flexLayoutTools";
            flexLayoutTools.Size = new System.Drawing.Size(404, 36);
            flexLayoutTools.Spacing = 16;
            flexLayoutTools.TabIndex = 1;
            flexLayoutTools.VerticalAlign = Wisej.Web.VerticalAlignment.Middle;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BackColor = System.Drawing.Color.FromArgb(250, 251, 253);
            textBoxSearch.CssStyle = "border-radius: 8px;";
            textBoxSearch.Location = new System.Drawing.Point(0, 0);
            textBoxSearch.Margin = new Wisej.Web.Padding(0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.ReadOnly = true;
            textBoxSearch.TabStop = false;
            textBoxSearch.Size = new System.Drawing.Size(300, 36);
            textBoxSearch.TabIndex = 0;
            componentTool1.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/search.svg";
            componentTool1.Name = "search";
            componentTool1.Position = Wisej.Web.LeftRightAlignment.Left;
            textBoxSearch.Tools.AddRange(new Wisej.Web.ComponentTool[] { componentTool1 });
            textBoxSearch.Watermark = "Search  Ctrl+K";
            textBoxSearch.Click += textBoxSearch_Click;
            // 
            // buttonNotifications
            // 
            buttonNotifications.BackColor = System.Drawing.Color.Transparent;
            buttonNotifications.CssStyle = "border: none; box-shadow: none;";
            buttonNotifications.Display = Wisej.Web.Display.Icon;
            buttonNotifications.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/bell.svg";
            buttonNotifications.Location = new System.Drawing.Point(316, 0);
            buttonNotifications.Margin = new Wisej.Web.Padding(0);
            buttonNotifications.Name = "buttonNotifications";
            buttonNotifications.Size = new System.Drawing.Size(36, 36);
            buttonNotifications.TabIndex = 1;
            buttonNotifications.ToolTipText = "Notifications";
            buttonNotifications.Click += buttonNotifications_Click;
            // 
            // avatarUser
            // 
            avatarUser.AvatarSize = 36;
            avatarUser.Cursor = Wisej.Web.Cursors.Hand;
            avatarUser.Location = new System.Drawing.Point(368, 0);
            avatarUser.Margin = new Wisej.Web.Padding(0);
            avatarUser.Name = "avatarUser";
            avatarUser.Size = new System.Drawing.Size(36, 36);
            avatarUser.TabIndex = 2;
            avatarUser.Text = "MP";
            avatarUser.Click += avatarUser_Click;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("defaultBold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            labelTitle.Location = new System.Drawing.Point(24, 19);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(106, 27);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Dashboard";
            // 
            // panelMain
            // 
            panelMain.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            panelMain.Dock = Wisej.Web.DockStyle.Fill;
            panelMain.Location = new System.Drawing.Point(232, 64);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Wisej.Web.Padding(24);
            panelMain.ResponsiveProfiles.Add((Wisej.Base.ResponsiveProfile)resources.GetObject("panelMain.ResponsiveProfiles"));
            panelMain.ResponsiveProfiles.Add((Wisej.Base.ResponsiveProfile)resources.GetObject("panelMain.ResponsiveProfiles1"));
            panelMain.Size = new System.Drawing.Size(714, 574);
            panelMain.TabIndex = 2;
            // 
            // contextMenuUser
            // 
            contextMenuUser.MenuItems.AddRange(new Wisej.Web.MenuItem[] { menuItemProfile, menuItemSettings, menuItemSignOut });
            contextMenuUser.Name = "contextMenuUser";
            // 
            // menuItemProfile
            // 
            menuItemProfile.Index = 0;
            menuItemProfile.Name = "menuItemProfile";
            menuItemProfile.Text = "Profile";
            menuItemProfile.Click += menuItemProfile_Click;
            // 
            // menuItemSettings
            // 
            menuItemSettings.Index = 1;
            menuItemSettings.Name = "menuItemSettings";
            menuItemSettings.Text = "Settings";
            menuItemSettings.Click += menuItemSettings_Click;
            // 
            // menuItemSignOut
            // 
            menuItemSignOut.Index = 2;
            menuItemSignOut.Name = "menuItemSignOut";
            menuItemSignOut.Text = "Sign out";
            menuItemSignOut.Click += menuItemSignOut_Click;
            // 
            // commandPalette
            // 
            commandPalette.FilterMode = Wisej.Web.CommandFilterMode.Server;
            commandPalette.PlaceholderText = "Search pages, contacts, companies and deals";
            commandPalette.QueryChanged += commandPalette_QueryChanged;
            commandPalette.CommandExecuted += commandPalette_CommandExecuted;
            // 
            // Page1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            Controls.Add(panelMain);
            Controls.Add(panelTop);
            Controls.Add(navigationBar);
            Name = "Page1";
            Size = new System.Drawing.Size(946, 638);
            Text = "Relay";
            Load += Page1_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            flexLayoutTools.ResumeLayout(false);
            flexLayoutTools.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Ext.NavigationBar.NavigationBar navigationBar;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarDashboard;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarContacts;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarCompanies;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarDeals;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarActivities;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarTasks;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarReports;
		private Wisej.Web.Ext.NavigationBar.NavigationBarItem navigationBarSettings;
		private Wisej.Web.Panel panelTop;
		private Wisej.Web.Label labelTitle;
		private Wisej.Web.FlexLayoutPanel flexLayoutTools;
		private Wisej.Web.TextBox textBoxSearch;
		private Wisej.Web.Button buttonNotifications;
		private Wisej.Web.Avatar avatarUser;
		private Wisej.Web.CommandPalette commandPalette;
		private Wisej.Web.Panel panelMain;
		private Wisej.Web.Animation animationIn;
		private Wisej.Web.ContextMenu contextMenuUser;
		private Wisej.Web.MenuItem menuItemProfile;
		private Wisej.Web.MenuItem menuItemSettings;
		private Wisej.Web.MenuItem menuItemSignOut;
	}
}
