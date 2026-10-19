using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Avatar pictures: the initials of a name on a round patch of the user's colour.
	/// </summary>
	public static class Avatars
	{
		/// <summary>A round avatar of <paramref name="size"/> pixels with the initials of <paramref name="name"/>.</summary>
		public static Image Create(string name, string color, int size)
		{
			var back = ParseColor(color);
			var bitmap = new Bitmap(size, size);
			using (var g = Graphics.FromImage(bitmap))
			using (var brush = new SolidBrush(back))
			using (var font = new Font("Segoe UI", size * 0.38f, FontStyle.Bold, GraphicsUnit.Pixel))
			{
				g.SmoothingMode = SmoothingMode.AntiAlias;
				g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
				g.FillEllipse(brush, 0, 0, size - 1, size - 1);
				using (var format = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
					g.DrawString(Text.Initials(name), font, Brushes.White, new RectangleF(0, 0, size, size), format);
			}
			return bitmap;
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
