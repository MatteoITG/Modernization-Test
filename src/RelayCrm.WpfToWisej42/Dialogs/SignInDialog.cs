using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Development sign-in: picks one of the seeded users, without a password.
	/// There is no real authentication provider.
	/// </summary>
	public partial class SignInDialog : Form
	{
		public SignInDialog()
		{
			InitializeComponent();
			DialogHelper.KeepOpenOnAccept(this);
		}

		/// <summary>
		/// Signs a user in; returns false when the user closed the dialog (the WPF application then exited).
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

			using (var dialog = new SignInDialog())
			{
				dialog.LoadUsers(users);

				// shown before Application.MainPage exists, so CenterScreen has no desktop to measure:
				// place it from the browser size reported at session start.
				var browser = Application.Browser.Size;
				if (!browser.IsEmpty)
				{
					dialog.StartPosition = FormStartPosition.Manual;
					dialog.Location = new System.Drawing.Point(
						Math.Max(0, (browser.Width - dialog.Width) / 2),
						Math.Max(0, (browser.Height - dialog.Height) / 2));
				}
				return dialog.ShowDialog() == DialogResult.OK && CurrentUser.IsSignedIn;
			}
		}

		/// <summary>
		/// Shown when the user left the sign-in or chose Exit: a web app cannot close the browser tab,
		/// so it says so and offers to sign in again: Application.Exit ends the session and, with "autoReload"
		/// in Default.json, the browser starts a new one (Program.Main runs again).
		/// </summary>
		public static void ShowSignedOut()
		{
			MessageBox.Show("You have left Relay.\n\nChoose OK to sign in again.", "Relay", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Application.Exit();
		}

		private void LoadUsers(List<UserItem> users)
		{
			// Admins first, then Managers, then Sales.
			this.listUsers.DataSource = TemplateItem.Wrap(users.OrderBy(u => u.Role).ThenBy(u => u.Name), UserTemplate);
			this.listUsers.SelectedIndex = 0;
			UpdateButton();
		}

		// the XAML item template: the avatar with the initials, the name, the role and the email.
		private static string UserTemplate(UserItem user)
		{
			return TemplateItem.WithAvatar(user.Initials, ToneExtensions.ColorOf(user.AvatarColor),
				TemplateItem.Line(user.Name, bold: true)
				+ TemplateItem.Line(user.Role + " · " + user.Email, color: ToneExtensions.MutedColor));
		}

		private void UpdateButton()
		{
			this.buttonSignIn.Enabled = this.listUsers.SelectedItem != null;
		}

		private void SignInSelected()
		{
			if (!(UiHelper.SelectedItem<UserItem>(this.listUsers) is UserItem user))
				return;

			if (Notify.Try(() => CurrentUser.SignIn(user.Id), "Signing in"))
				this.DialogResult = DialogResult.OK;
		}

		private void SignInDialog_Load(object sender, EventArgs e)
		{
			this.listUsers.Focus();
		}

		private void buttonSignIn_Click(object sender, EventArgs e)
		{
			SignInSelected();
		}

		private void listUsers_DoubleClick(object sender, EventArgs e)
		{
			if (UiHelper.SelectedItem<UserItem>(this.listUsers) != null)
				SignInSelected();
		}

		private void listUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateButton();
		}
	}
}
