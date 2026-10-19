using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

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
		private bool updatingFilters;
		// true once the user picked the columns: the grid stops hiding columns that do not fit.
		private bool userChoseColumns;

		public ContactsView()
		{
			InitializeComponent();

			this.dataGridView.AutoGenerateColumns = false;

			this.colStage.ToneMap["Lead"] = ChipTone.Neutral;
			this.colStage.ToneMap["Prospect"] = ChipTone.Warning;
			this.colStage.ToneMap["Customer"] = ChipTone.Success;
			this.colStage.ToneMap["Churned"] = ChipTone.Danger;

			SetupQueryBuilder();
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

		private ContactQuickFilter QuickFilter => (ContactQuickFilter)Math.Max(0, this.chipGroupFilters.SelectedIndex);

		private void SetFilterSilently(ContactQuickFilter filter)
		{
			this.updatingFilters = true;
			try
			{
				this.chipGroupFilters.SelectedIndex = (int)filter;
			}
			finally
			{
				this.updatingFilters = false;
			}
		}

		private void SetupQueryBuilder()
		{
			string[] owners = new string[0];
			Notify.Try(() => owners = LookupService.Users().Select(u => u.Name).ToArray(), "Loading the users");

			var fields = this.queryBuilder.Fields;
			fields.Add(new FilterField("FullName", "Name", FilterFieldType.Text, null));
			fields.Add(new FilterField("Title", "Job title", FilterFieldType.Text, null));
			fields.Add(new FilterField("Company", "Company", FilterFieldType.Text, null));
			fields.Add(new FilterField("Email", "Email", FilterFieldType.Text, null));
			fields.Add(new FilterField("Phone", "Phone", FilterFieldType.Text, null));
			fields.Add(new FilterField("Stage", "Lifecycle stage", FilterFieldType.Choice, Enum.GetNames(typeof(LifecycleStage))));
			fields.Add(new FilterField("Owner", "Owner", FilterFieldType.Choice, owners));
			fields.Add(new FilterField("LeadSource", "Lead source", FilterFieldType.Choice, LookupService.LeadSources));
			fields.Add(new FilterField("Tags", "Tags", FilterFieldType.Text, null));
			fields.Add(new FilterField("LastContacted", "Last contacted", FilterFieldType.Date, null));
			fields.Add(new FilterField("CreatedAt", "Created", FilterFieldType.Date, null));
		}

		/// <summary>
		/// Applies search and advanced filter, updates the chip counts, then the quick filter and the grid.
		/// </summary>
		private void ApplyFilters()
		{
			var search = this.textBoxSearch.Text;
			var matching = this.allRows.Where(r => ContactService.MatchesSearch(r, search));
			if (!QueryFilter.IsEmpty(this.queryBuilder.Root))
				matching = QueryFilter.Apply(matching, this.queryBuilder.Root);
			var list = matching.ToList();

			var counts = ContactService.QuickFilterCounts(list);
			for (var i = 0; i < this.chipGroupFilters.Items.Count; i++)
				this.chipGroupFilters.Items[i].Count = counts[(ContactQuickFilter)i];

			var filter = this.QuickFilter;
			var rows = list.Where(r => ContactService.InQuickFilter(r, filter)).ToList();

			this.dataGridView.DataSource = rows;
			this.emptyState.RefreshTarget();

			this.labelCount.Text = rows.Count == this.allRows.Count
				? this.allRows.Count + " contacts"
				: rows.Count + " of " + this.allRows.Count + " contacts";
			// the filter button shows the accent while an advanced filter is active.
			this.buttonAdvanced.CssClass = QueryFilter.IsEmpty(this.queryBuilder.Root) ? "relay-secondary" : "relay-primary";
		}

		/// <summary>
		/// Hides the optional columns that do not fit, so the grid never scrolls sideways;
		/// stops once the user picks the columns.
		/// </summary>
		private void FitColumns()
		{
			if (this.userChoseColumns)
				return;

			// room for the vertical scrollbar.
			var available = this.dataGridView.Width - 24;
			var needed = this.colName.MinimumWidth + this.colCompany.Width + this.colEmail.Width + this.colStage.Width
				+ this.colOwner.Width + this.colActions.Width;

			this.colLastContacted.Visible = needed + this.colLastContacted.Width <= available;
			this.colPhone.Visible = needed + this.colLastContacted.Width + this.colPhone.Width <= available;
		}

		private void dataGridView_Resize(object sender, EventArgs e)
		{
			FitColumns();
		}

		private ContactRow RowAt(int rowIndex)
		{
			return rowIndex >= 0 && rowIndex < this.dataGridView.RowCount
				? this.dataGridView.Rows[rowIndex].DataBoundItem as ContactRow
				: null;
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (ContactEditDialog.Edit(null))
				RefreshData();
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			ApplyFilters();
		}

		private void chipGroupFilters_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (!this.updatingFilters)
				ApplyFilters();
		}

		private void buttonAdvanced_Click(object sender, EventArgs e)
		{
			this.panelAdvanced.Visible = !this.panelAdvanced.Visible;
		}

		private void queryBuilder_QueryChanged(object sender, EventArgs e)
		{
			ApplyFilters();
		}

		private void buttonColumns_Click(object sender, EventArgs e)
		{
			this.contextMenuColumns.MenuItems.Clear();
			foreach (DataGridViewColumn column in this.dataGridView.Columns)
			{
				if (string.IsNullOrEmpty(column.HeaderText) || column == this.colName)
					continue;

				var col = column;
				var item = new MenuItem(col.HeaderText) { Checked = col.Visible };
				item.Click += (s, args) =>
				{
					this.userChoseColumns = true;
					col.Visible = !col.Visible;
					((MenuItem)s).Checked = col.Visible;
				};
				this.contextMenuColumns.MenuItems.Add(item);
			}
			this.contextMenuColumns.Show(this.buttonColumns, new Point(0, this.buttonColumns.Height));
		}

		private void buttonExport_Click(object sender, EventArgs e)
		{
			if (this.dataGridView.RowCount == 0)
			{
				Notify.Info("There are no contacts to export.");
				return;
			}
			Notify.Try(() => CsvExport.Download(this.dataGridView, "contacts.csv"), "Exporting the contacts");
		}

		private void emptyState_ActionClick(object sender, EventArgs e)
		{
			this.textBoxSearch.Text = "";
			this.queryBuilder.Root = new QueryGroup();
			SetFilterSilently(ContactQuickFilter.All);
			ApplyFilters();
		}

		private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = RowAt(e.RowIndex);
			if (row != null)
				Navigator.OpenContact(row.Id);
		}

		private void colName_AvatarClick(object sender, DataGridViewVisualCellEventArgs e)
		{
			if (e.DataBoundItem is ContactRow row)
				Navigator.OpenContact(row.Id);
		}

		private void colActions_ActionClick(object sender, DataGridViewVisualCellEventArgs e)
		{
			var row = e.DataBoundItem as ContactRow ?? RowAt(e.RowIndex);
			if (row == null || e.Action == null)
				return;

			switch (e.Action.Name)
			{
				case "call":
					if (LogActivityDialog.Show(row.Id, row.CompanyId, null, ActivityType.Call, null, "Call with " + row.FullName))
						RefreshData();
					break;

				case "email":
					if (LogActivityDialog.Show(row.Id, row.CompanyId, null, ActivityType.Email, null, "Email to " + row.FullName))
						RefreshData();
					break;

				case "edit":
					if (ContactEditDialog.Edit(row.Id))
						RefreshData();
					break;

				case "delete":
					DeleteContact(row);
					break;
			}
		}

		private void DeleteContact(ContactRow row)
		{
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
