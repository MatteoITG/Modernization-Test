using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm.Views
{
	/// <summary>
	/// The deals pipeline: a board with one column per stage (drag a card to another stage, or use its context menu),
	/// or a grid, filtered by owner, close date and amount.
	/// </summary>
	/// <remarks>
	/// Migration step 2: step 1 built the board columns and the cards (an ItemsControl of ListBoxes in WPF) from the
	/// data, with the Wisej DragStart/DragDrop events. The Wisej 4.2 KanbanBoard draws them in the browser: one
	/// <see cref="KanbanColumn"/> per stage, the value is the stage id as text (<see cref="DealRow.Status"/>), and the
	/// card order is <see cref="DealRow.BoardOrder"/>. A drop on a lost stage still asks for the reason
	/// (<see cref="LostReasonDialog"/>) and cancelling it cancels the move. The Board/List radio buttons became a
	/// SegmentedButton; the grid got chip, meter and avatar columns.
	/// </remarks>
	public partial class DealsView : UserControl, IRefreshable
	{
		private List<StageItem> stages = new List<StageItem>();
		private List<DealRow> rows = new List<DealRow>();

		// drill-down conditions that have no control of their own (dashboard).
		private DealFilter drillDown;

		// the card or row whose context menu is open.
		private DealRow menuRow;

		// the card of the board clicked last: the one the context menu of the board acts on.
		private DealRow boardDeal;

		// lost reason asked in CardMoving, saved in CardMoved.
		private string pendingLostReason;

		// true until the lookups are loaded, and while the filters are set by code.
		private bool loading = true;

		public DealsView()
		{
			InitializeComponent();
			GridHelper.UseConverters(this.dataGrid);

			try
			{
				Notify.Try(LoadLookups, "Loading the stages");
				ApplyDefaultFilter();
			}
			finally
			{
				this.loading = false;
			}

			FitBoard();
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
				this.datePickerFrom.NullableValue = filter.CloseFrom;
				this.datePickerTo.NullableValue = filter.CloseTo;
				this.textBoxMin.Text = filter.AmountMin?.ToString("0", CultureInfo.InvariantCulture) ?? "";
				this.textBoxMax.Text = filter.AmountMax?.ToString("0", CultureInfo.InvariantCulture) ?? "";
				this.drillDown = filter;
				this.segmentedMode.SelectedIndex = 1;
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

			// one board column per stage, in the tone of the WPF column bar; the same tones for the stage chips.
			this.kanbanBoard.Columns.Clear();
			this.colStage.ToneMap.Clear();
			foreach (var stage in this.stages)
			{
				var tone = stage.IsWon ? Tone.Success : stage.IsLost ? Tone.Danger : stage.Order <= 1 ? Tone.Neutral : Tone.Primary;
				this.kanbanBoard.Columns.Add(new KanbanColumn { Text = stage.Name, Value = StatusOf(stage), Tone = tone.ToMeter() });
				this.colStage.ToneMap[stage.Name] = ToneExtensions.DealStageTone(stage.IsWon, stage.IsLost).ToChip();
			}

			var owners = LookupService.Users().Select(u => new ListItem(u.Id, u.Name)).ToList();
			owners.Insert(0, new ListItem(0, "All owners"));
			this.comboBoxOwner.DataSource = owners;
		}

		private void ApplyDefaultFilter()
		{
			var filter = DealService.DefaultFilter();
			this.comboBoxOwner.SelectedValue = filter.OwnerId ?? 0;
			this.datePickerFrom.NullableValue = null;
			this.datePickerTo.NullableValue = null;
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
				CloseFrom = this.datePickerFrom.NullableValue,
				CloseTo = this.datePickerTo.NullableValue,
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
			if (this.loading || this.IsDisposed)
				return;

			var filter = CurrentFilter();
			List<DealRow> list = null;
			if (!Notify.Try(() => list = DealService.Deals(filter), "Loading the deals"))
				return;

			this.rows = list;
			this.dataGrid.DataSource = list;
			GridHelper.ShowEmpty(this.emptyList, list.Count == 0, "No deals match", "Clear the filters");
			ShowBoard(list);

			var caption = filter.Caption;
			this.runCaption.Text = caption ?? "";
			this.panelCaption.Visible = !string.IsNullOrEmpty(caption);

			var count = list.Count;
			var open = list.Where(r => r.IsOpen).Sum(r => r.Amount);
			this.labelSummary.Text = count + (count == 1 ? " deal" : " deals") + " · " + Fmt.MoneyShort(list.Sum(r => r.Amount)) + " total · " + Fmt.MoneyShort(open) + " open";
		}

		/// <summary>
		/// Shows the deals on the board: the column header has the stage's total (was the header template with the count).
		/// </summary>
		private void ShowBoard(List<DealRow> list)
		{
			var totals = DealService.Totals(list);
			foreach (var column in this.kanbanBoard.Columns)
			{
				var stage = StageOf(column);
				if (stage == null)
					continue;

				// the board shows the count of the cards itself.
				totals.TryGetValue(stage.Id, out var total);
				column.Text = stage.Name + " · " + Fmt.MoneyShort(total?.Total ?? 0);
			}
			this.kanbanBoard.DataSource = list;
			this.kanbanBoard.RefreshData();
		}

		private static string StatusOf(StageItem stage) => stage.Id.ToString(CultureInfo.InvariantCulture);

		private StageItem StageOf(KanbanColumn column) => column == null ? null : this.stages.FirstOrDefault(s => StatusOf(s) == column.Value);

		// lanes: at least MinLaneWidth wide. When they all fit, the board fills the width and the lanes share it;
		// otherwise the board is wider than its panel, which scrolls (the WPF board scrolled horizontally too).
		private const int MinLaneWidth = 180;
		private const int LaneGap = 16;

		private void FitBoard()
		{
			var lanes = Math.Max(1, this.kanbanBoard.Columns.Count);
			var needed = lanes * MinLaneWidth + (lanes - 1) * LaneGap + 8;
			var width = Math.Max(this.panelBoard.ClientSize.Width, needed);
			var height = this.panelBoard.ClientSize.Height - (width > this.panelBoard.ClientSize.Width ? 16 : 0);
			this.kanbanBoard.ColumnWidth = MinLaneWidth;
			this.kanbanBoard.Size = new System.Drawing.Size(width, Math.Max(200, height));
		}

		private bool ListMode => this.segmentedMode.SelectedIndex == 1;

		private void UpdateMode()
		{
			var list = this.ListMode;
			this.panelList.Visible = list;
			this.panelBoard.Visible = !list;
		}

		private void OpenDeal(int dealId)
		{
			if (Navigator.OpenDeal(dealId) && !this.IsDisposed)
				LoadData();
		}

		/// <summary>
		/// Moves a deal to a stage, before the card <paramref name="beforeDealId"/> (null: at the end of the column).
		/// Moving it to the Lost stage asks why; cancelling the question cancels the move.
		/// </summary>
		private void MoveDeal(DealRow row, StageItem stage, int? beforeDealId, string reason = null)
		{
			var stageChanged = row.StageId != stage.Id;
			if (stageChanged && stage.IsLost && reason == null)
			{
				reason = LostReasonDialog.Ask(row.Title);
				if (reason == null)
				{
					LoadData();
					return;
				}
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

		private void FillMoveMenu(MenuItem parent, DealRow row)
		{
			parent.MenuItems.Clear();
			foreach (var stage in this.stages)
			{
				var target = stage;
				var item = new MenuItem { Text = stage.Name, Checked = stage.Id == row.StageId, Enabled = stage.Id != row.StageId };
				item.Click += (s, args) => MoveDeal(row, target, null);
				parent.MenuItems.Add(item);
			}
		}

		#region Board

		private void kanbanBoard_CardMoving(object sender, KanbanCardMoveEventArgs e)
		{
			this.pendingLostReason = null;
			var stage = StageOf(e.Column);
			if (!(e.Item is DealRow row) || stage == null || e.Column == e.OldColumn || !stage.IsLost)
				return;

			// dropping on Lost asks why; cancelling the question cancels the move.
			this.pendingLostReason = LostReasonDialog.Ask(row.Title);
			e.Cancel = this.pendingLostReason == null;
		}

		private void kanbanBoard_CardMoved(object sender, KanbanCardMoveEventArgs e)
		{
			var stage = StageOf(e.Column);
			if (!(e.Item is DealRow row) || stage == null)
				return;

			// the card the moved one is placed before (the board rewrote BoardOrder), or the end of the column.
			var status = StatusOf(stage);
			var before = this.rows.Where(r => r != row && r.Status == status && r.BoardOrder > row.BoardOrder)
				.OrderBy(r => r.BoardOrder).FirstOrDefault();
			var reason = this.pendingLostReason;
			this.pendingLostReason = null;

			// the board changed Status and BoardOrder of the row; StageId is still the old stage.
			MoveDeal(row, stage, before?.Id, reason);
		}

		private void kanbanBoard_CardClick(object sender, KanbanCardEventArgs e)
		{
			this.boardDeal = e.Item as DealRow;
		}

		private void kanbanBoard_CardDoubleClick(object sender, KanbanCardEventArgs e)
		{
			if (e.Item is DealRow row)
				OpenDeal(row.Id);
		}

		private void panelBoard_Resize(object sender, EventArgs e)
		{
			FitBoard();
		}

		private void menuCard_Popup(object sender, EventArgs e)
		{
			// the popup of a Wisej context menu cannot be cancelled: the commands check the card.
			this.menuRow = this.boardDeal;
			this.menuCardOpen.Enabled = this.menuCardEdit.Enabled = this.menuCardMoveTo.Enabled = this.menuRow != null;
			if (this.menuRow != null)
				FillMoveMenu(this.menuCardMoveTo, this.menuRow);
		}

		private void menuCardOpen_Click(object sender, EventArgs e)
		{
			if (this.menuRow != null)
				OpenDeal(this.menuRow.Id);
		}

		private void menuCardEdit_Click(object sender, EventArgs e)
		{
			if (this.menuRow != null && DealEditDialog.Edit(this.menuRow.Id))
				LoadData();
		}

		#endregion

		#region Handlers

		private void segmentedMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.panelList != null && this.segmentedMode.SelectedIndex >= 0)
				UpdateMode();
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (DealEditDialog.Edit(null))
				LoadData();
		}

		private void filter_Changed(object sender, EventArgs e)
		{
			LoadData();
		}

		private void linkClear_Click(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.loading = true;
			try
			{
				this.comboBoxOwner.SelectedValue = 0;
				this.datePickerFrom.NullableValue = null;
				this.datePickerTo.NullableValue = null;
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

		private void emptyList_ActionClick(object sender, EventArgs e)
		{
			linkClear_Click(sender, null);
		}

		private DealRow SelectedRow => UiHelper.SelectedItem<DealRow>(this.dataGrid);

		private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (UiHelper.RowItem<DealRow>(this.dataGrid, e) is DealRow row)
				OpenDeal(row.Id);
		}

		private void dataGrid_CellToolTipTextNeeded(object sender, DataGridViewCellToolTipTextNeededEventArgs e)
		{
			// the Expected close column: the close date.
			if (e.ColumnIndex == this.colClose.Index && e.RowIndex >= 0 && this.dataGrid.Rows[e.RowIndex].DataBoundItem is DealRow row)
				e.ToolTipText = row.CloseText;
		}

		private void listMenu_Opened(object sender, EventArgs e)
		{
			var row = this.SelectedRow;
			this.menuMoveTo.Enabled = row != null;
			if (row != null)
				FillMoveMenu(this.menuMoveTo, row);
		}

		private void menuOpen_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null)
				OpenDeal(this.SelectedRow.Id);
		}

		private void menuEdit_Click(object sender, EventArgs e)
		{
			if (this.SelectedRow != null && DealEditDialog.Edit(this.SelectedRow.Id))
				LoadData();
		}

		#endregion
	}
}
