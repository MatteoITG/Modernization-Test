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
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment3 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment4 = new Wisej.Web.Segment();
			this.segmentedType = new Wisej.Web.SegmentedButton();
			this.textBoxSubject = new Wisej.Web.TextBox();
			this.dateTimePickerDate = new Wisej.Web.DateTimePicker();
			this.numericDuration = new Wisej.Web.NumericUpDown();
			this.textBoxBody = new Wisej.Web.TextBox();
			this.labelRelated = new Wisej.Web.Label();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			((System.ComponentModel.ISupportInitialize)(this.numericDuration)).BeginInit();
			this.SuspendLayout();
			//
			// segmentedType
			//
			segment1.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/telephone.svg";
			segment1.Text = "Call";
			segment2.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/envelope.svg";
			segment2.Text = "Email";
			segment3.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/people.svg";
			segment3.Text = "Meeting";
			segment4.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/sticky.svg";
			segment4.Text = "Note";
			this.segmentedType.Items.Add(segment1);
			this.segmentedType.Items.Add(segment2);
			this.segmentedType.Items.Add(segment3);
			this.segmentedType.Items.Add(segment4);
			this.segmentedType.Location = new System.Drawing.Point(24, 24);
			this.segmentedType.Name = "segmentedType";
			this.segmentedType.SelectedIndex = 0;
			this.segmentedType.Size = new System.Drawing.Size(432, 36);
			this.segmentedType.Stretch = true;
			this.segmentedType.TabIndex = 0;
			this.segmentedType.SelectedIndexChanged += new System.EventHandler(this.segmentedType_SelectedIndexChanged);
			//
			// textBoxSubject
			//
			this.textBoxSubject.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxSubject.LabelText = "Subject";
			this.textBoxSubject.Location = new System.Drawing.Point(24, 76);
			this.textBoxSubject.Name = "textBoxSubject";
			this.textBoxSubject.Size = new System.Drawing.Size(432, 56);
			this.textBoxSubject.TabIndex = 1;
			this.textBoxSubject.TextChanged += new System.EventHandler(this.textBoxSubject_TextChanged);
			//
			// dateTimePickerDate
			//
			this.dateTimePickerDate.CustomFormat = "MMM d, yyyy  HH:mm";
			this.dateTimePickerDate.Format = Wisej.Web.DateTimePickerFormat.Custom;
			this.dateTimePickerDate.LabelText = "Date";
			this.dateTimePickerDate.Location = new System.Drawing.Point(24, 144);
			this.dateTimePickerDate.Name = "dateTimePickerDate";
			this.dateTimePickerDate.Size = new System.Drawing.Size(280, 56);
			this.dateTimePickerDate.TabIndex = 2;
			//
			// numericDuration
			//
			this.numericDuration.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
			this.numericDuration.LabelText = "Duration (min)";
			this.numericDuration.Location = new System.Drawing.Point(320, 144);
			this.numericDuration.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
			this.numericDuration.Name = "numericDuration";
			this.numericDuration.Size = new System.Drawing.Size(136, 56);
			this.numericDuration.TabIndex = 3;
			//
			// textBoxBody
			//
			this.textBoxBody.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
            | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxBody.LabelText = "Notes";
			this.textBoxBody.Location = new System.Drawing.Point(24, 212);
			this.textBoxBody.Multiline = true;
			this.textBoxBody.Name = "textBoxBody";
			this.textBoxBody.Size = new System.Drawing.Size(432, 150);
			this.textBoxBody.TabIndex = 4;
			//
			// labelRelated
			//
			this.labelRelated.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.labelRelated.CssClass = "relay-muted";
			this.labelRelated.Location = new System.Drawing.Point(24, 374);
			this.labelRelated.Name = "labelRelated";
			this.labelRelated.Size = new System.Drawing.Size(432, 20);
			this.labelRelated.TabIndex = 5;
			this.labelRelated.Text = "Related to";
			//
			// buttonSave
			//
			this.buttonSave.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Location = new System.Drawing.Point(356, 410);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(100, 36);
			this.buttonSave.TabIndex = 6;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(248, 410);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 36);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Cancel";
			//
			// LogActivityDialog
			//
			this.AcceptButton = this.buttonSave;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(480, 470);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelRelated);
			this.Controls.Add(this.textBoxBody);
			this.Controls.Add(this.numericDuration);
			this.Controls.Add(this.dateTimePickerDate);
			this.Controls.Add(this.textBoxSubject);
			this.Controls.Add(this.segmentedType);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogActivityDialog";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Log activity";
			((System.ComponentModel.ISupportInitialize)(this.numericDuration)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.SegmentedButton segmentedType;
		private Wisej.Web.TextBox textBoxSubject;
		private Wisej.Web.DateTimePicker dateTimePickerDate;
		private Wisej.Web.NumericUpDown numericDuration;
		private Wisej.Web.TextBox textBoxBody;
		private Wisej.Web.Label labelRelated;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.Button buttonCancel;
	}
}
