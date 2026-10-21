using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using RelayCrm.Data;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm
{
	/// <summary>
	/// Maps the UI-neutral <see cref="Tone"/> of the shared services to text colours of the standard controls.
	/// </summary>
	/// <remarks>
	/// WPF brushes became <see cref="Color"/> values; <see cref="Color.Empty"/> means "the colour of the theme"
	/// (it was SystemColors.ControlTextBrush).
	/// </remarks>
	internal static class ToneExtensions
	{
		private static readonly Color PrimaryColor = Color.FromArgb(0, 84, 166);
		private static readonly Color SuccessColor = Color.FromArgb(16, 124, 16);
		private static readonly Color WarningColor = Color.FromArgb(178, 94, 0);
		private static readonly Color DangerColor = Color.FromArgb(196, 43, 28);

		/// <summary>Secondary text (SystemColors.GrayTextBrush in WPF).</summary>
		public static readonly Color MutedColor = Color.FromArgb(107, 114, 128);

		/// <summary>The accent of the brand ("Relay" logo, avatars).</summary>
		public static readonly Color AccentColor = Color.FromArgb(79, 70, 229);

		public static Color ToColor(this Tone tone)
		{
			switch (tone)
			{
				case Tone.Primary: return PrimaryColor;
				case Tone.Success: return SuccessColor;
				case Tone.Warning: return WarningColor;
				case Tone.Danger: return DangerColor;
				default: return MutedColor;
			}
		}

		/// <summary>Step 2: the tone as the tone of a Wisej 4.2 chip, meter, timeline marker or KPI card.</summary>
		public static ChipTone ToChip(this Tone tone) => Parse<ChipTone>(tone);

		public static MeterTone ToMeter(this Tone tone) => Parse<MeterTone>(tone);

		public static TimelineTone ToTimeline(this Tone tone) => Parse<TimelineTone>(tone);

		public static KpiTone ToKpi(this Tone tone) => Parse<KpiTone>(tone);

		private static T Parse<T>(Tone tone) where T : struct
		{
			return Enum.TryParse(tone.ToString(), out T value) ? value : default(T);
		}

		/// <summary>Adds the chip tones of the lifecycle stage names to <paramref name="map"/> (DataGridViewChipColumn.ToneMap).</summary>
		public static void AddStageTones(IDictionary<string, ChipTone> map)
		{
			foreach (LifecycleStage stage in Enum.GetValues(typeof(LifecycleStage)))
				map[stage.ToString()] = StageTone(stage).ToChip();
		}

		/// <summary>Adds the chip tones of the task status texts ("Overdue", "Due soon", "Done", "Open") to <paramref name="map"/>.</summary>
		public static void AddTaskStatusTones(IDictionary<string, ChipTone> map)
		{
			foreach (var status in new[] { "Overdue", "Due soon", "Done", "Open" })
				map[status] = TaskStatusTone(status).ToChip();
		}

		/// <summary>Adds the chip tones of the task priorities ("High", "Normal", "Low") to <paramref name="map"/>.</summary>
		public static void AddPriorityTones(IDictionary<string, ChipTone> map)
		{
			map["High"] = ChipTone.Danger;
			map["Normal"] = ChipTone.Primary;
			map["Low"] = ChipTone.Neutral;
		}

		/// <summary>The tone of a DealRow.CloseTone name ("Warning", "Danger", ...).</summary>
		public static Tone ParseTone(string name)
		{
			return Enum.TryParse(name, out Tone tone) ? tone : Tone.Neutral;
		}

		/// <summary>Lead = Neutral, Prospect = Warning, Customer = Success, Churned = Danger.</summary>
		public static Tone StageTone(LifecycleStage stage)
		{
			switch (stage)
			{
				case LifecycleStage.Prospect: return Tone.Warning;
				case LifecycleStage.Customer: return Tone.Success;
				case LifecycleStage.Churned: return Tone.Danger;
				default: return Tone.Neutral;
			}
		}

		/// <summary>The tone of a lifecycle stage name of a list row.</summary>
		public static Tone StageTone(string stage)
		{
			return Enum.TryParse(stage, out LifecycleStage value) ? StageTone(value) : Tone.Neutral;
		}

		/// <summary>Won = Success, Lost = Danger, other stages Primary.</summary>
		public static Tone DealStageTone(bool isWon, bool isLost)
		{
			return isWon ? Tone.Success : isLost ? Tone.Danger : Tone.Primary;
		}

		/// <summary>Done = Success, Overdue = Danger, Due soon = Warning, Open = Primary.</summary>
		public static Tone TaskStatusTone(string status)
		{
			switch (status)
			{
				case "Done": return Tone.Success;
				case "Overdue": return Tone.Danger;
				case "Due soon": return Tone.Warning;
				default: return Tone.Primary;
			}
		}

		/// <summary>A colour of a #RRGGBB text; the first avatar colour when it cannot be read.</summary>
		public static Color ColorOf(string html)
		{
			try
			{
				return ColorTranslator.FromHtml(string.IsNullOrEmpty(html) ? SettingsService.AvatarPalette[0] : html);
			}
			catch (Exception)
			{
				return ColorTranslator.FromHtml(SettingsService.AvatarPalette[0]);
			}
		}

		/// <summary>The colour as #RRGGBB, for the HTML of the list templates.</summary>
		public static string ToHtml(this Color color)
		{
			return color.IsEmpty ? "inherit" : "#" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
		}
	}

	/// <summary>
	/// Text colour of a value: a <see cref="Tone"/>, an <see cref="ActivityType"/>, a tone name, or with the parameter
	/// "Stage" a lifecycle stage name, "TaskStatus" a task status, "Priority" a task priority.
	/// </summary>
	/// <remarks>
	/// Was an IValueConverter used by the XAML bindings; the grids call it from <see cref="GridHelper"/>.
	/// </remarks>
	public static class ToneBrushConverter
	{
		public static Color Convert(object value, string parameter)
		{
			if (value is Tone tone)
				return tone.ToColor();
			if (value is ActivityType type)
				return ActivityService.Tone(type).ToColor();

			var text = System.Convert.ToString(value, CultureInfo.InvariantCulture) ?? "";
			switch (parameter)
			{
				case "Stage": return ToneExtensions.StageTone(text).ToColor();
				case "TaskStatus": return ToneExtensions.TaskStatusTone(text).ToColor();
				case "Priority": return (text == "High" ? Tone.Danger : text == "Normal" ? Tone.Primary : Tone.Neutral).ToColor();
				default: return ToneExtensions.ParseTone(text).ToColor();
			}
		}
	}

	/// <summary>
	/// Formats a value with <see cref="Fmt"/>; parameter: Money, MoneyShort, Date, DateTime, Relative or Percent.
	/// </summary>
	/// <remarks>
	/// Was an IValueConverter used by the XAML bindings; the grids call it from <see cref="GridHelper"/>.
	/// </remarks>
	public static class FmtConverter
	{
		public static string Convert(object value, string parameter)
		{
			if (value == null)
				return parameter == "Relative" ? Fmt.Relative(null) : "";

			switch (parameter)
			{
				case "Money": return Fmt.Money(System.Convert.ToDecimal(value, CultureInfo.InvariantCulture));
				case "MoneyShort": return Fmt.MoneyShort(System.Convert.ToDecimal(value, CultureInfo.InvariantCulture));
				case "Date": return value is DateTime d ? Fmt.Date(d) : value.ToString();
				case "DateTime": return value is DateTime dt ? Fmt.DateAndTime(dt) : value.ToString();
				case "Relative": return value is DateTime r ? Fmt.Relative(r) : value.ToString();
				case "Percent": return Fmt.Percent(System.Convert.ToDouble(value, CultureInfo.InvariantCulture));
				default: return System.Convert.ToString(value, Fmt.Culture);
			}
		}
	}
}
