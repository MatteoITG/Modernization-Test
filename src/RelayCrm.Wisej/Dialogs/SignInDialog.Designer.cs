namespace RelayCrm.Dialogs
{
	partial class SignInDialog
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
			this.labelLogo = new Wisej.Web.Label();
			this.labelWelcome = new Wisej.Web.Label();
			this.labelSignInAs = new Wisej.Web.Label();
			this.listViewUsers = new Wisej.Web.ListView();
			this.columnName = new Wisej.Web.ColumnHeader();
			this.columnRole = new Wisej.Web.ColumnHeader();
			this.columnEmail = new Wisej.Web.ColumnHeader();
			this.imageListAvatars = new Wisej.Web.ImageList(this.components);
			this.labelNote = new Wisej.Web.Label();
			this.buttonSignIn = new Wisej.Web.Button();
			this.buttonExit = new Wisej.Web.Button();
			this.SuspendLayout();
			//
			// labelLogo
			//
			this.labelLogo.AutoSize = true;
			this.labelLogo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			this.labelLogo.Location = new System.Drawing.Point(12, 12);
			this.labelLogo.Name = "labelLogo";
			this.labelLogo.Size = new System.Drawing.Size(116, 30);
			this.labelLogo.TabIndex = 0;
			this.labelLogo.Text = "Relay CRM";
			//
			// labelWelcome
			//
			this.labelWelcome.AutoSize = true;
			this.labelWelcome.Location = new System.Drawing.Point(14, 48);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Size = new System.Drawing.Size(266, 15);
			this.labelWelcome.TabIndex = 1;
			this.labelWelcome.Text = "Welcome back. Choose who you are to continue.";
			//
			// labelSignInAs
			//
			this.labelSignInAs.AutoSize = true;
			this.labelSignInAs.Location = new System.Drawing.Point(14, 78);
			this.labelSignInAs.Name = "labelSignInAs";
			this.labelSignInAs.Size = new System.Drawing.Size(58, 15);
			this.labelSignInAs.TabIndex = 2;
			this.labelSignInAs.Text = "&Sign in as:";
			//
			// listViewUsers
			//
			this.listViewUsers.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
			| Wisej.Web.AnchorStyles.Left)
			| Wisej.Web.AnchorStyles.Right)));
			this.listViewUsers.Columns.AddRange(new Wisej.Web.ColumnHeader[] {
			this.columnName,
			this.columnRole,
			this.columnEmail});
			this.listViewUsers.HeaderStyle = Wisej.Web.ColumnHeaderStyle.NonClickable;
			this.listViewUsers.Location = new System.Drawing.Point(14, 96);
			this.listViewUsers.MultiSelect = false;
			this.listViewUsers.Name = "listViewUsers";
			this.listViewUsers.Size = new System.Drawing.Size(496, 220);
			this.listViewUsers.SmallImageList = this.imageListAvatars;
			this.listViewUsers.TabIndex = 3;
			this.listViewUsers.View = Wisej.Web.View.Details;
			this.listViewUsers.ItemDoubleClick += new Wisej.Web.ItemClickEventHandler(this.listViewUsers_ItemActivate);
			this.listViewUsers.SelectedIndexChanged += new System.EventHandler(this.listViewUsers_SelectedIndexChanged);
			//
			// columnName
			//
			this.columnName.Text = "Name";
			this.columnName.Width = 170;
			//
			// columnRole
			//
			this.columnRole.Text = "Role";
			this.columnRole.Width = 80;
			//
			// columnEmail
			//
			this.columnEmail.Text = "Email";
			this.columnEmail.Width = 220;
			//
			// imageListAvatars
			//
			this.imageListAvatars.ImageSize = new System.Drawing.Size(32, 32);
			this.imageListAvatars.TransparentColor = System.Drawing.Color.Transparent;
			//
			// labelNote
			//
			this.labelNote.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
			this.labelNote.AutoSize = true;
			this.labelNote.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelNote.Location = new System.Drawing.Point(14, 330);
			this.labelNote.Name = "labelNote";
			this.labelNote.Size = new System.Drawing.Size(300, 15);
			this.labelNote.TabIndex = 4;
			this.labelNote.Text = "No password needed: this sign-in is for development only.";
			//
			// buttonSignIn
			//
			this.buttonSignIn.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonSignIn.Location = new System.Drawing.Point(326, 356);
			this.buttonSignIn.Name = "buttonSignIn";
			this.buttonSignIn.Size = new System.Drawing.Size(88, 27);
			this.buttonSignIn.TabIndex = 5;
			this.buttonSignIn.Text = "Sign in";
			this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
			//
			// buttonExit
			//
			this.buttonExit.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonExit.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(422, 356);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(88, 27);
			this.buttonExit.TabIndex = 6;
			this.buttonExit.Text = "Exit";
			//
			// SignInDialog
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(524, 395);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonSignIn);
			this.Controls.Add(this.labelNote);
			this.Controls.Add(this.listViewUsers);
			this.Controls.Add(this.labelSignInAs);
			this.Controls.Add(this.labelWelcome);
			this.Controls.Add(this.labelLogo);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SignInDialog";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "Sign in - Relay CRM";
			this.Shown += new System.EventHandler(this.SignInDialog_Shown);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelLogo;
		private Wisej.Web.Label labelWelcome;
		private Wisej.Web.Label labelSignInAs;
		private Wisej.Web.ListView listViewUsers;
		private Wisej.Web.ColumnHeader columnName;
		private Wisej.Web.ColumnHeader columnRole;
		private Wisej.Web.ColumnHeader columnEmail;
		private Wisej.Web.ImageList imageListAvatars;
		private Wisej.Web.Label labelNote;
		private Wisej.Web.Button buttonSignIn;
		private Wisej.Web.Button buttonExit;
	}
}
