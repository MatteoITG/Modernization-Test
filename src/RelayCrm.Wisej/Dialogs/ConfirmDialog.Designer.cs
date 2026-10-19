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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureIcon = new Wisej.Web.PictureBox();
			this.labelMessage = new Wisej.Web.Label();
			this.buttonOk = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).BeginInit();
			this.SuspendLayout();
			//
			// pictureIcon
			//
			this.pictureIcon.Location = new System.Drawing.Point(16, 16);
			this.pictureIcon.Name = "pictureIcon";
			this.pictureIcon.Size = new System.Drawing.Size(32, 32);
			this.pictureIcon.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			this.pictureIcon.TabIndex = 0;
			this.pictureIcon.TabStop = false;
			//
			// labelMessage
			//
			this.labelMessage.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
			| Wisej.Web.AnchorStyles.Left)
			| Wisej.Web.AnchorStyles.Right)));
			this.labelMessage.Location = new System.Drawing.Point(60, 16);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new System.Drawing.Size(328, 72);
			this.labelMessage.TabIndex = 1;
			this.labelMessage.Text = "Are you sure?";
			//
			// buttonOk
			//
			this.buttonOk.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonOk.DialogResult = Wisej.Web.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(184, 100);
			this.buttonOk.CssClass = "relay-primary";
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(104, 27);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "OK";
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(296, 100);
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			//
			// ConfirmDialog
			//
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(404, 141);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.labelMessage);
			this.Controls.Add(this.pictureIcon);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ConfirmDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Confirm";
			((System.ComponentModel.ISupportInitialize)(this.pictureIcon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.PictureBox pictureIcon;
		private Wisej.Web.Label labelMessage;
		private Wisej.Web.Button buttonOk;
		private Wisej.Web.Button buttonCancel;
	}
}
