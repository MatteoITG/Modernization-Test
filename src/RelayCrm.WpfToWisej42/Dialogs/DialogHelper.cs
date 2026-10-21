using System;
using Wisej.Web;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Shared behaviour of the dialogs: the modal display and the validation message under the fields.
	/// </summary>
	/// <remarks>
	/// Every dialog of the app uses the same modal style: a blocking <c>ShowDialog()</c> inside a <c>using</c> block.
	/// Wisej suspends the server thread until the dialog closes, so the WPF code that read <c>ShowDialog() == true</c>
	/// works unchanged; <c>using</c> disposes the dialog, which Wisej does not do when a modal dialog closes.
	/// </remarks>
	internal static class DialogHelper
	{
		/// <summary>Shows <paramref name="dialog"/> modally and disposes it; returns true when it was accepted.</summary>
		public static bool ShowModal(Form dialog)
		{
			using (dialog)
			{
				return dialog.ShowDialog() == DialogResult.OK;
			}
		}

		/// <summary>
		/// Makes the accept button (IsDefault in WPF) behave like WPF: its Click handler validates and sets
		/// DialogResult itself, so the dialog stays open when the input is wrong.
		/// </summary>
		/// <remarks>
		/// Wisej gives the AcceptButton DialogResult.OK when it is assigned and, with the
		/// "FormAutoCloseModalDialog" switch on (see Startup), that would close the dialog before the validation.
		/// Call it in the constructor after InitializeComponent.
		/// </remarks>
		public static void KeepOpenOnAccept(Form dialog)
		{
			if (dialog.AcceptButton is Button button)
				button.DialogResult = DialogResult.None;
		}

		/// <summary>Shows a validation message and moves the focus to the field to fix.</summary>
		public static void ShowError(Label label, string message, Control field = null)
		{
			label.Text = message;
			label.Visible = true;
			if (field != null)
			{
				field.Focus();
				(field as TextBox)?.SelectAll();
			}
		}

		/// <summary>Hides the validation message.</summary>
		public static void ClearError(Label label)
		{
			if (label != null)
				label.Visible = false;
		}

		/// <summary>The id of the selected item of a combo box bound to ids; null for none or 0.</summary>
		public static int? SelectedId(ComboBox combo)
		{
			var id = combo.SelectedValue is int value ? value : 0;
			return id == 0 ? (int?)null : id;
		}
	}
}
