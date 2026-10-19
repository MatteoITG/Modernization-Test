namespace RelayCrm.Dialogs
{
	partial class DealDetailDialog
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
			this.panelHeader = new Wisej.Web.Panel();
			this.labelTitle = new Wisej.Web.Label();
			this.linkCompany = new Wisej.Web.LinkLabel();
			this.chipStage = new Wisej.Web.ChipLabel();
			this.avatarOwner = new Wisej.Web.Avatar();
			this.labelAmount = new Wisej.Web.Label();
			this.buttonEdit = new Wisej.Web.Button();
			this.buttonDelete = new Wisej.Web.Button();
			this.panelStepper = new Wisej.Web.Panel();
			this.stepper = new Wisej.Web.Stepper();
			this.panelBody = new Wisej.Web.Panel();
			this.panelFields = new Wisej.Web.Panel();
			this.labelCapAmount = new Wisej.Web.Label();
			this.labelAmountValue = new Wisej.Web.Label();
			this.labelCapClose = new Wisej.Web.Label();
			this.labelCloseValue = new Wisej.Web.Label();
			this.labelCapProbability = new Wisej.Web.Label();
			this.labelProbabilityValue = new Wisej.Web.Label();
			this.labelCapContact = new Wisej.Web.Label();
			this.linkContact = new Wisej.Web.LinkLabel();
			this.labelCapCreated = new Wisej.Web.Label();
			this.labelCreatedValue = new Wisej.Web.Label();
			this.labelCapClosed = new Wisej.Web.Label();
			this.labelClosedValue = new Wisej.Web.Label();
			this.labelCapLost = new Wisej.Web.Label();
			this.labelLostValue = new Wisej.Web.Label();
			this.labelContactsTitle = new Wisej.Web.Label();
			this.avatarGroupContacts = new Wisej.Web.AvatarGroup();
			this.labelNoContacts = new Wisej.Web.Label();
			this.panelRight = new Wisej.Web.Panel();
			this.tabControl = new Wisej.Web.TabControl();
			this.tabPageActivity = new Wisej.Web.TabPage();
			this.buttonLogActivity = new Wisej.Web.Button();
			this.emptyStateActivity = new Wisej.Web.EmptyState();
			this.timeline = new Wisej.Web.Timeline();
			this.tabPageTasks = new Wisej.Web.TabPage();
			this.buttonAddTask = new Wisej.Web.Button();
			this.emptyStateTasks = new Wisej.Web.EmptyState();
			this.actionCardListTasks = new Wisej.Web.ActionCardList();
			this.panelHeader.SuspendLayout();
			this.panelStepper.SuspendLayout();
			this.panelBody.SuspendLayout();
			this.panelFields.SuspendLayout();
			this.panelRight.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageActivity.SuspendLayout();
			this.tabPageTasks.SuspendLayout();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.buttonDelete);
			this.panelHeader.Controls.Add(this.buttonEdit);
			this.panelHeader.Controls.Add(this.labelAmount);
			this.panelHeader.Controls.Add(this.avatarOwner);
			this.panelHeader.Controls.Add(this.chipStage);
			this.panelHeader.Controls.Add(this.linkCompany);
			this.panelHeader.Controls.Add(this.labelTitle);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(900, 116);
			this.panelHeader.TabIndex = 0;
			//
			// labelTitle
			//
			this.labelTitle.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.labelTitle.AutoEllipsis = true;
			this.labelTitle.CssClass = "relay-title";
			this.labelTitle.Font = new System.Drawing.Font("default", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelTitle.Location = new System.Drawing.Point(24, 16);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(560, 30);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "Deal";
			//
			// linkCompany
			//
			this.linkCompany.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.linkCompany.Location = new System.Drawing.Point(24, 48);
			this.linkCompany.Name = "linkCompany";
			this.linkCompany.Size = new System.Drawing.Size(400, 20);
			this.linkCompany.TabIndex = 1;
			this.linkCompany.Text = "Company";
			this.linkCompany.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkCompany_LinkClicked);
			//
			// chipStage
			//
			this.chipStage.Location = new System.Drawing.Point(24, 78);
			this.chipStage.Name = "chipStage";
			this.chipStage.ShowDot = true;
			this.chipStage.Size = new System.Drawing.Size(120, 26);
			this.chipStage.TabIndex = 2;
			this.chipStage.Text = "Stage";
			this.chipStage.Tone = Wisej.Web.ChipTone.Primary;
			//
			// avatarOwner
			//
			this.avatarOwner.AutoColor = true;
			this.avatarOwner.AvatarSize = 28;
			this.avatarOwner.Location = new System.Drawing.Point(160, 74);
			this.avatarOwner.Name = "avatarOwner";
			this.avatarOwner.Size = new System.Drawing.Size(260, 34);
			this.avatarOwner.SubLabel = "Owner";
			this.avatarOwner.TabIndex = 3;
			this.avatarOwner.Text = "Owner";
			//
			// labelAmount
			//
			this.labelAmount.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.labelAmount.CssClass = "relay-title";
			this.labelAmount.Font = new System.Drawing.Font("default", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelAmount.Location = new System.Drawing.Point(596, 16);
			this.labelAmount.Name = "labelAmount";
			this.labelAmount.Size = new System.Drawing.Size(280, 32);
			this.labelAmount.TabIndex = 4;
			this.labelAmount.Text = "$0";
			this.labelAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			// buttonEdit
			//
			this.buttonEdit.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonEdit.CssClass = "relay-secondary";
			this.buttonEdit.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/pencil.svg";
			this.buttonEdit.Location = new System.Drawing.Point(668, 73);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(100, 36);
			this.buttonEdit.TabIndex = 5;
			this.buttonEdit.Text = "Edit";
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			//
			// buttonDelete
			//
			this.buttonDelete.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonDelete.CssClass = "relay-secondary";
			this.buttonDelete.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			this.buttonDelete.Location = new System.Drawing.Point(776, 73);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(100, 36);
			this.buttonDelete.TabIndex = 6;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			//
			// panelStepper
			//
			this.panelStepper.Controls.Add(this.stepper);
			this.panelStepper.Dock = Wisej.Web.DockStyle.Top;
			this.panelStepper.Location = new System.Drawing.Point(0, 116);
			this.panelStepper.Name = "panelStepper";
			this.panelStepper.Padding = new Wisej.Web.Padding(24, 4, 24, 8);
			this.panelStepper.Size = new System.Drawing.Size(900, 80);
			this.panelStepper.TabIndex = 1;
			//
			// stepper
			//
			this.stepper.Appearance = Wisej.Web.StepperAppearance.Numbers;
			this.stepper.Dock = Wisej.Web.DockStyle.Fill;
			this.stepper.Location = new System.Drawing.Point(24, 4);
			this.stepper.Name = "stepper";
			this.stepper.Size = new System.Drawing.Size(852, 68);
			this.stepper.TabIndex = 0;
			//
			// panelBody
			//
			this.panelBody.Controls.Add(this.panelRight);
			this.panelBody.Controls.Add(this.panelFields);
			this.panelBody.Dock = Wisej.Web.DockStyle.Fill;
			this.panelBody.Location = new System.Drawing.Point(0, 196);
			this.panelBody.Name = "panelBody";
			this.panelBody.Padding = new Wisej.Web.Padding(24, 8, 24, 24);
			this.panelBody.Size = new System.Drawing.Size(900, 444);
			this.panelBody.TabIndex = 2;
			//
			// panelFields
			//
			this.panelFields.Controls.Add(this.labelNoContacts);
			this.panelFields.Controls.Add(this.avatarGroupContacts);
			this.panelFields.Controls.Add(this.labelContactsTitle);
			this.panelFields.Controls.Add(this.labelLostValue);
			this.panelFields.Controls.Add(this.labelCapLost);
			this.panelFields.Controls.Add(this.labelClosedValue);
			this.panelFields.Controls.Add(this.labelCapClosed);
			this.panelFields.Controls.Add(this.labelCreatedValue);
			this.panelFields.Controls.Add(this.labelCapCreated);
			this.panelFields.Controls.Add(this.linkContact);
			this.panelFields.Controls.Add(this.labelCapContact);
			this.panelFields.Controls.Add(this.labelProbabilityValue);
			this.panelFields.Controls.Add(this.labelCapProbability);
			this.panelFields.Controls.Add(this.labelCloseValue);
			this.panelFields.Controls.Add(this.labelCapClose);
			this.panelFields.Controls.Add(this.labelAmountValue);
			this.panelFields.Controls.Add(this.labelCapAmount);
			this.panelFields.AutoScroll = true;
			this.panelFields.CssClass = "relay-card";
			this.panelFields.Dock = Wisej.Web.DockStyle.Left;
			this.panelFields.Location = new System.Drawing.Point(24, 8);
			this.panelFields.Name = "panelFields";
			this.panelFields.Size = new System.Drawing.Size(320, 412);
			this.panelFields.TabIndex = 0;
			//
			// labelCapAmount
			//
			this.labelCapAmount.CssClass = "relay-muted";
			this.labelCapAmount.Location = new System.Drawing.Point(20, 20);
			this.labelCapAmount.Name = "labelCapAmount";
			this.labelCapAmount.Size = new System.Drawing.Size(108, 20);
			this.labelCapAmount.TabIndex = 0;
			this.labelCapAmount.Text = "Amount";
			//
			// labelAmountValue
			//
			this.labelAmountValue.Location = new System.Drawing.Point(132, 20);
			this.labelAmountValue.Name = "labelAmountValue";
			this.labelAmountValue.Size = new System.Drawing.Size(168, 20);
			this.labelAmountValue.TabIndex = 1;
			//
			// labelCapClose
			//
			this.labelCapClose.CssClass = "relay-muted";
			this.labelCapClose.Location = new System.Drawing.Point(20, 50);
			this.labelCapClose.Name = "labelCapClose";
			this.labelCapClose.Size = new System.Drawing.Size(108, 20);
			this.labelCapClose.TabIndex = 2;
			this.labelCapClose.Text = "Expected close";
			//
			// labelCloseValue
			//
			this.labelCloseValue.AutoEllipsis = true;
			this.labelCloseValue.Location = new System.Drawing.Point(132, 50);
			this.labelCloseValue.Name = "labelCloseValue";
			this.labelCloseValue.Size = new System.Drawing.Size(168, 20);
			this.labelCloseValue.TabIndex = 3;
			//
			// labelCapProbability
			//
			this.labelCapProbability.CssClass = "relay-muted";
			this.labelCapProbability.Location = new System.Drawing.Point(20, 80);
			this.labelCapProbability.Name = "labelCapProbability";
			this.labelCapProbability.Size = new System.Drawing.Size(108, 20);
			this.labelCapProbability.TabIndex = 4;
			this.labelCapProbability.Text = "Probability";
			//
			// labelProbabilityValue
			//
			this.labelProbabilityValue.Location = new System.Drawing.Point(132, 80);
			this.labelProbabilityValue.Name = "labelProbabilityValue";
			this.labelProbabilityValue.Size = new System.Drawing.Size(168, 20);
			this.labelProbabilityValue.TabIndex = 5;
			//
			// labelCapContact
			//
			this.labelCapContact.CssClass = "relay-muted";
			this.labelCapContact.Location = new System.Drawing.Point(20, 110);
			this.labelCapContact.Name = "labelCapContact";
			this.labelCapContact.Size = new System.Drawing.Size(108, 20);
			this.labelCapContact.TabIndex = 6;
			this.labelCapContact.Text = "Primary contact";
			//
			// linkContact
			//
			this.linkContact.AutoEllipsis = true;
			this.linkContact.Location = new System.Drawing.Point(132, 110);
			this.linkContact.Name = "linkContact";
			this.linkContact.Size = new System.Drawing.Size(168, 20);
			this.linkContact.TabIndex = 7;
			this.linkContact.LinkClicked += new Wisej.Web.LinkLabelLinkClickedEventHandler(this.linkContact_LinkClicked);
			//
			// labelCapCreated
			//
			this.labelCapCreated.CssClass = "relay-muted";
			this.labelCapCreated.Location = new System.Drawing.Point(20, 140);
			this.labelCapCreated.Name = "labelCapCreated";
			this.labelCapCreated.Size = new System.Drawing.Size(108, 20);
			this.labelCapCreated.TabIndex = 8;
			this.labelCapCreated.Text = "Created";
			//
			// labelCreatedValue
			//
			this.labelCreatedValue.Location = new System.Drawing.Point(132, 140);
			this.labelCreatedValue.Name = "labelCreatedValue";
			this.labelCreatedValue.Size = new System.Drawing.Size(168, 20);
			this.labelCreatedValue.TabIndex = 9;
			//
			// labelCapClosed
			//
			this.labelCapClosed.CssClass = "relay-muted";
			this.labelCapClosed.Location = new System.Drawing.Point(20, 170);
			this.labelCapClosed.Name = "labelCapClosed";
			this.labelCapClosed.Size = new System.Drawing.Size(108, 20);
			this.labelCapClosed.TabIndex = 10;
			this.labelCapClosed.Text = "Closed";
			this.labelCapClosed.Visible = false;
			//
			// labelClosedValue
			//
			this.labelClosedValue.Location = new System.Drawing.Point(132, 170);
			this.labelClosedValue.Name = "labelClosedValue";
			this.labelClosedValue.Size = new System.Drawing.Size(168, 20);
			this.labelClosedValue.TabIndex = 11;
			this.labelClosedValue.Visible = false;
			//
			// labelCapLost
			//
			this.labelCapLost.CssClass = "relay-muted";
			this.labelCapLost.Location = new System.Drawing.Point(20, 200);
			this.labelCapLost.Name = "labelCapLost";
			this.labelCapLost.Size = new System.Drawing.Size(108, 20);
			this.labelCapLost.TabIndex = 12;
			this.labelCapLost.Text = "Lost reason";
			this.labelCapLost.Visible = false;
			//
			// labelLostValue
			//
			this.labelLostValue.Location = new System.Drawing.Point(132, 200);
			this.labelLostValue.Name = "labelLostValue";
			this.labelLostValue.Size = new System.Drawing.Size(168, 40);
			this.labelLostValue.TabIndex = 13;
			this.labelLostValue.Visible = false;
			//
			// labelContactsTitle
			//
			this.labelContactsTitle.CssClass = "relay-title";
			this.labelContactsTitle.Font = new System.Drawing.Font("default", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelContactsTitle.Location = new System.Drawing.Point(20, 260);
			this.labelContactsTitle.Name = "labelContactsTitle";
			this.labelContactsTitle.Size = new System.Drawing.Size(280, 24);
			this.labelContactsTitle.TabIndex = 14;
			this.labelContactsTitle.Text = "Related contacts";
			//
			// avatarGroupContacts
			//
			this.avatarGroupContacts.AvatarSize = 36;
			this.avatarGroupContacts.Location = new System.Drawing.Point(20, 292);
			this.avatarGroupContacts.MaxVisible = 6;
			this.avatarGroupContacts.Name = "avatarGroupContacts";
			this.avatarGroupContacts.Size = new System.Drawing.Size(280, 44);
			this.avatarGroupContacts.TabIndex = 15;
			this.avatarGroupContacts.ItemClick += new System.EventHandler<Wisej.Web.AvatarItemEventArgs>(this.avatarGroupContacts_ItemClick);
			//
			// labelNoContacts
			//
			this.labelNoContacts.CssClass = "relay-muted";
			this.labelNoContacts.Location = new System.Drawing.Point(20, 292);
			this.labelNoContacts.Name = "labelNoContacts";
			this.labelNoContacts.Size = new System.Drawing.Size(280, 20);
			this.labelNoContacts.TabIndex = 16;
			this.labelNoContacts.Text = "No contacts at this company yet.";
			this.labelNoContacts.Visible = false;
			//
			// panelRight
			//
			this.panelRight.Controls.Add(this.tabControl);
			this.panelRight.Dock = Wisej.Web.DockStyle.Fill;
			this.panelRight.Location = new System.Drawing.Point(344, 8);
			this.panelRight.Name = "panelRight";
			this.panelRight.Padding = new Wisej.Web.Padding(16, 0, 0, 0);
			this.panelRight.Size = new System.Drawing.Size(532, 412);
			this.panelRight.TabIndex = 1;
			//
			// tabControl
			//
			this.tabControl.Controls.Add(this.tabPageActivity);
			this.tabControl.Controls.Add(this.tabPageTasks);
			this.tabControl.Dock = Wisej.Web.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(16, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.Size = new System.Drawing.Size(516, 412);
			this.tabControl.TabIndex = 0;
			//
			// tabPageActivity
			//
			this.tabPageActivity.Controls.Add(this.emptyStateActivity);
			this.tabPageActivity.Controls.Add(this.timeline);
			this.tabPageActivity.Controls.Add(this.buttonLogActivity);
			this.tabPageActivity.Location = new System.Drawing.Point(0, 40);
			this.tabPageActivity.Name = "tabPageActivity";
			this.tabPageActivity.Size = new System.Drawing.Size(516, 372);
			this.tabPageActivity.Text = "Activity";
			//
			// buttonLogActivity
			//
			this.buttonLogActivity.CssClass = "relay-secondary";
			this.buttonLogActivity.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus-lg.svg";
			this.buttonLogActivity.Location = new System.Drawing.Point(16, 16);
			this.buttonLogActivity.Name = "buttonLogActivity";
			this.buttonLogActivity.Size = new System.Drawing.Size(140, 36);
			this.buttonLogActivity.TabIndex = 0;
			this.buttonLogActivity.Text = "Log activity";
			this.buttonLogActivity.Click += new System.EventHandler(this.buttonLogActivity_Click);
			//
			// timeline
			//
			this.timeline.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
            | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.timeline.Location = new System.Drawing.Point(16, 68);
			this.timeline.Name = "timeline";
			this.timeline.Size = new System.Drawing.Size(484, 288);
			this.timeline.TabIndex = 1;
			this.timeline.TimeFormat = "MMM d, yyyy  HH:mm";
			this.timeline.TimePosition = Wisej.Web.TimelineTimePosition.Inline;
			//
			// emptyStateActivity
			//
			this.emptyStateActivity.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
            | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.emptyStateActivity.Compact = true;
			this.emptyStateActivity.Description = "Log a call, email, meeting or note for this deal.";
			this.emptyStateActivity.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/calendar-event.svg";
			this.emptyStateActivity.Location = new System.Drawing.Point(16, 68);
			this.emptyStateActivity.Name = "emptyStateActivity";
			this.emptyStateActivity.Size = new System.Drawing.Size(484, 288);
			this.emptyStateActivity.TabIndex = 2;
			this.emptyStateActivity.Title = "No activity yet";
			this.emptyStateActivity.Visible = false;
			//
			// tabPageTasks
			//
			this.tabPageTasks.Controls.Add(this.emptyStateTasks);
			this.tabPageTasks.Controls.Add(this.actionCardListTasks);
			this.tabPageTasks.Controls.Add(this.buttonAddTask);
			this.tabPageTasks.Location = new System.Drawing.Point(0, 40);
			this.tabPageTasks.Name = "tabPageTasks";
			this.tabPageTasks.Size = new System.Drawing.Size(516, 372);
			this.tabPageTasks.Text = "Tasks";
			//
			// buttonAddTask
			//
			this.buttonAddTask.CssClass = "relay-secondary";
			this.buttonAddTask.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus-lg.svg";
			this.buttonAddTask.Location = new System.Drawing.Point(16, 16);
			this.buttonAddTask.Name = "buttonAddTask";
			this.buttonAddTask.Size = new System.Drawing.Size(120, 36);
			this.buttonAddTask.TabIndex = 0;
			this.buttonAddTask.Text = "Add task";
			this.buttonAddTask.Click += new System.EventHandler(this.buttonAddTask_Click);
			//
			// actionCardListTasks
			//
			this.actionCardListTasks.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
            | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.actionCardListTasks.DisplayMembers.Description = "DueText";
			this.actionCardListTasks.DisplayMembers.Icon = "Icon";
			this.actionCardListTasks.DisplayMembers.Meta = "AssigneeName";
			this.actionCardListTasks.DisplayMembers.Title = "Title";
			this.actionCardListTasks.ItemHeight = 72;
			this.actionCardListTasks.ItemSpacing = 8;
			this.actionCardListTasks.Location = new System.Drawing.Point(16, 68);
			this.actionCardListTasks.Name = "actionCardListTasks";
			this.actionCardListTasks.Size = new System.Drawing.Size(484, 288);
			this.actionCardListTasks.TabIndex = 1;
			this.actionCardListTasks.ItemClick += new System.EventHandler<Wisej.Web.ActionCardListItemEventArgs>(this.actionCardListTasks_ItemClick);
			//
			// emptyStateTasks
			//
			this.emptyStateTasks.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom)
            | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			this.emptyStateTasks.Compact = true;
			this.emptyStateTasks.Description = "Add a follow-up so this deal keeps moving.";
			this.emptyStateTasks.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/check2-square.svg";
			this.emptyStateTasks.Location = new System.Drawing.Point(16, 68);
			this.emptyStateTasks.Name = "emptyStateTasks";
			this.emptyStateTasks.Size = new System.Drawing.Size(484, 288);
			this.emptyStateTasks.TabIndex = 2;
			this.emptyStateTasks.Title = "No tasks";
			this.emptyStateTasks.Visible = false;
			//
			// DealDetailDialog
			//
			this.ClientSize = new System.Drawing.Size(900, 640);
			this.Controls.Add(this.panelBody);
			this.Controls.Add(this.panelStepper);
			this.Controls.Add(this.panelHeader);
			this.MinimizeBox = false;
			this.Name = "DealDetailDialog";
			this.StartPosition = Wisej.Web.FormStartPosition.CenterParent;
			this.Text = "Deal";
			this.FormClosed += new Wisej.Web.FormClosedEventHandler(this.DealDetailDialog_FormClosed);
			this.panelHeader.ResumeLayout(false);
			this.panelStepper.ResumeLayout(false);
			this.panelBody.ResumeLayout(false);
			this.panelFields.ResumeLayout(false);
			this.panelRight.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.tabPageActivity.ResumeLayout(false);
			this.tabPageTasks.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelTitle;
		private Wisej.Web.LinkLabel linkCompany;
		private Wisej.Web.ChipLabel chipStage;
		private Wisej.Web.Avatar avatarOwner;
		private Wisej.Web.Label labelAmount;
		private Wisej.Web.Button buttonEdit;
		private Wisej.Web.Button buttonDelete;
		private Wisej.Web.Panel panelStepper;
		private Wisej.Web.Stepper stepper;
		private Wisej.Web.Panel panelBody;
		private Wisej.Web.Panel panelFields;
		private Wisej.Web.Label labelCapAmount;
		private Wisej.Web.Label labelAmountValue;
		private Wisej.Web.Label labelCapClose;
		private Wisej.Web.Label labelCloseValue;
		private Wisej.Web.Label labelCapProbability;
		private Wisej.Web.Label labelProbabilityValue;
		private Wisej.Web.Label labelCapContact;
		private Wisej.Web.LinkLabel linkContact;
		private Wisej.Web.Label labelCapCreated;
		private Wisej.Web.Label labelCreatedValue;
		private Wisej.Web.Label labelCapClosed;
		private Wisej.Web.Label labelClosedValue;
		private Wisej.Web.Label labelCapLost;
		private Wisej.Web.Label labelLostValue;
		private Wisej.Web.Label labelContactsTitle;
		private Wisej.Web.AvatarGroup avatarGroupContacts;
		private Wisej.Web.Label labelNoContacts;
		private Wisej.Web.Panel panelRight;
		private Wisej.Web.TabControl tabControl;
		private Wisej.Web.TabPage tabPageActivity;
		private Wisej.Web.Button buttonLogActivity;
		private Wisej.Web.EmptyState emptyStateActivity;
		private Wisej.Web.Timeline timeline;
		private Wisej.Web.TabPage tabPageTasks;
		private Wisej.Web.Button buttonAddTask;
		private Wisej.Web.EmptyState emptyStateTasks;
		private Wisej.Web.ActionCardList actionCardListTasks;
	}
}
