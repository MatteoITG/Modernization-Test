using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;

namespace RelayCrm.Services
{
	/// <summary>
	/// An entry of a list box with AllowHtml: the data item and the HTML that replaces its XAML DataTemplate.
	/// </summary>
	/// <remarks>
	/// The WPF lists drew each item with a DataTemplate of TextBlocks (bold title, muted description, coloured meta).
	/// A Wisej ListBox shows the text of its items, as HTML when AllowHtml is true: <see cref="Lines"/> builds that HTML.
	/// </remarks>
	public class TemplateItem
	{
		public TemplateItem(object data, string html)
		{
			this.Data = data;
			this.Html = html;
		}

		/// <summary>The data item (what the DataTemplate was bound to).</summary>
		public object Data { get; }

		/// <summary>The HTML shown by the list box.</summary>
		public string Html { get; }

		public override string ToString() => this.Html;

		/// <summary>Wraps every item of a list with the HTML made by <paramref name="template"/>.</summary>
		public static List<TemplateItem> Wrap<T>(IEnumerable<T> items, Func<T, string> template)
		{
			return (items ?? Enumerable.Empty<T>()).Select(i => new TemplateItem(i, template(i))).ToList();
		}

		/// <summary>HTML-encodes a text.</summary>
		public static string Encode(string text)
		{
			return WebUtility.HtmlEncode(text ?? "");
		}

		/// <summary>A line of the template: encoded text, optionally bold, coloured and small; long lines end with an ellipsis.</summary>
		public static string Line(string text, bool bold = false, Color color = default, bool small = false)
		{
			var style = "overflow:hidden;text-overflow:ellipsis;white-space:nowrap;line-height:1.35;";
			if (bold)
				style += "font-weight:600;";
			if (!color.IsEmpty)
				style += "color:" + color.ToHtml() + ";";
			if (small)
				style += "font-size:11px;";
			return "<div style=\"" + style + "\">" + Encode(text) + "</div>";
		}

		/// <summary>A run of text inside a line (a WPF Run): encoded, optionally bold and coloured.</summary>
		public static string Run(string text, bool bold = false, Color color = default)
		{
			var style = "";
			if (bold)
				style += "font-weight:600;";
			if (!color.IsEmpty)
				style += "color:" + color.ToHtml() + ";";
			return style.Length == 0 ? Encode(text) : "<span style=\"" + style + "\">" + Encode(text) + "</span>";
		}

		/// <summary>The lines of an item, with the vertical margin of the WPF StackPanel.</summary>
		public static string Lines(params string[] lines)
		{
			return "<div style=\"padding:3px 0;\">" + string.Concat(lines) + "</div>";
		}

		/// <summary>
		/// The avatar of the templates (a WPF Ellipse with the initials on top) followed by the lines of the item.
		/// </summary>
		public static string WithAvatar(string initials, Color color, string lines, int size = 34)
		{
			return "<div style=\"display:flex;align-items:center;padding:4px 2px;\">"
				+ "<div style=\"flex:none;width:" + size + "px;height:" + size + "px;border-radius:50%;background:" + color.ToHtml()
				+ ";color:#FFFFFF;font-weight:600;display:flex;align-items:center;justify-content:center;margin-right:10px;\">"
				+ Encode(initials) + "</div>"
				+ "<div style=\"flex:1;min-width:0;\">" + lines + "</div></div>";
		}
	}
}
