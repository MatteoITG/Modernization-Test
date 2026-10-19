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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Overdue", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Today", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("This week", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Later", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("Done", System.Windows.Forms.HorizontalAlignment.Left);
			this.labelEmpty = new System.Windows.Forms.Label();
			this.listView = new System.Windows.Forms.ListView();
			this.columnTitle = new System.Windows.Forms.ColumnHeader();
			this.columnPriority = new System.Windows.Forms.ColumnHeader();
			this.columnDue = new System.Windows.Forms.ColumnHeader();
			this.columnAssignee = new System.Windows.Forms.ColumnHeader();
			this.columnRelated = new System.Windows.Forms.ColumnHeader();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.buttonNew = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonMine = new System.Windows.Forms.ToolStripButton();
			this.buttonEveryone = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonEdit = new System.Windows.Forms.ToolStripButton();
			this.buttonComplete = new System.Windows.Forms.ToolStripButton();
			this.buttonDelete = new System.Windows.Forms.ToolStripButton();
			this.labelCount = new System.Windows.Forms.ToolStripLabel();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuOpenRelated = new System.Windows.Forms.ToolStripMenuItem();
			this.menuToggle = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip.SuspendLayout();
			this.contextMenu.SuspendLayout();
			this.SuspendLayout();
			//
			// labelEmpty
			//
			this.labelEmpty.BackColor = System.Drawing.SystemColors.Window;
			this.labelEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelEmpty.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelEmpty.Location = new System.Drawing.Point(0, 27);
			this.labelEmpty.Name = "labelEmpty";
			this.labelEmpty.Size = new System.Drawing.Size(900, 533);
			this.labelEmpty.TabIndex = 2;
			this.labelEmpty.Text = "No tasks here. Create one with New task.";
			this.labelEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelEmpty.Visible = false;
			//
			// listView
			//
			listViewGroup1.Header = "Overdue";
			listViewGroup1.Name = "groupOverdue";
			listViewGroup2.Header = "Today";
			listViewGroup2.Name = "groupToday";
			listViewGroup3.Header = "This week";
			listViewGroup3.Name = "groupWeek";
			listViewGroup4.Header = "Later";
			listViewGroup4.Name = "groupLater";
			listViewGroup5.Header = "Done";
			listViewGroup5.Name = "groupDone";
			this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
			listViewGroup1,
			listViewGroup2,
			listViewGroup3,
			listViewGroup4,
			listViewGroup5});
			this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnTitle,
			this.columnPriority,
			this.columnDue,
			this.columnAssignee,
			this.columnRelated});
			this.listView.CheckBoxes = true;
			this.listView.ContextMenuStrip = this.contextMenu;
			this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView.FullRowSelect = true;
			this.listView.HideSelection = false;
			this.listView.Location = new System.Drawing.Point(0, 27);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.ShowItemToolTips = true;
			this.listView.Size = new System.Drawing.Size(900, 533);
			this.listView.TabIndex = 1;
			this.listView.UseCompatibleStateImageBehavior = false;
			this.listView.View = System.Windows.Forms.View.Details;
			this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
			this.listView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView_ItemChecked);
			this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
			//
			// columnTitle
			//
			this.columnTitle.Text = "Task";
			this.columnTitle.Width = 330;
			//
			// columnPriority
			//
			this.columnPriority.Text = "Priority";
			this.columnPriority.Width = 70;
			//
			// columnDue
			//
			this.columnDue.Text = "Due";
			this.columnDue.Width = 110;
			//
			// columnAssignee
			//
			this.columnAssignee.Text = "Assignee";
			this.columnAssignee.Width = 130;
			//
			// columnRelated
			//
			this.columnRelated.Text = "Related to";
			this.columnRelated.Width = 300;
			//
			// toolStrip
			//
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonNew,
			this.toolStripSeparator1,
			this.buttonMine,
			this.buttonEveryone,
			this.toolStripSeparator2,
			this.buttonEdit,
			this.buttonComplete,
			this.buttonDelete,
			this.labelCount});
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(800, 27);
			this.toolStrip.TabIndex = 0;
			//
			// buttonNew
			//
			this.buttonNew.Tag = "plus";
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Text = "New task...";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			//
			// buttonMine
			//
			this.buttonMine.Checked = true;
			this.buttonMine.CheckState = System.Windows.Forms.CheckState.Checked;
			this.buttonMine.Name = "buttonMine";
			this.buttonMine.Text = "My tasks";
			this.buttonMine.Click += new System.EventHandler(this.buttonScope_Click);
			//
			// buttonEveryone
			//
			this.buttonEveryone.Name = "buttonEveryone";
			this.buttonEveryone.Text = "Everyone";
			this.buttonEveryone.Click += new System.EventHandler(this.buttonScope_Click);
			//
			// toolStripSeparator2
			//
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			//
			// buttonEdit
			//
			this.buttonEdit.Enabled = false;
			this.buttonEdit.Tag = "pencil";
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Text = "Edit...";
			this.buttonEdit.Click += new System.EventHandler(this.menuEdit_Click);
			//
			// buttonComplete
			//
			this.buttonComplete.Enabled = false;
			this.buttonComplete.Tag = "check-lg";
			this.buttonComplete.Name = "buttonComplete";
			this.buttonComplete.Text = "Mark done";
			this.buttonComplete.Click += new System.EventHandler(this.menuToggle_Click);
			//
			// buttonDelete
			//
			this.buttonDelete.Enabled = false;
			this.buttonDelete.Tag = "trash";
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// labelCount
			//
			this.labelCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.labelCount.Name = "labelCount";
			this.labelCount.Text = "0 open";
			//
			// contextMenu
			//
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuEdit,
			this.menuOpenRelated,
			this.menuToggle,
			this.menuSeparator1,
			this.menuDelete});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(181, 98);
			this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
			//
			// menuEdit
			//
			this.menuEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Text = "&Edit...";
			this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
			//
			// menuOpenRelated
			//
			this.menuOpenRelated.Name = "menuOpenRelated";
			this.menuOpenRelated.Text = "&Open related record";
			this.menuOpenRelated.Click += new System.EventHandler(this.menuOpenRelated_Click);
			//
			// menuToggle
			//
			this.menuToggle.Name = "menuToggle";
			this.menuToggle.Text = "&Mark done";
			this.menuToggle.Click += new System.EventHandler(this.menuToggle_Click);
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
			// TasksView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelEmpty);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.toolStrip);
			this.Name = "TasksView";
			this.Size = new System.Drawing.Size(900, 560);
			this.Load += new System.EventHandler(this.TasksView_Load);
			this.contextMenu.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelEmpty;
		private System.Windows.Forms.ListView listView;
		private System.Windows.Forms.ColumnHeader columnTitle;
		private System.Windows.Forms.ColumnHeader columnPriority;
		private System.Windows.Forms.ColumnHeader columnDue;
		private System.Windows.Forms.ColumnHeader columnAssignee;
		private System.Windows.Forms.ColumnHeader columnRelated;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton buttonNew;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton buttonMine;
		private System.Windows.Forms.ToolStripButton buttonEveryone;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton buttonEdit;
		private System.Windows.Forms.ToolStripButton buttonComplete;
		private System.Windows.Forms.ToolStripButton buttonDelete;
		private System.Windows.Forms.ToolStripLabel labelCount;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem menuEdit;
		private System.Windows.Forms.ToolStripMenuItem menuOpenRelated;
		private System.Windows.Forms.ToolStripMenuItem menuToggle;
		private System.Windows.Forms.ToolStripSeparator menuSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuDelete;
	}
}
