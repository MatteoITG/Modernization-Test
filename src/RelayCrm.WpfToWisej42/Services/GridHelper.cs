using System;
using System.Drawing;
using System.Reflection;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// The converters of the XAML grid bindings, applied by the CellFormatting event of a DataGridView.
	/// </summary>
	/// <remarks>
	/// The designer stores the converter of a column in its Tag, so the XAML
	/// <c>Binding="{Binding Amount, Converter={StaticResource Fmt}, ConverterParameter=Money}"</c> becomes
	/// <c>DataPropertyName = "Amount"</c> and <c>Tag = "Fmt:Money"</c>. Tag values, separated by ';':
	/// <list type="bullet">
	/// <item><c>Fmt:Money</c> formats the value with <see cref="FmtConverter"/> (Money, MoneyShort, Date, DateTime, Relative, Percent).</item>
	/// <item><c>Tone</c> or <c>Tone:Stage</c> colours the text by the cell value with <see cref="ToneBrushConverter"/>.</item>
	/// <item><c>ToneOf:CloseTone</c> or <c>ToneOf:Status:TaskStatus</c> colours the text by another property of the row.</item>
	/// <item><c>Bold</c> shows the text in bold (FontWeight="SemiBold").</item>
	/// </list>
	/// </remarks>
	public static class GridHelper
	{
		/// <summary>Applies the converters named by the Tag of the columns of <paramref name="grid"/>.</summary>
		public static void UseConverters(DataGridView grid)
		{
			grid.CellFormatting -= Grid_CellFormatting;
			grid.CellFormatting += Grid_CellFormatting;
		}

		private static void Grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var grid = (DataGridView)sender;
			if (e.RowIndex < 0 || e.ColumnIndex < 0)
				return;

			var tag = grid.Columns[e.ColumnIndex].Tag as string;
			if (string.IsNullOrEmpty(tag))
				return;

			var row = grid.Rows[e.RowIndex].DataBoundItem;
			foreach (var part in tag.Split(';'))
			{
				var args = part.Trim().Split(':');
				switch (args[0])
				{
					case "Fmt":
						e.Value = FmtConverter.Convert(e.Value, args.Length > 1 ? args[1] : null);
						e.FormattingApplied = true;
						break;

					case "Tone":
						e.CellStyle.ForeColor = ToneBrushConverter.Convert(e.Value, args.Length > 1 ? args[1] : null);
						break;

					case "ToneOf":
						if (row != null && args.Length > 1)
							e.CellStyle.ForeColor = ToneBrushConverter.Convert(ValueOf(row, args[1]), args.Length > 2 ? args[2] : null);
						break;

					case "Bold":
						e.CellStyle.Font = new Font(grid.Font, FontStyle.Bold);
						break;
				}
			}
		}

		/// <summary>
		/// Shows the empty state over an empty list (step 2: the Wisej EmptyState control); its action button clears the filters.
		/// </summary>
		/// <param name="empty">The empty state.</param>
		/// <param name="visible">True when the list is empty.</param>
		/// <param name="text">The title.</param>
		/// <param name="actionText">The caption of the action button, or null for a list that is empty without filters.</param>
		public static void ShowEmpty(EmptyState empty, bool visible, string text, string actionText)
		{
			empty.Visible = visible;
			if (!visible)
				return;

			empty.Title = text;
			empty.ActionText = actionText;
			empty.Kind = actionText == null ? EmptyStateKind.Empty : EmptyStateKind.NoResults;
			empty.BringToFront();
		}

		/// <summary>The value of a property of a row; null when there is no such property.</summary>
		public static object ValueOf(object row, string path)
		{
			object value = row;
			foreach (var name in path.Split('.'))
			{
				if (value == null)
					return null;
				var prop = value.GetType().GetProperty(name, BindingFlags.Public | BindingFlags.Instance);
				value = prop?.GetValue(value);
			}
			return value;
		}
	}
}
