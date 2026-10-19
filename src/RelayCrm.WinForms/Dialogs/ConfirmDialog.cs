using System;
using System.Drawing;
using System.Windows.Forms;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Asks the user to confirm an action ("Delete contact?"), with the action as the button text.
	/// </summary>
	public partial class ConfirmDialog : Form
	{
		public ConfirmDialog()
		{
			InitializeComponent();

			this.pictureIcon.Image = SystemIcons.Warning.ToBitmap();
		}

		/// <summary>
		/// Shows the dialog and returns true when the user confirms.
		/// </summary>
		public static bool Ask(string title, string message, string confirmText = "OK")
		{
			using (var dialog = new ConfirmDialog())
			{
				dialog.Text = title;
				dialog.labelMessage.Text = message;
				dialog.buttonOk.Text = confirmText;
				return dialog.ShowDialog(Form.ActiveForm) == DialogResult.OK;
			}
		}
	}
}
