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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxName = new Wisej.Web.TextBox();
			this.labelNameWarning = new Wisej.Web.ChipLabel();
			this.comboIndustry = new Wisej.Web.ComboBox();
			this.comboSize = new Wisej.Web.ComboBox();
			this.textBoxWebsite = new Wisej.Web.TextBox();
			this.textBoxPhone = new Wisej.Web.TextBox();
			this.textBoxAddress = new Wisej.Web.TextBox();
			this.textBoxCity = new Wisej.Web.TextBox();
			this.textBoxCountry = new Wisej.Web.TextBox();
			this.numericRevenue = new Wisej.Web.NumericUpDown();
			this.comboOwner = new Wisej.Web.ComboBox();
			this.labelTags = new Wisej.Web.Label();
			this.chipGroupTags = new Wisej.Web.ChipGroup();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericRevenue)).BeginInit();
			this.SuspendLayout();
			//
			// textBoxName
			//
			this.textBoxName.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxName.LabelText = "Name";
			this.textBoxName.Location = new System.Drawing.Point(24, 24);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(512, 56);
			this.textBoxName.TabIndex = 0;
			this.textBoxName.Watermark = "Company name";
			this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
			this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
			//
			// labelNameWarning
			//
			this.labelNameWarning.ChipSize = Wisej.Web.ChipSize.Small;
			this.labelNameWarning.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/exclamation-triangle.svg";
			this.labelNameWarning.Location = new System.Drawing.Point(236, 24);
			this.labelNameWarning.Name = "labelNameWarning";
			this.labelNameWarning.Size = new System.Drawing.Size(300, 20);
			this.labelNameWarning.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.labelNameWarning.TabIndex = 1;
			this.labelNameWarning.Text = "A company with this name already exists.";
			this.labelNameWarning.Tone = Wisej.Web.ChipTone.Warning;
			this.labelNameWarning.Visible = false;
			//
			// comboIndustry
			//
			this.comboIndustry.LabelText = "Industry";
			this.comboIndustry.Location = new System.Drawing.Point(24, 92);
			this.comboIndustry.Name = "comboIndustry";
			this.comboIndustry.Size = new System.Drawing.Size(248, 56);
			this.comboIndustry.TabIndex = 2;
			//
			// comboSize
			//
			this.comboSize.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboSize.LabelText = "Size (employees)";
			this.comboSize.Location = new System.Drawing.Point(288, 92);
			this.comboSize.Name = "comboSize";
			this.comboSize.Size = new System.Drawing.Size(248, 56);
			this.comboSize.TabIndex = 3;
			//
			// textBoxWebsite
			//
			this.textBoxWebsite.LabelText = "Website";
			this.textBoxWebsite.Location = new System.Drawing.Point(24, 160);
			this.textBoxWebsite.Name = "textBoxWebsite";
			this.textBoxWebsite.Size = new System.Drawing.Size(248, 56);
			this.textBoxWebsite.TabIndex = 4;
			this.textBoxWebsite.Watermark = "https://www.example.com";
			//
			// textBoxPhone
			//
			this.textBoxPhone.LabelText = "Phone";
			this.textBoxPhone.Location = new System.Drawing.Point(288, 160);
			this.textBoxPhone.Name = "textBoxPhone";
			this.textBoxPhone.Size = new System.Drawing.Size(248, 56);
			this.textBoxPhone.TabIndex = 5;
			//
			// textBoxAddress
			//
			this.textBoxAddress.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxAddress.LabelText = "Address";
			this.textBoxAddress.Location = new System.Drawing.Point(24, 228);
			this.textBoxAddress.Name = "textBoxAddress";
			this.textBoxAddress.Size = new System.Drawing.Size(512, 56);
			this.textBoxAddress.TabIndex = 6;
			//
			// textBoxCity
			//
			this.textBoxCity.LabelText = "City";
			this.textBoxCity.Location = new System.Drawing.Point(24, 296);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(248, 56);
			this.textBoxCity.TabIndex = 7;
			//
			// textBoxCountry
			//
			this.textBoxCountry.LabelText = "Country";
			this.textBoxCountry.Location = new System.Drawing.Point(288, 296);
			this.textBoxCountry.Name = "textBoxCountry";
			this.textBoxCountry.Size = new System.Drawing.Size(248, 56);
			this.textBoxCountry.TabIndex = 8;
			//
			// numericRevenue
			//
			this.numericRevenue.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numericRevenue.LabelText = "Annual revenue ($)";
			this.numericRevenue.Location = new System.Drawing.Point(24, 364);
			this.numericRevenue.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
			this.numericRevenue.Name = "numericRevenue";
			this.numericRevenue.Size = new System.Drawing.Size(248, 56);
			this.numericRevenue.TabIndex = 9;
			this.numericRevenue.ThousandsSeparator = true;
			//
			// comboOwner
			//
			this.comboOwner.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboOwner.LabelText = "Owner";
			this.comboOwner.Location = new System.Drawing.Point(288, 364);
			this.comboOwner.Name = "comboOwner";
			this.comboOwner.Size = new System.Drawing.Size(248, 56);
			this.comboOwner.TabIndex = 10;
			//
			// labelTags
			//
			this.labelTags.Location = new System.Drawing.Point(24, 432);
			this.labelTags.Name = "labelTags";
			this.labelTags.Size = new System.Drawing.Size(248, 18);
			this.labelTags.TabIndex = 11;
			this.labelTags.Text = "Tags";
			//
			// chipGroupTags
			//
			this.chipGroupTags.AllowDeselect = true;
			this.chipGroupTags.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.chipGroupTags.Location = new System.Drawing.Point(24, 454);
			this.chipGroupTags.Name = "chipGroupTags";
			this.chipGroupTags.SelectionMode = Wisej.Web.SegmentSelectionMode.Multiple;
			this.chipGroupTags.Size = new System.Drawing.Size(512, 36);
			this.chipGroupTags.TabIndex = 12;
			//
			// buttonSave
			//
			this.buttonSave.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Location = new System.Drawing.Point(436, 514);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(100, 36);
			this.buttonSave.TabIndex = 13;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(328, 514);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 36);
			this.buttonCancel.TabIndex = 14;
			this.buttonCancel.Text = "Cancel";
			//
			// CompanyEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(560, 574);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.chipGroupTags);
			this.Controls.Add(this.labelTags);
			this.Controls.Add(this.comboOwner);
			this.Controls.Add(this.numericRevenue);
			this.Controls.Add(this.textBoxCountry);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.textBoxAddress);
			this.Controls.Add(this.textBoxPhone);
			this.Controls.Add(this.textBoxWebsite);
			this.Controls.Add(this.comboSize);
			this.Controls.Add(this.comboIndustry);
			this.Controls.Add(this.labelNameWarning);
			this.Controls.Add(this.textBoxName);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CompanyEditDialog";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "New company";
			((System.ComponentModel.ISupportInitialize)(this.numericRevenue)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.TextBox textBoxName;
		private Wisej.Web.ChipLabel labelNameWarning;
		private Wisej.Web.ComboBox comboIndustry;
		private Wisej.Web.ComboBox comboSize;
		private Wisej.Web.TextBox textBoxWebsite;
		private Wisej.Web.TextBox textBoxPhone;
		private Wisej.Web.TextBox textBoxAddress;
		private Wisej.Web.TextBox textBoxCity;
		private Wisej.Web.TextBox textBoxCountry;
		private Wisej.Web.NumericUpDown numericRevenue;
		private Wisej.Web.ComboBox comboOwner;
		private Wisej.Web.Label labelTags;
		private Wisej.Web.ChipGroup chipGroupTags;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.Button buttonCancel;
	}
}
