using System;
using System.Windows;
using System.Windows.Controls;
using RelayCrm.Data;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Invites a user: creates the user with a name, an email and a role.
	/// </summary>
	public partial class InviteUserDialog : Window
	{
		public InviteUserDialog()
		{
			InitializeComponent();

			this.comboBoxRole.ItemsSource = Enum.GetValues(typeof(UserRole));
			this.comboBoxRole.SelectedItem = UserRole.Sales;
			this.Loaded += (s, e) => this.textBoxName.Focus();
		}

		/// <summary>
		/// Shows the dialog; returns true when a user was created.
		/// </summary>
		public static bool Invite()
		{
			return DialogHelper.ShowModal(new InviteUserDialog());
		}

		private UserRole SelectedRole => this.comboBoxRole.SelectedItem is UserRole role ? role : UserRole.Sales;

		private void textBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			DialogHelper.ClearError(this.labelError);
		}

		private void buttonInvite_Click(object sender, RoutedEventArgs e)
		{
			var name = this.textBoxName.Text.Trim();
			if (name.Length == 0)
			{
				DialogHelper.ShowError(this.labelError, "Enter a name.", this.textBoxName);
				return;
			}

			string emailError = null;
			if (!Notify.Try(() => emailError = SettingsService.ValidateEmail(this.textBoxEmail.Text), "Checking the email"))
				return;
			if (emailError != null)
			{
				DialogHelper.ShowError(this.labelError, emailError, this.textBoxEmail);
				return;
			}

			if (Notify.Try(() => SettingsService.InviteUser(name, this.textBoxEmail.Text.Trim(), this.SelectedRole), "Inviting the user"))
			{
				Notify.Success(name + " was invited as " + this.SelectedRole + ".");
				this.DialogResult = true;
			}
		}
	}
}
