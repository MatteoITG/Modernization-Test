using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using RelayCrm.Services;

namespace RelayCrm.Views
{
	/// <summary>
	/// A deal on the pipeline board: title, company and amount, close date and owner.
	/// Dragging the card to another stage column moves the deal; double-clicking opens it.
	/// </summary>
	public partial class DealCard : UserControl
	{
		private DealRow deal;
		private Point dragStart;
		private bool mouseDown;

		public DealCard()
		{
			InitializeComponent();

			// the labels cover the card: they pass the mouse on to it.
			foreach (Control child in this.Controls)
			{
				child.MouseDown += (s, e) => OnMouseDown(Translate(s, e));
				child.MouseMove += (s, e) => OnMouseMove(Translate(s, e));
				child.MouseUp += (s, e) => OnMouseUp(Translate(s, e));
				child.DoubleClick += (s, e) => OnDoubleClick(e);
			}
		}

		/// <summary>Raised when the card is double-clicked or Enter is pressed on it.</summary>
		public event EventHandler OpenRequested;

		/// <summary>The deal shown by the card.</summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DealRow Deal
		{
			get { return this.deal; }
			set
			{
				this.deal = value;
				Bind();
			}
		}

		private void Bind()
		{
			if (this.deal == null)
				return;

			this.labelTitle.Text = this.deal.Title;
			this.labelMeta.Text = this.deal.Meta;
			this.labelClose.Text = this.deal.CloseTag;
			var tone = ToneExtensions.ParseTone(this.deal.CloseTone);
			this.labelClose.ForeColor = tone == Tone.Neutral ? SystemColors.GrayText : tone.ToColor();
			this.labelOwner.Text = this.deal.OwnerInitials;

			var tip = this.deal.Title + "\n" + this.deal.Meta + "\nOwner: " + this.deal.OwnerName + "\n" + this.deal.CloseTag
				+ "\nProbability: " + this.deal.ProbabilityText;
			this.toolTip.SetToolTip(this, tip);
			foreach (Control child in this.Controls)
				this.toolTip.SetToolTip(child, tip);
		}

		private MouseEventArgs Translate(object sender, MouseEventArgs e)
		{
			var point = PointToClient(((Control)sender).PointToScreen(e.Location));
			return new MouseEventArgs(e.Button, e.Clicks, point.X, point.Y, e.Delta);
		}

		protected override void OnContextMenuStripChanged(EventArgs e)
		{
			base.OnContextMenuStripChanged(e);
			foreach (Control child in this.Controls)
				child.ContextMenuStrip = this.ContextMenuStrip;
		}

		protected override void OnMouseDown(MouseEventArgs e)
		{
			base.OnMouseDown(e);
			Focus();
			if (e.Button == MouseButtons.Left)
			{
				this.mouseDown = true;
				this.dragStart = e.Location;
			}
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);
			if (!this.mouseDown || this.deal == null)
				return;

			var size = SystemInformation.DragSize;
			if (Math.Abs(e.X - this.dragStart.X) < size.Width && Math.Abs(e.Y - this.dragStart.Y) < size.Height)
				return;

			this.mouseDown = false;
			DoDragDrop(this, DragDropEffects.Move);
		}

		protected override void OnMouseUp(MouseEventArgs e)
		{
			base.OnMouseUp(e);
			this.mouseDown = false;
		}

		protected override void OnDoubleClick(EventArgs e)
		{
			base.OnDoubleClick(e);
			OpenRequested?.Invoke(this, EventArgs.Empty);
		}

		protected override void OnEnter(EventArgs e)
		{
			base.OnEnter(e);
			this.BackColor = SystemColors.GradientInactiveCaption;
		}

		protected override void OnLeave(EventArgs e)
		{
			base.OnLeave(e);
			this.BackColor = SystemColors.Window;
		}

		protected override bool IsInputKey(Keys keyData)
		{
			return keyData == Keys.Enter || base.IsInputKey(keyData);
		}

		protected override void OnKeyDown(KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (e.KeyCode == Keys.Enter)
				OpenRequested?.Invoke(this, EventArgs.Empty);
		}
	}
}
