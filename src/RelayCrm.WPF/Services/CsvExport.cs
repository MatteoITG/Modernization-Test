using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.Win32;

namespace RelayCrm.Services
{
	/// <summary>
	/// Exports the visible columns of a grid to a CSV file chosen with the Save dialog.
	/// </summary>
	/// <remarks>
	/// The value of a bound column is read through its binding path; template columns use their SortMemberPath.
	/// </remarks>
	public static class CsvExport
	{
		/// <summary>Asks where to save and writes the file; returns true when it was written.</summary>
		/// <param name="grid">The grid whose visible columns are exported.</param>
		/// <param name="fileName">Proposed file name.</param>
		/// <param name="items">The rows to export; null exports the rows of the grid.</param>
		public static bool Save(DataGrid grid, string fileName, IEnumerable items = null)
		{
			var rows = (items ?? grid.Items).Cast<object>().ToList();
			if (rows.Count == 0)
			{
				Notify.Info("There is nothing to export.");
				return false;
			}

			var dialog = new SaveFileDialog
			{
				Title = "Export to CSV",
				Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
				FileName = fileName,
				OverwritePrompt = true,
			};
			var owner = Window.GetWindow(grid);
			if ((owner != null ? dialog.ShowDialog(owner) : dialog.ShowDialog()) != true)
				return false;

			// UTF-8 with a byte order mark, so that Excel reads the accents and the "·" right.
			var csv = ToCsv(grid, rows);
			if (!Notify.Try(() => File.WriteAllText(dialog.FileName, csv, new UTF8Encoding(true)), "Exporting"))
				return false;

			Notify.Success("Exported " + rows.Count + " rows to " + Path.GetFileName(dialog.FileName) + ".");
			return true;
		}

		/// <summary>The visible columns of <paramref name="grid"/> and the given rows as CSV text.</summary>
		public static string ToCsv(DataGrid grid, IEnumerable rows)
		{
			var columns = grid.Columns
				.Where(c => c.Visibility == Visibility.Visible && !string.IsNullOrEmpty(Convert.ToString(c.Header)) && PathOf(c) != null)
				.OrderBy(c => c.DisplayIndex)
				.ToList();

			var sb = new StringBuilder();
			sb.AppendLine(string.Join(",", columns.Select(c => Escape(Convert.ToString(c.Header)))));
			foreach (var row in rows)
				sb.AppendLine(string.Join(",", columns.Select(c => Escape(FormatValue(ValueOf(row, PathOf(c)))))));
			return sb.ToString();
		}

		private static string PathOf(DataGridColumn column)
		{
			if (column is DataGridBoundColumn bound && bound.Binding is Binding binding && binding.Path != null)
				return binding.Path.Path;
			return string.IsNullOrEmpty(column.SortMemberPath) ? null : column.SortMemberPath;
		}

		private static object ValueOf(object row, string path)
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
