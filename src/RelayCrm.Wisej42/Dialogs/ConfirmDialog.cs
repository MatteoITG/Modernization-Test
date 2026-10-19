using System;
using Wisej.Web;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Asks the user to confirm an action ("Delete contact?").
	/// </summary>
	public partial class ConfirmDialog : Form
	{
		public ConfirmDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Shows the dialog and returns true when the user confirms.
		/// </summary>
		public static bool Ask(string title, string message, string confirmText = "Confirm")
		{
			using (var dialog = new ConfirmDialog())
			{
				dialog.Text = title;
				dialog.labelMessage.Text = message;
				dialog.buttonOk.Text = confirmText;
				return dialog.ShowDialog() == DialogResult.OK;
			}
		}
	}
}
