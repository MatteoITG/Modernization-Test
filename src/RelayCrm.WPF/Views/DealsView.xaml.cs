using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// The deals pipeline: a board with one list per stage (drag a card to another stage, or use its context menu),
	/// or a grid, filtered by owner, close date and amount.
	/// </summary>
	public partial class DealsView : UserControl, IRefreshable
	{
		/// <summary>A stage column of the board.</summary>
		public class BoardColumn
		{
			public StageItem Stage { get; set; }
			public ObservableCollection<DealRow> Cards { get; set; }
			public string CountText { get; set; }
			public string TotalText { get; set; }
			public Brush ToneBrush { get; set; }
		}

		private List<StageItem> stages = new List<StageItem>();
		private List<DealRow> rows = new List<DealRow>();

		// drill-down conditions that have no control of their own (dashboard).
		private DealFilter drillDown;

		// the card under the mouse when the left button went down, and where: the start of a drag.
		private DealRow dragRow;
		private Point dragStart;

		// true until the lookups are loaded, and while the filters are set by code.
		private bool loading = true;

		public DealsView()
		{
			InitializeComponent();

			try
			{
				Notify.Try(LoadLookups, "Loading the stages");
				ApplyDefaultFilter();
			}
			finally
			{
				this.loading = false;
			}

			LoadData();
		}

		/// <summary>
		/// Switches to the list and applies <paramref name="filter"/> (dashboard drill-downs).
		/// </summary>
		public void ShowList(DealFilter filter)
		{
			filter = filter ?? new DealFilter();

			this.loading = true;
			try
			{
				this.comboBoxOwner.SelectedValue = filter.OwnerId ?? 0;
				this.datePickerFrom.SelectedDate = filter.CloseFrom;
				this.datePickerTo.SelectedDate = filter.CloseTo;
				this.textBoxMin.Text = filter.AmountMin?.ToString("0", CultureInfo.InvariantCulture) ?? "";
				this.textBoxMax.Text = filter.AmountMax?.ToString("0", CultureInfo.InvariantCulture) ?? "";
				this.drillDown = filter;
				this.radioList.IsChecked = true;
				UpdateMode();
			}
			finally
			{
				this.loading = false;
			}

			LoadData();
		}

		/// <summary>Reloads the deals.</summary>
		public void RefreshData()
		{
			LoadData();
		}

		private void LoadLookups()
		{
			this.stages = LookupService.Stages();

			var owners = LookupService.Users().Select(u => new ListItem(u.Id, u.Name)).ToList();
			owners.Insert(0, new ListItem(0, "All owners"));
			this.comboBoxOwner.ItemsSource = owners;
		}

		private void ApplyDefaultFilter()
		{
			var filter = DealService.DefaultFilter();
			this.comboBoxOwner.SelectedValue = filter.OwnerId ?? 0;
			this.datePickerFrom.SelectedDate = null;
			this.datePickerTo.SelectedDate = null;
			this.textBoxMin.Text = "";
			this.textBoxMax.Text = "";
			this.drillDown = null;
		}

		private static decimal? ParseAmount(string text)
		{
			return decimal.TryParse((text ?? "").Trim().TrimStart('$'), NumberStyles.Number, Fmt.Culture, out var value) ? value : (decimal?)null;
		}

		private DealFilter CurrentFilter()
		{
			var ownerId = this.comboBoxOwner.SelectedValue is int id && id != 0 ? id : (int?)null;
			return new DealFilter
			{
				OwnerId = ownerId,
				CloseFrom = this.datePickerFrom.SelectedDate,
				CloseTo = this.datePickerTo.SelectedDate,
				AmountMin = ParseAmount(this.textBoxMin.Text),
				AmountMax = ParseAmount(this.textBoxMax.Text),
				Search = this.drillDown?.Search,
				StageId = this.drillDown?.StageId,
				OpenOnly = this.drillDown?.OpenOnly ?? false,
				WonOnly = this.drillDown?.WonOnly ?? false,
				Caption = this.drillDown?.Caption,
			};
		}

		private void LoadData()
		{
			if (this.loading)
				return;

			var filter = CurrentFilter();
			List<DealRow> list = null;
			if (!Notify.Try(() => list = DealService.Deals(filter), "Loading the deals"))
				return;

			this.rows = list;
			this.dataGrid.ItemsSource = list;
			this.emptyList.Visibility = list.Count == 0 ? Visibility.Visible : Visibility.Collapsed;

			// one column per stage, with the stage's count and total in the header.
			var totals = DealService.Totals(list);
			var offset = this.boardScroll.HorizontalOffset;
			this.board.ItemsSource = this.stages.Select(stage =>
			{
				totals.TryGetValue(stage.Id, out var total);
				return new BoardColumn
				{
					Stage = stage,
					Cards = new ObservableCollection<DealRow>(list.Where(r => r.StageId == stage.Id)),
					CountText = (total?.Count ?? 0).ToString(Fmt.Culture),
					TotalText = Fmt.Money(total?.Total ?? 0),
					ToneBrush = (stage.IsWon ? Tone.Success : stage.IsLost ? Tone.Danger : stage.Order <= 1 ? Tone.Neutral : Tone.Primary).ToBrush(),
				};
			}).ToList();
			this.boardScroll.ScrollToHorizontalOffset(offset);

			var caption = filter.Caption;
			this.runCaption.Text = caption ?? "";
			this.panelCaption.Visibility = string.IsNullOrEmpty(caption) ? Visibility.Collapsed : Visibility.Visible;

			var count = list.Count;
			var open = list.Where(r => r.IsOpen).Sum(r => r.Amount);
			this.labelSummary.Text = count + (count == 1 ? " deal" : " deals") + " · " + Fmt.MoneyShort(list.Sum(r => r.Amount)) + " total · " + Fmt.MoneyShort(open) + " open";
		}

		private void UpdateMode()
		{
			var list = this.radioList.IsChecked == true;
			this.panelList.Visibility = list ? Visibility.Visible : Visibility.Collapsed;
			this.boardScroll.Visibility = list ? Visibility.Collapsed : Visibility.Visible;
		}

		private void OpenDeal(int dealId)
		{
			if (Navigator.OpenDeal(dealId))
				LoadData();
		}

		/// <summary>
		/// Moves a deal to a stage, before the card <paramref name="beforeDealId"/> (null: at the end of the column).
		/// Moving it to the Lost stage asks why; cancelling the question cancels the move.
		/// </summary>
		private void MoveDeal(DealRow row, StageItem stage, int? beforeDealId)
		{
			var stageChanged = row.StageId != stage.Id;
			string reason = null;
			if (stageChanged && stage.IsLost)
			{
				reason = LostReasonDialog.Ask(row.Title);
				if (reason == null)
					return;
			}

			var moved = Notify.Try(() => DealService.MoveToStage(row.Id, stage.Id, beforeDealId == null ? -1 : 0, reason, beforeDealId), "Moving the deal");
			LoadData();
			if (!moved || !stageChanged)
				return;

			if (stage.IsWon)
				Notify.Success("🎉 Deal won: " + row.Title + " · " + row.AmountText);
			else if (stage.IsLost)
				Notify.Info("Deal marked as lost: " + row.Title);
			else
				Notify.Success(row.Title + " moved to " + stage.Name + ".");
		}

		#region Board drag and drop

		private void cards_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			this.dragRow = UiHelper.RowItem<DealRow>(e);
			this.dragStart = e.GetPosition(null);
		}

		private void cards_PreviewMouseMove(object sender, MouseEventArgs e)
		{
			if (this.dragRow == null || e.LeftButton != MouseButtonState.Pressed)
				return;

			var position = e.GetPosition(null);
			if (Math.Abs(position.X - this.dragStart.X) < SystemParameters.MinimumHorizontalDragDistance
				&& Math.Abs(position.Y - this.dragStart.Y) < SystemParameters.MinimumVerticalDragDistance)
				return;

			var row = this.dragRow;
			this.dragRow = null;
			DragDrop.DoDragDrop((DependencyObject)sender, new DataObject(typeof(DealRow), row), DragDropEffects.Move);
		}

		private void cards_DragOver(object sender, DragEventArgs e)
		{
			e.Effects = e.Data.GetDataPresent(typeof(DealRow)) ? DragDropEffects.Move : DragDropEffects.None;
			e.Handled = true;
		}

		private void cards_Drop(object sender, DragEventArgs e)
		{
			var list = (ListBox)sender;
			if (!(e.Data.GetData(typeof(DealRow)) is DealRow row) || !(list.Tag is BoardColumn column))
				return;

			// the card the deal is dropped above: the first one whose middle is below the mouse.
			var y = e.GetPosition(list).Y;
			DealRow before = null;
			foreach (var card in column.Cards)
			{
				if (!(list.ItemContainerGenerator.ContainerFromItem(card) is ListBoxItem container) || !container.IsVisible)
					continue;
				var top = container.TranslatePoint(new Point(0, 0), list).Y;
				if (y < top + container.ActualHeight / 2)
				{
					before = card;
					break;
				}
			}
			if (before == row)
				return;

			e.Handled = true;
			MoveDeal(row, column.Stage, before?.Id);
		}

		private void cards_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<DealRow>(e) is DealRow row)
				OpenDeal(row.Id);
		}

		private void card_ContextMenuOpening(object sender, ContextMenuEventArgs e)
		{
			var card = (FrameworkElement)sender;
			if (!(card.DataContext is DealRow row) || card.ContextMenu == null)
			{
				e.Handled = true;
				return;
			}

			var menu = card.ContextMenu;
			menu.Items.Clear();

			var open = new MenuItem { Header = "_Open", FontWeight = FontWeights.Bold };
			open.Click += (s, args) => OpenDeal(row.Id);
			menu.Items.Add(open);

			var edit = new MenuItem { Header = "_Edit..." };
			edit.Click += (s, args) =>
			{
				if (DealEditDialog.Edit(row.Id))
					LoadData();
			};
			menu.Items.Add(edit);
			menu.Items.Add(new Separator());

			var moveTo = new MenuItem { Header = "_Move to" };
			FillMoveMenu(moveTo, row);
			menu.Items.Add(moveTo);
		}

		private void FillMoveMenu(MenuItem parent, DealRow row)
		{
			parent.Items.Clear();
			foreach (var stage in this.stages)
			{
				var target = stage;
				var item = new MenuItem { Header = stage.Name, IsChecked = stage.Id == row.StageId, IsEnabled = stage.Id != row.StageId };
				item.Click += (s, args) => MoveDeal(row, target, null);
				parent.Items.Add(item);
			}
		}

		#endregion

		#region Handlers

		private void radioMode_Checked(object sender, RoutedEventArgs e)
		{
			if (this.panelList != null)
				UpdateMode();
		}

		private void buttonNew_Click(object sender, RoutedEventArgs e)
		{
			if (DealEditDialog.Edit(null))
				LoadData();
		}

		private void filter_Changed(object sender, RoutedEventArgs e)
		{
			LoadData();
		}

		private void linkClear_Click(object sender, RoutedEventArgs e)
		{
			this.loading = true;
			try
			{
				this.comboBoxOwner.SelectedValue = 0;
				this.datePickerFrom.SelectedDate = null;
				this.datePickerTo.SelectedDate = null;
				this.textBoxMin.Text = "";
				this.textBoxMax.Text = "";
				this.drillDown = null;
			}
			finally
			{
				this.loading = false;
			}
			LoadData();
		}

		private DealRow SelectedRow => this.dataGrid.SelectedItem as DealRow;

		private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
		{
			if (UiHelper.RowItem<DealRow>(e) is DealRow row)
				OpenDeal(row.Id);
		}

		private void listMenu_Opened(object sender, RoutedEventArgs e)
		{
			var row = this.SelectedRow;
			this.menuMoveTo.IsEnabled = row != null;
			if (row != null)
				FillMoveMenu(this.menuMoveTo, row);
		}

		private void menuOpen_Click(object sender, RoutedEventArgs e)
		{
			if (this.SelectedRow != null)
				OpenDeal(this.SelectedRow.Id);
		}

		private void menuEdit_Click(object sender, RoutedEventArgs e)
		{
			if (this.SelectedRow != null && DealEditDialog.Edit(this.SelectedRow.Id))
				LoadData();
		}

		#endregion
	}
}
