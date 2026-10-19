using System;
using System.IO;
using System.Linq;
using System.Text;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Exports the visible columns and rows of a grid to a CSV file the browser downloads.
	/// </summary>
	public static class CsvExport
	{
		public static void Download(DataGridView grid, string fileName)
		{
			var columns = grid.Columns.Cast<DataGridViewColumn>()
				.Where(c => c.Visible && !string.IsNullOrEmpty(c.HeaderText))
				.OrderBy(c => c.DisplayIndex)
				.ToList();

			var sb = new StringBuilder();
			sb.AppendLine(string.Join(",", columns.Select(c => Escape(c.HeaderText))));
			foreach (DataGridViewRow row in grid.Rows)
			{
				if (!row.Visible)
					continue;
				sb.AppendLine(string.Join(",", columns.Select(c => Escape(FormatValue(row[c.Index].Value)))));
			}

			var bytes = Encoding.UTF8.GetPreamble().Concat(Encoding.UTF8.GetBytes(sb.ToString())).ToArray();
			Application.Download(new MemoryStream(bytes), fileName);
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
