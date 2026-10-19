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
			this.labelQuery = new Wisej.Web.Label();
			this.textBoxQuery = new Wisej.Web.TextBox();
			this.listViewResults = new Wisej.Web.ListView();
			this.columnText = new Wisej.Web.ColumnHeader();
			this.columnDescription = new Wisej.Web.ColumnHeader();
			this.labelHint = new Wisej.Web.Label();
			this.buttonOpen = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.timerSearch = new Wisej.Web.Timer(this.components);
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
			this.textBoxQuery.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
			| Wisej.Web.AnchorStyles.Right)));
			this.textBoxQuery.Location = new System.Drawing.Point(66, 12);
			this.textBoxQuery.Name = "textBoxQuery";
			this.textBoxQuery.Watermark = "Pages, contacts, companies and deals";
			this.textBoxQuery.Size = new System.Drawing.Size(502, 23);
			this.textBoxQuery.TabIndex = 1;
			this.textBoxQuery.TextChanged += new System.EventHandler(this.textBoxQuery_TextChanged);
			this.textBoxQuery.KeyDown += new Wisej.Web.KeyEventHandler(this.textBoxQuery_KeyDown);
			//
			// listViewResults
			//
			this.listViewResults.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
			| Wisej.Web.AnchorStyles.Left)
			| Wisej.Web.AnchorStyles.Right)));
			this.listViewResults.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
			this.columnText,
			this.columnDescription});
			this.listViewResults.HeaderStyle = Wisej.Web.ColumnHeaderStyle.None;
			this.listViewResults.Location = new System.Drawing.Point(12, 44);
			this.listViewResults.MultiSelect = false;
			this.listViewResults.Name = "listViewResults";
			this.listViewResults.Size = new System.Drawing.Size(556, 300);
			this.listViewResults.TabIndex = 2;
			this.listViewResults.View = Wisej.Web.View.Details;
			this.listViewResults.ItemDoubleClick += new Wisej.Web.ItemClickEventHandler(this.listViewResults_ItemActivate);
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
			this.labelHint.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)
			| Wisej.Web.AnchorStyles.Right)));
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
			this.buttonOpen.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonOpen.Location = new System.Drawing.Point(376, 354);
			this.buttonOpen.Name = "buttonOpen";
			this.buttonOpen.Size = new System.Drawing.Size(92, 27);
			this.buttonOpen.TabIndex = 4;
			this.buttonOpen.Text = "Open";
			this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(476, 354);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 5;
			this.buttonCancel.Text = "Cancel";
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
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
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
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Search";
			this.Load += new System.EventHandler(this.SearchDialog_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelQuery;
		private Wisej.Web.TextBox textBoxQuery;
		private Wisej.Web.ListView listViewResults;
		private Wisej.Web.ColumnHeader columnText;
		private Wisej.Web.ColumnHeader columnDescription;
		private Wisej.Web.Label labelHint;
		private Wisej.Web.Button buttonOpen;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Timer timerSearch;
	}
}
