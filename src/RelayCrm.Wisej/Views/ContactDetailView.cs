using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// The page of one contact: header with avatar, name, title at company, stage and owner,
	/// actions, and the Overview, Activity, Deals and Tasks tabs.
	/// </summary>
	public partial class ContactDetailView : UserControl, IRefreshable
	{
		private int contactId;
		private ContactDetail contact;

		public ContactDetailView()
		{
			InitializeComponent();

			this.gridTasks.AutoGenerateColumns = false;
			IconImages.Apply(this.toolStrip);
			IconImages.Apply(this.activityStrip);
			IconImages.Apply(this.dealsStrip);
			IconImages.Apply(this.tasksStrip);
			ToneExtensions.AddTaskStatusTones(this.colTaskStatus.ToneMap);

			// the deal cards show these properties of ContactDealItem.
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
			LoadActivities();
			LoadDeals();
			LoadTasks();
		}

		/// <summary>Reloads the contact (F5).</summary>
		public void RefreshData()
		{
			LoadContact(this.contactId);
		}

		private void ReloadHeader()
		{
			ContactDetail detail = null;
			if (!Notify.Try(() => detail = ContactService.Detail(this.contactId), "Loading the contact"))
				return;

			this.contact = detail;
			if (detail == null)
			{
				this.labelName.Text = "Contact not found";
				this.flowSubtitle.Visible = false;
				this.tabControl.Enabled = false;
				foreach (ToolBarButton item in this.toolStrip.Buttons)
					item.Enabled = false;
				return;
			}

			var name = string.IsNullOrEmpty(detail.FullName) ? "(No name)" : detail.FullName;
			this.labelName.Text = name;
			this.avatar.Text = RelayCrm.Text.Initials(name);
			this.avatar.ImageSource = Avatars.Source(name, SettingsService.AvatarPalette[detail.Id % SettingsService.AvatarPalette.Length]);

			var hasTitle = !string.IsNullOrEmpty(detail.Title);
			var hasCompany = detail.CompanyId != null && !string.IsNullOrEmpty(detail.CompanyName);
			this.labelTitleAt.Text = hasTitle ? (hasCompany ? detail.Title + " at" : detail.Title) : (hasCompany ? "Works at" : "No title or company");
			this.linkCompany.Text = hasCompany ? detail.CompanyName : "";
			this.linkCompany.Visible = hasCompany;

			this.chipStage.Text = detail.Stage.ToString();
			this.chipStage.Tone = ToneExtensions.StageTone(detail.Stage).ToChip();
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
				this.timelineActivity.Items.Add(new TimelineItem
				{
					Time = a.Date,
					Title = string.IsNullOrEmpty(a.Subject) ? a.Type.ToString() : a.Subject,
					Description = a.Type + (a.Duration > 0 ? " · " + a.Duration + " min" : "") + " · " + (a.UserName ?? "")
						+ (string.IsNullOrEmpty(a.Body) ? "" : " · " + a.Body),
					Icon = ActivityLogService.Icon(a.Type),
					// planned activities stand out.
					Tone = a.Date > now ? TimelineTone.Primary : TimelineTone.Neutral,
					Tag = a.Id,
				});
			}

			this.emptyActivity.Visible = activities.Count == 0;
			this.tabPageActivity.Text = activities.Count == 0 ? "Activity" : "Activity (" + activities.Count + ")";
		}

		private void LoadDeals()
		{
			List<ContactDealItem> deals = null;
			if (!Notify.Try(() => deals = ContactService.Deals(this.contactId), "Loading the deals"))
				return;

			this.listDeals.DataSource = deals;
			this.emptyDeals.Visible = deals.Count == 0;
			this.tabPageDeals.Text = deals.Count == 0 ? "Deals" : "Deals (" + deals.Count + ")";
		}

		private void LoadTasks()
		{
			List<ContactTaskItem> tasks = null;
			if (!Notify.Try(() => tasks = ContactService.Tasks(this.contactId), "Loading the tasks"))
				return;

			this.gridTasks.DataSource = tasks;
			this.emptyTasks.Visible = tasks.Count == 0;
			var open = tasks.Count(t => t.Status != "Done");
			this.tabPageTasks.Text = open == 0 ? "Tasks" : "Tasks (" + open + ")";
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
			if (LogActivityDialog.Show(this.contactId, this.contact.CompanyId))
			{
				ReloadHeader();
				LoadActivities();
				this.tabControl.SelectedTab = this.tabPageActivity;
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
				this.tabControl.SelectedTab = this.tabPageDeals;
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
				this.tabControl.SelectedTab = this.tabPageTasks;
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (this.contact == null)
				return;
			if (!ConfirmDialog.Ask("Delete contact",
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
			if (!(e.DataItem is ContactDealItem deal))
				return;
			if (Navigator.OpenDeal(deal.Id) && !this.IsDisposed)
				LoadDeals();
		}

		private void gridTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var task = GridHelper.RowAt<ContactTaskItem>(this.gridTasks, e.RowIndex);
			if (task != null && TaskEditDialog.Edit(task.Id))
			{
				LoadTasks();
				Navigator.RefreshBadges();
			}
		}

	}
}
