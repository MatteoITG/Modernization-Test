using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using RelayCrm.Services;
using Wisej.Web;

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
	/// A simple bar chart: vertical or horizontal bars, grouped or stacked series, a value axis with round ticks
	/// (<see cref="ChartColors.NiceMax"/>), a legend, tooltips and clickable bars.
	/// </summary>
	/// <remarks>
	/// The WPF version drew the bars by hand in OnRender with a DrawingContext. This port keeps the class and its API
	/// (SetData, ChartSeries, PointClick, Horizontal, Stacked, ...) so the dashboard and the reports call it unchanged,
	/// but it is now a Wisej 4.2 <see cref="ChartView"/>: the browser draws the chart, with hover, tooltips and resizing
	/// on the client, instead of a server-side OnPaint that would send a new image on every change.
	/// <para>
	/// Differences: the axis ticks take a .NET numeric format string (<see cref="AxisFormat"/>, e.g. "C0") instead of a
	/// function, and horizontal stacked bars are drawn as stacked columns (ChartView has no stacked bar type).
	/// </para>
	/// </remarks>
	[ToolboxItem(true)]
	public class BarChart : ChartView
	{
		private const int Ticks = 4;

		private readonly List<ChartSeries> series = new List<ChartSeries>();
		private string[] categories = new string[0];
		private object[] tags = new object[0];
		private bool horizontal;
		private bool stacked;
		private string emptyText = "No data";

		public BarChart()
		{
			this.Legend = ChartLegend.Hidden;
			this.Tooltip = ChartTooltip.Single;
			this.EmptyState = this.emptyText;
			this.YAxis.Min = 0;
			this.YAxis.Gridlines = true;
			this.YAxis.Format = "N0";

			// Wisej sends the clicks and the tooltip requests only to events with a handler attached.
			base.PointClick += BarChart_PointClick;
			this.TooltipShowing += BarChart_TooltipShowing;
		}

		/// <summary>Bars from the left (categories on the vertical axis) instead of from the bottom.</summary>
		[DefaultValue(false)]
		public bool Horizontal
		{
			get { return this.horizontal; }
			set { this.horizontal = value; Redraw(); }
		}

		/// <summary>Stacks the series of a category instead of placing them side by side.</summary>
		[DefaultValue(false)]
		public bool Stacked
		{
			get { return this.stacked; }
			set { this.stacked = value; Redraw(); }
		}

		/// <summary>Keeps the axis ticks on whole numbers (counts).</summary>
		[DefaultValue(false)]
		public bool WholeNumbers { get; set; }

		/// <summary>The .NET numeric format of the axis ticks, e.g. "N0" or "C0" (was a Func&lt;double, string&gt;).</summary>
		[DefaultValue("N0")]
		public string AxisFormat
		{
			get { return this.YAxis.Format; }
			set { this.YAxis.Format = value; }
		}

		/// <summary>Text of a value in the tooltip.</summary>
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Func<double, string> ValueFormat { get; set; } = v => v.ToString("N0", Fmt.Culture);

		/// <summary>Text shown when there are no categories.</summary>
		[DefaultValue("No data")]
		public string EmptyText
		{
			get { return this.emptyText; }
			set { this.emptyText = value; this.EmptyState = value; }
		}

		/// <summary>Raised when a bar is clicked.</summary>
		public new event EventHandler<ChartPointEventArgs> PointClick;

		/// <summary>Sets the categories, their tags (given back by <see cref="PointClick"/>) and the series, and redraws.</summary>
		public void SetData(IEnumerable<string> categories, IEnumerable<object> tags, params ChartSeries[] series)
		{
			this.categories = (categories ?? Enumerable.Empty<string>()).ToArray();
			this.tags = (tags ?? Enumerable.Empty<object>()).ToArray();
			this.series.Clear();
			this.series.AddRange(series ?? new ChartSeries[0]);
			Redraw();
		}

		// rebuilds the series of the ChartView from the data given to SetData (it was OnRender).
		private void Redraw()
		{
			this.Series.Clear();

			var count = this.categories.Length;
			if (count == 0 || this.series.Count == 0)
				return;

			var type = this.stacked ? ChartType.StackedColumn : this.horizontal ? ChartType.Bar : ChartType.Column;
			foreach (var s in this.series)
			{
				var chartSeries = new Wisej.Web.ChartSeries { Name = s.Name ?? "", ChartType = type, Color = s.Color };
				for (var c = 0; c < count; c++)
					chartSeries.Points.Add(new ChartPoint { Category = this.categories[c], Value = Math.Max(0, ValueAt(s, c)), Tag = c });
				this.Series.Add(chartSeries);
			}

			var totals = Enumerable.Range(0, count)
				.Select(i => this.stacked
					? this.series.Sum(s => Math.Max(0, ValueAt(s, i)))
					: this.series.Max(s => ValueAt(s, i)))
				.ToList();
			this.YAxis.Max = ChartColors.NiceMax(totals, this.WholeNumbers, Ticks) ?? (this.WholeNumbers ? Ticks : 1);
			this.Legend = this.series.Count > 1 ? ChartLegend.Bottom : ChartLegend.Hidden;
		}

		private static double ValueAt(ChartSeries series, int index)
		{
			return index < series.Values.Length ? series.Values[index] : 0;
		}

		private void BarChart_TooltipShowing(object sender, ChartTooltipEventArgs e)
		{
			if (!(e.Point?.Tag is int index) || e.SeriesIndex < 0 || e.SeriesIndex >= this.series.Count || index >= this.categories.Length)
				return;

			var s = this.series[e.SeriesIndex];
			var label = this.categories[index] + (this.series.Count > 1 ? " · " + s.Name : "");
			e.Text = label + ": " + this.ValueFormat(ValueAt(s, index));
		}

		private void BarChart_PointClick(object sender, SeriesPointEventArgs e)
		{
			var index = e.Point?.Tag is int i ? i : e.PointIndex;
			if (index < 0 || index >= this.categories.Length)
				return;

			var tag = index < this.tags.Length ? this.tags[index] : null;
			this.PointClick?.Invoke(this, new ChartPointEventArgs(e.SeriesIndex, index, tag));
		}
	}
}
