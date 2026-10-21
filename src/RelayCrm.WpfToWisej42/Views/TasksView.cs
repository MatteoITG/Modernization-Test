using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// Tasks grouped by Overdue, Today, This week, Later and Done; "My tasks" by default.
	/// </summary>
	/// <remarks>
	/// The cell templates of the group grids became columns: a check box column for Done, a link column for the
	/// related record, tone colours in the column Tag (<see cref="GridHelper"/>) and the strikethrough of done tasks
	/// in the CellFormatting event.
	/// Migration step 2: the groups are cards, the priority a chip column, the assignee an avatar column, the
	/// My tasks/Everybody's radio buttons a SegmentedButton and the empty panel an EmptyState.
	/// </remarks>
	public partial class TasksView : UserControl, IRefreshable
	{
		private bool ready;

		public TasksView()
		{
			InitializeComponent();

			this.ready = true;
			RefreshData();
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
			if (!this.ready)
				return;

			List<TaskRow> rows = null;
			if (!Notify.Try(() => rows = TaskService.List(this.MineOnly), "Loading the tasks"))
				return;

			var offset = this.panelGroups.VerticalScroll.Value;
			this.panelGroups.SuspendLayout();
			while (this.panelGroups.Controls.Count > 0)
				this.panelGroups.Controls[0].Dispose();
			foreach (TaskGroup group in Enum.GetValues(typeof(TaskGroup)))
			{
				var list = rows.Where(r => r.Group == group).ToList();
				if (list.Count == 0)
					continue;

				var box = new GroupBox
				{
					AllowHtml = true,
					Text = TemplateItem.Run(
						TaskService.GroupText(group) + " (" + list.Count + ")",
						bold: true,
						color: group == TaskGroup.Overdue ? Tone.Danger.ToColor() : Color.Empty),
					CssClass = "relay-card",
					Margin = new Padding(0, 0, 0, 10),
					Padding = new Padding(8, 4, 8, 8),
					Dock = DockStyle.Top,
				};
				// the WPF grid measured its rows; here the group gets the height of all its rows.
				var grid = CreateGrid(list);
				box.Height = grid.Height + 36;
				box.Controls.Add(grid);
				// docked controls stack from the last one added: each group goes under the previous ones.
				this.panelGroups.Controls.Add(box);
				box.BringToFront();
			}
			this.panelGroups.ResumeLayout(true);
			this.panelGroups.VerticalScroll.Value = offset;

			var open = rows.Count(r => r.Group != TaskGroup.Done);
			var overdue = rows.Count(r => r.Group == TaskGroup.Overdue);
			this.labelCount.Text = open + " open" + (overdue > 0 ? " · " + overdue + " overdue" : "");
			this.emptyState.Visible = rows.Count == 0;
			if (rows.Count == 0)
				this.emptyState.BringToFront();
		}

		// a grid with all the rows of a group: it does not scroll, the page does.
		private DataGridView CreateGrid(List<TaskRow> rows)
		{
			var grid = new DataGridView
			{
				AutoGenerateColumns = false,
				ReadOnly = true,
				MultiSelect = false,
				RowHeadersVisible = false,
				SelectionMode = DataGridViewSelectionMode.FullRowSelect,
				ShowColumnVisibilityMenu = false,
				AllowUserToResizeRows = false,
				KeepSameRowHeight = true,
				ScrollBars = ScrollBars.None,
				BorderStyle = BorderStyle.None,
				Dock = DockStyle.Top,
				ToolTipText = "Double-click to edit the task",
			};
			// the FluentLight theme draws rows 32 px high (WPF: 24); step 2: 40 px for the avatars of the assignees.
			// The group is sized for the rows the grid draws.
			grid.CssClass = "relay-grid";
			grid.RowTemplate.Height = 40;
			grid.ColumnHeadersHeight = 32;
			grid.Height = grid.ColumnHeadersHeight + rows.Count * grid.RowTemplate.Height + 4;
			grid.Columns.Add(new DataGridViewCheckBoxColumn { Name = "colDone", HeaderText = "Done", DataPropertyName = "Done", Width = 46, ToolTipText = "Complete or reopen the task" });
			grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "colTitle", HeaderText = "Task", DataPropertyName = "Title", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 250, MinimumWidth = 150 });
			grid.Columns.Add(new DataGridViewLinkColumn { Name = "colRelated", HeaderText = "Related to", DataPropertyName = "RelatedText", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 200 });
			grid.Columns.Add(new DataGridViewTextBoxColumn { Name = "colDue", HeaderText = "Due", DataPropertyName = "DueText", Width = 110, Tag = "ToneOf:DueTone" });
			var priority = new DataGridViewChipColumn { Name = "colPriority", HeaderText = "Priority", DataPropertyName = "PriorityText", Width = 100, Variant = ChipVariant.Soft };
			ToneExtensions.AddPriorityTones(priority.ToneMap);
			grid.Columns.Add(priority);
			grid.Columns.Add(new DataGridViewAvatarColumn { Name = "colAssignee", HeaderText = "Assignee", DataPropertyName = "AssigneeName", TextMember = "AssigneeName", AutoColor = true, AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 120 });
			grid.DataSource = rows;
			GridHelper.UseConverters(grid);
			grid.CellFormatting += grid_CellFormatting;
			grid.CellClick += grid_CellClick;
			grid.CellDoubleClick += grid_CellDoubleClick;
			return grid;
		}

		// completes or reopens a task and shows it in its new group.
		private void ToggleDone(TaskRow row)
		{
			var done = !row.Done;
			if (!Notify.Try(() => TaskService.SetDone(row.Id, done), done ? "Completing the task" : "Reopening the task"))
				return;

			RefreshData();
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

		// the title of a done task is struck through and muted (the DataTrigger of the TitleTemplate).
		private void grid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var grid = (DataGridView)sender;
			if (e.RowIndex < 0 || grid.Columns[e.ColumnIndex].Name != "colTitle")
				return;
			if (grid.Rows[e.RowIndex].DataBoundItem is TaskRow row && row.Done)
			{
				e.CellStyle.Font = new Font(grid.Font, FontStyle.Strikeout);
				e.CellStyle.ForeColor = ToneExtensions.MutedColor;
			}
		}

		private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			var grid = (DataGridView)sender;
			if (e.ColumnIndex < 0 || !(UiHelper.RowItem<TaskRow>(grid, e) is TaskRow row))
				return;

			if (grid.Columns[e.ColumnIndex].Name == "colDone")
				ToggleDone(row);
			else if (grid.Columns[e.ColumnIndex].Name == "colRelated" && !string.IsNullOrEmpty(row.RelatedText))
				OpenRelated(row);
		}

		private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (UiHelper.RowItem<TaskRow>((DataGridView)sender, e) is TaskRow row && TaskEditDialog.Edit(row.Id))
				RefreshData();
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (TaskEditDialog.Edit(null))
				RefreshData();
		}

		private void segmentedScope_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.segmentedScope.SelectedIndex >= 0)
				RefreshData();
		}
	}
}
