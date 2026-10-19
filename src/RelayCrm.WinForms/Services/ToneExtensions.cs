using System;
using System.Drawing;
using RelayCrm.Data;
using RelayCrm.Services;

namespace RelayCrm
{
	/// <summary>
	/// Maps the UI-neutral <see cref="Tone"/> of the shared services to text colours of the standard controls.
	/// </summary>
	internal static class ToneExtensions
	{
		public static Color ToColor(this Tone tone)
		{
			switch (tone)
			{
				case Tone.Primary: return Color.FromArgb(0, 84, 166);
				case Tone.Success: return Color.FromArgb(16, 124, 16);
				case Tone.Warning: return Color.FromArgb(178, 94, 0);
				case Tone.Danger: return Color.FromArgb(196, 43, 28);
				default: return SystemColors.GrayText;
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
	}
}
