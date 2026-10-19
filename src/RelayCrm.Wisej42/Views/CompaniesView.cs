using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// The companies list: search, quick filters, advanced filter, column chooser, CSV export and paging.
	/// </summary>
	public partial class CompaniesView : UserControl, IRefreshable
	{
		private const int PageSize = 20;

		// all the companies, and the ones matching the filters.
		private List<CompanyRow> rows = new List<CompanyRow>();
		private List<CompanyRow> filtered = new List<CompanyRow>();
		private int pageIndex;
		// true once the user picked the columns: the grid stops hiding columns that do not fit.
		private bool userChoseColumns;

		public CompaniesView()
		{
			InitializeComponent();

			this.colTag.ToneMap["VIP"] = ChipTone.Primary;
			this.colTag.ToneMap["Enterprise"] = ChipTone.Primary;
			this.colTag.ToneMap["Partner"] = ChipTone.Success;
			this.colTag.ToneMap["Renewal"] = ChipTone.Warning;
			this.colTag.ToneMap["Trial"] = ChipTone.Warning;
			this.colTag.ToneMap["SMB"] = ChipTone.Neutral;
			this.colTag.ToneMap["Newsletter"] = ChipTone.Neutral;
		}

		/// <summary>
		/// Reloads the companies, keeping the filters (called when coming back from a company).
		/// </summary>
		public void RefreshData()
		{
			Notify.Try(() => this.rows = CompanyService.List(), "Loading the companies");
			ApplyFilters(keepPage: true);
		}

		private void CompaniesView_Load(object sender, EventArgs e)
		{
			this.queryBuilder.Fields.Add(new FilterField("Name", "Name", FilterFieldType.Text, null));
			this.queryBuilder.Fields.Add(new FilterField("Industry", "Industry", FilterFieldType.Choice, LookupService.Industries));
			this.queryBuilder.Fields.Add(new FilterField("Size", "Size", FilterFieldType.Choice, LookupService.CompanySizes));
			this.queryBuilder.Fields.Add(new FilterField("Country", "Country", FilterFieldType.Text, null));
			this.queryBuilder.Fields.Add(new FilterField("City", "City", FilterFieldType.Text, null));
			this.queryBuilder.Fields.Add(new FilterField("Contacts", "Contacts", FilterFieldType.Number, null));
			this.queryBuilder.Fields.Add(new FilterField("OpenDeals", "Open deals", FilterFieldType.Number, null));
			this.queryBuilder.Fields.Add(new FilterField("OpenValue", "Open deal value", FilterFieldType.Number, null));
			this.queryBuilder.Fields.Add(new FilterField("WonRevenue", "Won revenue", FilterFieldType.Number, null));
			this.queryBuilder.Fields.Add(new FilterField("AnnualRevenue", "Annual revenue", FilterFieldType.Number, null));
			this.queryBuilder.Fields.Add(new FilterField("Tags", "Tags", FilterFieldType.Text, null));
			this.queryBuilder.Fields.Add(new FilterField("CreatedAt", "Created", FilterFieldType.Date, null));
			Notify.Try(() =>
			{
				var owners = LookupService.Users().Select(u => u.Name).ToArray();
				this.queryBuilder.Fields.Add(new FilterField("OwnerName", "Owner", FilterFieldType.Choice, owners));
			}, "Loading the users");

			BuildColumnMenu();

			// Sales see their own companies by default.
			this.chipGroupQuick.SelectedIndexChanged -= this.chipGroupQuick_SelectedIndexChanged;
			this.chipGroupQuick.SelectedIndex = (int)CompanyService.DefaultQuickFilter;
			this.chipGroupQuick.SelectedIndexChanged += this.chipGroupQuick_SelectedIndexChanged;

			RefreshData();
		}

		#region Filtering and paging

		private CompanyQuickFilter QuickFilter => (CompanyQuickFilter)Math.Max(0, this.chipGroupQuick.SelectedIndex);

		private void ApplyFilters(bool keepPage = false)
		{
			var search = this.textBoxSearch.Text.Trim();
			IEnumerable<CompanyRow> query = this.rows;
			if (search.Length > 0)
			{
				query = query.Where(r => RelayCrm.Text.Has(r.Name, search) || RelayCrm.Text.Has(r.Industry, search)
					|| RelayCrm.Text.Has(r.City, search) || RelayCrm.Text.Has(r.Country, search)
					|| RelayCrm.Text.Has(r.OwnerName, search) || RelayCrm.Text.Has(r.Tags, search));
			}
			query = QueryFilter.Apply(query, this.queryBuilder.Root);

			// counts of the quick filters over the searched rows.
			var searched = query.ToList();
			for (int i = 0; i < this.chipGroupQuick.Items.Count; i++)
				this.chipGroupQuick.Items[i].Count = CompanyService.Apply(searched, (CompanyQuickFilter)i, CurrentUser.Id).Count();

			this.filtered = CompanyService.Apply(searched, this.QuickFilter, CurrentUser.Id).ToList();

			var total = this.rows.Count;
			this.labelCount.Text = this.filtered.Count == total
				? total + (total == 1 ? " company" : " companies")
				: this.filtered.Count + " of " + total + " companies";

			if (!keepPage)
				this.pageIndex = 0;
			ShowPage();
		}

		private int PageCount => Math.Max(1, (this.filtered.Count + PageSize - 1) / PageSize);

		private void ShowPage()
		{
			this.pageIndex = Math.Min(this.pageIndex, this.PageCount - 1);
			var page = this.filtered.Skip(this.pageIndex * PageSize).Take(PageSize).ToList();
			this.grid.DataSource = page;


			var first = this.filtered.Count == 0 ? 0 : this.pageIndex * PageSize + 1;
			this.labelPage.Text = first + "–" + (this.pageIndex * PageSize + page.Count) + " of " + this.filtered.Count
				+ "  ·  page " + (this.pageIndex + 1) + " of " + this.PageCount;
			this.buttonPrevious.Enabled = this.pageIndex > 0;
			this.buttonNext.Enabled = this.pageIndex < this.PageCount - 1;

			this.emptyState.Title = this.rows.Count == 0 ? "No companies yet" : "No companies match";
			this.emptyState.RefreshTarget();
		}

		private void ClearFilters()
		{
			this.textBoxSearch.TextChanged -= this.textBoxSearch_TextChanged;
			this.textBoxSearch.Text = "";
			this.textBoxSearch.TextChanged += this.textBoxSearch_TextChanged;
			this.queryBuilder.Root = new QueryGroup();

			this.chipGroupQuick.SelectedIndexChanged -= this.chipGroupQuick_SelectedIndexChanged;
			this.chipGroupQuick.SelectedIndex = (int)CompanyQuickFilter.All;
			this.chipGroupQuick.SelectedIndexChanged += this.chipGroupQuick_SelectedIndexChanged;

			ApplyFilters();
		}

		#endregion

		#region Column chooser

		private void BuildColumnMenu()
		{
			this.contextMenuColumns.MenuItems.Clear();
			foreach (DataGridViewColumn column in this.grid.Columns)
			{
				if (column == this.colName)
					continue;

				var item = new MenuItem(column.HeaderText) { Checked = column.Visible, Tag = column };
				item.Click += (s, e) =>
				{
					this.userChoseColumns = true;
					var menuItem = (MenuItem)s;
					var col = (DataGridViewColumn)menuItem.Tag;
					col.Visible = !col.Visible;
					menuItem.Checked = col.Visible;
				};
				this.contextMenuColumns.MenuItems.Add(item);
			}
		}

		#endregion

		#region Handlers

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			ApplyFilters();
		}

		private void chipGroupQuick_SelectedIndexChanged(object sender, EventArgs e)
		{
			ApplyFilters();
		}

		private void queryBuilder_QueryChanged(object sender, EventArgs e)
		{
			ApplyFilters();
		}

		private void buttonAdvanced_Click(object sender, EventArgs e)
		{
			this.queryBuilder.Visible = !this.queryBuilder.Visible;
			this.buttonAdvanced.CssClass = this.queryBuilder.Visible ? "relay-primary" : "relay-secondary";

			// hiding the builder drops its rules.
			if (!this.queryBuilder.Visible && !QueryFilter.IsEmpty(this.queryBuilder.Root))
			{
				this.queryBuilder.Root = new QueryGroup();
				ApplyFilters();
			}
		}

		private void buttonColumns_Click(object sender, EventArgs e)
		{
			// rebuilt each time: the visible columns change with the width.
			BuildColumnMenu();
			this.contextMenuColumns.Show(this.buttonColumns, Placement.BottomRight, null);
		}

		/// <summary>
		/// Hides the sparkline column when it does not fit, so the grid never scrolls sideways;
		/// stops once the user picks the columns.
		/// </summary>
		private void FitColumns()
		{
			if (this.userChoseColumns)
				return;

			// room for the vertical scrollbar.
			var available = this.grid.Width - 24;
			var needed = this.colName.MinimumWidth + this.colCountry.Width + this.colOwner.Width + this.colContacts.Width
				+ this.colOpenValue.Width + this.colWonRevenue.Width + this.colTag.Width;
			this.colWonTrend.Visible = needed + this.colWonTrend.Width <= available;
		}

		private void grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
		{
			// the chip column draws a chip even for an empty value: companies without a tag get a plain cell.
			foreach (DataGridViewRow row in this.grid.Rows)
			{
				if ((row.DataBoundItem as CompanyRow)?.FirstTag == null)
					row.Cells[this.colTag.Index] = new DataGridViewTextBoxCell();
			}
		}

		private void grid_Resize(object sender, EventArgs e)
		{
			FitColumns();
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			// export every matching company, not only the current page.
			this.grid.DataSource = this.filtered;
			CsvExport.Download(this.grid, "companies.csv");
			ShowPage();
		}

		private void buttonPrevious_Click(object sender, EventArgs e)
		{
			this.pageIndex--;
			ShowPage();
		}

		private void buttonNext_Click(object sender, EventArgs e)
		{
			this.pageIndex++;
			ShowPage();
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (CompanyEditDialog.Edit(null))
				RefreshData();
		}

		private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (this.grid.Rows[e.RowIndex].DataBoundItem is CompanyRow row)
				Navigator.OpenCompany(row.Id);
		}

		private void emptyState_ActionClick(object sender, EventArgs e)
		{
			ClearFilters();
		}

		#endregion
	}
}
