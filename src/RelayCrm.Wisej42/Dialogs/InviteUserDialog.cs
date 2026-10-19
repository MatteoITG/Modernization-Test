using System;
using RelayCrm.Data;
using RelayCrm.Services;
using Wisej.Web;

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
				return dialog.ShowDialog() == DialogResult.OK;
			}
		}

		private UserRole SelectedRole => (UserRole)Math.Max(0, this.comboBoxRole.SelectedIndex);

		private bool ValidateInput()
		{
			var valid = true;

			if (this.textBoxName.Text.Trim().Length == 0)
			{
				this.textBoxName.InvalidMessage = "Enter a name.";
				this.textBoxName.Invalid = true;
				valid = false;
			}

			string emailError = null;
			if (!Notify.Try(() => emailError = SettingsService.ValidateEmail(this.textBoxEmail.Text), "Checking the email"))
				return false;
			if (emailError != null)
			{
				this.textBoxEmail.InvalidMessage = emailError;
				this.textBoxEmail.Invalid = true;
				valid = false;
			}

			if (!valid)
			{
				if (this.textBoxName.Invalid)
					this.textBoxName.Focus();
				else
					this.textBoxEmail.Focus();
			}
			return valid;
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

		private void textBoxName_TextChanged(object sender, EventArgs e)
		{
			this.textBoxName.Invalid = false;
		}

		private void textBoxEmail_TextChanged(object sender, EventArgs e)
		{
			this.textBoxEmail.Invalid = false;
		}
	}
}
