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
	/// The page of one contact: header with avatar, name, title at company, stage and owner,
	/// actions, and the Overview, Activity, Deals and Tasks tabs.
	/// </summary>
	public partial class ContactDetailView : UserControl
	{
		private int contactId;
		private ContactDetail contact;

		public ContactDetailView()
		{
			InitializeComponent();

			this.actionCardListDeals.DisplayMembers.Title = "Title";
			this.actionCardListDeals.DisplayMembers.Description = "Description";
			this.actionCardListDeals.DisplayMembers.Meta = "Meta";
			this.actionCardListDeals.DisplayMembers.Icon = "Icon";
			this.actionCardListDeals.DisplayMembers.IconTone = "IconTone";
			this.actionCardListDeals.DisplayMembers.Badge = "StageName";
			this.actionCardListDeals.DisplayMembers.BadgeTone = "StageTone";

			this.gridTasks.AutoGenerateColumns = false;
			this.colTaskStatus.ToneMap["Open"] = ChipTone.Primary;
			this.colTaskStatus.ToneMap["Overdue"] = ChipTone.Danger;
			this.colTaskStatus.ToneMap["Done"] = ChipTone.Success;
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

		private void ReloadHeader()
		{
			ContactDetail detail = null;
			if (!Notify.Try(() => detail = ContactService.Detail(this.contactId), "Loading the contact"))
				return;

			this.contact = detail;
			if (detail == null)
			{
				this.labelName.Text = "Contact not found";
				this.flexTitle.Visible = false;
				this.flexOwner.Visible = false;
				this.chipStage.Visible = false;
				this.tabControl.Enabled = false;
				foreach (var button in new[] { this.buttonLogActivity, this.buttonEdit, this.buttonNewDeal, this.buttonAddTask, this.buttonDelete })
					button.Enabled = false;
				return;
			}

			var name = string.IsNullOrEmpty(detail.FullName) ? "(No name)" : detail.FullName;
			this.avatar.Text = name;
			this.labelName.Text = name;

			this.chipStage.Text = detail.Stage.ToString();
			this.chipStage.Tone = StageTone(detail.Stage);

			var hasTitle = !string.IsNullOrEmpty(detail.Title);
			var hasCompany = detail.CompanyId != null && !string.IsNullOrEmpty(detail.CompanyName);
			this.labelTitleAt.Text = hasTitle ? (hasCompany ? detail.Title + " at" : detail.Title) : (hasCompany ? "Works at" : "No title or company");
			this.linkCompany.Text = hasCompany ? detail.CompanyName : "";
			this.linkCompany.Visible = hasCompany;

			this.avatarOwner.Text = detail.OwnerName ?? "";
			this.avatarOwner.Label = detail.OwnerName ?? "Unassigned";
			this.avatarOwner.Visible = true;

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

			this.flowTags.Controls.Clear(true);
			var tags = RelayCrm.Text.Tags(detail.Tags);
			if (tags.Length == 0)
			{
				this.flowTags.Controls.Add(new Label { Text = "No tags", AutoSize = true, CssClass = "relay-muted" });
			}
			else
			{
				foreach (var tag in tags)
				{
					this.flowTags.Controls.Add(new ChipLabel
					{
						Text = tag,
						Tone = ChipTone.Primary,
						Variant = ChipVariant.Soft,
						ChipSize = ChipSize.Small,
						AutoSize = true,
						Margin = new Padding(0, 0, 8, 8),
					});
				}
			}
		}

		private static ChipTone StageTone(LifecycleStage stage)
		{
			switch (stage)
			{
				case LifecycleStage.Prospect: return ChipTone.Warning;
				case LifecycleStage.Customer: return ChipTone.Success;
				case LifecycleStage.Churned: return ChipTone.Danger;
				default: return ChipTone.Neutral;
			}
		}

		private static TimelineTone ActivityTone(ActivityType type)
		{
			switch (type)
			{
				case ActivityType.Call: return TimelineTone.Primary;
				case ActivityType.Meeting: return TimelineTone.Success;
				case ActivityType.Email: return TimelineTone.Warning;
				default: return TimelineTone.Neutral;
			}
		}

		private void LoadActivities()
		{
			List<ContactActivityItem> activities = null;
			if (!Notify.Try(() => activities = ContactService.Activities(this.contactId), "Loading the activities"))
				return;

			this.timeline.Items.Clear();
			foreach (var a in activities)
			{
				var meta = new List<string>();
				if (a.Duration > 0)
					meta.Add(a.Duration + " min");
				if (!string.IsNullOrEmpty(a.UserName))
					meta.Add("by " + a.UserName);

				var description = a.Body ?? "";
				if (meta.Count > 0)
					description = (description.Length > 0 ? description + "\n" : "") + a.Type + " · " + string.Join(" · ", meta);

				this.timeline.Items.Add(new TimelineItem(a.Date, string.IsNullOrEmpty(a.Subject) ? a.Type.ToString() : a.Subject)
				{
					Description = description,
					Icon = ActivityLogService.Icon(a.Type),
					Tone = ActivityTone(a.Type),
					Tag = a.Id,
				});
			}

			this.timeline.Visible = activities.Count > 0;
			this.emptyStateActivity.Visible = activities.Count == 0;
			this.tabPageActivity.Text = activities.Count == 0 ? "Activity" : "Activity (" + activities.Count + ")";
		}

		private void LoadDeals()
		{
			List<ContactDealItem> deals = null;
			if (!Notify.Try(() => deals = ContactService.Deals(this.contactId), "Loading the deals"))
				return;

			this.actionCardListDeals.DataSource = deals;
			this.actionCardListDeals.Visible = deals.Count > 0;
			this.emptyStateDeals.Visible = deals.Count == 0;
			this.tabPageDeals.Text = deals.Count == 0 ? "Deals" : "Deals (" + deals.Count + ")";
		}

		private void LoadTasks()
		{
			List<ContactTaskItem> tasks = null;
			if (!Notify.Try(() => tasks = ContactService.Tasks(this.contactId), "Loading the tasks"))
				return;

			this.gridTasks.DataSource = tasks;
			this.emptyStateTasks.RefreshTarget();
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
			if (!ConfirmDialog.Ask("Delete contact?",
				"Delete " + this.contact.FullName + "? Their activities, tasks and deals are kept without the contact.", "Delete"))
				return;

			if (Notify.Try(() => ContactService.Delete(this.contactId), "Deleting the contact"))
			{
				Notify.Success(this.contact.FullName + " deleted.");
				Navigator.Back();
			}
		}

		private void actionCardListDeals_ItemClick(object sender, ActionCardListItemEventArgs e)
		{
			if (e.DataItem is ContactDealItem deal && Navigator.OpenDeal(deal.Id))
				LoadDeals();
		}

		private void gridTasks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.RowIndex >= this.gridTasks.RowCount)
				return;
			if (this.gridTasks.Rows[e.RowIndex].DataBoundItem is ContactTaskItem task && TaskEditDialog.Edit(task.Id))
			{
				LoadTasks();
				Navigator.RefreshBadges();
			}
		}
	}
}
