using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using RelayCrm.Services;

namespace RelayCrm.Controls
{
	/// <summary>One series of a <see cref="BarChart"/>.</summary>
	public class ChartSeries
	{
		public ChartSeries(string name, Color color, IEnumerable<double> values)
		{
			this.Name = name;
			this.Color = color;
			this.Values = (values ?? Enumerable.Empty<double>()).ToArray();
		}

		public string Name { get; }
		public Color Color { get; }
		public double[] Values { get; }
	}

	/// <summary>The bar that was clicked.</summary>
	public class ChartPointEventArgs : EventArgs
	{
		public ChartPointEventArgs(int seriesIndex, int index, object tag)
		{
			this.SeriesIndex = seriesIndex;
			this.Index = index;
			this.Tag = tag;
		}

		public int SeriesIndex { get; }
		/// <summary>Index of the category.</summary>
		public int Index { get; }
		/// <summary>The tag of the category given to <see cref="BarChart.SetData"/>.</summary>
		public object Tag { get; }
	}

	/// <summary>
	/// A simple bar chart drawn with the WPF drawing primitives: vertical or horizontal bars, grouped or stacked
	/// series, a value axis with round ticks (<see cref="ChartColors.NiceMax"/>), a legend, tooltips and clickable bars.
	/// </summary>
	public class BarChart : FrameworkElement
	{
		private const int Ticks = 4;
		private const double FontSize = 11;

		private class Bar
		{
			public Rect Rect;
			public int SeriesIndex;
			public int Index;
		}

		private readonly List<Bar> bars = new List<Bar>();
		private readonly List<ChartSeries> series = new List<ChartSeries>();
		private string[] categories = new string[0];
		private object[] tags = new object[0];
		private Bar hover;

		public BarChart()
		{
			this.MinHeight = 120;
			this.SnapsToDevicePixels = true;
		}

		/// <summary>Bars from the left (categories on the vertical axis) instead of from the bottom.</summary>
		public bool Horizontal { get; set; }

		/// <summary>Stacks the series of a category instead of placing them side by side.</summary>
		public bool Stacked { get; set; }

		/// <summary>Keeps the axis ticks on whole numbers (counts).</summary>
		public bool WholeNumbers { get; set; }

		/// <summary>Text of the axis ticks.</summary>
		public Func<double, string> AxisFormat { get; set; } = v => v.ToString("N0", Fmt.Culture);

		/// <summary>Text of a value in the tooltip.</summary>
		public Func<double, string> ValueFormat { get; set; } = v => v.ToString("N0", Fmt.Culture);

		/// <summary>Text shown when there are no categories.</summary>
		public string EmptyText { get; set; } = "No data";

		/// <summary>Raised when a bar is clicked.</summary>
		public event EventHandler<ChartPointEventArgs> PointClick;

		/// <summary>Sets the categories, their tags (given back by <see cref="PointClick"/>) and the series, and redraws.</summary>
		public void SetData(IEnumerable<string> categories, IEnumerable<object> tags, params ChartSeries[] series)
		{
			this.categories = (categories ?? Enumerable.Empty<string>()).ToArray();
			this.tags = (tags ?? Enumerable.Empty<object>()).ToArray();
			this.series.Clear();
			this.series.AddRange(series ?? new ChartSeries[0]);
			this.hover = null;
			this.ToolTip = null;
			InvalidateVisual();
		}

		protected override void OnRender(DrawingContext dc)
		{
			this.bars.Clear();
			var width = this.ActualWidth;
			var height = this.ActualHeight;

			// a transparent background makes the whole area receive the mouse.
			dc.DrawRectangle(Brushes.Transparent, null, new Rect(0, 0, width, height));
			if (width < 40 || height < 40)
				return;

			var count = this.categories.Length;
			if (count == 0 || this.series.Count == 0)
			{
				var empty = Text(this.EmptyText, SystemColors.GrayTextBrush);
				dc.DrawText(empty, new Point((width - empty.Width) / 2, (height - empty.Height) / 2));
				return;
			}

			var totals = Enumerable.Range(0, count)
				.Select(i => this.Stacked
					? this.series.Sum(s => Math.Max(0, ValueAt(s, i)))
					: this.series.Max(s => ValueAt(s, i)))
				.ToList();
			var max = ChartColors.NiceMax(totals, this.WholeNumbers, Ticks) ?? (this.WholeNumbers ? Ticks : 1);

			var top = 4d;
			if (this.series.Count > 1)
				top = DrawLegend(dc, width) + 8;

			var gridPen = new Pen(new SolidColorBrush(Color.FromRgb(0xE3, 0xE3, 0xE3)), 1);
			var axisPen = new Pen(SystemColors.ControlDarkBrush, 1);
			var textHeight = Text("0", Brushes.Black).Height;

			if (!this.Horizontal)
			{
				var labelWidth = Enumerable.Range(0, Ticks + 1).Max(i => Text(this.AxisFormat(max * i / Ticks), Brushes.Black).Width);
				var plot = new Rect(labelWidth + 8, top + textHeight / 2, Math.Max(10, width - labelWidth - 16), Math.Max(10, height - top - textHeight / 2 - textHeight - 8));

				for (var i = 0; i <= Ticks; i++)
				{
					var y = Math.Round(plot.Bottom - plot.Height * i / Ticks) + 0.5;
					dc.DrawLine(i == 0 ? axisPen : gridPen, new Point(plot.Left, y), new Point(plot.Right, y));
					var label = Text(this.AxisFormat(max * i / Ticks), SystemColors.GrayTextBrush);
					dc.DrawText(label, new Point(plot.Left - 6 - label.Width, y - label.Height / 2));
				}

				var band = plot.Width / count;
				var group = Math.Min(band * 0.7, 48d * (this.Stacked ? 1 : this.series.Count));
				// show every n-th category label when they do not fit.
				var widest = this.categories.Max(c => Text(c, Brushes.Black).Width) + 6;
				var step = Math.Max(1, (int)Math.Ceiling(widest / band));
				for (var c = 0; c < count; c++)
				{
					var x0 = plot.Left + band * c + (band - group) / 2;
					var stack = 0d;
					for (var s = 0; s < this.series.Count; s++)
					{
						var value = Math.Max(0, ValueAt(this.series[s], c));
						var h = plot.Height * value / max;
						Rect rect;
						if (this.Stacked)
						{
							rect = new Rect(x0, plot.Bottom - stack - h, group, h);
							stack += h;
						}
						else
						{
							var w = group / this.series.Count;
							rect = new Rect(x0 + w * s, plot.Bottom - h, Math.Max(1, w - 1), h);
						}
						AddBar(dc, rect, s, c);
					}

					if (c % step == 0)
					{
						var label = Text(Fit(this.categories[c], band * step - 4), SystemColors.ControlTextBrush);
						dc.DrawText(label, new Point(plot.Left + band * c + (band - label.Width) / 2, plot.Bottom + 4));
					}
				}
			}
			else
			{
				var categoryWidth = Math.Min(this.categories.Max(c => Text(c, Brushes.Black).Width), width * 0.35);
				var lastTick = Text(this.AxisFormat(max), Brushes.Black).Width;
				var plot = new Rect(categoryWidth + 10, top, Math.Max(10, width - categoryWidth - 10 - lastTick / 2 - 4), Math.Max(10, height - top - textHeight - 6));

				for (var i = 0; i <= Ticks; i++)
				{
					var x = Math.Round(plot.Left + plot.Width * i / Ticks) + 0.5;
					dc.DrawLine(i == 0 ? axisPen : gridPen, new Point(x, plot.Top), new Point(x, plot.Bottom));
					var label = Text(this.AxisFormat(max * i / Ticks), SystemColors.GrayTextBrush);
					dc.DrawText(label, new Point(x - label.Width / 2, plot.Bottom + 3));
				}

				var band = plot.Height / count;
				var group = Math.Min(band * 0.7, 22d * (this.Stacked ? 1 : this.series.Count));
				for (var c = 0; c < count; c++)
				{
					var y0 = plot.Top + band * c + (band - group) / 2;
					var stack = 0d;
					for (var s = 0; s < this.series.Count; s++)
					{
						var value = Math.Max(0, ValueAt(this.series[s], c));
						var w = plot.Width * value / max;
						Rect rect;
						if (this.Stacked)
						{
							rect = new Rect(plot.Left + stack, y0, w, group);
							stack += w;
						}
						else
						{
							var h = group / this.series.Count;
							rect = new Rect(plot.Left, y0 + h * s, w, Math.Max(1, h - 1));
						}
						AddBar(dc, rect, s, c);
					}

					var label = Text(Fit(this.categories[c], categoryWidth), SystemColors.ControlTextBrush);
					dc.DrawText(label, new Point(plot.Left - 6 - label.Width, plot.Top + band * c + (band - label.Height) / 2));
				}
			}
		}

		private double DrawLegend(DrawingContext dc, double width)
		{
			var x = 0d;
			var y = 2d;
			var rowHeight = 0d;
			foreach (var s in this.series)
			{
				var text = Text(s.Name ?? "", SystemColors.ControlTextBrush);
				var itemWidth = 14 + text.Width + 16;
				if (x > 0 && x + itemWidth > width)
				{
					x = 0;
					y += rowHeight + 2;
				}
				dc.DrawRectangle(new SolidColorBrush(s.Color), null, new Rect(x, y + (text.Height - 10) / 2, 10, 10));
				dc.DrawText(text, new Point(x + 14, y));
				x += itemWidth;
				rowHeight = Math.Max(rowHeight, text.Height);
			}
			return y + rowHeight;
		}

		private void AddBar(DrawingContext dc, Rect rect, int seriesIndex, int index)
		{
			if (rect.Width <= 0 || rect.Height <= 0)
				return;

			var color = this.series[seriesIndex].Color;
			if (this.hover != null && this.hover.SeriesIndex == seriesIndex && this.hover.Index == index)
				color = Color.FromRgb((byte)(color.R * 0.8), (byte)(color.G * 0.8), (byte)(color.B * 0.8));
			dc.DrawRectangle(new SolidColorBrush(color), null, rect);
			this.bars.Add(new Bar { Rect = rect, SeriesIndex = seriesIndex, Index = index });
		}

		private static double ValueAt(ChartSeries series, int index)
		{
			return index < series.Values.Length ? series.Values[index] : 0;
		}

		private FormattedText Text(string text, Brush brush)
		{
			return new FormattedText(text ?? "", Fmt.Culture, FlowDirection.LeftToRight,
				new Typeface(SystemFonts.MessageFontFamily, FontStyles.Normal, FontWeights.Normal, FontStretches.Normal),
				FontSize, brush, VisualTreeHelper.GetDpi(this).PixelsPerDip);
		}

		// shortens a label with an ellipsis to fit in width pixels.
		private string Fit(string text, double width)
		{
			text = text ?? "";
			if (Text(text, Brushes.Black).Width <= width)
				return text;
			while (text.Length > 1 && Text(text + "…", Brushes.Black).Width > width)
				text = text.Substring(0, text.Length - 1);
			return text.TrimEnd() + "…";
		}

		private Bar HitTest(Point point)
		{
			return this.bars.LastOrDefault(b =>
			{
				var rect = b.Rect;
				rect.Inflate(1, 1);
				return rect.Contains(point);
			});
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			var bar = HitTest(e.GetPosition(this));
			if (bar == this.hover)
				return;

			this.hover = bar;
			this.Cursor = bar != null && this.PointClick != null ? Cursors.Hand : null;
			if (bar == null)
			{
				this.ToolTip = null;
			}
			else
			{
				var s = this.series[bar.SeriesIndex];
				var label = this.categories[bar.Index] + (this.series.Count > 1 ? " · " + s.Name : "");
				this.ToolTip = label + ": " + this.ValueFormat(ValueAt(s, bar.Index));
			}
			InvalidateVisual();
		}

		protected override void OnMouseLeave(MouseEventArgs e)
		{
			base.OnMouseLeave(e);
			if (this.hover != null)
			{
				this.hover = null;
				InvalidateVisual();
			}
		}

		protected override void OnMouseLeftButtonUp(MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);

			var bar = HitTest(e.GetPosition(this));
			if (bar == null)
				return;

			var tag = bar.Index < this.tags.Length ? this.tags[bar.Index] : null;
			this.PointClick?.Invoke(this, new ChartPointEventArgs(bar.SeriesIndex, bar.Index, tag));
		}
	}

	/// <summary>
	/// A small line chart without axes, for the trend of a KPI or a table row.
	/// </summary>
	public class Sparkline : FrameworkElement
	{
		public static readonly DependencyProperty ValuesProperty = DependencyProperty.Register(
			nameof(Values), typeof(IList<double>), typeof(Sparkline),
			new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

		public Sparkline()
		{
			this.MinHeight = 16;
		}

		/// <summary>The values, oldest first.</summary>
		public IList<double> Values
		{
			get { return (IList<double>)GetValue(ValuesProperty); }
			set { SetValue(ValuesProperty, value); }
		}

		/// <summary>Colour of the line.</summary>
		public Color Color { get; set; } = ChartColors.Indigo.ToMedia();

		protected override void OnRender(DrawingContext dc)
		{
			var values = this.Values?.ToArray();
			var width = this.ActualWidth;
			var height = this.ActualHeight;
			if (values == null || values.Length < 2 || width < 4 || height < 4)
				return;

			var max = values.Max();
			var min = Math.Min(0, values.Min());
			var range = max - min <= 0 ? 1 : max - min;

			var geometry = new StreamGeometry();
			using (var context = geometry.Open())
			{
				for (var i = 0; i < values.Length; i++)
				{
					var point = new Point(1 + (width - 2) * i / (values.Length - 1), height - 1 - (height - 2) * (values[i] - min) / range);
					if (i == 0)
						context.BeginFigure(point, false, false);
					else
						context.LineTo(point, true, true);
				}
			}
			geometry.Freeze();
			dc.DrawGeometry(null, new Pen(new SolidColorBrush(this.Color), 1.5) { LineJoin = PenLineJoin.Round }, geometry);
		}
	}
}
