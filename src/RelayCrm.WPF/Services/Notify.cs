using System;
using System.Linq;
using System.Windows;

namespace RelayCrm.Services
{
	/// <summary>The kind of a status bar message.</summary>
	public enum StatusKind { None, Info, Warning }

	/// <summary>
	/// Feedback to the user: short messages in the status bar of the main window, errors in a message box.
	/// </summary>
	public static class Notify
	{
		private static MainWindow Shell => MainWindow.Instance;

		public static void Info(string text)
		{
			Status(text, StatusKind.Info);
		}

		public static void Success(string text)
		{
			Status(text, StatusKind.None);
		}

		public static void Warning(string text)
		{
			// without the main window (sign-in, startup) the message must not get lost.
			if (Shell == null || !Shell.IsVisible)
				Show(text, MessageBoxImage.Warning);
			else
				Status(text, StatusKind.Warning);
		}

		public static void Error(string text)
		{
			Show(text, MessageBoxImage.Error);
		}

		/// <summary>
		/// Runs a data operation and shows an error message instead of crashing when it fails.
		/// </summary>
		public static bool Try(Action action, string what = "The operation")
		{
			try
			{
				action();
				return true;
			}
			catch (Exception ex)
			{
				App.LogError(what, ex);
				Error(what + " failed: " + ex.GetBaseException().Message);
				return false;
			}
		}

		/// <summary>The window that owns new dialogs and message boxes: the active one, else the main window.</summary>
		public static Window ActiveWindow
		{
			get
			{
				var app = Application.Current;
				if (app == null)
					return null;
				var active = app.Windows.OfType<Window>().FirstOrDefault(w => w.IsActive && w.IsVisible);
				if (active != null)
					return active;
				return app.MainWindow != null && app.MainWindow.IsVisible ? app.MainWindow : null;
			}
		}

		private static void Show(string text, MessageBoxImage image)
		{
			var owner = ActiveWindow;
			if (owner != null)
				MessageBox.Show(owner, text, "Relay", MessageBoxButton.OK, image);
			else
				MessageBox.Show(text, "Relay", MessageBoxButton.OK, image);
		}

		private static void Status(string text, StatusKind kind)
		{
			Shell?.ShowStatus(text, kind);
		}
	}
}
