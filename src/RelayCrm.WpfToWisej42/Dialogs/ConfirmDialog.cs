using System;
using Wisej.Web;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Asks the user to confirm an action ("Delete contact?") with a standard message box.
	/// </summary>
	public static class ConfirmDialog
	{
		/// <summary>
		/// Shows the question and returns true when the user answers Yes.
		/// </summary>
		/// <param name="title">Caption of the message box.</param>
		/// <param name="message">The question.</param>
		/// <param name="confirmText">The action, e.g. "Delete": named in the question since message box buttons are fixed.</param>
		public static bool Ask(string title, string message, string confirmText = "Confirm")
		{
			var text = message + "\n\nChoose Yes to " + (confirmText ?? "Confirm").ToLowerInvariant() + ".";

			// a blocking modal message box, like every dialog of the app (see DialogHelper).
			var answer = MessageBox.Show(text, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
			return answer == DialogResult.Yes;
		}
	}
}
