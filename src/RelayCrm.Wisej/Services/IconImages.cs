using System;
using System.Collections.Generic;
using Wisej.Web;

namespace RelayCrm.Services
{
	/// <summary>
	/// Turns the Bootstrap icon names used by the services ("person", "briefcase", ...) into images
	/// for menus, toolbars, tree and list views.
	/// Migration: the WinForms version drew the glyphs of the Segoe MDL2 Assets font into bitmaps; in the browser
	/// the images are the SVG files of the Wisej BootstrapIcons extension (Icons.Prefix/Suffix are set in Program.Main).
	/// </summary>
	public static class IconImages
	{
		private static readonly HashSet<string> Names = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
		{
			"speedometer2", "person", "people", "building", "briefcase", "calendar-event", "check2-square", "square",
			"bar-chart", "gear", "telephone", "envelope", "sticky", "exclamation-circle", "search", "arrow-left", "bell",
			"plus", "arrow-clockwise", "pencil", "trash", "funnel", "download", "layout-three-columns", "box-arrow-right",
			"check-lg", "journal-plus",
		};

		/// <summary>
		/// The icon <paramref name="name"/> (a Bootstrap icon name, or a value of Icons.Get) as an image source,
		/// or null when it is unknown.
		/// </summary>
		public static string Get(string name)
		{
			name = Icons.NameOf(name);
			return string.IsNullOrEmpty(name) || !Names.Contains(name) ? null : Icons.Get(name);
		}

		/// <summary>An image list with the icons <paramref name="names"/>, keyed by name.</summary>
		public static ImageList List(int size, params string[] names)
		{
			var list = new ImageList { ImageSize = new System.Drawing.Size(size, size) };
			foreach (var name in names)
			{
				var image = Get(name);
				if (image != null)
					list.Images.Add(name, image);
			}
			return list;
		}

		/// <summary>Sets the images of toolbar buttons and their drop-down menus from their Tag (the icon name).</summary>
		public static void Apply(ToolBar bar)
		{
			foreach (ToolBarButton button in bar.Buttons)
			{
				if (button.Tag is string name && button.ImageSource == null)
					button.ImageSource = Get(name);
				if (button.DropDownMenu != null)
					Apply(button.DropDownMenu);
			}
		}

		/// <summary>Sets the images of menu items from their Tag (the icon name).</summary>
		public static void Apply(Menu menu)
		{
			foreach (MenuItem item in menu.MenuItems)
			{
				if (item.Tag is string name && string.IsNullOrEmpty(item.IconSource))
					item.IconSource = Get(name);
				Apply(item);
			}
		}

		/// <summary>Sets the images of the items of a menu bar from their Tag (the icon name).</summary>
		public static void Apply(MenuBar bar)
		{
			foreach (MenuItem item in bar.MenuItems)
				Apply(item);
		}
	}
}
