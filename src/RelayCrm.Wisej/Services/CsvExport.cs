using System;
using System.IO;
using System.Linq;
using System.Text;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Exports the visible columns and rows of a grid to a CSV file downloaded by the browser.
	/// </summary>
	public static class CsvExport
	{
		/// <summary>Sends the file to the browser, which saves it in the downloads; returns true when it was sent.</summary>
		/// <remarks>Migration: the WinForms version wrote the file chosen with a SaveFileDialog; a web app cannot
		/// write to the user's disk, it downloads the file with Application.Download.</remarks>
		public static bool Save(DataGridView grid, string fileName)
		{
			// UTF-8 with a byte order mark, so that Excel reads the accents and the "·" right.
			var csv = ToCsv(grid);
			if (!Notify.Try(() => Application.Download(new MemoryStream(new UTF8Encoding(true).GetPreamble().Concat(Encoding.UTF8.GetBytes(csv)).ToArray()), fileName), "Exporting"))
				return false;

			Notify.Success("Exported " + (grid.Rows.Count) + " rows to " + fileName + ".");
			return true;
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
