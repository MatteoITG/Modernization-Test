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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivitiesView));
			this.components = new System.ComponentModel.Container();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment3 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment4 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment5 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment6 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment7 = new Wisej.Web.Segment();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelCount = new Wisej.Web.Label();
			this.buttonLog = new Wisej.Web.Button();
			this.flowMode = new Wisej.Web.FlowLayoutPanel();
			this.segmentedMode = new Wisej.Web.SegmentedButton();
			this.buttonExport = new Wisej.Web.Button();
			this.panelFilters = new Wisej.Web.Panel();
			this.chipsType = new Wisej.Web.ChipGroup();
			this.flowUser = new Wisej.Web.FlowLayoutPanel();
			this.labelUser = new Wisej.Web.Label();
			this.comboBoxUser = new Wisej.Web.ComboBox();
			this.splitCalendar = new Wisej.Web.SplitContainer();
			this.schedulerView = new Wisej.Web.SchedulerView();
			this.emptyDay = new Wisej.Web.EmptyState();
			this.timelineDay = new Wisej.Web.Timeline();
			this.panelDay = new Wisej.Web.Panel();
			this.labelDay = new Wisej.Web.Label();
			this.buttonLogOnDay = new Wisej.Web.Button();
			this.panelList = new Wisej.Web.Panel();
			this.emptyState = new Wisej.Web.EmptyState();
			this.grid = new Wisej.Web.DataGridView();
			this.colDate = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colType = new Wisej.Web.DataGridViewChipColumn();
			this.colSubject = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colRelated = new Wisej.Web.DataGridViewLinkColumn();
			this.colUser = new Wisej.Web.DataGridViewAvatarColumn();
			this.colMinutes = new Wisej.Web.DataGridViewTextBoxColumn();
			this.contextMenuGrid = new Wisej.Web.ContextMenu(this.components);
			this.menuOpen = new Wisej.Web.MenuItem();
			this.menuSeparator = new Wisej.Web.MenuItem();
			this.menuDelete = new Wisej.Web.MenuItem();
			this.panelHeader.SuspendLayout();
			this.flowMode.SuspendLayout();
			this.panelFilters.SuspendLayout();
			this.flowUser.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitCalendar)).BeginInit();
			this.splitCalendar.Panel1.SuspendLayout();
			this.splitCalendar.Panel2.SuspendLayout();
			this.splitCalendar.SuspendLayout();
			this.panelDay.SuspendLayout();
			this.panelList.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.labelCount);
			this.panelHeader.Controls.Add(this.buttonLog);
			this.panelHeader.Controls.Add(this.flowMode);
			this.panelHeader.CssClass = "relay-toolbar";
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelHeader.ResponsiveProfiles"))));
			this.panelHeader.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelHeader.ResponsiveProfiles1"))));
			this.panelHeader.Padding = new Wisej.Web.Padding(12, 8, 12, 8);
			this.panelHeader.Size = new System.Drawing.Size(1000, 56);
			this.panelHeader.TabIndex = 0;
			//
			// labelCount
			//
			this.labelCount.AutoEllipsis = true;
			this.labelCount.CssClass = "relay-muted";
			this.labelCount.Dock = Wisej.Web.DockStyle.Fill;
			this.labelCount.Location = new System.Drawing.Point(152, 8);
			this.labelCount.Name = "labelCount";
			this.labelCount.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.labelCount.Size = new System.Drawing.Size(456, 40);
			this.labelCount.TabIndex = 1;
			this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonLog
			//
			this.buttonLog.CssClass = "relay-primary";
			this.buttonLog.Dock = Wisej.Web.DockStyle.Left;
			this.buttonLog.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/journal-plus.svg";
			this.buttonLog.Location = new System.Drawing.Point(12, 8);
			this.buttonLog.Name = "buttonLog";
			this.buttonLog.Size = new System.Drawing.Size(140, 40);
			this.buttonLog.TabIndex = 0;
			this.buttonLog.Text = "Log activity...";
			this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
			//
			// flowMode
			//
			this.flowMode.Controls.Add(this.segmentedMode);
			this.flowMode.Controls.Add(this.buttonExport);
			this.flowMode.Dock = Wisej.Web.DockStyle.Right;
			this.flowMode.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowMode.Location = new System.Drawing.Point(608, 8);
			this.flowMode.Name = "flowMode";
			this.flowMode.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flowMode.ResponsiveProfiles"))));
			this.flowMode.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("flowMode.ResponsiveProfiles1"))));
			this.flowMode.Size = new System.Drawing.Size(380, 40);
			this.flowMode.TabIndex = 2;
			this.flowMode.TabStop = true;
			//
			// segmentedMode
			//
			segment1.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar3.svg";
			segment1.Text = "Calendar";
			segment2.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/list-ul.svg";
			segment2.Text = "List";
			this.segmentedMode.Items.Add(segment1);
			this.segmentedMode.Items.Add(segment2);
			this.segmentedMode.Location = new System.Drawing.Point(150, 0);
			this.segmentedMode.Margin = new Wisej.Web.Padding(0);
			this.segmentedMode.Name = "segmentedMode";
			this.segmentedMode.SelectedIndex = 0;
			this.segmentedMode.Size = new System.Drawing.Size(230, 40);
			this.segmentedMode.TabIndex = 1;
			this.segmentedMode.SelectedIndexChanged += new System.EventHandler(this.segmentedMode_SelectedIndexChanged);
			//
			// buttonExport
			//
			this.buttonExport.CssClass = "relay-secondary";
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/download.svg";
			this.buttonExport.Location = new System.Drawing.Point(8, 2);
			this.buttonExport.Margin = new Wisej.Web.Padding(0, 2, 12, 2);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(130, 36);
			this.buttonExport.TabIndex = 0;
			this.buttonExport.Text = "Export CSV";
			this.buttonExport.Visible = false;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			//
			// panelFilters
			//
			this.panelFilters.Controls.Add(this.chipsType);
			this.panelFilters.Controls.Add(this.flowUser);
			this.panelFilters.Dock = Wisej.Web.DockStyle.Top;
			this.panelFilters.Location = new System.Drawing.Point(0, 56);
			this.panelFilters.Name = "panelFilters";
			this.panelFilters.Padding = new Wisej.Web.Padding(12, 8, 12, 8);
			this.panelFilters.Size = new System.Drawing.Size(1000, 56);
			this.panelFilters.TabIndex = 1;
			//
			// chipsType
			//
			this.chipsType.Dock = Wisej.Web.DockStyle.Fill;
			segment3.Text = "All";
			segment4.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/telephone.svg";
			segment4.Text = "Calls";
			segment5.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/envelope.svg";
			segment5.Text = "Emails";
			segment6.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/people.svg";
			segment6.Text = "Meetings";
			segment7.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/sticky.svg";
			segment7.Text = "Notes";
			this.chipsType.Items.Add(segment3);
			this.chipsType.Items.Add(segment4);
			this.chipsType.Items.Add(segment5);
			this.chipsType.Items.Add(segment6);
			this.chipsType.Items.Add(segment7);
			this.chipsType.Location = new System.Drawing.Point(12, 8);
			this.chipsType.Name = "chipsType";
			this.chipsType.SelectedIndex = 0;
			this.chipsType.Size = new System.Drawing.Size(716, 40);
			this.chipsType.TabIndex = 0;
			this.chipsType.ToolTipText = "Type";
			this.chipsType.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
			//
			// flowUser
			//
			this.flowUser.Controls.Add(this.labelUser);
			this.flowUser.Controls.Add(this.comboBoxUser);
			this.flowUser.Dock = Wisej.Web.DockStyle.Right;
			this.flowUser.Location = new System.Drawing.Point(728, 8);
			this.flowUser.Name = "flowUser";
			this.flowUser.Padding = new Wisej.Web.Padding(0, 4, 0, 0);
			this.flowUser.Size = new System.Drawing.Size(260, 40);
			this.flowUser.TabIndex = 1;
			this.flowUser.TabStop = true;
			//
			// labelUser
			//
			this.labelUser.AutoSize = true;
			this.labelUser.CssClass = "relay-muted";
			this.labelUser.Location = new System.Drawing.Point(0, 11);
			this.labelUser.Margin = new Wisej.Web.Padding(0, 7, 6, 0);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(34, 16);
			this.labelUser.TabIndex = 0;
			this.labelUser.Text = "User:";
			//
			// comboBoxUser
			//
			this.comboBoxUser.DisplayMember = "Text";
			this.comboBoxUser.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxUser.Location = new System.Drawing.Point(40, 4);
			this.comboBoxUser.Margin = new Wisej.Web.Padding(0);
			this.comboBoxUser.Name = "comboBoxUser";
			this.comboBoxUser.Size = new System.Drawing.Size(200, 30);
			this.comboBoxUser.TabIndex = 1;
			this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
			//
			// splitCalendar
			//
			this.splitCalendar.Dock = Wisej.Web.DockStyle.Fill;
			this.splitCalendar.FixedPanel = Wisej.Web.FixedPanel.Panel2;
			this.splitCalendar.Location = new System.Drawing.Point(0, 112);
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
			this.splitCalendar.Panel2.Controls.Add(this.panelDay);
			this.splitCalendar.Panel2.Padding = new Wisej.Web.Padding(8);
			this.splitCalendar.Size = new System.Drawing.Size(1000, 588);
			this.splitCalendar.SplitterDistance = 640;
			this.splitCalendar.TabIndex = 2;
			//
			// schedulerView
			//
			this.schedulerView.AllowCreate = false;
			this.schedulerView.AllowMove = false;
			this.schedulerView.AllowResize = false;
			this.schedulerView.Dock = Wisej.Web.DockStyle.Fill;
			this.schedulerView.EndHour = 19;
			this.schedulerView.Location = new System.Drawing.Point(8, 8);
			this.schedulerView.Name = "schedulerView";
			this.schedulerView.Size = new System.Drawing.Size(624, 572);
			this.schedulerView.StartHour = 7;
			this.schedulerView.TabIndex = 0;
			this.schedulerView.ToolTipText = "Double-click an activity to open it, a day to plan a meeting";
			this.schedulerView.View = Wisej.Web.SchedulerViewMode.Month;
			this.schedulerView.AppointmentClick += new System.EventHandler<Wisej.Web.SchedulerAppointmentEventArgs>(this.schedulerView_AppointmentClick);
			this.schedulerView.AppointmentDoubleClick += new System.EventHandler<Wisej.Web.SchedulerAppointmentEventArgs>(this.schedulerView_AppointmentDoubleClick);
			this.schedulerView.SlotDoubleClick += new System.EventHandler<Wisej.Web.SchedulerSlotEventArgs>(this.schedulerView_SlotDoubleClick);
			this.schedulerView.RangeChanged += new System.EventHandler<System.EventArgs>(this.schedulerView_RangeChanged);
			//
			// emptyDay
			//
			this.emptyDay.Compact = true;
			this.emptyDay.Description = "Double-click a day to plan a meeting.";
			this.emptyDay.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyDay.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.emptyDay.Location = new System.Drawing.Point(8, 84);
			this.emptyDay.Name = "emptyDay";
			this.emptyDay.Size = new System.Drawing.Size(340, 496);
			this.emptyDay.TabIndex = 2;
			this.emptyDay.Title = "No activities on this day.";
			this.emptyDay.Visible = false;
			//
			// timelineDay
			//
			this.timelineDay.ContextMenu = this.contextMenuGrid;
			this.timelineDay.Dock = Wisej.Web.DockStyle.Fill;
			this.timelineDay.HasMoreItems = false;
			this.timelineDay.Location = new System.Drawing.Point(8, 84);
			this.timelineDay.Name = "timelineDay";
			this.timelineDay.Size = new System.Drawing.Size(340, 496);
			this.timelineDay.TabIndex = 1;
			this.timelineDay.TimeFormat = "HH:mm";
			this.timelineDay.ItemClick += new System.EventHandler<Wisej.Web.TimelineItemEventArgs>(this.timelineDay_ItemClick);
			//
			// panelDay
			//
			this.panelDay.Controls.Add(this.labelDay);
			this.panelDay.Controls.Add(this.buttonLogOnDay);
			this.panelDay.Dock = Wisej.Web.DockStyle.Top;
			this.panelDay.Location = new System.Drawing.Point(8, 8);
			this.panelDay.Name = "panelDay";
			this.panelDay.Size = new System.Drawing.Size(340, 76);
			this.panelDay.TabIndex = 0;
			//
			// labelDay
			//
			this.labelDay.AppearanceKey = "relay-card-title";
			this.labelDay.AutoEllipsis = true;
			this.labelDay.Dock = Wisej.Web.DockStyle.Fill;
			this.labelDay.Location = new System.Drawing.Point(0, 0);
			this.labelDay.Name = "labelDay";
			this.labelDay.Size = new System.Drawing.Size(340, 40);
			this.labelDay.TabIndex = 0;
			this.labelDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonLogOnDay
			//
			this.buttonLogOnDay.CssClass = "relay-secondary";
			this.buttonLogOnDay.Dock = Wisej.Web.DockStyle.Bottom;
			this.buttonLogOnDay.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus.svg";
			this.buttonLogOnDay.Location = new System.Drawing.Point(0, 40);
			this.buttonLogOnDay.Name = "buttonLogOnDay";
			this.buttonLogOnDay.Size = new System.Drawing.Size(340, 36);
			this.buttonLogOnDay.TabIndex = 1;
			this.buttonLogOnDay.Text = "Plan a meeting on this day...";
			this.buttonLogOnDay.Click += new System.EventHandler(this.buttonLogOnDay_Click);
			//
			// panelList
			//
			this.panelList.Controls.Add(this.emptyState);
			this.panelList.Controls.Add(this.grid);
			this.panelList.Dock = Wisej.Web.DockStyle.Fill;
			this.panelList.Location = new System.Drawing.Point(0, 112);
			this.panelList.Name = "panelList";
			this.panelList.Size = new System.Drawing.Size(1000, 588);
			this.panelList.TabIndex = 3;
			this.panelList.Visible = false;
			//
			// emptyState
			//
			this.emptyState.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyState.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.emptyState.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyState.Location = new System.Drawing.Point(0, 0);
			this.emptyState.Name = "emptyState";
			this.emptyState.Size = new System.Drawing.Size(1000, 588);
			this.emptyState.TabIndex = 1;
			this.emptyState.Title = "No activities match the filters.";
			this.emptyState.Visible = false;
			//
			// grid
			//
			this.grid.AllowUserToResizeRows = false;
			this.grid.AutoGenerateColumns = false;
			this.grid.BorderStyle = Wisej.Web.BorderStyle.None;
			this.grid.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colDate,
			this.colType,
			this.colSubject,
			this.colRelated,
			this.colUser,
			this.colMinutes});
			this.grid.ContextMenu = this.contextMenuGrid;
			this.grid.CssClass = "relay-grid";
			this.grid.Dock = Wisej.Web.DockStyle.Fill;
			this.grid.KeepSameRowHeight = true;
			this.grid.Location = new System.Drawing.Point(0, 0);
			this.grid.MultiSelect = false;
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersVisible = false;
			this.grid.RowTemplate.Height = 40;
			this.grid.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.grid.ShowColumnVisibilityMenu = false;
			this.grid.Size = new System.Drawing.Size(1000, 588);
			this.grid.TabIndex = 0;
			this.grid.ToolTipText = "Double-click to open the related record; right-click for more";
			this.grid.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.grid_CellClick);
			this.grid.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
			this.grid.CellMouseDown += new Wisej.Web.DataGridViewCellMouseEventHandler(this.grid_CellMouseDown);
			//
			// colDate
			//
			this.colDate.DataPropertyName = "Date";
			this.colDate.HeaderText = "Date";
			this.colDate.Name = "colDate";
			this.colDate.Tag = "Fmt:DateTime";
			this.colDate.Width = 180;
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
			this.colSubject.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colSubject.DataPropertyName = "Subject";
			this.colSubject.FillWeight = 200F;
			this.colSubject.HeaderText = "Subject";
			this.colSubject.Name = "colSubject";
			//
			// colRelated
			//
			this.colRelated.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colRelated.DataPropertyName = "RelatedText";
			this.colRelated.FillWeight = 200F;
			this.colRelated.HeaderText = "Related to";
			this.colRelated.Name = "colRelated";
			//
			// colUser
			//
			this.colUser.AutoColor = true;
			this.colUser.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colUser.DataPropertyName = "UserName";
			this.colUser.FillWeight = 120F;
			this.colUser.HeaderText = "User";
			this.colUser.Name = "colUser";
			this.colUser.TextMember = "UserName";
			//
			// colMinutes
			//
			dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colMinutes.DataPropertyName = "Duration";
			this.colMinutes.DefaultCellStyle = dataGridViewCellStyle1;
			this.colMinutes.HeaderText = "Minutes";
			this.colMinutes.Name = "colMinutes";
			this.colMinutes.Width = 80;
			//
			// contextMenuGrid
			//
			this.contextMenuGrid.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuOpen,
			this.menuSeparator,
			this.menuDelete});
			this.contextMenuGrid.Name = "contextMenuGrid";
			//
			// menuOpen
			//
			this.menuOpen.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.menuOpen.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/box-arrow-up-right.svg";
			this.menuOpen.Index = 0;
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Text = "Open related record";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			//
			// menuSeparator
			//
			this.menuSeparator.Index = 1;
			this.menuSeparator.Name = "menuSeparator";
			this.menuSeparator.Text = "-";
			//
			// menuDelete
			//
			this.menuDelete.IconSource = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			this.menuDelete.Index = 2;
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Text = "Delete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// ActivitiesView
			//
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.splitCalendar);
			this.Controls.Add(this.panelList);
			this.Controls.Add(this.panelFilters);
			this.Controls.Add(this.panelHeader);
			this.CssClass = "relay-card";
			this.Name = "ActivitiesView";
			this.Size = new System.Drawing.Size(1000, 700);
			this.Load += new System.EventHandler(this.ActivitiesView_Load);
			this.panelHeader.ResumeLayout(false);
			this.flowMode.ResumeLayout(false);
			this.panelFilters.ResumeLayout(false);
			this.flowUser.ResumeLayout(false);
			this.flowUser.PerformLayout();
			this.splitCalendar.Panel1.ResumeLayout(false);
			this.splitCalendar.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitCalendar)).EndInit();
			this.splitCalendar.ResumeLayout(false);
			this.panelDay.ResumeLayout(false);
			this.panelList.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelCount;
		private Wisej.Web.Button buttonLog;
		private Wisej.Web.FlowLayoutPanel flowMode;
		private Wisej.Web.SegmentedButton segmentedMode;
		private Wisej.Web.Button buttonExport;
		private Wisej.Web.Panel panelFilters;
		private Wisej.Web.ChipGroup chipsType;
		private Wisej.Web.FlowLayoutPanel flowUser;
		private Wisej.Web.Label labelUser;
		private Wisej.Web.ComboBox comboBoxUser;
		private Wisej.Web.SplitContainer splitCalendar;
		private Wisej.Web.SchedulerView schedulerView;
		private Wisej.Web.EmptyState emptyDay;
		private Wisej.Web.Timeline timelineDay;
		private Wisej.Web.Panel panelDay;
		private Wisej.Web.Label labelDay;
		private Wisej.Web.Button buttonLogOnDay;
		private Wisej.Web.Panel panelList;
		private Wisej.Web.EmptyState emptyState;
		private Wisej.Web.DataGridView grid;
		private Wisej.Web.DataGridViewTextBoxColumn colDate;
		private Wisej.Web.DataGridViewChipColumn colType;
		private Wisej.Web.DataGridViewTextBoxColumn colSubject;
		private Wisej.Web.DataGridViewLinkColumn colRelated;
		private Wisej.Web.DataGridViewAvatarColumn colUser;
		private Wisej.Web.DataGridViewTextBoxColumn colMinutes;
		private Wisej.Web.ContextMenu contextMenuGrid;
		private Wisej.Web.MenuItem menuOpen;
		private Wisej.Web.MenuItem menuSeparator;
		private Wisej.Web.MenuItem menuDelete;
	}
}
