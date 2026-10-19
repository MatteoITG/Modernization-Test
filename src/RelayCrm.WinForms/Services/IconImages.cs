using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;

namespace RelayCrm.Services
{
	/// <summary>
	/// Turns the Bootstrap icon names used by the services ("person", "briefcase", ...) into small bitmaps
	/// for menus, toolbars, tree and list views. The glyphs come from the Segoe MDL2 Assets font that ships
	/// with Windows 10 and 11; without the font there are no images, only text.
	/// </summary>
	public static class IconImages
	{
		private const string FontName = "Segoe MDL2 Assets";

		private static readonly Dictionary<string, char> Glyphs = new Dictionary<string, char>(StringComparer.OrdinalIgnoreCase)
		{
			{ "speedometer2", '' },
			{ "person", '' },
			{ "people", '' },
			{ "building", '' },
			{ "briefcase", '' },
			{ "calendar-event", '' },
			{ "check2-square", '' },
			{ "square", '' },
			{ "bar-chart", '' },
			{ "gear", '' },
			{ "telephone", '' },
			{ "envelope", '' },
			{ "sticky", '' },
			{ "exclamation-circle", '' },
			{ "search", '' },
			{ "arrow-left", '' },
			{ "bell", '' },
			{ "plus", '' },
			{ "arrow-clockwise", '' },
			{ "pencil", '' },
			{ "trash", '' },
			{ "funnel", '' },
			{ "download", '' },
			{ "layout-three-columns", '' },
			{ "box-arrow-right", '' },
			{ "check-lg", '' },
			{ "journal-plus", '' },
		};

		private static readonly Dictionary<string, Image> Cache = new Dictionary<string, Image>();
		private static bool? fontInstalled;

		/// <summary>
		/// The icon <paramref name="name"/> (a Bootstrap icon name, or a value of Icons.Get) as a bitmap of
		/// <paramref name="size"/> pixels, or null when it is unknown.
		/// </summary>
		public static Image Get(string name, int size = 16, Color? color = null)
		{
			name = Icons.NameOf(name);
			if (string.IsNullOrEmpty(name) || !Glyphs.TryGetValue(name, out var glyph) || !FontInstalled)
				return null;

			var c = color ?? SystemColors.ControlText;
			var key = name + "|" + size + "|" + c.ToArgb();
			if (Cache.TryGetValue(key, out var image))
				return image;

			var bitmap = new Bitmap(size, size);
			using (var g = Graphics.FromImage(bitmap))
			using (var font = new Font(FontName, size * 0.75f, FontStyle.Regular, GraphicsUnit.Pixel))
			{
				g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
				TextRenderer.DrawText(g, glyph.ToString(), font, new Rectangle(0, 0, size, size), c,
					TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);
			}
			Cache[key] = bitmap;
			return bitmap;
		}

		/// <summary>An image list with the icons <paramref name="names"/>, keyed by name.</summary>
		public static ImageList List(int size, params string[] names)
		{
			var list = new ImageList { ImageSize = new Size(size, size), ColorDepth = ColorDepth.Depth32Bit };
			foreach (var name in names)
			{
				var image = Get(name, size);
				if (image != null)
					list.Images.Add(name, image);
			}
			return list;
		}

		/// <summary>Sets the images of toolbar and menu items from their Tag (the icon name).</summary>
		public static void Apply(ToolStrip strip)
		{
			foreach (ToolStripItem item in strip.Items)
				Apply(item);
		}

		private static void Apply(ToolStripItem item)
		{
			if (item.Tag is string name && item.Image == null)
			{
				var size = (int)Math.Round(16 * item.Owner?.DeviceDpi / 96f ?? 16);
				item.Image = Get(name, Math.Max(16, size));
			}
			if (item is ToolStripDropDownItem dropDown)
			{
				foreach (ToolStripItem child in dropDown.DropDownItems)
					Apply(child);
			}
		}

		private static bool FontInstalled
		{
			get
			{
				if (fontInstalled == null)
				{
					using (var font = new Font(FontName, 10f))
						fontInstalled = string.Equals(font.Name, FontName, StringComparison.OrdinalIgnoreCase);
				}
				return fontInstalled.Value;
			}
		}
	}
}
