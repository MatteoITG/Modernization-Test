using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// Settings: the profile of the signed in user, the team and their roles, the pipeline stages,
	/// the tags and the demo data.
	/// </summary>
	public partial class SettingsView : UserControl
	{
		/// <summary>A colour of the avatar palette.</summary>
		public class ColorChoice
		{
			public string Color { get; set; }
			public Brush Brush { get; set; }
			public string Check { get; set; }
		}

		/// <summary>What the cells of the users grid offer (bound through the grid's Tag).</summary>
		public class UsersGridState
		{
			public string[] Roles { get; set; }
			public bool CanManage { get; set; }
		}

		// true while a grid is being filled, to ignore its value changes.
		private bool loading;

		private string profileColor;
		private List<StageRow> stages = new List<StageRow>();

		public SettingsView()
		{
			InitializeComponent();

			ApplyRoleRules();
			LoadProfile();
			if (SettingsService.CanSeeUsers)
				LoadUsers();
			LoadStages();
			LoadTags();
		}

		/// <summary>
		/// Selects the Profile tab.
		/// </summary>
		public void ShowProfile()
		{
			this.tabControl.SelectedItem = this.tabProfile;
			this.Dispatcher.BeginInvoke(new Action(() => this.textBoxProfileName.Focus()), System.Windows.Threading.DispatcherPriority.Input);
		}

		/// <summary>
		/// Admins change everything; Managers see the users read-only; Sales do not see the users
		/// and cannot change stages, tags or the demo data.
		/// </summary>
		private void ApplyRoleRules()
		{
			var admin = SettingsService.CanManageUsers;
			var editor = SettingsService.CanEditSettings;

			this.tabUsers.Visibility = SettingsService.CanSeeUsers ? Visibility.Visible : Visibility.Collapsed;
			this.buttonInvite.Visibility = admin ? Visibility.Visible : Visibility.Collapsed;
			this.gridUsers.Tag = new UsersGridState { Roles = Enum.GetNames(typeof(UserRole)), CanManage = admin };
			this.labelUsersHint.Text = admin
				? "Invite people, change their role, or deactivate who left the team."
				: "Only Admins can invite users and change roles.";

			this.gridStages.IsReadOnly = !editor;
			this.buttonMoveUp.Visibility = this.buttonMoveDown.Visibility = this.buttonSaveStages.Visibility = editor ? Visibility.Visible : Visibility.Collapsed;
			if (!editor)
				this.labelStagesHint.Text = "Only Managers and Admins can change the pipeline stages.";

			this.panelAddTag.Visibility = editor ? Visibility.Visible : Visibility.Collapsed;
			if (!editor)
				this.labelTagsHint.Text = "Only Managers and Admins can add and remove tags.";

			this.buttonResetDemo.IsEnabled = CurrentUser.IsAdmin;
			this.labelDemoNote.Text = CurrentUser.IsAdmin ? "" : "Only Admins can reset the demo data.";
		}

		#region Profile

		private void LoadProfile()
		{
			this.textBoxProfileName.Text = CurrentUser.Name;
			this.textBoxProfileEmail.Text = CurrentUser.Email;
			this.labelProfileRole.Text = "Role: " + CurrentUser.Role + (CurrentUser.SeesAll ? " · sees all records" : " · sees own records by default");

			UserItem user = null;
			Notify.Try(() => user = LookupService.User(CurrentUser.Id), "Loading your profile");
			this.profileColor = user?.AvatarColor ?? SettingsService.AvatarPalette[0];
			UpdateProfilePreview();
		}

		private void UpdateProfilePreview()
		{
			if (this.listColors == null)
				return;

			var name = this.textBoxProfileName.Text.Trim();
			this.labelProfileInitials.Text = RelayCrm.Text.Initials(name);
			this.ellipseProfile.Fill = ToneExtensions.BrushOf(this.profileColor);
			this.labelProfileName.Text = name.Length == 0 ? "Your name" : name + "  ·  " + this.textBoxProfileEmail.Text.Trim();

			this.listColors.ItemsSource = SettingsService.AvatarPalette.Select(c => new ColorChoice
			{
				Color = c,
				Brush = ToneExtensions.BrushOf(c),
				Check = string.Equals(c, this.profileColor, StringComparison.OrdinalIgnoreCase) ? "✓" : "",
			}).ToList();
		}

		private void buttonColor_Click(object sender, RoutedEventArgs e)
		{
			if (((FrameworkElement)sender).DataContext is ColorChoice choice)
			{
				this.profileColor = choice.Color;
				UpdateProfilePreview();
			}
		}

		private void textBoxProfile_TextChanged(object sender, TextChangedEventArgs e)
		{
			DialogHelper.ClearError(this.labelProfileError);
			if (this.profileColor != null)
				UpdateProfilePreview();
		}

		private void buttonSaveProfile_Click(object sender, RoutedEventArgs e)
		{
			var name = this.textBoxProfileName.Text.Trim();
			if (name.Length == 0)
			{
				DialogHelper.ShowError(this.labelProfileError, "Enter your name.", this.textBoxProfileName);
				return;
			}

			string emailError = null;
			if (!Notify.Try(() => emailError = SettingsService.ValidateEmail(this.textBoxProfileEmail.Text, CurrentUser.Id), "Checking the email"))
				return;
			if (emailError != null)
			{
				DialogHelper.ShowError(this.labelProfileError, emailError, this.textBoxProfileEmail);
				return;
			}

			if (Notify.Try(() => SettingsService.SaveProfile(name, this.textBoxProfileEmail.Text, this.profileColor), "Saving your profile"))
			{
				Notify.Success("Profile saved.");
				if (SettingsService.CanSeeUsers)
					LoadUsers();
			}
		}

		#endregion

		#region Users

		private void LoadUsers()
		{
			List<UserRow> users = null;
			if (!Notify.Try(() => users = SettingsService.Users(), "Loading the users"))
				return;

			this.loading = true;
			try
			{
				this.gridUsers.ItemsSource = users;
				this.gridUsers.UpdateLayout();
				this.labelUsersTitle.Text = $"Team ({users.Count(u => u.Active)} active)";
			}
			finally
			{
				this.loading = false;
			}
		}

		private void buttonInvite_Click(object sender, RoutedEventArgs e)
		{
			if (InviteUserDialog.Invite())
				LoadUsers();
		}

		private void comboRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			var combo = (ComboBox)sender;
			if (this.loading || !SettingsService.CanManageUsers)
				return;
			// the grid creates its cells lazily: their first selection is the stored role and is ignored here.
			if (!(combo.DataContext is UserRow user) || !(combo.SelectedItem is string roleName) || roleName == user.Role)
				return;

			var role = (UserRole)Enum.Parse(typeof(UserRole), roleName);
			if (Notify.Try(() => SettingsService.ChangeRole(user.Id, role), "Changing the role"))
				Notify.Success($"{user.Name} is now {role}.");

			// reload to show the stored values (and undo a refused change).
			this.Dispatcher.BeginInvoke(new Action(LoadUsers));
		}

		private void checkActive_Click(object sender, RoutedEventArgs e)
		{
			var check = (CheckBox)sender;
			if (this.loading || !SettingsService.CanManageUsers || !(check.DataContext is UserRow user))
				return;

			var active = check.IsChecked == true;
			if (Notify.Try(() => SettingsService.SetActive(user.Id, active), "Changing the user"))
				Notify.Success(user.Name + (active ? " was activated." : " was deactivated."));

			LoadUsers();
		}

		#endregion

		#region Stages

		private void LoadStages()
		{
			List<StageRow> rows = null;
			if (!Notify.Try(() => rows = SettingsService.Stages(), "Loading the stages"))
				return;

			this.stages = rows;
			BindStages(0);
			this.buttonSaveStages.IsEnabled = false;
		}

		private void BindStages(int selectIndex)
		{
			for (var i = 0; i < this.stages.Count; i++)
				this.stages[i].Order = i + 1;

			this.loading = true;
			try
			{
				this.gridStages.ItemsSource = null;
				this.gridStages.ItemsSource = this.stages;
				if (selectIndex >= 0 && selectIndex < this.stages.Count)
					this.gridStages.SelectedIndex = selectIndex;
			}
			finally
			{
				this.loading = false;
			}
			UpdateMoveButtons();
		}

		private int SelectedStageIndex => this.gridStages.SelectedIndex;

		private void UpdateMoveButtons()
		{
			var index = this.SelectedStageIndex;
			var open = this.stages.Count(s => !s.IsClosed);
			var movable = index >= 0 && index < this.stages.Count && !this.stages[index].IsClosed;
			this.buttonMoveUp.IsEnabled = movable && index > 0;
			this.buttonMoveDown.IsEnabled = movable && index < open - 1;
		}

		private void MoveStage(int delta)
		{
			this.gridStages.CommitEdit(DataGridEditingUnit.Row, true);
			var index = this.SelectedStageIndex;
			var target = index + delta;
			var open = this.stages.Count(s => !s.IsClosed);
			if (index < 0 || target < 0 || target >= open || this.stages[index].IsClosed)
				return;

			var stage = this.stages[index];
			this.stages.RemoveAt(index);
			this.stages.Insert(target, stage);
			BindStages(target);
			this.buttonSaveStages.IsEnabled = true;
		}

		private void buttonMoveUp_Click(object sender, RoutedEventArgs e)
		{
			MoveStage(-1);
		}

		private void buttonMoveDown_Click(object sender, RoutedEventArgs e)
		{
			MoveStage(1);
		}

		private void buttonSaveStages_Click(object sender, RoutedEventArgs e)
		{
			this.gridStages.CommitEdit(DataGridEditingUnit.Row, true);

			var updated = 0;
			if (Notify.Try(() => updated = SettingsService.SaveStages(this.stages), "Saving the stages"))
			{
				Notify.Success(updated > 0
					? $"Stages saved. {updated} open deal{(updated == 1 ? "" : "s")} got the new probability."
					: "Stages saved.");
				LoadStages();
			}
		}

		private void gridStages_SelectionChanged(object sender, SelectionChangedEventArgs e)
		{
			if (this.buttonMoveUp != null)
				UpdateMoveButtons();
		}

		private void gridStages_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
		{
			if (this.loading || e.EditAction != DataGridEditAction.Commit || !(e.EditingElement is TextBox box))
				return;

			var text = box.Text.Trim();
			if ((string)e.Column.Header == "Name" && text.Length == 0)
			{
				Notify.Warning("Enter a name for the stage.");
				e.Cancel = true;
				return;
			}
			if ((string)e.Column.Header == "Probability %"
				&& (!int.TryParse(text.TrimEnd('%').Trim(), out var value) || value < 0 || value > 100))
			{
				Notify.Warning("Enter a probability between 0 and 100.");
				e.Cancel = true;
				return;
			}

			// the grid shows the same StageRow objects: the edit goes straight into this.stages.
			this.buttonSaveStages.IsEnabled = true;
		}

		#endregion

		#region Tags

		private void LoadTags()
		{
			List<TagRow> tags = null;
			if (!Notify.Try(() => tags = SettingsService.Tags(), "Loading the tags"))
				return;

			this.gridTags.ItemsSource = tags;
			this.labelTagsTitle.Text = $"Tags ({tags.Count})";
		}

		private void AddTag()
		{
			var name = this.textBoxNewTag.Text.Trim();
			if (name.Length == 0)
			{
				Notify.Warning("Enter a tag name.");
				this.textBoxNewTag.Focus();
				return;
			}

			if (Notify.Try(() => SettingsService.AddTag(name), "Adding the tag"))
			{
				Notify.Success($"Tag \"{name}\" added.");
				this.textBoxNewTag.Text = "";
				LoadTags();
			}
		}

		private void buttonAddTag_Click(object sender, RoutedEventArgs e)
		{
			AddTag();
		}

		private void textBoxNewTag_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Key == Key.Enter)
			{
				e.Handled = true;
				AddTag();
			}
		}

		private void buttonRemoveTag_Click(object sender, RoutedEventArgs e)
		{
			if (!(this.gridTags.SelectedItem is TagRow tag))
			{
				Notify.Info("Select the tag to remove.");
				return;
			}

			var message = tag.Usage == 0
				? $"Remove the tag \"{tag.Name}\"?"
				: $"Remove the tag \"{tag.Name}\"? It is taken off {tag.Companies} companies and {tag.Contacts} contacts.";
			if (!ConfirmDialog.Ask("Remove tag", message, "Remove"))
				return;

			if (Notify.Try(() => SettingsService.RemoveTag(tag.Id), "Removing the tag"))
			{
				Notify.Success($"Tag \"{tag.Name}\" removed.");
				LoadTags();
			}
		}

		#endregion

		#region Demo data

		private void buttonResetDemo_Click(object sender, RoutedEventArgs e)
		{
			if (!ConfirmDialog.Ask("Reset demo data",
				"All companies, contacts, deals, activities, tasks and users go back to the sample data. Every change made so far is lost.",
				"Reset"))
				return;

			Mouse.OverrideCursor = Cursors.Wait;
			bool reset;
			try
			{
				reset = Notify.Try(() => SettingsService.ResetDemoData(), "Resetting the demo data");
			}
			finally
			{
				Mouse.OverrideCursor = null;
			}

			if (reset)
			{
				// the seeded users get the same ids again: stay signed in when the user still exists.
				CurrentUser.Refresh();
				Navigator.Reload();
				Notify.Success("Demo data reset.");
			}
		}

		#endregion
	}
}
