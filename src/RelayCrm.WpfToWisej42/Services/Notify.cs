using System;
using System.Drawing;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Feedback to the user: toast notifications in the top right corner (Wisej AlertBox).
	/// </summary>
	/// <remarks>
	/// The WPF version wrote short messages in the status bar and showed errors in a message box. Step 1 kept the
	/// status bar and added a toast. Step 2 removed the status bar, so the "Alert Boxes" optimization of the guide
	/// shows every message as a non-blocking toast. Without the main page (sign-in, startup) warnings and errors
	/// are still message boxes, so they do not get lost behind the modal sign-in dialog.
	/// </remarks>
	public static class Notify
	{
		private static bool HasShell => MainWindow.Instance != null && MainWindow.Instance.Visible;

		public static void Info(string text)
		{
			AlertBox.Show(text, MessageBoxIcon.Information, alignment: ContentAlignment.TopRight, autoCloseDelay: 4000);
		}

		public static void Success(string text)
		{
			AlertBox.Show(text, MessageBoxIcon.None, alignment: ContentAlignment.TopRight, autoCloseDelay: 4000);
		}

		public static void Warning(string text)
		{
			if (HasShell)
				AlertBox.Show(text, MessageBoxIcon.Warning, alignment: ContentAlignment.TopRight, autoCloseDelay: 6000);
			else
				Show(text, MessageBoxIcon.Warning);
		}

		public static void Error(string text)
		{
			if (HasShell)
				AlertBox.Show(text, MessageBoxIcon.Error, alignment: ContentAlignment.TopRight, autoCloseDelay: 8000);
			else
				Show(text, MessageBoxIcon.Error);
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

		private static void Show(string text, MessageBoxIcon icon)
		{
			// Wisej message boxes are modal to the browser page: there is no owner window to look for.
			MessageBox.Show(text, "Relay", MessageBoxButtons.OK, icon);
		}
	}
}
