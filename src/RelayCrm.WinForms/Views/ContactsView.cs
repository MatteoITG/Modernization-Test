using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// The contacts list: search, quick filters with counts, advanced filter, column chooser,
	/// CSV export and row actions (log call or email, edit, delete).
	/// </summary>
	public partial class ContactsView : UserControl, IRefreshable
	{
		// all contacts as loaded from the store; filtering happens in memory.
		private List<ContactRow> allRows = new List<ContactRow>();
		private ContactQuickFilter quickFilter;
		private FilterQuery advancedFilter = new FilterQuery();
		private FilterField[] filterFields;

		public ContactsView()
		{
			InitializeComponent();

			this.dataGridView.AutoGenerateColumns = false;
			IconImages.Apply(this.toolStrip);
			this.textSearch.TextBox.PlaceholderText = "Name, title, company, email, phone or tag";

			this.quickFilter = ContactService.DefaultQuickFilter;
			SetupFilterFields();
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

		private ToolStripButton[] QuickButtons => new[] { this.quickAll, this.quickLeads, this.quickProspects, this.quickCustomers, this.quickMine };

		private static readonly string[] QuickTexts = { "All", "Leads", "Prospects", "Customers", "My contacts" };

		private void SetupFilterFields()
		{
			string[] owners = new string[0];
			Notify.Try(() => owners = LookupService.Users().Select(u => u.Name).ToArray(), "Loading the users");

			this.filterFields = new[]
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
		}

		/// <summary>
		/// Applies search and advanced filter, updates the quick filter counts, then the quick filter and the grid.
		/// </summary>
		private void ApplyFilters()
		{
			var search = this.textSearch.Text;
			var matching = this.allRows.Where(r => ContactService.MatchesSearch(r, search));
			matching = QueryFilter.Apply(matching, this.advancedFilter);
			var list = matching.ToList();

			var counts = ContactService.QuickFilterCounts(list);
			var buttons = this.QuickButtons;
			for (var i = 0; i < buttons.Length; i++)
			{
				buttons[i].Text = QuickTexts[i] + " (" + counts[(ContactQuickFilter)i] + ")";
				buttons[i].Checked = (int)this.quickFilter == i;
			}

			var rows = list.Where(r => ContactService.InQuickFilter(r, this.quickFilter)).ToList();

			// keep the sort order the user chose by clicking a header.
			var sortColumn = this.dataGridView.SortedColumn;
			var sortOrder = this.dataGridView.SortOrder;
			this.dataGridView.DataSource = new SortableBindingList<ContactRow>(rows);
			if (sortColumn != null && sortOrder != SortOrder.None)
				this.dataGridView.Sort(sortColumn, sortOrder == SortOrder.Ascending ? System.ComponentModel.ListSortDirection.Ascending : System.ComponentModel.ListSortDirection.Descending);

			this.labelCount.Text = rows.Count == this.allRows.Count
				? this.allRows.Count + " contacts"
				: rows.Count + " of " + this.allRows.Count + " contacts";

			var filtered = !QueryFilter.IsEmpty(this.advancedFilter);
			this.labelAdvanced.Text = filtered ? "Filter: " + this.advancedFilter : "";
			this.buttonFilter.Checked = filtered;
			this.buttonClearFilter.Visible = filtered || search.Trim().Length > 0 || this.quickFilter != ContactQuickFilter.All;

			GridHelper.ShowEmpty(this.linkEmpty, rows.Count == 0,
				this.allRows.Count == 0 ? "No contacts yet." : "No contacts match the search and the filters.",
				this.allRows.Count == 0 ? null : "Clear the filters");
			UpdateButtons();
		}

		private void ClearFilters()
		{
			this.textSearch.TextChanged -= textSearch_TextChanged;
			this.textSearch.Text = "";
			this.textSearch.TextChanged += textSearch_TextChanged;
			this.advancedFilter = new FilterQuery();
			this.quickFilter = ContactQuickFilter.All;
			ApplyFilters();
		}

		private ContactRow SelectedRow => GridHelper.Current<ContactRow>(this.dataGridView);

		private void UpdateButtons()
		{
			var selected = this.SelectedRow != null;
			this.buttonEdit.Enabled = this.buttonDelete.Enabled = this.buttonLogCall.Enabled = this.buttonLogEmail.Enabled = selected;
		}

		private void DeleteContact(ContactRow row)
		{
			if (!ConfirmDialog.Ask("Delete contact",
				"Delete " + row.FullName + "? Their activities, tasks and deals are kept without the contact.", "Delete"))
				return;

			if (Notify.Try(() => ContactService.Delete(row.Id), "Deleting the contact"))
			{
				Notify.Success(row.FullName + " deleted.");
				RefreshData();
			}
		}

		#region Handlers

		private void ContactsView_Load(object sender, EventArgs e)
		{
			this.textSearch.Focus();
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (ContactEditDialog.Edit(null))
				RefreshData();
		}

		private void textSearch_TextChanged(object sender, EventArgs e)
		{
			ApplyFilters();
		}

		private void quickFilter_Click(object sender, EventArgs e)
		{
			this.quickFilter = (ContactQuickFilter)Array.IndexOf(this.QuickButtons, sender);
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

		private void linkEmpty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ClearFilters();
		}

		private void dropDownColumns_DropDownOpening(object sender, EventArgs e)
		{
			GridHelper.FillColumnMenu(this.dropDownColumns, this.dataGridView, this.colName);
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			if (this.dataGridView.RowCount == 0)
			{
				Notify.Info("There are no contacts to export.");
				return;
			}
			CsvExport.Save(this.dataGridView, "contacts.csv");
		}

		private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (e.ColumnIndex == this.colStage.Index)
				e.CellStyle.ForeColor = ToneExtensions.StageTone(e.Value as string).ToColor();
			else if (e.ColumnIndex == this.colLastContacted.Index && (e.Value as string) == "never")
				e.CellStyle.ForeColor = System.Drawing.SystemColors.GrayText;
		}

		private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = GridHelper.RowAt<ContactRow>(this.dataGridView, e.RowIndex);
			if (row != null)
				Navigator.OpenContact(row.Id);
		}

		private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			GridHelper.SelectOnRightClick(this.dataGridView, e);
		}

		private void dataGridView_KeyDown(object sender, KeyEventArgs e)
		{
			var row = this.SelectedRow;
			if (row == null)
				return;

			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				Navigator.OpenContact(row.Id);
			}
			else if (e.KeyCode == Keys.Delete)
			{
				e.Handled = true;
				DeleteContact(row);
			}
		}

		private void dataGridView_SelectionChanged(object sender, EventArgs e)
		{
			UpdateButtons();
		}

		private void contextMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
		{
			e.Cancel = this.SelectedRow == null;
		}

		private void menuOpen_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null)
				Navigator.OpenContact(this.SelectedRow.Id);
		}

		private void menuLogCall_Click(object sender, EventArgs e)
		{
			var row = this.SelectedRow;
			if (row != null && LogActivityDialog.Show(row.Id, row.CompanyId, null, ActivityType.Call, null, "Call with " + row.FullName))
				RefreshData();
		}

		private void menuLogEmail_Click(object sender, EventArgs e)
		{
			var row = this.SelectedRow;
			if (row != null && LogActivityDialog.Show(row.Id, row.CompanyId, null, ActivityType.Email, null, "Email to " + row.FullName))
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
			if (row != null)
				DeleteContact(row);
		}

		#endregion
	}
}
