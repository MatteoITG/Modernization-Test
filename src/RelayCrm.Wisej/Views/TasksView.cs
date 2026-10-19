using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using Wisej.Web;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// Tasks grouped by Overdue, Today, This week, Later and Done; "My tasks" by default.
	/// The check box of a task completes or reopens it.
	/// </summary>
	public partial class TasksView : UserControl, IRefreshable
	{
		private List<TaskRow> rows = new List<TaskRow>();

		// true while the list is filled: the check boxes raise ItemChecked.
		private bool loading;

		private Font doneFont;

		public TasksView()
		{
			InitializeComponent();

			IconImages.Apply(this.toolStrip);
			this.doneFont = new Font(this.listView.Font, FontStyle.Strikeout);
			this.Disposed += (s, e) => this.doneFont.Dispose();
		}

		/// <summary>True when only the tasks of the signed in user are shown.</summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public bool MineOnly
		{
			get { return this.buttonMine.Pushed; }
			set
			{
				this.buttonMine.Pushed = value;
				this.buttonEveryone.Pushed = !value;
			}
		}

		/// <summary>Reloads the tasks.</summary>
		public void RefreshData()
		{
			List<TaskRow> loaded = null;
			if (!Notify.Try(() => loaded = TaskService.List(this.MineOnly), "Loading the tasks"))
				return;

			this.rows = loaded;
			ShowRows();
		}

		private void TasksView_Load(object sender, EventArgs e)
		{
			RefreshData();
		}

		// Wisej: the ListView has no groups; a bold row before the tasks of a group is its header.
		private ListViewItem GroupHeader(TaskGroup group)
		{
			var count = this.rows.Count(r => r.Group == group);
			return new ListViewItem(TaskService.GroupText(group) + " (" + count + ")") { Font = new Font(this.listView.Font, FontStyle.Bold) };
		}

		// fills the list from the rows (already sorted by group and due date), keeping the selection.
		private void ShowRows()
		{
			var selectedId = SelectedRow?.Id;

			this.loading = true;
			this.listView.BeginUpdate();
			try
			{
				this.listView.Items.Clear();
				TaskGroup? group = null;
				foreach (var row in this.rows)
				{
					if (row.Group != group)
					{
						group = row.Group;
						this.listView.Items.Add(GroupHeader(row.Group));
					}
					var item = new ListViewItem(row.Title)
					{
						Tag = row,
						Checked = row.Done,
						ToolTipText = row.RelatedText,
					};
					item.SubItems.Add(row.PriorityText, row.PriorityTone.ToColor(), item.BackColor, item.Font);
					item.SubItems.Add(row.DueText, row.DueTone == Tone.Neutral ? this.listView.ForeColor : row.DueTone.ToColor(), item.BackColor, item.Font);
					item.SubItems.Add(row.AssigneeName);
					item.SubItems.Add(row.RelatedText);
					if (row.Done)
					{
						item.Font = this.doneFont;
						item.ForeColor = SystemColors.GrayText;
					}
					this.listView.Items.Add(item);
					if (row.Id == selectedId)
						item.Selected = true;
				}
			}
			finally
			{
				this.listView.EndUpdate();
				this.loading = false;
			}

			var open = this.rows.Count(r => !r.Done);
			var overdue = this.rows.Count(r => r.Group == TaskGroup.Overdue);
			this.labelCount.Text = open + " open" + (overdue > 0 ? " · " + overdue + " overdue" : "");
			this.emptyState.Visible = this.rows.Count == 0;
			UpdateButtons();
		}

		private TaskRow SelectedRow => this.listView.SelectedItems.Count > 0 ? this.listView.SelectedItems[0].Tag as TaskRow : null;

		private void UpdateButtons()
		{
			var row = this.SelectedRow;
			this.buttonEdit.Enabled = this.buttonDelete.Enabled = this.buttonComplete.Enabled = row != null;
			this.buttonComplete.Text = row?.Done == true ? "Reopen" : "Mark done";
		}

		// completes or reopens a task and moves it to its new group without reloading the list.
		private void ToggleDone(TaskRow row)
		{
			var done = !row.Done;
			if (!Notify.Try(() => TaskService.SetDone(row.Id, done), done ? "Completing the task" : "Reopening the task"))
			{
				ShowRows();
				return;
			}

			row.Done = done;
			TaskService.Update(row);

			// done tasks: the most recently completed first, as many as the service lists.
			this.rows.Remove(row);
			if (done)
			{
				var firstDone = this.rows.FindIndex(r => r.Group == TaskGroup.Done);
				this.rows.Insert(firstDone < 0 ? this.rows.Count : firstDone, row);
				var doneRows = this.rows.Where(r => r.Group == TaskGroup.Done).ToList();
				foreach (var extra in doneRows.Skip(TaskService.DoneLimit))
					this.rows.Remove(extra);
			}
			else
			{
				this.rows.Add(row);
				this.rows = TaskService.Sort(this.rows);
			}

			ShowRows();
			Navigator.RefreshBadges();
			Notify.Success(done ? "Task completed: " + row.Title : "Task reopened: " + row.Title);
		}

		private void OpenRelated(TaskRow row)
		{
			if (row.DealId != null)
			{
				if (Navigator.OpenDeal(row.DealId.Value) && !this.IsDisposed)
					RefreshData();
			}
			else if (row.ContactId != null)
			{
				Navigator.OpenContact(row.ContactId.Value);
			}
			else if (row.CompanyId != null)
			{
				Navigator.OpenCompany(row.CompanyId.Value);
			}
			else
			{
				Notify.Info("This task is not related to a record.");
			}
		}

		private void EditSelected()
		{
			var row = this.SelectedRow;
			if (row != null && TaskEditDialog.Edit(row.Id))
				RefreshData();
		}

		private void listView_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			if (this.loading || !(e.Item.Tag is TaskRow row) || row.Done == e.Item.Checked)
				return;

			// change the list after the check box finished its own update.
			BeginInvoke(new Action(() => ToggleDone(row)));
		}

		private void listView_ItemActivate(object sender, EventArgs e)
		{
			EditSelected();
		}

		private void listView_SelectedIndexChanged(object sender, EventArgs e)
		{
			UpdateButtons();
		}

		private void contextMenu_Opening(object sender, EventArgs e)
		{
			var row = this.SelectedRow;
			if (row == null)
			{
				return;
			}
			this.menuToggle.Text = row.Done ? "&Reopen" : "&Mark done";
			this.menuOpenRelated.Enabled = !string.IsNullOrEmpty(row.RelatedText);
		}

		private void menuEdit_Click(object sender, EventArgs e)
		{
			EditSelected();
		}

		private void menuOpenRelated_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null)
				OpenRelated(this.SelectedRow);
		}

		private void menuToggle_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null)
				ToggleDone(this.SelectedRow);
		}

		private void menuDelete_Click(object sender, EventArgs e)
		{
			var row = this.SelectedRow;
			if (row == null || !ConfirmDialog.Ask("Delete task", "Delete \"" + row.Title + "\"? This cannot be undone.", "Delete"))
				return;

			if (Notify.Try(() => TaskService.Delete(row.Id), "Deleting the task"))
			{
				Notify.Success("Task deleted.");
				Navigator.RefreshBadges();
				RefreshData();
			}
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (TaskEditDialog.Edit(null))
				RefreshData();
		}

		private void buttonScope_Click(object sender, EventArgs e)
		{
			var mine = sender == this.buttonMine;
			if (mine == this.MineOnly)
				return;

			this.MineOnly = mine;
			RefreshData();
		}
	}
}
