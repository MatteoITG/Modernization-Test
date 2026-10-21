using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// The contacts list: search, quick filters with counts, advanced filter, column chooser,
	/// CSV export and row actions (log call or email, edit, delete) in the context menu.
	/// </summary>
	public partial class ContactsView : UserControl, IRefreshable
	{
		// all contacts as loaded from the store; filtering happens in memory.
		private List<ContactRow> allRows = new List<ContactRow>();
		private FilterQuery advancedFilter = new FilterQuery();
		private List<FilterField> filterFields;
		private bool updatingFilters;

		public ContactsView()
		{
			InitializeComponent();

			SetFilterSilently(ContactService.DefaultQuickFilter);
			RefreshData();
		}

		/// <summary>
		/// Selects a quick filter (All, Leads, Prospects, Customers, My contacts) and updates the list.
		/// </summary>
		public void SelectQuickFilter(ContactQuickFilter filter)
		{
			SetFilterSilently(filter);
			ApplyFilters();
		}

		/// <summary>
		/// Reloads the contacts from the store, keeping search and filters.
		/// </summary>
		public void RefreshData()
		{
			List<ContactRow> rows = null;
			if (Notify.Try(() => rows = ContactService.Rows(), "Loading the contacts"))
				this.allRows = rows;
			ApplyFilters();
		}

		private RadioButton[] QuickRadios => new[] { this.radioAll, this.radioLeads, this.radioProspects, this.radioCustomers, this.radioMine };

		private ContactQuickFilter QuickFilter
		{
			get
			{
				var index = Array.FindIndex(this.QuickRadios, r => r.IsChecked == true);
				return (ContactQuickFilter)Math.Max(0, index);
			}
		}

		private void SetFilterSilently(ContactQuickFilter filter)
		{
			this.updatingFilters = true;
			try
			{
				this.QuickRadios[(int)filter].IsChecked = true;
			}
			finally
			{
				this.updatingFilters = false;
			}
		}

		private List<FilterField> FilterFields()
		{
			if (this.filterFields != null)
				return this.filterFields;

			string[] owners = new string[0];
			Notify.Try(() => owners = LookupService.Users().Select(u => u.Name).ToArray(), "Loading the users");

			this.filterFields = new List<FilterField>
			{
				new FilterField("FullName", "Name", FilterFieldType.Text),
				new FilterField("Title", "Job title", FilterFieldType.Text),
				new FilterField("Company", "Company", FilterFieldType.Text),
				new FilterField("Email", "Email", FilterFieldType.Text),
				new FilterField("Phone", "Phone", FilterFieldType.Text),
				new FilterField("Stage", "Lifecycle stage", FilterFieldType.Choice, Enum.GetNames(typeof(LifecycleStage))),
				new FilterField("Owner", "Owner", FilterFieldType.Choice, owners),
				new FilterField("LeadSource", "Lead source", FilterFieldType.Choice, LookupService.LeadSources),
				new FilterField("Tags", "Tags", FilterFieldType.Text),
				new FilterField("LastContacted", "Last contacted", FilterFieldType.Date),
				new FilterField("CreatedAt", "Created", FilterFieldType.Date),
			};
			return this.filterFields;
		}

		/// <summary>
		/// Applies search and advanced filter, updates the quick filter counts, then the quick filter and the grid.
		/// </summary>
		private void ApplyFilters()
		{
			var search = this.textBoxSearch.Text;
			var matching = this.allRows.Where(r => ContactService.MatchesSearch(r, search));
			matching = QueryFilter.Apply(matching, this.advancedFilter);
			var list = matching.ToList();

			var counts = ContactService.QuickFilterCounts(list);
			var names = new[] { "All", "Leads", "Prospects", "Customers", "My contacts" };
			for (var i = 0; i < this.QuickRadios.Length; i++)
				this.QuickRadios[i].Content = names[i] + " (" + counts[(ContactQuickFilter)i] + ")";

			var filter = this.QuickFilter;
			var rows = list.Where(r => ContactService.InQuickFilter(r, filter)).ToList();

			this.dataGrid.ItemsSource = rows;
			this.emptyState.Visibility = rows.Count == 0 ? Visibility.Visible : Visibility.Collapsed;

			this.labelCount.Text = rows.Count == this.allRows.Count
				? this.allRows.Count + " contacts"
				: rows.Count + " of " + this.allRows.Count + " contacts";

			var filtered = !QueryFilter.IsEmpty(this.advancedFilter);
			this.panelFilter.Visibility = filtered ? Visibility.Visible : Visibility.Collapsed;
			this.runFilter.Text = filtered ? this.advancedFilter.ToString() : "";
			this.buttonAdvanced.FontWeight = filtered ? FontWeights.Bold : FontWeights.Normal;
		}

		private ContactRow SelectedRow => this.dataGrid.SelectedItem as ContactRow;

		private void buttonNew_Click(object sender, RoutedEventArgs e)
		{
			if (ContactEditDialog.Edit(null))
				RefreshData();
		}

		private void textBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
		{
			ApplyFilters();
		}

		private void radioQuick_Checked(object sender, RoutedEventArgs e)
		{
			// raised by InitializeComponent before the grid exists.
			if (!this.updatingFilters && this.dataGrid != null)
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
			this.textBoxSearch.Text = "";
			this.advancedFilter = new FilterQuery();
			SetFilterSilently(ContactQuickFilter.All);
			ApplyFilters();
		}

		private void buttonColumns_Click(object sender, RoutedEventArgs e)
		{
			var menu = new ContextMenu { PlacementTarget = this.buttonColumns, Placement = PlacementMode.Bottom };
			foreach (var column in this.dataGrid.Columns.Where(c => c != this.colName))
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
			CsvExport.Save(this.dataGrid, "contacts.csv");
		}

		private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<ContactRow>(e) is ContactRow row)
				Navigator.OpenContact(row.Id);
		}

		private void menuOpen_Click(object sender, RoutedEventArgs e)
		{
			if (this.SelectedRow != null)
				Navigator.OpenContact(this.SelectedRow.Id);
		}

		private void menuCall_Click(object sender, RoutedEventArgs e)
		{
			var row = this.SelectedRow;
			if (row != null && LogActivityDialog.Log(row.Id, row.CompanyId, null, ActivityType.Call, null, "Call with " + row.FullName))
				RefreshData();
		}

		private void menuEmail_Click(object sender, RoutedEventArgs e)
		{
			var row = this.SelectedRow;
			if (row != null && LogActivityDialog.Log(row.Id, row.CompanyId, null, ActivityType.Email, null, "Email to " + row.FullName))
				RefreshData();
		}

		private void menuEdit_Click(object sender, RoutedEventArgs e)
		{
			var row = this.SelectedRow;
			if (row != null && ContactEditDialog.Edit(row.Id))
				RefreshData();
		}

		private void menuDelete_Click(object sender, RoutedEventArgs e)
		{
			var row = this.SelectedRow;
			if (row == null)
				return;

			if (!ConfirmDialog.Ask("Delete contact?",
				"Delete " + row.FullName + "? Their activities, tasks and deals are kept without the contact.", "Delete"))
				return;

			if (Notify.Try(() => ContactService.Delete(row.Id), "Deleting the contact"))
			{
				Notify.Success(row.FullName + " deleted.");
				RefreshData();
			}
		}
	}
}
