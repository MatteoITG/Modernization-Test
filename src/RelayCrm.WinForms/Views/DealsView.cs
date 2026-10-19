using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
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

			GridHelper.ShowEmpty(this.linkEmpty, list.Count == 0, "No deals match the filters.", "Clear filters");

			var count = list.Count;
			var open = list.Where(r => r.IsOpen).Sum(r => r.Amount);
			this.labelSummary.Text = count + (count == 1 ? " deal" : " deals") + " · " + Fmt.MoneyShort(list.Sum(r => r.Amount)) + " total · " + Fmt.MoneyShort(open) + " open";
		}

		/// <summary>Builds one column per stage with the cards of its deals.</summary>
		private void ShowBoard()
		{
			var scroll = this.flowBoard.HorizontalScroll.Value;
			this.flowBoard.SuspendLayout();
			try
			{
				// one column per stage, created once and reused.
				var columns = this.flowBoard.Controls.OfType<StageColumn>().ToList();
				if (columns.Count != this.stages.Count)
				{
					foreach (var column in columns)
						column.Dispose();
					columns = this.stages.Select(s =>
					{
						var column = new StageColumn();
						column.CardDropped += stageColumn_CardDropped;
						this.flowBoard.Controls.Add(column);
						return column;
					}).ToList();
				}

				for (var i = 0; i < this.stages.Count; i++)
				{
					var stage = this.stages[i];
					columns[i].Bind(stage, this.rows.Where(r => r.StageId == stage.Id).ToList(), this.contextMenu, card_OpenRequested);
				}
			}
			finally
			{
				this.flowBoard.ResumeLayout();
			}
			FitColumns();
			this.flowBoard.HorizontalScroll.Value = Math.Min(scroll, this.flowBoard.HorizontalScroll.Maximum);
		}

		// the columns fill the height of the board.
		private void FitColumns()
		{
			var height = this.flowBoard.ClientSize.Height - this.flowBoard.Padding.Vertical - 4;
			foreach (Control column in this.flowBoard.Controls)
				column.Height = Math.Max(this.LogicalToDeviceUnits(200), height);
		}

		private void SetMode(bool list)
		{
			this.buttonList.Checked = list;
			this.buttonBoard.Checked = !list;
			this.panelList.Visible = list;
			this.flowBoard.Visible = !list;
		}

		/// <summary>
		/// Moves a deal to a stage, before another card or at the end; moving to a lost stage asks why.
		/// </summary>
		private void MoveDeal(DealRow row, StageItem stage, DealRow before)
		{
			var stageChanged = row.StageId != stage.Id;
			string reason = null;
			if (stageChanged && stage.IsLost)
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
			// a right click on a label of a card: the card is its parent.
			var source = this.contextMenu.SourceControl;
			while (source != null && !(source is DealCard))
				source = source.Parent;
			if (source is DealCard card)
				return card.Deal;
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
				e.SuppressKeyPress = true;
				amount_Leave(sender, e);
			}
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

		private void stageColumn_CardDropped(object sender, CardDroppedEventArgs e)
		{
			var stage = ((StageColumn)sender).Stage;
			if (stage == null || e.Deal == null || e.Before?.Id == e.Deal.Id)
				return;

			// BeginInvoke: the drag and drop operation ends before a dialog (lost reason) can open.
			BeginInvoke(new Action(() => MoveDeal(e.Deal, stage, e.Before)));
		}

		private void card_OpenRequested(object sender, EventArgs e)
		{
			if (sender is DealCard card && card.Deal != null)
				OpenDeal(card.Deal.Id);
		}

		private void flowBoard_Resize(object sender, EventArgs e)
		{
			FitColumns();
		}

		private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			var row = GridHelper.RowAt<DealRow>(this.dataGridView, e.RowIndex);
			if (row != null)
				OpenDeal(row.Id);
		}

		private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			var row = GridHelper.RowAt<DealRow>(this.dataGridView, e.RowIndex);
			if (row == null)
				return;

			if (e.ColumnIndex == this.colStage.Index)
				e.CellStyle.ForeColor = ToneExtensions.DealStageTone(row.IsWon, row.IsLost).ToColor();
			else if (e.ColumnIndex == this.colCloseTag.Index)
			{
				var tone = ToneExtensions.ParseTone(row.CloseTone);
				e.CellStyle.ForeColor = tone == Tone.Neutral ? System.Drawing.SystemColors.GrayText : tone.ToColor();
			}
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

		private void contextMenu_Opening(object sender, CancelEventArgs e)
		{
			var deal = MenuDeal();
			if (deal == null)
			{
				e.Cancel = true;
				return;
			}

			// the stages the deal can move to.
			this.menuMoveTo.DropDownItems.Clear();
			foreach (var stage in this.stages)
			{
				var target = stage;
				var item = new ToolStripMenuItem(stage.Name) { Checked = stage.Id == deal.StageId, Enabled = stage.Id != deal.StageId };
				item.Click += (s, args) => MoveDeal(deal, target, null);
				this.menuMoveTo.DropDownItems.Add(item);
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
