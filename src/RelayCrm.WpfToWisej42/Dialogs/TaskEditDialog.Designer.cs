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
			this.labelRelated = new Wisej.Web.Label();
			this.tableFields = new Wisej.Web.TableLayoutPanel();
			this.labelTitle = new Wisej.Web.Label();
			this.textBoxTitle = new Wisej.Web.TextBox();
			this.labelDue = new Wisej.Web.Label();
			this.flowDue = new Wisej.Web.FlowLayoutPanel();
			this.datePickerDue = new Wisej.Web.DateTimePicker();
			this.labelPriority = new Wisej.Web.Label();
			this.comboBoxPriority = new Wisej.Web.ComboBox();
			this.labelAssignee = new Wisej.Web.Label();
			this.comboBoxAssignee = new Wisej.Web.ComboBox();
			this.labelStatus = new Wisej.Web.Label();
			this.comboBoxStatus = new Wisej.Web.ComboBox();
			this.labelError = new Wisej.Web.Label();
			this.panelButtons = new Wisej.Web.Panel();
			this.flowButtons = new Wisej.Web.FlowLayoutPanel();
			this.buttonCancel = new Wisej.Web.Button();
			this.buttonSave = new Wisej.Web.Button();
			this.buttonDelete = new Wisej.Web.Button();
			this.tableFields.SuspendLayout();
			this.flowDue.SuspendLayout();
			this.panelButtons.SuspendLayout();
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
			this.labelRelated.Size = new System.Drawing.Size(418, 30);
			this.labelRelated.TabIndex = 0;
			//
			// tableFields
			//
			this.tableFields.ColumnCount = 2;
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
			this.tableFields.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableFields.Controls.Add(this.labelTitle, 0, 0);
			this.tableFields.Controls.Add(this.textBoxTitle, 1, 0);
			this.tableFields.Controls.Add(this.labelDue, 0, 1);
			this.tableFields.Controls.Add(this.flowDue, 1, 1);
			this.tableFields.Controls.Add(this.labelAssignee, 0, 2);
			this.tableFields.Controls.Add(this.comboBoxAssignee, 1, 2);
			this.tableFields.Controls.Add(this.labelStatus, 0, 3);
			this.tableFields.Controls.Add(this.comboBoxStatus, 1, 3);
			this.tableFields.Dock = Wisej.Web.DockStyle.Top;
			this.tableFields.Location = new System.Drawing.Point(14, 44);
			this.tableFields.Name = "tableFields";
			this.tableFields.RowCount = 4;
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableFields.Size = new System.Drawing.Size(418, 152);
			this.tableFields.TabIndex = 1;
			this.tableFields.TabStop = true;
			//
			// labelTitle
			//
			this.labelTitle.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelTitle.AutoSize = true;
			this.labelTitle.Location = new System.Drawing.Point(3, 11);
			this.labelTitle.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(30, 16);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Title:";
			//
			// textBoxTitle
			//
			this.textBoxTitle.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxTitle.Location = new System.Drawing.Point(74, 4);
			this.textBoxTitle.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(344, 30);
			this.textBoxTitle.TabIndex = 1;
			this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
			//
			// labelDue
			//
			this.labelDue.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelDue.AutoSize = true;
			this.labelDue.Location = new System.Drawing.Point(3, 49);
			this.labelDue.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelDue.Name = "labelDue";
			this.labelDue.Size = new System.Drawing.Size(30, 16);
			this.labelDue.TabIndex = 2;
			this.labelDue.Text = "Due:";
			//
			// flowDue
			//
			this.flowDue.Controls.Add(this.datePickerDue);
			this.flowDue.Controls.Add(this.labelPriority);
			this.flowDue.Controls.Add(this.comboBoxPriority);
			this.flowDue.Dock = Wisej.Web.DockStyle.Fill;
			this.flowDue.Location = new System.Drawing.Point(74, 38);
			this.flowDue.Margin = new Wisej.Web.Padding(0);
			this.flowDue.Name = "flowDue";
			this.flowDue.Size = new System.Drawing.Size(344, 38);
			this.flowDue.TabIndex = 3;
			this.flowDue.TabStop = true;
			//
			// datePickerDue
			//
			this.datePickerDue.Format = Wisej.Web.DateTimePickerFormat.Short;
			this.datePickerDue.Location = new System.Drawing.Point(0, 4);
			this.datePickerDue.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.datePickerDue.Name = "datePickerDue";
			this.datePickerDue.Size = new System.Drawing.Size(160, 30);
			this.datePickerDue.TabIndex = 0;
			//
			// labelPriority
			//
			this.labelPriority.AutoSize = true;
			this.labelPriority.Location = new System.Drawing.Point(178, 11);
			this.labelPriority.Margin = new Wisej.Web.Padding(18, 11, 8, 0);
			this.labelPriority.Name = "labelPriority";
			this.labelPriority.Size = new System.Drawing.Size(48, 16);
			this.labelPriority.TabIndex = 1;
			this.labelPriority.Text = "Priority:";
			//
			// comboBoxPriority
			//
			this.comboBoxPriority.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxPriority.Location = new System.Drawing.Point(234, 4);
			this.comboBoxPriority.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxPriority.Name = "comboBoxPriority";
			this.comboBoxPriority.Size = new System.Drawing.Size(100, 30);
			this.comboBoxPriority.TabIndex = 2;
			//
			// labelAssignee
			//
			this.labelAssignee.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelAssignee.AutoSize = true;
			this.labelAssignee.Location = new System.Drawing.Point(3, 87);
			this.labelAssignee.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelAssignee.Name = "labelAssignee";
			this.labelAssignee.Size = new System.Drawing.Size(60, 16);
			this.labelAssignee.TabIndex = 4;
			this.labelAssignee.Text = "Assignee:";
			//
			// comboBoxAssignee
			//
			this.comboBoxAssignee.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.comboBoxAssignee.DisplayMember = "Name";
			this.comboBoxAssignee.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxAssignee.Location = new System.Drawing.Point(74, 80);
			this.comboBoxAssignee.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxAssignee.Name = "comboBoxAssignee";
			this.comboBoxAssignee.Size = new System.Drawing.Size(344, 30);
			this.comboBoxAssignee.TabIndex = 5;
			//
			// labelStatus
			//
			this.labelStatus.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelStatus.AutoSize = true;
			this.labelStatus.Location = new System.Drawing.Point(3, 125);
			this.labelStatus.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(44, 16);
			this.labelStatus.TabIndex = 6;
			this.labelStatus.Text = "Status:";
			//
			// comboBoxStatus
			//
			this.comboBoxStatus.Anchor = Wisej.Web.AnchorStyles.Left;
			this.comboBoxStatus.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxStatus.Location = new System.Drawing.Point(74, 118);
			this.comboBoxStatus.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(140, 30);
			this.comboBoxStatus.TabIndex = 7;
			//
			// labelError
			//
			this.labelError.Dock = Wisej.Web.DockStyle.Top;
			this.labelError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
			this.labelError.Location = new System.Drawing.Point(14, 196);
			this.labelError.Name = "labelError";
			this.labelError.Padding = new Wisej.Web.Padding(0, 10, 0, 0);
			this.labelError.Size = new System.Drawing.Size(418, 34);
			this.labelError.TabIndex = 2;
			this.labelError.Visible = false;
			//
			// panelButtons
			//
			this.panelButtons.Controls.Add(this.flowButtons);
			this.panelButtons.Controls.Add(this.buttonDelete);
			this.panelButtons.Dock = Wisej.Web.DockStyle.Top;
			this.panelButtons.Location = new System.Drawing.Point(14, 230);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Padding = new Wisej.Web.Padding(0, 14, 0, 0);
			this.panelButtons.Size = new System.Drawing.Size(418, 44);
			this.panelButtons.TabIndex = 3;
			this.panelButtons.TabStop = true;
			//
			// flowButtons
			//
			this.flowButtons.Controls.Add(this.buttonCancel);
			this.flowButtons.Controls.Add(this.buttonSave);
			this.flowButtons.Dock = Wisej.Web.DockStyle.Fill;
			this.flowButtons.FlowDirection = Wisej.Web.FlowDirection.RightToLeft;
			this.flowButtons.Location = new System.Drawing.Point(88, 14);
			this.flowButtons.Name = "flowButtons";
			this.flowButtons.Size = new System.Drawing.Size(330, 30);
			this.flowButtons.TabIndex = 1;
			this.flowButtons.TabStop = true;
			//
			// buttonCancel
			//
			this.buttonCancel.CssClass = "relay-secondary";
			this.buttonCancel.DialogResult = Wisej.Web.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(242, 0);
			this.buttonCancel.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(88, 30);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			//
			// buttonSave
			//
			this.buttonSave.CssClass = "relay-primary";
			this.buttonSave.Location = new System.Drawing.Point(146, 0);
			this.buttonSave.Margin = new Wisej.Web.Padding(8, 0, 0, 0);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(88, 30);
			this.buttonSave.TabIndex = 0;
			this.buttonSave.Text = "Save";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			//
			// buttonDelete
			//
			this.buttonDelete.CssClass = "relay-secondary";
			this.buttonDelete.Dock = Wisej.Web.DockStyle.Left;
			this.buttonDelete.Location = new System.Drawing.Point(0, 14);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(88, 30);
			this.buttonDelete.TabIndex = 0;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Visible = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			//
			// TaskEditDialog
			//
			this.AcceptButton = this.buttonSave;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(446, 288);
			this.Controls.Add(this.panelButtons);
			this.Controls.Add(this.labelError);
			this.Controls.Add(this.tableFields);
			this.Controls.Add(this.labelRelated);
			this.FormBorderStyle = Wisej.Web.FormBorderStyle.Fixed;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TaskEditDialog";
			this.Padding = new Wisej.Web.Padding(14);
			this.ShowInTaskbar = false;
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Task";
			this.tableFields.ResumeLayout(false);
			this.tableFields.PerformLayout();
			this.flowDue.ResumeLayout(false);
			this.flowDue.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.flowButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Label labelRelated;
		private Wisej.Web.TableLayoutPanel tableFields;
		private Wisej.Web.Label labelTitle;
		private Wisej.Web.TextBox textBoxTitle;
		private Wisej.Web.Label labelDue;
		private Wisej.Web.FlowLayoutPanel flowDue;
		private Wisej.Web.DateTimePicker datePickerDue;
		private Wisej.Web.Label labelPriority;
		private Wisej.Web.ComboBox comboBoxPriority;
		private Wisej.Web.Label labelAssignee;
		private Wisej.Web.ComboBox comboBoxAssignee;
		private Wisej.Web.Label labelStatus;
		private Wisej.Web.ComboBox comboBoxStatus;
		private Wisej.Web.Label labelError;
		private Wisej.Web.Panel panelButtons;
		private Wisej.Web.FlowLayoutPanel flowButtons;
		private Wisej.Web.Button buttonCancel;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.Button buttonDelete;
	}
}
