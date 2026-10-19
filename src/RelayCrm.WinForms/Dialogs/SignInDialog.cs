using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RelayCrm.Services;

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

			using (var dialog = new SignInDialog())
			{
				dialog.LoadUsers(users);
				return dialog.ShowDialog() == DialogResult.OK && CurrentUser.IsSignedIn;
			}
		}

		private void LoadUsers(List<UserItem> users)
		{
			var size = this.LogicalToDeviceUnits(32);
			this.imageListAvatars.ImageSize = new System.Drawing.Size(size, size);

			// Admins first, then Managers, then Sales.
			this.listViewUsers.BeginUpdate();
			foreach (var user in users.OrderBy(u => u.Role).ThenBy(u => u.Name))
			{
				this.imageListAvatars.Images.Add(user.Id.ToString(), Avatars.Create(user.Name, user.AvatarColor, size));
				var item = new ListViewItem(user.Name, user.Id.ToString()) { Tag = user.Id };
				item.SubItems.Add(user.Role.ToString());
				item.SubItems.Add(user.Email);
				this.listViewUsers.Items.Add(item);
			}
			this.listViewUsers.EndUpdate();

			this.listViewUsers.Items[0].Selected = true;
			this.listViewUsers.Items[0].Focused = true;
			UpdateButton();
		}

		private void UpdateButton()
		{
			this.buttonSignIn.Enabled = this.listViewUsers.SelectedItems.Count > 0;
		}

		private void SignInSelected()
		{
			if (this.listViewUsers.SelectedItems.Count == 0)
				return;

			var userId = (int)this.listViewUsers.SelectedItems[0].Tag;
			if (Notify.Try(() => CurrentUser.SignIn(userId), "Signing in"))
			{
				this.DialogResult = DialogResult.OK;
				Close();
			}
		}

		private void buttonSignIn_Click(object sender, EventArgs e)
		{
			SignInSelected();
		}

		private void listViewUsers_ItemActivate(object sender, EventArgs e)
		{
			SignInSelected();
		}

		private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateButton();
		}

		private void SignInDialog_Shown(object sender, EventArgs e)
		{
			this.listViewUsers.Focus();
		}
	}
}
