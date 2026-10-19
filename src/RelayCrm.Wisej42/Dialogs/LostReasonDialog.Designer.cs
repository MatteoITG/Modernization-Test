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
			this.comboBoxReason = new Wisej.Web.ComboBox();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.SuspendLayout();
			//
			// labelMessage
			//
			this.labelMessage.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.labelMessage.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelMessage.CssClass = "relay-title";
			this.labelMessage.Location = new System.Drawing.Point(24, 24);
			this.labelMessage.Name = "labelMessage";
			this.labelMessage.Size = new System.Drawing.Size(392, 44);
			this.labelMessage.TabIndex = 0;
			this.labelMessage.Text = "Why was the deal lost?";
			//
			// comboBoxReason
			//
			this.comboBoxReason.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxReason.LabelText = "Lost reason";
			this.comboBoxReason.Location = new System.Drawing.Point(24, 76);
			this.comboBoxReason.Name = "comboBoxReason";
			this.comboBoxReason.Size = new System.Drawing.Size(392, 56);
			this.comboBoxReason.TabIndex = 1;
			this.comboBoxReason.Watermark = "Pick or type a reason";
			this.comboBoxReason.TextChanged += new System.EventHandler(this.comboBoxReason_TextChanged);
			//
			// buttonSave
			//
			this.buttonSave.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Location = new System.Drawing.Point(296, 164);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(120, 36);
			this.buttonSave.TabIndex = 2;
			this.buttonSave.Text = "Mark as lost";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(188, 164);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 36);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			//
			// LostReasonDialog
			//
			this.AcceptButton = this.buttonSave;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(440, 224);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.comboBoxReason);
			this.Controls.Add(this.labelMessage);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LostReasonDialog";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Deal lost";
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Label labelMessage;
		private Wisej.Web.ComboBox comboBoxReason;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.Button buttonCancel;
	}
}
