namespace RelayCrm.Views
{
	partial class CompaniesView
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
			this.components = new System.ComponentModel.Container();
			Wisej.Web.Segment segment1 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment2 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment3 = new Wisej.Web.Segment();
			Wisej.Web.Segment segment4 = new Wisej.Web.Segment();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle6 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle7 = new Wisej.Web.DataGridViewCellStyle();
			Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle8 = new Wisej.Web.DataGridViewCellStyle();
			this.panelHeader = new Wisej.Web.Panel();
			this.labelCount = new Wisej.Web.Label();
			this.buttonNew = new Wisej.Web.Button();
			this.panelToolbar = new Wisej.Web.Panel();
			this.textBoxSearch = new Wisej.Web.TextBox();
			this.chipGroupQuick = new Wisej.Web.ChipGroup();
			this.buttonAdvanced = new Wisej.Web.Button();
			this.buttonColumns = new Wisej.Web.Button();
			this.buttonExport = new Wisej.Web.Button();
			this.panelCard = new Wisej.Web.Panel();
			this.queryBuilder = new Wisej.Web.QueryBuilder();
			this.grid = new Wisej.Web.DataGridView();
			this.colName = new Wisej.Web.DataGridViewAvatarColumn();
			this.colCountry = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colCity = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOwner = new Wisej.Web.DataGridViewAvatarColumn();
			this.colContacts = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colOpenValue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colWonRevenue = new Wisej.Web.DataGridViewTextBoxColumn();
			this.colWonTrend = new Wisej.Web.DataGridViewSparklineColumn();
			this.colTag = new Wisej.Web.DataGridViewChipColumn();
			this.colTags = new Wisej.Web.DataGridViewTextBoxColumn();
			this.emptyState = new Wisej.Web.EmptyState();
			this.panelPager = new Wisej.Web.Panel();
			this.labelPage = new Wisej.Web.Label();
			this.buttonPrevious = new Wisej.Web.Button();
			this.buttonNext = new Wisej.Web.Button();
			this.contextMenuColumns = new Wisej.Web.ContextMenu(this.components);
			this.panelHeader.SuspendLayout();
			this.panelToolbar.SuspendLayout();
			this.panelCard.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
			this.panelPager.SuspendLayout();
			this.SuspendLayout();
			//
			// panelHeader
			//
			this.panelHeader.Controls.Add(this.buttonNew);
			this.panelHeader.Controls.Add(this.labelCount);
			this.panelHeader.Dock = Wisej.Web.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(1100, 48);
			this.panelHeader.TabIndex = 0;
			//
			// labelCount
			//
			this.labelCount.CssClass = "relay-muted";
			this.labelCount.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelCount.Location = new System.Drawing.Point(0, 0);
			this.labelCount.Name = "labelCount";
			this.labelCount.Size = new System.Drawing.Size(500, 48);
			this.labelCount.TabIndex = 0;
			this.labelCount.Text = "0 companies";
			this.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonNew
			//
			this.buttonNew.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonNew.CssClass = "relay-primary";
			this.buttonNew.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/plus-lg.svg";
			this.buttonNew.Location = new System.Drawing.Point(956, 6);
			this.buttonNew.Name = "buttonNew";
			this.buttonNew.Size = new System.Drawing.Size(144, 36);
			this.buttonNew.TabIndex = 1;
			this.buttonNew.Text = "New company";
			this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
			//
			// panelToolbar
			//
			this.panelToolbar.Controls.Add(this.buttonExport);
			this.panelToolbar.Controls.Add(this.buttonColumns);
			this.panelToolbar.Controls.Add(this.buttonAdvanced);
			this.panelToolbar.Controls.Add(this.chipGroupQuick);
			this.panelToolbar.Controls.Add(this.textBoxSearch);
			this.panelToolbar.Dock = Wisej.Web.DockStyle.Top;
			this.panelToolbar.Location = new System.Drawing.Point(0, 48);
			this.panelToolbar.Name = "panelToolbar";
			this.panelToolbar.Size = new System.Drawing.Size(1100, 52);
			this.panelToolbar.TabIndex = 1;
			//
			// textBoxSearch
			//
			this.textBoxSearch.AutoSize = false;
			this.textBoxSearch.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.textBoxSearch.Location = new System.Drawing.Point(0, 0);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(280, 36);
			this.textBoxSearch.TabIndex = 0;
			this.textBoxSearch.Watermark = "Search companies";
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			//
			// chipGroupQuick
			//
			this.chipGroupQuick.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left)
            | Wisej.Web.AnchorStyles.Right)));
			segment1.Text = "All";
			segment2.Text = "My companies";
			segment3.Text = "With open deals";
			segment4.Text = "Customers";
			this.chipGroupQuick.Items.Add(segment1);
			this.chipGroupQuick.Items.Add(segment2);
			this.chipGroupQuick.Items.Add(segment3);
			this.chipGroupQuick.Items.Add(segment4);
			this.chipGroupQuick.Location = new System.Drawing.Point(296, 0);
			this.chipGroupQuick.Name = "chipGroupQuick";
			this.chipGroupQuick.SelectedIndex = 0;
			this.chipGroupQuick.ShowCounts = true;
			this.chipGroupQuick.Size = new System.Drawing.Size(664, 36);
			this.chipGroupQuick.TabIndex = 1;
			this.chipGroupQuick.SelectedIndexChanged += new System.EventHandler(this.chipGroupQuick_SelectedIndexChanged);
			//
			// buttonAdvanced
			//
			this.buttonAdvanced.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonAdvanced.CssClass = "relay-secondary";
			this.buttonAdvanced.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/funnel.svg";
			this.buttonAdvanced.Location = new System.Drawing.Point(976, 0);
			this.buttonAdvanced.Name = "buttonAdvanced";
			this.buttonAdvanced.Size = new System.Drawing.Size(36, 36);
			this.buttonAdvanced.TabIndex = 2;
			this.buttonAdvanced.ToolTipText = "Advanced filter";
			this.buttonAdvanced.Click += new System.EventHandler(this.buttonAdvanced_Click);
			//
			// buttonColumns
			//
			this.buttonColumns.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonColumns.CssClass = "relay-secondary";
			this.buttonColumns.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/columns-gap.svg";
			this.buttonColumns.Location = new System.Drawing.Point(1020, 0);
			this.buttonColumns.Name = "buttonColumns";
			this.buttonColumns.Size = new System.Drawing.Size(36, 36);
			this.buttonColumns.TabIndex = 3;
			this.buttonColumns.ToolTipText = "Choose columns";
			this.buttonColumns.Click += new System.EventHandler(this.buttonColumns_Click);
			//
			// buttonExport
			//
			this.buttonExport.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonExport.CssClass = "relay-secondary";
			this.buttonExport.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/download.svg";
			this.buttonExport.Location = new System.Drawing.Point(1064, 0);
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new System.Drawing.Size(36, 36);
			this.buttonExport.TabIndex = 4;
			this.buttonExport.ToolTipText = "Export to CSV";
			this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
			//
			// panelCard
			//
			this.panelCard.Controls.Add(this.emptyState);
			this.panelCard.Controls.Add(this.grid);
			this.panelCard.Controls.Add(this.panelPager);
			this.panelCard.Controls.Add(this.queryBuilder);
			this.panelCard.CssClass = "relay-card";
			this.panelCard.Dock = Wisej.Web.DockStyle.Fill;
			this.panelCard.Location = new System.Drawing.Point(0, 100);
			this.panelCard.Name = "panelCard";
			this.panelCard.Padding = new Wisej.Web.Padding(20);
			this.panelCard.Size = new System.Drawing.Size(1100, 660);
			this.panelCard.TabIndex = 2;
			//
			// queryBuilder
			//
			this.queryBuilder.Dock = Wisej.Web.DockStyle.Top;
			this.queryBuilder.Location = new System.Drawing.Point(20, 20);
			this.queryBuilder.Name = "queryBuilder";
			this.queryBuilder.ShowPreview = true;
			this.queryBuilder.Size = new System.Drawing.Size(1060, 180);
			this.queryBuilder.TabIndex = 0;
			this.queryBuilder.Visible = false;
			this.queryBuilder.QueryChanged += new System.EventHandler(this.queryBuilder_QueryChanged);
			//
			// grid
			//
			this.grid.AllowUserToAddRows = false;
			this.grid.AllowUserToDeleteRows = false;
			this.grid.AllowUserToResizeRows = false;
			this.grid.AutoGenerateColumns = false;
			this.grid.BorderStyle = Wisej.Web.BorderStyle.None;
			this.grid.CellBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.Horizontal;
			dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.grid.ColumnHeadersHeight = 40;
			this.grid.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.colName,
            this.colCountry,
            this.colCity,
            this.colOwner,
            this.colContacts,
            this.colOpenValue,
            this.colWonRevenue,
            this.colWonTrend,
            this.colTag,
            this.colTags});
			this.grid.CssClass = "relay-grid";
			dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.Padding = new Wisej.Web.Padding(8, 0, 8, 0);
			this.grid.DefaultCellStyle = dataGridViewCellStyle2;
			this.grid.Dock = Wisej.Web.DockStyle.Fill;
			this.grid.Location = new System.Drawing.Point(20, 20);
			this.grid.Name = "grid";
			this.grid.ReadOnly = true;
			this.grid.RowHeadersVisible = false;
			this.grid.RowTemplate.Height = 52;
			this.grid.SelectionMode = Wisej.Web.DataGridViewSelectionMode.FullRowSelect;
			this.grid.Size = new System.Drawing.Size(1060, 568);
			this.grid.TabIndex = 1;
			this.grid.CellDoubleClick += new Wisej.Web.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
			this.grid.DataBindingComplete += new Wisej.Web.DataGridViewBindingCompleteEventHandler(this.grid_DataBindingComplete);
			this.grid.Resize += new System.EventHandler(this.grid_Resize);
			//
			// colName
			//
			this.colName.AutoColor = true;
			this.colName.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill;
			this.colName.DataPropertyName = "Name";
			this.colName.HeaderText = "Company";
			this.colName.MinimumWidth = 200;
			this.colName.Name = "colName";
			this.colName.Shape = Wisej.Web.AvatarShape.Rounded;
			this.colName.SubTextMember = "Industry";
			//
			// colCountry
			//
			this.colCountry.DataPropertyName = "Country";
			this.colCountry.HeaderText = "Country";
			this.colCountry.Name = "colCountry";
			this.colCountry.Width = 120;
			//
			// colCity
			//
			this.colCity.DataPropertyName = "City";
			this.colCity.HeaderText = "City";
			this.colCity.Name = "colCity";
			this.colCity.Visible = false;
			this.colCity.Width = 120;
			//
			// colOwner
			//
			this.colOwner.AutoColor = true;
			this.colOwner.DataPropertyName = "OwnerName";
			this.colOwner.HeaderText = "Owner";
			this.colOwner.Name = "colOwner";
			this.colOwner.Size = 24;
			this.colOwner.Width = 144;
			//
			// colContacts
			//
			dataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colContacts.DataPropertyName = "Contacts";
			this.colContacts.DefaultCellStyle = dataGridViewCellStyle3;
			dataGridViewCellStyle4.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colContacts.HeaderStyle = dataGridViewCellStyle4;
			this.colContacts.HeaderText = "Contacts";
			this.colContacts.Name = "colContacts";
			this.colContacts.Width = 92;
			//
			// colOpenValue
			//
			dataGridViewCellStyle5.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle5.Format = "$#,##0";
			this.colOpenValue.DataPropertyName = "OpenValue";
			this.colOpenValue.DefaultCellStyle = dataGridViewCellStyle5;
			dataGridViewCellStyle6.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colOpenValue.HeaderStyle = dataGridViewCellStyle6;
			this.colOpenValue.HeaderText = "Open deals";
			this.colOpenValue.Name = "colOpenValue";
			this.colOpenValue.Width = 116;
			//
			// colWonRevenue
			//
			dataGridViewCellStyle7.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			dataGridViewCellStyle7.Format = "$#,##0";
			this.colWonRevenue.DataPropertyName = "WonRevenue";
			this.colWonRevenue.DefaultCellStyle = dataGridViewCellStyle7;
			dataGridViewCellStyle8.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleRight;
			this.colWonRevenue.HeaderStyle = dataGridViewCellStyle8;
			this.colWonRevenue.HeaderText = "Won revenue";
			this.colWonRevenue.Name = "colWonRevenue";
			this.colWonRevenue.Width = 120;
			//
			// colWonTrend
			//
			this.colWonTrend.ChartType = Wisej.Web.SparklineChartType.Bar;
			this.colWonTrend.DataPropertyName = "WonTrend";
			this.colWonTrend.HeaderText = "Won, 12 months";
			this.colWonTrend.Name = "colWonTrend";
			this.colWonTrend.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable;
			this.colWonTrend.Tone = Wisej.Web.SparklineTone.Success;
			this.colWonTrend.Width = 136;
			//
			// colTag
			//
			this.colTag.DataPropertyName = "FirstTag";
			this.colTag.HeaderText = "Tag";
			this.colTag.Name = "colTag";
			this.colTag.Width = 104;
			//
			// colTags
			//
			this.colTags.DataPropertyName = "Tags";
			this.colTags.HeaderText = "All tags";
			this.colTags.Name = "colTags";
			this.colTags.Visible = false;
			this.colTags.Width = 180;
			//
			// emptyState
			//
			this.emptyState.ActionText = "Clear filters";
			this.emptyState.Description = "Try another search or clear the filters.";
			this.emptyState.Icon = "resource.wx/Wisej.Ext.BootstrapIcons/building.svg";
			this.emptyState.Kind = Wisej.Web.EmptyStateKind.NoResults;
			this.emptyState.Location = new System.Drawing.Point(400, 200);
			this.emptyState.Name = "emptyState";
			this.emptyState.Size = new System.Drawing.Size(300, 200);
			this.emptyState.TabIndex = 3;
			this.emptyState.TargetControl = this.grid;
			this.emptyState.Title = "No companies match";
			this.emptyState.ActionClick += new System.EventHandler(this.emptyState_ActionClick);
			//
			// panelPager
			//
			this.panelPager.BackColor = System.Drawing.Color.Transparent;
			this.panelPager.Controls.Add(this.buttonNext);
			this.panelPager.Controls.Add(this.buttonPrevious);
			this.panelPager.Controls.Add(this.labelPage);
			this.panelPager.Dock = Wisej.Web.DockStyle.Bottom;
			this.panelPager.Location = new System.Drawing.Point(20, 588);
			this.panelPager.Name = "panelPager";
			this.panelPager.Size = new System.Drawing.Size(1060, 52);
			this.panelPager.TabIndex = 2;
			//
			// labelPage
			//
			this.labelPage.CssClass = "relay-muted";
			this.labelPage.Font = new System.Drawing.Font("default", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.labelPage.Location = new System.Drawing.Point(0, 16);
			this.labelPage.Name = "labelPage";
			this.labelPage.Size = new System.Drawing.Size(500, 36);
			this.labelPage.TabIndex = 0;
			this.labelPage.Text = "0 of 0";
			this.labelPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// buttonPrevious
			//
			this.buttonPrevious.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonPrevious.CssClass = "relay-secondary";
			this.buttonPrevious.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/chevron-left.svg";
			this.buttonPrevious.Location = new System.Drawing.Point(852, 16);
			this.buttonPrevious.Name = "buttonPrevious";
			this.buttonPrevious.Size = new System.Drawing.Size(100, 36);
			this.buttonPrevious.TabIndex = 1;
			this.buttonPrevious.Text = "Previous";
			this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
			//
			// buttonNext
			//
			this.buttonNext.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Right)));
			this.buttonNext.CssClass = "relay-secondary";
			this.buttonNext.ImageSource = "resource.wx/Wisej.Ext.BootstrapIcons/chevron-right.svg";
			this.buttonNext.Location = new System.Drawing.Point(960, 16);
			this.buttonNext.Name = "buttonNext";
			this.buttonNext.Size = new System.Drawing.Size(100, 36);
			this.buttonNext.TabIndex = 2;
			this.buttonNext.Text = "Next";
			this.buttonNext.TextImageRelation = Wisej.Web.TextImageRelation.TextBeforeImage;
			this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
			//
			// contextMenuColumns
			//
			this.contextMenuColumns.Name = "contextMenuColumns";
			//
			// CompaniesView
			//
			this.Controls.Add(this.panelCard);
			this.Controls.Add(this.panelToolbar);
			this.Controls.Add(this.panelHeader);
			this.Name = "CompaniesView";
			this.Size = new System.Drawing.Size(1100, 760);
			this.Load += new System.EventHandler(this.CompaniesView_Load);
			this.panelHeader.ResumeLayout(false);
			this.panelToolbar.ResumeLayout(false);
			this.panelCard.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
			this.panelPager.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Panel panelHeader;
		private Wisej.Web.Label labelCount;
		private Wisej.Web.Button buttonNew;
		private Wisej.Web.Panel panelToolbar;
		private Wisej.Web.TextBox textBoxSearch;
		private Wisej.Web.ChipGroup chipGroupQuick;
		private Wisej.Web.Button buttonAdvanced;
		private Wisej.Web.Button buttonColumns;
		private Wisej.Web.Button buttonExport;
		private Wisej.Web.Panel panelCard;
		private Wisej.Web.QueryBuilder queryBuilder;
		private Wisej.Web.DataGridView grid;
		private Wisej.Web.DataGridViewAvatarColumn colName;
		private Wisej.Web.DataGridViewTextBoxColumn colCountry;
		private Wisej.Web.DataGridViewTextBoxColumn colCity;
		private Wisej.Web.DataGridViewAvatarColumn colOwner;
		private Wisej.Web.DataGridViewTextBoxColumn colContacts;
		private Wisej.Web.DataGridViewTextBoxColumn colOpenValue;
		private Wisej.Web.DataGridViewTextBoxColumn colWonRevenue;
		private Wisej.Web.DataGridViewSparklineColumn colWonTrend;
		private Wisej.Web.DataGridViewChipColumn colTag;
		private Wisej.Web.DataGridViewTextBoxColumn colTags;
		private Wisej.Web.EmptyState emptyState;
		private Wisej.Web.Panel panelPager;
		private Wisej.Web.Label labelPage;
		private Wisej.Web.Button buttonPrevious;
		private Wisej.Web.Button buttonNext;
		private Wisej.Web.ContextMenu contextMenuColumns;
	}
}
