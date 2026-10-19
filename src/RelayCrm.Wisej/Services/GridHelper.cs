using System;
using Wisej.Web;

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
		public static void FillColumnMenu(ToolBarButton dropDown, DataGridView grid, DataGridViewColumn fixedColumn)
		{
			dropDown.DropDownMenu.MenuItems.Clear();
			foreach (DataGridViewColumn column in grid.Columns)
			{
				if (column == fixedColumn || string.IsNullOrEmpty(column.HeaderText))
					continue;

				var col = column;
				var item = new MenuItem(col.HeaderText) { Checked = col.Visible };
				item.Click += (s, e) => col.Visible = item.Checked = !item.Checked;
				dropDown.DropDownMenu.MenuItems.Add(item);
			}
		}

		/// <summary>
		/// Makes the row under a right click the current row, so that the context menu acts on it.
		/// </summary>
		public static void SelectOnRightClick(DataGridView grid, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right || e.RowIndex < 0)
				return;

			var column = e.ColumnIndex >= 0 ? e.ColumnIndex : grid.FirstDisplayedColumnIndex;
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
		/// Shows the empty state over an empty grid; its action button clears the filters.
		/// </summary>
		public static void ShowEmpty(EmptyState empty, bool visible, string text, string actionText)
		{
			empty.Visible = visible;
			if (!visible)
				return;

			empty.Title = text;
			empty.ActionText = actionText;
			empty.Kind = actionText == null ? EmptyStateKind.Empty : EmptyStateKind.NoResults;
		}
	}
}
