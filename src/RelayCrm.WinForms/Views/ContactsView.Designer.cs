namespace RelayCrm.Views
{
	partial class ContactsView
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
			this.linkEmpty = new System.Windows.Forms.LinkLabel();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colLastContacted = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.filterStrip = new System.Windows.Forms.ToolStrip();
			this.labelSearch = new System.Windows.Forms.ToolStripLabel();
			this.textSearch = new System.Windows.Forms.ToolStripTextBox();
			this.filterSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.quickAll = new System.Windows.Forms.ToolStripButton();
			this.quickLeads = new System.Windows.Forms.ToolStripButton();
			this.quickProspects = new System.Windows.Forms.ToolStripButton();
			this.quickCustomers = new System.Windows.Forms.ToolStripButton();
			this.quickMine = new System.Windows.Forms.ToolStripButton();
			this.filterSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.labelAdvanced = new System.Windows.Forms.ToolStripLabel();
			this.buttonClearFilter = new System.Windows.Forms.ToolStripButton();
			this.toolStrip = new System.Windows.Forms.ToolStrip();
			this.buttonNew = new System.Windows.Forms.ToolStripButton();
			this.buttonEdit = new System.Windows.Forms.ToolStripButton();
			this.buttonDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonLogCall = new System.Windows.Forms.ToolStripButton();
			this.buttonLogEmail = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.buttonFilter = new System.Windows.Forms.ToolStripButton();
			this.dropDownColumns = new System.Windows.Forms.ToolStripDropDownButton();
			this.buttonExport = new System.Windows.Forms.ToolStripButton();
			this.labelCount = new System.Windows.Forms.ToolStripLabel();
			this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuLogCall = new System.Windows.Forms.ToolStripMenuItem();
			this.menuLogEmail = new System.Windows.Forms.ToolStripMenuItem();
			this.menuSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
			this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.filterStrip.SuspendLayout();
			this.toolStrip.SuspendLayout();
			this.contextMenu.SuspendLayout();
			this.SuspendLayout();
			//
			// linkEmpty
			//
			this.linkEmpty.BackColor = System.Drawing.SystemColors.Window;
			this.linkEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
			this.linkEmpty.LinkArea = new System.Windows.Forms.LinkArea(0, 0);
			this.linkEmpty.Location = new System.Drawing.Point(0, 54);
			this.linkEmpty.Name = "linkEmpty";
			this.linkEmpty.Size = new System.Drawing.Size(900, 500);
			this.linkEmpty.TabIndex = 3;
			this.linkEmpty.TabStop = true;
			this.linkEmpty.Text = "No contacts match the search and the filters. Clear the filters";
			this.linkEmpty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.linkEmpty.Visible = false;
			this.linkEmpty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEmpty_LinkClicked);
			//
			// dataGridView
			//
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.colName,
			this.colTitle,
			this.colCompany,
			this.colEmail,
			this.colPhone,
			this.colStage,
			this.colOwner,
			this.colLastContacted});
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 54);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowHeadersVisible = false;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(1000, 546);
			this.dataGridView.TabIndex = 2;
			this.dataGridView.ContextMenuStrip = this.contextMenu;
			this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
			this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
			this.dataGridView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDown);
			this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
			this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
			//
			// colName
			//
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.colName.DataPropertyName = "FullName";
			this.colName.DefaultCellStyle = dataGridViewCellStyle1;
			this.colName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.MinimumWidth = 150;
			this.colName.HeaderText = "Name";
			this.colName.Name = "colName";
			//
			// colTitle
			//
			this.colTitle.DataPropertyName = "Title";
			this.colTitle.HeaderText = "Job title";
			this.colTitle.Name = "colTitle";
			this.colTitle.Width = 150;
			//
			// colCompany
			//
			this.colCompany.DataPropertyName = "Company";
			this.colCompany.HeaderText = "Company";
			this.colCompany.Name = "colCompany";
			this.colCompany.Width = 170;
			//
			// colEmail
			//
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.HeaderText = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.Width = 210;
			//
			// colPhone
			//
			this.colPhone.DataPropertyName = "Phone";
			this.colPhone.HeaderText = "Phone";
			this.colPhone.Name = "colPhone";
			this.colPhone.Width = 120;
			//
			// colStage
			//
			this.colStage.DataPropertyName = "Stage";
			this.colStage.HeaderText = "Stage";
			this.colStage.Name = "colStage";
			this.colStage.Width = 80;
			//
			// colOwner
			//
			this.colOwner.DataPropertyName = "Owner";
			this.colOwner.HeaderText = "Owner";
			this.colOwner.Name = "colOwner";
			this.colOwner.Width = 120;
			//
			// colLastContacted
			//
			this.colLastContacted.DataPropertyName = "LastContactedText";
			this.colLastContacted.HeaderText = "Last contacted";
			this.colLastContacted.Name = "colLastContacted";
			this.colLastContacted.Width = 110;
			//
			// filterStrip
			//
			this.filterStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.labelSearch,
			this.textSearch,
			this.filterSeparator1,
			this.quickAll,
			this.quickLeads,
			this.quickProspects,
			this.quickCustomers,
			this.quickMine,
			this.filterSeparator2,
			this.labelAdvanced,
			this.buttonClearFilter});
			this.filterStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.filterStrip.Location = new System.Drawing.Point(0, 27);
			this.filterStrip.Name = "filterStrip";
			this.filterStrip.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.filterStrip.Size = new System.Drawing.Size(800, 27);
			this.filterStrip.TabIndex = 1;
			//
			// labelSearch
			//
			this.labelSearch.Name = "labelSearch";
			this.labelSearch.Text = "Search:";
			//
			// textSearch
			//
			this.textSearch.AutoSize = false;
			this.textSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textSearch.Size = new System.Drawing.Size(240, 23);
			this.textSearch.Name = "textSearch";
			this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
			//
			// filterSeparator1
			//
			this.filterSeparator1.Name = "filterSeparator1";
			//
			// quickAll
			//
			this.quickAll.Name = "quickAll";
			this.quickAll.Text = "All";
			this.quickAll.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickLeads
			//
			this.quickLeads.Name = "quickLeads";
			this.quickLeads.Text = "Leads";
			this.quickLeads.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickProspects
			//
			this.quickProspects.Name = "quickProspects";
			this.quickProspects.Text = "Prospects";
			this.quickProspects.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickCustomers
			//
			this.quickCustomers.Name = "quickCustomers";
			this.quickCustomers.Text = "Customers";
			this.quickCustomers.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// quickMine
			//
			this.quickMine.Name = "quickMine";
			this.quickMine.Text = "My contacts";
			this.quickMine.Click += new System.EventHandler(this.quickFilter_Click);
			//
			// filterSeparator2
			//
			this.filterSeparator2.Name = "filterSeparator2";
			//
			// labelAdvanced
			//
			this.labelAdvanced.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labelAdvanced.Name = "labelAdvanced";
			this.labelAdvanced.Text = "";
			//
			// buttonClearFilter
			//
			this.buttonClearFilter.Visible = false;
			this.buttonClearFilter.Name = "buttonClearFilter";
			this.buttonClearFilter.Text = "Clear filters";
			this.buttonClearFilter.Click += new System.EventHandler(this.buttonClearFilter_Click);
			//
			// toolStrip
			//
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.buttonNew,
			this.buttonEdit,
			this.buttonDelete,
			this.toolStripSeparator1,
			this.buttonLogCall,
			this.buttonLogEmail,
			this.toolStripSeparator2,
			this.buttonFilter,
			this.dropDownColumns,
			this.buttonExport,
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
			this.buttonNew.Text = "New contact...";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// buttonEdit
			//
			this.buttonEdit.Tag = "pencil";
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Text = "Edit...";
			this.buttonEdit.Click += new System.EventHandler(this.menuEdit_Click);
			//
			// buttonDelete
			//
			this.buttonDelete.Tag = "trash";
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// toolStripSeparator1
			//
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			//
			// buttonLogCall
			//
			this.buttonLogCall.Tag = "telephone";
			this.buttonLogCall.Name = "buttonLogCall";
			this.buttonLogCall.Text = "Log call...";
			this.buttonLogCall.Click += new System.EventHandler(this.menuLogCall_Click);
			//
			// buttonLogEmail
			//
			this.buttonLogEmail.Tag = "envelope";
			this.buttonLogEmail.Name = "buttonLogEmail";
			this.buttonLogEmail.Text = "Log email...";
			this.buttonLogEmail.Click += new System.EventHandler(this.menuLogEmail_Click);
			//
			// toolStripSeparator2
			//
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			//
			// buttonFilter
			//
			this.buttonFilter.Tag = "funnel";
			this.buttonFilter.Name = "buttonFilter";
			this.buttonFilter.Text = "Filter...";
			this.buttonFilter.ToolTipText = "Advanced filter";
			this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
			//
			// dropDownColumns
			//
			this.dropDownColumns.Tag = "layout-three-columns";
			this.dropDownColumns.Name = "dropDownColumns";
			this.dropDownColumns.Text = "Columns";
			this.dropDownColumns.DropDownOpening += new System.EventHandler(this.dropDownColumns_DropDownOpening);
			//
			// buttonExport
			//
			this.buttonExport.Tag = "download";
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Text = "Export CSV...";
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			//
			// labelCount
			//
			this.labelCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.labelCount.Name = "labelCount";
			this.labelCount.Text = "0 contacts";
			//
			// contextMenu
			//
			this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.menuOpen,
			this.menuSeparator1,
			this.menuLogCall,
			this.menuLogEmail,
			this.menuSeparator2,
			this.menuEdit,
			this.menuDelete});
			this.contextMenu.Name = "contextMenu";
			this.contextMenu.Size = new System.Drawing.Size(181, 120);
			this.contextMenu.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenu_Opening);
			//
			// menuOpen
			//
			this.menuOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.menuOpen.Name = "menuOpen";
			this.menuOpen.Text = "&Open";
			this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
			//
			// menuSeparator1
			//
			this.menuSeparator1.Name = "menuSeparator1";
			//
			// menuLogCall
			//
			this.menuLogCall.Name = "menuLogCall";
			this.menuLogCall.Text = "Log &call...";
			this.menuLogCall.Click += new System.EventHandler(this.menuLogCall_Click);
			//
			// menuLogEmail
			//
			this.menuLogEmail.Name = "menuLogEmail";
			this.menuLogEmail.Text = "Log &email...";
			this.menuLogEmail.Click += new System.EventHandler(this.menuLogEmail_Click);
			//
			// menuSeparator2
			//
			this.menuSeparator2.Name = "menuSeparator2";
			//
			// menuEdit
			//
			this.menuEdit.Name = "menuEdit";
			this.menuEdit.Text = "E&dit...";
			this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
			//
			// menuDelete
			//
			this.menuDelete.Name = "menuDelete";
			this.menuDelete.Text = "De&lete";
			this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
			//
			// ContactsView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.linkEmpty);
			this.Controls.Add(this.dataGridView);
			this.Controls.Add(this.filterStrip);
			this.Controls.Add(this.toolStrip);
			this.Name = "ContactsView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.Load += new System.EventHandler(this.ContactsView_Load);
			this.contextMenu.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.filterStrip.ResumeLayout(false);
			this.filterStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.LinkLabel linkEmpty;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn colName;
		private System.Windows.Forms.DataGridViewTextBoxColumn colTitle;
		private System.Windows.Forms.DataGridViewTextBoxColumn colCompany;
		private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
		private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn colStage;
		private System.Windows.Forms.DataGridViewTextBoxColumn colOwner;
		private System.Windows.Forms.DataGridViewTextBoxColumn colLastContacted;
		private System.Windows.Forms.ToolStrip filterStrip;
		private System.Windows.Forms.ToolStripLabel labelSearch;
		private System.Windows.Forms.ToolStripTextBox textSearch;
		private System.Windows.Forms.ToolStripSeparator filterSeparator1;
		private System.Windows.Forms.ToolStripButton quickAll;
		private System.Windows.Forms.ToolStripButton quickLeads;
		private System.Windows.Forms.ToolStripButton quickProspects;
		private System.Windows.Forms.ToolStripButton quickCustomers;
		private System.Windows.Forms.ToolStripButton quickMine;
		private System.Windows.Forms.ToolStripSeparator filterSeparator2;
		private System.Windows.Forms.ToolStripLabel labelAdvanced;
		private System.Windows.Forms.ToolStripButton buttonClearFilter;
		private System.Windows.Forms.ToolStrip toolStrip;
		private System.Windows.Forms.ToolStripButton buttonNew;
		private System.Windows.Forms.ToolStripButton buttonEdit;
		private System.Windows.Forms.ToolStripButton buttonDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton buttonLogCall;
		private System.Windows.Forms.ToolStripButton buttonLogEmail;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton buttonFilter;
		private System.Windows.Forms.ToolStripDropDownButton dropDownColumns;
		private System.Windows.Forms.ToolStripButton buttonExport;
		private System.Windows.Forms.ToolStripLabel labelCount;
		private System.Windows.Forms.ContextMenuStrip contextMenu;
		private System.Windows.Forms.ToolStripMenuItem menuOpen;
		private System.Windows.Forms.ToolStripSeparator menuSeparator1;
		private System.Windows.Forms.ToolStripMenuItem menuLogCall;
		private System.Windows.Forms.ToolStripMenuItem menuLogEmail;
		private System.Windows.Forms.ToolStripSeparator menuSeparator2;
		private System.Windows.Forms.ToolStripMenuItem menuEdit;
		private System.Windows.Forms.ToolStripMenuItem menuDelete;
	}
}
