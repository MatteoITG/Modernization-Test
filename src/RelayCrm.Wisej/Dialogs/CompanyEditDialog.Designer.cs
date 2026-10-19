namespace RelayCrm.Dialogs
{
	partial class CompanyEditDialog
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
			this.labelName = new Wisej.Web.Label();
			this.textBoxName = new Wisej.Web.TextBox();
			this.labelNameWarning = new Wisej.Web.Label();
			this.labelIndustry = new Wisej.Web.Label();
			this.comboIndustry = new Wisej.Web.ComboBox();
			this.labelSize = new Wisej.Web.Label();
			this.comboSize = new Wisej.Web.ComboBox();
			this.labelWebsite = new Wisej.Web.Label();
			this.textBoxWebsite = new Wisej.Web.TextBox();
			this.labelPhone = new Wisej.Web.Label();
			this.textBoxPhone = new Wisej.Web.TextBox();
			this.labelAddress = new Wisej.Web.Label();
			this.textBoxAddress = new Wisej.Web.TextBox();
			this.labelCity = new Wisej.Web.Label();
			this.textBoxCity = new Wisej.Web.TextBox();
			this.labelCountry = new Wisej.Web.Label();
			this.textBoxCountry = new Wisej.Web.TextBox();
			this.labelRevenue = new Wisej.Web.Label();
			this.numericRevenue = new Wisej.Web.NumericUpDown();
			this.labelOwner = new Wisej.Web.Label();
			this.comboOwner = new Wisej.Web.ComboBox();
			this.labelTags = new Wisej.Web.Label();
			this.checkedListTags = new Wisej.Web.CheckedListBox();
			this.buttonCancel = new Wisej.Web.Button();
			this.buttonSave = new Wisej.Web.Button();
			this.errorProvider = new Wisej.Web.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numericRevenue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			//
			// labelName
			//
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(12, 15);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(42, 15);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "&Name:";
			//
			// textBoxName
			//
			this.textBoxName.Location = new System.Drawing.Point(130, 12);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(302, 23);
			this.textBoxName.TabIndex = 1;
			this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
			//
			// labelNameWarning
			//
			this.labelNameWarning.AutoEllipsis = true;
			this.labelNameWarning.ForeColor = System.Drawing.Color.Firebrick;
			this.labelNameWarning.Location = new System.Drawing.Point(130, 37);
			this.labelNameWarning.Name = "labelNameWarning";
			this.labelNameWarning.Size = new System.Drawing.Size(314, 18);
			this.labelNameWarning.TabIndex = 2;
			this.labelNameWarning.Text = "A company with this name already exists.";
			this.labelNameWarning.Visible = false;
			//
			// labelIndustry
			//
			this.labelIndustry.AutoSize = true;
			this.labelIndustry.Location = new System.Drawing.Point(12, 64);
			this.labelIndustry.Name = "labelIndustry";
			this.labelIndustry.Size = new System.Drawing.Size(66, 15);
			this.labelIndustry.TabIndex = 3;
			this.labelIndustry.Text = "&Industry:";
			//
			// comboIndustry
			//
			this.comboIndustry.FormattingEnabled = true;
			this.comboIndustry.Location = new System.Drawing.Point(130, 61);
			this.comboIndustry.Name = "comboIndustry";
			this.comboIndustry.Size = new System.Drawing.Size(200, 23);
			this.comboIndustry.TabIndex = 4;
			//
			// labelSize
			//
			this.labelSize.AutoSize = true;
			this.labelSize.Location = new System.Drawing.Point(12, 93);
			this.labelSize.Name = "labelSize";
			this.labelSize.Size = new System.Drawing.Size(114, 15);
			this.labelSize.TabIndex = 5;
			this.labelSize.Text = "Si&ze (employees):";
			//
			// comboSize
			//
			this.comboSize.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboSize.FormattingEnabled = true;
			this.comboSize.Location = new System.Drawing.Point(130, 90);
			this.comboSize.Name = "comboSize";
			this.comboSize.Size = new System.Drawing.Size(120, 23);
			this.comboSize.TabIndex = 6;
			//
			// labelWebsite
			//
			this.labelWebsite.AutoSize = true;
			this.labelWebsite.Location = new System.Drawing.Point(12, 122);
			this.labelWebsite.Name = "labelWebsite";
			this.labelWebsite.Size = new System.Drawing.Size(60, 15);
			this.labelWebsite.TabIndex = 7;
			this.labelWebsite.Text = "&Website:";
			//
			// textBoxWebsite
			//
			this.textBoxWebsite.Location = new System.Drawing.Point(130, 119);
			this.textBoxWebsite.Name = "textBoxWebsite";
			this.textBoxWebsite.Size = new System.Drawing.Size(302, 23);
			this.textBoxWebsite.TabIndex = 8;
			//
			// labelPhone
			//
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(12, 151);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(48, 15);
			this.labelPhone.TabIndex = 9;
			this.labelPhone.Text = "&Phone:";
			//
			// textBoxPhone
			//
			this.textBoxPhone.Location = new System.Drawing.Point(130, 148);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(180, 23);
			this.textBoxPhone.TabIndex = 10;
			//
			// labelAddress
			//
			this.labelAddress.AutoSize = true;
			this.labelAddress.Location = new System.Drawing.Point(12, 180);
			this.labelAddress.Name = "labelAddress";
			this.labelAddress.Size = new System.Drawing.Size(60, 15);
			this.labelAddress.TabIndex = 11;
			this.labelAddress.Text = "&Address:";
			//
			// textBoxAddress
			//
			this.textBoxAddress.Location = new System.Drawing.Point(130, 177);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(302, 23);
			this.textBoxAddress.TabIndex = 12;
			//
			// labelCity
			//
			this.labelCity.AutoSize = true;
			this.labelCity.Location = new System.Drawing.Point(12, 209);
			this.labelCity.Name = "labelCity";
			this.labelCity.Size = new System.Drawing.Size(42, 15);
			this.labelCity.TabIndex = 13;
			this.labelCity.Text = "&City:";
			//
			// textBoxCity
			//
			this.textBoxCity.Location = new System.Drawing.Point(130, 206);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(180, 23);
			this.textBoxCity.TabIndex = 14;
			//
			// labelCountry
			//
			this.labelCountry.AutoSize = true;
			this.labelCountry.Location = new System.Drawing.Point(12, 238);
			this.labelCountry.Name = "labelCountry";
			this.labelCountry.Size = new System.Drawing.Size(60, 15);
			this.labelCountry.TabIndex = 15;
			this.labelCountry.Text = "Co&untry:";
			//
			// textBoxCountry
			//
			this.textBoxCountry.Location = new System.Drawing.Point(130, 235);
			this.textBoxCountry.Name = "textBoxCountry";
			this.textBoxCountry.Size = new System.Drawing.Size(180, 23);
			this.textBoxCountry.TabIndex = 16;
			//
			// labelRevenue
			//
			this.labelRevenue.AutoSize = true;
			this.labelRevenue.Location = new System.Drawing.Point(12, 267);
			this.labelRevenue.Name = "labelRevenue";
			this.labelRevenue.Size = new System.Drawing.Size(126, 15);
			this.labelRevenue.TabIndex = 17;
			this.labelRevenue.Text = "Annual &revenue ($):";
			//
			// numericRevenue
			//
			this.numericRevenue.Increment = new decimal(new int[] {
			10000,
			0,
			0,
			0});
			this.numericRevenue.Maximum = new decimal(new int[] {
			2000000000,
			0,
			0,
			0});
			this.numericRevenue.TextAlign = Wisej.Web.HorizontalAlignment.Right;
			this.numericRevenue.ThousandsSeparator = true;
			this.numericRevenue.Location = new System.Drawing.Point(130, 264);
			this.numericRevenue.Name = "numericRevenue";
			this.numericRevenue.Size = new System.Drawing.Size(150, 23);
			this.numericRevenue.TabIndex = 18;
			//
			// labelOwner
			//
			this.labelOwner.AutoSize = true;
			this.labelOwner.Location = new System.Drawing.Point(12, 296);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Size = new System.Drawing.Size(48, 15);
			this.labelOwner.TabIndex = 19;
			this.labelOwner.Text = "&Owner:";
			//
			// comboOwner
			//
			this.comboOwner.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboOwner.FormattingEnabled = true;
			this.comboOwner.Location = new System.Drawing.Point(130, 293);
			this.comboOwner.Name = "comboOwner";
			this.comboOwner.Size = new System.Drawing.Size(180, 23);
			this.comboOwner.TabIndex = 20;
			//
			// labelTags
			//
			this.labelTags.AutoSize = true;
			this.labelTags.Location = new System.Drawing.Point(12, 325);
			this.labelTags.Name = "labelTags";
			this.labelTags.Size = new System.Drawing.Size(42, 15);
			this.labelTags.TabIndex = 21;
			this.labelTags.Text = "&Tags:";
			//
			// checkedListTags
			//
			this.checkedListTags.CheckOnClick = true;
			this.checkedListTags.FormattingEnabled = true;
			this.checkedListTags.Location = new System.Drawing.Point(130, 322);
			this.checkedListTags.Name = "checkedListTags";
			this.checkedListTags.Size = new System.Drawing.Size(302, 80);
			this.checkedListTags.TabIndex = 22;
			//
			// buttonSave
			//
			this.buttonSave.Location = new System.Drawing.Point(256, 418);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(92, 27);
			this.buttonSave.TabIndex = 23;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(356, 418);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 24;
			this.buttonCancel.Text = "Cancel";
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = Wisej.Web.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// CompanyEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(460, 457);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.checkedListTags);
			this.Controls.Add(this.labelTags);
			this.Controls.Add(this.comboOwner);
			this.Controls.Add(this.labelOwner);
			this.Controls.Add(this.numericRevenue);
			this.Controls.Add(this.labelRevenue);
			this.Controls.Add(this.textBoxCountry);
			this.Controls.Add(this.labelCountry);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.labelCity);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.labelAddress);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.textBoxWebsite);
			this.Controls.Add(this.labelWebsite);
			this.Controls.Add(this.comboSize);
			this.Controls.Add(this.labelSize);
			this.Controls.Add(this.comboIndustry);
			this.Controls.Add(this.labelIndustry);
			this.Controls.Add(this.labelNameWarning);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.labelName);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CompanyEditDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "New company";
			((System.ComponentModel.ISupportInitialize)(this.numericRevenue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelName;
		private Wisej.Web.TextBox textBoxName;
		private Wisej.Web.Label labelNameWarning;
		private Wisej.Web.Label labelIndustry;
		private Wisej.Web.ComboBox comboIndustry;
		private Wisej.Web.Label labelSize;
		private Wisej.Web.ComboBox comboSize;
		private Wisej.Web.Label labelWebsite;
		private Wisej.Web.TextBox textBoxWebsite;
		private Wisej.Web.Label labelPhone;
		private Wisej.Web.TextBox textBoxPhone;
		private Wisej.Web.Label labelAddress;
		private Wisej.Web.TextBox textBoxAddress;
		private Wisej.Web.Label labelCity;
		private Wisej.Web.TextBox textBoxCity;
		private Wisej.Web.Label labelCountry;
		private Wisej.Web.TextBox textBoxCountry;
		private Wisej.Web.Label labelRevenue;
		private Wisej.Web.NumericUpDown numericRevenue;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.ComboBox comboOwner;
		private Wisej.Web.Label labelTags;
		private Wisej.Web.CheckedListBox checkedListTags;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.ErrorProvider errorProvider;
	}
}
