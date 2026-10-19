namespace RelayCrm.Services
{
	/// <summary>
	/// Icon names used by the services are Bootstrap Icons names ("person", "briefcase", ...).
	/// Each user interface decides how a name becomes an image: the Wisej versions point at the
	/// BootstrapIcons extension, the WinForms version maps the name to a bundled bitmap.
	/// </summary>
	public static class Icons
	{
		/// <summary>Text placed before the icon name, e.g. "resource.wx/Wisej.Ext.BootstrapIcons/".</summary>
		public static string Prefix { get; set; } = "";

		/// <summary>Text placed after the icon name, e.g. ".svg".</summary>
		public static string Suffix { get; set; } = "";

		public static string Get(string name)
		{
			return Prefix + name + Suffix;
		}

		/// <summary>Returns the plain icon name of a value produced by <see cref="Get"/>.</summary>
		public static string NameOf(string icon)
		{
			if (string.IsNullOrEmpty(icon))
				return icon;
			if (Prefix.Length > 0 && icon.StartsWith(Prefix))
				icon = icon.Substring(Prefix.Length);
			if (Suffix.Length > 0 && icon.EndsWith(Suffix))
				icon = icon.Substring(0, icon.Length - Suffix.Length);
			return icon;
		}
	}

	/// <summary>
	/// Semantic colour of a chip, badge or card icon. The user interfaces map it to their own colours.
	/// </summary>
	public enum Tone
	{
		Neutral,
		Primary,
		Success,
		Warning,
		Danger
	}
}
