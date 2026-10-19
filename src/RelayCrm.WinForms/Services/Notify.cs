using System;
using System.Windows.Forms;

namespace RelayCrm.Services
{
	/// <summary>
	/// Feedback to the user: short messages in the status bar of the main window, errors in a message box.
	/// </summary>
	public static class Notify
	{
		private static MainForm Shell => MainForm.Instance;

		public static void Info(string text)
		{
			Status(text, ToolTipIcon.Info);
		}

		public static void Success(string text)
		{
			Status(text, ToolTipIcon.None);
		}

		public static void Warning(string text)
		{
			// without the main window (sign-in, startup) the message must not get lost.
			if (Shell == null || !Shell.Visible)
				MessageBox.Show(text, "Relay", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			else
				Status(text, ToolTipIcon.Warning);
		}

		public static void Error(string text)
		{
			MessageBox.Show(Form.ActiveForm, text, "Relay", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				Error(what + " failed: " + ex.GetBaseException().Message);
				return false;
			}
		}

		private static void Status(string text, ToolTipIcon icon)
		{
			Shell?.ShowStatus(text, icon);
		}
	}
}
