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
	/// The deals pipeline: a KanbanBoard with one column per stage, or a list, filtered by owner, close date and amount.
	/// </summary>
	public partial class DealsView : UserControl, IRefreshable
	{
		private List<StageItem> stages = new List<StageItem>();
		private BindingList<DealRow> rows = new BindingList<DealRow>();

		// drill-down conditions that have no control of their own (dashboard).
		private DealFilter drillDown;

		// lost reason asked in CardMoving, saved in CardMoved.
		private string pendingLostReason;

		private bool loading;

		public DealsView()
		{
			InitializeComponent();

			this.dataGridView.AutoGenerateColumns = false;

			this.loading = true;
			try
			{
				Notify.Try(LoadLookups, "Loading the stages");
				kanbanBoard_Resize(this.kanbanBoard, EventArgs.Empty);
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
				this.dateTimePickerFrom.NullableValue = filter.CloseFrom;
				this.dateTimePickerTo.NullableValue = filter.CloseTo;
				this.numericMin.NullableValue = filter.AmountMin;
				this.numericMax.NullableValue = filter.AmountMax;
				this.drillDown = filter;
				this.segmentedView.SelectedIndex = 1;
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

			// one board column per stage; the value is the stage id as text (DealRow.Status).
			this.kanbanBoard.Columns.Clear();
			foreach (var stage in this.stages)
			{
				this.kanbanBoard.Columns.Add(new KanbanColumn
				{
					Text = stage.Name,
					Value = stage.Id.ToString(System.Globalization.CultureInfo.InvariantCulture),
					Tone = stage.IsWon ? MeterTone.Success : stage.IsLost ? MeterTone.Danger : stage.Order <= 1 ? MeterTone.Neutral : MeterTone.Primary,
				});
			}

			// stage chips of the list.
			this.colStage.ToneMap.Clear();
			foreach (var stage in this.stages)
			{
				this.colStage.ToneMap[stage.Name] =
					stage.IsWon ? ChipTone.Success :
					stage.IsLost ? ChipTone.Danger :
					stage.Name == "Negotiation" ? ChipTone.Warning :
					stage.Order <= 1 ? ChipTone.Neutral : ChipTone.Primary;
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
			this.dateTimePickerFrom.NullableValue = null;
			this.dateTimePickerTo.NullableValue = null;
			this.numericMin.NullableValue = null;
			this.numericMax.NullableValue = null;
			this.drillDown = null;
		}

		private DealFilter CurrentFilter()
		{
			var ownerId = this.comboBoxOwner.SelectedValue is int id && id != 0 ? id : (int?)null;
			return new DealFilter
			{
				OwnerId = ownerId,
				CloseFrom = this.dateTimePickerFrom.NullableValue,
				CloseTo = this.dateTimePickerTo.NullableValue,
				AmountMin = this.numericMin.NullableValue,
				AmountMax = this.numericMax.NullableValue,
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

			this.rows = new BindingList<DealRow>(list);
			this.kanbanBoard.DataSource = this.rows;
			this.dataGridView.DataSource = this.rows;

			var caption = filter.Caption;
			this.labelCaption.Text = string.IsNullOrEmpty(caption) ? "" : caption;
			this.panelCaption.Visible = !string.IsNullOrEmpty(caption);

			UpdateTotals();
			this.emptyStateList.RefreshTarget();
		}

		/// <summary>Updates the column headers (stage, count, total) and the summary of the header.</summary>
		private void UpdateTotals()
		{
			var totals = DealService.Totals(this.rows);
			foreach (var column in this.kanbanBoard.Columns)
			{
				var stage = this.stages.FirstOrDefault(s => s.Id.ToString(System.Globalization.CultureInfo.InvariantCulture) == column.Value);
				if (stage == null)
					continue;

				totals.TryGetValue(stage.Id, out var total);
				// the board shows the card count in the column's badge.
				column.Text = stage.Name + " · " + Fmt.MoneyShort(total?.Total ?? 0);
			}
			this.kanbanBoard.Update();

			var count = this.rows.Count;
			var open = this.rows.Where(r => r.IsOpen).Sum(r => r.Amount);
			this.labelSummary.Text = count + (count == 1 ? " deal" : " deals") + " · " + Fmt.MoneyShort(this.rows.Sum(r => r.Amount)) + " total · " + Fmt.MoneyShort(open) + " open";
		}

		private void UpdateMode()
		{
			var list = this.segmentedView.SelectedIndex == 1;
			this.panelList.Visible = list;
			this.kanbanBoard.Visible = !list;
		}

		private void OpenDeal(int dealId)
		{
			if (Navigator.OpenDeal(dealId) && !this.IsDisposed)
				LoadData();
		}

		private void segmentedView_SelectedIndexChanged(object sender, EventArgs e)
		{
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

		private void dateTimePicker_ToolClick(object sender, ToolClickEventArgs e)
		{
			((DateTimePicker)sender).NullableValue = null;
			LoadData();
		}

		private void linkClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.loading = true;
			try
			{
				this.comboBoxOwner.SelectedValue = 0;
				this.dateTimePickerFrom.NullableValue = null;
				this.dateTimePickerTo.NullableValue = null;
				this.numericMin.NullableValue = null;
				this.numericMax.NullableValue = null;
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
			var row = e.Item as DealRow;
			var stage = StageOf(e.Column);
			if (row == null || stage == null || e.Column == e.OldColumn || !stage.IsLost)
				return;

			// dropping on Lost asks why; cancelling the question cancels the move.
			var reason = LostReasonDialog.Ask(row.Title);
			if (reason == null)
				e.Cancel = true;
			else
				this.pendingLostReason = reason;
		}

		private void kanbanBoard_CardMoved(object sender, KanbanCardMoveEventArgs e)
		{
			var row = e.Item as DealRow;
			var stage = StageOf(e.Column);
			if (row == null || stage == null)
				return;

			// the board rewrote BoardOrder of the visible cards: persist the position before the next visible card.
			var next = this.rows
				.Where(r => r != row && r.Status == row.Status && r.BoardOrder > row.BoardOrder)
				.OrderBy(r => r.BoardOrder)
				.FirstOrDefault();

			var stageChanged = e.Column != e.OldColumn;
			var reason = this.pendingLostReason;
			this.pendingLostReason = null;

			if (!Notify.Try(() => DealService.MoveToStage(row.Id, stage.Id, next == null ? -1 : e.Index, reason, next?.Id), "Moving the deal"))
			{
				LoadData();
				return;
			}

			if (stageChanged)
			{
				row.StageId = stage.Id;
				row.StageName = stage.Name;
				row.IsWon = stage.IsWon;
				row.IsLost = stage.IsLost;
				row.Probability = stage.Probability;
				DealService.CloseTag(row, out var tag, out var tone);
				row.CloseTag = tag;
				row.CloseTone = tone;
				this.rows.ResetItem(this.rows.IndexOf(row));

				UpdateTotals();

				if (stage.IsWon)
					Notify.Success("🎉 Deal won: " + row.Title + " · " + row.AmountText);
				else if (stage.IsLost)
					Notify.Info("Deal marked as lost: " + row.Title);
			}
		}

		// lane sizing: every lane at least MinLaneWidth; when not all fit, as many whole lanes as fit fill the width
		// and the board scrolls horizontally, so no lane is cut at the right edge.
		private const int MinLaneWidth = 200;
		private const int LaneGap = 16;
		private const int BoardPadding = 6;

		private void kanbanBoard_Resize(object sender, EventArgs e)
		{
			var lanes = Math.Max(1, this.kanbanBoard.Columns.Count);
			var available = this.kanbanBoard.Width - BoardPadding;
			var visible = Math.Max(1, Math.Min(lanes, (available + LaneGap) / (MinLaneWidth + LaneGap)));
			// one pixel less than the exact share: the next lane starts past the right edge.
			this.kanbanBoard.ColumnWidth = Math.Max(MinLaneWidth, (available - (visible - 1) * LaneGap) / visible - 1);
		}

		private StageItem StageOf(KanbanColumn column)
		{
			return column == null ? null : this.stages.FirstOrDefault(s => s.Id.ToString(System.Globalization.CultureInfo.InvariantCulture) == column.Value);
		}

		private void kanbanBoard_CardDoubleClick(object sender, KanbanCardEventArgs e)
		{
			if (e.Item is DealRow row)
				OpenDeal(row.Id);
		}

		private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0)
				return;

			if (this.dataGridView.Rows[e.RowIndex].DataBoundItem is DealRow row)
				OpenDeal(row.Id);
		}

		private void emptyStateList_ActionClick(object sender, EventArgs e)
		{
			linkClear_LinkClicked(this.linkClear, null);
		}
	}
}
