using System;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm
{
	/// <summary>
	/// Maps the UI-neutral <see cref="Tone"/> of the shared services to the tone enums of the Wisej 4.2 controls.
	/// </summary>
	internal static class ToneExtensions
	{
		public static MeterTone ToMeter(this Tone tone) => Parse<MeterTone>(tone);

		public static ChipTone ToChip(this Tone tone) => Parse<ChipTone>(tone);

		public static ActionCardTone ToCard(this Tone tone) => Parse<ActionCardTone>(tone);

		private static T Parse<T>(Tone tone) where T : struct
		{
			return Enum.TryParse(tone.ToString(), out T value) ? value : default(T);
		}
	}
}
