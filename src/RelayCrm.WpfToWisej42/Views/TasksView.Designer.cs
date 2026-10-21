namespace RelayCrm.Views
{
	partial class TasksView
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksView));
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelCount = new Wisej.Web.Label();
			this.buttonNew = new Wisej.Web.Button();
			this.segmentedScope = new Wisej.Web.SegmentedButton();
			this.panelGroups = new Wisej.Web.Panel();
			this.emptyState = new Wisej.Web.EmptyState();
			this.panelHeader.SuspendLayout();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.labelCount);
			this.panelHeader.Controls.Add(this.buttonNew);
			this.panelHeader.Controls.Add(this.segmentedScope);
			this.panelHeader.CssClass = "relay-toolbar";
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelHeader.ResponsiveProfiles"))));
			this.panelHeader.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("panelHeader.ResponsiveProfiles1"))));
			this.panelHeader.Padding = new Wisej.Web.Padding(12, 8, 12, 8);
			this.panelHeader.Size = new System.Drawing.Size(900, 56);
			this.panelHeader.TabIndex = 0;
			//
			// labelCount
			//
			this.labelCount.AutoEllipsis = true;
			this.labelCount.CssClass = "relay-muted";
			this.labelCount.Dock = Wisej.Web.DockStyle.Fill;
			this.labelCount.Location = new System.Drawing.Point(132, 8);
			this.labelCount.Name = "labelCount";
			this.labelCount.Padding = new Wisej.Web.Padding(12, 0, 0, 0);
			this.labelCount.Size = new System.Drawing.Size(486, 40);
			this.labelCount.TabIndex = 1;
			this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonNew
			//
			this.buttonNew.CssClass = "relay-primary";
			this.buttonNew.Dock = Wisej.Web.DockStyle.Left;
			this.buttonNew.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus.svg";
			this.buttonNew.Location = new System.Drawing.Point(12, 8);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(120, 40);
			this.buttonNew.TabIndex = 0;
			this.buttonNew.Text = "New task...";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// segmentedScope
			//
			this.segmentedScope.Dock = Wisej.Web.DockStyle.Right;
			segment1.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/person.svg";
			segment1.Text = "My tasks";
			segment2.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/people.svg";
			segment2.Text = "Everybody\'s";
			this.segmentedScope.Items.Add(segment1);
			this.segmentedScope.Items.Add(segment2);
			this.segmentedScope.Location = new System.Drawing.Point(618, 8);
			this.segmentedScope.Name = "segmentedScope";
			this.segmentedScope.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("segmentedScope.ResponsiveProfiles"))));
			this.segmentedScope.ResponsiveProfiles.Add(((Wisej.Base.ResponsiveProfile)(resources.GetObject("segmentedScope.ResponsiveProfiles1"))));
			this.segmentedScope.SelectedIndex = 0;
			this.segmentedScope.Size = new System.Drawing.Size(270, 40);
			this.segmentedScope.TabIndex = 2;
			this.segmentedScope.SelectedIndexChanged += new System.EventHandler(this.segmentedScope_SelectedIndexChanged);
			//
			// panelGroups
			//
			this.panelGroups.AutoScroll = true;
			this.panelGroups.Dock = Wisej.Web.DockStyle.Fill;
			this.panelGroups.Location = new System.Drawing.Point(0, 56);
			this.panelGroups.Name = "panelGroups";
			this.panelGroups.Padding = new Wisej.Web.Padding(12);
			this.panelGroups.Size = new System.Drawing.Size(900, 544);
			this.panelGroups.TabIndex = 1;
			this.panelGroups.TabStop = true;
			//
			// emptyState
			//
			this.emptyState.ActionText = "New task...";
			this.emptyState.Description = "You\'re all caught up. Add a task to plan your next step.";
			this.emptyState.Dock = Wisej.Web.DockStyle.Fill;
			this.emptyState.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
			this.emptyState.Location = new System.Drawing.Point(0, 56);
			this.emptyState.Name = "emptyState";
			this.emptyState.Size = new System.Drawing.Size(900, 544);
			this.emptyState.TabIndex = 2;
			this.emptyState.Title = "No tasks";
			this.emptyState.Visible = false;
			this.emptyState.ActionClick += new System.EventHandler(this.buttonNew_Click);
			//
			// TasksView
			//
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.emptyState);
			this.Controls.Add(this.panelGroups);
			this.Controls.Add(this.panelHeader);
			this.CssClass = "relay-card";
			this.Name = "TasksView";
			this.Size = new System.Drawing.Size(900, 600);
			this.panelHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelCount;
		private Wisej.Web.Button buttonNew;
		private Wisej.Web.SegmentedButton segmentedScope;
		private Wisej.Web.Panel panelGroups;
		private Wisej.Web.EmptyState emptyState;
	}
}
