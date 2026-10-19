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
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment3 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment4 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment5 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment6 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment7 = new Wisej.Web.Segment();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.CardAction cardAction1 = new Wisej.Web.CardAction();
			Wisej.Web.CardAction cardAction2 = new Wisej.Web.CardAction();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelCount = new Wisej.Web.Label();
			this.buttonExport = new Wisej.Web.Button();
			this.buttonLog = new Wisej.Web.Button();
			this.panelToolbar = new Wisej.Web.Panel();
			this.segmentedMode = new Wisej.Web.SegmentedButton();
			this.chipGroupType = new Wisej.Web.ChipGroup();
			this.comboBoxUser = new Wisej.Web.ComboBox();
			this.panelCard = new Wisej.Web.Panel();
			this.scheduler = new Wisej.Web.SchedulerView();
			this.grid = new Wisej.Web.DataGridView();
			this.colType = new Wisej.Web.DataGridViewAvatarColumn();
			this.colSubject = new Wisej.Web.DataGridViewSubtitleColumn();
			this.colRelated = new Wisej.Web.DataGridViewLinkColumn();
			this.colUser = new Wisej.Web.DataGridViewAvatarColumn();
			this.colDate = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colActions = new Wisej.Web.DataGridViewActionsColumn();
			this.emptyState = new Wisej.Web.EmptyState();
			this.panelHeader.SuspendLayout();
			this.panelToolbar.SuspendLayout();
			this.panelCard.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.buttonLog);
			this.panelHeader.Controls.Add(this.buttonExport);
			this.panelHeader.Controls.Add(this.labelCount);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1100, 48);
			this.panelHeader.TabIndex = 0;
			//
			// labelCount
			//
			this.labelCount.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.labelCount.CssClass = "relay-muted";
			this.labelCount.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelCount.Location = new System.Drawing.Point(0, 0);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(800, 48);
			this.labelCount.TabIndex = 1;
			this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonExport
			//
			this.buttonExport.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonExport.CssClass = "relay-secondary";
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/download.svg";
			this.buttonExport.Location = new System.Drawing.Point(816, 6);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(132, 36);
			this.buttonExport.TabIndex = 2;
			this.buttonExport.Text = "Export CSV";
			this.buttonExport.Visible = false;
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			//
			// buttonLog
			//
			this.buttonLog.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonLog.CssClass = "relay-primary";
			this.buttonLog.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus-lg.svg";
			this.buttonLog.Location = new System.Drawing.Point(956, 6);
			this.buttonLog.Name = "buttonLog";
			this.buttonLog.Size = new System.Drawing.Size(144, 36);
			this.buttonLog.TabIndex = 3;
			this.buttonLog.Text = "Log activity";
			this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
			//
			// panelToolbar
			//
			this.panelToolbar.Controls.Add(this.comboBoxUser);
			this.panelToolbar.Controls.Add(this.chipGroupType);
			this.panelToolbar.Controls.Add(this.segmentedMode);
			this.panelToolbar.Dock = Wisej.Web.DockStyle.Top;
			this.panelToolbar.Location = new System.Drawing.Point(0, 48);
			this.panelToolbar.Name = "panelToolbar";
			this.panelToolbar.Padding = new Wisej.Web.Padding(0, 0, 0, 16);
			this.panelToolbar.Size = new System.Drawing.Size(1100, 52);
			this.panelToolbar.TabIndex = 1;
			//
			// segmentedMode
			//
			segment1.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			segment1.Text = "Calendar";
			segment2.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/list-ul.svg";
			segment2.Text = "List";
			this.segmentedMode.Items.Add(segment1);
			this.segmentedMode.Items.Add(segment2);
			this.segmentedMode.Location = new System.Drawing.Point(0, 0);
			this.segmentedMode.Name = "segmentedMode";
			this.segmentedMode.SegmentSize = Wisej.Web.SegmentSize.Small;
			this.segmentedMode.SelectedIndex = 0;
			this.segmentedMode.Size = new System.Drawing.Size(220, 36);
			this.segmentedMode.Stretch = true;
			this.segmentedMode.TabIndex = 0;
			this.segmentedMode.SelectedIndexChanged += new System.EventHandler(this.segmentedMode_SelectedIndexChanged);
			//
			// chipGroupType
			//
			segment3.Text = "All";
			segment4.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/telephone.svg";
			segment4.Text = "Call";
			segment5.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/envelope.svg";
			segment5.Text = "Email";
			segment6.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/people.svg";
			segment6.Text = "Meeting";
			segment7.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/sticky.svg";
			segment7.Text = "Note";
			this.chipGroupType.Items.Add(segment3);
			this.chipGroupType.Items.Add(segment4);
			this.chipGroupType.Items.Add(segment5);
			this.chipGroupType.Items.Add(segment6);
			this.chipGroupType.Items.Add(segment7);
			this.chipGroupType.Location = new System.Drawing.Point(236, 0);
			this.chipGroupType.Name = "chipGroupType";
			this.chipGroupType.SelectedIndex = 0;
			this.chipGroupType.Size = new System.Drawing.Size(440, 36);
			this.chipGroupType.TabIndex = 1;
			this.chipGroupType.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
			//
			// comboBoxUser
			//
			this.comboBoxUser.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxUser.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxUser.Location = new System.Drawing.Point(880, 0);
			this.comboBoxUser.Name = "comboBoxUser";
			this.comboBoxUser.Size = new System.Drawing.Size(220, 36);
			this.comboBoxUser.TabIndex = 2;
			this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.filter_Changed);
			//
			// panelCard
			//
			this.panelCard.Controls.Add(this.emptyState);
			this.panelCard.Controls.Add(this.grid);
			this.panelCard.Controls.Add(this.scheduler);
			this.panelCard.CssClass = "relay-card";
			this.panelCard.Dock = Wisej.Web.DockStyle.Fill;
			this.panelCard.Location = new System.Drawing.Point(0, 100);
			this.panelCard.Name = "panelCard";
			this.panelCard.Padding = new Wisej.Web.Padding(20);
			this.panelCard.Size = new System.Drawing.Size(1100, 660);
			this.panelCard.TabIndex = 2;
			//
			// scheduler
			//
			this.scheduler.AllowCreate = false;
			this.scheduler.AllowMove = false;
			this.scheduler.AllowResize = false;
			this.scheduler.Dock = Wisej.Web.DockStyle.Fill;
			this.scheduler.EndHour = 20;
			this.scheduler.Location = new System.Drawing.Point(20, 20);
			this.scheduler.Name = "scheduler";
			this.scheduler.ShowCurrentTime = true;
			this.scheduler.Size = new System.Drawing.Size(1060, 620);
			this.scheduler.SlotDuration = 30;
			this.scheduler.StartHour = 7;
			this.scheduler.TabIndex = 0;
			this.scheduler.View = Wisej.Web.SchedulerViewMode.Month;
			this.scheduler.AppointmentClick += new System.EventHandler<Wisej.Web.SchedulerAppointmentEventArgs>(this.scheduler_AppointmentClick);
			this.scheduler.SlotDoubleClick += new System.EventHandler<Wisej.Web.SchedulerSlotEventArgs>(this.scheduler_SlotDoubleClick);
			this.scheduler.RangeChanged += new System.EventHandler<System.EventArgs>(this.scheduler_RangeChanged);
			//
			// grid
			//
			this.grid.AllowUserToResizeRows = false;
			this.grid.AutoGenerateColumns = false;
			this.grid.BorderStyle = Wisej.Web.BorderStyle.None;
			this.grid.CellBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.Horizontal;
			dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.grid.ColumnHeadersHeight = 40;
			this.grid.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colType,
            this.colSubject,
            this.colRelated,
            this.colUser,
            this.colDate,
            this.colActions});
			this.grid.CssClass = "relay-grid";
			dataGridViewCellStyle2.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.grid.DefaultCellStyle = dataGridViewCellStyle2;
			this.grid.Dock = Wisej.Web.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(20, 20);
			this.grid.MultiSelect = false;
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersVisible = false;
			this.grid.RowTemplate.Height = 52;
			this.grid.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.grid.Size = new System.Drawing.Size(1060, 620);
			this.grid.TabIndex = 1;
			this.grid.Visible = false;
			this.grid.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.grid_CellClick);
			this.grid.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
			//
			// colType
			//
			this.colType.DataPropertyName = "TypeName";
			this.colType.HeaderText = "Type";
			this.colType.ImageMember = "TypeIcon";
			this.colType.Name = "colType";
			this.colType.Shape = Wisej.Web.AvatarShape.Rounded;
			this.colType.Size = 28;
			this.colType.Width = 120;
			//
			// colSubject
			//
			this.colSubject.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colSubject.DataPropertyName = "Subject";
			this.colSubject.HeaderText = "Subject";
			this.colSubject.MinimumWidth = 200;
			this.colSubject.Monospace = false;
			this.colSubject.Name = "colSubject";
			this.colSubject.SubtitleFont = new System.Drawing.Font("default", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.colSubject.SubtitleMember = "Details";
			//
			// colRelated
			//
			this.colRelated.DataPropertyName = "RelatedText";
			this.colRelated.HeaderText = "Related to";
			this.colRelated.Name = "colRelated";
			this.colRelated.Width = 200;
			//
			// colUser
			//
			this.colUser.AutoColor = true;
			this.colUser.DataPropertyName = "UserName";
			this.colUser.HeaderText = "User";
			this.colUser.Name = "colUser";
			this.colUser.Size = 28;
			this.colUser.Width = 150;
			//
			// colDate
			//
			this.colDate.DataPropertyName = "Date";
			dataGridViewCellStyle1.Format = "MMM d, yyyy  HH:mm";
			this.colDate.DefaultCellStyle = dataGridViewCellStyle1;
			this.colDate.HeaderText = "Date";
			this.colDate.Name = "colDate";
			this.colDate.Width = 150;
			//
			// colActions
			//
			cardAction1.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/box-arrow-up-right.svg";
			cardAction1.Name = "open";
			cardAction1.Text = "Open related record";
			cardAction2.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			cardAction2.Name = "delete";
			cardAction2.Text = "Delete";
			this.colActions.Actions.Add(cardAction1);
			this.colActions.Actions.Add(cardAction2);
			this.colActions.HeaderText = "";
			this.colActions.IconOnly = true;
			this.colActions.Name = "colActions";
			this.colActions.ShowOnHover = true;
			this.colActions.Width = 72;
			this.colActions.ActionClick += new System.EventHandler<Wisej.Web.DataGridViewVisualCellEventArgs>(this.colActions_ActionClick);
			//
			// emptyState
			//
			this.emptyState.ActionText = "Log activity";
			this.emptyState.Description = "No activities match the selected type and user.";
			this.emptyState.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyState.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.emptyState.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyState.Location = new System.Drawing.Point(20, 20);
			this.emptyState.Name = "emptyState";
			this.emptyState.Size = new System.Drawing.Size(1060, 620);
			this.emptyState.TabIndex = 2;
			this.emptyState.Title = "No activities";
			this.emptyState.Visible = false;
			this.emptyState.ActionClick += new System.EventHandler(this.buttonLog_Click);
			//
			// ActivitiesView
			//
			this.Controls.Add(this.panelCard);
			this.Controls.Add(this.panelToolbar);
			this.Controls.Add(this.panelHeader);
			this.Name = "ActivitiesView";
			this.Size = new System.Drawing.Size(1100, 760);
			this.Load += new System.EventHandler(this.ActivitiesView_Load);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.panelCard.ResumeLayout(false);
			this.panelToolbar.ResumeLayout(false);
			this.panelHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelCount;
		private Wisej.Web.Button buttonExport;
		private Wisej.Web.Button buttonLog;
		private Wisej.Web.Panel panelToolbar;
		private Wisej.Web.SegmentedButton segmentedMode;
		private Wisej.Web.ChipGroup chipGroupType;
		private Wisej.Web.ComboBox comboBoxUser;
		private Wisej.Web.Panel panelCard;
		private Wisej.Web.SchedulerView scheduler;
		private Wisej.Web.DataGridView grid;
		private Wisej.Web.DataGridViewAvatarColumn colType;
		private Wisej.Web.DataGridViewSubtitleColumn colSubject;
		private Wisej.Web.DataGridViewLinkColumn colRelated;
		private Wisej.Web.DataGridViewAvatarColumn colUser;
		private Wisej.Web.DataGridViewTextBoxColumn colDate;
		private Wisej.Web.DataGridViewActionsColumn colActions;
		private Wisej.Web.EmptyState emptyState;
	}
}
