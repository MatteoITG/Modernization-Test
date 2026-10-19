namespace RelayCrm.Dialogs
{
	partial class ConfirmDialog
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
			this.panelButtons = new Wisej.Web.Panel();
			this.buttonOk = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.panelButtons.SuspendLayout();
			this.SuspendLayout();
			//
			// labelMessage
			//
			this.labelMessage.Dock = Wisej.Web.DockStyle.Fill;
			this.labelMessage.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelMessage.Location = new System.Drawing.Point(24, 24);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new System.Drawing.Size(372, 78);
			this.labelMessage.TabIndex = 0;
			this.labelMessage.Text = "Are you sure?";
			//
			// panelButtons
			//
			this.panelButtons.Controls.Add(this.buttonCancel);
			this.panelButtons.Controls.Add(this.buttonOk);
			this.panelButtons.Dock = Wisej.Web.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(24, 102);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(372, 48);
			this.panelButtons.TabIndex = 1;
			//
			// buttonOk
			//
			this.buttonOk.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonOk.CssClass = "relay-primary";
			this.buttonOk.DialogResult = Wisej.Web.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(272, 12);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(100, 36);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "Confirm";
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(164, 12);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 36);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			//
			// ConfirmDialog
			//
			this.AcceptButton = this.buttonOk;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(420, 174);
			this.Controls.Add(this.labelMessage);
			this.Controls.Add(this.panelButtons);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfirmDialog";
			this.Padding = new Wisej.Web.Padding(24);
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Confirm";
			this.panelButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Label labelMessage;
		private Wisej.Web.Panel panelButtons;
		private Wisej.Web.Button buttonOk;
		private Wisej.Web.Button buttonCancel;
	}
}
