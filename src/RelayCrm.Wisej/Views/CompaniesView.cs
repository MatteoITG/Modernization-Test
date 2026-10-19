using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Wisej.Web;
using RelayCrm.Dialogs;
using RelayCrm.Services;
// Wisej 4.2 has its own FilterField (QueryBuilder): use the one of the app.
using FilterField = RelayCrm.Services.FilterField;
using FilterFieldType = RelayCrm.Services.FilterFieldType;

namespace RelayCrm.Views
{
	/// <summary>
	/// The companies list: search, quick filters, advanced filter, column chooser, CSV export and paging.
	/// </summary>
	public partial class CompaniesView : UserControl, IRefreshable
	{
		private const int PageSize = 50;

		// all the companies, and the ones matching the filters.
		private List<CompanyRow> rows = new List<CompanyRow>();
		private List<CompanyRow> filtered = new List<CompanyRow>();
		private int pageIndex;
		private CompanyQuickFilter quickFilter;
		private FilterQuery advancedFilter = new FilterQuery();
		private FilterField[] filterFields;

		public CompaniesView()
		{
			InitializeComponent();

			this.grid.AutoGenerateColumns = false;
			this.grid.DefaultCellStyle.FormatProvider = Fmt.Culture;
			IconImages.Apply(this.toolStrip);
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
			string[] owners = new string[0];
			Notify.Try(() => owners = LookupService.Users().Select(u => u.Name).ToArray(), "Loading the users");
			this.filterFields = new[]
			{
				new FilterField("Name", "Name", FilterFieldType.Text),
				new FilterField("Industry", "Industry", FilterFieldType.Choice, LookupService.Industries),
				new FilterField("Size", "Size", FilterFieldType.Choice, LookupService.CompanySizes),
				new FilterField("Country", "Country", FilterFieldType.Text),
				new FilterField("City", "City", FilterFieldType.Text),
				new FilterField("OwnerName", "Owner", FilterFieldType.Choice, owners),
				new FilterField("Contacts", "Contacts", FilterFieldType.Number),
				new FilterField("OpenDeals", "Open deals", FilterFieldType.Number),
				new FilterField("OpenValue", "Open deal value", FilterFieldType.Number),
				new FilterField("WonRevenue", "Won revenue", FilterFieldType.Number),
				new FilterField("AnnualRevenue", "Annual revenue", FilterFieldType.Number),
				new FilterField("Tags", "Tags", FilterFieldType.Text),
				new FilterField("CreatedAt", "Created", FilterFieldType.Date),
			};

			// Sales see their own companies by default.
			this.quickFilter = CompanyService.DefaultQuickFilter;
			RefreshData();
			this.textSearch.Focus();
		}

		#region Filtering and paging

		private void ApplyFilters(bool keepPage = false)
		{
			var search = this.textSearch.Text.Trim();
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
			var segments = this.segmentedQuick.Items;
			for (int i = 0; i < segments.Count; i++)
				segments[i].Count = CompanyService.Apply(searched, (CompanyQuickFilter)i, CurrentUser.Id).Count();
			this.segmentedQuick.SelectedIndex = (int)this.quickFilter;

			this.filtered = CompanyService.Apply(searched, this.quickFilter, CurrentUser.Id).ToList();
			SortFiltered();

			var total = this.rows.Count;
			this.labelCount.Text = this.filtered.Count == total
				? total + (total == 1 ? " company" : " companies")
				: this.filtered.Count + " of " + total + " companies";

			var advanced = !QueryFilter.IsEmpty(this.advancedFilter);
			this.labelAdvanced.Text = advanced ? "Filter: " + this.advancedFilter : "";
			this.buttonFilter.Pushed = advanced;
			this.buttonClearFilter.Visible = advanced || search.Length > 0 || this.quickFilter != CompanyQuickFilter.All;

			if (!keepPage)
				this.pageIndex = 0;
			ShowPage();
		}

		// the grid sorts the whole filtered list, not only the page: the header click is handled here.
		private string sortProperty;
		private ListSortDirection sortDirection;

		private void SortFiltered()
		{
			if (this.sortProperty == null)
				return;

			var property = TypeDescriptor.GetProperties(typeof(CompanyRow))[this.sortProperty];
			var sorted = new SortableBindingList<CompanyRow>(this.filtered);
			((IBindingList)sorted).ApplySort(property, this.sortDirection);
			this.filtered = sorted.ToList();
		}

		private int PageCount => Math.Max(1, (this.filtered.Count + PageSize - 1) / PageSize);

		private void ShowPage()
		{
			this.pageIndex = Math.Min(this.pageIndex, this.PageCount - 1);
			var page = this.filtered.Skip(this.pageIndex * PageSize).Take(PageSize).ToList();
			this.grid.DataSource = page;
			ShowSortGlyph();

			var first = this.filtered.Count == 0 ? 0 : this.pageIndex * PageSize + 1;
			this.labelPage.Text = first + "–" + (this.pageIndex * PageSize + page.Count) + " of " + this.filtered.Count
				+ "    Page " + (this.pageIndex + 1) + " of " + this.PageCount;
			this.buttonPrevious.Enabled = this.pageIndex > 0;
			this.buttonNext.Enabled = this.pageIndex < this.PageCount - 1;

			GridHelper.ShowEmpty(this.emptyState, this.filtered.Count == 0,
				this.rows.Count == 0 ? "No companies yet." : "No companies match the search and the filters.",
				this.rows.Count == 0 ? null : "Clear the filters");
			UpdateButtons();
		}

		private void ShowSortGlyph()
		{
			foreach (DataGridViewColumn column in this.grid.Columns)
			{
				column.SortMode = DataGridViewColumnSortMode.Programmatic;
				column.HeaderCell.SortGlyphDirection = column.DataPropertyName == this.sortProperty
					? (this.sortDirection == ListSortDirection.Ascending ? SortOrder.Ascending : SortOrder.Descending)
					: SortOrder.None;
			}
		}

		private void ClearFilters()
		{
			this.textSearch.TextChanged -= this.textSearch_TextChanged;
			this.textSearch.Text = "";
			this.textSearch.TextChanged += this.textSearch_TextChanged;
			this.advancedFilter = new FilterQuery();
			this.quickFilter = CompanyQuickFilter.All;
			ApplyFilters();
		}

		#endregion

		private CompanyRow SelectedRow => GridHelper.Current<CompanyRow>(this.grid);

		private void UpdateButtons()
		{
			this.buttonEdit.Enabled = this.buttonDelete.Enabled = this.SelectedRow != null;
		}

		private void DeleteCompany(CompanyRow row)
		{
			var message = "Delete " + row.Name + "? Its contacts, deals, activities and tasks are kept but no longer linked to a company.";
			if (!ConfirmDialog.Ask("Delete company", message, "Delete"))
				return;

			if (Notify.Try(() => CompanyService.Delete(row.Id), "Deleting the company"))
			{
				Notify.Success(row.Name + " deleted.");
				RefreshData();
			}
		}

		#region Handlers

		private void textSearch_TextChanged(object sender, EventArgs e)
		{
			ApplyFilters();
		}

		private void textSearch_ToolClick(object sender, ToolClickEventArgs e)
		{
			this.textSearch.Text = "";
		}

		private void segmentedQuick_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.segmentedQuick.SelectedIndex < 0 || this.segmentedQuick.SelectedIndex == (int)this.quickFilter)
				return;

			this.quickFilter = (CompanyQuickFilter)this.segmentedQuick.SelectedIndex;
			ApplyFilters();
		}

		private void buttonFilter_Click(object sender, EventArgs e)
		{
			var query = FilterDialog.Edit(this.filterFields, this.advancedFilter);
			if (query == null)
				return;

			this.advancedFilter = query;
			ApplyFilters();
		}

		private void buttonClearFilter_Click(object sender, EventArgs e)
		{
			ClearFilters();
		}

		private void emptyState_ActionClick(object sender, EventArgs e)
		{
			ClearFilters();
		}

		private void dropDownColumns_DropDownOpening(object sender, EventArgs e)
		{
			GridHelper.FillColumnMenu(this.dropDownColumns, this.grid, this.colName);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			if (this.filtered.Count == 0)
			{
				Notify.Info("There are no companies to export.");
				return;
			}

			// export every matching company, not only the current page.
			this.grid.DataSource = this.filtered;
			try
			{
				CsvExport.Save(this.grid, "companies.csv");
			}
			finally
			{
				ShowPage();
			}
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

		private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (e.ColumnIndex == this.colWonRevenue.Index || e.ColumnIndex == this.colOpenValue.Index)
			{
				if (e.Value is decimal amount && amount == 0)
					e.CellStyle.ForeColor = System.Drawing.SystemColors.GrayText;
			}
		}

		private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = GridHelper.RowAt<CompanyRow>(this.grid, e.RowIndex);
			if (row != null)
				Navigator.OpenCompany(row.Id);
		}

		private void grid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.RowIndex == -1 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Left)
			{
				// header click: sort the whole list by this column.
				var property = this.grid.Columns[e.ColumnIndex].DataPropertyName;
				if (string.IsNullOrEmpty(property))
					return;
				this.sortDirection = this.sortProperty == property && this.sortDirection == ListSortDirection.Ascending
					? ListSortDirection.Descending
					: ListSortDirection.Ascending;
				this.sortProperty = property;
				SortFiltered();
				ShowPage();
				return;
			}
			GridHelper.SelectOnRightClick(this.grid, e);
		}

		private void grid_KeyDown(object sender, KeyEventArgs e)
		{
			var row = this.SelectedRow;
			if (row == null)
				return;

			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				Navigator.OpenCompany(row.Id);
			}
			else if (e.KeyCode == Keys.Delete)
			{
				e.Handled = true;
				DeleteCompany(row);
			}
		}

		private void grid_SelectionChanged(object sender, EventArgs e)
		{
			UpdateButtons();
		}

		private void contextMenu_Opening(object sender, EventArgs e)
		{
			// the popup of a Wisej context menu cannot be cancelled: the commands check the selected row.
		}

		private void menuOpen_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null)
				Navigator.OpenCompany(this.SelectedRow.Id);
		}

		private void menuEdit_Click(object sender, EventArgs e)
		{
			var row = this.SelectedRow;
			if (row != null && CompanyEditDialog.Edit(row.Id))
				RefreshData();
		}

		private void menuDelete_Click(object sender, EventArgs e)
		{
			var row = this.SelectedRow;
			if (row != null)
				DeleteCompany(row);
		}

		#endregion
	}
}
