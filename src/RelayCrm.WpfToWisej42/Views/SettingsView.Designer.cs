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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			this.tabControl = new Wisej.Web.TabControl();
			this.tabProfile = new Wisej.Web.TabPage();
			this.panelProfile = new Wisej.Web.Panel();
			this.panelSaveProfile = new Wisej.Web.Panel();
			this.buttonSaveProfile = new Wisej.Web.Button();
			this.labelProfileError = new Wisej.Web.Label();
			this.tableProfile = new Wisej.Web.TableLayoutPanel();
			this.labelName = new Wisej.Web.Label();
			this.textBoxProfileName = new Wisej.Web.TextBox();
			this.labelEmail = new Wisej.Web.Label();
			this.textBoxProfileEmail = new Wisej.Web.TextBox();
			this.labelColor = new Wisej.Web.Label();
			this.listColors = new Wisej.Web.FlowLayoutPanel();
			this.panelProfileHeader = new Wisej.Web.Panel();
			this.panelProfileNames = new Wisej.Web.Panel();
			this.labelProfileRole = new Wisej.Web.Label();
			this.labelProfileName = new Wisej.Web.Label();
			this.avatarProfile = new Wisej.Web.Avatar();
			this.tabUsers = new Wisej.Web.TabPage();
			this.gridUsers = new Wisej.Web.DataGridView();
			this.colUserName = new Wisej.Web.DataGridViewAvatarColumn();
			this.colEmail = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colRole = new Wisej.Web.DataGridViewComboBoxColumn();
			this.colActive = new Wisej.Web.DataGridViewCheckBoxColumn();
			this.colOwns = new Wisej.Web.DataGridViewTextBoxColumn();
			this.panelUsersHeader = new Wisej.Web.Panel();
			this.buttonInvite = new Wisej.Web.Button();
			this.labelUsersHint = new Wisej.Web.Label();
			this.labelUsersTitle = new Wisej.Web.Label();
			this.tabStages = new Wisej.Web.TabPage();
			this.gridStages = new Wisej.Web.DataGridView();
			this.colStageOrder = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStageName = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStageProbability = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStageKind = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colStageDeals = new Wisej.Web.DataGridViewTextBoxColumn();
			this.panelStageButtons = new Wisej.Web.Panel();
			this.buttonMoveUp = new Wisej.Web.Button();
			this.buttonMoveDown = new Wisej.Web.Button();
			this.buttonSaveStages = new Wisej.Web.Button();
			this.labelStagesHint = new Wisej.Web.Label();
			this.tabTags = new Wisej.Web.TabPage();
			this.gridTags = new Wisej.Web.DataGridView();
			this.colTagName = new Wisej.Web.DataGridViewChipColumn();
			this.colTagUsage = new Wisej.Web.DataGridViewTextBoxColumn();
			this.panelAddTag = new Wisej.Web.FlowLayoutPanel();
			this.textBoxNewTag = new Wisej.Web.TextBox();
			this.buttonAddTag = new Wisej.Web.Button();
			this.buttonRemoveTag = new Wisej.Web.Button();
			this.labelTagsHint = new Wisej.Web.Label();
			this.labelTagsTitle = new Wisej.Web.Label();
			this.tabDemo = new Wisej.Web.TabPage();
			this.panelDemo = new Wisej.Web.Panel();
			this.buttonResetDemo = new Wisej.Web.Button();
			this.labelDemoNote = new Wisej.Web.Label();
			this.labelDemoText = new Wisej.Web.Label();
			this.tabControl.SuspendLayout();
			this.tabProfile.SuspendLayout();
			this.panelProfile.SuspendLayout();
			this.panelSaveProfile.SuspendLayout();
			this.tableProfile.SuspendLayout();
			this.panelProfileHeader.SuspendLayout();
			this.panelProfileNames.SuspendLayout();
			this.tabUsers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
			this.panelUsersHeader.SuspendLayout();
			this.tabStages.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridStages)).BeginInit();
			this.panelStageButtons.SuspendLayout();
			this.tabTags.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridTags)).BeginInit();
			this.panelAddTag.SuspendLayout();
			this.tabDemo.SuspendLayout();
			this.panelDemo.SuspendLayout();
			this.SuspendLayout();
			//
			// tabControl
			//
			this.tabControl.Controls.Add(this.tabProfile);
			this.tabControl.Controls.Add(this.tabUsers);
			this.tabControl.Controls.Add(this.tabStages);
			this.tabControl.Controls.Add(this.tabTags);
			this.tabControl.Controls.Add(this.tabDemo);
			this.tabControl.Dock = Wisej.Web.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.Size = new System.Drawing.Size(968, 576);
			this.tabControl.TabIndex = 1;
			//
			// tabProfile
			//
			this.tabProfile.AutoScroll = true;
			this.tabProfile.Controls.Add(this.panelProfile);
			this.tabProfile.Location = new System.Drawing.Point(1, 41);
			this.tabProfile.Name = "tabProfile";
			this.tabProfile.Size = new System.Drawing.Size(966, 534);
			this.tabProfile.Text = "Profile";
			//
			// panelProfile
			//
			this.panelProfile.Controls.Add(this.panelSaveProfile);
			this.panelProfile.Controls.Add(this.labelProfileError);
			this.panelProfile.Controls.Add(this.tableProfile);
			this.panelProfile.Controls.Add(this.panelProfileHeader);
			this.panelProfile.Location = new System.Drawing.Point(12, 12);
			this.panelProfile.Name = "panelProfile";
			this.panelProfile.Size = new System.Drawing.Size(460, 262);
			this.panelProfile.TabIndex = 0;
			//
			// panelSaveProfile
			//
			this.panelSaveProfile.Controls.Add(this.buttonSaveProfile);
			this.panelSaveProfile.Dock = Wisej.Web.DockStyle.Top;
			this.panelSaveProfile.Location = new System.Drawing.Point(0, 218);
			this.panelSaveProfile.Name = "panelSaveProfile";
			this.panelSaveProfile.Size = new System.Drawing.Size(460, 44);
			this.panelSaveProfile.TabIndex = 3;
			//
			// buttonSaveProfile
			//
			this.buttonSaveProfile.CssClass = "relay-primary";
			this.buttonSaveProfile.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/check-lg.svg";
			this.buttonSaveProfile.Location = new System.Drawing.Point(0, 14);
			this.buttonSaveProfile.Name = "buttonSaveProfile";
			this.buttonSaveProfile.Size = new System.Drawing.Size(130, 32);
			this.buttonSaveProfile.TabIndex = 0;
			this.buttonSaveProfile.Text = "Save profile";
			this.buttonSaveProfile.Click += new System.EventHandler(this.buttonSaveProfile_Click);
			//
			// labelProfileError
			//
			this.labelProfileError.Dock = Wisej.Web.DockStyle.Top;
			this.labelProfileError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(43)))), ((int)(((byte)(28)))));
			this.labelProfileError.Location = new System.Drawing.Point(0, 184);
			this.labelProfileError.Name = "labelProfileError";
			this.labelProfileError.Padding = new Wisej.Web.Padding(0, 10, 0, 0);
			this.labelProfileError.Size = new System.Drawing.Size(460, 34);
			this.labelProfileError.TabIndex = 2;
			this.labelProfileError.Visible = false;
			//
			// tableProfile
			//
			this.tableProfile.ColumnCount = 2;
			this.tableProfile.ColumnStyles.Add(new Wisej.Web.ColumnStyle());
			this.tableProfile.ColumnStyles.Add(new Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 100F));
			this.tableProfile.Controls.Add(this.labelName, 0, 0);
			this.tableProfile.Controls.Add(this.textBoxProfileName, 1, 0);
			this.tableProfile.Controls.Add(this.labelEmail, 0, 1);
			this.tableProfile.Controls.Add(this.textBoxProfileEmail, 1, 1);
			this.tableProfile.Controls.Add(this.labelColor, 0, 2);
			this.tableProfile.Controls.Add(this.listColors, 1, 2);
			this.tableProfile.Dock = Wisej.Web.DockStyle.Top;
			this.tableProfile.Location = new System.Drawing.Point(0, 70);
			this.tableProfile.Name = "tableProfile";
			this.tableProfile.RowCount = 3;
			this.tableProfile.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableProfile.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableProfile.RowStyles.Add(new Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 38F));
			this.tableProfile.Size = new System.Drawing.Size(460, 114);
			this.tableProfile.TabIndex = 1;
			this.tableProfile.TabStop = true;
			//
			// labelName
			//
			this.labelName.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelName.AutoSize = true;
			this.labelName.Location = new System.Drawing.Point(0, 11);
			this.labelName.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(41, 16);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "Name:";
			//
			// textBoxProfileName
			//
			this.textBoxProfileName.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxProfileName.Location = new System.Drawing.Point(103, 4);
			this.textBoxProfileName.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxProfileName.Name = "textBoxProfileName";
			this.textBoxProfileName.Size = new System.Drawing.Size(357, 30);
			this.textBoxProfileName.TabIndex = 1;
			this.textBoxProfileName.TextChanged += new System.EventHandler(this.textBoxProfile_TextChanged);
			//
			// labelEmail
			//
			this.labelEmail.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(0, 49);
			this.labelEmail.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(39, 16);
			this.labelEmail.TabIndex = 2;
			this.labelEmail.Text = "Email:";
			//
			// textBoxProfileEmail
			//
			this.textBoxProfileEmail.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.textBoxProfileEmail.Location = new System.Drawing.Point(103, 42);
			this.textBoxProfileEmail.Margin = new Wisej.Web.Padding(0, 4, 0, 4);
			this.textBoxProfileEmail.Name = "textBoxProfileEmail";
			this.textBoxProfileEmail.Size = new System.Drawing.Size(357, 30);
			this.textBoxProfileEmail.TabIndex = 3;
			this.textBoxProfileEmail.TextChanged += new System.EventHandler(this.textBoxProfile_TextChanged);
			//
			// labelColor
			//
			this.labelColor.Anchor = Wisej.Web.AnchorStyles.Left;
			this.labelColor.AutoSize = true;
			this.labelColor.Location = new System.Drawing.Point(0, 87);
			this.labelColor.Margin = new Wisej.Web.Padding(0, 0, 12, 0);
			this.labelColor.Name = "labelColor";
			this.labelColor.Size = new System.Drawing.Size(91, 16);
			this.labelColor.TabIndex = 4;
			this.labelColor.Text = "Avatar colour:";
			//
			// listColors
			//
			this.listColors.Anchor = Wisej.Web.AnchorStyles.Left;
			this.listColors.Location = new System.Drawing.Point(103, 81);
			this.listColors.Margin = new Wisej.Web.Padding(0);
			this.listColors.Name = "listColors";
			this.listColors.Size = new System.Drawing.Size(280, 28);
			this.listColors.TabIndex = 5;
			this.listColors.TabStop = true;
			//
			// panelProfileHeader
			//
			this.panelProfileHeader.Controls.Add(this.panelProfileNames);
			this.panelProfileHeader.Controls.Add(this.avatarProfile);
			this.panelProfileHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelProfileHeader.Location = new System.Drawing.Point(0, 0);
			this.panelProfileHeader.Name = "panelProfileHeader";
			this.panelProfileHeader.Padding = new Wisej.Web.Padding(0, 0, 0, 14);
			this.panelProfileHeader.Size = new System.Drawing.Size(460, 70);
			this.panelProfileHeader.TabIndex = 0;
			//
			// panelProfileNames
			//
			this.panelProfileNames.Controls.Add(this.labelProfileRole);
			this.panelProfileNames.Controls.Add(this.labelProfileName);
			this.panelProfileNames.Dock = Wisej.Web.DockStyle.Fill;
			this.panelProfileNames.Location = new System.Drawing.Point(56, 0);
			this.panelProfileNames.Name = "panelProfileNames";
			this.panelProfileNames.Padding = new Wisej.Web.Padding(12, 8, 0, 0);
			this.panelProfileNames.Size = new System.Drawing.Size(404, 56);
			this.panelProfileNames.TabIndex = 1;
			//
			// labelProfileRole
			//
			this.labelProfileRole.Dock = Wisej.Web.DockStyle.Top;
			this.labelProfileRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelProfileRole.Location = new System.Drawing.Point(12, 30);
			this.labelProfileRole.Name = "labelProfileRole";
			this.labelProfileRole.Size = new System.Drawing.Size(392, 20);
			this.labelProfileRole.TabIndex = 1;
			//
			// labelProfileName
			//
			this.labelProfileName.AutoEllipsis = true;
			this.labelProfileName.Dock = Wisej.Web.DockStyle.Top;
			this.labelProfileName.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelProfileName.Location = new System.Drawing.Point(12, 8);
			this.labelProfileName.Name = "labelProfileName";
			this.labelProfileName.Size = new System.Drawing.Size(392, 22);
			this.labelProfileName.TabIndex = 0;
			//
			// avatarProfile
			//
			this.avatarProfile.AvatarSize = 56;
			this.avatarProfile.Dock = Wisej.Web.DockStyle.Left;
			this.avatarProfile.Location = new System.Drawing.Point(0, 0);
			this.avatarProfile.Name = "avatarProfile";
			this.avatarProfile.Size = new System.Drawing.Size(56, 56);
			this.avatarProfile.TabIndex = 0;
			//
			// tabUsers
			//
			this.tabUsers.Controls.Add(this.gridUsers);
			this.tabUsers.Controls.Add(this.panelUsersHeader);
			this.tabUsers.Location = new System.Drawing.Point(1, 41);
			this.tabUsers.Name = "tabUsers";
			this.tabUsers.Padding = new Wisej.Web.Padding(8);
			this.tabUsers.Size = new System.Drawing.Size(966, 534);
			this.tabUsers.Text = "Users";
			//
			// gridUsers
			//
			this.gridUsers.AllowUserToResizeRows = false;
			this.gridUsers.AutoGenerateColumns = false;
			this.gridUsers.BorderStyle = Wisej.Web.BorderStyle.None;
			this.gridUsers.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colUserName,
            this.colEmail,
            this.colRole,
            this.colActive,
            this.colOwns});
			this.gridUsers.CssClass = "relay-grid";
			this.gridUsers.Dock = Wisej.Web.DockStyle.Fill;
			this.gridUsers.Location = new System.Drawing.Point(8, 58);
			this.gridUsers.MultiSelect = false;
			this.gridUsers.Name = "gridUsers";
			this.gridUsers.RowHeadersVisible = false;
			this.gridUsers.RowTemplate.Height = 40;
			this.gridUsers.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.gridUsers.ShowColumnVisibilityMenu = false;
			this.gridUsers.Size = new System.Drawing.Size(950, 468);
			this.gridUsers.TabIndex = 1;
			this.gridUsers.CellValueChanged += new Wisej.Web.DataGridViewCellEventHandler(this.gridUsers_CellValueChanged);
			//
			// colUserName
			//
			this.colUserName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colUserName.DataPropertyName = "Name";
			this.colUserName.FillWeight = 150F;
			this.colUserName.HeaderText = "Name";
			this.colUserName.Name = "colUserName";
			this.colUserName.ReadOnly = true;
			this.colUserName.AutoColor = true;
			this.colUserName.TextMember = "Name";
			//
			// colEmail
			//
			this.colEmail.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colEmail.DataPropertyName = "Email";
			this.colEmail.FillWeight = 200F;
			this.colEmail.HeaderText = "Email";
			this.colEmail.Name = "colEmail";
			this.colEmail.ReadOnly = true;
			//
			// colRole
			//
			this.colRole.DataPropertyName = "Role";
			this.colRole.HeaderText = "Role";
			this.colRole.Name = "colRole";
			this.colRole.Width = 120;
			//
			// colActive
			//
			this.colActive.DataPropertyName = "Active";
			this.colActive.HeaderText = "Active";
			this.colActive.Name = "colActive";
			this.colActive.Width = 60;
			//
			// colOwns
			//
			this.colOwns.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colOwns.DataPropertyName = "OwnedText";
			this.colOwns.FillWeight = 200F;
			this.colOwns.HeaderText = "Owns";
			this.colOwns.Name = "colOwns";
			this.colOwns.ReadOnly = true;
			//
			// panelUsersHeader
			//
			this.panelUsersHeader.Controls.Add(this.buttonInvite);
			this.panelUsersHeader.Controls.Add(this.labelUsersHint);
			this.panelUsersHeader.Controls.Add(this.labelUsersTitle);
			this.panelUsersHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelUsersHeader.Location = new System.Drawing.Point(8, 8);
			this.panelUsersHeader.Name = "panelUsersHeader";
			this.panelUsersHeader.Size = new System.Drawing.Size(950, 50);
			this.panelUsersHeader.TabIndex = 0;
			//
			// buttonInvite
			//
			this.buttonInvite.CssClass = "relay-primary";
			this.buttonInvite.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/person-plus.svg";
			this.buttonInvite.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonInvite.Location = new System.Drawing.Point(820, 0);
			this.buttonInvite.Name = "buttonInvite";
			this.buttonInvite.Size = new System.Drawing.Size(130, 32);
			this.buttonInvite.TabIndex = 2;
			this.buttonInvite.Text = "Invite user...";
			this.buttonInvite.Click += new System.EventHandler(this.buttonInvite_Click);
			//
			// labelUsersHint
			//
			this.labelUsersHint.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right)));
			this.labelUsersHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelUsersHint.Location = new System.Drawing.Point(0, 22);
			this.labelUsersHint.Name = "labelUsersHint";
			this.labelUsersHint.Size = new System.Drawing.Size(830, 20);
			this.labelUsersHint.TabIndex = 1;
			//
			// labelUsersTitle
			//
			this.labelUsersTitle.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) | Wisej.Web.AnchorStyles.Right)));
			this.labelUsersTitle.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelUsersTitle.Location = new System.Drawing.Point(0, 0);
			this.labelUsersTitle.Name = "labelUsersTitle";
			this.labelUsersTitle.Size = new System.Drawing.Size(830, 22);
			this.labelUsersTitle.TabIndex = 0;
			//
			// tabStages
			//
			this.tabStages.Controls.Add(this.gridStages);
			this.tabStages.Controls.Add(this.panelStageButtons);
			this.tabStages.Controls.Add(this.labelStagesHint);
			this.tabStages.Location = new System.Drawing.Point(1, 41);
			this.tabStages.Name = "tabStages";
			this.tabStages.Padding = new Wisej.Web.Padding(8);
			this.tabStages.Size = new System.Drawing.Size(966, 534);
			this.tabStages.Text = "Pipeline stages";
			//
			// gridStages
			//
			this.gridStages.AllowUserToResizeRows = false;
			this.gridStages.AutoGenerateColumns = false;
			this.gridStages.BorderStyle = Wisej.Web.BorderStyle.None;
			this.gridStages.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colStageOrder,
            this.colStageName,
            this.colStageProbability,
            this.colStageKind,
            this.colStageDeals});
			this.gridStages.CssClass = "relay-grid";
			this.gridStages.Dock = Wisej.Web.DockStyle.Fill;
			this.gridStages.Location = new System.Drawing.Point(8, 52);
			this.gridStages.MultiSelect = false;
			this.gridStages.Name = "gridStages";
			this.gridStages.RowHeadersVisible = false;
			this.gridStages.RowTemplate.Height = 36;
			this.gridStages.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.gridStages.ShowColumnVisibilityMenu = false;
			this.gridStages.Size = new System.Drawing.Size(842, 474);
			this.gridStages.TabIndex = 2;
			this.gridStages.CellValidating += new Wisej.Web.DataGridViewCellValidatingEventHandler(this.gridStages_CellValidating);
			this.gridStages.SelectionChanged += new System.EventHandler(this.gridStages_SelectionChanged);
			//
			// colStageOrder
			//
			this.colStageOrder.DataPropertyName = "Order";
			this.colStageOrder.HeaderText = "#";
			this.colStageOrder.Name = "colStageOrder";
			this.colStageOrder.ReadOnly = true;
			this.colStageOrder.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable;
			this.colStageOrder.Width = 40;
			//
			// colStageName
			//
			this.colStageName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colStageName.DataPropertyName = "Name";
			this.colStageName.FillWeight = 200F;
			this.colStageName.HeaderText = "Name";
			this.colStageName.Name = "colStageName";
			this.colStageName.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable;
			//
			// colStageProbability
			//
			this.colStageProbability.DataPropertyName = "Probability";
			this.colStageProbability.HeaderText = "Probability %";
			this.colStageProbability.Name = "colStageProbability";
			this.colStageProbability.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable;
			this.colStageProbability.Width = 100;
			//
			// colStageKind
			//
			this.colStageKind.DataPropertyName = "Kind";
			this.colStageKind.HeaderText = "Kind";
			this.colStageKind.Name = "colStageKind";
			this.colStageKind.ReadOnly = true;
			this.colStageKind.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable;
			this.colStageKind.Width = 70;
			//
			// colStageDeals
			//
			this.colStageDeals.DataPropertyName = "Deals";
			dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colStageDeals.DefaultCellStyle = dataGridViewCellStyle1;
			this.colStageDeals.HeaderText = "Deals";
			this.colStageDeals.Name = "colStageDeals";
			this.colStageDeals.ReadOnly = true;
			this.colStageDeals.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable;
			this.colStageDeals.Width = 70;
			//
			// panelStageButtons
			//
			this.panelStageButtons.Controls.Add(this.buttonMoveUp);
			this.panelStageButtons.Controls.Add(this.buttonMoveDown);
			this.panelStageButtons.Controls.Add(this.buttonSaveStages);
			this.panelStageButtons.Dock = Wisej.Web.DockStyle.Right;
			this.panelStageButtons.Location = new System.Drawing.Point(850, 52);
			this.panelStageButtons.Name = "panelStageButtons";
			this.panelStageButtons.Padding = new Wisej.Web.Padding(8, 0, 0, 0);
			this.panelStageButtons.Size = new System.Drawing.Size(108, 474);
			this.panelStageButtons.TabIndex = 1;
			//
			// buttonMoveUp
			//
			this.buttonMoveUp.CssClass = "relay-secondary";
			this.buttonMoveUp.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/arrow-up.svg";
			this.buttonMoveUp.Location = new System.Drawing.Point(8, 0);
			this.buttonMoveUp.Name = "buttonMoveUp";
			this.buttonMoveUp.Size = new System.Drawing.Size(120, 32);
			this.buttonMoveUp.TabIndex = 0;
			this.buttonMoveUp.Text = "Move up";
			this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
			//
			// buttonMoveDown
			//
			this.buttonMoveDown.CssClass = "relay-secondary";
			this.buttonMoveDown.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/arrow-down.svg";
			this.buttonMoveDown.Location = new System.Drawing.Point(8, 36);
			this.buttonMoveDown.Name = "buttonMoveDown";
			this.buttonMoveDown.Size = new System.Drawing.Size(120, 32);
			this.buttonMoveDown.TabIndex = 1;
			this.buttonMoveDown.Text = "Move down";
			this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
			//
			// buttonSaveStages
			//
			this.buttonSaveStages.CssClass = "relay-primary";
			this.buttonSaveStages.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/check-lg.svg";
			this.buttonSaveStages.Enabled = false;
			this.buttonSaveStages.Location = new System.Drawing.Point(8, 84);
			this.buttonSaveStages.Name = "buttonSaveStages";
			this.buttonSaveStages.Size = new System.Drawing.Size(120, 32);
			this.buttonSaveStages.TabIndex = 2;
			this.buttonSaveStages.Text = "Save stages";
			this.buttonSaveStages.Click += new System.EventHandler(this.buttonSaveStages_Click);
			//
			// labelStagesHint
			//
			this.labelStagesHint.Dock = Wisej.Web.DockStyle.Top;
			this.labelStagesHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelStagesHint.Location = new System.Drawing.Point(8, 8);
			this.labelStagesHint.Name = "labelStagesHint";
			this.labelStagesHint.Padding = new Wisej.Web.Padding(0, 0, 0, 8);
			this.labelStagesHint.Size = new System.Drawing.Size(950, 44);
			this.labelStagesHint.TabIndex = 0;
			this.labelStagesHint.Text = "Rename the stages, change their win probability and order. Won and Lost always stay last. Open deals get the new probability of their stage.";
			//
			// tabTags
			//
			this.tabTags.Controls.Add(this.gridTags);
			this.tabTags.Controls.Add(this.panelAddTag);
			this.tabTags.Controls.Add(this.labelTagsHint);
			this.tabTags.Controls.Add(this.labelTagsTitle);
			this.tabTags.Location = new System.Drawing.Point(1, 41);
			this.tabTags.Name = "tabTags";
			this.tabTags.Padding = new Wisej.Web.Padding(8);
			this.tabTags.Size = new System.Drawing.Size(966, 534);
			this.tabTags.Text = "Tags";
			//
			// gridTags
			//
			this.gridTags.AllowUserToResizeRows = false;
			this.gridTags.AutoGenerateColumns = false;
			this.gridTags.BorderStyle = Wisej.Web.BorderStyle.None;
			this.gridTags.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colTagName,
            this.colTagUsage});
			this.gridTags.CssClass = "relay-grid";
			this.gridTags.Dock = Wisej.Web.DockStyle.Left;
			this.gridTags.Location = new System.Drawing.Point(8, 96);
			this.gridTags.MultiSelect = false;
			this.gridTags.Name = "gridTags";
			this.gridTags.ReadOnly = true;
			this.gridTags.RowHeadersVisible = false;
			this.gridTags.RowTemplate.Height = 40;
			this.gridTags.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.gridTags.ShowColumnVisibilityMenu = false;
			this.gridTags.Size = new System.Drawing.Size(560, 430);
			this.gridTags.TabIndex = 3;
			//
			// colTagName
			//
			this.colTagName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTagName.DataPropertyName = "Name";
			this.colTagName.HeaderText = "Tag";
			this.colTagName.Name = "colTagName";
			this.colTagName.Variant = Wisej.Web.ChipVariant.Soft;
			//
			// colTagUsage
			//
			this.colTagUsage.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colTagUsage.DataPropertyName = "UsageText";
			this.colTagUsage.FillWeight = 200F;
			this.colTagUsage.HeaderText = "Used by";
			this.colTagUsage.Name = "colTagUsage";
			//
			// panelAddTag
			//
			this.panelAddTag.Controls.Add(this.textBoxNewTag);
			this.panelAddTag.Controls.Add(this.buttonAddTag);
			this.panelAddTag.Controls.Add(this.buttonRemoveTag);
			this.panelAddTag.Dock = Wisej.Web.DockStyle.Top;
			this.panelAddTag.Location = new System.Drawing.Point(8, 58);
			this.panelAddTag.Name = "panelAddTag";
			this.panelAddTag.Padding = new Wisej.Web.Padding(0, 0, 0, 8);
			this.panelAddTag.Size = new System.Drawing.Size(950, 38);
			this.panelAddTag.TabIndex = 2;
			this.panelAddTag.TabStop = true;
			//
			// textBoxNewTag
			//
			this.textBoxNewTag.Location = new System.Drawing.Point(0, 0);
			this.textBoxNewTag.Margin = new Wisej.Web.Padding(0);
			this.textBoxNewTag.Name = "textBoxNewTag";
			this.textBoxNewTag.Size = new System.Drawing.Size(200, 30);
			this.textBoxNewTag.TabIndex = 0;
			this.textBoxNewTag.KeyDown += new Wisej.Web.KeyEventHandler(this.textBoxNewTag_KeyDown);
			//
			// buttonAddTag
			//
			this.buttonAddTag.CssClass = "relay-primary";
			this.buttonAddTag.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus.svg";
			this.buttonAddTag.Location = new System.Drawing.Point(206, 0);
			this.buttonAddTag.Margin = new Wisej.Web.Padding(6, 0, 0, 0);
			this.buttonAddTag.Name = "buttonAddTag";
			this.buttonAddTag.Size = new System.Drawing.Size(100, 32);
			this.buttonAddTag.TabIndex = 1;
			this.buttonAddTag.Text = "Add tag";
			this.buttonAddTag.Click += new System.EventHandler(this.buttonAddTag_Click);
			//
			// buttonRemoveTag
			//
			this.buttonRemoveTag.CssClass = "relay-secondary";
			this.buttonRemoveTag.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/trash.svg";
			this.buttonRemoveTag.Location = new System.Drawing.Point(292, 0);
			this.buttonRemoveTag.Margin = new Wisej.Web.Padding(6, 0, 0, 0);
			this.buttonRemoveTag.Name = "buttonRemoveTag";
			this.buttonRemoveTag.Size = new System.Drawing.Size(150, 32);
			this.buttonRemoveTag.TabIndex = 2;
			this.buttonRemoveTag.Text = "Remove selected";
			this.buttonRemoveTag.Click += new System.EventHandler(this.buttonRemoveTag_Click);
			//
			// labelTagsHint
			//
			this.labelTagsHint.Dock = Wisej.Web.DockStyle.Top;
			this.labelTagsHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelTagsHint.Location = new System.Drawing.Point(8, 30);
			this.labelTagsHint.Name = "labelTagsHint";
			this.labelTagsHint.Padding = new Wisej.Web.Padding(0, 0, 0, 8);
			this.labelTagsHint.Size = new System.Drawing.Size(950, 28);
			this.labelTagsHint.TabIndex = 1;
			this.labelTagsHint.Text = "Tags label companies and contacts. Removing a tag takes it off every record.";
			//
			// labelTagsTitle
			//
			this.labelTagsTitle.Dock = Wisej.Web.DockStyle.Top;
			this.labelTagsTitle.Font = new System.Drawing.Font("default", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelTagsTitle.Location = new System.Drawing.Point(8, 8);
			this.labelTagsTitle.Name = "labelTagsTitle";
			this.labelTagsTitle.Size = new System.Drawing.Size(950, 22);
			this.labelTagsTitle.TabIndex = 0;
			//
			// tabDemo
			//
			this.tabDemo.Controls.Add(this.panelDemo);
			this.tabDemo.Location = new System.Drawing.Point(1, 41);
			this.tabDemo.Name = "tabDemo";
			this.tabDemo.Size = new System.Drawing.Size(966, 534);
			this.tabDemo.Text = "Demo data";
			//
			// panelDemo
			//
			this.panelDemo.Controls.Add(this.buttonResetDemo);
			this.panelDemo.Controls.Add(this.labelDemoNote);
			this.panelDemo.Controls.Add(this.labelDemoText);
			this.panelDemo.Location = new System.Drawing.Point(12, 12);
			this.panelDemo.Name = "panelDemo";
			this.panelDemo.Size = new System.Drawing.Size(520, 116);
			this.panelDemo.TabIndex = 0;
			//
			// buttonResetDemo
			//
			this.buttonResetDemo.CssClass = "relay-secondary";
			this.buttonResetDemo.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/arrow-counterclockwise.svg";
			this.buttonResetDemo.Location = new System.Drawing.Point(0, 86);
			this.buttonResetDemo.Name = "buttonResetDemo";
			this.buttonResetDemo.Size = new System.Drawing.Size(160, 32);
			this.buttonResetDemo.TabIndex = 2;
			this.buttonResetDemo.Text = "Reset demo data...";
			this.buttonResetDemo.Click += new System.EventHandler(this.buttonResetDemo_Click);
			//
			// labelDemoNote
			//
			this.labelDemoNote.Dock = Wisej.Web.DockStyle.Top;
			this.labelDemoNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
			this.labelDemoNote.Location = new System.Drawing.Point(0, 50);
			this.labelDemoNote.Name = "labelDemoNote";
			this.labelDemoNote.Padding = new Wisej.Web.Padding(0, 0, 0, 10);
			this.labelDemoNote.Size = new System.Drawing.Size(520, 30);
			this.labelDemoNote.TabIndex = 1;
			//
			// labelDemoText
			//
			this.labelDemoText.Dock = Wisej.Web.DockStyle.Top;
			this.labelDemoText.Location = new System.Drawing.Point(0, 0);
			this.labelDemoText.Name = "labelDemoText";
			this.labelDemoText.Padding = new Wisej.Web.Padding(0, 0, 0, 10);
			this.labelDemoText.Size = new System.Drawing.Size(520, 50);
			this.labelDemoText.TabIndex = 0;
			this.labelDemoText.Text = "Relay ships with fictional sample data. Resetting it deletes every change and seeds the companies, contacts, deals, activities, tasks and users again.";
			//
			// SettingsView
			//
			this.Controls.Add(this.tabControl);
			this.BackColor = System.Drawing.Color.White;
			this.CssClass = "relay-card";
			this.Name = "SettingsView";
			this.Size = new System.Drawing.Size(1000, 640);
			this.tabControl.ResumeLayout(false);
			this.tabProfile.ResumeLayout(false);
			this.panelProfile.ResumeLayout(false);
			this.panelSaveProfile.ResumeLayout(false);
			this.tableProfile.ResumeLayout(false);
			this.tableProfile.PerformLayout();
			this.panelProfileHeader.ResumeLayout(false);
			this.panelProfileNames.ResumeLayout(false);
			this.tabUsers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
			this.panelUsersHeader.ResumeLayout(false);
			this.tabStages.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridStages)).EndInit();
			this.panelStageButtons.ResumeLayout(false);
			this.tabTags.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridTags)).EndInit();
			this.panelAddTag.ResumeLayout(false);
			this.tabDemo.ResumeLayout(false);
			this.panelDemo.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.TabControl tabControl;
		private Wisej.Web.TabPage tabProfile;
		private Wisej.Web.Panel panelProfile;
		private Wisej.Web.Panel panelProfileHeader;
		private Wisej.Web.Avatar avatarProfile;
		private Wisej.Web.Panel panelProfileNames;
		private Wisej.Web.Label labelProfileName;
		private Wisej.Web.Label labelProfileRole;
		private Wisej.Web.TableLayoutPanel tableProfile;
		private Wisej.Web.Label labelName;
		private Wisej.Web.TextBox textBoxProfileName;
		private Wisej.Web.Label labelEmail;
		private Wisej.Web.TextBox textBoxProfileEmail;
		private Wisej.Web.Label labelColor;
		private Wisej.Web.FlowLayoutPanel listColors;
		private Wisej.Web.Label labelProfileError;
		private Wisej.Web.Panel panelSaveProfile;
		private Wisej.Web.Button buttonSaveProfile;
		private Wisej.Web.TabPage tabUsers;
		private Wisej.Web.Panel panelUsersHeader;
		private Wisej.Web.Button buttonInvite;
		private Wisej.Web.Label labelUsersTitle;
		private Wisej.Web.Label labelUsersHint;
		private Wisej.Web.DataGridView gridUsers;
		private Wisej.Web.DataGridViewAvatarColumn colUserName;
		private Wisej.Web.DataGridViewTextBoxColumn colEmail;
		private Wisej.Web.DataGridViewComboBoxColumn colRole;
		private Wisej.Web.DataGridViewCheckBoxColumn colActive;
		private Wisej.Web.DataGridViewTextBoxColumn colOwns;
		private Wisej.Web.TabPage tabStages;
		private Wisej.Web.Label labelStagesHint;
		private Wisej.Web.Panel panelStageButtons;
		private Wisej.Web.Button buttonMoveUp;
		private Wisej.Web.Button buttonMoveDown;
		private Wisej.Web.Button buttonSaveStages;
		private Wisej.Web.DataGridView gridStages;
		private Wisej.Web.DataGridViewTextBoxColumn colStageOrder;
		private Wisej.Web.DataGridViewTextBoxColumn colStageName;
		private Wisej.Web.DataGridViewTextBoxColumn colStageProbability;
		private Wisej.Web.DataGridViewTextBoxColumn colStageKind;
		private Wisej.Web.DataGridViewTextBoxColumn colStageDeals;
		private Wisej.Web.TabPage tabTags;
		private Wisej.Web.Label labelTagsTitle;
		private Wisej.Web.Label labelTagsHint;
		private Wisej.Web.FlowLayoutPanel panelAddTag;
		private Wisej.Web.TextBox textBoxNewTag;
		private Wisej.Web.Button buttonAddTag;
		private Wisej.Web.Button buttonRemoveTag;
		private Wisej.Web.DataGridView gridTags;
		private Wisej.Web.DataGridViewChipColumn colTagName;
		private Wisej.Web.DataGridViewTextBoxColumn colTagUsage;
		private Wisej.Web.TabPage tabDemo;
		private Wisej.Web.Panel panelDemo;
		private Wisej.Web.Label labelDemoText;
		private Wisej.Web.Label labelDemoNote;
		private Wisej.Web.Button buttonResetDemo;
	}
}
