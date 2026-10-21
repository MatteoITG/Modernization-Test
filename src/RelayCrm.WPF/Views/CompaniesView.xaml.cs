using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using RelayCrm.Dialogs;
using RelayCrm.Services;

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
		private FilterQuery advancedFilter = new FilterQuery();
		private List<FilterField> filterFields;
		private int pageIndex;
		private bool updatingFilters;

		public CompaniesView()
		{
			InitializeComponent();

			// Sales see their own companies by default.
			this.updatingFilters = true;
			this.QuickRadios[(int)CompanyService.DefaultQuickFilter].IsChecked = true;
			this.updatingFilters = false;

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

		private RadioButton[] QuickRadios => new[] { this.radioAll, this.radioMine, this.radioOpenDeals, this.radioCustomers };

		private CompanyQuickFilter QuickFilter => (CompanyQuickFilter)Math.Max(0, Array.FindIndex(this.QuickRadios, r => r.IsChecked == true));

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
			var names = new[] { "All", "My companies", "With open deals", "Customers" };
			for (var i = 0; i < this.QuickRadios.Length; i++)
				this.QuickRadios[i].Content = names[i] + " (" + CompanyService.Apply(searched, (CompanyQuickFilter)i, CurrentUser.Id).Count() + ")";

			this.filtered = CompanyService.Apply(searched, this.QuickFilter, CurrentUser.Id).ToList();

			var total = this.rows.Count;
			this.labelCount.Text = this.filtered.Count == total
				? total + (total == 1 ? " company" : " companies")
				: this.filtered.Count + " of " + total + " companies";

			var advanced = !QueryFilter.IsEmpty(this.advancedFilter);
			this.panelFilter.Visibility = advanced ? Visibility.Visible : Visibility.Collapsed;
			this.runFilter.Text = advanced ? this.advancedFilter.ToString() : "";
			this.buttonAdvanced.FontWeight = advanced ? FontWeights.Bold : FontWeights.Normal;

			if (!keepPage)
				this.pageIndex = 0;
			ShowPage();
		}

		private int PageCount => Math.Max(1, (this.filtered.Count + PageSize - 1) / PageSize);

		private void ShowPage()
		{
			this.pageIndex = Math.Max(0, Math.Min(this.pageIndex, this.PageCount - 1));
			var page = this.filtered.Skip(this.pageIndex * PageSize).Take(PageSize).ToList();
			this.grid.ItemsSource = page;

			var first = this.filtered.Count == 0 ? 0 : this.pageIndex * PageSize + 1;
			this.labelPage.Text = first + "–" + (this.pageIndex * PageSize + page.Count) + " of " + this.filtered.Count
				+ "  ·  page " + (this.pageIndex + 1) + " of " + this.PageCount;
			this.buttonPrevious.IsEnabled = this.pageIndex > 0;
			this.buttonNext.IsEnabled = this.pageIndex < this.PageCount - 1;

			this.labelEmpty.Text = this.rows.Count == 0 ? "No companies yet" : "No companies match";
			this.emptyState.Visibility = page.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
		}

		private void ClearFilters()
		{
			this.updatingFilters = true;
			try
			{
				this.textBoxSearch.Text = "";
				this.advancedFilter = new FilterQuery();
				this.radioAll.IsChecked = true;
			}
			finally
			{
				this.updatingFilters = false;
			}
			ApplyFilters();
		}

		#endregion

		#region Handlers

		private CompanyRow SelectedRow => this.grid.SelectedItem as CompanyRow;

		private void textBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
		{
			if (!this.updatingFilters)
				ApplyFilters();
		}

		private void radioQuick_Checked(object sender, RoutedEventArgs e)
		{
			// raised by InitializeComponent before the grid exists.
			if (!this.updatingFilters && this.grid != null)
				ApplyFilters();
		}

		private void buttonAdvanced_Click(object sender, RoutedEventArgs e)
		{
			var query = AdvancedFilterDialog.Edit(FilterFields(), this.advancedFilter);
			if (query == null)
				return;

			this.advancedFilter = query;
			ApplyFilters();
		}

		private void linkClearFilter_Click(object sender, RoutedEventArgs e)
		{
			ClearFilters();
		}

		private void buttonColumns_Click(object sender, RoutedEventArgs e)
		{
			var menu = new ContextMenu { PlacementTarget = this.buttonColumns, Placement = PlacementMode.Bottom };
			foreach (var column in this.grid.Columns.Where(c => c != this.colName))
			{
				var col = column;
				var item = new MenuItem { Header = col.Header, IsCheckable = true, IsChecked = col.Visibility == Visibility.Visible };
				item.Click += (s, args) => col.Visibility = item.IsChecked ? Visibility.Visible : Visibility.Collapsed;
				menu.Items.Add(item);
			}
			menu.IsOpen = true;
		}

		private void buttonExport_Click(object sender, RoutedEventArgs e)
		{
			// export every matching company, not only the current page.
			CsvExport.Save(this.grid, "companies.csv", this.filtered);
		}

		private void buttonPrevious_Click(object sender, RoutedEventArgs e)
		{
			this.pageIndex--;
			ShowPage();
		}

		private void buttonNext_Click(object sender, RoutedEventArgs e)
		{
			this.pageIndex++;
			ShowPage();
		}

		private void buttonNew_Click(object sender, RoutedEventArgs e)
		{
			if (CompanyEditDialog.Edit(null))
				RefreshData();
		}

		private void grid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<CompanyRow>(e) is CompanyRow row)
				Navigator.OpenCompany(row.Id);
		}

		private void menuOpen_Click(object sender, RoutedEventArgs e)
		{
			if (this.SelectedRow != null)
				Navigator.OpenCompany(this.SelectedRow.Id);
		}

		private void menuEdit_Click(object sender, RoutedEventArgs e)
		{
			if (this.SelectedRow != null && CompanyEditDialog.Edit(this.SelectedRow.Id))
				RefreshData();
		}

		private void menuLogActivity_Click(object sender, RoutedEventArgs e)
		{
			if (this.SelectedRow != null && LogActivityDialog.Log(companyId: this.SelectedRow.Id))
				RefreshData();
		}

		private void menuNewDeal_Click(object sender, RoutedEventArgs e)
		{
			if (this.SelectedRow != null && DealEditDialog.Edit(null, this.SelectedRow.Id))
				RefreshData();
		}

		private void menuDelete_Click(object sender, RoutedEventArgs e)
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
