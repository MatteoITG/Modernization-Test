namespace RelayCrm.Dialogs
{
	partial class FilterDialog
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
			this.groupBoxCondition = new Wisej.Web.GroupBox();
			this.labelField = new Wisej.Web.Label();
			this.comboBoxField = new Wisej.Web.ComboBox();
			this.comboBoxOperator = new Wisej.Web.ComboBox();
			this.comboBoxValue = new Wisej.Web.ComboBox();
			this.dateTimePickerValue = new Wisej.Web.DateTimePicker();
			this.buttonAdd = new Wisej.Web.Button();
			this.labelRules = new Wisej.Web.Label();
			this.listBoxRules = new Wisej.Web.ListBox();
			this.labelEmpty = new Wisej.Web.Label();
			this.buttonRemove = new Wisej.Web.Button();
			this.buttonClear = new Wisej.Web.Button();
			this.labelMatch = new Wisej.Web.Label();
			this.radioAll = new Wisej.Web.RadioButton();
			this.radioAny = new Wisej.Web.RadioButton();
			this.buttonOk = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.errorProvider = new Wisej.Web.ErrorProvider(this.components);
			this.groupBoxCondition.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			//
			// groupBoxCondition
			//
			this.groupBoxCondition.Controls.Add(this.labelField);
			this.groupBoxCondition.Controls.Add(this.comboBoxField);
			this.groupBoxCondition.Controls.Add(this.comboBoxOperator);
			this.groupBoxCondition.Controls.Add(this.comboBoxValue);
			this.groupBoxCondition.Controls.Add(this.dateTimePickerValue);
			this.groupBoxCondition.Controls.Add(this.buttonAdd);
			this.groupBoxCondition.Location = new System.Drawing.Point(12, 8);
			this.groupBoxCondition.Name = "groupBoxCondition";
			this.groupBoxCondition.Size = new System.Drawing.Size(576, 62);
			this.groupBoxCondition.TabIndex = 0;
			this.groupBoxCondition.TabStop = false;
			this.groupBoxCondition.Text = "New condition";
			//
			// labelField
			//
			this.labelField.AutoSize = true;
			this.labelField.Location = new System.Drawing.Point(10, 27);
			this.labelField.Name = "labelField";
			this.labelField.Size = new System.Drawing.Size(16, 15);
			this.labelField.TabIndex = 0;
			this.labelField.Text = "&If";
			//
			// comboBoxField
			//
			this.comboBoxField.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxField.FormattingEnabled = true;
			this.comboBoxField.Location = new System.Drawing.Point(30, 24);
			this.comboBoxField.Name = "comboBoxField";
			this.comboBoxField.Size = new System.Drawing.Size(140, 23);
			this.comboBoxField.TabIndex = 1;
			this.comboBoxField.SelectedIndexChanged += new System.EventHandler(this.comboBoxField_SelectedIndexChanged);
			//
			// comboBoxOperator
			//
			this.comboBoxOperator.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxOperator.FormattingEnabled = true;
			this.comboBoxOperator.Location = new System.Drawing.Point(176, 24);
			this.comboBoxOperator.Name = "comboBoxOperator";
			this.comboBoxOperator.Size = new System.Drawing.Size(120, 23);
			this.comboBoxOperator.TabIndex = 2;
			this.comboBoxOperator.SelectedIndexChanged += new System.EventHandler(this.comboBoxOperator_SelectedIndexChanged);
			//
			// comboBoxValue
			//
			this.comboBoxValue.FormattingEnabled = true;
			this.comboBoxValue.Location = new System.Drawing.Point(302, 24);
			this.comboBoxValue.Name = "comboBoxValue";
			this.comboBoxValue.Size = new System.Drawing.Size(170, 23);
			this.comboBoxValue.TabIndex = 3;
			this.comboBoxValue.TextChanged += new System.EventHandler(this.comboBoxValue_TextChanged);
			//
			// dateTimePickerValue
			//
			this.dateTimePickerValue.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.dateTimePickerValue.Location = new System.Drawing.Point(302, 24);
			this.dateTimePickerValue.Name = "dateTimePickerValue";
			this.dateTimePickerValue.Size = new System.Drawing.Size(170, 23);
			this.dateTimePickerValue.TabIndex = 4;
			this.dateTimePickerValue.Visible = false;
			//
			// buttonAdd
			//
			this.buttonAdd.Location = new System.Drawing.Point(486, 22);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(80, 27);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "&Add";
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			//
			// labelRules
			//
			this.labelRules.AutoSize = true;
			this.labelRules.Location = new System.Drawing.Point(12, 80);
			this.labelRules.Name = "labelRules";
			this.labelRules.Size = new System.Drawing.Size(66, 15);
			this.labelRules.TabIndex = 1;
			this.labelRules.Text = "C&onditions:";
			//
			// listBoxRules
			//
			this.listBoxRules.FormattingEnabled = true;
			this.listBoxRules.ItemHeight = 15;
			this.listBoxRules.Location = new System.Drawing.Point(12, 98);
			this.listBoxRules.Name = "listBoxRules";
			this.listBoxRules.Size = new System.Drawing.Size(480, 150);
			this.listBoxRules.TabIndex = 2;
			this.listBoxRules.SelectedIndexChanged += new System.EventHandler(this.listBoxRules_SelectedIndexChanged);
			//
			// labelEmpty
			//
			this.labelEmpty.BackColor = System.Drawing.SystemColors.Window;
			this.labelEmpty.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelEmpty.Location = new System.Drawing.Point(20, 110);
			this.labelEmpty.Name = "labelEmpty";
			this.labelEmpty.Size = new System.Drawing.Size(440, 18);
			this.labelEmpty.TabIndex = 3;
			this.labelEmpty.Text = "No conditions: every row is shown. Add one above.";
			//
			// buttonRemove
			//
			this.buttonRemove.Location = new System.Drawing.Point(500, 98);
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new System.Drawing.Size(88, 27);
			this.buttonRemove.TabIndex = 4;
			this.buttonRemove.Text = "&Remove";
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			//
			// buttonClear
			//
			this.buttonClear.Location = new System.Drawing.Point(500, 131);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 27);
			this.buttonClear.TabIndex = 5;
			this.buttonClear.Text = "C&lear all";
			this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
			//
			// labelMatch
			//
			this.labelMatch.AutoSize = true;
			this.labelMatch.Location = new System.Drawing.Point(12, 262);
			this.labelMatch.Name = "labelMatch";
			this.labelMatch.Size = new System.Drawing.Size(66, 15);
			this.labelMatch.TabIndex = 6;
			this.labelMatch.Text = "Show rows:";
			//
			// radioAll
			//
			this.radioAll.AutoSize = true;
			this.radioAll.Checked = true;
			this.radioAll.Location = new System.Drawing.Point(90, 260);
			this.radioAll.Name = "radioAll";
			this.radioAll.Size = new System.Drawing.Size(162, 19);
			this.radioAll.TabIndex = 7;
			this.radioAll.TabStop = true;
			this.radioAll.Text = "matching a&ll conditions";
			//
			// radioAny
			//
			this.radioAny.AutoSize = true;
			this.radioAny.Location = new System.Drawing.Point(260, 260);
			this.radioAny.Name = "radioAny";
			this.radioAny.Size = new System.Drawing.Size(170, 19);
			this.radioAny.TabIndex = 8;
			this.radioAny.Text = "matching a&ny condition";
			//
			// buttonOk
			//
			this.buttonOk.DialogResult = Wisej.Web.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(396, 296);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(92, 27);
			this.buttonOk.TabIndex = 9;
			this.buttonOk.Text = "Apply";
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(496, 296);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 10;
			this.buttonCancel.Text = "Cancel";
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = Wisej.Web.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// FilterDialog
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(600, 335);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonOk);
			this.Controls.Add(this.radioAny);
			this.Controls.Add(this.radioAll);
			this.Controls.Add(this.labelMatch);
			this.Controls.Add(this.buttonClear);
			this.Controls.Add(this.buttonRemove);
			this.Controls.Add(this.labelEmpty);
			this.Controls.Add(this.listBoxRules);
			this.Controls.Add(this.labelRules);
			this.Controls.Add(this.groupBoxCondition);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FilterDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Advanced filter";
			this.groupBoxCondition.ResumeLayout(false);
			this.groupBoxCondition.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.GroupBox groupBoxCondition;
		private Wisej.Web.Label labelField;
		private Wisej.Web.ComboBox comboBoxField;
		private Wisej.Web.ComboBox comboBoxOperator;
		private Wisej.Web.ComboBox comboBoxValue;
		private Wisej.Web.DateTimePicker dateTimePickerValue;
		private Wisej.Web.Button buttonAdd;
		private Wisej.Web.Label labelRules;
		private Wisej.Web.ListBox listBoxRules;
		private Wisej.Web.Label labelEmpty;
		private Wisej.Web.Button buttonRemove;
		private Wisej.Web.Button buttonClear;
		private Wisej.Web.Label labelMatch;
		private Wisej.Web.RadioButton radioAll;
		private Wisej.Web.RadioButton radioAny;
		private Wisej.Web.Button buttonOk;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.ErrorProvider errorProvider;
	}
}
