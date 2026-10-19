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
			this.labelIntro = new Wisej.Web.Label();
			this.labelName = new Wisej.Web.Label();
			this.textBoxName = new Wisej.Web.TextBox();
			this.labelEmail = new Wisej.Web.Label();
			this.textBoxEmail = new Wisej.Web.TextBox();
			this.labelRole = new Wisej.Web.Label();
			this.comboBoxRole = new Wisej.Web.ComboBox();
			this.labelRoleHint = new Wisej.Web.Label();
			this.buttonInvite = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.errorProvider = new Wisej.Web.ErrorProvider(this.components);
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
			this.comboBoxRole.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
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
			this.buttonInvite.Click += new System.EventHandler(this.buttonInvite_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(296, 176);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 9;
			this.buttonCancel.Text = "Cancel";
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = Wisej.Web.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// InviteUserDialog
			//
			this.AcceptButton = this.buttonInvite;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
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
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InviteUserDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Invite user";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelIntro;
		private Wisej.Web.Label labelName;
		private Wisej.Web.TextBox textBoxName;
		private Wisej.Web.Label labelEmail;
		private Wisej.Web.TextBox textBoxEmail;
		private Wisej.Web.Label labelRole;
		private Wisej.Web.ComboBox comboBoxRole;
		private Wisej.Web.Label labelRoleHint;
		private Wisej.Web.Button buttonInvite;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.ErrorProvider errorProvider;
	}
}
