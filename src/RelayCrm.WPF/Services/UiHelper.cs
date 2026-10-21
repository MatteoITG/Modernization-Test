using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace RelayCrm.Services
{
	/// <summary>
	/// Small helpers for the standard WPF controls.
	/// </summary>
	public static class UiHelper
	{
		/// <summary>
		/// Passes the mouse wheel of a grid that shows all its rows to the scroll viewer of the page,
		/// so the page scrolls when the pointer is over the grid.
		/// </summary>
		public static void BubbleMouseWheel(UIElement element)
		{
			element.PreviewMouseWheel += (s, e) =>
			{
				if (e.Handled)
					return;

				e.Handled = true;
				var parent = VisualTreeHelper.GetParent((DependencyObject)s) as UIElement;
				parent?.RaiseEvent(new MouseWheelEventArgs(e.MouseDevice, e.Timestamp, e.Delta)
				{
					RoutedEvent = UIElement.MouseWheelEvent,
					Source = s,
				});
			};
		}

		/// <summary>The data item of the row under a double click, or null for a click on the header or the empty area.</summary>
		public static T RowItem<T>(MouseButtonEventArgs e) where T : class
		{
			var source = e.OriginalSource as DependencyObject;
			while (source != null && !(source is DataGridRow) && !(source is ListBoxItem))
			{
				if (source is DataGridColumnHeader || source is ScrollBar)
					return null;
				source = source is Visual || source is System.Windows.Media.Media3D.Visual3D
					? VisualTreeHelper.GetParent(source)
					: LogicalTreeHelper.GetParent(source);
			}
			return (source as FrameworkElement)?.DataContext as T;
		}

		/// <summary>Opens a web site in the default browser.</summary>
		public static void OpenUrl(string url)
		{
			if (string.IsNullOrWhiteSpace(url))
				return;
			if (!url.Contains("://"))
				url = "https://" + url.Trim();
			Notify.Try(() => System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(url) { UseShellExecute = true }), "Opening the web site");
		}
	}
}
