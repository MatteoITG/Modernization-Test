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
			this.labelEmpty = new Wisej.Web.Label();
			this.listView = new Wisej.Web.ListView();
			this.columnTitle = new Wisej.Web.ColumnHeader();
			this.columnPriority = new Wisej.Web.ColumnHeader();
			this.columnDue = new Wisej.Web.ColumnHeader();
			this.columnAssignee = new Wisej.Web.ColumnHeader();
			this.columnRelated = new Wisej.Web.ColumnHeader();
			this.toolStrip = new Wisej.Web.ToolBar();
			this.buttonNew = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator1 = new Wisej.Web.ToolBarButton();
			this.buttonMine = new Wisej.Web.ToolBarButton();
			this.buttonEveryone = new Wisej.Web.ToolBarButton();
			this.toolStripSeparator2 = new Wisej.Web.ToolBarButton();
			this.buttonEdit = new Wisej.Web.ToolBarButton();
			this.buttonComplete = new Wisej.Web.ToolBarButton();
			this.buttonDelete = new Wisej.Web.ToolBarButton();
			this.labelCount = new Wisej.Web.ToolBarButton();
			this.contextMenu = new Wisej.Web.ContextMenu(this.components);
			this.menuEdit = new Wisej.Web.MenuItem();
			this.menuOpenRelated = new Wisej.Web.MenuItem();
			this.menuToggle = new Wisej.Web.MenuItem();
			this.menuSeparator1 = new Wisej.Web.MenuItem();
			this.menuDelete = new Wisej.Web.MenuItem();
			this.toolStrip.SuspendLayout();
			this.SuspendLayout();
			//
			// labelEmpty
			//
			this.labelEmpty.BackColor = System.Drawing.SystemColors.Window;
			this.labelEmpty.Dock = Wisej.Web.DockStyle.Fill;
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
			this.listView.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
			this.columnTitle,
			this.columnPriority,
			this.columnDue,
			this.columnAssignee,
			this.columnRelated});
			this.listView.CheckBoxes = true;
			this.listView.ContextMenu = this.contextMenu;
			this.listView.Dock = Wisej.Web.DockStyle.Fill;
			this.listView.Location = new System.Drawing.Point(0, 27);
			this.listView.MultiSelect = false;
			this.listView.Name = "listView";
			this.listView.ShowItemToolTips = true;
			this.listView.Size = new System.Drawing.Size(900, 533);
			this.listView.TabIndex = 1;
			this.listView.View = Wisej.Web.View.Details;
			this.listView.ItemDoubleClick += new Wisej.Web.ItemClickEventHandler(this.listView_ItemActivate);
			this.listView.ItemChecked += new Wisej.Web.ItemCheckedEventHandler(this.listView_ItemChecked);
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
			this.toolStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonNew,
			this.toolStripSeparator1,
			this.buttonMine,
			this.buttonEveryone,
			this.toolStripSeparator2,
			this.buttonEdit,
			this.buttonComplete,
			this.buttonDelete,
			this.labelCount});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Padding = new Wisej.Web.Padding(4, 2, 4, 2);
			this.toolStrip.Size = new System.Drawing.Size(800, 27);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
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
			this.toolStripSeparator1.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// buttonMine
			//
			this.buttonMine.Pushed = true;
			this.buttonMine.Name = "buttonMine";
			this.buttonMine.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.buttonMine.Text = "My tasks";
			this.buttonMine.Click += new System.EventHandler(this.buttonScope_Click);
			//
			// buttonEveryone
			//
			this.buttonEveryone.Name = "buttonEveryone";
			this.buttonEveryone.Style = Wisej.Web.ToolBarButtonStyle.ToggleButton;
			this.buttonEveryone.Text = "Everyone";
			this.buttonEveryone.Click += new System.EventHandler(this.buttonScope_Click);
			//
			// toolStripSeparator2
			//
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Style = Wisej.Web.ToolBarButtonStyle.Separator;
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
			this.labelCount.Name = "labelCount";
			this.labelCount.Text = "0 open";
			//
			// contextMenu
			//
			this.contextMenu.MenuItems.AddRange(new Wisej.Web.MenuItem[] {
			this.menuEdit,
			this.menuOpenRelated,
			this.menuToggle,
			this.menuSeparator1,
			this.menuDelete});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Popup += new System.EventHandler(this.contextMenu_Opening);
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
			this.menuSeparator1.Text = "-";
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
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.labelEmpty);
			this.Controls.Add(this.listView);
			this.Controls.Add(this.toolStrip);
			this.Name = "TasksView";
			this.Size = new System.Drawing.Size(900, 560);
			this.Load += new System.EventHandler(this.TasksView_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelEmpty;
		private Wisej.Web.ListView listView;
		private Wisej.Web.ColumnHeader columnTitle;
		private Wisej.Web.ColumnHeader columnPriority;
		private Wisej.Web.ColumnHeader columnDue;
		private Wisej.Web.ColumnHeader columnAssignee;
		private Wisej.Web.ColumnHeader columnRelated;
		private Wisej.Web.ToolBar toolStrip;
		private Wisej.Web.ToolBarButton buttonNew;
		private Wisej.Web.ToolBarButton toolStripSeparator1;
		private Wisej.Web.ToolBarButton buttonMine;
		private Wisej.Web.ToolBarButton buttonEveryone;
		private Wisej.Web.ToolBarButton toolStripSeparator2;
		private Wisej.Web.ToolBarButton buttonEdit;
		private Wisej.Web.ToolBarButton buttonComplete;
		private Wisej.Web.ToolBarButton buttonDelete;
		private Wisej.Web.ToolBarButton labelCount;
		private Wisej.Web.ContextMenu contextMenu;
		private Wisej.Web.MenuItem menuEdit;
		private Wisej.Web.MenuItem menuOpenRelated;
		private Wisej.Web.MenuItem menuToggle;
		private Wisej.Web.MenuItem menuSeparator1;
		private Wisej.Web.MenuItem menuDelete;
	}
}
