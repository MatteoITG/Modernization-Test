namespace RelayCrm.Dialogs
{
	partial class AdvancedFilterDialog
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
			this.labelHint = new Wisej.Web.Label();
			this.queryBuilder = new Wisej.Web.QueryBuilder();
			this.panelButtons = new Wisej.Web.Panel();
			this.buttonClear = new Wisej.Web.Button();
			this.flowButtons = new Wisej.Web.FlowLayoutPanel();
			this.buttonCancel = new Wisej.Web.Button();
			this.buttonApply = new Wisej.Web.Button();
			this.panelButtons.SuspendLayout();
			this.flowButtons.SuspendLayout();
			this.SuspendLayout();
			//
			// labelHint
			//
			this.labelHint.CssClass = "relay-muted";
			this.labelHint.Dock = Wisej.Web.DockStyle.Top;
			this.labelHint.Location = new System.Drawing.Point(16, 16);
			this.labelHint.Name = "labelHint";
			this.labelHint.Padding = new Wisej.Web.Padding(0, 0, 0, 8);
			this.labelHint.Size = new System.Drawing.Size(608, 28);
			this.labelHint.TabIndex = 0;
			this.labelHint.Text = "Show the rows that match all or any of these conditions. Amounts are plain numbers (2500000).";
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
			this.panelButtons.Controls.Add(this.flowButtons);
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
			// flowButtons
			//
			this.flowButtons.Controls.Add(this.buttonCancel);
			this.flowButtons.Controls.Add(this.buttonApply);
			this.flowButtons.Dock = Wisej.Web.DockStyle.Right;
			this.flowButtons.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowButtons.Location = new System.Drawing.Point(392, 12);
			this.flowButtons.Name = "flowButtons";
			this.flowButtons.Size = new System.Drawing.Size(216, 36);
			this.flowButtons.TabIndex = 1;
			this.flowButtons.TabStop = true;
			//
			// buttonCancel
			//
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(116, 0);
			this.buttonCancel.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 36);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			//
			// buttonApply
			//
			this.buttonApply.CssClass = "relay-primary";
			this.buttonApply.Location = new System.Drawing.Point(8, 0);
			this.buttonApply.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(100, 36);
			this.buttonApply.TabIndex = 0;
			this.buttonApply.Text = "Apply";
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			//
			// AdvancedFilterDialog
			//
			this.AcceptButton = this.buttonApply;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(640, 396);
			this.Controls.Add(this.queryBuilder);
			this.Controls.Add(this.labelHint);
			this.Controls.Add(this.panelButtons);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(480, 320);
			this.Name = "AdvancedFilterDialog";
			this.Padding = new Wisej.Web.Padding(16);
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Advanced filter";
			this.panelButtons.ResumeLayout(false);
			this.flowButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Label labelHint;
		private Wisej.Web.QueryBuilder queryBuilder;
		private Wisej.Web.Panel panelButtons;
		private Wisej.Web.Button buttonClear;
		private Wisej.Web.FlowLayoutPanel flowButtons;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Button buttonApply;
	}
}
