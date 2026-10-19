using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// One stage of the pipeline board: its name, count and total, and the cards of its deals.
	/// Cards dropped on the column raise <see cref="CardDropped"/> with the position they were dropped at.
	/// </summary>
	public partial class StageColumn : UserControl
	{
		public StageColumn()
		{
			InitializeComponent();
		}

		/// <summary>Raised when a deal card is dropped on this column.</summary>
		public event EventHandler<CardDroppedEventArgs> CardDropped;

		/// <summary>The stage of the column.</summary>
		public StageItem Stage { get; private set; }

		/// <summary>The cards of the column, top to bottom.</summary>
		public IEnumerable<DealCard> Cards => this.flowCards.Controls.OfType<DealCard>();

		/// <summary>Shows the stage and its deals.</summary>
		public void Bind(StageItem stage, IList<DealRow> deals, ContextMenuStrip cardMenu, EventHandler openCard)
		{
			this.Stage = stage;
			this.labelName.Text = stage.Name;
			this.labelName.ForeColor = stage.IsWon ? Tone.Success.ToColor() : stage.IsLost ? Tone.Danger.ToColor() : SystemColors.ControlText;
			this.labelTotals.Text = (deals.Count == 1 ? "1 deal" : deals.Count + " deals") + " · " + Fmt.MoneyShort(deals.Sum(d => d.Amount))
				+ (stage.IsWon || stage.IsLost ? "" : " · " + stage.Probability + "%");

			this.flowCards.SuspendLayout();
			while (this.flowCards.Controls.Count > 0)
				this.flowCards.Controls[0].Dispose();
			foreach (var deal in deals)
			{
				var card = new DealCard { Deal = deal, ContextMenuStrip = cardMenu };
				card.OpenRequested += openCard;
				this.flowCards.Controls.Add(card);
			}
			this.flowCards.ResumeLayout();
			FitCards();
		}

		// cards take the width of the column, without the vertical scroll bar.
		private void FitCards()
		{
			var width = this.flowCards.ClientSize.Width - this.flowCards.Padding.Horizontal - this.LogicalToDeviceUnits(8);
			foreach (Control card in this.flowCards.Controls)
				card.Width = Math.Max(this.LogicalToDeviceUnits(120), width);
		}

		/// <summary>The index a card dropped at <paramref name="screenPoint"/> takes in the column.</summary>
		private int DropIndex(Point screenPoint)
		{
			var y = this.flowCards.PointToClient(screenPoint).Y;
			var index = 0;
			foreach (Control card in this.flowCards.Controls)
			{
				if (y < card.Top + card.Height / 2)
					break;
				index++;
			}
			return index;
		}

		private static DealCard DraggedCard(DragEventArgs e)
		{
			return e.Data.GetData(typeof(DealCard)) as DealCard;
		}

		private void flowCards_DragEnter(object sender, DragEventArgs e)
		{
			if (DraggedCard(e) != null)
				this.flowCards.BackColor = SystemColors.GradientInactiveCaption;
		}

		private void flowCards_DragOver(object sender, DragEventArgs e)
		{
			e.Effect = DraggedCard(e) != null ? DragDropEffects.Move : DragDropEffects.None;
		}

		private void flowCards_DragLeave(object sender, EventArgs e)
		{
			this.flowCards.BackColor = SystemColors.ControlLight;
		}

		private void flowCards_DragDrop(object sender, DragEventArgs e)
		{
			this.flowCards.BackColor = SystemColors.ControlLight;
			var card = DraggedCard(e);
			if (card?.Deal == null)
				return;

			var index = DropIndex(new Point(e.X, e.Y));
			// the first card below the drop position, other than the dragged card itself.
			var before = this.Cards.Skip(index).FirstOrDefault(c => c != card);
			CardDropped?.Invoke(this, new CardDroppedEventArgs(card.Deal, before?.Deal));
		}

		private void flowCards_Resize(object sender, EventArgs e)
		{
			FitCards();
		}
	}

	/// <summary>A deal card dropped on a stage column.</summary>
	public class CardDroppedEventArgs : EventArgs
	{
		public CardDroppedEventArgs(DealRow deal, DealRow before)
		{
			this.Deal = deal;
			this.Before = before;
		}

		/// <summary>The dropped deal.</summary>
		public DealRow Deal { get; }

		/// <summary>The deal the dropped one is placed before, or null for the end of the column.</summary>
		public DealRow Before { get; }
	}
}
