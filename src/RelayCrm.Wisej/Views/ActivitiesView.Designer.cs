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
			this.labelEmpty = new Wisej.Web.Label();
			this.grid = new Wisej.Web.DataGridView();
			this.colType = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colSubject = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colDetails = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colRelated = new Wisej.Web.DataGridViewLinkColumn();
			this.colUser = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colDate = new Wisej.Web.DataGridViewTextBoxColumn();
			this.splitCalendar = new Wisej.Web.SplitContainer();
			this.buttonLogOnDay = new Wisej.Web.Button();
			this.labelCalendarHint = new Wisej.Web.Label();
			this.monthCalendar = new Wisej.Web.MonthCalendar();
			this.listViewDay = new Wisej.Web.ListView();
			this.columnDayTime = new Wisej.Web.ColumnHeader();
			this.columnDayType = new Wisej.Web.ColumnHeader();
			this.columnDaySubject = new Wisej.Web.ColumnHeader();
			this.columnDayRelated = new Wisej.Web.ColumnHeader();
			this.columnDayUser = new Wisej.Web.ColumnHeader();
			this.columnDayDuration = new Wisej.Web.ColumnHeader();
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
			this.panelList.Controls.Add(this.labelEmpty);
			this.panelList.Controls.Add(this.grid);
			this.panelList.Dock = Wisej.Web.DockStyle.Fill;
			this.panelList.Location = new System.Drawing.Point(0, 27);
			this.panelList.Name = "panelList";
			this.panelList.Size = new System.Drawing.Size(1000, 573);
			this.panelList.TabIndex = 2;
			this.panelList.Visible = false;
			//
			// labelEmpty
			//
			this.labelEmpty.BackColor = System.Drawing.SystemColors.Window;
			this.labelEmpty.Dock = Wisej.Web.DockStyle.Fill;
			this.labelEmpty.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelEmpty.Location = new System.Drawing.Point(0, 0);
			this.labelEmpty.Name = "labelEmpty";
			this.labelEmpty.Size = new System.Drawing.Size(1000, 573);
			this.labelEmpty.TabIndex = 1;
			this.labelEmpty.Text = "No activities match the filters.";
			this.labelEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelEmpty.Visible = false;
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
			//
			// colType
			//
			this.colType.DataPropertyName = "TypeName";
			this.colType.HeaderText = "Type";
			this.colType.Name = "colType";
			this.colType.Width = 70;
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
			this.colUser.Width = 120;
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
			this.splitCalendar.FixedPanel = Wisej.Web.FixedPanel.Panel1;
			this.splitCalendar.Location = new System.Drawing.Point(0, 27);
			this.splitCalendar.Name = "splitCalendar";
			//
			// splitCalendar.Panel1
			//
			this.splitCalendar.Panel1.Controls.Add(this.buttonLogOnDay);
			this.splitCalendar.Panel1.Controls.Add(this.labelCalendarHint);
			this.splitCalendar.Panel1.Controls.Add(this.monthCalendar);
			this.splitCalendar.Panel1.Padding = new Wisej.Web.Padding(8);
			//
			// splitCalendar.Panel2
			//
			this.splitCalendar.Panel2.Controls.Add(this.listViewDay);
			this.splitCalendar.Panel2.Controls.Add(this.labelDay);
			this.splitCalendar.Size = new System.Drawing.Size(1000, 573);
			this.splitCalendar.SplitterDistance = 260;
			this.splitCalendar.TabIndex = 1;
			//
			// buttonLogOnDay
			//
			this.buttonLogOnDay.Dock = Wisej.Web.DockStyle.Top;
			this.buttonLogOnDay.Location = new System.Drawing.Point(8, 340);
			this.buttonLogOnDay.Name = "buttonLogOnDay";
			this.buttonLogOnDay.Size = new System.Drawing.Size(244, 28);
			this.buttonLogOnDay.TabIndex = 2;
			this.buttonLogOnDay.Text = "Log activity on this day...";
			this.buttonLogOnDay.Click += new System.EventHandler(this.buttonLogOnDay_Click);
			//
			// labelCalendarHint
			//
			this.labelCalendarHint.Dock = Wisej.Web.DockStyle.Top;
			this.labelCalendarHint.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelCalendarHint.Location = new System.Drawing.Point(8, 300);
			this.labelCalendarHint.Name = "labelCalendarHint";
			this.labelCalendarHint.Size = new System.Drawing.Size(244, 40);
			this.labelCalendarHint.TabIndex = 1;
			this.labelCalendarHint.Text = "Days in bold have activities. Select a day, or drag over up to 7 days.";
			//
			// monthCalendar
			//
			this.monthCalendar.CalendarDimensions = new System.Drawing.Size(1, 2);
			this.monthCalendar.Dock = Wisej.Web.DockStyle.Top;
			this.monthCalendar.Location = new System.Drawing.Point(8, 8);
			this.monthCalendar.MaxSelectionCount = 7;
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.ShowWeekNumbers = true;
			this.monthCalendar.TabIndex = 0;
			this.monthCalendar.DateChanged += new Wisej.Web.DateRangeEventHandler(this.monthCalendar_DateChanged);
			//
			// listViewDay
			//
			this.listViewDay.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
			this.columnDayTime,
			this.columnDayType,
			this.columnDaySubject,
			this.columnDayRelated,
			this.columnDayUser,
			this.columnDayDuration});
			this.listViewDay.ContextMenu = this.contextMenu;
			this.listViewDay.Dock = Wisej.Web.DockStyle.Fill;
			this.listViewDay.Location = new System.Drawing.Point(0, 32);
			this.listViewDay.MultiSelect = false;
			this.listViewDay.Name = "listViewDay";
			this.listViewDay.ShowItemToolTips = true;
			this.listViewDay.Size = new System.Drawing.Size(736, 541);
			this.listViewDay.TabIndex = 1;
			this.listViewDay.View = Wisej.Web.View.Details;
			this.listViewDay.ItemDoubleClick += new Wisej.Web.ItemClickEventHandler(this.listViewDay_ItemActivate);
			//
			// columnDayTime
			//
			this.columnDayTime.Text = "Time";
			this.columnDayTime.Width = 120;
			//
			// columnDayType
			//
			this.columnDayType.Text = "Type";
			this.columnDayType.Width = 70;
			//
			// columnDaySubject
			//
			this.columnDaySubject.Text = "Subject";
			this.columnDaySubject.Width = 220;
			//
			// columnDayRelated
			//
			this.columnDayRelated.Text = "Related to";
			this.columnDayRelated.Width = 240;
			//
			// columnDayUser
			//
			this.columnDayUser.Text = "User";
			this.columnDayUser.Width = 110;
			//
			// columnDayDuration
			//
			this.columnDayDuration.Text = "Duration";
			this.columnDayDuration.Width = 70;
			//
			// labelDay
			//
			this.labelDay.Dock = Wisej.Web.DockStyle.Top;
			this.labelDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.labelDay.Location = new System.Drawing.Point(0, 0);
			this.labelDay.Name = "labelDay";
			this.labelDay.Padding = new Wisej.Web.Padding(4, 0, 0, 0);
			this.labelDay.Size = new System.Drawing.Size(736, 32);
			this.labelDay.TabIndex = 0;
			this.labelDay.Text = "Today";
			this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.panelList);
			this.Controls.Add(this.splitCalendar);
			this.Controls.Add(this.toolStrip);
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
		private Wisej.Web.Label labelEmpty;
		private Wisej.Web.DataGridView grid;
		private Wisej.Web.DataGridViewTextBoxColumn colType;
		private Wisej.Web.DataGridViewTextBoxColumn colSubject;
		private Wisej.Web.DataGridViewTextBoxColumn colDetails;
		private Wisej.Web.DataGridViewLinkColumn colRelated;
		private Wisej.Web.DataGridViewTextBoxColumn colUser;
		private Wisej.Web.DataGridViewTextBoxColumn colDate;
		private Wisej.Web.SplitContainer splitCalendar;
		private Wisej.Web.Button buttonLogOnDay;
		private Wisej.Web.Label labelCalendarHint;
		private Wisej.Web.MonthCalendar monthCalendar;
		private Wisej.Web.ListView listViewDay;
		private Wisej.Web.ColumnHeader columnDayTime;
		private Wisej.Web.ColumnHeader columnDayType;
		private Wisej.Web.ColumnHeader columnDaySubject;
		private Wisej.Web.ColumnHeader columnDayRelated;
		private Wisej.Web.ColumnHeader columnDayUser;
		private Wisej.Web.ColumnHeader columnDayDuration;
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
	}
}
