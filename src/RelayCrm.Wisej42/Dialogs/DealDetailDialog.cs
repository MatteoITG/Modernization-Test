using System;
using System.Linq;
using RelayCrm.Data;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// A deal: header, stage progress, fields, related contacts, activity timeline and tasks.
	/// Opened by <see cref="Navigator.OpenDeal"/>.
	/// </summary>
	public partial class DealDetailDialog : Form
	{
		private int dealId;
		private DealDetail detail;

		// navigation to run once the dialog is closed (company or contact page).
		private Action afterClose;

		public DealDetailDialog()
		{
			InitializeComponent();
		}

		/// <summary>True when anything was changed while the dialog was open.</summary>
		public bool Changed { get; private set; }

		/// <summary>Loads the deal to show.</summary>
		public void LoadDeal(int dealId)
		{
			this.dealId = dealId;
			Reload();
		}

		private void Reload()
		{
			DealDetail loaded = null;
			if (!Notify.Try(() => loaded = DealService.Detail(this.dealId), "Loading the deal"))
				return;

			this.detail = loaded;
			if (loaded == null)
			{
				this.Text = "Deal not found";
				this.labelTitle.Text = "This deal no longer exists.";
				this.buttonEdit.Enabled = this.buttonDelete.Enabled = this.buttonLogActivity.Enabled = this.buttonAddTask.Enabled = false;
				return;
			}

			var deal = loaded.Deal;
			this.Text = "Deal · " + deal.Title;
			ShowHeader(deal);
			ShowStages(loaded);
			ShowFields(loaded);
			ShowContacts(loaded);
			ShowActivities(loaded);
			ShowTasks(loaded);
		}

		private void ShowHeader(DealRow deal)
		{
			this.labelTitle.Text = deal.Title;
			this.linkCompany.Text = string.IsNullOrEmpty(deal.CompanyName) ? "No company" : deal.CompanyName;
			this.linkCompany.Enabled = deal.CompanyId != null;
			this.labelAmount.Text = deal.AmountText;
			this.chipStage.Text = deal.StageName;
			this.chipStage.Tone = deal.IsWon ? ChipTone.Success : deal.IsLost ? ChipTone.Danger : deal.StageName == "Negotiation" ? ChipTone.Warning : ChipTone.Primary;
			this.avatarOwner.Text = deal.OwnerName;
			this.avatarOwner.Label = deal.OwnerName;
		}

		/// <summary>Open stages in order and the closing step: Won, or Lost in the Error state.</summary>
		private void ShowStages(DealDetail detail)
		{
			var deal = detail.Deal;
			var open = detail.Stages.Where(s => !s.IsWon && !s.IsLost).OrderBy(s => s.Order).ToList();
			var won = detail.Stages.FirstOrDefault(s => s.IsWon);
			var lost = detail.Stages.FirstOrDefault(s => s.IsLost);

			this.stepper.Steps.Clear();
			var current = open.FindIndex(s => s.Id == deal.StageId);
			for (var i = 0; i < open.Count; i++)
			{
				this.stepper.Steps.Add(new Step
				{
					Text = open[i].Name,
					Description = open[i].Probability + "%",
					State = deal.IsWon ? StepState.Completed
						: deal.IsLost ? StepState.Skipped
						: i < current ? StepState.Completed
						: i == current ? StepState.Active
						: StepState.Pending,
				});
			}

			if (deal.IsLost)
			{
				this.stepper.Steps.Add(new Step
				{
					Text = lost?.Name ?? "Lost",
					Description = detail.ClosedDate == null ? "" : Fmt.Date(detail.ClosedDate.Value),
					State = StepState.Error,
				});
				this.stepper.ActiveIndex = this.stepper.Steps.Count - 1;
			}
			else
			{
				this.stepper.Steps.Add(new Step
				{
					Text = won?.Name ?? "Won",
					Description = deal.IsWon && detail.ClosedDate != null ? Fmt.Date(detail.ClosedDate.Value) : "100%",
					State = deal.IsWon ? StepState.Completed : StepState.Pending,
				});
				this.stepper.ActiveIndex = deal.IsWon ? this.stepper.Steps.Count - 1 : Math.Max(0, current);
			}
		}

		private void ShowFields(DealDetail detail)
		{
			var deal = detail.Deal;
			this.labelAmountValue.Text = deal.AmountText;
			this.labelCloseValue.Text = deal.IsOpen && deal.CloseTone != "Neutral"
				? deal.CloseText + "  (" + deal.CloseTag.Substring(deal.CloseTag.IndexOf('·') + 1).Trim() + ")"
				: deal.CloseText;
			this.labelProbabilityValue.Text = deal.Probability + "%";
			this.linkContact.Text = string.IsNullOrEmpty(deal.ContactName) ? "None" : deal.ContactName;
			this.linkContact.Enabled = deal.ContactId != null;
			this.labelCreatedValue.Text = Fmt.Date(detail.CreatedAt);

			var closed = !deal.IsOpen && detail.ClosedDate != null;
			this.labelCapClosed.Visible = this.labelClosedValue.Visible = closed;
			this.labelClosedValue.Text = closed ? Fmt.Date(detail.ClosedDate.Value) : "";

			this.labelCapLost.Visible = this.labelLostValue.Visible = deal.IsLost;
			this.labelLostValue.Text = string.IsNullOrEmpty(detail.LostReason) ? "Not given" : detail.LostReason;
		}

		private void ShowContacts(DealDetail detail)
		{
			this.avatarGroupContacts.Items.Clear();
			foreach (var contact in detail.Contacts)
			{
				this.avatarGroupContacts.Items.Add(new AvatarItem
				{
					Text = contact.Name,
					Label = contact.Name,
					SubLabel = contact.Title,
					AutoColor = true,
					Tag = contact.Id,
				});
			}
			this.avatarGroupContacts.Visible = detail.Contacts.Count > 0;
			this.labelNoContacts.Visible = detail.Contacts.Count == 0;
		}

		private void ShowActivities(DealDetail detail)
		{
			this.timeline.Items.Clear();
			foreach (var activity in detail.Activities)
			{
				var description = activity.Type + (string.IsNullOrEmpty(activity.UserName) ? "" : " · " + activity.UserName);
				if (!string.IsNullOrWhiteSpace(activity.Body))
					description += "\n" + (activity.Body.Length > 160 ? activity.Body.Substring(0, 160) + "…" : activity.Body);

				this.timeline.Items.Add(new TimelineItem
				{
					Time = activity.Date,
					Title = activity.Subject,
					Description = description,
					Icon = ActivityLogService.Icon(activity.Type),
					Tone = activity.Date > DateTime.Now ? TimelineTone.Primary : TimelineTone.Neutral,
					Tag = activity.Id,
				});
			}
			this.emptyStateActivity.Visible = detail.Activities.Count == 0;
		}

		private void ShowTasks(DealDetail detail)
		{
			this.actionCardListTasks.DataSource = detail.Tasks;
			this.emptyStateTasks.Visible = detail.Tasks.Count == 0;
		}

		private void MarkChanged()
		{
			this.Changed = true;
			Reload();
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			if (DealEditDialog.Edit(this.dealId))
				MarkChanged();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (this.detail == null)
				return;

			if (!ConfirmDialog.Ask("Delete deal", "Delete \"" + this.detail.Deal.Title + "\"? Its activities and tasks are kept.", "Delete"))
				return;

			if (Notify.Try(() => DealService.Delete(this.dealId), "Deleting the deal"))
			{
				Notify.Success("Deal deleted.");
				this.Changed = true;
				Close();
			}
		}

		private void buttonLogActivity_Click(object sender, EventArgs e)
		{
			if (this.detail == null)
				return;

			if (LogActivityDialog.Show(this.detail.Deal.ContactId, this.detail.Deal.CompanyId, this.dealId))
				MarkChanged();
		}

		private void buttonAddTask_Click(object sender, EventArgs e)
		{
			if (TaskEditDialog.Edit(null, null, null, this.dealId))
			{
				Navigator.RefreshBadges();
				MarkChanged();
			}
		}

		private void actionCardListTasks_ItemClick(object sender, ActionCardListItemEventArgs e)
		{
			if (e.DataItem is DealTaskItem task && TaskEditDialog.Edit(task.Id))
			{
				Navigator.RefreshBadges();
				MarkChanged();
			}
		}

		private void linkCompany_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var companyId = this.detail?.Deal.CompanyId;
			if (companyId == null)
				return;

			this.afterClose = () => Navigator.OpenCompany(companyId.Value);
			Close();
		}

		private void linkContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			var contactId = this.detail?.Deal.ContactId;
			if (contactId == null)
				return;

			this.afterClose = () => Navigator.OpenContact(contactId.Value);
			Close();
		}

		private void avatarGroupContacts_ItemClick(object sender, AvatarItemEventArgs e)
		{
			if (!(e.Item?.Tag is int contactId))
				return;

			this.afterClose = () => Navigator.OpenContact(contactId);
			Close();
		}

		private void DealDetailDialog_FormClosed(object sender, FormClosedEventArgs e)
		{
			var action = this.afterClose;
			this.afterClose = null;
			action?.Invoke();
		}
	}
}
