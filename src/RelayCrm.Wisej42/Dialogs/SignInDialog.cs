using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// Development sign-in: picks one of the seeded users, without a password.
	/// There is no real authentication provider; Release builds sign in the first Admin.
	/// </summary>
	public partial class SignInDialog : Form
	{
		// one entry of the "Sign in as" list.
		private class UserChoice
		{
			public int Id { get; set; }
			public string Html { get; set; }
		}

		private bool signedIn;

		public SignInDialog()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Signs a user in; blocks until a user was chosen.
		/// </summary>
		public static void SignIn()
		{
			List<UserItem> users = null;
			if (!Notify.Try(() => users = LookupService.Users(activeOnly: true), "Loading the users") || users.Count == 0)
				return;

#if !DEBUG
			var admin = users.FirstOrDefault(u => u.Role == UserRole.Admin) ?? users[0];
			CurrentUser.SignIn(admin.Id);
			return;
#else
			using (var dialog = new SignInDialog())
			{
				dialog.LoadUsers(users);
				dialog.ShowDialog();
			}
#endif
		}

		private void LoadUsers(List<UserItem> users)
		{
			// Admins first, then Managers, then Sales.
			var choices = users
				.OrderBy(u => u.Role).ThenBy(u => u.Name)
				.Select(u => new UserChoice { Id = u.Id, Html = ItemHtml(u) })
				.ToList();

			this.listBoxUsers.DisplayMember = "Html";
			this.listBoxUsers.ValueMember = "Id";
			this.listBoxUsers.DataSource = choices;
			this.listBoxUsers.SelectedIndex = 0;
			UpdateButton();
		}

		private static string ItemHtml(UserItem user)
		{
			return "<div style='display:flex;align-items:center;gap:12px;height:100%'>"
				+ "<img src='" + SettingsService.AvatarImage(user.Name, user.AvatarColor) + "' style='width:36px;height:36px;border-radius:50%;flex:none'/>"
				+ "<div style='line-height:18px;overflow:hidden'>"
				+ "<div style='font-weight:600'>" + Encode(user.Name) + "</div>"
				+ "<div style='opacity:0.65;font-size:12px'>" + user.Role + " · " + Encode(user.Email) + "</div>"
				+ "</div></div>";
		}

		private static string Encode(string text) => System.Net.WebUtility.HtmlEncode(text ?? "");

		private void UpdateButton()
		{
			this.buttonSignIn.Enabled = this.listBoxUsers.SelectedIndex >= 0;
		}

		private void SignInSelected()
		{
			if (!(this.listBoxUsers.SelectedItem is UserChoice choice))
				return;

			if (Notify.Try(() => CurrentUser.SignIn(choice.Id), "Signing in"))
			{
				this.signedIn = true;
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void buttonSignIn_Click(object sender, EventArgs e)
		{
			SignInSelected();
		}

		private void listBoxUsers_DoubleClick(object sender, EventArgs e)
		{
			SignInSelected();
		}

		private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateButton();
		}

		private void SignInDialog_FormClosing(object sender, FormClosingEventArgs e)
		{
			// the dialog closes only after a user was chosen.
			if (!this.signedIn)
				e.Cancel = true;
		}
	}
}
