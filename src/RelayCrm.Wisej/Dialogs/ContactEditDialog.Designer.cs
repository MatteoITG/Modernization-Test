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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.labelFirstName = new Wisej.Web.Label();
			this.textBoxFirstName = new Wisej.Web.TextBox();
			this.labelLastName = new Wisej.Web.Label();
			this.textBoxLastName = new Wisej.Web.TextBox();
			this.labelTitle = new Wisej.Web.Label();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.labelEmail = new Wisej.Web.Label();
			this.textBoxEmail = new Wisej.Web.TextBox();
			this.labelPhone = new Wisej.Web.Label();
			this.textBoxPhone = new Wisej.Web.TextBox();
			this.labelCompany = new Wisej.Web.Label();
			this.comboBoxCompany = new Wisej.Web.ComboBox();
			this.labelStage = new Wisej.Web.Label();
			this.comboBoxStage = new Wisej.Web.ComboBox();
			this.labelLeadSource = new Wisej.Web.Label();
			this.comboBoxLeadSource = new Wisej.Web.ComboBox();
			this.labelOwner = new Wisej.Web.Label();
			this.comboBoxOwner = new Wisej.Web.ComboBox();
			this.labelTags = new Wisej.Web.Label();
			this.textBoxTags = new Wisej.Web.TextBox();
			this.labelTagsHint = new Wisej.Web.Label();
			this.buttonCancel = new Wisej.Web.Button();
			this.buttonSave = new Wisej.Web.Button();
			this.errorProvider = new Wisej.Web.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			//
			// labelFirstName
			//
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Location = new System.Drawing.Point(12, 15);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(78, 15);
			this.labelFirstName.TabIndex = 0;
			this.labelFirstName.Text = "&First name:";
			//
			// textBoxFirstName
			//
			this.textBoxFirstName.Location = new System.Drawing.Point(110, 12);
			this.textBoxFirstName.Name = "textBoxFirstName";
			this.textBoxFirstName.Size = new System.Drawing.Size(302, 23);
			this.textBoxFirstName.TabIndex = 1;
			this.textBoxFirstName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			//
			// labelLastName
			//
			this.labelLastName.AutoSize = true;
			this.labelLastName.Location = new System.Drawing.Point(12, 44);
			this.labelLastName.Name = "labelLastName";
			this.labelLastName.Size = new System.Drawing.Size(72, 15);
			this.labelLastName.TabIndex = 2;
			this.labelLastName.Text = "&Last name:";
			//
			// textBoxLastName
			//
			this.textBoxLastName.Location = new System.Drawing.Point(110, 41);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(302, 23);
			this.textBoxLastName.TabIndex = 3;
			this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			//
			// labelTitle
			//
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(12, 73);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(72, 15);
			this.labelTitle.TabIndex = 4;
			this.labelTitle.Text = "&Job title:";
			//
			// textBoxTitle
			//
			this.textBoxTitle.Location = new System.Drawing.Point(110, 70);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(302, 23);
			this.textBoxTitle.TabIndex = 5;
			//
			// labelEmail
			//
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(12, 102);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(48, 15);
			this.labelEmail.TabIndex = 6;
			this.labelEmail.Text = "&Email:";
			//
			// textBoxEmail
			//
			this.textBoxEmail.Location = new System.Drawing.Point(110, 99);
			this.textBoxEmail.Name = "textBoxEmail";
			this.textBoxEmail.Size = new System.Drawing.Size(302, 23);
			this.textBoxEmail.TabIndex = 7;
			this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
			//
			// labelPhone
			//
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(12, 131);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(48, 15);
			this.labelPhone.TabIndex = 8;
			this.labelPhone.Text = "&Phone:";
			//
			// textBoxPhone
			//
			this.textBoxPhone.Location = new System.Drawing.Point(110, 128);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(180, 23);
			this.textBoxPhone.TabIndex = 9;
			//
			// labelCompany
			//
			this.labelCompany.AutoSize = true;
			this.labelCompany.Location = new System.Drawing.Point(12, 160);
			this.labelCompany.Name = "labelCompany";
			this.labelCompany.Size = new System.Drawing.Size(60, 15);
			this.labelCompany.TabIndex = 10;
			this.labelCompany.Text = "&Company:";
			//
			// comboBoxCompany
			//
			this.comboBoxCompany.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxCompany.FormattingEnabled = true;
			this.comboBoxCompany.Location = new System.Drawing.Point(110, 157);
			this.comboBoxCompany.Name = "comboBoxCompany";
			this.comboBoxCompany.Size = new System.Drawing.Size(302, 23);
			this.comboBoxCompany.TabIndex = 11;
			//
			// labelStage
			//
			this.labelStage.AutoSize = true;
			this.labelStage.Location = new System.Drawing.Point(12, 189);
			this.labelStage.Name = "labelStage";
			this.labelStage.Size = new System.Drawing.Size(108, 15);
			this.labelStage.TabIndex = 12;
			this.labelStage.Text = "Lifecycle &stage:";
			//
			// comboBoxStage
			//
			this.comboBoxStage.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxStage.FormattingEnabled = true;
			this.comboBoxStage.Items.AddRange(new object[] {
			"Lead",
			"Prospect",
			"Customer",
			"Churned"});
			this.comboBoxStage.Location = new System.Drawing.Point(110, 186);
			this.comboBoxStage.Name = "comboBoxStage";
			this.comboBoxStage.Size = new System.Drawing.Size(180, 23);
			this.comboBoxStage.TabIndex = 13;
			//
			// labelLeadSource
			//
			this.labelLeadSource.AutoSize = true;
			this.labelLeadSource.Location = new System.Drawing.Point(12, 218);
			this.labelLeadSource.Name = "labelLeadSource";
			this.labelLeadSource.Size = new System.Drawing.Size(84, 15);
			this.labelLeadSource.TabIndex = 14;
			this.labelLeadSource.Text = "Lead s&ource:";
			//
			// comboBoxLeadSource
			//
			this.comboBoxLeadSource.FormattingEnabled = true;
			this.comboBoxLeadSource.Location = new System.Drawing.Point(110, 215);
			this.comboBoxLeadSource.Name = "comboBoxLeadSource";
			this.comboBoxLeadSource.Size = new System.Drawing.Size(180, 23);
			this.comboBoxLeadSource.TabIndex = 15;
			//
			// labelOwner
			//
			this.labelOwner.AutoSize = true;
			this.labelOwner.Location = new System.Drawing.Point(12, 247);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Size = new System.Drawing.Size(48, 15);
			this.labelOwner.TabIndex = 16;
			this.labelOwner.Text = "&Owner:";
			//
			// comboBoxOwner
			//
			this.comboBoxOwner.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOwner.FormattingEnabled = true;
			this.comboBoxOwner.Location = new System.Drawing.Point(110, 244);
			this.comboBoxOwner.Name = "comboBoxOwner";
			this.comboBoxOwner.Size = new System.Drawing.Size(180, 23);
			this.comboBoxOwner.TabIndex = 17;
			//
			// labelTags
			//
			this.labelTags.AutoSize = true;
			this.labelTags.Location = new System.Drawing.Point(12, 276);
			this.labelTags.Name = "labelTags";
			this.labelTags.Size = new System.Drawing.Size(42, 15);
			this.labelTags.TabIndex = 18;
			this.labelTags.Text = "&Tags:";
			//
			// textBoxTags
			//
			this.textBoxTags.Location = new System.Drawing.Point(110, 273);
			this.textBoxTags.Name = "textBoxTags";
			this.textBoxTags.Size = new System.Drawing.Size(302, 23);
			this.textBoxTags.TabIndex = 19;
			//
			// labelTagsHint
			//
			this.labelTagsHint.AutoEllipsis = true;
			this.labelTagsHint.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelTagsHint.Location = new System.Drawing.Point(110, 298);
			this.labelTagsHint.Name = "labelTagsHint";
			this.labelTagsHint.Size = new System.Drawing.Size(314, 32);
			this.labelTagsHint.TabIndex = 20;
			this.labelTagsHint.Text = "Separate tags with commas.";
			//
			// buttonSave
			//
			this.buttonSave.Location = new System.Drawing.Point(236, 346);
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(92, 27);
			this.buttonSave.TabIndex = 21;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(336, 346);
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 22;
			this.buttonCancel.Text = "Cancel";
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = Wisej.Web.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// ContactEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(440, 385);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.labelTagsHint);
			this.Controls.Add(this.textBoxTags);
			this.Controls.Add(this.labelTags);
			this.Controls.Add(this.comboBoxOwner);
			this.Controls.Add(this.labelOwner);
			this.Controls.Add(this.comboBoxLeadSource);
			this.Controls.Add(this.labelLeadSource);
			this.Controls.Add(this.comboBoxStage);
			this.Controls.Add(this.labelStage);
			this.Controls.Add(this.comboBoxCompany);
			this.Controls.Add(this.labelCompany);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.textBoxEmail);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.labelTitle);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.labelLastName);
			this.Controls.Add(this.textBoxFirstName);
			this.Controls.Add(this.labelFirstName);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ContactEditDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "New contact";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelFirstName;
		private Wisej.Web.TextBox textBoxFirstName;
		private Wisej.Web.Label labelLastName;
		private Wisej.Web.TextBox textBoxLastName;
		private Wisej.Web.Label labelTitle;
		private Wisej.Web.TextBox textBoxTitle;
		private Wisej.Web.Label labelEmail;
		private Wisej.Web.TextBox textBoxEmail;
		private Wisej.Web.Label labelPhone;
		private Wisej.Web.TextBox textBoxPhone;
		private Wisej.Web.Label labelCompany;
		private Wisej.Web.ComboBox comboBoxCompany;
		private Wisej.Web.Label labelStage;
		private Wisej.Web.ComboBox comboBoxStage;
		private Wisej.Web.Label labelLeadSource;
		private Wisej.Web.ComboBox comboBoxLeadSource;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.ComboBox comboBoxOwner;
		private Wisej.Web.Label labelTags;
		private Wisej.Web.TextBox textBoxTags;
		private Wisej.Web.Label labelTagsHint;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.ErrorProvider errorProvider;
	}
}
