using System;
using System.Windows.Forms;

namespace RelayCrm.Services
{
	/// <summary>
	/// Small helpers shared by the grids of the lists: the column chooser, the row under a right click
	/// and the record of the current row.
	/// </summary>
	public static class GridHelper
	{
		/// <summary>
		/// Fills <paramref name="dropDown"/> with one checked item per column; clicking an item shows or hides the column.
		/// </summary>
		/// <param name="dropDown">The "Columns" drop-down button.</param>
		/// <param name="grid">The grid.</param>
		/// <param name="fixedColumn">A column that cannot be hidden (the name), or null.</param>
		public static void FillColumnMenu(ToolStripDropDownItem dropDown, DataGridView grid, DataGridViewColumn fixedColumn)
		{
			dropDown.DropDownItems.Clear();
			foreach (DataGridViewColumn column in grid.Columns)
			{
				if (column == fixedColumn || string.IsNullOrEmpty(column.HeaderText))
					continue;

				var col = column;
				var item = new ToolStripMenuItem(col.HeaderText) { Checked = col.Visible, CheckOnClick = true };
				item.CheckedChanged += (s, e) => col.Visible = ((ToolStripMenuItem)s).Checked;
				dropDown.DropDownItems.Add(item);
			}
		}

		/// <summary>
		/// Makes the row under a right click the current row, so that the context menu acts on it.
		/// </summary>
		public static void SelectOnRightClick(DataGridView grid, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right || e.RowIndex < 0)
				return;

			var column = e.ColumnIndex >= 0 ? e.ColumnIndex : grid.FirstDisplayedScrollingColumnIndex;
			if (column < 0 || !grid.Columns[column].Visible)
				return;

			grid.ClearSelection();
			grid.CurrentCell = grid.Rows[e.RowIndex].Cells[column];
			grid.Rows[e.RowIndex].Selected = true;
		}

		/// <summary>The record of the current row, or null.</summary>
		public static T Current<T>(DataGridView grid) where T : class
		{
			return grid.CurrentRow?.DataBoundItem as T;
		}

		/// <summary>The record of row <paramref name="rowIndex"/>, or null for the header row.</summary>
		public static T RowAt<T>(DataGridView grid, int rowIndex) where T : class
		{
			return rowIndex >= 0 && rowIndex < grid.Rows.Count ? grid.Rows[rowIndex].DataBoundItem as T : null;
		}

		/// <summary>
		/// Shows the "nothing found" link over an empty grid; the link part clears the filters.
		/// </summary>
		public static void ShowEmpty(LinkLabel label, bool visible, string text, string linkText)
		{
			label.Visible = visible;
			if (!visible)
				return;

			label.Text = linkText == null ? text : text + " " + linkText;
			label.LinkArea = linkText == null ? new LinkArea(0, 0) : new LinkArea(text.Length + 1, linkText.Length);
		}
	}
}
