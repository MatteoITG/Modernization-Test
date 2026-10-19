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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelList = new System.Windows.Forms.Panel();
			this.labelEmpty = new System.Windows.Forms.Label();
			this.grid = new System.Windows.Forms.DataGridView();
			this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colRelated = new System.Windows.Forms.DataGridViewLinkColumn();
			this.colUser = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.splitCalendar = new System.Windows.Forms.SplitContainer();
			this.buttonLogOnDay = new System.Windows.Forms.Button();
			this.labelCalendarHint = new System.Windows.Forms.Label();
			this.monthCalendar = new System.Windows.Forms.MonthCalendar();
			this.listViewDay = new System.Windows.Forms.ListView();
			this.columnDayTime = new System.Windows.Forms.ColumnHeader();
			this.columnDayType = new System.Windows.Forms.ColumnHeader();
			this.columnDaySubject = new System.Windows.Forms.ColumnHeader();
			this.columnDayRelated = new System.Windows.Forms.ColumnHeader();
			this.columnDayUser = new System.Windows.Forms.ColumnHeader();
			this.columnDayDuration = new System.Windows.Forms.ColumnHeader();
			this.labelDay = new System.Windows.Forms.Label();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.buttonLog = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonCalendar = new System.Windows.Forms.ToolStripButton();
			this.buttonList = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.labelType = new System.Windows.Forms.ToolStripLabel();
			this.comboType = new System.Windows.Forms.ToolStripComboBox();
			this.labelUser = new System.Windows.Forms.ToolStripLabel();
			this.comboUser = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonExport = new System.Windows.Forms.ToolStripButton();
			this.labelCount = new System.Windows.Forms.ToolStripLabel();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.panelList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitCalendar)).BeginInit();
			this.splitCalendar.Panel1.SuspendLayout();
			this.splitCalendar.Panel2.SuspendLayout();
			this.splitCalendar.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.contextMenu.SuspendLayout();
			this.SuspendLayout();
			//
			// panelList
			//
			this.panelList.Controls.Add(this.labelEmpty);
			this.panelList.Controls.Add(this.grid);
			this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelList.Location = new System.Drawing.Point(0, 27);
			this.panelList.Name = "panelList";
			this.panelList.Size = new System.Drawing.Size(1000, 573);
			this.panelList.TabIndex = 2;
			this.panelList.Visible = false;
			//
			// labelEmpty
			//
			this.labelEmpty.BackColor = System.Drawing.SystemColors.Window;
			this.labelEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
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
			this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colType,
			this.colSubject,
			this.colDetails,
			this.colRelated,
			this.colUser,
			this.colDate});
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.AllowUserToResizeRows = false;
			this.grid.BackgroundColor = System.Drawing.SystemColors.Window;
			this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(0, 0);
			this.grid.MultiSelect = false;
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersVisible = false;
			this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.grid.Size = new System.Drawing.Size(400, 200);
			this.grid.TabIndex = 0;
			this.grid.ContextMenuStrip = this.contextMenu;
			this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
			this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
			this.grid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_CellMouseDown);
			this.grid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.grid_KeyDown);
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
			this.colSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
			this.colRelated.TrackVisitedState = false;
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
			this.splitCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitCalendar.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitCalendar.Location = new System.Drawing.Point(0, 27);
			this.splitCalendar.Name = "splitCalendar";
			//
			// splitCalendar.Panel1
			//
			this.splitCalendar.Panel1.Controls.Add(this.buttonLogOnDay);
			this.splitCalendar.Panel1.Controls.Add(this.labelCalendarHint);
			this.splitCalendar.Panel1.Controls.Add(this.monthCalendar);
			this.splitCalendar.Panel1.Padding = new System.Windows.Forms.Padding(8);
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
			this.buttonLogOnDay.Dock = System.Windows.Forms.DockStyle.Top;
			this.buttonLogOnDay.Location = new System.Drawing.Point(8, 340);
			this.buttonLogOnDay.Name = "buttonLogOnDay";
			this.buttonLogOnDay.Size = new System.Drawing.Size(244, 28);
			this.buttonLogOnDay.TabIndex = 2;
			this.buttonLogOnDay.Text = "Log activity on this day...";
			this.buttonLogOnDay.UseVisualStyleBackColor = true;
			this.buttonLogOnDay.Click += new System.EventHandler(this.buttonLogOnDay_Click);
			//
			// labelCalendarHint
			//
			this.labelCalendarHint.Dock = System.Windows.Forms.DockStyle.Top;
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
			this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Top;
			this.monthCalendar.Location = new System.Drawing.Point(8, 8);
			this.monthCalendar.MaxSelectionCount = 7;
			this.monthCalendar.Name = "monthCalendar";
			this.monthCalendar.ShowWeekNumbers = true;
			this.monthCalendar.TabIndex = 0;
			this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
			//
			// listViewDay
			//
			this.listViewDay.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnDayTime,
			this.columnDayType,
			this.columnDaySubject,
			this.columnDayRelated,
			this.columnDayUser,
			this.columnDayDuration});
			this.listViewDay.ContextMenuStrip = this.contextMenu;
			this.listViewDay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewDay.FullRowSelect = true;
			this.listViewDay.HideSelection = false;
			this.listViewDay.Location = new System.Drawing.Point(0, 32);
			this.listViewDay.MultiSelect = false;
			this.listViewDay.Name = "listViewDay";
			this.listViewDay.ShowItemToolTips = true;
			this.listViewDay.Size = new System.Drawing.Size(736, 541);
			this.listViewDay.TabIndex = 1;
			this.listViewDay.UseCompatibleStateImageBehavior = false;
			this.listViewDay.View = System.Windows.Forms.View.Details;
			this.listViewDay.ItemActivate += new System.EventHandler(this.listViewDay_ItemActivate);
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
			this.labelDay.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelDay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.labelDay.Location = new System.Drawing.Point(0, 0);
			this.labelDay.Name = "labelDay";
			this.labelDay.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.labelDay.Size = new System.Drawing.Size(736, 32);
			this.labelDay.TabIndex = 0;
			this.labelDay.Text = "Today";
			this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// toolStrip
			//
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonLog,
			this.toolStripSeparator1,
			this.buttonCalendar,
			this.buttonList,
			this.toolStripSeparator2,
			this.labelType,
			this.comboType,
			this.labelUser,
			this.comboUser,
			this.toolStripSeparator3,
			this.buttonExport,
			this.labelCount});
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(800, 27);
			this.toolStrip.TabIndex = 0;
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
			//
			// buttonCalendar
			//
			this.buttonCalendar.Checked = true;
			this.buttonCalendar.CheckState = System.Windows.Forms.CheckState.Checked;
			this.buttonCalendar.Tag = "calendar-event";
			this.buttonCalendar.Name = "buttonCalendar";
			this.buttonCalendar.Text = "Calendar";
			this.buttonCalendar.Click += new System.EventHandler(this.buttonMode_Click);
			//
			// buttonList
			//
			this.buttonList.Tag = "layout-three-columns";
			this.buttonList.Name = "buttonList";
			this.buttonList.Text = "List";
			this.buttonList.Click += new System.EventHandler(this.buttonMode_Click);
			//
			// toolStripSeparator2
			//
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			//
			// labelType
			//
			this.labelType.Name = "labelType";
			this.labelType.Text = "Type:";
			//
			// comboType
			//
			this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboType.Size = new System.Drawing.Size(100, 23);
			this.comboType.Name = "comboType";
			this.comboType.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
			//
			// labelUser
			//
			this.labelUser.Name = "labelUser";
			this.labelUser.Text = "User:";
			//
			// comboUser
			//
			this.comboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboUser.Size = new System.Drawing.Size(140, 23);
			this.comboUser.Name = "comboUser";
			this.comboUser.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
			//
			// toolStripSeparator3
			//
			this.toolStripSeparator3.Name = "toolStripSeparator3";
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
			this.labelCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.labelCount.Name = "labelCount";
			this.labelCount.Text = "0 activities";
			//
			// contextMenu
			//
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuOpen,
			this.menuSeparator1,
			this.menuDelete});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(181, 54);
			this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
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
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panelList);
			this.Controls.Add(this.splitCalendar);
			this.Controls.Add(this.toolStrip);
			this.Name = "ActivitiesView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.Load += new System.EventHandler(this.ActivitiesView_Load);
			this.contextMenu.ResumeLayout(false);
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

		private System.Windows.Forms.Panel panelList;
		private System.Windows.Forms.Label labelEmpty;
		private System.Windows.Forms.DataGridView grid;
		private System.Windows.Forms.DataGridViewTextBoxColumn colType;
		private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDetails;
		private System.Windows.Forms.DataGridViewLinkColumn colRelated;
		private System.Windows.Forms.DataGridViewTextBoxColumn colUser;
		private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
		private System.Windows.Forms.SplitContainer splitCalendar;
		private System.Windows.Forms.Button buttonLogOnDay;
		private System.Windows.Forms.Label labelCalendarHint;
		private System.Windows.Forms.MonthCalendar monthCalendar;
		private System.Windows.Forms.ListView listViewDay;
		private System.Windows.Forms.ColumnHeader columnDayTime;
		private System.Windows.Forms.ColumnHeader columnDayType;
		private System.Windows.Forms.ColumnHeader columnDaySubject;
		private System.Windows.Forms.ColumnHeader columnDayRelated;
		private System.Windows.Forms.ColumnHeader columnDayUser;
		private System.Windows.Forms.ColumnHeader columnDayDuration;
		private System.Windows.Forms.Label labelDay;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton buttonLog;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton buttonCalendar;
		private System.Windows.Forms.ToolStripButton buttonList;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripLabel labelType;
		private System.Windows.Forms.ToolStripComboBox comboType;
		private System.Windows.Forms.ToolStripLabel labelUser;
		private System.Windows.Forms.ToolStripComboBox comboUser;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton buttonExport;
		private System.Windows.Forms.ToolStripLabel labelCount;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem menuOpen;
		private System.Windows.Forms.ToolStripSeparator menuSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuDelete;
	}
}
