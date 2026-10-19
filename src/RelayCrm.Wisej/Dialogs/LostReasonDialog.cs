using System;
using Wisej.Web;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Asks why a deal was lost, when it is dropped on the Lost stage or saved in it.
	/// </summary>
	public partial class LostReasonDialog : Form
	{
		/// <summary>Common reasons offered in the list; any other text can be typed.</summary>
		public static readonly string[] CommonReasons =
		{
			"Price too high",
			"Chose a competitor",
			"No budget",
			"No decision / went silent",
			"Bad timing",
			"Missing features",
		};

		public LostReasonDialog()
		{
			InitializeComponent();

			this.comboBoxReason.Items.AddRange(CommonReasons);
		}

		/// <summary>
		/// Asks the lost reason of a deal; returns the reason, or null when cancelled.
		/// </summary>
		/// <param name="dealTitle">Title of the deal, shown in the question.</param>
		public static string Ask(string dealTitle)
		{
			using (var dialog = new LostReasonDialog())
			{
				dialog.labelMessage.Text = "Why was \"" + dealTitle + "\" lost?";
				return dialog.ShowDialog(Form.ActiveForm) == DialogResult.OK ? dialog.comboBoxReason.Text.Trim() : null;
			}
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (this.comboBoxReason.Text.Trim().Length == 0)
			{
				this.errorProvider.SetError(this.comboBoxReason, "Enter or pick a reason.");
				this.comboBoxReason.Focus();
				return;
			}

			this.DialogResult = DialogResult.OK;
		}

		private void comboBoxReason_TextChanged(object sender, EventArgs e)
		{
			this.errorProvider.SetError(this.comboBoxReason, "");
		}
	}
}
