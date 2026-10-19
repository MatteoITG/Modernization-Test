namespace RelayCrm.Dialogs
{
	partial class LogActivityDialog
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
			this.groupBoxType = new System.Windows.Forms.GroupBox();
			this.radioCall = new System.Windows.Forms.RadioButton();
			this.radioEmail = new System.Windows.Forms.RadioButton();
			this.radioMeeting = new System.Windows.Forms.RadioButton();
			this.radioNote = new System.Windows.Forms.RadioButton();
			this.labelSubject = new System.Windows.Forms.Label();
			this.textBoxSubject = new System.Windows.Forms.TextBox();
			this.labelDate = new System.Windows.Forms.Label();
			this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
			this.labelDuration = new System.Windows.Forms.Label();
			this.numericDuration = new System.Windows.Forms.NumericUpDown();
			this.labelMinutes = new System.Windows.Forms.Label();
			this.labelBody = new System.Windows.Forms.Label();
			this.textBoxBody = new System.Windows.Forms.TextBox();
			this.labelRelated = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBoxType.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericDuration)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.SuspendLayout();
			//
			// groupBoxType
			//
			this.groupBoxType.Controls.Add(this.radioCall);
			this.groupBoxType.Controls.Add(this.radioEmail);
			this.groupBoxType.Controls.Add(this.radioMeeting);
			this.groupBoxType.Controls.Add(this.radioNote);
			this.groupBoxType.Location = new System.Drawing.Point(12, 8);
			this.groupBoxType.Name = "groupBoxType";
			this.groupBoxType.Size = new System.Drawing.Size(416, 50);
			this.groupBoxType.TabIndex = 0;
			this.groupBoxType.TabStop = false;
			this.groupBoxType.Text = "Type";
			//
			// radioCall
			//
			this.radioCall.AutoSize = true;
			this.radioCall.Location = new System.Drawing.Point(14, 20);
			this.radioCall.Name = "radioCall";
			this.radioCall.Size = new System.Drawing.Size(45, 19);
			this.radioCall.TabIndex = 0;
			this.radioCall.TabStop = true;
			this.radioCall.Text = "&Call";
			this.radioCall.UseVisualStyleBackColor = true;
			this.radioCall.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
			//
			// radioEmail
			//
			this.radioEmail.AutoSize = true;
			this.radioEmail.Location = new System.Drawing.Point(110, 20);
			this.radioEmail.Name = "radioEmail";
			this.radioEmail.Size = new System.Drawing.Size(54, 19);
			this.radioEmail.TabIndex = 1;
			this.radioEmail.Text = "&Email";
			this.radioEmail.UseVisualStyleBackColor = true;
			this.radioEmail.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
			//
			// radioMeeting
			//
			this.radioMeeting.AutoSize = true;
			this.radioMeeting.Location = new System.Drawing.Point(206, 20);
			this.radioMeeting.Name = "radioMeeting";
			this.radioMeeting.Size = new System.Drawing.Size(68, 19);
			this.radioMeeting.TabIndex = 2;
			this.radioMeeting.Text = "&Meeting";
			this.radioMeeting.UseVisualStyleBackColor = true;
			this.radioMeeting.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
			//
			// radioNote
			//
			this.radioNote.AutoSize = true;
			this.radioNote.Location = new System.Drawing.Point(312, 20);
			this.radioNote.Name = "radioNote";
			this.radioNote.Size = new System.Drawing.Size(51, 19);
			this.radioNote.TabIndex = 3;
			this.radioNote.Text = "&Note";
			this.radioNote.UseVisualStyleBackColor = true;
			this.radioNote.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
			//
			// labelSubject
			//
			this.labelSubject.AutoSize = true;
			this.labelSubject.Location = new System.Drawing.Point(12, 73);
			this.labelSubject.Name = "labelSubject";
			this.labelSubject.Size = new System.Drawing.Size(49, 15);
			this.labelSubject.TabIndex = 1;
			this.labelSubject.Text = "&Subject:";
			//
			// textBoxSubject
			//
			this.textBoxSubject.Location = new System.Drawing.Point(100, 70);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(308, 23);
			this.textBoxSubject.TabIndex = 2;
			this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
			//
			// labelDate
			//
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(12, 102);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(34, 15);
			this.labelDate.TabIndex = 3;
			this.labelDate.Text = "&Date:";
			//
			// dateTimePickerDate
			//
			this.dateTimePickerDate.CustomFormat = "ddd, MMM d, yyyy   HH:mm";
			this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerDate.Location = new System.Drawing.Point(100, 99);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(200, 23);
			this.dateTimePickerDate.TabIndex = 4;
			//
			// labelDuration
			//
			this.labelDuration.AutoSize = true;
			this.labelDuration.Location = new System.Drawing.Point(12, 131);
			this.labelDuration.Name = "labelDuration";
			this.labelDuration.Size = new System.Drawing.Size(56, 15);
			this.labelDuration.TabIndex = 5;
			this.labelDuration.Text = "D&uration:";
			//
			// numericDuration
			//
			this.numericDuration.Increment = new decimal(new int[] {
			15,
			0,
			0,
			0});
			this.numericDuration.Location = new System.Drawing.Point(100, 128);
			this.numericDuration.Maximum = new decimal(new int[] {
			600,
			0,
			0,
			0});
			this.numericDuration.Name = "numericDuration";
			this.numericDuration.Size = new System.Drawing.Size(70, 23);
			this.numericDuration.TabIndex = 6;
			//
			// labelMinutes
			//
			this.labelMinutes.AutoSize = true;
			this.labelMinutes.Location = new System.Drawing.Point(176, 131);
			this.labelMinutes.Name = "labelMinutes";
			this.labelMinutes.Size = new System.Drawing.Size(50, 15);
			this.labelMinutes.TabIndex = 7;
			this.labelMinutes.Text = "minutes";
			//
			// labelBody
			//
			this.labelBody.AutoSize = true;
			this.labelBody.Location = new System.Drawing.Point(12, 160);
			this.labelBody.Name = "labelBody";
			this.labelBody.Size = new System.Drawing.Size(41, 15);
			this.labelBody.TabIndex = 8;
			this.labelBody.Text = "N&otes:";
			//
			// textBoxBody
			//
			this.textBoxBody.AcceptsReturn = true;
			this.textBoxBody.Location = new System.Drawing.Point(100, 157);
			this.textBoxBody.Multiline = true;
			this.textBoxBody.Name = "textBoxBody";
			this.textBoxBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxBody.Size = new System.Drawing.Size(308, 96);
			this.textBoxBody.TabIndex = 9;
			//
			// labelRelated
			//
			this.labelRelated.AutoEllipsis = true;
			this.labelRelated.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelRelated.Location = new System.Drawing.Point(100, 260);
			this.labelRelated.Name = "labelRelated";
			this.labelRelated.Size = new System.Drawing.Size(308, 18);
			this.labelRelated.TabIndex = 10;
			this.labelRelated.Text = "Related to";
			//
			// buttonSave
			//
			this.buttonSave.Location = new System.Drawing.Point(236, 290);
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
			this.buttonCancel.Location = new System.Drawing.Point(336, 290);
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
			// LogActivityDialog
			//
			this.AcceptButton = this.buttonSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(440, 329);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelRelated);
			this.Controls.Add(this.textBoxBody);
			this.Controls.Add(this.labelBody);
			this.Controls.Add(this.labelMinutes);
			this.Controls.Add(this.numericDuration);
			this.Controls.Add(this.labelDuration);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.textBoxSubject);
			this.Controls.Add(this.labelSubject);
			this.Controls.Add(this.groupBoxType);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogActivityDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Log activity";
			this.groupBoxType.ResumeLayout(false);
			this.groupBoxType.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxType;
		private System.Windows.Forms.RadioButton radioCall;
		private System.Windows.Forms.RadioButton radioEmail;
		private System.Windows.Forms.RadioButton radioMeeting;
		private System.Windows.Forms.RadioButton radioNote;
		private System.Windows.Forms.Label labelSubject;
		private System.Windows.Forms.TextBox textBoxSubject;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerDate;
		private System.Windows.Forms.Label labelDuration;
		private System.Windows.Forms.NumericUpDown numericDuration;
		private System.Windows.Forms.Label labelMinutes;
		private System.Windows.Forms.Label labelBody;
		private System.Windows.Forms.TextBox textBoxBody;
		private System.Windows.Forms.Label labelRelated;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ErrorProvider errorProvider;
	}
}
