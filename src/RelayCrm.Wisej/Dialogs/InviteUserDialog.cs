using System;
using Wisej.Web;
using RelayCrm.Data;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Invites a user: creates the user with a name, an email and a role.
	/// </summary>
	public partial class InviteUserDialog : Form
	{
		public InviteUserDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Shows the dialog; returns true when a user was created.
		/// </summary>
		public static new bool Show()
		{
			using (var dialog = new InviteUserDialog())
			{
				dialog.comboBoxRole.SelectedIndex = (int)UserRole.Sales;
				return dialog.ShowDialog(Form.ActiveForm) == DialogResult.OK;
			}
		}

		private UserRole SelectedRole => (UserRole)Math.Max(0, this.comboBoxRole.SelectedIndex);

		private bool ValidateInput()
		{
			Control first = null;

			if (this.textBoxName.Text.Trim().Length == 0)
			{
				this.errorProvider.SetError(this.textBoxName, "Enter a name.");
				first = this.textBoxName;
			}

			string emailError = null;
			if (!Notify.Try(() => emailError = SettingsService.ValidateEmail(this.textBoxEmail.Text), "Checking the email"))
				return false;
			if (emailError != null)
			{
				this.errorProvider.SetError(this.textBoxEmail, emailError);
				first = first ?? this.textBoxEmail;
			}

			first?.Focus();
			return first == null;
		}

		private void buttonInvite_Click(object sender, EventArgs e)
		{
			if (!ValidateInput())
				return;

			var name = this.textBoxName.Text.Trim();
			if (Notify.Try(() => SettingsService.InviteUser(name, this.textBoxEmail.Text.Trim(), this.SelectedRole), "Inviting the user"))
			{
				Notify.Success(name + " was invited as " + this.SelectedRole + ".");
				this.DialogResult = DialogResult.OK;
			}
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			this.errorProvider.SetError((Control)sender, "");
		}
	}
}
