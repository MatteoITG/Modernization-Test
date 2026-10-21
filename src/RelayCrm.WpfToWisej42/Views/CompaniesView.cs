using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;
using FilterField = RelayCrm.Services.FilterField;
using FilterFieldType = RelayCrm.Services.FilterFieldType;

namespace RelayCrm.Views
{
	/// <summary>
	/// The companies list: search, quick filters, advanced filter, column chooser, CSV export and paging.
	/// </summary>
	/// <remarks>
	/// The Sparkline template column of the WPF grid became a <see cref="DataGridViewSparklineColumn"/>.
	/// Migration step 2: the quick filter radio buttons became a ChipGroup with counts, the name and owner columns
	/// avatar columns, the first tag a chip column, the empty panel an EmptyState, and the search box has a clear button.
	/// </remarks>
	public partial class CompaniesView : UserControl, IRefreshable
	{
		private const int PageSize = 20;

		// all the companies, and the ones matching the filters.
		private List<CompanyRow> rows = new List<CompanyRow>();
		private List<CompanyRow> filtered = new List<CompanyRow>();
		private FilterQuery advancedFilter = new FilterQuery();
		private List<FilterField> filterFields;
		private int pageIndex;
		private bool updatingFilters;
		private CompanyQuickFilter quickFilter;

		public CompaniesView()
		{
			InitializeComponent();
			GridHelper.UseConverters(this.grid);

			// Sales see their own companies by default.
			this.quickFilter = CompanyService.DefaultQuickFilter;

			RefreshData();
		}

		/// <summary>
		/// Reloads the companies, keeping the filters (called when coming back from a company).
		/// </summary>
		public void RefreshData()
		{
			Notify.Try(() => this.rows = CompanyService.List(), "Loading the companies");
			ApplyFilters(keepPage: true);
		}

		#region Filtering and paging

		private List<FilterField> FilterFields()
		{
			if (this.filterFields != null)
				return this.filterFields;

			var owners = new string[0];
			Notify.Try(() => owners = LookupService.Users().Select(u => u.Name).ToArray(), "Loading the users");
			this.filterFields = new List<FilterField>
			{
				new FilterField("Name", "Name", FilterFieldType.Text),
				new FilterField("Industry", "Industry", FilterFieldType.Choice, LookupService.Industries),
				new FilterField("Size", "Size", FilterFieldType.Choice, LookupService.CompanySizes),
				new FilterField("Country", "Country", FilterFieldType.Text),
				new FilterField("City", "City", FilterFieldType.Text),
				new FilterField("Contacts", "Contacts", FilterFieldType.Number),
				new FilterField("OpenDeals", "Open deals", FilterFieldType.Number),
				new FilterField("OpenValue", "Open deal value", FilterFieldType.Number),
				new FilterField("WonRevenue", "Won revenue", FilterFieldType.Number),
				new FilterField("AnnualRevenue", "Annual revenue", FilterFieldType.Number),
				new FilterField("Tags", "Tags", FilterFieldType.Text),
				new FilterField("CreatedAt", "Created", FilterFieldType.Date),
				new FilterField("OwnerName", "Owner", FilterFieldType.Choice, owners),
			};
			return this.filterFields;
		}

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
			query = QueryFilter.Apply(query, this.advancedFilter);

			// counts of the quick filters over the searched rows.
			var searched = query.ToList();
			var chips = this.chipsQuick.Items;
			for (var i = 0; i < chips.Count; i++)
				chips[i].Count = CompanyService.Apply(searched, (CompanyQuickFilter)i, CurrentUser.Id).Count();
			this.chipsQuick.SelectedIndex = (int)this.quickFilter;

			this.filtered = CompanyService.Apply(searched, this.quickFilter, CurrentUser.Id).ToList();

			var total = this.rows.Count;
			this.labelCount.Text = this.filtered.Count == total
				? total + (total == 1 ? " company" : " companies")
				: this.filtered.Count + " of " + total + " companies";

			var advanced = !QueryFilter.IsEmpty(this.advancedFilter);
			this.panelFilter.Visible = advanced;
			this.runFilter.Text = advanced ? this.advancedFilter.ToString() : "";
			this.buttonAdvanced.CssClass = advanced ? "relay-primary" : "relay-secondary";

			if (!keepPage)
				this.pageIndex = 0;
			ShowPage();
		}

		private int PageCount => Math.Max(1, (this.filtered.Count + PageSize - 1) / PageSize);

		private void ShowPage()
		{
			this.pageIndex = Math.Max(0, Math.Min(this.pageIndex, this.PageCount - 1));
			var page = this.filtered.Skip(this.pageIndex * PageSize).Take(PageSize).ToList();
			this.grid.DataSource = page;

			var first = this.filtered.Count == 0 ? 0 : this.pageIndex * PageSize + 1;
			this.labelPage.Text = first + "–" + (this.pageIndex * PageSize + page.Count) + " of " + this.filtered.Count
				+ "  ·  page " + (this.pageIndex + 1) + " of " + this.PageCount;
			this.buttonPrevious.Enabled = this.pageIndex > 0;
			this.buttonNext.Enabled = this.pageIndex < this.PageCount - 1;

			GridHelper.ShowEmpty(this.emptyState, page.Count == 0,
				this.rows.Count == 0 ? "No companies yet" : "No companies match",
				this.rows.Count == 0 ? null : "Clear the filters");
		}

		private void ClearFilters()
		{
			this.updatingFilters = true;
			try
			{
				this.textBoxSearch.Text = "";
				this.advancedFilter = new FilterQuery();
				this.quickFilter = CompanyQuickFilter.All;
			}
			finally
			{
				this.updatingFilters = false;
			}
			ApplyFilters();
		}

		#endregion

		#region Handlers

		private CompanyRow SelectedRow => UiHelper.SelectedItem<CompanyRow>(this.grid);

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			if (!this.updatingFilters)
				ApplyFilters();
		}

		private void textBoxSearch_ToolClick(object sender, ToolClickEventArgs e)
		{
			this.textBoxSearch.Text = "";
			this.textBoxSearch.Focus();
		}

		private void chipsQuick_SelectedIndexChanged(object sender, EventArgs e)
		{
			// raised also when ApplyFilters selects the chip of the current filter.
			if (this.chipsQuick.SelectedIndex < 0 || this.chipsQuick.SelectedIndex == (int)this.quickFilter)
				return;

			this.quickFilter = (CompanyQuickFilter)this.chipsQuick.SelectedIndex;
			ApplyFilters();
		}

		private void emptyState_ActionClick(object sender, EventArgs e)
		{
			ClearFilters();
		}

		private void buttonAdvanced_Click(object sender, EventArgs e)
		{
			var query = AdvancedFilterDialog.Edit(FilterFields(), this.advancedFilter);
			if (query == null)
				return;

			this.advancedFilter = query;
			ApplyFilters();
		}

		private void linkClearFilter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ClearFilters();
		}

		private void buttonColumns_Click(object sender, EventArgs e)
		{
			var menu = this.menuColumns;
			menu.MenuItems.Clear(true);
			foreach (var column in this.grid.Columns.Cast<DataGridViewColumn>().Where(c => c != this.colName))
			{
				var col = column;
				var item = new MenuItem(col.HeaderText) { Checked = col.Visible };
				item.Click += (s, args) => col.Visible = item.Checked = !item.Checked;
				menu.MenuItems.Add(item);
			}
			menu.Show(this.buttonColumns, Placement.BottomLeft);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			// export every matching company, not only the current page.
			CsvExport.Save(this.grid, "companies.csv", this.filtered);
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
			if (UiHelper.RowItem<CompanyRow>(this.grid, e) is CompanyRow row)
				Navigator.OpenCompany(row.Id);
		}

		private void grid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			// the WPF DataGrid selects the row under a right click: the context menu acts on it.
			if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
				this.grid.CurrentCell = this.grid.Rows[e.RowIndex].Cells[e.ColumnIndex];
		}

		private void menuOpen_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null)
				Navigator.OpenCompany(this.SelectedRow.Id);
		}

		private void menuEdit_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null && CompanyEditDialog.Edit(this.SelectedRow.Id))
				RefreshData();
		}

		private void menuLogActivity_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null && LogActivityDialog.Log(companyId: this.SelectedRow.Id))
				RefreshData();
		}

		private void menuNewDeal_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null && DealEditDialog.Edit(null, this.SelectedRow.Id))
				RefreshData();
		}

		private void menuDelete_Click(object sender, EventArgs e)
		{
			var row = this.SelectedRow;
			if (row == null)
				return;

			var message = "Delete " + row.Name + "? Its contacts, deals, activities and tasks are kept but no longer linked to a company.";
			if (!ConfirmDialog.Ask("Delete company", message, "Delete"))
				return;

			if (Notify.Try(() => CompanyService.Delete(row.Id), "Deleting the company"))
			{
				Notify.Success(row.Name + " deleted.");
				RefreshData();
			}
		}

		#endregion
	}
}
