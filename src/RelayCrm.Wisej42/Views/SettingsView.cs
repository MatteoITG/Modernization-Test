using System;
using System.Collections.Generic;
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
	public partial class SettingsView : UserControl
	{
		private const string ColorButtonStyle = "border-radius:50%;min-width:32px;padding:0;";

		// true while a grid is being filled, to ignore its value changes.
		private bool loading;

		private string profileColor;
		private List<StageRow> stages = new List<StageRow>();
		private bool stagesDirty;

		public SettingsView()
		{
			InitializeComponent();

			this.dataGridUsers.AutoGenerateColumns = false;
			this.dataGridStages.AutoGenerateColumns = false;
			this.dataGridTags.AutoGenerateColumns = false;

			this.colStageKind.ToneMap["Open"] = ChipTone.Neutral;
			this.colStageKind.ToneMap["Won"] = ChipTone.Success;
			this.colStageKind.ToneMap["Lost"] = ChipTone.Danger;
		}

		/// <summary>
		/// Selects the Profile tab.
		/// </summary>
		public void ShowProfile()
		{
			this.tabControl.SelectedTab = this.tabProfile;
			this.textBoxProfileName.Focus();
		}

		private void SettingsView_Load(object sender, EventArgs e)
		{
			ApplyRoleRules();
			LoadProfile();
			if (SettingsService.CanSeeUsers)
				LoadUsers();
			LoadStages();
			LoadTags();
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
			this.dataGridUsers.ReadOnly = !admin;
			this.colUserAvatar.ReadOnly = true;
			this.colUserOwned.ReadOnly = true;
			this.labelUsersHint.Text = admin
				? "Invite people, change their role, or deactivate who left the team."
				: "Only Admins can invite users and change roles.";

			this.dataGridStages.ReadOnly = !editor;
			this.colStageOrder.ReadOnly = true;
			this.colStageKind.ReadOnly = true;
			this.colStageDeals.ReadOnly = true;
			this.buttonMoveUp.Visible = editor;
			this.buttonMoveDown.Visible = editor;
			this.buttonSaveStages.Visible = editor;
			if (!editor)
				this.labelStagesHint.Text = "Only Managers and Admins can change the pipeline stages.";

			this.textBoxNewTag.Visible = editor;
			this.buttonAddTag.Visible = editor;
			this.colTagActions.Visible = editor;
			if (!editor)
				this.labelTagsHint.Text = "Only Managers and Admins can add and remove tags.";

			this.buttonResetDemo.Enabled = CurrentUser.IsAdmin;
			if (!CurrentUser.IsAdmin)
				this.labelDemoNote.Text = "Only Admins can reset the demo data.";
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

			var buttons = this.ColorButtons;
			for (var i = 0; i < buttons.Length; i++)
			{
				buttons[i].BackColor = System.Drawing.ColorTranslator.FromHtml(SettingsService.AvatarPalette[i]);
				buttons[i].Tag = SettingsService.AvatarPalette[i];
				buttons[i].ToolTipText = SettingsService.AvatarPalette[i];
			}
			UpdateProfilePreview();
		}

		private Button[] ColorButtons => new[] {
			this.buttonColor1, this.buttonColor2, this.buttonColor3, this.buttonColor4,
			this.buttonColor5, this.buttonColor6, this.buttonColor7, this.buttonColor8 };

		private void UpdateProfilePreview()
		{
			var name = this.textBoxProfileName.Text.Trim();
			this.avatarProfile.Text = name;
			this.avatarProfile.ImageSource = SettingsService.AvatarImage(name, this.profileColor);
			this.avatarProfile.Label = name.Length == 0 ? "Your name" : name;
			this.avatarProfile.SubLabel = this.textBoxProfileEmail.Text.Trim();

			foreach (var button in this.ColorButtons)
			{
				var selected = (string)button.Tag == this.profileColor;
				button.CssStyle = ColorButtonStyle + (selected ? "outline:2px solid " + this.profileColor + ";outline-offset:3px;" : "");
				button.ImageSource = selected ? "resource.wx/Wisej.Ext.BootstrapIcons/check-lg.svg" : null;
			}
		}

		private void buttonColor_Click(object sender, EventArgs e)
		{
			this.profileColor = (string)((Button)sender).Tag;
			UpdateProfilePreview();
		}

		private void textBoxProfile_TextChanged(object sender, EventArgs e)
		{
			((TextBox)sender).Invalid = false;
			UpdateProfilePreview();
		}

		private void buttonSaveProfile_Click(object sender, EventArgs e)
		{
			var name = this.textBoxProfileName.Text.Trim();
			if (name.Length == 0)
			{
				this.textBoxProfileName.InvalidMessage = "Enter your name.";
				this.textBoxProfileName.Invalid = true;
				this.textBoxProfileName.Focus();
				return;
			}

			string emailError = null;
			if (!Notify.Try(() => emailError = SettingsService.ValidateEmail(this.textBoxProfileEmail.Text, CurrentUser.Id), "Checking the email"))
				return;
			if (emailError != null)
			{
				this.textBoxProfileEmail.InvalidMessage = emailError;
				this.textBoxProfileEmail.Invalid = true;
				this.textBoxProfileEmail.Focus();
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
				this.dataGridUsers.DataSource = users;
				this.labelUsersTitle.Text = $"Team ({users.Count(u => u.Active)} active)";
			}
			finally
			{
				this.loading = false;
			}
		}

		private void buttonInvite_Click(object sender, EventArgs e)
		{
			if (InviteUserDialog.Show())
				LoadUsers();
		}

		private void dataGridUsers_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (this.loading || e.RowIndex < 0 || !SettingsService.CanManageUsers)
				return;

			if (!(this.dataGridUsers.Rows[e.RowIndex].DataBoundItem is UserRow user))
				return;

			var column = this.dataGridUsers.Columns[e.ColumnIndex];
			bool ok;
			if (column == this.colUserRole)
			{
				var role = (UserRole)Enum.Parse(typeof(UserRole), user.Role);
				ok = Notify.Try(() => SettingsService.ChangeRole(user.Id, role), "Changing the role");
				if (ok)
					Notify.Success($"{user.Name} is now {role}.");
			}
			else if (column == this.colUserActive)
			{
				var active = user.Active;
				ok = Notify.Try(() => SettingsService.SetActive(user.Id, active), "Changing the user");
				if (ok)
					Notify.Success(user.Name + (active ? " was activated." : " was deactivated."));
			}
			else
			{
				return;
			}

			// reload to show the stored values (and undo a refused change).
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
			SetStagesDirty(false);
		}

		private void BindStages(int selectIndex)
		{
			for (var i = 0; i < this.stages.Count; i++)
				this.stages[i].Order = i + 1;

			this.loading = true;
			try
			{
				this.dataGridStages.DataSource = null;
				this.dataGridStages.DataSource = this.stages.ToList();
				if (selectIndex >= 0 && selectIndex < this.dataGridStages.Rows.Count)
				{
					this.dataGridStages.ClearSelection();
					this.dataGridStages.CurrentCell = this.dataGridStages.Rows[selectIndex].Cells[this.colStageName.Index];
				}
			}
			finally
			{
				this.loading = false;
			}
			UpdateMoveButtons();
		}

		private void SetStagesDirty(bool dirty)
		{
			this.stagesDirty = dirty;
			this.buttonSaveStages.Enabled = dirty;
		}

		private int SelectedStageIndex => this.dataGridStages.CurrentRow?.Index ?? -1;

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
			this.dataGridStages.EndEdit();
			var index = this.SelectedStageIndex;
			var target = index + delta;
			var open = this.stages.Count(s => !s.IsClosed);
			if (index < 0 || target < 0 || target >= open || this.stages[index].IsClosed)
				return;

			var stage = this.stages[index];
			this.stages.RemoveAt(index);
			this.stages.Insert(target, stage);
			BindStages(target);
			SetStagesDirty(true);
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
			this.dataGridStages.EndEdit();

			var updated = 0;
			if (Notify.Try(() => updated = SettingsService.SaveStages(this.stages), "Saving the stages"))
			{
				Notify.Success(updated > 0
					? $"Stages saved. {updated} open deal{(updated == 1 ? "" : "s")} got the new probability."
					: "Stages saved.");
				LoadStages();
			}
		}

		private void dataGridStages_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			if (this.loading || e.RowIndex < 0)
				return;

			var column = this.dataGridStages.Columns[e.ColumnIndex];
			var text = Convert.ToString(e.FormattedValue)?.Trim() ?? "";

			if (column == this.colStageProbability)
			{
				if (!int.TryParse(text.TrimEnd('%').Trim(), out var value) || value < 0 || value > 100)
				{
					Notify.Warning("Enter a probability between 0 and 100.");
					e.Cancel = true;
				}
			}
			else if (column == this.colStageName)
			{
				if (text.Length == 0)
				{
					Notify.Warning("Enter a name for the stage.");
					e.Cancel = true;
				}
			}
		}

		private void dataGridStages_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			if (this.loading || e.RowIndex < 0)
				return;

			// the grid shows the same StageRow objects: the edit is already in this.stages.
			SetStagesDirty(true);
		}

		private void dataGridStages_CurrentCellChanged(object sender, EventArgs e)
		{
			UpdateMoveButtons();
		}

		#endregion

		#region Tags

		private void LoadTags()
		{
			List<TagRow> tags = null;
			if (!Notify.Try(() => tags = SettingsService.Tags(), "Loading the tags"))
				return;

			foreach (var tag in tags)
				this.colTagName.ToneMap[tag.Name] = tag.Usage > 0 ? ChipTone.Primary : ChipTone.Neutral;
			this.dataGridTags.DataSource = tags;
			this.labelTagsTitle.Text = $"Tags ({tags.Count})";
		}

		private void buttonAddTag_Click(object sender, EventArgs e)
		{
			var name = this.textBoxNewTag.Text.Trim();
			if (name.Length == 0)
			{
				this.textBoxNewTag.InvalidMessage = "Enter a tag name.";
				this.textBoxNewTag.Invalid = true;
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

		private void textBoxNewTag_TextChanged(object sender, EventArgs e)
		{
			this.textBoxNewTag.Invalid = false;
		}

		private void colTagActions_ActionClick(object sender, DataGridViewVisualCellEventArgs e)
		{
			if (!(e.DataBoundItem is TagRow tag) || e.Action?.Name != "remove")
				return;

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

			if (Notify.Try(() => SettingsService.ResetDemoData(), "Resetting the demo data"))
			{
				Notify.Success("Demo data reset. Reloading Relay...");
				// the seeded users get the same ids again: stay signed in when the user still exists.
				CurrentUser.Refresh();
				Application.Reload();
			}
		}

		#endregion
	}
}
