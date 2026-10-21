using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Development sign-in: picks one of the seeded users, without a password.
	/// There is no real authentication provider.
	/// </summary>
	public partial class SignInDialog : Window
	{
		public SignInDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Signs a user in; returns false when the user closed the dialog (the application then exits).
		/// </summary>
		public static bool SignIn()
		{
			List<UserItem> users = null;
			if (!Notify.Try(() => users = LookupService.Users(activeOnly: true), "Loading the users"))
				return false;
			if (users.Count == 0)
			{
				Notify.Error("There are no active users to sign in with.");
				return false;
			}

			var dialog = new SignInDialog();
			dialog.LoadUsers(users);
			return dialog.ShowDialog() == true && CurrentUser.IsSignedIn;
		}

		private void LoadUsers(List<UserItem> users)
		{
			// Admins first, then Managers, then Sales.
			this.listUsers.ItemsSource = users.OrderBy(u => u.Role).ThenBy(u => u.Name).ToList();
			this.listUsers.SelectedIndex = 0;
			this.Loaded += (s, e) =>
			{
				this.listUsers.UpdateLayout();
				(this.listUsers.ItemContainerGenerator.ContainerFromIndex(0) as ListBoxItem)?.Focus();
			};
			UpdateButton();
		}

		private void UpdateButton()
		{
			this.buttonSignIn.IsEnabled = this.listUsers.SelectedItem != null;
		}

		private void SignInSelected()
		{
			if (!(this.listUsers.SelectedItem is UserItem user))
				return;

			if (Notify.Try(() => CurrentUser.SignIn(user.Id), "Signing in"))
				this.DialogResult = true;
		}

		private void buttonSignIn_Click(object sender, RoutedEventArgs e)
		{
			SignInSelected();
		}

		private void listUsers_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<UserItem>(e) != null)
				SignInSelected();
		}

		private void listUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			UpdateButton();
		}
	}
}
