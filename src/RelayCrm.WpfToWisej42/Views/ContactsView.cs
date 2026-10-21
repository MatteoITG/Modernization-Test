using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;
using FilterField = RelayCrm.Services.FilterField;
using FilterFieldType = RelayCrm.Services.FilterFieldType;

namespace RelayCrm.Views
{
	/// <summary>
	/// The contacts list: search, quick filters with counts, advanced filter, column chooser,
	/// CSV export and row actions (log call or email, edit, delete) in the context menu.
	/// </summary>
	/// <remarks>
	/// Migration step 2: the quick filter radio buttons became a ChipGroup with counts, the name and owner columns
	/// avatar columns, the stage a chip column, the empty panel an EmptyState, and the search box has a clear button.
	/// </remarks>
	public partial class ContactsView : UserControl, IRefreshable
	{
		// all contacts as loaded from the store; filtering happens in memory.
		private List<ContactRow> allRows = new List<ContactRow>();
		private FilterQuery advancedFilter = new FilterQuery();
		private List<FilterField> filterFields;
		private ContactQuickFilter quickFilter;

		public ContactsView()
		{
			InitializeComponent();
			GridHelper.UseConverters(this.dataGrid);
			ToneExtensions.AddStageTones(this.colStage.ToneMap);

			this.quickFilter = ContactService.DefaultQuickFilter;
			RefreshData();
		}

		/// <summary>
		/// Selects a quick filter (All, Leads, Prospects, Customers, My contacts) and updates the list.
		/// </summary>
		public void SelectQuickFilter(ContactQuickFilter filter)
		{
			this.quickFilter = filter;
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

			// the counts of the chips (they were in the text of the radio buttons).
			var counts = ContactService.QuickFilterCounts(list);
			var chips = this.chipsQuick.Items;
			for (var i = 0; i < chips.Count; i++)
				chips[i].Count = counts[(ContactQuickFilter)i];
			this.chipsQuick.SelectedIndex = (int)this.quickFilter;

			var rows = list.Where(r => ContactService.InQuickFilter(r, this.quickFilter)).ToList();
			this.dataGrid.DataSource = rows;
			GridHelper.ShowEmpty(this.emptyState, rows.Count == 0,
				this.allRows.Count == 0 ? "No contacts yet" : "No contacts match",
				this.allRows.Count == 0 ? null : "Clear the filters");

			this.labelCount.Text = rows.Count == this.allRows.Count
				? this.allRows.Count + " contacts"
				: rows.Count + " of " + this.allRows.Count + " contacts";

			var filtered = !QueryFilter.IsEmpty(this.advancedFilter);
			this.panelFilter.Visible = filtered;
			this.runFilter.Text = filtered ? this.advancedFilter.ToString() : "";
			this.buttonAdvanced.CssClass = filtered ? "relay-primary" : "relay-secondary";
		}

		private void ClearFilters()
		{
			this.textBoxSearch.TextChanged -= textBoxSearch_TextChanged;
			this.textBoxSearch.Text = "";
			this.textBoxSearch.TextChanged += textBoxSearch_TextChanged;
			this.advancedFilter = new FilterQuery();
			this.quickFilter = ContactQuickFilter.All;
			ApplyFilters();
		}

		private ContactRow SelectedRow => UiHelper.SelectedItem<ContactRow>(this.dataGrid);

		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (ContactEditDialog.Edit(null))
				RefreshData();
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
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

			this.quickFilter = (ContactQuickFilter)this.chipsQuick.SelectedIndex;
			ApplyFilters();
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

		private void emptyState_ActionClick(object sender, EventArgs e)
		{
			ClearFilters();
		}
		private void buttonColumns_Click(object sender, EventArgs e)
		{
			var menu = new ContextMenu();
			foreach (var column in this.dataGrid.Columns.Cast<DataGridViewColumn>().Where(c => c != this.colName))
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
			CsvExport.Save(this.dataGrid, "contacts.csv");
		}

		private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (UiHelper.RowItem<ContactRow>(this.dataGrid, e) is ContactRow row)
				Navigator.OpenContact(row.Id);
		}

		private void menuOpen_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null)
				Navigator.OpenContact(this.SelectedRow.Id);
		}

		private void menuCall_Click(object sender, EventArgs e)
		{
			var row = this.SelectedRow;
			if (row != null && LogActivityDialog.Log(row.Id, row.CompanyId, null, ActivityType.Call, null, "Call with " + row.FullName))
				RefreshData();
		}

		private void menuEmail_Click(object sender, EventArgs e)
		{
			var row = this.SelectedRow;
			if (row != null && LogActivityDialog.Log(row.Id, row.CompanyId, null, ActivityType.Email, null, "Email to " + row.FullName))
				RefreshData();
		}

		private void menuEdit_Click(object sender, EventArgs e)
		{
			var row = this.SelectedRow;
			if (row != null && ContactEditDialog.Edit(row.Id))
				RefreshData();
		}

		private void menuDelete_Click(object sender, EventArgs e)
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
