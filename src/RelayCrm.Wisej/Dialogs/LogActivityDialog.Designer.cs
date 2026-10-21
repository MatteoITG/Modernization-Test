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
			this.groupBoxType = new Wisej.Web.GroupBox();
			this.radioCall = new Wisej.Web.RadioButton();
			this.radioEmail = new Wisej.Web.RadioButton();
			this.radioMeeting = new Wisej.Web.RadioButton();
			this.radioNote = new Wisej.Web.RadioButton();
			this.labelSubject = new Wisej.Web.Label();
			this.textBoxSubject = new Wisej.Web.TextBox();
			this.labelDate = new Wisej.Web.Label();
			this.dateTimePickerDate = new Wisej.Web.DateTimePicker();
			this.labelDuration = new Wisej.Web.Label();
			this.numericDuration = new Wisej.Web.NumericUpDown();
			this.labelMinutes = new Wisej.Web.Label();
			this.labelBody = new Wisej.Web.Label();
			this.textBoxBody = new Wisej.Web.TextBox();
			this.labelRelated = new Wisej.Web.Label();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.errorProvider = new Wisej.Web.ErrorProvider(this.components);
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
			this.dateTimePickerDate.Format = Wisej.Web.DateTimePickerFormat.Custom;
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
			this.textBoxBody.ScrollBars = Wisej.Web.ScrollBars.Vertical;
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
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(336, 290);
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
			// LogActivityDialog
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
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
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogActivityDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Log activity";
			this.groupBoxType.ResumeLayout(false);
			this.groupBoxType.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.GroupBox groupBoxType;
		private Wisej.Web.RadioButton radioCall;
		private Wisej.Web.RadioButton radioEmail;
		private Wisej.Web.RadioButton radioMeeting;
		private Wisej.Web.RadioButton radioNote;
		private Wisej.Web.Label labelSubject;
		private Wisej.Web.TextBox textBoxSubject;
		private Wisej.Web.Label labelDate;
		private Wisej.Web.DateTimePicker dateTimePickerDate;
		private Wisej.Web.Label labelDuration;
		private Wisej.Web.NumericUpDown numericDuration;
		private Wisej.Web.Label labelMinutes;
		private Wisej.Web.Label labelBody;
		private Wisej.Web.TextBox textBoxBody;
		private Wisej.Web.Label labelRelated;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.ErrorProvider errorProvider;
	}
}
