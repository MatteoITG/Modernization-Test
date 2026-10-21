using System;
using System.Collections.Generic;
using System.Linq;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// The page of one contact: header with avatar, name, title at company, stage and owner,
	/// actions, and the Overview, Activity, Deals and Tasks tabs.
	/// </summary>
	/// <remarks>
	/// Migration step 2: the round initials label became an Avatar, the stage text a ChipLabel, the HTML activity list
	/// a Timeline, the deals grid an ActionCardList, the empty labels EmptyStates, and the tasks grid got chip and
	/// avatar columns.
	/// </remarks>
	public partial class ContactDetailView : UserControl
	{
		private int contactId;
		private ContactDetail contact;

		public ContactDetailView()
		{
			InitializeComponent();
			GridHelper.UseConverters(this.gridTasks);
			ToneExtensions.AddTaskStatusTones(this.colTaskStatus.ToneMap);
			ToneExtensions.AddPriorityTones(this.colTaskPriority.ToneMap);

			// the deal cards show these properties of ContactDealItem (the columns of the WPF grid).
			this.listDeals.DisplayMembers.Title = "Title";
			this.listDeals.DisplayMembers.Description = "Description";
			this.listDeals.DisplayMembers.Meta = "Meta";
			this.listDeals.DisplayMembers.Icon = "Icon";
			this.listDeals.DisplayMembers.IconTone = "IconTone";
			this.listDeals.DisplayMembers.Badge = "StageName";
			this.listDeals.DisplayMembers.BadgeTone = "StageTone";
		}

		/// <summary>
		/// Loads the contact and all its tabs.
		/// </summary>
		public void LoadContact(int contactId)
		{
			this.contactId = contactId;
			ReloadHeader();
			if (this.contact == null)
				return;
			LoadActivities();
			LoadDeals();
			LoadTasks();
		}

		private void ReloadHeader()
		{
			ContactDetail detail = null;
			if (!Notify.Try(() => detail = ContactService.Detail(this.contactId), "Loading the contact"))
				return;

			this.contact = detail;
			if (detail == null)
			{
				this.runName.Text = "Contact not found";
				this.labelTitleAt.Visible = false;
				this.labelOwner.Visible = false;
				this.avatar.Text = "?";
				this.tabControl.Enabled = false;
				foreach (var button in new[] { this.buttonLogActivity, this.buttonEdit, this.buttonNewDeal, this.buttonAddTask, this.buttonDelete })
					button.Enabled = false;
				return;
			}

			var name = string.IsNullOrEmpty(detail.FullName) ? "(No name)" : detail.FullName;
			this.avatar.Text = name;
			this.avatar.ImageSource = Avatars.Source(name, SettingsService.AvatarPalette[detail.Id % SettingsService.AvatarPalette.Length]);
			this.runName.Text = name;
			this.chipStage.Text = detail.Stage.ToString();
			this.chipStage.Tone = ToneExtensions.StageTone(detail.Stage).ToChip();

			var hasTitle = !string.IsNullOrEmpty(detail.Title);
			var hasCompany = detail.CompanyId != null && !string.IsNullOrEmpty(detail.CompanyName);
			this.runTitleAt.Text = hasTitle ? (hasCompany ? detail.Title + " at" : detail.Title) : (hasCompany ? "Works at" : "No title or company");
			this.linkCompany.Text = hasCompany ? detail.CompanyName : "";
			this.linkCompany.Enabled = hasCompany;
			this.labelOwner.Text = "Owner: " + (detail.OwnerName ?? "Unassigned");

			// Overview
			this.textBoxEmail.Text = detail.Email ?? "";
			this.textBoxPhone.Text = detail.Phone ?? "";
			this.textBoxCompany.Text = detail.CompanyName ?? "";
			this.textBoxJobTitle.Text = detail.Title ?? "";
			this.textBoxStage.Text = detail.Stage.ToString();
			this.textBoxLeadSource.Text = detail.LeadSource ?? "";
			this.textBoxOwner.Text = detail.OwnerName ?? "Unassigned";
			this.textBoxLastContacted.Text = detail.LastContacted == null
				? "Never"
				: Fmt.DateAndTime(detail.LastContacted.Value) + " (" + Fmt.Relative(detail.LastContacted) + ")";
			this.textBoxCreated.Text = Fmt.Date(detail.CreatedAt);
			var tags = RelayCrm.Text.Tags(detail.Tags);
			this.textBoxTags.Text = tags.Length == 0 ? "No tags" : string.Join(", ", tags);
		}

		private void LoadActivities()
		{
			List<ContactActivityItem> activities = null;
			if (!Notify.Try(() => activities = ContactService.Activities(this.contactId), "Loading the activities"))
				return;

			var now = DateTime.Now;
			this.timelineActivity.Items.Clear();
			foreach (var a in activities)
			{
				var meta = new List<string>();
				if (a.Duration > 0)
					meta.Add(a.Duration + " min");
				if (!string.IsNullOrEmpty(a.UserName))
					meta.Add("by " + a.UserName);

				var body = string.IsNullOrEmpty(a.Body) ? "" : a.Body + " · ";
				this.timelineActivity.Items.Add(new TimelineItem
				{
					Time = a.Date,
					Title = string.IsNullOrEmpty(a.Subject) ? a.Type.ToString() : a.Subject,
					Description = body + a.Type + (meta.Count > 0 ? " · " + string.Join(" · ", meta) : ""),
					Icon = ActivityLogService.Icon(a.Type),
					// planned activities stand out (the TitleBrush of the WPF template).
					Tone = a.Date > now ? TimelineTone.Primary : TimelineTone.Neutral,
					Tag = a.Id,
				});
			}

			this.emptyActivity.Visible = activities.Count == 0;
			this.tabActivity.Text = activities.Count == 0 ? "Activity" : "Activity (" + activities.Count + ")";
		}

		private void LoadDeals()
		{
			List<ContactDealItem> deals = null;
			if (!Notify.Try(() => deals = ContactService.Deals(this.contactId), "Loading the deals"))
				return;

			this.listDeals.DataSource = deals;
			this.emptyDeals.Visible = deals.Count == 0;
			this.tabDeals.Text = deals.Count == 0 ? "Deals" : "Deals (" + deals.Count + ")";
		}

		private void LoadTasks()
		{
			List<ContactTaskItem> tasks = null;
			if (!Notify.Try(() => tasks = ContactService.Tasks(this.contactId), "Loading the tasks"))
				return;

			this.gridTasks.DataSource = tasks;
			this.emptyTasks.Visible = tasks.Count == 0;
			var open = tasks.Count(t => t.Status != "Done");
			this.tabTasks.Text = open == 0 ? "Tasks" : "Tasks (" + open + ")";
		}

		private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Navigator.Back();
		}

		private void linkCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (this.contact?.CompanyId != null)
				Navigator.OpenCompany(this.contact.CompanyId.Value);
		}

		private void buttonLogActivity_Click(object sender, EventArgs e)
		{
			if (this.contact == null)
				return;
			if (LogActivityDialog.Log(this.contactId, this.contact.CompanyId))
			{
				ReloadHeader();
				LoadActivities();
				this.tabControl.SelectedTab = this.tabActivity;
			}
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (this.contact != null && ContactEditDialog.Edit(this.contactId))
				ReloadHeader();
		}

		private void buttonNewDeal_Click(object sender, EventArgs e)
		{
			if (this.contact == null)
				return;
			if (DealEditDialog.Edit(null, this.contact.CompanyId, this.contactId))
			{
				LoadDeals();
				this.tabControl.SelectedTab = this.tabDeals;
			}
		}

		private void buttonAddTask_Click(object sender, EventArgs e)
		{
			if (this.contact == null)
				return;
			if (TaskEditDialog.Edit(null, this.contactId))
			{
				LoadTasks();
				Navigator.RefreshBadges();
				this.tabControl.SelectedTab = this.tabTasks;
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (this.contact == null)
				return;
			if (!ConfirmDialog.Ask("Delete contact?",
				"Delete " + this.contact.FullName + "? Their activities, tasks and deals are kept without the contact.", "Delete"))
				return;

			if (Notify.Try(() => ContactService.Delete(this.contactId), "Deleting the contact"))
			{
				Notify.Success(this.contact.FullName + " deleted.");
				Navigator.Back();
			}
		}

		private void listDeals_ItemClick(object sender, ActionCardListItemEventArgs e)
		{
			if (e.DataItem is ContactDealItem deal && Navigator.OpenDeal(deal.Id) && !this.IsDisposed)
				LoadDeals();
		}

		private void gridTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (UiHelper.RowItem<ContactTaskItem>(this.gridTasks, e) is ContactTaskItem task && TaskEditDialog.Edit(task.Id))
			{
				LoadTasks();
				Navigator.RefreshBadges();
			}
		}
	}
}
