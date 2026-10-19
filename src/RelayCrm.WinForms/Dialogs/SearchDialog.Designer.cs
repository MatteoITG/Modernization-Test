namespace RelayCrm.Dialogs
{
	partial class SearchDialog
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Pages", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Contacts", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("Companies", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("Deals", System.Windows.Forms.HorizontalAlignment.Left);
			this.labelQuery = new System.Windows.Forms.Label();
			this.textBoxQuery = new System.Windows.Forms.TextBox();
			this.listViewResults = new System.Windows.Forms.ListView();
			this.columnText = new System.Windows.Forms.ColumnHeader();
			this.columnDescription = new System.Windows.Forms.ColumnHeader();
			this.labelHint = new System.Windows.Forms.Label();
			this.buttonOpen = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.timerSearch = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			//
			// labelQuery
			//
			this.labelQuery.AutoSize = true;
			this.labelQuery.Location = new System.Drawing.Point(12, 15);
			this.labelQuery.Name = "labelQuery";
			this.labelQuery.Size = new System.Drawing.Size(45, 15);
			this.labelQuery.TabIndex = 0;
			this.labelQuery.Text = "&Search:";
			//
			// textBoxQuery
			//
			this.textBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxQuery.Location = new System.Drawing.Point(66, 12);
			this.textBoxQuery.Name = "textBoxQuery";
			this.textBoxQuery.PlaceholderText = "Pages, contacts, companies and deals";
			this.textBoxQuery.Size = new System.Drawing.Size(502, 23);
			this.textBoxQuery.TabIndex = 1;
			this.textBoxQuery.TextChanged += new System.EventHandler(this.textBoxQuery_TextChanged);
			this.textBoxQuery.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxQuery_KeyDown);
			//
			// listViewResults
			//
			this.listViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.columnText,
			this.columnDescription});
			this.listViewResults.FullRowSelect = true;
			listViewGroup1.Header = "Pages";
			listViewGroup1.Name = "groupPages";
			listViewGroup2.Header = "Contacts";
			listViewGroup2.Name = "groupContacts";
			listViewGroup3.Header = "Companies";
			listViewGroup3.Name = "groupCompanies";
			listViewGroup4.Header = "Deals";
			listViewGroup4.Name = "groupDeals";
			this.listViewResults.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
			listViewGroup1,
			listViewGroup2,
			listViewGroup3,
			listViewGroup4});
			this.listViewResults.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewResults.HideSelection = false;
			this.listViewResults.Location = new System.Drawing.Point(12, 44);
			this.listViewResults.MultiSelect = false;
			this.listViewResults.Name = "listViewResults";
			this.listViewResults.Size = new System.Drawing.Size(556, 300);
			this.listViewResults.TabIndex = 2;
			this.listViewResults.UseCompatibleStateImageBehavior = false;
			this.listViewResults.View = System.Windows.Forms.View.Details;
			this.listViewResults.ItemActivate += new System.EventHandler(this.listViewResults_ItemActivate);
			this.listViewResults.SelectedIndexChanged += new System.EventHandler(this.listViewResults_SelectedIndexChanged);
			//
			// columnText
			//
			this.columnText.Text = "Name";
			this.columnText.Width = 200;
			//
			// columnDescription
			//
			this.columnDescription.Text = "Description";
			this.columnDescription.Width = 330;
			//
			// labelHint
			//
			this.labelHint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.labelHint.AutoEllipsis = true;
			this.labelHint.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelHint.Location = new System.Drawing.Point(12, 358);
			this.labelHint.Name = "labelHint";
			this.labelHint.Size = new System.Drawing.Size(352, 18);
			this.labelHint.TabIndex = 3;
			this.labelHint.Text = "Enter opens the selected result.";
			//
			// buttonOpen
			//
			this.buttonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOpen.Location = new System.Drawing.Point(376, 354);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(92, 27);
			this.buttonOpen.TabIndex = 4;
			this.buttonOpen.Text = "Open";
			this.buttonOpen.UseVisualStyleBackColor = true;
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(476, 354);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			//
			// timerSearch
			//
			this.timerSearch.Interval = 250;
			this.timerSearch.Tick += new System.EventHandler(this.timerSearch_Tick);
			//
			// SearchDialog
			//
			this.AcceptButton = this.buttonOpen;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(580, 393);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOpen);
			this.Controls.Add(this.labelHint);
			this.Controls.Add(this.listViewResults);
			this.Controls.Add(this.textBoxQuery);
			this.Controls.Add(this.labelQuery);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(420, 300);
			this.Name = "SearchDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Search";
			this.Load += new System.EventHandler(this.SearchDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelQuery;
		private System.Windows.Forms.TextBox textBoxQuery;
		private System.Windows.Forms.ListView listViewResults;
		private System.Windows.Forms.ColumnHeader columnText;
		private System.Windows.Forms.ColumnHeader columnDescription;
		private System.Windows.Forms.Label labelHint;
		private System.Windows.Forms.Button buttonOpen;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Timer timerSearch;
	}
}
