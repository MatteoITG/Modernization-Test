using System;
using System.Collections.Generic;
using System.Linq;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Common look and behaviour of the ChartView charts of the dashboard.
	/// </summary>
	/// <remarks>
	/// Step 2: the dashboard charts are plain Wisej 4.2 ChartViews with their series in the designer (step 1 used the
	/// <see cref="Controls.BarChart"/> subclass, which the reports still use). The drill-downs use the PointClick event,
	/// and the tooltips show the amounts with <see cref="Fmt.Money"/>.
	/// </remarks>
	public static class ChartStyle
	{
		/// <summary>Applies the common look to <paramref name="chart"/>; <paramref name="format"/> is the .NET format of the value axis.</summary>
		public static void Apply(ChartView chart, string format = "C0")
		{
			chart.Palette = ChartColors.Palette;
			chart.YAxis.Format = format;
			chart.YAxis.Min = 0;
			chart.YAxis.Gridlines = true;
			chart.TooltipShowing -= Chart_TooltipShowing;
			chart.TooltipShowing += Chart_TooltipShowing;
		}

		/// <summary>Replaces the points of <paramref name="series"/>; the tags are given back by the PointClick event.</summary>
		public static void SetPoints<T>(ChartSeries series, IEnumerable<T> items, Func<T, string> category, Func<T, double> value)
		{
			series.Points.Clear();
			foreach (var item in items)
				series.Points.Add(new ChartPoint { Category = category(item), Value = Math.Max(0, value(item)), Tag = item });
		}

		/// <summary>Sets a round maximum on the value axis (four round ticks), or lets the chart choose without data.</summary>
		public static void SetMaximum(ChartView chart)
		{
			var values = chart.Series.SelectMany(s => s.Points.Select(p => p.Value)).ToList();
			chart.YAxis.Max = ChartColors.NiceMax(values);
		}

		// the tooltip of a bar: "Discovery (4): $120,000".
		private static void Chart_TooltipShowing(object sender, ChartTooltipEventArgs e)
		{
			var chart = (ChartView)sender;
			if (e.Point == null)
				return;

			var series = e.SeriesIndex >= 0 && e.SeriesIndex < chart.Series.Count && chart.Series.Count > 1
				? " · " + chart.Series[e.SeriesIndex].Name
				: "";
			e.Text = e.Point.Category + series + ": " + Fmt.Money((decimal)e.Point.Value);
		}
	}
}
