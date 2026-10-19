namespace RelayCrm.Dialogs
{
	partial class DealEditDialog
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
			this.labelTitle = new System.Windows.Forms.Label();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.labelCompany = new System.Windows.Forms.Label();
			this.comboBoxCompany = new System.Windows.Forms.ComboBox();
			this.labelContact = new System.Windows.Forms.Label();
			this.comboBoxContact = new System.Windows.Forms.ComboBox();
			this.labelAmount = new System.Windows.Forms.Label();
			this.numericAmount = new System.Windows.Forms.NumericUpDown();
			this.labelStage = new System.Windows.Forms.Label();
			this.comboBoxStage = new System.Windows.Forms.ComboBox();
			this.labelClose = new System.Windows.Forms.Label();
			this.dateTimePickerClose = new System.Windows.Forms.DateTimePicker();
			this.labelOwner = new System.Windows.Forms.Label();
			this.comboBoxOwner = new System.Windows.Forms.ComboBox();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			//
			// labelTitle
			//
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(12, 15);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(78, 15);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Deal &title:";
			//
			// textBoxTitle
			//
			this.textBoxTitle.Location = new System.Drawing.Point(120, 12);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(312, 23);
			this.textBoxTitle.TabIndex = 1;
			this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
			//
			// labelCompany
			//
			this.labelCompany.AutoSize = true;
			this.labelCompany.Location = new System.Drawing.Point(12, 44);
			this.labelCompany.Name = "labelCompany";
			this.labelCompany.Size = new System.Drawing.Size(60, 15);
			this.labelCompany.TabIndex = 2;
			this.labelCompany.Text = "&Company:";
			//
			// comboBoxCompany
			//
			this.comboBoxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCompany.FormattingEnabled = true;
			this.comboBoxCompany.Location = new System.Drawing.Point(120, 41);
			this.comboBoxCompany.Name = "comboBoxCompany";
			this.comboBoxCompany.Size = new System.Drawing.Size(312, 23);
			this.comboBoxCompany.TabIndex = 3;
			this.comboBoxCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompany_SelectedIndexChanged);
			//
			// labelContact
			//
			this.labelContact.AutoSize = true;
			this.labelContact.Location = new System.Drawing.Point(12, 73);
			this.labelContact.Name = "labelContact";
			this.labelContact.Size = new System.Drawing.Size(108, 15);
			this.labelContact.TabIndex = 4;
			this.labelContact.Text = "Primary c&ontact:";
			//
			// comboBoxContact
			//
			this.comboBoxContact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxContact.FormattingEnabled = true;
			this.comboBoxContact.Location = new System.Drawing.Point(120, 70);
			this.comboBoxContact.Name = "comboBoxContact";
			this.comboBoxContact.Size = new System.Drawing.Size(312, 23);
			this.comboBoxContact.TabIndex = 5;
			//
			// labelAmount
			//
			this.labelAmount.AutoSize = true;
			this.labelAmount.Location = new System.Drawing.Point(12, 102);
			this.labelAmount.Name = "labelAmount";
			this.labelAmount.Size = new System.Drawing.Size(90, 15);
			this.labelAmount.TabIndex = 6;
			this.labelAmount.Text = "&Amount (USD):";
			//
			// numericAmount
			//
			this.numericAmount.Increment = new decimal(new int[] {
			1000,
			0,
			0,
			0});
			this.numericAmount.Maximum = new decimal(new int[] {
			100000000,
			0,
			0,
			0});
			this.numericAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numericAmount.ThousandsSeparator = true;
			this.numericAmount.Location = new System.Drawing.Point(120, 99);
			this.numericAmount.Name = "numericAmount";
			this.numericAmount.Size = new System.Drawing.Size(150, 23);
			this.numericAmount.TabIndex = 7;
			this.numericAmount.ValueChanged += new System.EventHandler(this.numericAmount_ValueChanged);
			//
			// labelStage
			//
			this.labelStage.AutoSize = true;
			this.labelStage.Location = new System.Drawing.Point(12, 131);
			this.labelStage.Name = "labelStage";
			this.labelStage.Size = new System.Drawing.Size(48, 15);
			this.labelStage.TabIndex = 8;
			this.labelStage.Text = "&Stage:";
			//
			// comboBoxStage
			//
			this.comboBoxStage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStage.FormattingEnabled = true;
			this.comboBoxStage.Location = new System.Drawing.Point(120, 128);
			this.comboBoxStage.Name = "comboBoxStage";
			this.comboBoxStage.Size = new System.Drawing.Size(180, 23);
			this.comboBoxStage.TabIndex = 9;
			//
			// labelClose
			//
			this.labelClose.AutoSize = true;
			this.labelClose.Location = new System.Drawing.Point(12, 160);
			this.labelClose.Name = "labelClose";
			this.labelClose.Size = new System.Drawing.Size(102, 15);
			this.labelClose.TabIndex = 10;
			this.labelClose.Text = "&Expected close:";
			//
			// dateTimePickerClose
			//
			this.dateTimePickerClose.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerClose.Location = new System.Drawing.Point(120, 157);
			this.dateTimePickerClose.Name = "dateTimePickerClose";
			this.dateTimePickerClose.Size = new System.Drawing.Size(150, 23);
			this.dateTimePickerClose.TabIndex = 11;
			//
			// labelOwner
			//
			this.labelOwner.AutoSize = true;
			this.labelOwner.Location = new System.Drawing.Point(12, 189);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Size = new System.Drawing.Size(48, 15);
			this.labelOwner.TabIndex = 12;
			this.labelOwner.Text = "O&wner:";
			//
			// comboBoxOwner
			//
			this.comboBoxOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxOwner.FormattingEnabled = true;
			this.comboBoxOwner.Location = new System.Drawing.Point(120, 186);
			this.comboBoxOwner.Name = "comboBoxOwner";
			this.comboBoxOwner.Size = new System.Drawing.Size(180, 23);
			this.comboBoxOwner.TabIndex = 13;
			//
			// buttonSave
			//
			this.buttonSave.Location = new System.Drawing.Point(256, 225);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(92, 27);
			this.buttonSave.TabIndex = 14;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(356, 225);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 15;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// DealEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(460, 264);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.comboBoxOwner);
			this.Controls.Add(this.labelOwner);
			this.Controls.Add(this.dateTimePickerClose);
			this.Controls.Add(this.labelClose);
			this.Controls.Add(this.comboBoxStage);
			this.Controls.Add(this.labelStage);
			this.Controls.Add(this.numericAmount);
			this.Controls.Add(this.labelAmount);
			this.Controls.Add(this.comboBoxContact);
			this.Controls.Add(this.labelContact);
			this.Controls.Add(this.comboBoxCompany);
			this.Controls.Add(this.labelCompany);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.labelTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DealEditDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Deal";
			((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Label labelCompany;
		private System.Windows.Forms.ComboBox comboBoxCompany;
		private System.Windows.Forms.Label labelContact;
		private System.Windows.Forms.ComboBox comboBoxContact;
		private System.Windows.Forms.Label labelAmount;
		private System.Windows.Forms.NumericUpDown numericAmount;
		private System.Windows.Forms.Label labelStage;
		private System.Windows.Forms.ComboBox comboBoxStage;
		private System.Windows.Forms.Label labelClose;
		private System.Windows.Forms.DateTimePicker dateTimePickerClose;
		private System.Windows.Forms.Label labelOwner;
		private System.Windows.Forms.ComboBox comboBoxOwner;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
