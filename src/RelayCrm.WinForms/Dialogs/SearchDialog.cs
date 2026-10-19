using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Global search (Ctrl+K): pages, contacts, companies and deals as you type.
	/// </summary>
	public partial class SearchDialog : Form
	{
		public SearchDialog()
		{
			InitializeComponent();

			this.listViewResults.SmallImageList = IconImages.List(16,
				SearchService.Pages.Select(p => p.Icon).Concat(new[] { "person", "building", "briefcase" }).Distinct().ToArray());
		}

		/// <summary>The text searched when the dialog opens.</summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string Query
		{
			get { return this.textBoxQuery.Text; }
			set { this.textBoxQuery.Text = value ?? ""; }
		}

		/// <summary>The chosen result, when the dialog returns OK.</summary>
		public SearchResult Result { get; private set; }

		private void SearchDialog_Load(object sender, EventArgs e)
		{
			RunSearch();
			this.textBoxQuery.SelectionStart = this.textBoxQuery.Text.Length;
		}

		private void RunSearch()
		{
			this.timerSearch.Stop();

			List<SearchResult> results = null;
			if (!Notify.Try(() => results = SearchService.Search(this.textBoxQuery.Text, 40), "Searching"))
				return;

			this.listViewResults.BeginUpdate();
			this.listViewResults.Items.Clear();
			foreach (var result in results)
			{
				var group = this.listViewResults.Groups[GroupName(result.Kind)];
				var item = new ListViewItem(result.Text, Icons.NameOf(result.Icon), group) { Tag = result };
				item.SubItems.Add(result.Description);
				this.listViewResults.Items.Add(item);
			}
			this.listViewResults.EndUpdate();

			if (this.listViewResults.Items.Count > 0)
			{
				// the first record when there is one, otherwise the first page.
				var first = this.listViewResults.Items.Cast<ListViewItem>().FirstOrDefault(i => ((SearchResult)i.Tag).Kind != SearchKind.Page)
					?? this.listViewResults.Items[0];
				first.Selected = true;
				first.Focused = true;
				first.EnsureVisible();
			}

			var query = this.textBoxQuery.Text.Trim();
			this.labelHint.Text = query.Length == 1
				? "Type at least 2 characters to search contacts, companies and deals."
				: results.Count == 0 ? "Nothing found for \"" + query + "\"." : "Enter opens the selected result.";
			this.buttonOpen.Enabled = this.listViewResults.SelectedItems.Count > 0;
		}

		private static string GroupName(SearchKind kind)
		{
			switch (kind)
			{
				case SearchKind.Contact: return "groupContacts";
				case SearchKind.Company: return "groupCompanies";
				case SearchKind.Deal: return "groupDeals";
				default: return "groupPages";
			}
		}

		private void OpenSelected()
		{
			if (this.listViewResults.SelectedItems.Count == 0)
				return;

			this.Result = (SearchResult)this.listViewResults.SelectedItems[0].Tag;
			this.DialogResult = DialogResult.OK;
		}

		private void textBoxQuery_TextChanged(object sender, EventArgs e)
		{
			// search when the user pauses typing.
			this.timerSearch.Stop();
			this.timerSearch.Start();
		}

		private void timerSearch_Tick(object sender, EventArgs e)
		{
			RunSearch();
		}

		private void textBoxQuery_KeyDown(object sender, KeyEventArgs e)
		{
			// the arrows move through the results while the cursor stays in the text box.
			var count = this.listViewResults.Items.Count;
			if (count == 0 || (e.KeyCode != Keys.Down && e.KeyCode != Keys.Up))
				return;

			var index = this.listViewResults.SelectedIndices.Count > 0 ? this.listViewResults.SelectedIndices[0] : -1;
			index = Math.Max(0, Math.Min(count - 1, index + (e.KeyCode == Keys.Down ? 1 : -1)));
			this.listViewResults.SelectedItems.Clear();
			this.listViewResults.Items[index].Selected = true;
			this.listViewResults.Items[index].EnsureVisible();
			e.Handled = e.SuppressKeyPress = true;
		}

		private void listViewResults_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.buttonOpen.Enabled = this.listViewResults.SelectedItems.Count > 0;
		}

		private void listViewResults_ItemActivate(object sender, EventArgs e)
		{
			OpenSelected();
		}

		private void buttonOpen_Click(object sender, EventArgs e)
		{
			if (this.timerSearch.Enabled)
				RunSearch();
			OpenSelected();
		}
	}
}
