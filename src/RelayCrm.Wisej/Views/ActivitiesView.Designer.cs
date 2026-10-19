namespace RelayCrm.Views
{
	partial class ActivitiesView
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
			this.components = new System.ComponentModel.Container();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			this.panelList = new Wisej.Web.Panel();
			this.emptyList = new Wisej.Web.EmptyState();
			this.grid = new Wisej.Web.DataGridView();
			this.colType = new Wisej.Web.DataGridViewChipColumn();
			this.colSubject = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colDetails = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colRelated = new Wisej.Web.DataGridViewLinkColumn();
			this.colUser = new Wisej.Web.DataGridViewAvatarColumn();
			this.colDate = new Wisej.Web.DataGridViewTextBoxColumn();
			this.splitCalendar = new Wisej.Web.SplitContainer();
			this.buttonLogOnDay = new Wisej.Web.Button();
			this.labelDay = new Wisej.Web.Label();
			this.toolStrip = new Wisej.Web.ToolBar();
			this.buttonLog = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator1 = new Wisej.Web.ToolBarButton();
			this.buttonCalendar = new Wisej.Web.ToolBarButton();
			this.buttonList = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator2 = new Wisej.Web.ToolBarButton();
			this.labelType = new Wisej.Web.ToolBarButton();
			this.comboType = new Wisej.Web.ComboBox();
			this.comboTypeHost = new Wisej.Web.ToolBarControl();
			this.labelUser = new Wisej.Web.ToolBarButton();
			this.comboUser = new Wisej.Web.ComboBox();
			this.comboUserHost = new Wisej.Web.ToolBarControl();
			this.toolStripSeparator3 = new Wisej.Web.ToolBarButton();
			this.buttonExport = new Wisej.Web.ToolBarButton();
			this.labelCount = new Wisej.Web.ToolBarButton();
			this.contextMenu = new Wisej.Web.ContextMenu(this.components);
			this.menuOpen = new Wisej.Web.MenuItem();
			this.menuSeparator1 = new Wisej.Web.MenuItem();
			this.menuDelete = new Wisej.Web.MenuItem();
			this.schedulerView = new Wisej.Web.SchedulerView();
			this.timelineDay = new Wisej.Web.Timeline();
			this.emptyDay = new Wisej.Web.EmptyState();
			this.panelList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitCalendar)).BeginInit();
			this.splitCalendar.Panel1.SuspendLayout();
			this.splitCalendar.Panel2.SuspendLayout();
			this.splitCalendar.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			//
			// panelList
			//
			this.panelList.Controls.Add(this.emptyList);
			this.panelList.Controls.Add(this.grid);
			this.panelList.Dock = Wisej.Web.DockStyle.Fill;
			this.panelList.Location = new System.Drawing.Point(0, 27);
			this.panelList.Name = "panelList";
			this.panelList.Size = new System.Drawing.Size(1000, 573);
			this.panelList.TabIndex = 2;
			this.panelList.Visible = false;
			//
			// emptyList
			//
			this.emptyList.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyList.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.emptyList.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyList.Location = new System.Drawing.Point(0, 0);
			this.emptyList.Name = "emptyList";
			this.emptyList.Size = new System.Drawing.Size(1000, 556);
			this.emptyList.TabIndex = 1;
			this.emptyList.Title = "No activities match the filters.";
			this.emptyList.Visible = false;
			//
			// grid
			//
			this.grid.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colType,
			this.colSubject,
			this.colDetails,
			this.colRelated,
			this.colUser,
			this.colDate});
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.AllowUserToResizeRows = false;
			this.grid.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Dock = Wisej.Web.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(0, 0);
			this.grid.MultiSelect = false;
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersVisible = false;
			this.grid.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.grid.Size = new System.Drawing.Size(400, 200);
			this.grid.TabIndex = 0;
			this.grid.ContextMenu = this.contextMenu;
			this.grid.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.grid_CellContentClick);
			this.grid.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
			this.grid.CellMouseDown += new Wisej.Web.DataGridViewCellMouseEventHandler(this.grid_CellMouseDown);
			this.grid.KeyDown += new Wisej.Web.KeyEventHandler(this.grid_KeyDown);
			this.grid.BorderStyle = Wisej.Web.BorderStyle.None;
			this.grid.CssClass = "relay-grid";
			this.grid.RowTemplate.Height = 44;
			//
			// colType
			//
			this.colType.DataPropertyName = "TypeName";
			this.colType.HeaderText = "Type";
			this.colType.Name = "colType";
			this.colType.Width = 100;
			//
			// colSubject
			//
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.colSubject.DataPropertyName = "Subject";
			this.colSubject.DefaultCellStyle = dataGridViewCellStyle1;
			this.colSubject.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colSubject.MinimumWidth = 200;
			this.colSubject.HeaderText = "Subject";
			this.colSubject.Name = "colSubject";
			//
			// colDetails
			//
			this.colDetails.DataPropertyName = "Details";
			this.colDetails.HeaderText = "Details";
			this.colDetails.Name = "colDetails";
			this.colDetails.Width = 120;
			//
			// colRelated
			//
			this.colRelated.DataPropertyName = "RelatedText";
			this.colRelated.HeaderText = "Related to";
			this.colRelated.Name = "colRelated";
			this.colRelated.Width = 280;
			//
			// colUser
			//
			this.colUser.DataPropertyName = "UserName";
			this.colUser.HeaderText = "User";
			this.colUser.Name = "colUser";
			this.colUser.Width = 150;
			this.colUser.TextMember = "UserName";
			//
			// colDate
			//
			dataGridViewCellStyle2.Format = "MMM d, yyyy  HH:mm";
			this.colDate.DataPropertyName = "Date";
			this.colDate.DefaultCellStyle = dataGridViewCellStyle2;
			this.colDate.HeaderText = "Date";
			this.colDate.Name = "colDate";
			this.colDate.Width = 140;
			//
			// splitCalendar
			//
			this.splitCalendar.Dock = Wisej.Web.DockStyle.Fill;
			this.splitCalendar.FixedPanel = Wisej.Web.FixedPanel.Panel2;
			this.splitCalendar.Location = new System.Drawing.Point(0, 44);
			this.splitCalendar.Name = "splitCalendar";
			//
			// splitCalendar.Panel1
			//
			this.splitCalendar.Panel1.Controls.Add(this.schedulerView);
			this.splitCalendar.Panel1.Padding = new Wisej.Web.Padding(8);
			//
			// splitCalendar.Panel2
			//
			this.splitCalendar.Panel2.Controls.Add(this.emptyDay);
			this.splitCalendar.Panel2.Controls.Add(this.timelineDay);
			this.splitCalendar.Panel2.Controls.Add(this.buttonLogOnDay);
			this.splitCalendar.Panel2.Controls.Add(this.labelDay);
			this.splitCalendar.Panel2.Padding = new Wisej.Web.Padding(8);
			this.splitCalendar.Size = new System.Drawing.Size(1000, 556);
			this.splitCalendar.SplitterDistance = 640;
			this.splitCalendar.TabIndex = 1;
			//
			// schedulerView
			//
			this.schedulerView.Dock = Wisej.Web.DockStyle.Fill;
			this.schedulerView.EndHour = 19;
			this.schedulerView.Location = new System.Drawing.Point(8, 8);
			this.schedulerView.Name = "schedulerView";
			this.schedulerView.Size = new System.Drawing.Size(624, 540);
			this.schedulerView.StartHour = 7;
			this.schedulerView.TabIndex = 0;
			this.schedulerView.View = Wisej.Web.SchedulerViewMode.Month;
			this.schedulerView.AppointmentClick += new System.EventHandler<Wisej.Web.SchedulerAppointmentEventArgs>(this.schedulerView_AppointmentClick);
			this.schedulerView.AppointmentDoubleClick += new System.EventHandler<Wisej.Web.SchedulerAppointmentEventArgs>(this.schedulerView_AppointmentDoubleClick);
			this.schedulerView.SlotDoubleClick += new System.EventHandler<Wisej.Web.SchedulerSlotEventArgs>(this.schedulerView_SlotDoubleClick);
			this.schedulerView.RangeChanged += new System.EventHandler<System.EventArgs>(this.schedulerView_RangeChanged);
			//
			// buttonLogOnDay
			//
			this.buttonLogOnDay.CssClass = "relay-secondary";
			this.buttonLogOnDay.Dock = Wisej.Web.DockStyle.Top;
			this.buttonLogOnDay.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/journal-plus.svg";
			this.buttonLogOnDay.Location = new System.Drawing.Point(8, 48);
			this.buttonLogOnDay.Name = "buttonLogOnDay";
			this.buttonLogOnDay.Size = new System.Drawing.Size(340, 36);
			this.buttonLogOnDay.TabIndex = 1;
			this.buttonLogOnDay.Text = "Log activity on this day...";
			this.buttonLogOnDay.Click += new System.EventHandler(this.buttonLogOnDay_Click);
			//
			// timelineDay
			//
			this.timelineDay.ContextMenu = this.contextMenu;
			this.timelineDay.Dock = Wisej.Web.DockStyle.Fill;
			this.timelineDay.Location = new System.Drawing.Point(8, 84);
			this.timelineDay.Name = "timelineDay";
			this.timelineDay.Size = new System.Drawing.Size(340, 464);
			this.timelineDay.TabIndex = 2;
			this.timelineDay.TimeFormat = "HH:mm";
			this.timelineDay.ItemClick += new System.EventHandler<Wisej.Web.TimelineItemEventArgs>(this.timelineDay_ItemClick);
			//
			// emptyDay
			//
			this.emptyDay.Compact = true;
			this.emptyDay.Description = "Double-click a day of the calendar to log one.";
			this.emptyDay.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyDay.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.emptyDay.Location = new System.Drawing.Point(8, 84);
			this.emptyDay.Name = "emptyDay";
			this.emptyDay.Size = new System.Drawing.Size(340, 464);
			this.emptyDay.TabIndex = 3;
			this.emptyDay.Title = "No activities on this day.";
			this.emptyDay.Visible = false;
			//
			// labelDay
			//
			this.labelDay.Dock = Wisej.Web.DockStyle.Top;
			this.labelDay.Location = new System.Drawing.Point(0, 0);
			this.labelDay.Name = "labelDay";
			this.labelDay.Padding = new Wisej.Web.Padding(4, 0, 0, 0);
			this.labelDay.Size = new System.Drawing.Size(340, 40);
			this.labelDay.TabIndex = 0;
			this.labelDay.Text = "Today";
			this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.labelDay.AppearanceKey = "relay-card-title";
			//
			// toolStrip
			//
			this.toolStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonLog,
			this.toolStripSeparator1,
			this.buttonCalendar,
			this.buttonList,
			this.toolStripSeparator2,
			this.labelType,
			this.comboTypeHost,
			this.labelUser,
			this.comboUserHost,
			this.toolStripSeparator3,
			this.buttonExport,
			this.labelCount});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new Wisej.Web.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(800, 27);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.toolStrip.CssClass = "relay-toolbar";
			//
			// buttonLog
			//
			this.buttonLog.Tag = "journal-plus";
			this.buttonLog.Name = "buttonLog";
			this.buttonLog.Text = "Log activity...";
			this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// buttonCalendar
			//
			this.buttonCalendar.Pushed = true;
			this.buttonCalendar.Tag = "calendar-event";
			this.buttonCalendar.Name = "buttonCalendar";
			this.buttonCalendar.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.buttonCalendar.Text = "Calendar";
			this.buttonCalendar.Click += new System.EventHandler(this.buttonMode_Click);
			//
			// buttonList
			//
			this.buttonList.Tag = "layout-three-columns";
			this.buttonList.Name = "buttonList";
			this.buttonList.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.buttonList.Text = "List";
			this.buttonList.Click += new System.EventHandler(this.buttonMode_Click);
			//
			// toolStripSeparator2
			//
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// labelType
			//
			this.labelType.Name = "labelType";
			this.labelType.Text = "Type:";
			//
			// comboType
			//
			this.comboType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboType.Size = new System.Drawing.Size(100, 23);
			this.comboType.Name = "comboType";
			this.comboTypeHost.Control = this.comboType;
			this.comboTypeHost.Name = "comboTypeHost";
			this.comboType.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
			//
			// labelUser
			//
			this.labelUser.Name = "labelUser";
			this.labelUser.Text = "User:";
			//
			// comboUser
			//
			this.comboUser.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboUser.Size = new System.Drawing.Size(140, 23);
			this.comboUser.Name = "comboUser";
			this.comboUserHost.Control = this.comboUser;
			this.comboUserHost.Name = "comboUserHost";
			this.comboUser.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
			//
			// toolStripSeparator3
			//
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// buttonExport
			//
			this.buttonExport.Visible = false;
			this.buttonExport.Tag = "download";
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Text = "Export CSV...";
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			//
			// labelCount
			//
			this.labelCount.Name = "labelCount";
			this.labelCount.Text = "0 activities";
			//
			// contextMenu
			//
			this.contextMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuOpen,
			this.menuSeparator1,
			this.menuDelete});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Popup += new System.EventHandler(this.contextMenu_Opening);
			//
			// menuOpen
			//
			this.menuOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Text = "&Open related record";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			//
			// menuSeparator1
			//
			this.menuSeparator1.Name = "menuSeparator1";
			this.menuSeparator1.Text = "-";
			//
			// menuDelete
			//
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Text = "&Delete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// ActivitiesView
			//
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.panelList);
			this.Controls.Add(this.splitCalendar);
			this.Controls.Add(this.toolStrip);
			this.CssClass = "relay-card";
			this.Name = "ActivitiesView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.Load += new System.EventHandler(this.ActivitiesView_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitCalendar)).EndInit();
			this.splitCalendar.Panel1.ResumeLayout(false);
			this.splitCalendar.Panel2.ResumeLayout(false);
			this.splitCalendar.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.panelList.ResumeLayout(false);
			this.panelList.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Panel panelList;
		private Wisej.Web.EmptyState emptyList;
		private Wisej.Web.DataGridView grid;
		private Wisej.Web.DataGridViewChipColumn colType;
		private Wisej.Web.DataGridViewTextBoxColumn colSubject;
		private Wisej.Web.DataGridViewTextBoxColumn colDetails;
		private Wisej.Web.DataGridViewLinkColumn colRelated;
		private Wisej.Web.DataGridViewAvatarColumn colUser;
		private Wisej.Web.DataGridViewTextBoxColumn colDate;
		private Wisej.Web.SplitContainer splitCalendar;
		private Wisej.Web.Button buttonLogOnDay;
		private Wisej.Web.Label labelDay;
		private Wisej.Web.ToolBar toolStrip;
		private Wisej.Web.ToolBarButton buttonLog;
		private Wisej.Web.ToolBarButton toolStripSeparator1;
		private Wisej.Web.ToolBarButton buttonCalendar;
		private Wisej.Web.ToolBarButton buttonList;
		private Wisej.Web.ToolBarButton toolStripSeparator2;
		private Wisej.Web.ToolBarButton labelType;
		private Wisej.Web.ComboBox comboType;
		private Wisej.Web.ToolBarControl comboTypeHost;
		private Wisej.Web.ToolBarButton labelUser;
		private Wisej.Web.ComboBox comboUser;
		private Wisej.Web.ToolBarControl comboUserHost;
		private Wisej.Web.ToolBarButton toolStripSeparator3;
		private Wisej.Web.ToolBarButton buttonExport;
		private Wisej.Web.ToolBarButton labelCount;
		private Wisej.Web.ContextMenu contextMenu;
		private Wisej.Web.MenuItem menuOpen;
		private Wisej.Web.MenuItem menuSeparator1;
		private Wisej.Web.MenuItem menuDelete;
		private Wisej.Web.SchedulerView schedulerView;
		private Wisej.Web.Timeline timelineDay;
		private Wisej.Web.EmptyState emptyDay;
	}
}
