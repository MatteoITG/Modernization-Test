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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelRelated = new Wisej.Web.Label();
			this.tableFields = new Wisej.Web.TableLayoutPanel();
			this.labelType = new Wisej.Web.Label();
			this.flowType = new Wisej.Web.FlowLayoutPanel();
			this.radioCall = new Wisej.Web.RadioButton();
			this.radioEmail = new Wisej.Web.RadioButton();
			this.radioMeeting = new Wisej.Web.RadioButton();
			this.radioNote = new Wisej.Web.RadioButton();
			this.labelWhen = new Wisej.Web.Label();
			this.flowWhen = new Wisej.Web.FlowLayoutPanel();
			this.datePickerDate = new Wisej.Web.DateTimePicker();
			this.textBoxTime = new Wisej.Web.TextBox();
			this.labelDuration = new Wisej.Web.Label();
			this.textBoxDuration = new Wisej.Web.TextBox();
			this.labelMinutes = new Wisej.Web.Label();
			this.labelSubject = new Wisej.Web.Label();
			this.textBoxSubject = new Wisej.Web.TextBox();
			this.labelNotes = new Wisej.Web.Label();
			this.textBoxBody = new Wisej.Web.TextBox();
			this.labelError = new Wisej.Web.Label();
			this.flowButtons = new Wisej.Web.FlowLayoutPanel();
			this.buttonCancel = new Wisej.Web.Button();
			this.buttonSave = new Wisej.Web.Button();
			this.tableFields.SuspendLayout();
			this.flowType.SuspendLayout();
			this.flowWhen.SuspendLayout();
			this.flowButtons.SuspendLayout();
			this.SuspendLayout();
			//
			// labelRelated
			//
			this.labelRelated.Dock = Wisej.Web.DockStyle.Top;
			this.labelRelated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelRelated.Location = new System.Drawing.Point(14, 14);
			this.labelRelated.Name = "labelRelated";
			this.labelRelated.Padding = new Wisej.Web.Padding(0, 0, 0, 10);
			this.labelRelated.Size = new System.Drawing.Size(458, 30);
			this.labelRelated.TabIndex = 0;
			//
			// tableFields
			//
			this.tableFields.ColumnCount = 2;
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableFields.Controls.Add(this.labelType, 0, 0);
			this.tableFields.Controls.Add(this.flowType, 1, 0);
			this.tableFields.Controls.Add(this.labelWhen, 0, 1);
			this.tableFields.Controls.Add(this.flowWhen, 1, 1);
			this.tableFields.Controls.Add(this.labelSubject, 0, 2);
			this.tableFields.Controls.Add(this.textBoxSubject, 1, 2);
			this.tableFields.Controls.Add(this.labelNotes, 0, 3);
			this.tableFields.Controls.Add(this.textBoxBody, 1, 3);
			this.tableFields.Dock = Wisej.Web.DockStyle.Top;
			this.tableFields.Location = new System.Drawing.Point(14, 44);
			this.tableFields.Name = "tableFields";
			this.tableFields.RowCount = 4;
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 40F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 118F));
			this.tableFields.Size = new System.Drawing.Size(458, 234);
			this.tableFields.TabIndex = 1;
			this.tableFields.TabStop = true;
			//
			// labelType
			//
			this.labelType.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelType.AutoSize = true;
			this.labelType.Location = new System.Drawing.Point(3, 12);
			this.labelType.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelType.Name = "labelType";
			this.labelType.Size = new System.Drawing.Size(34, 16);
			this.labelType.TabIndex = 0;
			this.labelType.Text = "Type:";
			//
			// flowType
			//
			this.flowType.Controls.Add(this.radioCall);
			this.flowType.Controls.Add(this.radioEmail);
			this.flowType.Controls.Add(this.radioMeeting);
			this.flowType.Controls.Add(this.radioNote);
			this.flowType.Dock = Wisej.Web.DockStyle.Fill;
			this.flowType.Location = new System.Drawing.Point(64, 0);
			this.flowType.Margin = new Wisej.Web.Padding(0);
			this.flowType.Name = "flowType";
			this.flowType.Size = new System.Drawing.Size(394, 40);
			this.flowType.TabIndex = 1;
			this.flowType.TabStop = true;
			//
			// radioCall
			//
			this.radioCall.AutoSize = true;
			this.radioCall.Location = new System.Drawing.Point(0, 9);
			this.radioCall.Margin = new Wisej.Web.Padding(0, 9, 16, 0);
			this.radioCall.Name = "radioCall";
			this.radioCall.Size = new System.Drawing.Size(50, 22);
			this.radioCall.TabIndex = 0;
			this.radioCall.Text = "Call";
			this.radioCall.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
			//
			// radioEmail
			//
			this.radioEmail.AutoSize = true;
			this.radioEmail.Location = new System.Drawing.Point(66, 9);
			this.radioEmail.Margin = new Wisej.Web.Padding(0, 9, 16, 0);
			this.radioEmail.Name = "radioEmail";
			this.radioEmail.Size = new System.Drawing.Size(58, 22);
			this.radioEmail.TabIndex = 1;
			this.radioEmail.Text = "Email";
			this.radioEmail.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
			//
			// radioMeeting
			//
			this.radioMeeting.AutoSize = true;
			this.radioMeeting.Location = new System.Drawing.Point(140, 9);
			this.radioMeeting.Margin = new Wisej.Web.Padding(0, 9, 16, 0);
			this.radioMeeting.Name = "radioMeeting";
			this.radioMeeting.Size = new System.Drawing.Size(74, 22);
			this.radioMeeting.TabIndex = 2;
			this.radioMeeting.Text = "Meeting";
			this.radioMeeting.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
			//
			// radioNote
			//
			this.radioNote.AutoSize = true;
			this.radioNote.Location = new System.Drawing.Point(230, 9);
			this.radioNote.Margin = new Wisej.Web.Padding(0, 9, 0, 0);
			this.radioNote.Name = "radioNote";
			this.radioNote.Size = new System.Drawing.Size(54, 22);
			this.radioNote.TabIndex = 3;
			this.radioNote.Text = "Note";
			this.radioNote.CheckedChanged += new System.EventHandler(this.radioType_CheckedChanged);
			//
			// labelWhen
			//
			this.labelWhen.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelWhen.AutoSize = true;
			this.labelWhen.Location = new System.Drawing.Point(3, 51);
			this.labelWhen.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelWhen.Name = "labelWhen";
			this.labelWhen.Size = new System.Drawing.Size(40, 16);
			this.labelWhen.TabIndex = 2;
			this.labelWhen.Text = "When:";
			//
			// flowWhen
			//
			this.flowWhen.Controls.Add(this.datePickerDate);
			this.flowWhen.Controls.Add(this.textBoxTime);
			this.flowWhen.Controls.Add(this.labelDuration);
			this.flowWhen.Controls.Add(this.textBoxDuration);
			this.flowWhen.Controls.Add(this.labelMinutes);
			this.flowWhen.Dock = Wisej.Web.DockStyle.Fill;
			this.flowWhen.Location = new System.Drawing.Point(64, 40);
			this.flowWhen.Margin = new Wisej.Web.Padding(0);
			this.flowWhen.Name = "flowWhen";
			this.flowWhen.Size = new System.Drawing.Size(394, 38);
			this.flowWhen.TabIndex = 3;
			this.flowWhen.TabStop = true;
			//
			// datePickerDate
			//
			this.datePickerDate.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.datePickerDate.Location = new System.Drawing.Point(0, 4);
			this.datePickerDate.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.datePickerDate.Name = "datePickerDate";
			this.datePickerDate.Size = new System.Drawing.Size(160, 30);
			this.datePickerDate.TabIndex = 0;
			//
			// textBoxTime
			//
			this.textBoxTime.Location = new System.Drawing.Point(168, 4);
			this.textBoxTime.Margin = new Wisej.Web.Padding(8, 4, 0, 4);
			this.textBoxTime.Name = "textBoxTime";
			this.textBoxTime.Size = new System.Drawing.Size(60, 30);
			this.textBoxTime.TabIndex = 1;
			this.textBoxTime.ToolTipText = "Time (HH:mm)";
			this.textBoxTime.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// labelDuration
			//
			this.labelDuration.AutoSize = true;
			this.labelDuration.Location = new System.Drawing.Point(246, 11);
			this.labelDuration.Margin = new Wisej.Web.Padding(18, 11, 8, 0);
			this.labelDuration.Name = "labelDuration";
			this.labelDuration.Size = new System.Drawing.Size(56, 16);
			this.labelDuration.TabIndex = 2;
			this.labelDuration.Text = "Duration:";
			//
			// textBoxDuration
			//
			this.textBoxDuration.Location = new System.Drawing.Point(310, 4);
			this.textBoxDuration.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxDuration.Name = "textBoxDuration";
			this.textBoxDuration.Size = new System.Drawing.Size(50, 30);
			this.textBoxDuration.TabIndex = 3;
			this.textBoxDuration.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// labelMinutes
			//
			this.labelMinutes.AutoSize = true;
			this.labelMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelMinutes.Location = new System.Drawing.Point(366, 11);
			this.labelMinutes.Margin = new Wisej.Web.Padding(6, 11, 0, 0);
			this.labelMinutes.Name = "labelMinutes";
			this.labelMinutes.Size = new System.Drawing.Size(24, 16);
			this.labelMinutes.TabIndex = 4;
			this.labelMinutes.Text = "min";
			//
			// labelSubject
			//
			this.labelSubject.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelSubject.AutoSize = true;
			this.labelSubject.Location = new System.Drawing.Point(3, 89);
			this.labelSubject.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelSubject.Name = "labelSubject";
			this.labelSubject.Size = new System.Drawing.Size(50, 16);
			this.labelSubject.TabIndex = 4;
			this.labelSubject.Text = "Subject:";
			//
			// textBoxSubject
			//
			this.textBoxSubject.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxSubject.Location = new System.Drawing.Point(64, 82);
			this.textBoxSubject.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(394, 30);
			this.textBoxSubject.TabIndex = 5;
			this.textBoxSubject.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			//
			// labelNotes
			//
			this.labelNotes.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)));
			this.labelNotes.AutoSize = true;
			this.labelNotes.Location = new System.Drawing.Point(3, 123);
			this.labelNotes.Margin = new Wisej.Web.Padding(0, 7, 12, 0);
			this.labelNotes.Name = "labelNotes";
			this.labelNotes.Size = new System.Drawing.Size(40, 16);
			this.labelNotes.TabIndex = 6;
			this.labelNotes.Text = "Notes:";
			//
			// textBoxBody
			//
			this.textBoxBody.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxBody.Location = new System.Drawing.Point(64, 120);
			this.textBoxBody.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxBody.Multiline = true;
			this.textBoxBody.Name = "textBoxBody";
			this.textBoxBody.ScrollBars = Wisej.Web.ScrollBars.Vertical;
			this.textBoxBody.Size = new System.Drawing.Size(394, 110);
			this.textBoxBody.TabIndex = 7;
			//
			// labelError
			//
			this.labelError.Dock = Wisej.Web.DockStyle.Top;
			this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
			this.labelError.Location = new System.Drawing.Point(14, 278);
			this.labelError.Name = "labelError";
			this.labelError.Padding = new Wisej.Web.Padding(0, 10, 0, 0);
			this.labelError.Size = new System.Drawing.Size(458, 34);
			this.labelError.TabIndex = 2;
			this.labelError.Visible = false;
			//
			// flowButtons
			//
			this.flowButtons.Controls.Add(this.buttonCancel);
			this.flowButtons.Controls.Add(this.buttonSave);
			this.flowButtons.Dock = Wisej.Web.DockStyle.Top;
			this.flowButtons.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowButtons.Location = new System.Drawing.Point(14, 312);
			this.flowButtons.Name = "flowButtons";
			this.flowButtons.Padding = new Wisej.Web.Padding(0, 14, 0, 0);
			this.flowButtons.Size = new System.Drawing.Size(458, 48);
			this.flowButtons.TabIndex = 3;
			this.flowButtons.TabStop = true;
			//
			// buttonCancel
			//
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(370, 14);
			this.buttonCancel.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 30);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			//
			// buttonSave
			//
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Location = new System.Drawing.Point(274, 14);
			this.buttonSave.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 30);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// LogActivityDialog
			//
			this.AcceptButton = this.buttonSave;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(486, 374);
			this.Controls.Add(this.flowButtons);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.tableFields);
			this.Controls.Add(this.labelRelated);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogActivityDialog";
			this.Padding = new Wisej.Web.Padding(14);
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Log activity";
			this.tableFields.ResumeLayout(false);
			this.tableFields.PerformLayout();
			this.flowType.ResumeLayout(false);
			this.flowType.PerformLayout();
			this.flowWhen.ResumeLayout(false);
			this.flowWhen.PerformLayout();
			this.flowButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Label labelRelated;
		private Wisej.Web.TableLayoutPanel tableFields;
		private Wisej.Web.Label labelType;
		private Wisej.Web.FlowLayoutPanel flowType;
		private Wisej.Web.RadioButton radioCall;
		private Wisej.Web.RadioButton radioEmail;
		private Wisej.Web.RadioButton radioMeeting;
		private Wisej.Web.RadioButton radioNote;
		private Wisej.Web.Label labelWhen;
		private Wisej.Web.FlowLayoutPanel flowWhen;
		private Wisej.Web.DateTimePicker datePickerDate;
		private Wisej.Web.TextBox textBoxTime;
		private Wisej.Web.Label labelDuration;
		private Wisej.Web.TextBox textBoxDuration;
		private Wisej.Web.Label labelMinutes;
		private Wisej.Web.Label labelSubject;
		private Wisej.Web.TextBox textBoxSubject;
		private Wisej.Web.Label labelNotes;
		private Wisej.Web.TextBox textBoxBody;
		private Wisej.Web.Label labelError;
		private Wisej.Web.FlowLayoutPanel flowButtons;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Button buttonSave;
	}
}
