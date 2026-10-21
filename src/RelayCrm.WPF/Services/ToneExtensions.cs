using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using RelayCrm.Data;
using RelayCrm.Services;

namespace RelayCrm
{
	/// <summary>
	/// Maps the UI-neutral <see cref="Tone"/> of the shared services to text colours of the standard controls.
	/// </summary>
	internal static class ToneExtensions
	{
		private static readonly Brush PrimaryBrush = Freeze(Color.FromRgb(0, 84, 166));
		private static readonly Brush SuccessBrush = Freeze(Color.FromRgb(16, 124, 16));
		private static readonly Brush WarningBrush = Freeze(Color.FromRgb(178, 94, 0));
		private static readonly Brush DangerBrush = Freeze(Color.FromRgb(196, 43, 28));

		public static Brush ToBrush(this Tone tone)
		{
			switch (tone)
			{
				case Tone.Primary: return PrimaryBrush;
				case Tone.Success: return SuccessBrush;
				case Tone.Warning: return WarningBrush;
				case Tone.Danger: return DangerBrush;
				default: return SystemColors.GrayTextBrush;
			}
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

		/// <summary>A WPF colour of a chart colour of the Core.</summary>
		public static Color ToMedia(this System.Drawing.Color color)
		{
			return Color.FromArgb(color.A, color.R, color.G, color.B);
		}

		/// <summary>A brush of a #RRGGBB colour; the first avatar colour when it cannot be read.</summary>
		public static Brush BrushOf(string html)
		{
			try
			{
				return Freeze((Color)ColorConverter.ConvertFromString(string.IsNullOrEmpty(html) ? SettingsService.AvatarPalette[0] : html));
			}
			catch (FormatException)
			{
				return Freeze((Color)ColorConverter.ConvertFromString(SettingsService.AvatarPalette[0]));
			}
		}

		private static Brush Freeze(Color color)
		{
			var brush = new SolidColorBrush(color);
			brush.Freeze();
			return brush;
		}
	}

	/// <summary>
	/// Text colour of a value: a <see cref="Tone"/>, an <see cref="ActivityType"/>, a tone name, or with ConverterParameter
	/// "Stage" a lifecycle stage name, "TaskStatus" a task status, "Priority" a task priority.
	/// </summary>
	public class ToneBrushConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value is Tone tone)
				return tone.ToBrush();
			if (value is ActivityType type)
				return ActivityService.Tone(type).ToBrush();

			var text = System.Convert.ToString(value, CultureInfo.InvariantCulture) ?? "";
			switch (parameter as string)
			{
				case "Stage": return ToneExtensions.StageTone(text).ToBrush();
				case "TaskStatus": return ToneExtensions.TaskStatusTone(text).ToBrush();
				case "Priority": return (text == "High" ? Tone.Danger : text == "Normal" ? Tone.Primary : Tone.Neutral).ToBrush();
				default: return ToneExtensions.ParseTone(text).ToBrush();
			}
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return DependencyProperty.UnsetValue;
		}
	}

	/// <summary>
	/// Formats a value with <see cref="Fmt"/>; ConverterParameter: Money, MoneyShort, Date, DateTime, Relative or Percent.
	/// </summary>
	public class FmtConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			if (value == null)
				return (parameter as string) == "Relative" ? Fmt.Relative(null) : "";

			switch (parameter as string)
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

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return DependencyProperty.UnsetValue;
		}
	}

	/// <summary>
	/// The initials of a name ("Morgan Price" → "MP"), for the avatars.
	/// </summary>
	public class InitialsConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return RelayCrm.Text.Initials(value as string);
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			return DependencyProperty.UnsetValue;
		}
	}
}
