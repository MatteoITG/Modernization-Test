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
			this.labelName = new System.Windows.Forms.Label();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.labelNameWarning = new System.Windows.Forms.Label();
			this.labelIndustry = new System.Windows.Forms.Label();
			this.comboIndustry = new System.Windows.Forms.ComboBox();
			this.labelSize = new System.Windows.Forms.Label();
			this.comboSize = new System.Windows.Forms.ComboBox();
			this.labelWebsite = new System.Windows.Forms.Label();
			this.textBoxWebsite = new System.Windows.Forms.TextBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.textBoxPhone = new System.Windows.Forms.TextBox();
			this.labelAddress = new System.Windows.Forms.Label();
			this.textBoxAddress = new System.Windows.Forms.TextBox();
			this.labelCity = new System.Windows.Forms.Label();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.labelCountry = new System.Windows.Forms.Label();
			this.textBoxCountry = new System.Windows.Forms.TextBox();
			this.labelRevenue = new System.Windows.Forms.Label();
			this.numericRevenue = new System.Windows.Forms.NumericUpDown();
			this.labelOwner = new System.Windows.Forms.Label();
			this.comboOwner = new System.Windows.Forms.ComboBox();
			this.labelTags = new System.Windows.Forms.Label();
			this.checkedListTags = new System.Windows.Forms.CheckedListBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
			this.comboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
			this.numericRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			this.comboOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
			this.checkedListTags.MultiColumn = true;
			this.checkedListTags.ColumnWidth = 110;
			this.checkedListTags.IntegralHeight = false;
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
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(356, 418);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 24;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// CompanyEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CompanyEditDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New company";
			((System.ComponentModel.ISupportInitialize)(this.numericRevenue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label labelNameWarning;
		private System.Windows.Forms.Label labelIndustry;
		private System.Windows.Forms.ComboBox comboIndustry;
		private System.Windows.Forms.Label labelSize;
		private System.Windows.Forms.ComboBox comboSize;
		private System.Windows.Forms.Label labelWebsite;
		private System.Windows.Forms.TextBox textBoxWebsite;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.TextBox textBoxPhone;
		private System.Windows.Forms.Label labelAddress;
		private System.Windows.Forms.TextBox textBoxAddress;
		private System.Windows.Forms.Label labelCity;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.Label labelCountry;
		private System.Windows.Forms.TextBox textBoxCountry;
		private System.Windows.Forms.Label labelRevenue;
		private System.Windows.Forms.NumericUpDown numericRevenue;
		private System.Windows.Forms.Label labelOwner;
		private System.Windows.Forms.ComboBox comboOwner;
		private System.Windows.Forms.Label labelTags;
		private System.Windows.Forms.CheckedListBox checkedListTags;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
