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
			this.textBoxFirstName = new Wisej.Web.TextBox();
			this.textBoxLastName = new Wisej.Web.TextBox();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.textBoxEmail = new Wisej.Web.TextBox();
			this.textBoxPhone = new Wisej.Web.TextBox();
			this.comboBoxCompany = new Wisej.Web.ComboBox();
			this.comboBoxStage = new Wisej.Web.ComboBox();
			this.comboBoxLeadSource = new Wisej.Web.ComboBox();
			this.comboBoxOwner = new Wisej.Web.ComboBox();
			this.textBoxTags = new Wisej.Web.TextBox();
			this.labelTagsHint = new Wisej.Web.Label();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.SuspendLayout();
			//
			// textBoxFirstName
			//
			this.textBoxFirstName.LabelText = "First name";
			this.textBoxFirstName.Location = new System.Drawing.Point(24, 24);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(248, 56);
			this.textBoxFirstName.TabIndex = 0;
			this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			//
			// textBoxLastName
			//
			this.textBoxLastName.LabelText = "Last name";
			this.textBoxLastName.Location = new System.Drawing.Point(288, 24);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(248, 56);
			this.textBoxLastName.TabIndex = 1;
			this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			//
			// textBoxTitle
			//
			this.textBoxTitle.LabelText = "Job title";
			this.textBoxTitle.Location = new System.Drawing.Point(24, 92);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(512, 56);
			this.textBoxTitle.TabIndex = 2;
			//
			// textBoxEmail
			//
			this.textBoxEmail.LabelText = "Email";
			this.textBoxEmail.Location = new System.Drawing.Point(24, 160);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(248, 56);
			this.textBoxEmail.TabIndex = 3;
			this.textBoxEmail.Watermark = "name@company.com";
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
			//
			// textBoxPhone
			//
			this.textBoxPhone.LabelText = "Phone";
			this.textBoxPhone.Location = new System.Drawing.Point(288, 160);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(248, 56);
			this.textBoxPhone.TabIndex = 4;
			//
			// comboBoxCompany
			//
			this.comboBoxCompany.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxCompany.LabelText = "Company";
			this.comboBoxCompany.Location = new System.Drawing.Point(24, 228);
			this.comboBoxCompany.Name = "comboBoxCompany";
			this.comboBoxCompany.Size = new System.Drawing.Size(512, 56);
			this.comboBoxCompany.TabIndex = 5;
			//
			// comboBoxStage
			//
			this.comboBoxStage.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxStage.Items.AddRange(new object[] {
            "Lead",
            "Prospect",
            "Customer",
            "Churned"});
			this.comboBoxStage.LabelText = "Lifecycle stage";
			this.comboBoxStage.Location = new System.Drawing.Point(24, 296);
			this.comboBoxStage.Name = "comboBoxStage";
			this.comboBoxStage.Size = new System.Drawing.Size(248, 56);
			this.comboBoxStage.TabIndex = 6;
			//
			// comboBoxLeadSource
			//
			this.comboBoxLeadSource.LabelText = "Lead source";
			this.comboBoxLeadSource.Location = new System.Drawing.Point(288, 296);
			this.comboBoxLeadSource.Name = "comboBoxLeadSource";
			this.comboBoxLeadSource.Size = new System.Drawing.Size(248, 56);
			this.comboBoxLeadSource.TabIndex = 7;
			//
			// comboBoxOwner
			//
			this.comboBoxOwner.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOwner.LabelText = "Owner";
			this.comboBoxOwner.Location = new System.Drawing.Point(24, 364);
			this.comboBoxOwner.Name = "comboBoxOwner";
			this.comboBoxOwner.Size = new System.Drawing.Size(248, 56);
			this.comboBoxOwner.TabIndex = 8;
			//
			// textBoxTags
			//
			this.textBoxTags.LabelText = "Tags";
			this.textBoxTags.Location = new System.Drawing.Point(24, 432);
			this.textBoxTags.Name = "textBoxTags";
			this.textBoxTags.Size = new System.Drawing.Size(512, 56);
			this.textBoxTags.TabIndex = 9;
			this.textBoxTags.Watermark = "Comma separated, e.g. VIP, Newsletter";
			//
			// labelTagsHint
			//
			this.labelTagsHint.CssClass = "relay-muted";
			this.labelTagsHint.Location = new System.Drawing.Point(24, 494);
			this.labelTagsHint.Name = "labelTagsHint";
			this.labelTagsHint.Size = new System.Drawing.Size(512, 36);
			this.labelTagsHint.TabIndex = 10;
			this.labelTagsHint.Text = "Existing tags:";
			//
			// buttonSave
			//
			this.buttonSave.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Location = new System.Drawing.Point(436, 548);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(100, 36);
			this.buttonSave.TabIndex = 11;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(328, 548);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 36);
			this.buttonCancel.TabIndex = 12;
			this.buttonCancel.Text = "Cancel";
			//
			// ContactEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(560, 608);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelTagsHint);
			this.Controls.Add(this.textBoxTags);
			this.Controls.Add(this.comboBoxOwner);
			this.Controls.Add(this.comboBoxLeadSource);
			this.Controls.Add(this.comboBoxStage);
			this.Controls.Add(this.comboBoxCompany);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.textBoxFirstName);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ContactEditDialog";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "New contact";
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.TextBox textBoxFirstName;
		private Wisej.Web.TextBox textBoxLastName;
		private Wisej.Web.TextBox textBoxTitle;
		private Wisej.Web.TextBox textBoxEmail;
		private Wisej.Web.TextBox textBoxPhone;
		private Wisej.Web.ComboBox comboBoxCompany;
		private Wisej.Web.ComboBox comboBoxStage;
		private Wisej.Web.ComboBox comboBoxLeadSource;
		private Wisej.Web.ComboBox comboBoxOwner;
		private Wisej.Web.TextBox textBoxTags;
		private Wisej.Web.Label labelTagsHint;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.Button buttonCancel;
	}
}
