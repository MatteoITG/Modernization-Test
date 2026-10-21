using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// Settings: the profile of the signed in user, the team and their roles, the pipeline stages,
	/// the tags and the demo data.
	/// </summary>
	/// <remarks>
	/// The ComboBox and CheckBox cell templates of the users grid became a combo box and a check box column
	/// (CellValueChanged); the avatar colours, an ItemsControl of buttons, are buttons in a FlowLayoutPanel.
	/// Migration step 2: the profile preview and the users grid show Avatars (the HTML avatar column is gone),
	/// the tag names are chips, and the buttons and grids use the Relay theme.
	/// </remarks>
	public partial class SettingsView : UserControl
	{
		/// <summary>A colour of the avatar palette.</summary>
		public class ColorChoice
		{
			public string Color { get; set; }
			public Color Brush { get; set; }
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
			GridHelper.UseConverters(this.gridUsers);
			GridHelper.UseConverters(this.gridTags);

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
			this.tabControl.SelectedTab = this.tabProfile;
			this.textBoxProfileName.Focus();
		}

		/// <summary>
		/// Admins change everything; Managers see the users read-only; Sales do not see the users
		/// and cannot change stages, tags or the demo data.
		/// </summary>
		private void ApplyRoleRules()
		{
			var admin = SettingsService.CanManageUsers;
			var editor = SettingsService.CanEditSettings;

			this.tabUsers.Hidden = !SettingsService.CanSeeUsers;
			this.buttonInvite.Visible = admin;
			this.gridUsers.Tag = new UsersGridState { Roles = Enum.GetNames(typeof(UserRole)), CanManage = admin };
			var state = (UsersGridState)this.gridUsers.Tag;
			this.colRole.Items.AddRange(state.Roles);
			this.colRole.ReadOnly = this.colActive.ReadOnly = !state.CanManage;
			this.labelUsersHint.Text = admin
				? "Invite people, change their role, or deactivate who left the team."
				: "Only Admins can invite users and change roles.";

			this.gridStages.ReadOnly = !editor;
			this.buttonMoveUp.Visible = this.buttonMoveDown.Visible = this.buttonSaveStages.Visible = editor;
			if (!editor)
				this.labelStagesHint.Text = "Only Managers and Admins can change the pipeline stages.";

			this.panelAddTag.Visible = editor;
			if (!editor)
				this.labelTagsHint.Text = "Only Managers and Admins can add and remove tags.";

			this.buttonResetDemo.Enabled = CurrentUser.IsAdmin;
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
			// step 2: an Avatar with an SVG image of the initials (was an Ellipse with a TextBlock).
			this.avatarProfile.Text = name;
			this.avatarProfile.ImageSource = Avatars.Source(name.Length == 0 ? "?" : name, this.profileColor);
			this.labelProfileName.Text = name.Length == 0 ? "Your name" : name + "  ·  " + this.textBoxProfileEmail.Text.Trim();

			ShowColors(SettingsService.AvatarPalette.Select(c => new ColorChoice
			{
				Color = c,
				Brush = ToneExtensions.ColorOf(c),
				Check = string.Equals(c, this.profileColor, StringComparison.OrdinalIgnoreCase) ? "✓" : "",
			}).ToList());
		}

		// the ItemsControl of the colours: one button per ColorChoice, as its XAML ItemTemplate.
		private void ShowColors(List<ColorChoice> choices)
		{
			if (this.listColors.Controls.Count != choices.Count)
			{
				this.listColors.Controls.Clear(true);
				foreach (var choice in choices)
				{
					var button = new Button { Size = new Size(28, 28), Margin = new Padding(0, 0, 6, 0), Padding = new Padding(0), ForeColor = Color.White };
					button.Font = new Font(button.Font, FontStyle.Bold);
					button.Click += buttonColor_Click;
					this.listColors.Controls.Add(button);
				}
			}
			for (var i = 0; i < choices.Count; i++)
			{
				var button = this.listColors.Controls[i];
				button.Tag = choices[i];
				button.BackColor = choices[i].Brush;
				button.ToolTipText = choices[i].Color;
				button.Text = choices[i].Check;
			}
		}

		private void buttonColor_Click(object sender, EventArgs e)
		{
			if (((Control)sender).Tag is ColorChoice choice)
			{
				this.profileColor = choice.Color;
				UpdateProfilePreview();
			}
		}

		private void textBoxProfile_TextChanged(object sender, EventArgs e)
		{
			DialogHelper.ClearError(this.labelProfileError);
			if (this.profileColor != null)
				UpdateProfilePreview();
		}

		private void buttonSaveProfile_Click(object sender, EventArgs e)
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
				this.gridUsers.DataSource = users;
				this.labelUsersTitle.Text = $"Team ({users.Count(u => u.Active)} active)";
			}
			finally
			{
				this.loading = false;
			}
		}

		private void buttonInvite_Click(object sender, EventArgs e)
		{
			if (InviteUserDialog.Invite())
				LoadUsers();
		}

		private void gridUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;
			if (e.ColumnIndex == this.colRole.Index)
				comboRole_SelectionChanged(sender, e);
			else if (e.ColumnIndex == this.colActive.Index)
				checkActive_Click(sender, e);
		}

		private void comboRole_SelectionChanged(object sender, DataGridViewCellEventArgs e)
		{
			var combo = this.gridUsers[e.ColumnIndex, e.RowIndex];
			if (this.loading || !SettingsService.CanManageUsers)
				return;
			// the grid already wrote the new role into the row: the stored role is reloaded below.
			if (!(UiHelper.RowItem<UserRow>(this.gridUsers, e) is UserRow user) || !(combo.Value is string roleName))
				return;

			var role = (UserRole)Enum.Parse(typeof(UserRole), roleName);
			if (Notify.Try(() => SettingsService.ChangeRole(user.Id, role), "Changing the role"))
				Notify.Success($"{user.Name} is now {role}.");

			// reload to show the stored values (and undo a refused change).
			Application.Post(LoadUsers);
		}

		private void checkActive_Click(object sender, DataGridViewCellEventArgs e)
		{
			var check = this.gridUsers[e.ColumnIndex, e.RowIndex];
			if (this.loading || !SettingsService.CanManageUsers || !(UiHelper.RowItem<UserRow>(this.gridUsers, e) is UserRow user))
				return;

			var active = check.Value is bool value && value;
			if (Notify.Try(() => SettingsService.SetActive(user.Id, active), "Changing the user"))
				Notify.Success(user.Name + (active ? " was activated." : " was deactivated."));

			// reloaded after the grid finished the edit.
			Application.Post(LoadUsers);
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
			this.buttonSaveStages.Enabled = false;
		}

		private void BindStages(int selectIndex)
		{
			for (var i = 0; i < this.stages.Count; i++)
				this.stages[i].Order = i + 1;

			this.loading = true;
			try
			{
				this.gridStages.DataSource = null;
				this.gridStages.DataSource = this.stages;
				if (selectIndex >= 0 && selectIndex < this.stages.Count)
					this.gridStages.CurrentCell = this.gridStages[0, selectIndex];
			}
			finally
			{
				this.loading = false;
			}
			UpdateMoveButtons();
		}

		private int SelectedStageIndex => this.gridStages.CurrentRow?.Index ?? -1;

		private void UpdateMoveButtons()
		{
			var index = this.SelectedStageIndex;
			var open = this.stages.Count(s => !s.IsClosed);
			var movable = index >= 0 && index < this.stages.Count && !this.stages[index].IsClosed;
			this.buttonMoveUp.Enabled = movable && index > 0;
			this.buttonMoveDown.Enabled = movable && index < open - 1;
		}

		private void MoveStage(int delta)
		{
			this.gridStages.EndEdit();
			var index = this.SelectedStageIndex;
			var target = index + delta;
			var open = this.stages.Count(s => !s.IsClosed);
			if (index < 0 || target < 0 || target >= open || this.stages[index].IsClosed)
				return;

			var stage = this.stages[index];
			this.stages.RemoveAt(index);
			this.stages.Insert(target, stage);
			BindStages(target);
			this.buttonSaveStages.Enabled = true;
		}

		private void buttonMoveUp_Click(object sender, EventArgs e)
		{
			MoveStage(-1);
		}

		private void buttonMoveDown_Click(object sender, EventArgs e)
		{
			MoveStage(1);
		}

		private void buttonSaveStages_Click(object sender, EventArgs e)
		{
			this.gridStages.EndEdit();

			var updated = 0;
			if (Notify.Try(() => updated = SettingsService.SaveStages(this.stages), "Saving the stages"))
			{
				Notify.Success(updated > 0
					? $"Stages saved. {updated} open deal{(updated == 1 ? "" : "s")} got the new probability."
					: "Stages saved.");
				LoadStages();
			}
		}

		private void gridStages_SelectionChanged(object sender, EventArgs e)
		{
			if (this.buttonMoveUp != null)
				UpdateMoveButtons();
		}

		private void gridStages_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (this.loading || !this.gridStages.IsCurrentCellInEditMode)
				return;

			var text = Convert.ToString(e.FormattedValue).Trim();
			var column = this.gridStages.Columns[e.ColumnIndex];
			if (column.HeaderText == "Name" && text.Length == 0)
			{
				Notify.Warning("Enter a name for the stage.");
				e.Cancel = true;
				return;
			}
			if (column.HeaderText == "Probability %"
				&& (!int.TryParse(text.TrimEnd('%').Trim(), out var value) || value < 0 || value > 100))
			{
				Notify.Warning("Enter a probability between 0 and 100.");
				e.Cancel = true;
				return;
			}

			// the grid shows the same StageRow objects: the edit goes straight into this.stages.
			this.buttonSaveStages.Enabled = true;
		}

		#endregion

		#region Tags

		private void LoadTags()
		{
			List<TagRow> tags = null;
			if (!Notify.Try(() => tags = SettingsService.Tags(), "Loading the tags"))
				return;

			this.gridTags.DataSource = tags;
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

		private void buttonAddTag_Click(object sender, EventArgs e)
		{
			AddTag();
		}

		private void textBoxNewTag_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				AddTag();
			}
		}

		private void buttonRemoveTag_Click(object sender, EventArgs e)
		{
			if (!(UiHelper.SelectedItem<TagRow>(this.gridTags) is TagRow tag))
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

		private void buttonResetDemo_Click(object sender, EventArgs e)
		{
			if (!ConfirmDialog.Ask("Reset demo data",
				"All companies, contacts, deals, activities, tasks and users go back to the sample data. Every change made so far is lost.",
				"Reset"))
				return;

			// the browser shows the Wisej loader while the request runs (was Mouse.OverrideCursor = Cursors.Wait).
			var reset = Notify.Try(() => SettingsService.ResetDemoData(), "Resetting the demo data");

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
