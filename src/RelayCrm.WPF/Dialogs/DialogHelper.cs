using System;
using System.Windows;
using System.Windows.Controls;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Shared behaviour of the dialogs: the owner window and the validation message under the fields.
	/// </summary>
	internal static class DialogHelper
	{
		/// <summary>Shows <paramref name="dialog"/> modally over the active window; returns true when it was accepted.</summary>
		public static bool ShowModal(Window dialog)
		{
			var owner = Notify.ActiveWindow;
			if (owner != null && owner != dialog)
				dialog.Owner = owner;
			else
				dialog.WindowStartupLocation = WindowStartupLocation.CenterScreen;
			return dialog.ShowDialog() == true;
		}

		/// <summary>Shows a validation message and moves the focus to the field to fix.</summary>
		public static void ShowError(TextBlock label, string message, Control field = null)
		{
			label.Text = message;
			label.Visibility = Visibility.Visible;
			if (field != null)
			{
				field.Focus();
				(field as TextBox)?.SelectAll();
			}
		}

		/// <summary>Hides the validation message.</summary>
		public static void ClearError(TextBlock label)
		{
			if (label != null)
				label.Visibility = Visibility.Collapsed;
		}

		/// <summary>The id of the selected item of a combo box bound to ids; null for none or 0.</summary>
		public static int? SelectedId(ComboBox combo)
		{
			var id = combo.SelectedValue is int value ? value : 0;
			return id == 0 ? (int?)null : id;
		}
	}
}
