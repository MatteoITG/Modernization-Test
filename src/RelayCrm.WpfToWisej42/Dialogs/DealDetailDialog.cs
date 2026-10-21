using System;
using System.Linq;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// A deal: header, stage progress, fields, related contacts, activity timeline and tasks.
	/// Opened by <see cref="Navigator.OpenDeal"/>.
	/// </summary>
	/// <remarks>
	/// Migration step 2: the stage progress (an ItemsControl with a UniformGrid, then a TableLayoutPanel of labels) is a
	/// Wisej 4.2 Stepper; the stage text is a ChipLabel, the HTML lists of contacts and tasks ActionCardLists, the
	/// activity list a Timeline, and the empty labels EmptyStates.
	/// </remarks>
	public partial class DealDetailDialog : Form
	{
		private int dealId;
		private DealDetail detail;

		// navigation to run once the dialog is closed (company or contact page).
		private Action afterClose;

		public DealDetailDialog()
		{
			InitializeComponent();

			// the cards show these properties of DealContactItem and DealTaskItem (the XAML item templates).
			this.listContacts.DisplayMembers.Title = "Name";
			this.listContacts.DisplayMembers.Description = "Title";
			this.listTasks.DisplayMembers.Title = "Title";
			this.listTasks.DisplayMembers.Description = "DueText";
			this.listTasks.DisplayMembers.Meta = "AssigneeName";
			this.listTasks.DisplayMembers.Icon = "Icon";
		}

		/// <summary>True when anything was changed while the dialog was open.</summary>
		public bool Changed { get; private set; }

		/// <summary>Loads the deal to show.</summary>
		public void LoadDeal(int dealId)
		{
			this.dealId = dealId;
			Reload();
		}

		/// <summary>Runs the navigation the user asked for (company, contact) after the dialog closed.</summary>
		public void RunAfterClose()
		{
			var action = this.afterClose;
			this.afterClose = null;
			action?.Invoke();
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
				this.linkCompany.Enabled = this.linkContact.Enabled = false;
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
			this.runAmount.Text = deal.AmountText;
			this.chipStage.Text = deal.StageName;
			this.chipStage.Tone = (deal.StageName == "Negotiation" && deal.IsOpen ? Tone.Warning : ToneExtensions.DealStageTone(deal.IsWon, deal.IsLost)).ToChip();
			this.runOwner.Text = deal.OwnerName;
		}

		/// <summary>Open stages in order and the closing step: Won, or Lost in red, as the steps of the stepper.</summary>
		private void ShowStages(DealDetail detail)
		{
			var deal = detail.Deal;
			var open = detail.Stages.Where(s => !s.IsWon && !s.IsLost).OrderBy(s => s.Order).ToList();
			var won = detail.Stages.FirstOrDefault(s => s.IsWon);
			var lost = detail.Stages.FirstOrDefault(s => s.IsLost);
			var current = open.FindIndex(s => s.Id == deal.StageId);

			this.stepperStages.Steps.Clear();
			for (var i = 0; i < open.Count; i++)
			{
				// a lost deal skips the open stages (they were struck through in WPF).
				var state = deal.IsWon || (!deal.IsLost && i < current) ? StepState.Completed
					: deal.IsLost ? StepState.Skipped
					: i == current ? StepState.Active
					: StepState.Pending;
				this.stepperStages.Steps.Add(new Step { Text = open[i].Name, Description = open[i].Probability + "%", State = state });
			}

			if (deal.IsLost)
				this.stepperStages.Steps.Add(new Step { Text = lost?.Name ?? "Lost", Description = detail.ClosedDate == null ? "" : Fmt.Date(detail.ClosedDate.Value), State = StepState.Error });
			else
				this.stepperStages.Steps.Add(new Step
				{
					Text = won?.Name ?? "Won",
					Description = deal.IsWon && detail.ClosedDate != null ? Fmt.Date(detail.ClosedDate.Value) : "100%",
					State = deal.IsWon ? StepState.Completed : StepState.Pending,
				});

			this.stepperStages.ActiveIndex = deal.IsWon || deal.IsLost ? open.Count : Math.Max(0, current);
		}

		private void ShowFields(DealDetail detail)
		{
			var deal = detail.Deal;
			this.labelAmountValue.Text = deal.AmountText;
			this.labelCloseValue.Text = deal.IsOpen && deal.CloseTone != "Neutral"
				? deal.CloseText + "  (" + deal.CloseTag.Substring(deal.CloseTag.IndexOf('·') + 1).Trim() + ")"
				: deal.CloseText;
			this.labelCloseValue.ForeColor = deal.IsOpen && deal.CloseTone != "Neutral" ? ToneExtensions.ParseTone(deal.CloseTone).ToColor() : System.Drawing.Color.Empty;
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
			this.listContacts.DataSource = detail.Contacts;
			this.listContacts.Visible = detail.Contacts.Count > 0;
			this.emptyContacts.Visible = detail.Contacts.Count == 0;
		}

		private void ShowActivities(DealDetail detail)
		{
			var now = DateTime.Now;
			this.timelineActivity.Items.Clear();
			foreach (var a in detail.Activities)
			{
				var description = a.Type + (string.IsNullOrEmpty(a.UserName) ? "" : " · " + a.UserName);
				if (!string.IsNullOrWhiteSpace(a.Body))
					description += " · " + (a.Body.Length > 160 ? a.Body.Substring(0, 160) + "…" : a.Body);
				this.timelineActivity.Items.Add(new TimelineItem
				{
					Time = a.Date,
					Title = a.Subject,
					Description = description,
					Icon = ActivityLogService.Icon(a.Type),
					// planned activities stand out (the TitleBrush of the WPF template).
					Tone = a.Date > now ? TimelineTone.Primary : TimelineTone.Neutral,
					Tag = a.Id,
				});
			}
			this.emptyActivity.Visible = detail.Activities.Count == 0;
			this.tabActivity.Text = detail.Activities.Count == 0 ? "Activity" : "Activity (" + detail.Activities.Count + ")";
		}

		private void ShowTasks(DealDetail detail)
		{
			this.listTasks.DataSource = detail.Tasks;
			this.emptyTasks.Visible = detail.Tasks.Count == 0;
			var open = detail.Tasks.Count(t => !t.Done);
			this.tabTasks.Text = open == 0 ? "Tasks" : "Tasks (" + open + ")";
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

			if (LogActivityDialog.Log(this.detail.Deal.ContactId, this.detail.Deal.CompanyId, this.dealId))
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

		private void buttonClose_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void listTasks_ItemClick(object sender, ActionCardListItemEventArgs e)
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

		private void listContacts_ItemClick(object sender, ActionCardListItemEventArgs e)
		{
			if (!(e.DataItem is DealContactItem contact))
				return;

			var contactId = contact.Id;
			this.afterClose = () => Navigator.OpenContact(contactId);
			Close();
		}
	}
}
