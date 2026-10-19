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
			this.labelTitle = new Wisej.Web.Label();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.labelCompany = new Wisej.Web.Label();
			this.comboBoxCompany = new Wisej.Web.ComboBox();
			this.labelContact = new Wisej.Web.Label();
			this.comboBoxContact = new Wisej.Web.ComboBox();
			this.labelAmount = new Wisej.Web.Label();
			this.numericAmount = new Wisej.Web.NumericUpDown();
			this.labelStage = new Wisej.Web.Label();
			this.comboBoxStage = new Wisej.Web.ComboBox();
			this.labelClose = new Wisej.Web.Label();
			this.dateTimePickerClose = new Wisej.Web.DateTimePicker();
			this.labelOwner = new Wisej.Web.Label();
			this.comboBoxOwner = new Wisej.Web.ComboBox();
			this.buttonCancel = new Wisej.Web.Button();
			this.buttonSave = new Wisej.Web.Button();
			this.errorProvider = new Wisej.Web.ErrorProvider(this.components);
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
			this.comboBoxCompany.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
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
			this.comboBoxContact.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
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
			this.numericAmount.TextAlign = Wisej.Web.HorizontalAlignment.Right;
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
			this.comboBoxStage.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
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
			this.dateTimePickerClose.Format = Wisej.Web.DateTimePickerFormat.Short;
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
			this.comboBoxOwner.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOwner.FormattingEnabled = true;
			this.comboBoxOwner.Location = new System.Drawing.Point(120, 186);
			this.comboBoxOwner.Name = "comboBoxOwner";
			this.comboBoxOwner.Size = new System.Drawing.Size(180, 23);
			this.comboBoxOwner.TabIndex = 13;
			//
			// buttonSave
			//
			this.buttonSave.Location = new System.Drawing.Point(256, 225);
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(92, 27);
			this.buttonSave.TabIndex = 14;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(356, 225);
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 15;
			this.buttonCancel.Text = "Cancel";
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = Wisej.Web.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// DealEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
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
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DealEditDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Deal";
			((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelTitle;
		private Wisej.Web.TextBox textBoxTitle;
		private Wisej.Web.Label labelCompany;
		private Wisej.Web.ComboBox comboBoxCompany;
		private Wisej.Web.Label labelContact;
		private Wisej.Web.ComboBox comboBoxContact;
		private Wisej.Web.Label labelAmount;
		private Wisej.Web.NumericUpDown numericAmount;
		private Wisej.Web.Label labelStage;
		private Wisej.Web.ComboBox comboBoxStage;
		private Wisej.Web.Label labelClose;
		private Wisej.Web.DateTimePicker dateTimePickerClose;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.ComboBox comboBoxOwner;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.ErrorProvider errorProvider;
	}
}
