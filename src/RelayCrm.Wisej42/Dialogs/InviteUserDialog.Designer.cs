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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelIntro = new Wisej.Web.Label();
			this.textBoxName = new Wisej.Web.TextBox();
			this.textBoxEmail = new Wisej.Web.TextBox();
			this.comboBoxRole = new Wisej.Web.ComboBox();
			this.labelRoleHint = new Wisej.Web.Label();
			this.buttonInvite = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.SuspendLayout();
			//
			// labelIntro
			//
			this.labelIntro.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.labelIntro.CssClass = "relay-muted";
			this.labelIntro.Location = new System.Drawing.Point(24, 24);
			this.labelIntro.Name = "labelIntro";
			this.labelIntro.Size = new System.Drawing.Size(392, 40);
			this.labelIntro.TabIndex = 0;
			this.labelIntro.Text = "The new user can sign in right away. Their records and tasks start empty.";
			//
			// textBoxName
			//
			this.textBoxName.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxName.LabelText = "Name";
			this.textBoxName.Location = new System.Drawing.Point(24, 76);
			this.textBoxName.MaxLength = 100;
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(392, 56);
			this.textBoxName.TabIndex = 1;
			this.textBoxName.Watermark = "First and last name";
			this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			//
			// textBoxEmail
			//
			this.textBoxEmail.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxEmail.LabelText = "Email";
			this.textBoxEmail.Location = new System.Drawing.Point(24, 144);
			this.textBoxEmail.MaxLength = 200;
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(392, 56);
			this.textBoxEmail.TabIndex = 2;
			this.textBoxEmail.Watermark = "name@example.com";
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
			//
			// comboBoxRole
			//
			this.comboBoxRole.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Sales"});
			this.comboBoxRole.LabelText = "Role";
			this.comboBoxRole.Location = new System.Drawing.Point(24, 212);
			this.comboBoxRole.Name = "comboBoxRole";
			this.comboBoxRole.Size = new System.Drawing.Size(180, 56);
			this.comboBoxRole.TabIndex = 3;
			//
			// labelRoleHint
			//
			this.labelRoleHint.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.labelRoleHint.CssClass = "relay-muted";
			this.labelRoleHint.Location = new System.Drawing.Point(216, 232);
			this.labelRoleHint.Name = "labelRoleHint";
			this.labelRoleHint.Size = new System.Drawing.Size(200, 36);
			this.labelRoleHint.TabIndex = 4;
			this.labelRoleHint.Text = "Sales see their own records; Managers and Admins see all.";
			//
			// buttonInvite
			//
			this.buttonInvite.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonInvite.CssClass = "relay-primary";
			this.buttonInvite.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/send.svg";
			this.buttonInvite.Location = new System.Drawing.Point(296, 296);
			this.buttonInvite.Name = "buttonInvite";
			this.buttonInvite.Size = new System.Drawing.Size(120, 36);
			this.buttonInvite.TabIndex = 5;
			this.buttonInvite.Text = "Invite";
			this.buttonInvite.Click += new System.EventHandler(this.buttonInvite_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(188, 296);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 36);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Cancel";
			//
			// InviteUserDialog
			//
			this.AcceptButton = this.buttonInvite;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(440, 356);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonInvite);
			this.Controls.Add(this.labelRoleHint);
			this.Controls.Add(this.comboBoxRole);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelIntro);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InviteUserDialog";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Invite user";
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Label labelIntro;
		private Wisej.Web.TextBox textBoxName;
		private Wisej.Web.TextBox textBoxEmail;
		private Wisej.Web.ComboBox comboBoxRole;
		private Wisej.Web.Label labelRoleHint;
		private Wisej.Web.Button buttonInvite;
		private Wisej.Web.Button buttonCancel;
	}
}
