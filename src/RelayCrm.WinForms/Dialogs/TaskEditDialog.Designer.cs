namespace RelayCrm.Dialogs
{
	partial class TaskEditDialog
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
			this.labelDue = new System.Windows.Forms.Label();
			this.dateTimePickerDue = new System.Windows.Forms.DateTimePicker();
			this.labelPriority = new System.Windows.Forms.Label();
			this.comboBoxPriority = new System.Windows.Forms.ComboBox();
			this.labelAssignee = new System.Windows.Forms.Label();
			this.comboBoxAssignee = new System.Windows.Forms.ComboBox();
			this.labelStatus = new System.Windows.Forms.Label();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.labelRelated = new System.Windows.Forms.Label();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			//
			// labelTitle
			//
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(12, 15);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(32, 15);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "&Title:";
			//
			// textBoxTitle
			//
			this.textBoxTitle.Location = new System.Drawing.Point(92, 12);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(316, 23);
			this.textBoxTitle.TabIndex = 1;
			this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
			//
			// labelDue
			//
			this.labelDue.AutoSize = true;
			this.labelDue.Location = new System.Drawing.Point(12, 44);
			this.labelDue.Name = "labelDue";
			this.labelDue.Size = new System.Drawing.Size(58, 15);
			this.labelDue.TabIndex = 2;
			this.labelDue.Text = "&Due date:";
			//
			// dateTimePickerDue
			//
			this.dateTimePickerDue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerDue.Location = new System.Drawing.Point(92, 41);
			this.dateTimePickerDue.Name = "dateTimePickerDue";
			this.dateTimePickerDue.Size = new System.Drawing.Size(130, 23);
			this.dateTimePickerDue.TabIndex = 3;
			//
			// labelPriority
			//
			this.labelPriority.AutoSize = true;
			this.labelPriority.Location = new System.Drawing.Point(12, 73);
			this.labelPriority.Name = "labelPriority";
			this.labelPriority.Size = new System.Drawing.Size(48, 15);
			this.labelPriority.TabIndex = 4;
			this.labelPriority.Text = "&Priority:";
			//
			// comboBoxPriority
			//
			this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxPriority.FormattingEnabled = true;
			this.comboBoxPriority.Items.AddRange(new object[] {
			"Low",
			"Normal",
			"High"});
			this.comboBoxPriority.Location = new System.Drawing.Point(92, 70);
			this.comboBoxPriority.Name = "comboBoxPriority";
			this.comboBoxPriority.Size = new System.Drawing.Size(130, 23);
			this.comboBoxPriority.TabIndex = 5;
			//
			// labelAssignee
			//
			this.labelAssignee.AutoSize = true;
			this.labelAssignee.Location = new System.Drawing.Point(12, 102);
			this.labelAssignee.Name = "labelAssignee";
			this.labelAssignee.Size = new System.Drawing.Size(56, 15);
			this.labelAssignee.TabIndex = 6;
			this.labelAssignee.Text = "&Assignee:";
			//
			// comboBoxAssignee
			//
			this.comboBoxAssignee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxAssignee.FormattingEnabled = true;
			this.comboBoxAssignee.Location = new System.Drawing.Point(92, 99);
			this.comboBoxAssignee.Name = "comboBoxAssignee";
			this.comboBoxAssignee.Size = new System.Drawing.Size(200, 23);
			this.comboBoxAssignee.TabIndex = 7;
			//
			// labelStatus
			//
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(12, 131);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(42, 15);
			this.labelStatus.TabIndex = 8;
			this.labelStatus.Text = "&Status:";
			//
			// comboBoxStatus
			//
			this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStatus.FormattingEnabled = true;
			this.comboBoxStatus.Items.AddRange(new object[] {
			"Open",
			"Done"});
			this.comboBoxStatus.Location = new System.Drawing.Point(92, 128);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(130, 23);
			this.comboBoxStatus.TabIndex = 9;
			//
			// labelRelated
			//
			this.labelRelated.AutoEllipsis = true;
			this.labelRelated.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelRelated.Location = new System.Drawing.Point(92, 160);
			this.labelRelated.Name = "labelRelated";
			this.labelRelated.Size = new System.Drawing.Size(316, 18);
			this.labelRelated.TabIndex = 10;
			this.labelRelated.Text = "Not related to a record";
			//
			// buttonDelete
			//
			this.buttonDelete.Location = new System.Drawing.Point(12, 192);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(92, 27);
			this.buttonDelete.TabIndex = 13;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Visible = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			//
			// buttonSave
			//
			this.buttonSave.Location = new System.Drawing.Point(216, 192);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(92, 27);
			this.buttonSave.TabIndex = 11;
			this.buttonSave.Text = "Save";
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(316, 192);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 12;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// TaskEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(424, 231);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.labelRelated);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.comboBoxAssignee);
			this.Controls.Add(this.labelAssignee);
			this.Controls.Add(this.comboBoxPriority);
			this.Controls.Add(this.labelPriority);
			this.Controls.Add(this.dateTimePickerDue);
			this.Controls.Add(this.labelDue);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.labelTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TaskEditDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "New task";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTitle;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.Label labelDue;
		private System.Windows.Forms.DateTimePicker dateTimePickerDue;
		private System.Windows.Forms.Label labelPriority;
		private System.Windows.Forms.ComboBox comboBoxPriority;
		private System.Windows.Forms.Label labelAssignee;
		private System.Windows.Forms.ComboBox comboBoxAssignee;
		private System.Windows.Forms.Label labelStatus;
		private System.Windows.Forms.ComboBox comboBoxStatus;
		private System.Windows.Forms.Label labelRelated;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
