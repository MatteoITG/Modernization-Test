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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.labelMessage = new Wisej.Web.Label();
			this.labelReason = new Wisej.Web.Label();
			this.comboBoxReason = new Wisej.Web.ComboBox();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.errorProvider = new Wisej.Web.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			//
			// labelMessage
			//
			this.labelMessage.Location = new System.Drawing.Point(12, 12);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new System.Drawing.Size(360, 36);
			this.labelMessage.TabIndex = 0;
			this.labelMessage.Text = "Why was the deal lost?";
			//
			// labelReason
			//
			this.labelReason.AutoSize = true;
			this.labelReason.Location = new System.Drawing.Point(12, 56);
			this.labelReason.Name = "labelReason";
			this.labelReason.Size = new System.Drawing.Size(67, 15);
			this.labelReason.TabIndex = 1;
			this.labelReason.Text = "Lost &reason:";
			//
			// comboBoxReason
			//
			this.comboBoxReason.FormattingEnabled = true;
			this.comboBoxReason.Location = new System.Drawing.Point(100, 53);
			this.comboBoxReason.Name = "comboBoxReason";
			this.comboBoxReason.Size = new System.Drawing.Size(252, 23);
			this.comboBoxReason.TabIndex = 2;
			this.comboBoxReason.TextChanged += new System.EventHandler(this.comboBoxReason_TextChanged);
			//
			// buttonSave
			//
			this.buttonSave.Location = new System.Drawing.Point(168, 96);
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(104, 27);
			this.buttonSave.TabIndex = 3;
			this.buttonSave.Text = "Mark as lost";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(280, 96);
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 4;
			this.buttonCancel.Text = "Cancel";
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = Wisej.Web.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// LostReasonDialog
			//
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(384, 135);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.comboBoxReason);
			this.Controls.Add(this.labelReason);
			this.Controls.Add(this.labelMessage);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LostReasonDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Deal lost";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelMessage;
		private Wisej.Web.Label labelReason;
		private Wisej.Web.ComboBox comboBoxReason;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.ErrorProvider errorProvider;
	}
}
