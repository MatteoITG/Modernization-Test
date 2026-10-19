namespace RelayCrm.Dialogs
{
	partial class FilterDialog
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
			this.queryBuilder = new Wisej.Web.QueryBuilder();
			this.panelButtons = new Wisej.Web.Panel();
			this.buttonClear = new Wisej.Web.Button();
			this.buttonOk = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.labelHint = new Wisej.Web.Label();
			this.panelButtons.SuspendLayout();
			this.SuspendLayout();
			//
			// queryBuilder
			//
			this.queryBuilder.Dock = Wisej.Web.DockStyle.Fill;
			this.queryBuilder.Location = new System.Drawing.Point(16, 44);
			this.queryBuilder.MaxDepth = 0;
			this.queryBuilder.Name = "queryBuilder";
			this.queryBuilder.ShowPreview = true;
			this.queryBuilder.Size = new System.Drawing.Size(608, 288);
			this.queryBuilder.TabIndex = 1;
			//
			// panelButtons
			//
			this.panelButtons.Controls.Add(this.buttonClear);
			this.panelButtons.Controls.Add(this.buttonOk);
			this.panelButtons.Controls.Add(this.buttonCancel);
			this.panelButtons.Dock = Wisej.Web.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(16, 332);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Padding = new Wisej.Web.Padding(0, 12, 0, 0);
			this.panelButtons.Size = new System.Drawing.Size(608, 48);
			this.panelButtons.TabIndex = 2;
			//
			// buttonClear
			//
			this.buttonClear.CssClass = "relay-secondary";
			this.buttonClear.Dock = Wisej.Web.DockStyle.Left;
			this.buttonClear.Location = new System.Drawing.Point(0, 12);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(100, 36);
			this.buttonClear.TabIndex = 0;
			this.buttonClear.Text = "Clear all";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			//
			// buttonOk
			//
			this.buttonOk.CssClass = "relay-primary";
			this.buttonOk.DialogResult = Wisej.Web.DialogResult.OK;
			this.buttonOk.Dock = Wisej.Web.DockStyle.Right;
			this.buttonOk.Location = new System.Drawing.Point(408, 12);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(100, 36);
			this.buttonOk.TabIndex = 1;
			this.buttonOk.Text = "Apply";
			//
			// buttonCancel
			//
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Dock = Wisej.Web.DockStyle.Right;
			this.buttonCancel.Location = new System.Drawing.Point(508, 12);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 36);
			this.buttonCancel.TabIndex = 2;
			this.buttonCancel.Text = "Cancel";
			//
			// labelHint
			//
			this.labelHint.CssClass = "relay-muted";
			this.labelHint.Dock = Wisej.Web.DockStyle.Top;
			this.labelHint.Location = new System.Drawing.Point(16, 16);
			this.labelHint.Name = "labelHint";
			this.labelHint.Size = new System.Drawing.Size(608, 28);
			this.labelHint.TabIndex = 0;
			this.labelHint.Text = "Show the rows that match all or any of these conditions.";
			//
			// FilterDialog
			//
			this.AcceptButton = this.buttonOk;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(640, 396);
			this.Controls.Add(this.queryBuilder);
			this.Controls.Add(this.labelHint);
			this.Controls.Add(this.panelButtons);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(480, 320);
			this.Name = "FilterDialog";
			this.Padding = new Wisej.Web.Padding(16);
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Advanced filter";
			this.panelButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.QueryBuilder queryBuilder;
		private Wisej.Web.Panel panelButtons;
		private Wisej.Web.Button buttonClear;
		private Wisej.Web.Button buttonOk;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Label labelHint;
	}
}
