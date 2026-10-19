using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace RelayCrm.Services
{
	/// <summary>
	/// Common look and behaviour of the charts (System.Windows.Forms.DataVisualization): the shared palette,
	/// light gridlines, axis formats, and finding the data point under the mouse for the drill-downs.
	/// </summary>
	public static class ChartStyle
	{
		/// <summary>Applies the common look to <paramref name="chart"/>; <paramref name="format"/> formats the value axis.</summary>
		public static void Apply(Chart chart, string format = "N0")
		{
			chart.Palette = ChartColorPalette.None;
			chart.PaletteCustomColors = ChartColors.Palette;
			chart.BackColor = SystemColors.Window;
			chart.AntiAliasing = AntiAliasingStyles.All;
			chart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;

			foreach (var area in chart.ChartAreas)
			{
				area.BackColor = SystemColors.Window;
				foreach (var axis in new[] { area.AxisX, area.AxisY })
				{
					axis.LabelStyle.Font = chart.Font;
					axis.LabelStyle.ForeColor = SystemColors.ControlText;
					axis.LineColor = SystemColors.ControlDark;
					axis.MajorTickMark.LineColor = SystemColors.ControlDark;
					axis.MajorGrid.LineColor = SystemColors.ControlLight;
					axis.TitleFont = chart.Font;
				}
				area.AxisX.MajorGrid.Enabled = false;
				area.AxisX.Interval = 1;
				area.AxisX.IsLabelAutoFit = true;
				area.AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont | LabelAutoFitStyles.WordWrap;
				area.AxisY.LabelStyle.Format = format;
				area.AxisY.Minimum = 0;
			}

			foreach (var legend in chart.Legends)
			{
				legend.Font = chart.Font;
				legend.BackColor = SystemColors.Window;
			}

			// categories are texts: the points are placed by their index, not by an X value.
			foreach (var series in chart.Series)
			{
				series.Font = chart.Font;
				series.IsXValueIndexed = true;
			}
		}

		/// <summary>Sets a round maximum on the value axis (4 intervals), or lets the chart choose without data.</summary>
		public static void SetMaximum(Chart chart, double? max)
		{
			var axis = chart.ChartAreas[0].AxisY;
			if (max == null)
			{
				axis.Maximum = double.NaN;
				axis.Interval = double.NaN;
			}
			else
			{
				axis.Maximum = max.Value;
				axis.Interval = max.Value / 4;
			}
		}

		/// <summary>Removes the points of every series.</summary>
		public static void Clear(Chart chart)
		{
			foreach (var series in chart.Series)
				series.Points.Clear();
		}

		/// <summary>
		/// The data point under the mouse and the index of its series, or null; the bar, its label and the axis label count.
		/// </summary>
		public static DataPoint PointAt(Chart chart, Point location, out int seriesIndex)
		{
			seriesIndex = -1;
			HitTestResult hit;
			try
			{
				hit = chart.HitTest(location.X, location.Y);
			}
			catch (Exception)
			{
				return null;
			}

			if ((hit.ChartElementType == ChartElementType.DataPoint || hit.ChartElementType == ChartElementType.DataPointLabel)
				&& hit.Series != null && hit.PointIndex >= 0)
			{
				seriesIndex = chart.Series.IndexOf(hit.Series);
				return hit.Series.Points[hit.PointIndex];
			}

			// a category label of the X axis: the first series' point of that category.
			if (hit.ChartElementType == ChartElementType.AxisLabels && hit.Object is CustomLabel label && chart.Series.Count > 0)
			{
				var series = chart.Series[0];
				var point = series.Points.FirstOrDefault(p => p.AxisLabel == label.Text);
				if (point != null)
				{
					seriesIndex = 0;
					return point;
				}
			}
			return null;
		}

		/// <summary>Shows the hand cursor over the clickable points.</summary>
		public static void UpdateCursor(Chart chart, Point location)
		{
			chart.Cursor = PointAt(chart, location, out _) != null ? Cursors.Hand : Cursors.Default;
		}
	}
}
