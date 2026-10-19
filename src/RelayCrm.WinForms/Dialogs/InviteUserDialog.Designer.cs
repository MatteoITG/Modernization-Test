namespace RelayCrm.Dialogs
{
	partial class InviteUserDialog
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
			this.labelIntro = new System.Windows.Forms.Label();
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelEmail = new System.Windows.Forms.Label();
			this.textBoxEmail = new System.Windows.Forms.TextBox();
			this.labelRole = new System.Windows.Forms.Label();
			this.comboBoxRole = new System.Windows.Forms.ComboBox();
			this.labelRoleHint = new System.Windows.Forms.Label();
			this.buttonInvite = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			//
			// labelIntro
			//
			this.labelIntro.Location = new System.Drawing.Point(12, 12);
			this.labelIntro.Name = "labelIntro";
			this.labelIntro.Size = new System.Drawing.Size(376, 34);
			this.labelIntro.TabIndex = 0;
			this.labelIntro.Text = "The new user can sign in right away. Their records and tasks start empty.";
			//
			// labelName
			//
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 59);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(42, 15);
			this.labelName.TabIndex = 1;
			this.labelName.Text = "&Name:";
			//
			// textBoxName
			//
			this.textBoxName.Location = new System.Drawing.Point(84, 56);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(280, 23);
			this.textBoxName.TabIndex = 2;
			this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// labelEmail
			//
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(12, 88);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(39, 15);
			this.labelEmail.TabIndex = 3;
			this.labelEmail.Text = "&Email:";
			//
			// textBoxEmail
			//
			this.textBoxEmail.Location = new System.Drawing.Point(84, 85);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(280, 23);
			this.textBoxEmail.TabIndex = 4;
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// labelRole
			//
			this.labelRole.AutoSize = true;
			this.labelRole.Location = new System.Drawing.Point(12, 117);
			this.labelRole.Name = "labelRole";
			this.labelRole.Size = new System.Drawing.Size(33, 15);
			this.labelRole.TabIndex = 5;
			this.labelRole.Text = "&Role:";
			//
			// comboBoxRole
			//
			this.comboBoxRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRole.FormattingEnabled = true;
			this.comboBoxRole.Items.AddRange(new object[] {
			"Admin",
			"Manager",
			"Sales"});
			this.comboBoxRole.Location = new System.Drawing.Point(84, 114);
			this.comboBoxRole.Name = "comboBoxRole";
			this.comboBoxRole.Size = new System.Drawing.Size(140, 23);
			this.comboBoxRole.TabIndex = 6;
			//
			// labelRoleHint
			//
			this.labelRoleHint.AutoSize = true;
			this.labelRoleHint.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelRoleHint.Location = new System.Drawing.Point(84, 142);
			this.labelRoleHint.Name = "labelRoleHint";
			this.labelRoleHint.Size = new System.Drawing.Size(298, 15);
			this.labelRoleHint.TabIndex = 7;
			this.labelRoleHint.Text = "Sales see their own records; Managers and Admins see all.";
			//
			// buttonInvite
			//
			this.buttonInvite.Location = new System.Drawing.Point(196, 176);
			this.buttonInvite.Name = "buttonInvite";
			this.buttonInvite.Size = new System.Drawing.Size(92, 27);
			this.buttonInvite.TabIndex = 8;
			this.buttonInvite.Text = "Invite";
			this.buttonInvite.UseVisualStyleBackColor = true;
			this.buttonInvite.Click += new System.EventHandler(this.buttonInvite_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(296, 176);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// InviteUserDialog
			//
			this.AcceptButton = this.buttonInvite;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(400, 215);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonInvite);
			this.Controls.Add(this.labelRoleHint);
			this.Controls.Add(this.comboBoxRole);
			this.Controls.Add(this.labelRole);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.Controls.Add(this.labelIntro);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InviteUserDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Invite user";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelIntro;
		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.TextBox textBoxEmail;
		private System.Windows.Forms.Label labelRole;
		private System.Windows.Forms.ComboBox comboBoxRole;
		private System.Windows.Forms.Label labelRoleHint;
		private System.Windows.Forms.Button buttonInvite;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
