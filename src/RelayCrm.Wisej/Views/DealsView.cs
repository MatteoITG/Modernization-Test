using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using Wisej.Web;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// The deals pipeline: a board with one column per stage (drag a card to change its stage), or a list,
	/// filtered by owner, close date and amount.
	/// </summary>
	public partial class DealsView : UserControl, IRefreshable
	{
		private List<StageItem> stages = new List<StageItem>();
		private List<DealRow> rows = new List<DealRow>();

		// drill-down conditions that have no control of their own (dashboard, reports).
		private DealFilter drillDown;

		private bool loading;

		// lost reason asked in CardMoving, saved in CardMoved.
		private string pendingLostReason;

		// the card of the board the context menu acts on (the card clicked last).
		private DealRow boardDeal;

		public DealsView()
		{
			InitializeComponent();

			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.DefaultCellStyle.FormatProvider = Fmt.Culture;
			IconImages.Apply(this.toolStrip);

			this.loading = true;
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
				SetDate(this.dateTimePickerFrom, filter.CloseFrom);
				SetDate(this.dateTimePickerTo, filter.CloseTo);
				this.textBoxMin.Text = FormatAmount(filter.AmountMin);
				this.textBoxMax.Text = FormatAmount(filter.AmountMax);
				this.drillDown = filter;
				SetMode(list: true);
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

			// one board column per stage; the value is the stage id as text (DealRow.Status).
			this.kanbanBoard.Columns.Clear();
			this.colStage.ToneMap.Clear();
			foreach (var stage in this.stages)
			{
				var tone = ToneExtensions.DealStageTone(stage.IsWon, stage.IsLost);
				this.kanbanBoard.Columns.Add(new KanbanColumn { Text = stage.Name, Value = StatusOf(stage), Tone = tone.ToMeter() });
				this.colStage.ToneMap[stage.Name] = tone.ToChip();
			}

			var owners = LookupService.Users().Select(u => new ListItem(u.Id, u.Name)).ToList();
			owners.Insert(0, new ListItem(0, "All owners"));
			this.comboBoxOwner.DisplayMember = "Text";
			this.comboBoxOwner.ValueMember = "Id";
			this.comboBoxOwner.DataSource = owners;
		}

		private void ApplyDefaultFilter()
		{
			var filter = DealService.DefaultFilter();
			this.comboBoxOwner.SelectedValue = filter.OwnerId ?? 0;
			SetDate(this.dateTimePickerFrom, null);
			SetDate(this.dateTimePickerTo, null);
			this.textBoxMin.Text = "";
			this.textBoxMax.Text = "";
			this.drillDown = null;
		}

		#region Filter

		private static void SetDate(DateTimePicker picker, DateTime? value)
		{
			if (value != null)
				picker.Value = value.Value.Date;
			picker.Checked = value != null;
		}

		private static DateTime? GetDate(DateTimePicker picker)
		{
			return picker.Checked ? picker.Value.Date : (DateTime?)null;
		}

		private static string FormatAmount(decimal? value)
		{
			return value == null ? "" : value.Value.ToString("N0", Fmt.Culture);
		}

		private static decimal? ParseAmount(TextBox textBox)
		{
			var text = textBox.Text.Trim().TrimStart('$');
			return decimal.TryParse(text, NumberStyles.Number, Fmt.Culture, out var value) ? value : (decimal?)null;
		}

		private DealFilter CurrentFilter()
		{
			var ownerId = this.comboBoxOwner.SelectedValue is int id && id != 0 ? id : (int?)null;
			return new DealFilter
			{
				OwnerId = ownerId,
				CloseFrom = GetDate(this.dateTimePickerFrom),
				CloseTo = GetDate(this.dateTimePickerTo),
				AmountMin = ParseAmount(this.textBoxMin),
				AmountMax = ParseAmount(this.textBoxMax),
				Search = this.drillDown?.Search,
				StageId = this.drillDown?.StageId,
				OpenOnly = this.drillDown?.OpenOnly ?? false,
				WonOnly = this.drillDown?.WonOnly ?? false,
				Caption = this.drillDown?.Caption,
			};
		}

		#endregion

		private void LoadData()
		{
			if (this.loading || this.IsDisposed)
				return;

			var filter = CurrentFilter();
			List<DealRow> list = null;
			if (!Notify.Try(() => list = DealService.Deals(filter), "Loading the deals"))
				return;

			this.rows = list;
			ShowBoard();

			var sortColumn = this.dataGridView.SortedColumn;
			var sortOrder = this.dataGridView.SortOrder;
			this.dataGridView.DataSource = new SortableBindingList<DealRow>(list);
			if (sortColumn != null && sortOrder != SortOrder.None)
				this.dataGridView.Sort(sortColumn, sortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending);

			var caption = filter.Caption;
			this.labelCaption.Text = string.IsNullOrEmpty(caption) ? "" : caption + "  (" + (list.Count == 1 ? "1 deal" : list.Count + " deals") + ")";
			this.panelCaption.Visible = !string.IsNullOrEmpty(caption);

			GridHelper.ShowEmpty(this.emptyState, list.Count == 0, "No deals match the filters.", "Clear filters");

			var count = list.Count;
			var open = list.Where(r => r.IsOpen).Sum(r => r.Amount);
			this.labelSummary.Text = count + (count == 1 ? " deal" : " deals") + " · " + Fmt.MoneyShort(list.Sum(r => r.Amount)) + " total · " + Fmt.MoneyShort(open) + " open";
		}

		/// <summary>Shows the deals on the board (one column per stage) with the totals of each stage.</summary>
		private void ShowBoard()
		{
			this.kanbanBoard.DataSource = this.rows;
			foreach (var column in this.kanbanBoard.Columns)
			{
				var stage = StageOf(column);
				if (stage == null)
					continue;

				var deals = this.rows.Where(r => r.StageId == stage.Id).ToList();
				// the board shows the card count in the column's badge.
				column.Text = stage.Name + " · " + Fmt.MoneyShort(deals.Sum(d => d.Amount))
					+ (stage.IsWon || stage.IsLost ? "" : " · " + stage.Probability + "%");
			}
			this.kanbanBoard.Update();
		}

		private static string StatusOf(StageItem stage) => stage.Id.ToString(CultureInfo.InvariantCulture);

		private StageItem StageOf(KanbanColumn column) => column == null ? null : this.stages.FirstOrDefault(s => StatusOf(s) == column.Value);

		// lanes: at least MinLaneWidth wide; as many whole lanes as fit fill the width, the board scrolls for the others.
		private const int MinLaneWidth = 220;
		private const int LaneGap = 16;

		private void FitColumns()
		{
			var lanes = Math.Max(1, this.kanbanBoard.Columns.Count);
			var visible = Math.Max(1, Math.Min(lanes, (this.kanbanBoard.Width + LaneGap) / (MinLaneWidth + LaneGap)));
			this.kanbanBoard.ColumnWidth = Math.Max(MinLaneWidth, (this.kanbanBoard.Width - (visible - 1) * LaneGap) / visible - 1);
		}

		private void SetMode(bool list)
		{
			this.buttonList.Pushed = list;
			this.buttonBoard.Pushed = !list;
			this.panelList.Visible = list;
			this.kanbanBoard.Visible = !list;
		}

		/// <summary>
		/// Moves a deal to a stage, before another card or at the end; moving to a lost stage asks why.
		/// </summary>
		private void MoveDeal(DealRow row, StageItem stage, DealRow before, string reason = null)
		{
			var stageChanged = row.StageId != stage.Id;
			if (stageChanged && stage.IsLost && reason == null)
			{
				// cancelling the question cancels the move.
				reason = LostReasonDialog.Ask(row.Title);
				if (reason == null)
					return;
			}

			if (!Notify.Try(() => DealService.MoveToStage(row.Id, stage.Id, -1, reason, before?.Id), "Moving the deal"))
			{
				LoadData();
				return;
			}

			if (stageChanged)
			{
				if (stage.IsWon)
					Notify.Success("Deal won: " + row.Title + " · " + row.AmountText);
				else if (stage.IsLost)
					Notify.Info("Deal marked as lost: " + row.Title);
				else
					Notify.Success(row.Title + " moved to " + stage.Name + ".");
			}
			LoadData();
		}

		private void OpenDeal(int dealId)
		{
			if (Navigator.OpenDeal(dealId) && !this.IsDisposed)
				LoadData();
		}

		/// <summary>The deal the context menu was opened on: a card of the board or the current row of the list.</summary>
		private DealRow MenuDeal()
		{
			// on the board: the card clicked last.
			if (this.contextMenu.SourceControl == this.kanbanBoard)
				return this.boardDeal;
			if (this.contextMenu.SourceControl == this.dataGridView)
				return GridHelper.Current<DealRow>(this.dataGridView);
			return null;
		}

		#region Handlers

		private void buttonMode_Click(object sender, EventArgs e)
		{
			SetMode(sender == this.buttonList);
		}

		private void buttonNew_Click(object sender, EventArgs e)
		{
			if (DealEditDialog.Edit(null))
				LoadData();
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			LoadData();
		}

		private void filter_Changed(object sender, EventArgs e)
		{
			LoadData();
		}

		private void amount_Leave(object sender, EventArgs e)
		{
			var textBox = (TextBox)sender;
			if (textBox.Text.Trim().Length > 0 && ParseAmount(textBox) == null)
			{
				Notify.Warning("Enter an amount like 25,000.");
				textBox.Text = "";
			}
			LoadData();
		}

		private void amount_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				amount_Leave(sender, e);
			}
		}

		private void emptyState_ActionClick(object sender, EventArgs e)
		{
			linkClear_LinkClicked(sender, null);
		}

		private void linkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.loading = true;
			try
			{
				this.comboBoxOwner.SelectedValue = 0;
				SetDate(this.dateTimePickerFrom, null);
				SetDate(this.dateTimePickerTo, null);
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
			MoveDeal(row, stage, before, reason);
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

		private void kanbanBoard_Resize(object sender, EventArgs e)
		{
			FitColumns();
		}

		private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = GridHelper.RowAt<DealRow>(this.dataGridView, e.RowIndex);
			if (row != null)
				OpenDeal(row.Id);
		}

		private void dataGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
		{
			GridHelper.SelectOnRightClick(this.dataGridView, e);
		}

		private void dataGridView_KeyDown(object sender, KeyEventArgs e)
		{
			var row = GridHelper.Current<DealRow>(this.dataGridView);
			if (row != null && e.KeyCode == Keys.Enter)
			{
				e.Handled = true;
				OpenDeal(row.Id);
			}
		}

		private void contextMenu_Opening(object sender, EventArgs e)
		{
			var deal = MenuDeal();
			if (deal == null)
			{
				return;
			}

			// the stages the deal can move to.
			this.menuMoveTo.MenuItems.Clear();
			foreach (var stage in this.stages)
			{
				var target = stage;
				var item = new MenuItem(stage.Name) { Checked = stage.Id == deal.StageId, Enabled = stage.Id != deal.StageId };
				item.Click += (s, args) => MoveDeal(deal, target, null);
				this.menuMoveTo.MenuItems.Add(item);
			}
		}

		private void menuOpen_Click(object sender, EventArgs e)
		{
			var deal = MenuDeal();
			if (deal != null)
				OpenDeal(deal.Id);
		}

		private void menuEdit_Click(object sender, EventArgs e)
		{
			var deal = MenuDeal();
			if (deal != null && DealEditDialog.Edit(deal.Id))
				LoadData();
		}

		private void menuDelete_Click(object sender, EventArgs e)
		{
			var deal = MenuDeal();
			if (deal == null || !ConfirmDialog.Ask("Delete deal", "Delete \"" + deal.Title + "\"? Its activities and tasks are kept.", "Delete"))
				return;

			if (Notify.Try(() => DealService.Delete(deal.Id), "Deleting the deal"))
			{
				Notify.Success("Deal deleted.");
				LoadData();
			}
		}

		#endregion
	}
}
