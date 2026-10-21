using System;
using System.Windows;
using System.Windows.Media;

namespace RelayCrm.Services
{
	/// <summary>
	/// An entry of an activity list (the timelines of the dashboard and the detail pages).
	/// </summary>
	public class TimelineEntry
	{
		public TimelineEntry(DateTime date, string title, string description)
		{
			this.Date = date;
			this.Title = title;
			this.Description = description;
			this.Time = Fmt.DateAndTime(date);
		}

		public DateTime Date { get; }
		public string Title { get; }
		public string Description { get; }

		/// <summary>"Oct 15, 2026 · 14:30".</summary>
		public string Time { get; }

		/// <summary>Colour of the title: planned activities use the accent.</summary>
		public Brush TitleBrush { get; set; } = SystemColors.ControlTextBrush;

		/// <summary>The record behind the entry.</summary>
		public object Tag { get; set; }
	}
}
