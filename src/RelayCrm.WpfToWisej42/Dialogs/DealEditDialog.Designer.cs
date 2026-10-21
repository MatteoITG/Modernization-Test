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
			this.tableFields = new Wisej.Web.TableLayoutPanel();
			this.labelTitle = new Wisej.Web.Label();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.labelCompany = new Wisej.Web.Label();
			this.comboBoxCompany = new Wisej.Web.ComboBox();
			this.labelContact = new Wisej.Web.Label();
			this.comboBoxContact = new Wisej.Web.ComboBox();
			this.labelAmount = new Wisej.Web.Label();
			this.textBoxAmount = new Wisej.Web.TextBox();
			this.labelStage = new Wisej.Web.Label();
			this.comboBoxStage = new Wisej.Web.ComboBox();
			this.labelClose = new Wisej.Web.Label();
			this.datePickerClose = new Wisej.Web.DateTimePicker();
			this.labelOwner = new Wisej.Web.Label();
			this.comboBoxOwner = new Wisej.Web.ComboBox();
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
			this.tableFields.ColumnCount = 2;
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableFields.Controls.Add(this.labelTitle, 0, 0);
			this.tableFields.Controls.Add(this.textBoxTitle, 1, 0);
			this.tableFields.Controls.Add(this.labelCompany, 0, 1);
			this.tableFields.Controls.Add(this.comboBoxCompany, 1, 1);
			this.tableFields.Controls.Add(this.labelContact, 0, 2);
			this.tableFields.Controls.Add(this.comboBoxContact, 1, 2);
			this.tableFields.Controls.Add(this.labelAmount, 0, 3);
			this.tableFields.Controls.Add(this.textBoxAmount, 1, 3);
			this.tableFields.Controls.Add(this.labelStage, 0, 4);
			this.tableFields.Controls.Add(this.comboBoxStage, 1, 4);
			this.tableFields.Controls.Add(this.labelClose, 0, 5);
			this.tableFields.Controls.Add(this.datePickerClose, 1, 5);
			this.tableFields.Controls.Add(this.labelOwner, 0, 6);
			this.tableFields.Controls.Add(this.comboBoxOwner, 1, 6);
			this.tableFields.Dock = Wisej.Web.DockStyle.Top;
			this.tableFields.Location = new System.Drawing.Point(14, 14);
			this.tableFields.Name = "tableFields";
			this.tableFields.RowCount = 7;
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.Size = new System.Drawing.Size(438, 266);
			this.tableFields.TabIndex = 0;
			this.tableFields.TabStop = true;
			//
			// labelTitle
			//
			this.labelTitle.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(3, 11);
			this.labelTitle.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(30, 16);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Title:";
			//
			// textBoxTitle
			//
			this.textBoxTitle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxTitle.Location = new System.Drawing.Point(116, 4);
			this.textBoxTitle.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(322, 30);
			this.textBoxTitle.TabIndex = 1;
			this.textBoxTitle.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// labelCompany
			//
			this.labelCompany.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelCompany.AutoSize = true;
			this.labelCompany.Location = new System.Drawing.Point(3, 49);
			this.labelCompany.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelCompany.Name = "labelCompany";
			this.labelCompany.Size = new System.Drawing.Size(61, 16);
			this.labelCompany.TabIndex = 2;
			this.labelCompany.Text = "Company:";
			//
			// comboBoxCompany
			//
			this.comboBoxCompany.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxCompany.DisplayMember = "Text";
			this.comboBoxCompany.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxCompany.Location = new System.Drawing.Point(116, 42);
			this.comboBoxCompany.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxCompany.Name = "comboBoxCompany";
			this.comboBoxCompany.Size = new System.Drawing.Size(322, 30);
			this.comboBoxCompany.TabIndex = 3;
			this.comboBoxCompany.ValueMember = "Id";
			this.comboBoxCompany.SelectedIndexChanged += new System.EventHandler(this.comboBoxCompany_SelectedIndexChanged);
			//
			// labelContact
			//
			this.labelContact.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelContact.AutoSize = true;
			this.labelContact.Location = new System.Drawing.Point(3, 87);
			this.labelContact.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelContact.Name = "labelContact";
			this.labelContact.Size = new System.Drawing.Size(101, 16);
			this.labelContact.TabIndex = 4;
			this.labelContact.Text = "Primary contact:";
			//
			// comboBoxContact
			//
			this.comboBoxContact.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxContact.DisplayMember = "Text";
			this.comboBoxContact.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxContact.Location = new System.Drawing.Point(116, 80);
			this.comboBoxContact.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxContact.Name = "comboBoxContact";
			this.comboBoxContact.Size = new System.Drawing.Size(322, 30);
			this.comboBoxContact.TabIndex = 5;
			this.comboBoxContact.ValueMember = "Id";
			//
			// labelAmount
			//
			this.labelAmount.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelAmount.AutoSize = true;
			this.labelAmount.Location = new System.Drawing.Point(3, 125);
			this.labelAmount.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelAmount.Name = "labelAmount";
			this.labelAmount.Size = new System.Drawing.Size(87, 16);
			this.labelAmount.TabIndex = 6;
			this.labelAmount.Text = "Amount (USD):";
			//
			// textBoxAmount
			//
			this.textBoxAmount.Anchor = Wisej.Web.AnchorStyles.Left;
			this.textBoxAmount.Location = new System.Drawing.Point(116, 118);
			this.textBoxAmount.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxAmount.Name = "textBoxAmount";
			this.textBoxAmount.Size = new System.Drawing.Size(160, 30);
			this.textBoxAmount.TabIndex = 7;
			this.textBoxAmount.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// labelStage
			//
			this.labelStage.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelStage.AutoSize = true;
			this.labelStage.Location = new System.Drawing.Point(3, 163);
			this.labelStage.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelStage.Name = "labelStage";
			this.labelStage.Size = new System.Drawing.Size(40, 16);
			this.labelStage.TabIndex = 8;
			this.labelStage.Text = "Stage:";
			//
			// comboBoxStage
			//
			this.comboBoxStage.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxStage.DisplayMember = "Name";
			this.comboBoxStage.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxStage.Location = new System.Drawing.Point(116, 156);
			this.comboBoxStage.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxStage.Name = "comboBoxStage";
			this.comboBoxStage.Size = new System.Drawing.Size(322, 30);
			this.comboBoxStage.TabIndex = 9;
			this.comboBoxStage.ValueMember = "Id";
			//
			// labelClose
			//
			this.labelClose.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelClose.AutoSize = true;
			this.labelClose.Location = new System.Drawing.Point(3, 201);
			this.labelClose.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelClose.Name = "labelClose";
			this.labelClose.Size = new System.Drawing.Size(98, 16);
			this.labelClose.TabIndex = 10;
			this.labelClose.Text = "Expected close:";
			//
			// datePickerClose
			//
			this.datePickerClose.Anchor = Wisej.Web.AnchorStyles.Left;
			this.datePickerClose.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.datePickerClose.Location = new System.Drawing.Point(116, 194);
			this.datePickerClose.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.datePickerClose.Name = "datePickerClose";
			this.datePickerClose.Size = new System.Drawing.Size(170, 30);
			this.datePickerClose.TabIndex = 11;
			//
			// labelOwner
			//
			this.labelOwner.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelOwner.AutoSize = true;
			this.labelOwner.Location = new System.Drawing.Point(3, 239);
			this.labelOwner.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelOwner.Name = "labelOwner";
			this.labelOwner.Size = new System.Drawing.Size(44, 16);
			this.labelOwner.TabIndex = 12;
			this.labelOwner.Text = "Owner:";
			//
			// comboBoxOwner
			//
			this.comboBoxOwner.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxOwner.DisplayMember = "Text";
			this.comboBoxOwner.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOwner.Location = new System.Drawing.Point(116, 232);
			this.comboBoxOwner.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxOwner.Name = "comboBoxOwner";
			this.comboBoxOwner.Size = new System.Drawing.Size(322, 30);
			this.comboBoxOwner.TabIndex = 13;
			this.comboBoxOwner.ValueMember = "Id";
			//
			// labelError
			//
			this.labelError.Dock = Wisej.Web.DockStyle.Top;
			this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
			this.labelError.Location = new System.Drawing.Point(14, 280);
			this.labelError.Name = "labelError";
			this.labelError.Padding = new Wisej.Web.Padding(0, 10, 0, 0);
			this.labelError.Size = new System.Drawing.Size(438, 34);
			this.labelError.TabIndex = 1;
			this.labelError.Visible = false;
			//
			// flowButtons
			//
			this.flowButtons.Controls.Add(this.buttonCancel);
			this.flowButtons.Controls.Add(this.buttonSave);
			this.flowButtons.Dock = Wisej.Web.DockStyle.Top;
			this.flowButtons.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowButtons.Location = new System.Drawing.Point(14, 314);
			this.flowButtons.Name = "flowButtons";
			this.flowButtons.Padding = new Wisej.Web.Padding(0, 14, 0, 0);
			this.flowButtons.Size = new System.Drawing.Size(438, 48);
			this.flowButtons.TabIndex = 2;
			this.flowButtons.TabStop = true;
			//
			// buttonCancel
			//
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(350, 14);
			this.buttonCancel.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 30);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			//
			// buttonSave
			//
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Location = new System.Drawing.Point(254, 14);
			this.buttonSave.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 30);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// DealEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(466, 376);
			this.Controls.Add(this.flowButtons);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.tableFields);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DealEditDialog";
			this.Padding = new Wisej.Web.Padding(14);
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Deal";
			this.tableFields.ResumeLayout(false);
			this.tableFields.PerformLayout();
			this.flowButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.TableLayoutPanel tableFields;
		private Wisej.Web.Label labelTitle;
		private Wisej.Web.TextBox textBoxTitle;
		private Wisej.Web.Label labelCompany;
		private Wisej.Web.ComboBox comboBoxCompany;
		private Wisej.Web.Label labelContact;
		private Wisej.Web.ComboBox comboBoxContact;
		private Wisej.Web.Label labelAmount;
		private Wisej.Web.TextBox textBoxAmount;
		private Wisej.Web.Label labelStage;
		private Wisej.Web.ComboBox comboBoxStage;
		private Wisej.Web.Label labelClose;
		private Wisej.Web.DateTimePicker datePickerClose;
		private Wisej.Web.Label labelOwner;
		private Wisej.Web.ComboBox comboBoxOwner;
		private Wisej.Web.Label labelError;
		private Wisej.Web.FlowLayoutPanel flowButtons;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Button buttonSave;
	}
}
