namespace RelayCrm.Dialogs
{
	partial class LostReasonDialog
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
			this.labelMessage = new Wisej.Web.Label();
			this.labelHint = new Wisej.Web.Label();
			this.comboBoxReason = new Wisej.Web.ComboBox();
			this.labelError = new Wisej.Web.Label();
			this.flowButtons = new Wisej.Web.FlowLayoutPanel();
			this.buttonCancel = new Wisej.Web.Button();
			this.buttonSave = new Wisej.Web.Button();
			this.flowButtons.SuspendLayout();
			this.SuspendLayout();
			//
			// labelMessage
			//
			this.labelMessage.Dock = Wisej.Web.DockStyle.Top;
			this.labelMessage.Location = new System.Drawing.Point(14, 14);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Padding = new Wisej.Web.Padding(0, 0, 0, 8);
			this.labelMessage.Size = new System.Drawing.Size(392, 40);
			this.labelMessage.TabIndex = 0;
			//
			// labelHint
			//
			this.labelHint.Dock = Wisej.Web.DockStyle.Top;
			this.labelHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelHint.Location = new System.Drawing.Point(14, 54);
			this.labelHint.Name = "labelHint";
			this.labelHint.Padding = new Wisej.Web.Padding(0, 0, 0, 4);
			this.labelHint.Size = new System.Drawing.Size(392, 24);
			this.labelHint.TabIndex = 1;
			this.labelHint.Text = "Pick a common reason or type your own:";
			//
			// comboBoxReason
			//
			this.comboBoxReason.Dock = Wisej.Web.DockStyle.Top;
			this.comboBoxReason.Location = new System.Drawing.Point(14, 78);
			this.comboBoxReason.Name = "comboBoxReason";
			this.comboBoxReason.Size = new System.Drawing.Size(392, 30);
			this.comboBoxReason.TabIndex = 2;
			//
			// labelError
			//
			this.labelError.Dock = Wisej.Web.DockStyle.Top;
			this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
			this.labelError.Location = new System.Drawing.Point(14, 108);
			this.labelError.Name = "labelError";
			this.labelError.Padding = new Wisej.Web.Padding(0, 8, 0, 0);
			this.labelError.Size = new System.Drawing.Size(392, 32);
			this.labelError.TabIndex = 3;
			this.labelError.Visible = false;
			//
			// flowButtons
			//
			this.flowButtons.Controls.Add(this.buttonCancel);
			this.flowButtons.Controls.Add(this.buttonSave);
			this.flowButtons.Dock = Wisej.Web.DockStyle.Top;
			this.flowButtons.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowButtons.Location = new System.Drawing.Point(14, 140);
			this.flowButtons.Name = "flowButtons";
			this.flowButtons.Padding = new Wisej.Web.Padding(0, 14, 0, 0);
			this.flowButtons.Size = new System.Drawing.Size(392, 48);
			this.flowButtons.TabIndex = 4;
			this.flowButtons.TabStop = true;
			//
			// buttonCancel
			//
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(304, 14);
			this.buttonCancel.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 30);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			//
			// buttonSave
			//
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Location = new System.Drawing.Point(208, 14);
			this.buttonSave.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 30);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Mark as lost";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// LostReasonDialog
			//
			this.AcceptButton = this.buttonSave;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(420, 202);
			this.Controls.Add(this.flowButtons);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.comboBoxReason);
			this.Controls.Add(this.labelHint);
			this.Controls.Add(this.labelMessage);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LostReasonDialog";
			this.Padding = new Wisej.Web.Padding(14);
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Deal lost";
			this.flowButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Label labelMessage;
		private Wisej.Web.Label labelHint;
		private Wisej.Web.ComboBox comboBoxReason;
		private Wisej.Web.Label labelError;
		private Wisej.Web.FlowLayoutPanel flowButtons;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Button buttonSave;
	}
}
