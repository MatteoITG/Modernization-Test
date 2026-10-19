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
			this.groupBoxCondition = new System.Windows.Forms.GroupBox();
			this.labelField = new System.Windows.Forms.Label();
			this.comboBoxField = new System.Windows.Forms.ComboBox();
			this.comboBoxOperator = new System.Windows.Forms.ComboBox();
			this.comboBoxValue = new System.Windows.Forms.ComboBox();
			this.dateTimePickerValue = new System.Windows.Forms.DateTimePicker();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.labelRules = new System.Windows.Forms.Label();
			this.listBoxRules = new System.Windows.Forms.ListBox();
			this.labelEmpty = new System.Windows.Forms.Label();
			this.buttonRemove = new System.Windows.Forms.Button();
			this.buttonClear = new System.Windows.Forms.Button();
			this.labelMatch = new System.Windows.Forms.Label();
			this.radioAll = new System.Windows.Forms.RadioButton();
			this.radioAny = new System.Windows.Forms.RadioButton();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
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
			this.comboBoxField.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxField.FormattingEnabled = true;
			this.comboBoxField.Location = new System.Drawing.Point(30, 24);
			this.comboBoxField.MaxDropDownItems = 16;
			this.comboBoxField.Name = "comboBoxField";
			this.comboBoxField.Size = new System.Drawing.Size(140, 23);
			this.comboBoxField.TabIndex = 1;
			this.comboBoxField.SelectedIndexChanged += new System.EventHandler(this.comboBoxField_SelectedIndexChanged);
			//
			// comboBoxOperator
			//
			this.comboBoxOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
			this.dateTimePickerValue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
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
			this.buttonAdd.UseVisualStyleBackColor = true;
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
			this.listBoxRules.IntegralHeight = false;
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
			this.buttonRemove.UseVisualStyleBackColor = true;
			this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
			//
			// buttonClear
			//
			this.buttonClear.Location = new System.Drawing.Point(500, 131);
			this.buttonClear.Name = "buttonClear";
			this.buttonClear.Size = new System.Drawing.Size(88, 27);
			this.buttonClear.TabIndex = 5;
			this.buttonClear.Text = "C&lear all";
			this.buttonClear.UseVisualStyleBackColor = true;
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
			this.radioAll.UseVisualStyleBackColor = true;
			//
			// radioAny
			//
			this.radioAny.AutoSize = true;
			this.radioAny.Location = new System.Drawing.Point(260, 260);
			this.radioAny.Name = "radioAny";
			this.radioAny.Size = new System.Drawing.Size(170, 19);
			this.radioAny.TabIndex = 8;
			this.radioAny.Text = "matching a&ny condition";
			this.radioAny.UseVisualStyleBackColor = true;
			//
			// buttonOk
			//
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(396, 296);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(92, 27);
			this.buttonOk.TabIndex = 9;
			this.buttonOk.Text = "Apply";
			this.buttonOk.UseVisualStyleBackColor = true;
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(496, 296);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 10;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// FilterDialog
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FilterDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Advanced filter";
			this.groupBoxCondition.ResumeLayout(false);
			this.groupBoxCondition.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxCondition;
		private System.Windows.Forms.Label labelField;
		private System.Windows.Forms.ComboBox comboBoxField;
		private System.Windows.Forms.ComboBox comboBoxOperator;
		private System.Windows.Forms.ComboBox comboBoxValue;
		private System.Windows.Forms.DateTimePicker dateTimePickerValue;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label labelRules;
		private System.Windows.Forms.ListBox listBoxRules;
		private System.Windows.Forms.Label labelEmpty;
		private System.Windows.Forms.Button buttonRemove;
		private System.Windows.Forms.Button buttonClear;
		private System.Windows.Forms.Label labelMatch;
		private System.Windows.Forms.RadioButton radioAll;
		private System.Windows.Forms.RadioButton radioAny;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
