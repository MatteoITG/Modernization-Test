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
			this.panelHeader = new Wisej.Web.Panel();
			this.labelIntro = new Wisej.Web.Label();
			this.labelLogo = new Wisej.Web.Label();
			this.flowButtons = new Wisej.Web.FlowLayoutPanel();
			this.buttonExit = new Wisej.Web.Button();
			this.buttonSignIn = new Wisej.Web.Button();
			this.listUsers = new Wisej.Web.ListBox();
			this.panelHeader.SuspendLayout();
			this.flowButtons.SuspendLayout();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.labelIntro);
			this.panelHeader.Controls.Add(this.labelLogo);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(12, 12);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Padding = new Wisej.Web.Padding(0, 0, 0, 10);
			this.panelHeader.Size = new System.Drawing.Size(400, 76);
			this.panelHeader.TabIndex = 0;
			//
			// labelIntro
			//
			this.labelIntro.Dock = Wisej.Web.DockStyle.Top;
			this.labelIntro.Location = new System.Drawing.Point(0, 30);
			this.labelIntro.Name = "labelIntro";
			this.labelIntro.Padding = new Wisej.Web.Padding(0, 4, 0, 0);
			this.labelIntro.Size = new System.Drawing.Size(400, 36);
			this.labelIntro.TabIndex = 1;
			this.labelIntro.Text = "Development sign-in: choose the user to work as. There are no passwords.";
			//
			// labelLogo
			//
			this.labelLogo.Dock = Wisej.Web.DockStyle.Top;
			this.labelLogo.Font = new System.Drawing.Font("default", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(70)))), ((int)(((byte)(229)))));
			this.labelLogo.Location = new System.Drawing.Point(0, 0);
			this.labelLogo.Name = "labelLogo";
			this.labelLogo.Size = new System.Drawing.Size(400, 30);
			this.labelLogo.TabIndex = 0;
			this.labelLogo.Text = "Relay";
			//
			// flowButtons
			//
			this.flowButtons.Controls.Add(this.buttonExit);
			this.flowButtons.Controls.Add(this.buttonSignIn);
			this.flowButtons.Dock = Wisej.Web.DockStyle.Bottom;
			this.flowButtons.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowButtons.Location = new System.Drawing.Point(12, 374);
			this.flowButtons.Name = "flowButtons";
			this.flowButtons.Padding = new Wisej.Web.Padding(0, 10, 0, 0);
			this.flowButtons.Size = new System.Drawing.Size(400, 44);
			this.flowButtons.TabIndex = 2;
			this.flowButtons.TabStop = true;
			//
			// buttonExit
			//
			this.buttonExit.CssClass = "relay-secondary";
			this.buttonExit.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonExit.Location = new System.Drawing.Point(312, 10);
			this.buttonExit.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(88, 30);
			this.buttonExit.TabIndex = 1;
			this.buttonExit.Text = "Exit";
			//
			// buttonSignIn
			//
			this.buttonSignIn.CssClass = "relay-primary";
			this.buttonSignIn.Location = new System.Drawing.Point(216, 10);
			this.buttonSignIn.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonSignIn.Name = "buttonSignIn";
			this.buttonSignIn.Size = new System.Drawing.Size(88, 30);
			this.buttonSignIn.TabIndex = 0;
			this.buttonSignIn.Text = "Sign in";
			this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
			//
			// listUsers
			//
			this.listUsers.AllowHtml = true;
			this.listUsers.Dock = Wisej.Web.DockStyle.Fill;
			this.listUsers.ItemHeight = 46;
			this.listUsers.Location = new System.Drawing.Point(12, 88);
			this.listUsers.Name = "listUsers";
			this.listUsers.Size = new System.Drawing.Size(400, 286);
			this.listUsers.TabIndex = 1;
			this.listUsers.SelectedIndexChanged += new System.EventHandler(this.listUsers_SelectedIndexChanged);
			this.listUsers.DoubleClick += new System.EventHandler(this.listUsers_DoubleClick);
			//
			// SignInDialog
			//
			this.AcceptButton = this.buttonSignIn;
			this.CancelButton = this.buttonExit;
			this.ClientSize = new System.Drawing.Size(424, 430);
			this.Controls.Add(this.listUsers);
			this.Controls.Add(this.flowButtons);
			this.Controls.Add(this.panelHeader);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SignInDialog";
			this.Padding = new Wisej.Web.Padding(12);
			this.Anchor = Wisej.Web.AnchorStyles.None;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterScreen;
			this.Text = "Sign in to Relay";
			this.Load += new System.EventHandler(this.SignInDialog_Load);
			this.panelHeader.ResumeLayout(false);
			this.flowButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelLogo;
		private Wisej.Web.Label labelIntro;
		private Wisej.Web.FlowLayoutPanel flowButtons;
		private Wisej.Web.Button buttonSignIn;
		private Wisej.Web.Button buttonExit;
		private Wisej.Web.ListBox listUsers;
	}
}
