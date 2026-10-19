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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelLogo = new Wisej.Web.Label();
			this.labelWelcome = new Wisej.Web.Label();
			this.chipDevelopment = new Wisej.Web.ChipLabel();
			this.labelSignInAs = new Wisej.Web.Label();
			this.listBoxUsers = new Wisej.Web.ListBox();
			this.buttonSignIn = new Wisej.Web.Button();
			this.labelNote = new Wisej.Web.Label();
			this.SuspendLayout();
			//
			// labelLogo
			//
			this.labelLogo.Font = new System.Drawing.Font("defaultBold", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelLogo.Location = new System.Drawing.Point(32, 32);
			this.labelLogo.Name = "labelLogo";
			this.labelLogo.Size = new System.Drawing.Size(200, 40);
			this.labelLogo.TabIndex = 0;
			this.labelLogo.Text = "Relay";
			//
			// labelWelcome
			//
			this.labelWelcome.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.labelWelcome.CssClass = "relay-muted";
			this.labelWelcome.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelWelcome.Location = new System.Drawing.Point(32, 80);
			this.labelWelcome.Name = "labelWelcome";
			this.labelWelcome.Size = new System.Drawing.Size(376, 22);
			this.labelWelcome.TabIndex = 1;
			this.labelWelcome.Text = "Welcome back. Choose who you are to continue.";
			//
			// chipDevelopment
			//
			this.chipDevelopment.ChipSize = Wisej.Web.ChipSize.Small;
			this.chipDevelopment.Location = new System.Drawing.Point(280, 40);
			this.chipDevelopment.Name = "chipDevelopment";
			this.chipDevelopment.ShowDot = true;
			this.chipDevelopment.Size = new System.Drawing.Size(128, 24);
			this.chipDevelopment.TabIndex = 2;
			this.chipDevelopment.Text = "Development";
			this.chipDevelopment.Tone = Wisej.Web.ChipTone.Warning;
			//
			// labelSignInAs
			//
			this.labelSignInAs.Font = new System.Drawing.Font("defaultBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelSignInAs.Location = new System.Drawing.Point(32, 124);
			this.labelSignInAs.Name = "labelSignInAs";
			this.labelSignInAs.Size = new System.Drawing.Size(200, 24);
			this.labelSignInAs.TabIndex = 3;
			this.labelSignInAs.Text = "Sign in as";
			//
			// listBoxUsers
			//
			this.listBoxUsers.AllowHtml = true;
			this.listBoxUsers.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
            | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.listBoxUsers.ItemHeight = 56;
			this.listBoxUsers.Location = new System.Drawing.Point(32, 156);
			this.listBoxUsers.Name = "listBoxUsers";
			this.listBoxUsers.Size = new System.Drawing.Size(376, 300);
			this.listBoxUsers.TabIndex = 4;
			this.listBoxUsers.SelectedIndexChanged += new System.EventHandler(this.listBoxUsers_SelectedIndexChanged);
			this.listBoxUsers.DoubleClick += new System.EventHandler(this.listBoxUsers_DoubleClick);
			//
			// buttonSignIn
			//
			this.buttonSignIn.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.buttonSignIn.CssClass = "relay-primary";
			this.buttonSignIn.Location = new System.Drawing.Point(32, 472);
			this.buttonSignIn.Name = "buttonSignIn";
			this.buttonSignIn.Size = new System.Drawing.Size(376, 36);
			this.buttonSignIn.TabIndex = 5;
			this.buttonSignIn.Text = "Sign in";
			this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
			//
			// labelNote
			//
			this.labelNote.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.labelNote.CssClass = "relay-muted";
			this.labelNote.Location = new System.Drawing.Point(32, 524);
			this.labelNote.Name = "labelNote";
			this.labelNote.Size = new System.Drawing.Size(376, 20);
			this.labelNote.TabIndex = 6;
			this.labelNote.Text = "No password needed: this sign-in is for development only.";
			this.labelNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			// SignInDialog
			//
			this.AcceptButton = this.buttonSignIn;
			this.ClientSize = new System.Drawing.Size(440, 568);
			this.CloseBox = false;
			this.ControlBox = false;
			this.Controls.Add(this.labelNote);
			this.Controls.Add(this.buttonSignIn);
			this.Controls.Add(this.listBoxUsers);
			this.Controls.Add(this.labelSignInAs);
			this.Controls.Add(this.chipDevelopment);
			this.Controls.Add(this.labelWelcome);
			this.Controls.Add(this.labelLogo);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.None;
			this.KeepCentered = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Movable = false;
			this.Name = "SignInDialog";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "Sign in";
			this.FormClosing += new Wisej.Web.FormClosingEventHandler(this.SignInDialog_FormClosing);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Label labelLogo;
		private Wisej.Web.Label labelWelcome;
		private Wisej.Web.ChipLabel chipDevelopment;
		private Wisej.Web.Label labelSignInAs;
		private Wisej.Web.ListBox listBoxUsers;
		private Wisej.Web.Button buttonSignIn;
		private Wisej.Web.Label labelNote;
	}
}
