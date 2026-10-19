using System;
using RelayCrm.Data;

namespace RelayCrm.Services
{
	/// <summary>
	/// The user signed in to this session (development sign-in, no real authentication provider).
	/// </summary>
	public static class CurrentUser
	{
		private const string SessionKey = "Relay.CurrentUser";

		/// <summary>
		/// Where the signed in user is kept. A desktop app has one user per process, so the default is a
		/// process-wide bag; a Wisej app sets a bag backed by Application.Session at startup.
		/// </summary>
		public static ISessionBag Bag { get; set; } = new ProcessBag();

		private static object Get(string key) => Bag[key];

		private static UserItem Item => Get(SessionKey) as UserItem;

		public static bool IsSignedIn => Item != null;

		public static int Id => Item?.Id ?? 0;

		public static string Name => Item?.Name ?? "";

		public static string Initials => Item?.Initials ?? "?";

		public static string Email => Item?.Email ?? "";

		public static UserRole Role => Item?.Role ?? UserRole.Sales;

		/// <summary>Managers and Admins see all records; Sales see their own by default.</summary>
		public static bool SeesAll => Role != UserRole.Sales;

		public static bool IsAdmin => Role == UserRole.Admin;

		/// <summary>Raised when the signed in user changes or is updated.</summary>
		public static event EventHandler Changed
		{
			add { Bag[SessionKey + ".Changed"] = (EventHandler)Get(SessionKey + ".Changed") + value; }
			remove { Bag[SessionKey + ".Changed"] = (EventHandler)Get(SessionKey + ".Changed") - value; }
		}

		public static void SignIn(int userId)
		{
			Bag[SessionKey] = LookupService.User(userId);
			RaiseChanged();
		}

		/// <summary>Reloads the user after the profile was edited.</summary>
		public static void Refresh()
		{
			if (IsSignedIn)
				SignIn(Id);
		}

		public static void SignOut()
		{
			Bag[SessionKey] = null;
			RaiseChanged();
		}

		private static void RaiseChanged()
		{
			((EventHandler)Get(SessionKey + ".Changed"))?.Invoke(null, EventArgs.Empty);
		}
	}

	/// <summary>
	/// Per-user state storage: one per process in a desktop app, one per browser session in a web app.
	/// </summary>
	public interface ISessionBag
	{
		object this[string key] { get; set; }
	}

	internal sealed class ProcessBag : ISessionBag
	{
		private readonly System.Collections.Generic.Dictionary<string, object> values = new System.Collections.Generic.Dictionary<string, object>();

		public object this[string key]
		{
			get => values.TryGetValue(key, out var value) ? value : null;
			set => values[key] = value;
		}
	}
}
