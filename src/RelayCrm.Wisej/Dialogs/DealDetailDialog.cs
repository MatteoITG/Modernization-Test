using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;
using RelayCrm.Data;
using RelayCrm.Services;

namespace RelayCrm.Dialogs
{
	/// <summary>
	/// A deal: header, stage path, fields, related contacts, activities and tasks.
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

			IconImages.Apply(this.toolStrip);
			this.listViewActivity.SmallImageList = IconImages.List(16, "telephone", "envelope", "people", "sticky");
			this.listViewTasks.SmallImageList = IconImages.List(16, "square", "check2-square", "exclamation-circle");
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
			this.Text = "Deal - " + deal.Title;
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
			this.labelStage.Text = deal.StageName;
			this.labelStage.ForeColor = ToneExtensions.DealStageTone(deal.IsWon, deal.IsLost).ToColor();
			this.labelOwner.Text = "Owner: " + deal.OwnerName;
		}

		/// <summary>
		/// The open stages in order and the closing step, as a text path: "✓ Qualification › ● Discovery › ○ Proposal › ...".
		/// </summary>
		private void ShowStages(DealDetail detail)
		{
			var deal = detail.Deal;
			var open = detail.Stages.Where(s => !s.IsWon && !s.IsLost).OrderBy(s => s.Order).ToList();
			var won = detail.Stages.FirstOrDefault(s => s.IsWon);
			var lost = detail.Stages.FirstOrDefault(s => s.IsLost);
			var current = open.FindIndex(s => s.Id == deal.StageId);

			var steps = new List<string>();
			for (var i = 0; i < open.Count; i++)
			{
				var mark = deal.IsWon || (!deal.IsLost && i < current) ? "✓" : !deal.IsLost && i == current ? "●" : "○";
				steps.Add(mark + " " + open[i].Name + " (" + open[i].Probability + "%)");
			}

			if (deal.IsLost)
				steps.Add("✗ " + (lost?.Name ?? "Lost") + (detail.ClosedDate == null ? "" : " on " + Fmt.Date(detail.ClosedDate.Value)));
			else
				steps.Add((deal.IsWon ? "✓ " : "○ ") + (won?.Name ?? "Won") + (deal.IsWon && detail.ClosedDate != null ? " on " + Fmt.Date(detail.ClosedDate.Value) : ""));

			this.labelStages.Text = string.Join("   ›   ", steps);
		}

		private void ShowFields(DealDetail detail)
		{
			var deal = detail.Deal;
			this.labelAmountValue.Text = deal.AmountText;
			this.labelCloseValue.Text = deal.IsOpen && deal.CloseTone != "Neutral"
				? deal.CloseText + "  (" + deal.CloseTag.Substring(deal.CloseTag.IndexOf('·') + 1).Trim() + ")"
				: deal.CloseText;
			this.labelCloseValue.ForeColor = deal.IsOpen ? ToneExtensions.ParseTone(deal.CloseTone).ToColor() : this.ForeColor;
			if (deal.IsOpen && deal.CloseTone == "Neutral")
				this.labelCloseValue.ForeColor = this.ForeColor;
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
			this.listViewContacts.BeginUpdate();
			this.listViewContacts.Items.Clear();
			foreach (var contact in detail.Contacts)
			{
				var item = new ListViewItem(contact.Name) { Tag = contact.Id };
				item.SubItems.Add(contact.Title ?? "");
				if (contact.Id == detail.Deal.ContactId)
					item.Font = new System.Drawing.Font(this.listViewContacts.Font, System.Drawing.FontStyle.Bold);
				this.listViewContacts.Items.Add(item);
			}
			this.listViewContacts.EndUpdate();
			this.listViewContacts.Visible = detail.Contacts.Count > 0;
			this.labelNoContacts.Visible = detail.Contacts.Count == 0;
		}

		private void ShowActivities(DealDetail detail)
		{
			this.listViewActivity.BeginUpdate();
			this.listViewActivity.Items.Clear();
			var now = DateTime.Now;
			foreach (var activity in detail.Activities)
			{
				var item = new ListViewItem(Fmt.DateAndTime(activity.Date), Icons.NameOf(ActivityLogService.Icon(activity.Type))) { Tag = activity.Id };
				item.SubItems.Add(activity.Type.ToString());
				item.SubItems.Add(activity.Subject ?? "");
				item.SubItems.Add(activity.UserName ?? "");
				item.SubItems.Add((activity.Body ?? "").Replace("\r", " ").Replace("\n", " "));
				item.ToolTipText = activity.Body;
				// planned activities stand out.
				if (activity.Date > now)
					item.ForeColor = Tone.Primary.ToColor();
				this.listViewActivity.Items.Add(item);
			}
			this.listViewActivity.EndUpdate();
			this.tabPageActivity.Text = detail.Activities.Count == 0 ? "Activity" : "Activity (" + detail.Activities.Count + ")";
		}

		private void ShowTasks(DealDetail detail)
		{
			this.listViewTasks.BeginUpdate();
			this.listViewTasks.Items.Clear();
			foreach (var task in detail.Tasks)
			{
				var item = new ListViewItem(task.Title, task.Done ? "check2-square" : task.Overdue ? "exclamation-circle" : "square") { Tag = task.Id };
				item.SubItems.Add(task.DueText);
				item.SubItems.Add(task.Priority.ToString());
				item.SubItems.Add(task.AssigneeName ?? "");
				if (task.Done)
					item.ForeColor = System.Drawing.SystemColors.GrayText;
				else if (task.Overdue)
					item.ForeColor = Tone.Danger.ToColor();
				this.listViewTasks.Items.Add(item);
			}
			this.listViewTasks.EndUpdate();
			var open = detail.Tasks.Count(t => !t.Done);
			this.tabPageTasks.Text = open == 0 ? "Tasks" : "Tasks (" + open + ")";
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
			{
				MarkChanged();
				this.tabControl.SelectedTab = this.tabPageActivity;
			}
		}

		private void buttonAddTask_Click(object sender, EventArgs e)
		{
			if (TaskEditDialog.Edit(null, null, null, this.dealId))
			{
				Navigator.RefreshBadges();
				MarkChanged();
				this.tabControl.SelectedTab = this.tabPageTasks;
			}
		}

		private void listViewTasks_ItemActivate(object sender, EventArgs e)
		{
			if (this.listViewTasks.SelectedItems.Count == 0)
				return;

			if (TaskEditDialog.Edit((int)this.listViewTasks.SelectedItems[0].Tag))
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

		private void listViewContacts_ItemActivate(object sender, EventArgs e)
		{
			if (this.listViewContacts.SelectedItems.Count == 0)
				return;

			var contactId = (int)this.listViewContacts.SelectedItems[0].Tag;
			this.afterClose = () => Navigator.OpenContact(contactId);
			Close();
		}

		private void DealDetailDialog_FormClosed(object sender, FormClosedEventArgs e)
		{
			var action = this.afterClose;
			this.afterClose = null;
			// after ShowDialog returned: the page opens behind no modal window.
			if (action != null)
				MainForm.Instance?.BeginInvoke(action);
		}
	}
}
