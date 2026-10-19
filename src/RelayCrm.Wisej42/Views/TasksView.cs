using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// Tasks grouped by Overdue, Today, This week, Later and Done; "My tasks" by default.
	/// </summary>
	public partial class TasksView : UserControl, IRefreshable
	{
		// height of a task row, of the card's padding, header row and border (see the designer).
		private const int RowHeight = 48;
		private const int CardChrome = 20 + 40 + 20 + 2;
		private const int CardGap = 16;

		private readonly Dictionary<TaskGroup, BindingList<TaskRow>> lists = new Dictionary<TaskGroup, BindingList<TaskRow>>();
		private readonly Dictionary<TaskGroup, DataGridView> grids;
		private readonly Dictionary<TaskGroup, Panel> panels;
		private readonly Dictionary<TaskGroup, ChipLabel> chips;

		public TasksView()
		{
			InitializeComponent();

			this.grids = new Dictionary<TaskGroup, DataGridView>
			{
				{ TaskGroup.Overdue, this.gridOverdue },
				{ TaskGroup.Today, this.gridToday },
				{ TaskGroup.ThisWeek, this.gridWeek },
				{ TaskGroup.Later, this.gridLater },
				{ TaskGroup.Done, this.gridDone },
			};
			this.panels = new Dictionary<TaskGroup, Panel>
			{
				{ TaskGroup.Overdue, this.panelOverdue },
				{ TaskGroup.Today, this.panelToday },
				{ TaskGroup.ThisWeek, this.panelWeek },
				{ TaskGroup.Later, this.panelLater },
				{ TaskGroup.Done, this.panelDone },
			};
			this.chips = new Dictionary<TaskGroup, ChipLabel>
			{
				{ TaskGroup.Overdue, this.chipOverdue },
				{ TaskGroup.Today, this.chipToday },
				{ TaskGroup.ThisWeek, this.chipWeek },
				{ TaskGroup.Later, this.chipLater },
				{ TaskGroup.Done, this.chipDone },
			};

			foreach (TaskGroup group in Enum.GetValues(typeof(TaskGroup)))
				this.lists[group] = new BindingList<TaskRow>();

			// no pre-selected first row in the group cards.
			foreach (var grid in this.grids.Values)
			{
				grid.DataBindingComplete += (s, e) =>
				{
					var g = (DataGridView)s;
					g.CurrentCell = null;
					g.ClearSelection();
				};
			}
		}

		/// <summary>True when only the tasks of the signed in user are shown.</summary>
		public bool MineOnly
		{
			get { return this.segmentedScope.SelectedIndex != 1; }
			set { this.segmentedScope.SelectedIndex = value ? 0 : 1; }
		}

		/// <summary>Reloads the tasks.</summary>
		public void RefreshData()
		{
			// raised by InitializeComponent before the view is ready.
			if (this.grids == null)
				return;

			List<TaskRow> rows = null;
			if (!Notify.Try(() => rows = TaskService.List(this.MineOnly), "Loading the tasks"))
				return;

			foreach (var group in this.grids.Keys)
			{
				this.lists[group] = new BindingList<TaskRow>(rows.Where(r => r.Group == group).ToList());
				this.grids[group].DataSource = this.lists[group];
				this.grids[group].CurrentCell = null;
				this.grids[group].ClearSelection();
			}

			UpdateLayout();
		}

		private void TasksView_Load(object sender, EventArgs e)
		{
			RefreshData();
		}

		// sizes each group card to its rows, hides the empty groups and updates the counters.
		private void UpdateLayout()
		{
			foreach (var group in this.grids.Keys)
			{
				var count = this.lists[group].Count;
				this.chips[group].Text = count.ToString();
				this.panels[group].Visible = count > 0;
				this.panels[group].Height = CardChrome + count * RowHeight + CardGap;
			}

			var open = this.lists.Where(l => l.Key != TaskGroup.Done).Sum(l => l.Value.Count);
			var overdue = this.lists[TaskGroup.Overdue].Count;
			this.labelCount.Text = open + " open" + (overdue > 0 ? " · " + overdue + " overdue" : "");
			this.emptyState.Visible = this.lists.Values.All(l => l.Count == 0);
		}

		// completes or reopens a task and moves its row to the new group without reloading the view.
		private void ToggleDone(TaskRow row)
		{
			var done = !row.Done;
			if (!Notify.Try(() => TaskService.SetDone(row.Id, done), done ? "Completing the task" : "Reopening the task"))
				return;

			var oldGroup = row.Group;
			row.Done = done;
			TaskService.Update(row);

			this.lists[oldGroup].Remove(row);
			var target = this.lists[row.Group];
			if (row.Group == TaskGroup.Done)
			{
				target.Insert(0, row);
				while (target.Count > TaskService.DoneLimit)
					target.RemoveAt(target.Count - 1);
			}
			else
			{
				var sorted = TaskService.Sort(target.Concat(new[] { row }));
				target.Insert(sorted.IndexOf(row), row);
			}

			UpdateLayout();
			Navigator.RefreshBadges();
			Notify.Success(done ? "Task completed." : "Task reopened.");
		}

		private void OpenRelated(TaskRow row)
		{
			if (row.DealId != null)
			{
				if (Navigator.OpenDeal(row.DealId.Value))
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

		private static TaskRow RowAt(object sender, DataGridViewCellEventArgs e)
		{
			var grid = (DataGridView)sender;
			if (e.RowIndex < 0 || e.RowIndex >= grid.Rows.Count)
				return null;
			return grid.Rows[e.RowIndex].DataBoundItem as TaskRow;
		}

		private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = RowAt(sender, e);
			if (row == null || e.ColumnIndex < 0)
				return;

			var column = ((DataGridView)sender).Columns[e.ColumnIndex];
			if (column is DataGridViewCheckBoxColumn)
				ToggleDone(row);
			else if (column is DataGridViewLinkColumn && !string.IsNullOrEmpty(row.RelatedText))
				OpenRelated(row);
		}

		private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = RowAt(sender, e);
			if (row == null || e.ColumnIndex < 0)
				return;

			var column = ((DataGridView)sender).Columns[e.ColumnIndex];
			if (column is DataGridViewCheckBoxColumn || column is DataGridViewLinkColumn)
				return;

			if (TaskEditDialog.Edit(row.Id))
				RefreshData();
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (TaskEditDialog.Edit(null))
				RefreshData();
		}

		private void segmentedScope_SelectedIndexChanged(object sender, EventArgs e)
		{
			RefreshData();
		}
	}
}
