using System;
using System.Globalization;
using System.Linq;

namespace RelayCrm
{
	/// <summary>
	/// Display formats shared by all views (money in USD, dates, relative dates).
	/// </summary>
	public static class Fmt
	{
		public static readonly CultureInfo Culture = CultureInfo.GetCultureInfo("en-US");

		/// <summary>$12,500</summary>
		public static string Money(decimal value)
		{
			return value.ToString("C0", Culture);
		}

		/// <summary>$12.5K, $1.2M</summary>
		public static string MoneyShort(decimal value)
		{
			var abs = Math.Abs(value);
			if (abs >= 1000000m)
				return (value / 1000000m).ToString("$0.#M", Culture);
			if (abs >= 1000m)
				return (value / 1000m).ToString("$0.#K", Culture);
			return value.ToString("$0", Culture);
		}

		/// <summary>Oct 15, 2026</summary>
		public static string Date(DateTime value)
		{
			return value.ToString("MMM d, yyyy", Culture);
		}

		/// <summary>Oct 15, 2026 · 14:30</summary>
		public static string DateAndTime(DateTime value)
		{
			return value.ToString("MMM d, yyyy · HH:mm", Culture);
		}

		/// <summary>42%</summary>
		public static string Percent(double value)
		{
			return Math.Round(value).ToString("0", Culture) + "%";
		}

		/// <summary>"today", "yesterday", "3 days ago", "in 5 days", "2 months ago", "never".</summary>
		public static string Relative(DateTime? value)
		{
			if (value == null)
				return "never";

			var days = (int)Math.Round((System.DateTime.Today - value.Value.Date).TotalDays);
			if (days == 0) return "today";
			if (days == 1) return "yesterday";
			if (days == -1) return "tomorrow";
			if (days < 0)
				return -days < 30 ? "in " + (-days) + " days" : "in " + (-days / 30) + " months";
			if (days < 30) return days + " days ago";
			if (days < 365) return (days / 30) + (days / 30 == 1 ? " month ago" : " months ago");
			return (days / 365) + (days / 365 == 1 ? " year ago" : " years ago");
		}
	}

	/// <summary>
	/// Small text helpers.
	/// </summary>
	public static class Text
	{
		/// <summary>"Morgan Price" → "MP".</summary>
		public static string Initials(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
				return "?";
			var parts = name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			return parts.Length == 1
				? parts[0].Substring(0, Math.Min(2, parts[0].Length)).ToUpperInvariant()
				: (parts[0].Substring(0, 1) + parts[parts.Length - 1].Substring(0, 1)).ToUpperInvariant();
		}

		/// <summary>Splits a comma separated tag list.</summary>
		public static string[] Tags(string tags)
		{
			return string.IsNullOrWhiteSpace(tags)
				? new string[0]
				: tags.Split(',').Select(t => t.Trim()).Where(t => t.Length > 0).ToArray();
		}

		/// <summary>True when <paramref name="text"/> contains <paramref name="search"/>, ignoring case.</summary>
		public static bool Has(string text, string search)
		{
			return !string.IsNullOrEmpty(text) && text.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0;
		}
	}
}
