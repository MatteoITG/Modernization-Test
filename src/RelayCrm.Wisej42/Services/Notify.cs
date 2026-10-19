using System;
using System.Drawing;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Toast notifications in the top right corner.
	/// </summary>
	public static class Notify
	{
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
			AlertBox.Show(text, MessageBoxIcon.Warning, alignment: ContentAlignment.TopRight, autoCloseDelay: 6000);
		}

		public static void Error(string text)
		{
			AlertBox.Show(text, MessageBoxIcon.Error, alignment: ContentAlignment.TopRight, autoCloseDelay: 8000);
		}

		/// <summary>
		/// Runs a data operation and shows an error toast instead of crashing when it fails.
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
	}
}
