using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Exports the visible columns of a grid to a CSV file that the browser downloads.
	/// </summary>
	/// <remarks>
	/// The WPF version asked where to save with the SaveFileDialog. A Wisej app runs on the server, so the file is
	/// written to a stream and sent with Application.Download: the browser saves it in the user's download folder.
	/// The value of a column is read through its DataPropertyName (the binding path of the XAML column).
	/// </remarks>
	public static class CsvExport
	{
		/// <summary>Writes the file and sends it to the browser; returns true when it was sent.</summary>
		/// <param name="grid">The grid whose visible columns are exported.</param>
		/// <param name="fileName">Proposed file name.</param>
		/// <param name="items">The rows to export; null exports the rows of the grid.</param>
		public static bool Save(DataGridView grid, string fileName, IEnumerable items = null)
		{
			var rows = (items ?? grid.Rows.Cast<DataGridViewRow>().Select(r => r.DataBoundItem)).Cast<object>().ToList();
			if (rows.Count == 0)
			{
				Notify.Info("There is nothing to export.");
				return false;
			}

			// UTF-8 with a byte order mark, so that Excel reads the accents and the "·" right.
			var csv = ToCsv(grid, rows);
			if (!Notify.Try(() =>
			{
				var stream = new MemoryStream(new UTF8Encoding(true).GetPreamble().Concat(Encoding.UTF8.GetBytes(csv)).ToArray());
				Application.Download(stream, fileName);
			}, "Exporting"))
				return false;

			Notify.Success("Exported " + rows.Count + " rows to " + fileName + ".");
			return true;
		}

		/// <summary>The visible columns of <paramref name="grid"/> and the given rows as CSV text.</summary>
		public static string ToCsv(DataGridView grid, IEnumerable rows)
		{
			var columns = grid.Columns.Cast<DataGridViewColumn>()
				.Where(c => c.Visible && !string.IsNullOrEmpty(c.HeaderText) && PathOf(c) != null)
				.OrderBy(c => c.DisplayIndex)
				.ToList();

			var sb = new StringBuilder();
			sb.AppendLine(string.Join(",", columns.Select(c => Escape(c.HeaderText))));
			foreach (var row in rows)
				sb.AppendLine(string.Join(",", columns.Select(c => Escape(FormatValue(GridHelper.ValueOf(row, PathOf(c)))))));
			return sb.ToString();
		}

		private static string PathOf(DataGridViewColumn column)
		{
			return string.IsNullOrEmpty(column.DataPropertyName) ? null : column.DataPropertyName;
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
