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
			this.labelTitle = new Wisej.Web.Label();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.labelDue = new Wisej.Web.Label();
			this.dateTimePickerDue = new Wisej.Web.DateTimePicker();
			this.labelPriority = new Wisej.Web.Label();
			this.comboBoxPriority = new Wisej.Web.ComboBox();
			this.labelAssignee = new Wisej.Web.Label();
			this.comboBoxAssignee = new Wisej.Web.ComboBox();
			this.labelStatus = new Wisej.Web.Label();
			this.comboBoxStatus = new Wisej.Web.ComboBox();
			this.labelRelated = new Wisej.Web.Label();
			this.buttonDelete = new Wisej.Web.Button();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.errorProvider = new Wisej.Web.ErrorProvider(this.components);
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
			this.dateTimePickerDue.Format = Wisej.Web.DateTimePickerFormat.Short;
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
			this.comboBoxPriority.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
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
			this.comboBoxAssignee.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
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
			this.comboBoxStatus.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
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
			this.buttonDelete.Visible = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			//
			// buttonSave
			//
			this.buttonSave.Location = new System.Drawing.Point(216, 192);
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(92, 27);
			this.buttonSave.TabIndex = 11;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(316, 192);
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(92, 27);
			this.buttonCancel.TabIndex = 12;
			this.buttonCancel.Text = "Cancel";
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = Wisej.Web.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// TaskEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
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
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TaskEditDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "New task";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelTitle;
		private Wisej.Web.TextBox textBoxTitle;
		private Wisej.Web.Label labelDue;
		private Wisej.Web.DateTimePicker dateTimePickerDue;
		private Wisej.Web.Label labelPriority;
		private Wisej.Web.ComboBox comboBoxPriority;
		private Wisej.Web.Label labelAssignee;
		private Wisej.Web.ComboBox comboBoxAssignee;
		private Wisej.Web.Label labelStatus;
		private Wisej.Web.ComboBox comboBoxStatus;
		private Wisej.Web.Label labelRelated;
		private Wisej.Web.Button buttonDelete;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.ErrorProvider errorProvider;
	}
}
