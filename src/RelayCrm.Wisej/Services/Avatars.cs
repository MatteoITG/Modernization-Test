using System;
using System.Drawing;
using System.Net;
using System.Text;

namespace RelayCrm.Services
{
	/// <summary>
	/// Avatar pictures: the initials of a name on a round patch of the user's colour.
	/// </summary>
	/// <remarks>
	/// Migration step 2: the WinForms version drew the avatars into bitmaps with GDI+; in the browser they are small
	/// SVG images (data URLs) for the Wisej Avatar control, avatar columns and image lists: no drawing on the server.
	/// </remarks>
	public static class Avatars
	{
		/// <summary>
		/// The image source of an avatar with the initials of <paramref name="name"/> on <paramref name="color"/>;
		/// <paramref name="rounded"/> draws a rounded square (companies) instead of a circle (people).
		/// </summary>
		public static string Source(string name, string color, bool rounded = false)
		{
			var back = ColorTranslator.ToHtml(ParseColor(color));
			var shape = rounded
				? "<rect width='64' height='64' rx='14' fill='" + back + "'/>"
				: "<circle cx='32' cy='32' r='32' fill='" + back + "'/>";
			var svg = "<svg xmlns='http://www.w3.org/2000/svg' width='64' height='64' viewBox='0 0 64 64'>" + shape
				+ "<text x='32' y='41' text-anchor='middle' font-family='Segoe UI,Roboto,Arial,sans-serif' font-size='24' font-weight='700' fill='#FFFFFF'>"
				+ WebUtility.HtmlEncode(Text.Initials(name)) + "</text></svg>";
			return "data:image/svg+xml;base64," + Convert.ToBase64String(Encoding.UTF8.GetBytes(svg));
		}

		/// <summary>The colour of an avatar ("#4F46E5"); the first colour of the palette when it is missing.</summary>
		public static Color ParseColor(string color)
		{
			if (string.IsNullOrEmpty(color) || color[0] != '#')
				color = SettingsService.AvatarPalette[0];
			try
			{
				return ColorTranslator.FromHtml(color);
			}
			catch (Exception)
			{
				return ColorTranslator.FromHtml(SettingsService.AvatarPalette[0]);
			}
		}
	}
}
