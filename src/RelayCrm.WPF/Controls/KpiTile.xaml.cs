using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using RelayCrm.Services;

namespace RelayCrm.Controls
{
	/// <summary>
	/// A key figure: title, value, caption, optional change versus the previous period and a sparkline.
	/// Clicking it raises <see cref="Click"/> (the dashboard drills down to the deals behind the figure).
	/// </summary>
	public partial class KpiTile : UserControl
	{
		public KpiTile()
		{
			InitializeComponent();
		}

		/// <summary>Raised when the tile is clicked.</summary>
		public event EventHandler Click;

		public string Title
		{
			get { return this.labelTitle.Text; }
			set { this.labelTitle.Text = value; }
		}

		/// <summary>Colours the value: Warning for a figure that needs attention.</summary>
		public Tone Tone
		{
			set { this.labelValue.Foreground = value == Tone.Neutral ? SystemColors.ControlTextBrush : value.ToBrush(); }
		}

		/// <summary>Shows a KPI of the dashboard.</summary>
		public void Show(string value, string caption, double[] sparkline, decimal? trend = null)
		{
			this.labelValue.Text = value;
			this.labelCaption.Text = caption;
			this.labelCaption.ToolTip = caption;
			this.sparkline.Values = sparkline;
			this.sparkline.Visibility = sparkline == null ? Visibility.Collapsed : Visibility.Visible;

			if (trend == null)
			{
				this.labelTrend.Text = "";
			}
			else
			{
				this.labelTrend.Text = (trend.Value >= 0 ? "▲ " : "▼ ") + Math.Abs(trend.Value).ToString("0.#", Fmt.Culture) + "%";
				this.labelTrend.Foreground = (trend.Value >= 0 ? Tone.Success : Tone.Danger).ToBrush();
			}
		}

		protected override void OnMouseEnter(MouseEventArgs e)
		{
			base.OnMouseEnter(e);
			if (this.Click != null)
			{
				this.Cursor = Cursors.Hand;
				this.border.BorderBrush = SystemColors.HighlightBrush;
			}
		}

		protected override void OnMouseLeave(MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			this.border.BorderBrush = SystemColors.ActiveBorderBrush;
		}

		protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			this.Click?.Invoke(this, EventArgs.Empty);
		}
	}
}
