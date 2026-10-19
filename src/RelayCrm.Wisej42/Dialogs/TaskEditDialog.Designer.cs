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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.dateTimePickerDue = new Wisej.Web.DateTimePicker();
			this.comboBoxPriority = new Wisej.Web.ComboBox();
			this.comboBoxAssignee = new Wisej.Web.ComboBox();
			this.comboBoxStatus = new Wisej.Web.ComboBox();
			this.labelRelated = new Wisej.Web.Label();
			this.buttonDelete = new Wisej.Web.Button();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonCancel = new Wisej.Web.Button();
			this.SuspendLayout();
			//
			// textBoxTitle
			//
			this.textBoxTitle.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.textBoxTitle.LabelText = "Title";
			this.textBoxTitle.Location = new System.Drawing.Point(24, 24);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(432, 56);
			this.textBoxTitle.TabIndex = 0;
			this.textBoxTitle.Watermark = "What needs to be done?";
			this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
			//
			// dateTimePickerDue
			//
			this.dateTimePickerDue.CustomFormat = "MMM d, yyyy";
			this.dateTimePickerDue.Format = Wisej.Web.DateTimePickerFormat.Custom;
			this.dateTimePickerDue.LabelText = "Due date";
			this.dateTimePickerDue.Location = new System.Drawing.Point(24, 92);
			this.dateTimePickerDue.Name = "dateTimePickerDue";
			this.dateTimePickerDue.Size = new System.Drawing.Size(208, 56);
			this.dateTimePickerDue.TabIndex = 1;
			//
			// comboBoxPriority
			//
			this.comboBoxPriority.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxPriority.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
			this.comboBoxPriority.LabelText = "Priority";
			this.comboBoxPriority.Location = new System.Drawing.Point(248, 92);
			this.comboBoxPriority.Name = "comboBoxPriority";
			this.comboBoxPriority.Size = new System.Drawing.Size(208, 56);
			this.comboBoxPriority.TabIndex = 2;
			//
			// comboBoxAssignee
			//
			this.comboBoxAssignee.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxAssignee.LabelText = "Assignee";
			this.comboBoxAssignee.Location = new System.Drawing.Point(24, 160);
			this.comboBoxAssignee.Name = "comboBoxAssignee";
			this.comboBoxAssignee.Size = new System.Drawing.Size(208, 56);
			this.comboBoxAssignee.TabIndex = 3;
			//
			// comboBoxStatus
			//
			this.comboBoxStatus.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxStatus.Items.AddRange(new object[] {
            "Open",
            "Done"});
			this.comboBoxStatus.LabelText = "Status";
			this.comboBoxStatus.Location = new System.Drawing.Point(248, 160);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(208, 56);
			this.comboBoxStatus.TabIndex = 4;
			//
			// labelRelated
			//
			this.labelRelated.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.labelRelated.CssClass = "relay-muted";
			this.labelRelated.Location = new System.Drawing.Point(24, 232);
			this.labelRelated.Name = "labelRelated";
			this.labelRelated.Size = new System.Drawing.Size(432, 20);
			this.labelRelated.TabIndex = 5;
			this.labelRelated.Text = "Not related to a record";
			//
			// buttonDelete
			//
			this.buttonDelete.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Left)));
			this.buttonDelete.CssClass = "relay-secondary";
			this.buttonDelete.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			this.buttonDelete.Location = new System.Drawing.Point(24, 276);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(100, 36);
			this.buttonDelete.TabIndex = 8;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Visible = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			//
			// buttonSave
			//
			this.buttonSave.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Bottom | Wisej.Web.AnchorStyles.Right)));
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Location = new System.Drawing.Point(356, 276);
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
			this.buttonCancel.Location = new System.Drawing.Point(248, 276);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(100, 36);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Cancel";
			//
			// TaskEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(480, 336);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.labelRelated);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.comboBoxAssignee);
			this.Controls.Add(this.comboBoxPriority);
			this.Controls.Add(this.dateTimePickerDue);
			this.Controls.Add(this.textBoxTitle);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TaskEditDialog";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "New task";
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.TextBox textBoxTitle;
		private Wisej.Web.DateTimePicker dateTimePickerDue;
		private Wisej.Web.ComboBox comboBoxPriority;
		private Wisej.Web.ComboBox comboBoxAssignee;
		private Wisej.Web.ComboBox comboBoxStatus;
		private Wisej.Web.Label labelRelated;
		private Wisej.Web.Button buttonDelete;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.Button buttonCancel;
	}
}
