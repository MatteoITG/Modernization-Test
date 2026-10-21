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
			this.tableFields = new Wisej.Web.TableLayoutPanel();
			this.labelName = new Wisej.Web.Label();
			this.textBoxName = new Wisej.Web.TextBox();
			this.labelEmail = new Wisej.Web.Label();
			this.textBoxEmail = new Wisej.Web.TextBox();
			this.labelRole = new Wisej.Web.Label();
			this.comboBoxRole = new Wisej.Web.ComboBox();
			this.labelError = new Wisej.Web.Label();
			this.flowButtons = new Wisej.Web.FlowLayoutPanel();
			this.buttonCancel = new Wisej.Web.Button();
			this.buttonInvite = new Wisej.Web.Button();
			this.tableFields.SuspendLayout();
			this.flowButtons.SuspendLayout();
			this.SuspendLayout();
			//
			// labelIntro
			//
			this.labelIntro.Dock = Wisej.Web.DockStyle.Top;
			this.labelIntro.Location = new System.Drawing.Point(14, 14);
			this.labelIntro.Name = "labelIntro";
			this.labelIntro.Padding = new Wisej.Web.Padding(0, 0, 0, 10);
			this.labelIntro.Size = new System.Drawing.Size(378, 46);
			this.labelIntro.TabIndex = 0;
			this.labelIntro.Text = "The new user can sign in right away and gets the avatar colour that is next in the palette.";
			//
			// tableFields
			//
			this.tableFields.ColumnCount = 2;
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableFields.Controls.Add(this.labelName, 0, 0);
			this.tableFields.Controls.Add(this.textBoxName, 1, 0);
			this.tableFields.Controls.Add(this.labelEmail, 0, 1);
			this.tableFields.Controls.Add(this.textBoxEmail, 1, 1);
			this.tableFields.Controls.Add(this.labelRole, 0, 2);
			this.tableFields.Controls.Add(this.comboBoxRole, 1, 2);
			this.tableFields.Dock = Wisej.Web.DockStyle.Top;
			this.tableFields.Location = new System.Drawing.Point(14, 60);
			this.tableFields.Name = "tableFields";
			this.tableFields.RowCount = 3;
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.Size = new System.Drawing.Size(378, 114);
			this.tableFields.TabIndex = 1;
			this.tableFields.TabStop = true;
			//
			// labelName
			//
			this.labelName.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(3, 11);
			this.labelName.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(41, 16);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name:";
			//
			// textBoxName
			//
			this.textBoxName.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxName.Location = new System.Drawing.Point(53, 4);
			this.textBoxName.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(325, 30);
			this.textBoxName.TabIndex = 1;
			this.textBoxName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// labelEmail
			//
			this.labelEmail.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(3, 49);
			this.labelEmail.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(39, 16);
			this.labelEmail.TabIndex = 2;
			this.labelEmail.Text = "Email:";
			//
			// textBoxEmail
			//
			this.textBoxEmail.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxEmail.Location = new System.Drawing.Point(53, 42);
			this.textBoxEmail.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(325, 30);
			this.textBoxEmail.TabIndex = 3;
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// labelRole
			//
			this.labelRole.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelRole.AutoSize = true;
			this.labelRole.Location = new System.Drawing.Point(3, 87);
			this.labelRole.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelRole.Name = "labelRole";
			this.labelRole.Size = new System.Drawing.Size(34, 16);
			this.labelRole.TabIndex = 4;
			this.labelRole.Text = "Role:";
			//
			// comboBoxRole
			//
			this.comboBoxRole.Anchor = Wisej.Web.AnchorStyles.Left;
			this.comboBoxRole.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxRole.Location = new System.Drawing.Point(53, 80);
			this.comboBoxRole.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxRole.Name = "comboBoxRole";
			this.comboBoxRole.Size = new System.Drawing.Size(160, 30);
			this.comboBoxRole.TabIndex = 5;
			//
			// labelError
			//
			this.labelError.Dock = Wisej.Web.DockStyle.Top;
			this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
			this.labelError.Location = new System.Drawing.Point(14, 174);
			this.labelError.Name = "labelError";
			this.labelError.Padding = new Wisej.Web.Padding(0, 10, 0, 0);
			this.labelError.Size = new System.Drawing.Size(378, 34);
			this.labelError.TabIndex = 2;
			this.labelError.Visible = false;
			//
			// flowButtons
			//
			this.flowButtons.Controls.Add(this.buttonCancel);
			this.flowButtons.Controls.Add(this.buttonInvite);
			this.flowButtons.Dock = Wisej.Web.DockStyle.Top;
			this.flowButtons.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowButtons.Location = new System.Drawing.Point(14, 208);
			this.flowButtons.Name = "flowButtons";
			this.flowButtons.Padding = new Wisej.Web.Padding(0, 14, 0, 0);
			this.flowButtons.Size = new System.Drawing.Size(378, 48);
			this.flowButtons.TabIndex = 3;
			this.flowButtons.TabStop = true;
			//
			// buttonCancel
			//
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(290, 14);
			this.buttonCancel.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 30);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			//
			// buttonInvite
			//
			this.buttonInvite.CssClass = "relay-primary";
			this.buttonInvite.Location = new System.Drawing.Point(194, 14);
			this.buttonInvite.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonInvite.Name = "buttonInvite";
			this.buttonInvite.Size = new System.Drawing.Size(88, 30);
			this.buttonInvite.TabIndex = 0;
			this.buttonInvite.Text = "Invite";
			this.buttonInvite.Click += new System.EventHandler(this.buttonInvite_Click);
			//
			// InviteUserDialog
			//
			this.AcceptButton = this.buttonInvite;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(406, 270);
			this.Controls.Add(this.flowButtons);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.tableFields);
			this.Controls.Add(this.labelIntro);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "InviteUserDialog";
			this.Padding = new Wisej.Web.Padding(14);
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Invite user";
			this.tableFields.ResumeLayout(false);
			this.tableFields.PerformLayout();
			this.flowButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Label labelIntro;
		private Wisej.Web.TableLayoutPanel tableFields;
		private Wisej.Web.Label labelName;
		private Wisej.Web.TextBox textBoxName;
		private Wisej.Web.Label labelEmail;
		private Wisej.Web.TextBox textBoxEmail;
		private Wisej.Web.Label labelRole;
		private Wisej.Web.ComboBox comboBoxRole;
		private Wisej.Web.Label labelError;
		private Wisej.Web.FlowLayoutPanel flowButtons;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Button buttonInvite;
	}
}
