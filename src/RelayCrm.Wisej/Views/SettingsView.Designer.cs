namespace RelayCrm.Views
{
	partial class SettingsView
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

		#region Component Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle6 = new Wisej.Web.DataGridViewCellStyle();
			this.errorProvider = new Wisej.Web.ErrorProvider(this.components);
			this.tabControl = new Wisej.Web.TabControl();
			this.labelSubtitle = new Wisej.Web.Label();
			this.tabProfile = new Wisej.Web.TabPage();
			this.labelProfileTitle = new Wisej.Web.Label();
			this.labelProfileHint = new Wisej.Web.Label();
			this.labelProfileName = new Wisej.Web.Label();
			this.textBoxProfileName = new Wisej.Web.TextBox();
			this.labelProfileEmail = new Wisej.Web.Label();
			this.textBoxProfileEmail = new Wisej.Web.TextBox();
			this.labelColor = new Wisej.Web.Label();
			this.buttonColor1 = new Wisej.Web.Button();
			this.buttonColor2 = new Wisej.Web.Button();
			this.buttonColor3 = new Wisej.Web.Button();
			this.buttonColor4 = new Wisej.Web.Button();
			this.buttonColor5 = new Wisej.Web.Button();
			this.buttonColor6 = new Wisej.Web.Button();
			this.buttonColor7 = new Wisej.Web.Button();
			this.buttonColor8 = new Wisej.Web.Button();
			this.labelProfileRole = new Wisej.Web.Label();
			this.buttonSaveProfile = new Wisej.Web.Button();
			this.groupPreview = new Wisej.Web.GroupBox();
			this.avatarProfile = new Wisej.Web.Avatar();
			this.labelPreviewName = new Wisej.Web.Label();
			this.labelPreviewEmail = new Wisej.Web.Label();
			this.tabUsers = new Wisej.Web.TabPage();
			this.dataGridUsers = new Wisej.Web.DataGridView();
			this.colUserName = new Wisej.Web.DataGridViewAvatarColumn();
			this.colUserEmail = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colUserRole = new Wisej.Web.DataGridViewComboBoxColumn();
			this.colUserActive = new Wisej.Web.DataGridViewCheckBoxColumn();
			this.colUserOwned = new Wisej.Web.DataGridViewTextBoxColumn();
			this.usersStrip = new Wisej.Web.ToolBar();
			this.buttonInvite = new Wisej.Web.ToolBarButton();
			this.labelUsersTitle = new Wisej.Web.ToolBarButton();
			this.labelUsersHint = new Wisej.Web.ToolBarButton();
			this.tabStages = new Wisej.Web.TabPage();
			this.dataGridStages = new Wisej.Web.DataGridView();
			this.colStageOrder = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStageName = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStageProbability = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStageKind = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStageDeals = new Wisej.Web.DataGridViewTextBoxColumn();
			this.stagesStrip = new Wisej.Web.ToolBar();
			this.buttonMoveUp = new Wisej.Web.ToolBarButton();
			this.buttonMoveDown = new Wisej.Web.ToolBarButton();
			this.buttonSaveStages = new Wisej.Web.ToolBarButton();
			this.stagesSeparator = new Wisej.Web.ToolBarButton();
			this.labelStagesHint = new Wisej.Web.ToolBarButton();
			this.tabTags = new Wisej.Web.TabPage();
			this.dataGridTags = new Wisej.Web.DataGridView();
			this.colTagName = new Wisej.Web.DataGridViewChipColumn();
			this.colTagUsage = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colTagCount = new Wisej.Web.DataGridViewTextBoxColumn();
			this.tagsStrip = new Wisej.Web.ToolBar();
			this.labelNewTag = new Wisej.Web.ToolBarButton();
			this.textNewTag = new Wisej.Web.TextBox();
			this.textNewTagHost = new Wisej.Web.ToolBarControl();
			this.buttonAddTag = new Wisej.Web.ToolBarButton();
			this.buttonRemoveTag = new Wisej.Web.ToolBarButton();
			this.tagsSeparator = new Wisej.Web.ToolBarButton();
			this.labelTagsTitle = new Wisej.Web.ToolBarButton();
			this.labelTagsHint = new Wisej.Web.ToolBarButton();
			this.tabDemo = new Wisej.Web.TabPage();
			this.labelDemoTitle = new Wisej.Web.Label();
			this.labelDemoText = new Wisej.Web.Label();
			this.labelDemoNote = new Wisej.Web.Label();
			this.buttonResetDemo = new Wisej.Web.Button();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
			this.tabControl.SuspendLayout();
			this.tabProfile.SuspendLayout();
			this.groupPreview.SuspendLayout();
			this.tabUsers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).BeginInit();
			this.usersStrip.SuspendLayout();
			this.tabStages.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridStages)).BeginInit();
			this.stagesStrip.SuspendLayout();
			this.tabTags.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTags)).BeginInit();
			this.tagsStrip.SuspendLayout();
			this.tabDemo.SuspendLayout();
			this.SuspendLayout();
			//
			// errorProvider
			//
			this.errorProvider.BlinkStyle = Wisej.Web.ErrorBlinkStyle.NeverBlink;
			this.errorProvider.ContainerControl = this;
			//
			// tabControl
			//
			this.tabControl.Controls.Add(this.tabProfile);
			this.tabControl.Controls.Add(this.tabUsers);
			this.tabControl.Controls.Add(this.tabStages);
			this.tabControl.Controls.Add(this.tabTags);
			this.tabControl.Controls.Add(this.tabDemo);
			this.tabControl.Dock = Wisej.Web.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 34);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1000, 566);
			this.tabControl.TabIndex = 1;
			//
			// labelSubtitle
			//
			this.labelSubtitle.Dock = Wisej.Web.DockStyle.Top;
			this.labelSubtitle.Location = new System.Drawing.Point(0, 0);
			this.labelSubtitle.Name = "labelSubtitle";
			this.labelSubtitle.Padding = new Wisej.Web.Padding(8, 0, 0, 0);
			this.labelSubtitle.Size = new System.Drawing.Size(1000, 34);
			this.labelSubtitle.TabIndex = 0;
			this.labelSubtitle.Text = "Your profile, the team, the pipeline stages and the tags.";
			this.labelSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// tabProfile
			//
			this.tabProfile.Controls.Add(this.labelProfileTitle);
			this.tabProfile.Controls.Add(this.labelProfileHint);
			this.tabProfile.Controls.Add(this.labelProfileName);
			this.tabProfile.Controls.Add(this.textBoxProfileName);
			this.tabProfile.Controls.Add(this.labelProfileEmail);
			this.tabProfile.Controls.Add(this.textBoxProfileEmail);
			this.tabProfile.Controls.Add(this.labelColor);
			this.tabProfile.Controls.Add(this.buttonColor1);
			this.tabProfile.Controls.Add(this.buttonColor2);
			this.tabProfile.Controls.Add(this.buttonColor3);
			this.tabProfile.Controls.Add(this.buttonColor4);
			this.tabProfile.Controls.Add(this.buttonColor5);
			this.tabProfile.Controls.Add(this.buttonColor6);
			this.tabProfile.Controls.Add(this.buttonColor7);
			this.tabProfile.Controls.Add(this.buttonColor8);
			this.tabProfile.Controls.Add(this.labelProfileRole);
			this.tabProfile.Controls.Add(this.buttonSaveProfile);
			this.tabProfile.Controls.Add(this.groupPreview);
			this.tabProfile.Location = new System.Drawing.Point(4, 24);
			this.tabProfile.Name = "tabProfile";
			this.tabProfile.Padding = new Wisej.Web.Padding(8);
			this.tabProfile.Size = new System.Drawing.Size(992, 538);
			this.tabProfile.TabIndex = 0;
			this.tabProfile.Text = "Profile";
			//
			// labelProfileTitle
			//
			this.labelProfileTitle.AutoSize = true;
			this.labelProfileTitle.Location = new System.Drawing.Point(16, 16);
			this.labelProfileTitle.Name = "labelProfileTitle";
			this.labelProfileTitle.Size = new System.Drawing.Size(84, 20);
			this.labelProfileTitle.Text = "Your profile";
			this.labelProfileTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			//
			// labelProfileHint
			//
			this.labelProfileHint.AutoSize = true;
			this.labelProfileHint.Location = new System.Drawing.Point(16, 40);
			this.labelProfileHint.Name = "labelProfileHint";
			this.labelProfileHint.Size = new System.Drawing.Size(455, 15);
			this.labelProfileHint.Text = "How the team sees you in Relay: on records, tasks and activities.";
			this.labelProfileHint.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// labelProfileName
			//
			this.labelProfileName.AutoSize = true;
			this.labelProfileName.Location = new System.Drawing.Point(16, 75);
			this.labelProfileName.Name = "labelProfileName";
			this.labelProfileName.Size = new System.Drawing.Size(42, 15);
			this.labelProfileName.Text = "&Name:";
			//
			// textBoxProfileName
			//
			this.textBoxProfileName.Location = new System.Drawing.Point(130, 72);
			this.textBoxProfileName.Name = "textBoxProfileName";
			this.textBoxProfileName.Size = new System.Drawing.Size(260, 23);
			this.textBoxProfileName.TabIndex = 1;
			this.textBoxProfileName.TextChanged += new System.EventHandler(this.textBoxProfile_TextChanged);
			//
			// labelProfileEmail
			//
			this.labelProfileEmail.AutoSize = true;
			this.labelProfileEmail.Location = new System.Drawing.Point(16, 104);
			this.labelProfileEmail.Name = "labelProfileEmail";
			this.labelProfileEmail.Size = new System.Drawing.Size(49, 15);
			this.labelProfileEmail.Text = "&Email:";
			//
			// textBoxProfileEmail
			//
			this.textBoxProfileEmail.Location = new System.Drawing.Point(130, 101);
			this.textBoxProfileEmail.Name = "textBoxProfileEmail";
			this.textBoxProfileEmail.Size = new System.Drawing.Size(260, 23);
			this.textBoxProfileEmail.TabIndex = 2;
			this.textBoxProfileEmail.TextChanged += new System.EventHandler(this.textBoxProfile_TextChanged);
			//
			// labelColor
			//
			this.labelColor.AutoSize = true;
			this.labelColor.Location = new System.Drawing.Point(16, 138);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new System.Drawing.Size(98, 15);
			this.labelColor.Text = "Avatar colour:";
			//
			// buttonColor1
			//
			this.buttonColor1.Location = new System.Drawing.Point(130, 132);
			this.buttonColor1.Name = "buttonColor1";
			this.buttonColor1.Size = new System.Drawing.Size(28, 28);
			this.buttonColor1.TabIndex = 3;
			this.buttonColor1.Click += new System.EventHandler(this.buttonColor_Click);
			//
			// buttonColor2
			//
			this.buttonColor2.Location = new System.Drawing.Point(163, 132);
			this.buttonColor2.Name = "buttonColor2";
			this.buttonColor2.Size = new System.Drawing.Size(28, 28);
			this.buttonColor2.TabIndex = 4;
			this.buttonColor2.Click += new System.EventHandler(this.buttonColor_Click);
			//
			// buttonColor3
			//
			this.buttonColor3.Location = new System.Drawing.Point(196, 132);
			this.buttonColor3.Name = "buttonColor3";
			this.buttonColor3.Size = new System.Drawing.Size(28, 28);
			this.buttonColor3.TabIndex = 5;
			this.buttonColor3.Click += new System.EventHandler(this.buttonColor_Click);
			//
			// buttonColor4
			//
			this.buttonColor4.Location = new System.Drawing.Point(229, 132);
			this.buttonColor4.Name = "buttonColor4";
			this.buttonColor4.Size = new System.Drawing.Size(28, 28);
			this.buttonColor4.TabIndex = 6;
			this.buttonColor4.Click += new System.EventHandler(this.buttonColor_Click);
			//
			// buttonColor5
			//
			this.buttonColor5.Location = new System.Drawing.Point(262, 132);
			this.buttonColor5.Name = "buttonColor5";
			this.buttonColor5.Size = new System.Drawing.Size(28, 28);
			this.buttonColor5.TabIndex = 7;
			this.buttonColor5.Click += new System.EventHandler(this.buttonColor_Click);
			//
			// buttonColor6
			//
			this.buttonColor6.Location = new System.Drawing.Point(295, 132);
			this.buttonColor6.Name = "buttonColor6";
			this.buttonColor6.Size = new System.Drawing.Size(28, 28);
			this.buttonColor6.TabIndex = 8;
			this.buttonColor6.Click += new System.EventHandler(this.buttonColor_Click);
			//
			// buttonColor7
			//
			this.buttonColor7.Location = new System.Drawing.Point(328, 132);
			this.buttonColor7.Name = "buttonColor7";
			this.buttonColor7.Size = new System.Drawing.Size(28, 28);
			this.buttonColor7.TabIndex = 9;
			this.buttonColor7.Click += new System.EventHandler(this.buttonColor_Click);
			//
			// buttonColor8
			//
			this.buttonColor8.Location = new System.Drawing.Point(361, 132);
			this.buttonColor8.Name = "buttonColor8";
			this.buttonColor8.Size = new System.Drawing.Size(28, 28);
			this.buttonColor8.TabIndex = 10;
			this.buttonColor8.Click += new System.EventHandler(this.buttonColor_Click);
			//
			// labelProfileRole
			//
			this.labelProfileRole.AutoSize = true;
			this.labelProfileRole.Location = new System.Drawing.Point(130, 172);
			this.labelProfileRole.Name = "labelProfileRole";
			this.labelProfileRole.Size = new System.Drawing.Size(28, 15);
			this.labelProfileRole.Text = "Role";
			this.labelProfileRole.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// buttonSaveProfile
			//
			this.buttonSaveProfile.Location = new System.Drawing.Point(130, 200);
			this.buttonSaveProfile.Name = "buttonSaveProfile";
			this.buttonSaveProfile.Size = new System.Drawing.Size(92, 27);
			this.buttonSaveProfile.TabIndex = 12;
			this.buttonSaveProfile.Text = "&Save";
			this.buttonSaveProfile.Click += new System.EventHandler(this.buttonSaveProfile_Click);
			this.buttonSaveProfile.CssClass = "relay-primary";
			//
			// groupPreview
			//
			this.groupPreview.Controls.Add(this.avatarProfile);
			this.groupPreview.Controls.Add(this.labelPreviewName);
			this.groupPreview.Controls.Add(this.labelPreviewEmail);
			this.groupPreview.Location = new System.Drawing.Point(440, 64);
			this.groupPreview.Name = "groupPreview";
			this.groupPreview.Size = new System.Drawing.Size(300, 100);
			this.groupPreview.TabIndex = 13;
			this.groupPreview.TabStop = false;
			this.groupPreview.Text = "Preview";
			this.groupPreview.CssClass = "relay-card";
			//
			// avatarProfile
			//
			this.avatarProfile.AvatarSize = 56;
			this.avatarProfile.Location = new System.Drawing.Point(12, 24);
			this.avatarProfile.Name = "avatarProfile";
			this.avatarProfile.Size = new System.Drawing.Size(56, 56);
			this.avatarProfile.TabIndex = 1;
			//
			// labelPreviewName
			//
			this.labelPreviewName.Location = new System.Drawing.Point(80, 32);
			this.labelPreviewName.Name = "labelPreviewName";
			this.labelPreviewName.Size = new System.Drawing.Size(210, 20);
			this.labelPreviewName.Text = "Your name";
			this.labelPreviewName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.labelPreviewName.AutoEllipsis = true;
			//
			// labelPreviewEmail
			//
			this.labelPreviewEmail.Location = new System.Drawing.Point(80, 54);
			this.labelPreviewEmail.Name = "labelPreviewEmail";
			this.labelPreviewEmail.Size = new System.Drawing.Size(210, 18);
			this.labelPreviewEmail.Text = "";
			this.labelPreviewEmail.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelPreviewEmail.AutoEllipsis = true;
			//
			// tabUsers
			//
			this.tabUsers.Controls.Add(this.dataGridUsers);
			this.tabUsers.Controls.Add(this.usersStrip);
			this.tabUsers.Location = new System.Drawing.Point(4, 24);
			this.tabUsers.Name = "tabUsers";
			this.tabUsers.Padding = new Wisej.Web.Padding(8);
			this.tabUsers.Size = new System.Drawing.Size(992, 538);
			this.tabUsers.TabIndex = 0;
			this.tabUsers.Text = "Users";
			//
			// dataGridUsers
			//
			this.dataGridUsers.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colUserName,
			this.colUserEmail,
			this.colUserRole,
			this.colUserActive,
			this.colUserOwned});
			this.dataGridUsers.AllowUserToAddRows = false;
			this.dataGridUsers.AllowUserToDeleteRows = false;
			this.dataGridUsers.AllowUserToResizeRows = false;
			this.dataGridUsers.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridUsers.Dock = Wisej.Web.DockStyle.Fill;
			this.dataGridUsers.Location = new System.Drawing.Point(8, 35);
			this.dataGridUsers.MultiSelect = false;
			this.dataGridUsers.Name = "dataGridUsers";
			this.dataGridUsers.ReadOnly = false;
			this.dataGridUsers.RowHeadersVisible = false;
			this.dataGridUsers.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridUsers.Size = new System.Drawing.Size(400, 200);
			this.dataGridUsers.TabIndex = 1;
			this.dataGridUsers.RowTemplate.Height = 30;
			this.dataGridUsers.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.dataGridUsers_CellFormatting);
			this.dataGridUsers.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridUsers_CellValueChanged);
			this.dataGridUsers.DataError += new Wisej.Web.DataGridViewDataErrorEventHandler(this.grid_DataError);
			this.dataGridUsers.BorderStyle = Wisej.Web.BorderStyle.None;
			this.dataGridUsers.CssClass = "relay-grid";
			this.dataGridUsers.RowTemplate.Height = 40;
			//
			// colUserName
			//
			this.colUserName.DataPropertyName = "Name";
			this.colUserName.HeaderText = "Name";
			this.colUserName.Name = "colUserName";
			this.colUserName.ReadOnly = true;
			this.colUserName.Width = 200;
			this.colUserName.ImageMember = "AvatarImage";
			this.colUserName.TextMember = "Name";
			//
			// colUserEmail
			//
			this.colUserEmail.DataPropertyName = "Email";
			this.colUserEmail.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colUserEmail.MinimumWidth = 180;
			this.colUserEmail.HeaderText = "Email";
			this.colUserEmail.Name = "colUserEmail";
			this.colUserEmail.ReadOnly = true;
			//
			// colUserRole
			//
			this.colUserRole.Items.AddRange(new object[] {
			"Admin",
			"Manager",
			"Sales"});
			this.colUserRole.DataPropertyName = "Role";
			this.colUserRole.HeaderText = "Role";
			this.colUserRole.Name = "colUserRole";
			this.colUserRole.Width = 110;
			//
			// colUserActive
			//
			this.colUserActive.DataPropertyName = "Active";
			this.colUserActive.HeaderText = "Active";
			this.colUserActive.Name = "colUserActive";
			this.colUserActive.Width = 60;
			//
			// colUserOwned
			//
			this.colUserOwned.DataPropertyName = "OwnedText";
			this.colUserOwned.HeaderText = "Owned records";
			this.colUserOwned.Name = "colUserOwned";
			this.colUserOwned.ReadOnly = true;
			this.colUserOwned.Width = 240;
			//
			// usersStrip
			//
			this.usersStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonInvite,
			this.labelUsersTitle,
			this.labelUsersHint});
			this.usersStrip.Location = new System.Drawing.Point(8, 8);
			this.usersStrip.Name = "usersStrip";
			this.usersStrip.Padding = new Wisej.Web.Padding(2);
			this.usersStrip.Size = new System.Drawing.Size(800, 27);
			this.usersStrip.TabIndex = 0;
			this.usersStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.usersStrip.BackColor = System.Drawing.SystemColors.Window;
			this.usersStrip.CssClass = "relay-toolbar";
			//
			// buttonInvite
			//
			this.buttonInvite.Tag = "plus";
			this.buttonInvite.Name = "buttonInvite";
			this.buttonInvite.Text = "Invite user...";
			this.buttonInvite.Click += new System.EventHandler(this.buttonInvite_Click);
			//
			// labelUsersTitle
			//
			this.labelUsersTitle.Name = "labelUsersTitle";
			this.labelUsersTitle.Text = "Team";
			//
			// labelUsersHint
			//
			this.labelUsersHint.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelUsersHint.Name = "labelUsersHint";
			this.labelUsersHint.Text = "Invite people, change their role, or deactivate who left the team.";
			//
			// tabStages
			//
			this.tabStages.Controls.Add(this.dataGridStages);
			this.tabStages.Controls.Add(this.stagesStrip);
			this.tabStages.Location = new System.Drawing.Point(4, 24);
			this.tabStages.Name = "tabStages";
			this.tabStages.Padding = new Wisej.Web.Padding(8);
			this.tabStages.Size = new System.Drawing.Size(992, 538);
			this.tabStages.TabIndex = 0;
			this.tabStages.Text = "Pipeline stages";
			//
			// dataGridStages
			//
			this.dataGridStages.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colStageOrder,
			this.colStageName,
			this.colStageProbability,
			this.colStageKind,
			this.colStageDeals});
			this.dataGridStages.AllowUserToAddRows = false;
			this.dataGridStages.AllowUserToDeleteRows = false;
			this.dataGridStages.AllowUserToResizeRows = false;
			this.dataGridStages.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridStages.Dock = Wisej.Web.DockStyle.Fill;
			this.dataGridStages.Location = new System.Drawing.Point(8, 35);
			this.dataGridStages.MultiSelect = false;
			this.dataGridStages.Name = "dataGridStages";
			this.dataGridStages.ReadOnly = false;
			this.dataGridStages.RowHeadersVisible = false;
			this.dataGridStages.SelectionMode = Wisej.Web.DataGridViewSelectionMode.CellSelect;
			this.dataGridStages.Size = new System.Drawing.Size(400, 200);
			this.dataGridStages.TabIndex = 1;
			this.dataGridStages.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.dataGridStages_CellFormatting);
			this.dataGridStages.CellValidating += new Wisej.Web.DataGridViewCellValidatingEventHandler(this.dataGridStages_CellValidating);
			this.dataGridStages.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridStages_CellValueChanged);
			this.dataGridStages.CurrentCellChanged += new System.EventHandler(this.dataGridStages_CurrentCellChanged);
			this.dataGridStages.DataError += new Wisej.Web.DataGridViewDataErrorEventHandler(this.grid_DataError);
			this.dataGridStages.BorderStyle = Wisej.Web.BorderStyle.None;
			this.dataGridStages.CssClass = "relay-grid";
			this.dataGridStages.RowTemplate.Height = 40;
			//
			// colStageOrder
			//
			dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colStageOrder.DataPropertyName = "Order";
			this.colStageOrder.DefaultCellStyle = dataGridViewCellStyle2;
			this.colStageOrder.HeaderText = "#";
			this.colStageOrder.Name = "colStageOrder";
			this.colStageOrder.ReadOnly = true;
			this.colStageOrder.Width = 40;
			//
			// colStageName
			//
			this.colStageName.DataPropertyName = "Name";
			this.colStageName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colStageName.MinimumWidth = 160;
			this.colStageName.HeaderText = "Name";
			this.colStageName.Name = "colStageName";
			//
			// colStageProbability
			//
			dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colStageProbability.DataPropertyName = "Probability";
			this.colStageProbability.DefaultCellStyle = dataGridViewCellStyle3;
			this.colStageProbability.HeaderText = "Probability %";
			this.colStageProbability.Name = "colStageProbability";
			this.colStageProbability.Width = 100;
			//
			// colStageKind
			//
			this.colStageKind.DataPropertyName = "Kind";
			this.colStageKind.HeaderText = "Type";
			this.colStageKind.Name = "colStageKind";
			this.colStageKind.ReadOnly = true;
			this.colStageKind.Width = 80;
			//
			// colStageDeals
			//
			dataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colStageDeals.DataPropertyName = "Deals";
			this.colStageDeals.DefaultCellStyle = dataGridViewCellStyle4;
			this.colStageDeals.HeaderText = "Deals";
			this.colStageDeals.Name = "colStageDeals";
			this.colStageDeals.ReadOnly = true;
			this.colStageDeals.Width = 70;
			//
			// stagesStrip
			//
			this.stagesStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.buttonMoveUp,
			this.buttonMoveDown,
			this.buttonSaveStages,
			this.stagesSeparator,
			this.labelStagesHint});
			this.stagesStrip.Location = new System.Drawing.Point(8, 8);
			this.stagesStrip.Name = "stagesStrip";
			this.stagesStrip.Padding = new Wisej.Web.Padding(2);
			this.stagesStrip.Size = new System.Drawing.Size(800, 27);
			this.stagesStrip.TabIndex = 0;
			this.stagesStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.stagesStrip.BackColor = System.Drawing.SystemColors.Window;
			this.stagesStrip.CssClass = "relay-toolbar";
			//
			// buttonMoveUp
			//
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Text = "Move up";
			this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
			//
			// buttonMoveDown
			//
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Text = "Move down";
			this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
			//
			// buttonSaveStages
			//
			this.buttonSaveStages.Enabled = false;
			this.buttonSaveStages.Name = "buttonSaveStages";
			this.buttonSaveStages.Text = "Save";
			this.buttonSaveStages.Click += new System.EventHandler(this.buttonSaveStages_Click);
			//
			// stagesSeparator
			//
			this.stagesSeparator.Name = "stagesSeparator";
			this.stagesSeparator.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// labelStagesHint
			//
			this.labelStagesHint.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelStagesHint.Name = "labelStagesHint";
			this.labelStagesHint.Text = "Rename, reorder and set the win probability. Won and Lost stay last; open deals get the new probability.";
			//
			// tabTags
			//
			this.tabTags.Controls.Add(this.dataGridTags);
			this.tabTags.Controls.Add(this.tagsStrip);
			this.tabTags.Location = new System.Drawing.Point(4, 24);
			this.tabTags.Name = "tabTags";
			this.tabTags.Padding = new Wisej.Web.Padding(8);
			this.tabTags.Size = new System.Drawing.Size(992, 538);
			this.tabTags.TabIndex = 0;
			this.tabTags.Text = "Tags";
			//
			// dataGridTags
			//
			this.dataGridTags.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
			this.colTagName,
			this.colTagUsage,
			this.colTagCount});
			this.dataGridTags.AllowUserToAddRows = false;
			this.dataGridTags.AllowUserToDeleteRows = false;
			this.dataGridTags.AllowUserToResizeRows = false;
			this.dataGridTags.ColumnHeadersHeightSizeMode = Wisej.Web.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridTags.Dock = Wisej.Web.DockStyle.Fill;
			this.dataGridTags.Location = new System.Drawing.Point(8, 35);
			this.dataGridTags.MultiSelect = false;
			this.dataGridTags.Name = "dataGridTags";
			this.dataGridTags.ReadOnly = true;
			this.dataGridTags.RowHeadersVisible = false;
			this.dataGridTags.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridTags.Size = new System.Drawing.Size(400, 200);
			this.dataGridTags.TabIndex = 1;
			this.dataGridTags.CellFormatting += new Wisej.Web.DataGridViewCellFormattingEventHandler(this.dataGridTags_CellFormatting);
			this.dataGridTags.KeyDown += new Wisej.Web.KeyEventHandler(this.dataGridTags_KeyDown);
			this.dataGridTags.BorderStyle = Wisej.Web.BorderStyle.None;
			this.dataGridTags.CssClass = "relay-grid";
			this.dataGridTags.RowTemplate.Height = 40;
			//
			// colTagName
			//
			this.colTagName.DataPropertyName = "Name";
			this.colTagName.HeaderText = "Tag";
			this.colTagName.Name = "colTagName";
			this.colTagName.Width = 200;
			this.colTagName.Variant = Wisej.Web.ChipVariant.Soft;
			//
			// colTagUsage
			//
			this.colTagUsage.DataPropertyName = "UsageText";
			this.colTagUsage.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTagUsage.MinimumWidth = 200;
			this.colTagUsage.HeaderText = "Used by";
			this.colTagUsage.Name = "colTagUsage";
			//
			// colTagCount
			//
			dataGridViewCellStyle6.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colTagCount.DataPropertyName = "Usage";
			this.colTagCount.DefaultCellStyle = dataGridViewCellStyle6;
			this.colTagCount.HeaderText = "Records";
			this.colTagCount.Name = "colTagCount";
			this.colTagCount.Width = 80;
			//
			// tagsStrip
			//
			this.tagsStrip.Buttons.AddRange(new Wisej.Web.ToolBarButton[] {
			this.labelNewTag,
			this.textNewTagHost,
			this.buttonAddTag,
			this.buttonRemoveTag,
			this.tagsSeparator,
			this.labelTagsTitle,
			this.labelTagsHint});
			this.tagsStrip.Location = new System.Drawing.Point(8, 8);
			this.tagsStrip.Name = "tagsStrip";
			this.tagsStrip.Padding = new Wisej.Web.Padding(2);
			this.tagsStrip.Size = new System.Drawing.Size(800, 27);
			this.tagsStrip.TabIndex = 0;
			this.tagsStrip.TextAlign = Wisej.Web.ToolBarTextAlign.Right;
			this.tagsStrip.BackColor = System.Drawing.SystemColors.Window;
			this.tagsStrip.CssClass = "relay-toolbar";
			//
			// labelNewTag
			//
			this.labelNewTag.Name = "labelNewTag";
			this.labelNewTag.Text = "New tag:";
			//
			// textNewTag
			//
			this.textNewTag.BorderStyle = Wisej.Web.BorderStyle.Solid;
			this.textNewTag.Size = new System.Drawing.Size(160, 23);
			this.textNewTag.Name = "textNewTag";
			this.textNewTagHost.Control = this.textNewTag;
			this.textNewTagHost.Name = "textNewTagHost";
			this.textNewTag.KeyDown += new Wisej.Web.KeyEventHandler(this.textNewTag_KeyDown);
			//
			// buttonAddTag
			//
			this.buttonAddTag.Tag = "plus";
			this.buttonAddTag.Name = "buttonAddTag";
			this.buttonAddTag.Text = "Add tag";
			this.buttonAddTag.Click += new System.EventHandler(this.buttonAddTag_Click);
			//
			// buttonRemoveTag
			//
			this.buttonRemoveTag.Tag = "trash";
			this.buttonRemoveTag.Name = "buttonRemoveTag";
			this.buttonRemoveTag.Text = "Remove";
			this.buttonRemoveTag.Click += new System.EventHandler(this.buttonRemoveTag_Click);
			//
			// tagsSeparator
			//
			this.tagsSeparator.Name = "tagsSeparator";
			this.tagsSeparator.Style = Wisej.Web.ToolBarButtonStyle.Separator;
			//
			// labelTagsTitle
			//
			this.labelTagsTitle.Name = "labelTagsTitle";
			this.labelTagsTitle.Text = "Tags";
			//
			// labelTagsHint
			//
			this.labelTagsHint.ForeColor = System.Drawing.SystemColors.GrayText;
			this.labelTagsHint.Name = "labelTagsHint";
			this.labelTagsHint.Text = "Tags label companies and contacts. Removing a tag takes it off every record.";
			//
			// tabDemo
			//
			this.tabDemo.Controls.Add(this.labelDemoTitle);
			this.tabDemo.Controls.Add(this.labelDemoText);
			this.tabDemo.Controls.Add(this.labelDemoNote);
			this.tabDemo.Controls.Add(this.buttonResetDemo);
			this.tabDemo.Location = new System.Drawing.Point(4, 24);
			this.tabDemo.Name = "tabDemo";
			this.tabDemo.Padding = new Wisej.Web.Padding(8);
			this.tabDemo.Size = new System.Drawing.Size(992, 538);
			this.tabDemo.TabIndex = 0;
			this.tabDemo.Text = "Demo data";
			//
			// labelDemoTitle
			//
			this.labelDemoTitle.AutoSize = true;
			this.labelDemoTitle.Location = new System.Drawing.Point(16, 16);
			this.labelDemoTitle.Name = "labelDemoTitle";
			this.labelDemoTitle.Size = new System.Drawing.Size(63, 20);
			this.labelDemoTitle.Text = "Demo data";
			this.labelDemoTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
			//
			// labelDemoText
			//
			this.labelDemoText.Location = new System.Drawing.Point(16, 44);
			this.labelDemoText.Name = "labelDemoText";
			this.labelDemoText.Size = new System.Drawing.Size(600, 36);
			this.labelDemoText.Text = "Relay ships with fictional sample data: users, companies, contacts, deals, activities and tasks. Resetting deletes everything you added or changed and creates the sample data again. This cannot be undone.";
			//
			// labelDemoNote
			//
			this.labelDemoNote.AutoSize = true;
			this.labelDemoNote.Location = new System.Drawing.Point(16, 86);
			this.labelDemoNote.Name = "labelDemoNote";
			this.labelDemoNote.Size = new System.Drawing.Size(343, 15);
			this.labelDemoNote.Text = "Everyone using this database sees the reset data.";
			this.labelDemoNote.ForeColor = System.Drawing.SystemColors.GrayText;
			//
			// buttonResetDemo
			//
			this.buttonResetDemo.Location = new System.Drawing.Point(16, 114);
			this.buttonResetDemo.Name = "buttonResetDemo";
			this.buttonResetDemo.Size = new System.Drawing.Size(140, 27);
			this.buttonResetDemo.TabIndex = 4;
			this.buttonResetDemo.Text = "&Reset demo data...";
			this.buttonResetDemo.Click += new System.EventHandler(this.buttonResetDemo_Click);
			this.buttonResetDemo.CssClass = "relay-secondary";
			//
			// SettingsView
			//
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.labelSubtitle);
			this.CssClass = "relay-card";
			this.Name = "SettingsView";
			this.Size = new System.Drawing.Size(1000, 600);
			this.Load += new System.EventHandler(this.SettingsView_Load);
			this.tabDemo.ResumeLayout(false);
			this.tabDemo.PerformLayout();
			this.tagsStrip.ResumeLayout(false);
			this.tagsStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridTags)).EndInit();
			this.tabTags.ResumeLayout(false);
			this.tabTags.PerformLayout();
			this.stagesStrip.ResumeLayout(false);
			this.stagesStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridStages)).EndInit();
			this.tabStages.ResumeLayout(false);
			this.tabStages.PerformLayout();
			this.usersStrip.ResumeLayout(false);
			this.usersStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridUsers)).EndInit();
			this.tabUsers.ResumeLayout(false);
			this.tabUsers.PerformLayout();
			this.groupPreview.ResumeLayout(false);
			this.groupPreview.PerformLayout();
			this.tabProfile.ResumeLayout(false);
			this.tabProfile.PerformLayout();
			this.tabControl.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.ErrorProvider errorProvider;
		private Wisej.Web.TabControl tabControl;
		private Wisej.Web.Label labelSubtitle;
		private Wisej.Web.TabPage tabProfile;
		private Wisej.Web.Label labelProfileTitle;
		private Wisej.Web.Label labelProfileHint;
		private Wisej.Web.Label labelProfileName;
		private Wisej.Web.TextBox textBoxProfileName;
		private Wisej.Web.Label labelProfileEmail;
		private Wisej.Web.TextBox textBoxProfileEmail;
		private Wisej.Web.Label labelColor;
		private Wisej.Web.Button buttonColor1;
		private Wisej.Web.Button buttonColor2;
		private Wisej.Web.Button buttonColor3;
		private Wisej.Web.Button buttonColor4;
		private Wisej.Web.Button buttonColor5;
		private Wisej.Web.Button buttonColor6;
		private Wisej.Web.Button buttonColor7;
		private Wisej.Web.Button buttonColor8;
		private Wisej.Web.Label labelProfileRole;
		private Wisej.Web.Button buttonSaveProfile;
		private Wisej.Web.GroupBox groupPreview;
		private Wisej.Web.Avatar avatarProfile;
		private Wisej.Web.Label labelPreviewName;
		private Wisej.Web.Label labelPreviewEmail;
		private Wisej.Web.TabPage tabUsers;
		private Wisej.Web.DataGridView dataGridUsers;
		private Wisej.Web.DataGridViewAvatarColumn colUserName;
		private Wisej.Web.DataGridViewTextBoxColumn colUserEmail;
		private Wisej.Web.DataGridViewComboBoxColumn colUserRole;
		private Wisej.Web.DataGridViewCheckBoxColumn colUserActive;
		private Wisej.Web.DataGridViewTextBoxColumn colUserOwned;
		private Wisej.Web.ToolBar usersStrip;
		private Wisej.Web.ToolBarButton buttonInvite;
		private Wisej.Web.ToolBarButton labelUsersTitle;
		private Wisej.Web.ToolBarButton labelUsersHint;
		private Wisej.Web.TabPage tabStages;
		private Wisej.Web.DataGridView dataGridStages;
		private Wisej.Web.DataGridViewTextBoxColumn colStageOrder;
		private Wisej.Web.DataGridViewTextBoxColumn colStageName;
		private Wisej.Web.DataGridViewTextBoxColumn colStageProbability;
		private Wisej.Web.DataGridViewTextBoxColumn colStageKind;
		private Wisej.Web.DataGridViewTextBoxColumn colStageDeals;
		private Wisej.Web.ToolBar stagesStrip;
		private Wisej.Web.ToolBarButton buttonMoveUp;
		private Wisej.Web.ToolBarButton buttonMoveDown;
		private Wisej.Web.ToolBarButton buttonSaveStages;
		private Wisej.Web.ToolBarButton stagesSeparator;
		private Wisej.Web.ToolBarButton labelStagesHint;
		private Wisej.Web.TabPage tabTags;
		private Wisej.Web.DataGridView dataGridTags;
		private Wisej.Web.DataGridViewChipColumn colTagName;
		private Wisej.Web.DataGridViewTextBoxColumn colTagUsage;
		private Wisej.Web.DataGridViewTextBoxColumn colTagCount;
		private Wisej.Web.ToolBar tagsStrip;
		private Wisej.Web.ToolBarButton labelNewTag;
		private Wisej.Web.TextBox textNewTag;
		private Wisej.Web.ToolBarControl textNewTagHost;
		private Wisej.Web.ToolBarButton buttonAddTag;
		private Wisej.Web.ToolBarButton buttonRemoveTag;
		private Wisej.Web.ToolBarButton tagsSeparator;
		private Wisej.Web.ToolBarButton labelTagsTitle;
		private Wisej.Web.ToolBarButton labelTagsHint;
		private Wisej.Web.TabPage tabDemo;
		private Wisej.Web.Label labelDemoTitle;
		private Wisej.Web.Label labelDemoText;
		private Wisej.Web.Label labelDemoNote;
		private Wisej.Web.Button buttonResetDemo;
	}
}
