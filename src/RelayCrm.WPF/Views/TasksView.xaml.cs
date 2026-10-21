using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// Tasks grouped by Overdue, Today, This week, Later and Done; "My tasks" by default.
	/// </summary>
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
			get { return this.radioAll.IsChecked != true; }
			set
			{
				if (value)
					this.radioMine.IsChecked = true;
				else
					this.radioAll.IsChecked = true;
			}
		}

		/// <summary>Reloads the tasks.</summary>
		public void RefreshData()
		{
			if (!this.ready)
				return;

			List<TaskRow> rows = null;
			if (!Notify.Try(() => rows = TaskService.List(this.MineOnly), "Loading the tasks"))
				return;

			var offset = (this.panelGroups.Parent as ScrollViewer)?.VerticalOffset ?? 0;
			this.panelGroups.Children.Clear();
			foreach (TaskGroup group in Enum.GetValues(typeof(TaskGroup)))
			{
				var list = rows.Where(r => r.Group == group).ToList();
				if (list.Count == 0)
					continue;

				this.panelGroups.Children.Add(new GroupBox
				{
					Header = new TextBlock
					{
						Text = TaskService.GroupText(group) + " (" + list.Count + ")",
						FontWeight = FontWeights.SemiBold,
						Foreground = group == TaskGroup.Overdue ? Tone.Danger.ToBrush() : SystemColors.ControlTextBrush,
					},
					Margin = new Thickness(0, 0, 0, 10),
					Content = CreateGrid(list),
				});
			}
			(this.panelGroups.Parent as ScrollViewer)?.ScrollToVerticalOffset(offset);

			var open = rows.Count(r => r.Group != TaskGroup.Done);
			var overdue = rows.Count(r => r.Group == TaskGroup.Overdue);
			this.labelCount.Text = open + " open" + (overdue > 0 ? " · " + overdue + " overdue" : "");
			this.emptyState.Visibility = rows.Count == 0 ? Visibility.Visible : Visibility.Collapsed;
		}

		// a grid with all the rows of a group: it does not scroll, the page does.
		private DataGrid CreateGrid(List<TaskRow> rows)
		{
			var grid = new DataGrid
			{
				ItemsSource = rows,
				VerticalScrollBarVisibility = ScrollBarVisibility.Disabled,
				HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled,
				BorderThickness = new Thickness(0),
				ToolTip = "Double-click to edit the task",
			};
			grid.Columns.Add(new DataGridTemplateColumn { Header = "Done", CellTemplate = (DataTemplate)FindResource("DoneTemplate"), Width = 46, SortMemberPath = "Done" });
			grid.Columns.Add(new DataGridTemplateColumn { Header = "Task", CellTemplate = (DataTemplate)FindResource("TitleTemplate"), Width = new DataGridLength(2.5, DataGridLengthUnitType.Star), SortMemberPath = "Title" });
			grid.Columns.Add(new DataGridTemplateColumn { Header = "Related to", CellTemplate = (DataTemplate)FindResource("RelatedTemplate"), Width = new DataGridLength(2, DataGridLengthUnitType.Star), SortMemberPath = "RelatedText" });
			grid.Columns.Add(new DataGridTemplateColumn { Header = "Due", CellTemplate = (DataTemplate)FindResource("DueTemplate"), Width = 110, SortMemberPath = "DueDate" });
			grid.Columns.Add(new DataGridTemplateColumn { Header = "Priority", CellTemplate = (DataTemplate)FindResource("PriorityTemplate"), Width = 80, SortMemberPath = "Priority" });
			grid.Columns.Add(new DataGridTextColumn { Header = "Assignee", Binding = new System.Windows.Data.Binding("AssigneeName"), Width = new DataGridLength(1.2, DataGridLengthUnitType.Star) });
			grid.MouseDoubleClick += grid_MouseDoubleClick;
			UiHelper.BubbleMouseWheel(grid);
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

		private void checkDone_Click(object sender, RoutedEventArgs e)
		{
			if (((FrameworkElement)sender).DataContext is TaskRow row)
				ToggleDone(row);
		}

		private void linkRelated_Click(object sender, RoutedEventArgs e)
		{
			if (((FrameworkContentElement)sender).DataContext is TaskRow row && !string.IsNullOrEmpty(row.RelatedText))
				OpenRelated(row);
		}

		private void grid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<TaskRow>(e) is TaskRow row && TaskEditDialog.Edit(row.Id))
				RefreshData();
		}

		private void buttonNew_Click(object sender, RoutedEventArgs e)
		{
			if (TaskEditDialog.Edit(null))
				RefreshData();
		}

		private void radioScope_Checked(object sender, RoutedEventArgs e)
		{
			RefreshData();
		}
	}
}
