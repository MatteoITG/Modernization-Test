using System;
using System.Linq;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Common look and behaviour of the charts. Migration: the WinForms version styled the
	/// System.Windows.Forms.DataVisualization chart (GDI+, Windows only); the Wisej version styles the
	/// Wisej 4.2 ChartView, which is drawn in the browser. The drill-downs use the PointClick event of
	/// the chart instead of a hit test under the mouse, and the browser shows the hand cursor by itself.
	/// </summary>
	public static class ChartStyle
	{
		/// <summary>Applies the common look to <paramref name="chart"/>; <paramref name="format"/> formats the value axis.</summary>
		public static void Apply(ChartView chart, string format = "N0")
		{
			chart.Palette = ChartColors.Palette;
			// the chart formats the axis ticks with the standard .NET formats only ("C0", "N0", "P0"...).
			chart.YAxis.Format = format.Length <= 3 ? format : "C0";
			chart.YAxis.Min = 0;
			chart.YAxis.Gridlines = true;
		}

		/// <summary>Sets a round maximum on the value axis, or lets the chart choose without data.</summary>
		public static void SetMaximum(ChartView chart, double? max)
		{
			chart.YAxis.Max = max;
		}

		/// <summary>Adds a category point, like DataPointCollection.AddXY of the WinForms chart; returns its index.</summary>
		public static int AddXY(this ChartPointCollection points, string category, double value)
		{
			points.Add(new ChartPoint { Category = category, Value = value });
			return points.Count - 1;
		}

		/// <summary>Removes the points of every series.</summary>
		public static void Clear(ChartView chart)
		{
			foreach (var series in chart.Series)
				series.Points.Clear();
		}
	}
}
