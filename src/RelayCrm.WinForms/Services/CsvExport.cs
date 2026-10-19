using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RelayCrm.Services
{
	/// <summary>
	/// Exports the visible columns and rows of a grid to a CSV file chosen with the Save dialog.
	/// </summary>
	public static class CsvExport
	{
		/// <summary>Asks where to save and writes the file; returns true when it was written.</summary>
		public static bool Save(DataGridView grid, string fileName)
		{
			using (var dialog = new SaveFileDialog())
			{
				dialog.Title = "Export to CSV";
				dialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
				dialog.FileName = fileName;
				dialog.OverwritePrompt = true;
				if (dialog.ShowDialog(grid.FindForm()) != DialogResult.OK)
					return false;

				// UTF-8 with a byte order mark, so that Excel reads the accents and the "·" right.
				var csv = ToCsv(grid);
				if (!Notify.Try(() => File.WriteAllText(dialog.FileName, csv, new UTF8Encoding(true)), "Exporting"))
					return false;

				Notify.Success("Exported " + (grid.Rows.Count) + " rows to " + Path.GetFileName(dialog.FileName) + ".");
				return true;
			}
		}

		/// <summary>The visible columns and rows of <paramref name="grid"/> as CSV text.</summary>
		public static string ToCsv(DataGridView grid)
		{
			var columns = grid.Columns.Cast<DataGridViewColumn>()
				.Where(c => c.Visible && !string.IsNullOrEmpty(c.HeaderText) && !(c is DataGridViewButtonColumn))
				.OrderBy(c => c.DisplayIndex)
				.ToList();

			var sb = new StringBuilder();
			sb.AppendLine(string.Join(",", columns.Select(c => Escape(c.HeaderText))));
			foreach (DataGridViewRow row in grid.Rows)
			{
				if (!row.Visible || row.IsNewRow)
					continue;
				sb.AppendLine(string.Join(",", columns.Select(c => Escape(FormatValue(row.Cells[c.Index].Value)))));
			}
			return sb.ToString();
		}

		private static string FormatValue(object value)
		{
			switch (value)
			{
				case null: return "";
				case DateTime d: return d.ToString("yyyy-MM-dd");
				case double[] values: return string.Join(" ", values.Select(v => v.ToString(Fmt.Culture)));
				case IFormattable f: return f.ToString(null, Fmt.Culture);
				default: return value.ToString();
			}
		}

		private static string Escape(string text)
		{
			text = text ?? "";
			return text.IndexOfAny(new[] { ',', '"', '\n', '\r' }) >= 0
				? "\"" + text.Replace("\"", "\"\"") + "\""
				: text;
		}
	}
}
