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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.comboBoxCompany = new Wisej.Web.ComboBox();
			this.comboBoxContact = new Wisej.Web.ComboBox();
			this.numericAmount = new Wisej.Web.NumericUpDown();
			this.dateTimePickerClose = new Wisej.Web.DateTimePicker();
			this.comboBoxStage = new Wisej.Web.ComboBox();
			this.comboBoxOwner = new Wisej.Web.ComboBox();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericAmount)).BeginInit();
			this.SuspendLayout();
			//
			// textBoxTitle
			//
			this.textBoxTitle.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxTitle.LabelText = "Deal title";
			this.textBoxTitle.Location = new System.Drawing.Point(24, 24);
			this.textBoxTitle.MaxLength = 200;
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(512, 56);
			this.textBoxTitle.TabIndex = 0;
			this.textBoxTitle.Watermark = "e.g. Annual platform license";
			this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
			//
			// comboBoxCompany
			//
			this.comboBoxCompany.AutoCompleteMode = Wisej.Web.AutoCompleteMode.SuggestAppend;
			this.comboBoxCompany.LabelText = "Company";
			this.comboBoxCompany.Location = new System.Drawing.Point(24, 92);
			this.comboBoxCompany.Name = "comboBoxCompany";
			this.comboBoxCompany.Size = new System.Drawing.Size(248, 56);
			this.comboBoxCompany.TabIndex = 1;
			this.comboBoxCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompany_SelectedIndexChanged);
			//
			// comboBoxContact
			//
			this.comboBoxContact.AutoCompleteMode = Wisej.Web.AutoCompleteMode.SuggestAppend;
			this.comboBoxContact.LabelText = "Primary contact";
			this.comboBoxContact.Location = new System.Drawing.Point(288, 92);
			this.comboBoxContact.Name = "comboBoxContact";
			this.comboBoxContact.Size = new System.Drawing.Size(248, 56);
			this.comboBoxContact.TabIndex = 2;
			//
			// numericAmount
			//
			this.numericAmount.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericAmount.LabelText = "Amount (USD)";
			this.numericAmount.Location = new System.Drawing.Point(24, 160);
			this.numericAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.numericAmount.Name = "numericAmount";
			this.numericAmount.Size = new System.Drawing.Size(248, 56);
			this.numericAmount.TabIndex = 3;
			this.numericAmount.ThousandsSeparator = true;
			this.numericAmount.ValueChanged += new System.EventHandler(this.numericAmount_ValueChanged);
			//
			// dateTimePickerClose
			//
			this.dateTimePickerClose.CustomFormat = "MMM d, yyyy";
			this.dateTimePickerClose.Format = Wisej.Web.DateTimePickerFormat.Custom;
			this.dateTimePickerClose.LabelText = "Expected close";
			this.dateTimePickerClose.Location = new System.Drawing.Point(288, 160);
			this.dateTimePickerClose.Name = "dateTimePickerClose";
			this.dateTimePickerClose.Size = new System.Drawing.Size(248, 56);
			this.dateTimePickerClose.TabIndex = 4;
			//
			// comboBoxStage
			//
			this.comboBoxStage.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxStage.LabelText = "Stage";
			this.comboBoxStage.Location = new System.Drawing.Point(24, 228);
			this.comboBoxStage.Name = "comboBoxStage";
			this.comboBoxStage.Size = new System.Drawing.Size(248, 56);
			this.comboBoxStage.TabIndex = 5;
			//
			// comboBoxOwner
			//
			this.comboBoxOwner.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOwner.LabelText = "Owner";
			this.comboBoxOwner.Location = new System.Drawing.Point(288, 228);
			this.comboBoxOwner.Name = "comboBoxOwner";
			this.comboBoxOwner.Size = new System.Drawing.Size(248, 56);
			this.comboBoxOwner.TabIndex = 6;
			//
			// buttonSave
			//
			this.buttonSave.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Location = new System.Drawing.Point(416, 316);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(120, 36);
			this.buttonSave.TabIndex = 7;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(308, 316);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 36);
			this.buttonCancel.TabIndex = 8;
			this.buttonCancel.Text = "Cancel";
			//
			// DealEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(560, 376);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.comboBoxOwner);
			this.Controls.Add(this.comboBoxStage);
			this.Controls.Add(this.dateTimePickerClose);
			this.Controls.Add(this.numericAmount);
			this.Controls.Add(this.comboBoxContact);
			this.Controls.Add(this.comboBoxCompany);
			this.Controls.Add(this.textBoxTitle);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DealEditDialog";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Deal";
			((System.ComponentModel.ISupportInitialize)(this.numericAmount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.TextBox textBoxTitle;
		private Wisej.Web.ComboBox comboBoxCompany;
		private Wisej.Web.ComboBox comboBoxContact;
		private Wisej.Web.NumericUpDown numericAmount;
		private Wisej.Web.DateTimePicker dateTimePickerClose;
		private Wisej.Web.ComboBox comboBoxStage;
		private Wisej.Web.ComboBox comboBoxOwner;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.Button buttonCancel;
	}
}
