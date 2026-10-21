using System;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Small helpers for the standard Wisej controls.
	/// </summary>
	/// <remarks>
	/// BubbleMouseWheel of the WPF version is gone: the browser scrolls the page under a grid by itself.
	/// </remarks>
	public static class UiHelper
	{
		/// <summary>The data item of the row of a cell event, or null for a click on the header.</summary>
		public static T RowItem<T>(DataGridView grid, DataGridViewCellEventArgs e) where T : class
		{
			if (e == null || e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count)
				return null;
			return grid.Rows[e.RowIndex].DataBoundItem as T;
		}

		/// <summary>The data item of the selected row, or null.</summary>
		public static T SelectedItem<T>(DataGridView grid) where T : class
		{
			return grid.CurrentRow?.DataBoundItem as T;
		}

		/// <summary>The data item behind the selected entry of a list box filled with <see cref="TemplateItem"/>s.</summary>
		public static T SelectedItem<T>(ListBox list) where T : class
		{
			var item = list.SelectedItem;
			return (item as TemplateItem)?.Data as T ?? item as T;
		}

		/// <summary>Opens a web site in a new browser tab (Process.Start would run on the server).</summary>
		public static void OpenUrl(string url)
		{
			if (string.IsNullOrWhiteSpace(url))
				return;
			if (!url.Contains("://"))
				url = "https://" + url.Trim();
			Notify.Try(() => Application.Navigate(url, "_blank"), "Opening the web site");
		}
	}
}
