namespace RelayCrm.Dialogs
{
	partial class ContactEditDialog
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
			this.tableFields = new Wisej.Web.TableLayoutPanel();
			this.labelName = new Wisej.Web.Label();
			this.textBoxFirstName = new Wisej.Web.TextBox();
			this.textBoxLastName = new Wisej.Web.TextBox();
			this.labelJobTitle = new Wisej.Web.Label();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.labelEmail = new Wisej.Web.Label();
			this.textBoxEmail = new Wisej.Web.TextBox();
			this.labelPhone = new Wisej.Web.Label();
			this.textBoxPhone = new Wisej.Web.TextBox();
			this.labelCompany = new Wisej.Web.Label();
			this.comboBoxCompany = new Wisej.Web.ComboBox();
			this.labelStage = new Wisej.Web.Label();
			this.comboBoxStage = new Wisej.Web.ComboBox();
			this.comboBoxLeadSource = new Wisej.Web.ComboBox();
			this.labelOwner = new Wisej.Web.Label();
			this.comboBoxOwner = new Wisej.Web.ComboBox();
			this.labelTags = new Wisej.Web.Label();
			this.textBoxTags = new Wisej.Web.TextBox();
			this.labelTagsHint = new Wisej.Web.Label();
			this.labelError = new Wisej.Web.Label();
			this.flowButtons = new Wisej.Web.FlowLayoutPanel();
			this.buttonCancel = new Wisej.Web.Button();
			this.buttonSave = new Wisej.Web.Button();
			this.tableFields.SuspendLayout();
			this.flowButtons.SuspendLayout();
			this.SuspendLayout();
			//
			// tableFields
			//
			this.tableFields.ColumnCount = 4;
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 12F));
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 50F));
			this.tableFields.Controls.Add(this.labelName, 0, 0);
			this.tableFields.Controls.Add(this.textBoxFirstName, 1, 0);
			this.tableFields.Controls.Add(this.textBoxLastName, 3, 0);
			this.tableFields.Controls.Add(this.labelJobTitle, 0, 1);
			this.tableFields.Controls.Add(this.textBoxTitle, 1, 1);
			this.tableFields.Controls.Add(this.labelEmail, 0, 2);
			this.tableFields.Controls.Add(this.textBoxEmail, 1, 2);
			this.tableFields.Controls.Add(this.labelPhone, 0, 3);
			this.tableFields.Controls.Add(this.textBoxPhone, 1, 3);
			this.tableFields.Controls.Add(this.labelCompany, 0, 4);
			this.tableFields.Controls.Add(this.comboBoxCompany, 1, 4);
			this.tableFields.Controls.Add(this.labelStage, 0, 5);
			this.tableFields.Controls.Add(this.comboBoxStage, 1, 5);
			this.tableFields.Controls.Add(this.comboBoxLeadSource, 3, 5);
			this.tableFields.Controls.Add(this.labelOwner, 0, 6);
			this.tableFields.Controls.Add(this.comboBoxOwner, 1, 6);
			this.tableFields.Controls.Add(this.labelTags, 0, 7);
			this.tableFields.Controls.Add(this.textBoxTags, 1, 7);
			this.tableFields.Controls.Add(this.labelTagsHint, 1, 8);
			this.tableFields.Dock = Wisej.Web.DockStyle.Top;
			this.tableFields.Location = new System.Drawing.Point(14, 14);
			this.tableFields.Name = "tableFields";
			this.tableFields.RowCount = 9;
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 40F));
			this.tableFields.Size = new System.Drawing.Size(478, 344);
			this.tableFields.TabIndex = 0;
			this.tableFields.TabStop = true;
			//
			// labelName
			//
			this.labelName.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(3, 11);
			this.labelName.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(40, 16);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name:";
			//
			// textBoxFirstName
			//
			this.textBoxFirstName.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxFirstName.Location = new System.Drawing.Point(73, 4);
			this.textBoxFirstName.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(196, 30);
			this.textBoxFirstName.TabIndex = 1;
			this.textBoxFirstName.ToolTipText = "First name";
			this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// textBoxLastName
			//
			this.textBoxLastName.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxLastName.Location = new System.Drawing.Point(281, 4);
			this.textBoxLastName.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(197, 30);
			this.textBoxLastName.TabIndex = 2;
			this.textBoxLastName.ToolTipText = "Last name";
			this.textBoxLastName.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// labelJobTitle
			//
			this.labelJobTitle.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelJobTitle.AutoSize = true;
			this.labelJobTitle.Location = new System.Drawing.Point(3, 49);
			this.labelJobTitle.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelJobTitle.Name = "labelJobTitle";
			this.labelJobTitle.Size = new System.Drawing.Size(55, 16);
			this.labelJobTitle.TabIndex = 3;
			this.labelJobTitle.Text = "Job title:";
			//
			// textBoxTitle
			//
			this.textBoxTitle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.tableFields.SetColumnSpan(this.textBoxTitle, 3);
			this.textBoxTitle.Location = new System.Drawing.Point(73, 42);
			this.textBoxTitle.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(405, 30);
			this.textBoxTitle.TabIndex = 4;
			//
			// labelEmail
			//
			this.labelEmail.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(3, 87);
			this.labelEmail.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(39, 16);
			this.labelEmail.TabIndex = 5;
			this.labelEmail.Text = "Email:";
			//
			// textBoxEmail
			//
			this.textBoxEmail.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.tableFields.SetColumnSpan(this.textBoxEmail, 3);
			this.textBoxEmail.Location = new System.Drawing.Point(73, 80);
			this.textBoxEmail.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(405, 30);
			this.textBoxEmail.TabIndex = 6;
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// labelPhone
			//
			this.labelPhone.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(3, 125);
			this.labelPhone.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(44, 16);
			this.labelPhone.TabIndex = 7;
			this.labelPhone.Text = "Phone:";
			//
			// textBoxPhone
			//
			this.textBoxPhone.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.tableFields.SetColumnSpan(this.textBoxPhone, 3);
			this.textBoxPhone.Location = new System.Drawing.Point(73, 118);
			this.textBoxPhone.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(405, 30);
			this.textBoxPhone.TabIndex = 8;
			//
			// labelCompany
			//
			this.labelCompany.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelCompany.AutoSize = true;
			this.labelCompany.Location = new System.Drawing.Point(3, 163);
			this.labelCompany.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelCompany.Name = "labelCompany";
			this.labelCompany.Size = new System.Drawing.Size(61, 16);
			this.labelCompany.TabIndex = 9;
			this.labelCompany.Text = "Company:";
			//
			// comboBoxCompany
			//
			this.comboBoxCompany.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.tableFields.SetColumnSpan(this.comboBoxCompany, 3);
			this.comboBoxCompany.DisplayMember = "Text";
			this.comboBoxCompany.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxCompany.Location = new System.Drawing.Point(73, 156);
			this.comboBoxCompany.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxCompany.Name = "comboBoxCompany";
			this.comboBoxCompany.Size = new System.Drawing.Size(405, 30);
			this.comboBoxCompany.TabIndex = 10;
			this.comboBoxCompany.ValueMember = "Id";
			//
			// labelStage
			//
			this.labelStage.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelStage.AutoSize = true;
			this.labelStage.Location = new System.Drawing.Point(3, 201);
			this.labelStage.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelStage.Name = "labelStage";
			this.labelStage.Size = new System.Drawing.Size(40, 16);
			this.labelStage.TabIndex = 11;
			this.labelStage.Text = "Stage:";
			//
			// comboBoxStage
			//
			this.comboBoxStage.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxStage.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxStage.Location = new System.Drawing.Point(73, 194);
			this.comboBoxStage.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxStage.Name = "comboBoxStage";
			this.comboBoxStage.Size = new System.Drawing.Size(196, 30);
			this.comboBoxStage.TabIndex = 12;
			//
			// comboBoxLeadSource
			//
			this.comboBoxLeadSource.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxLeadSource.Location = new System.Drawing.Point(281, 194);
			this.comboBoxLeadSource.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxLeadSource.Name = "comboBoxLeadSource";
			this.comboBoxLeadSource.Size = new System.Drawing.Size(197, 30);
			this.comboBoxLeadSource.TabIndex = 13;
			this.comboBoxLeadSource.ToolTipText = "Lead source";
			//
			// labelOwner
			//
			this.labelOwner.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelOwner.AutoSize = true;
			this.labelOwner.Location = new System.Drawing.Point(3, 239);
			this.labelOwner.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Size = new System.Drawing.Size(44, 16);
			this.labelOwner.TabIndex = 14;
			this.labelOwner.Text = "Owner:";
			//
			// comboBoxOwner
			//
			this.comboBoxOwner.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.tableFields.SetColumnSpan(this.comboBoxOwner, 3);
			this.comboBoxOwner.DisplayMember = "Name";
			this.comboBoxOwner.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOwner.Location = new System.Drawing.Point(73, 232);
			this.comboBoxOwner.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxOwner.Name = "comboBoxOwner";
			this.comboBoxOwner.Size = new System.Drawing.Size(405, 30);
			this.comboBoxOwner.TabIndex = 15;
			this.comboBoxOwner.ValueMember = "Id";
			//
			// labelTags
			//
			this.labelTags.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelTags.AutoSize = true;
			this.labelTags.Location = new System.Drawing.Point(3, 277);
			this.labelTags.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelTags.Name = "labelTags";
			this.labelTags.Size = new System.Drawing.Size(35, 16);
			this.labelTags.TabIndex = 16;
			this.labelTags.Text = "Tags:";
			//
			// textBoxTags
			//
			this.textBoxTags.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.tableFields.SetColumnSpan(this.textBoxTags, 3);
			this.textBoxTags.Location = new System.Drawing.Point(73, 270);
			this.textBoxTags.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxTags.Name = "textBoxTags";
			this.textBoxTags.Size = new System.Drawing.Size(405, 30);
			this.textBoxTags.TabIndex = 17;
			this.textBoxTags.ToolTipText = "Comma separated";
			//
			// labelTagsHint
			//
			this.tableFields.SetColumnSpan(this.labelTagsHint, 3);
			this.labelTagsHint.Dock = Wisej.Web.DockStyle.Fill;
			this.labelTagsHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelTagsHint.Location = new System.Drawing.Point(73, 307);
			this.labelTagsHint.Margin = new Wisej.Web.Padding(0, 3, 0, 0);
			this.labelTagsHint.Name = "labelTagsHint";
			this.labelTagsHint.Size = new System.Drawing.Size(405, 37);
			this.labelTagsHint.TabIndex = 18;
			//
			// labelError
			//
			this.labelError.Dock = Wisej.Web.DockStyle.Top;
			this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
			this.labelError.Location = new System.Drawing.Point(14, 358);
			this.labelError.Name = "labelError";
			this.labelError.Padding = new Wisej.Web.Padding(0, 10, 0, 0);
			this.labelError.Size = new System.Drawing.Size(478, 34);
			this.labelError.TabIndex = 1;
			this.labelError.Visible = false;
			//
			// flowButtons
			//
			this.flowButtons.Controls.Add(this.buttonCancel);
			this.flowButtons.Controls.Add(this.buttonSave);
			this.flowButtons.Dock = Wisej.Web.DockStyle.Top;
			this.flowButtons.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowButtons.Location = new System.Drawing.Point(14, 392);
			this.flowButtons.Name = "flowButtons";
			this.flowButtons.Padding = new Wisej.Web.Padding(0, 14, 0, 0);
			this.flowButtons.Size = new System.Drawing.Size(478, 48);
			this.flowButtons.TabIndex = 2;
			this.flowButtons.TabStop = true;
			//
			// buttonCancel
			//
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(390, 14);
			this.buttonCancel.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 30);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			//
			// buttonSave
			//
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Location = new System.Drawing.Point(294, 14);
			this.buttonSave.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 30);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// ContactEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(506, 454);
			this.Controls.Add(this.flowButtons);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.tableFields);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ContactEditDialog";
			this.Padding = new Wisej.Web.Padding(14);
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Contact";
			this.tableFields.ResumeLayout(false);
			this.tableFields.PerformLayout();
			this.flowButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.TableLayoutPanel tableFields;
		private Wisej.Web.Label labelName;
		private Wisej.Web.TextBox textBoxFirstName;
		private Wisej.Web.TextBox textBoxLastName;
		private Wisej.Web.Label labelJobTitle;
		private Wisej.Web.TextBox textBoxTitle;
		private Wisej.Web.Label labelEmail;
		private Wisej.Web.TextBox textBoxEmail;
		private Wisej.Web.Label labelPhone;
		private Wisej.Web.TextBox textBoxPhone;
		private Wisej.Web.Label labelCompany;
		private Wisej.Web.ComboBox comboBoxCompany;
		private Wisej.Web.Label labelStage;
		private Wisej.Web.ComboBox comboBoxStage;
		private Wisej.Web.ComboBox comboBoxLeadSource;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.ComboBox comboBoxOwner;
		private Wisej.Web.Label labelTags;
		private Wisej.Web.TextBox textBoxTags;
		private Wisej.Web.Label labelTagsHint;
		private Wisej.Web.Label labelError;
		private Wisej.Web.FlowLayoutPanel flowButtons;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Button buttonSave;
	}
}
