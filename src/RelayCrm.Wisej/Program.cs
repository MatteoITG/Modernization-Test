using System;
using System.Collections.Specialized;
using System.Linq;
using System.Threading;
using Wisej.Web;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		/// <remarks>
		/// Development switches in the URL: ?user=1 signs in without the dialog, ?page=DealsView opens a page,
		/// ?contact=5, ?company=5 or ?deal=5 open that record.
		/// </remarks>
		static void Main(NameValueCollection query)
		{
			var args = query.AllKeys.Where(k => k != null).Select(k => k + "=" + query[k]).ToArray();

			// amounts are in USD and dates in US English everywhere (grids, charts), whatever the language of the browser.
			Application.CurrentCulture = Fmt.Culture;
			Application.ThreadException += Application_ThreadException;

			// WinForms closes a modal dialog when its DialogResult is set; Wisej does it when this default is on.
			// With it on, clicking a dialog's AcceptButton also sets DialogResult.OK and closes the dialog before
			// the button's Click handler runs, so dialogs that validate in Click don't set AcceptButton.
			Form.AutoCloseModalDialogDefault = true;

			RelayDbContext.DatabasePath = Application.MapPath("relay.db");

			// statics are shared by all the users of a web app: the signed in user lives in the session.
			CurrentUser.Bag = new WisejSessionBag();
			Icons.Prefix = "resource.wx/Wisej.Ext.BootstrapIcons/";
			Icons.Suffix = ".svg";

			if (!Notify.Try(DbSeeder.EnsureReady, "Opening the database"))
				return;

			var options = StartOptions.Parse(args);
			if (options.UserId != null)
				Notify.Try(() => CurrentUser.SignIn(options.UserId.Value), "Signing in");

			if (!CurrentUser.IsSignedIn && !SignInDialog.SignIn())
				return;

			new MainForm(options).Show();
		}

		private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			Notify.Error("Unexpected error: " + e.Exception.GetBaseException().Message);
		}
	}

	/// <summary>
	/// Command line switches of the development build.
	/// </summary>
	public class StartOptions
	{
		public int? UserId { get; set; }
		public string Page { get; set; }
		public int? ContactId { get; set; }
		public int? CompanyId { get; set; }
		public int? DealId { get; set; }

		public static StartOptions Parse(string[] args)
		{
			var options = new StartOptions();
			foreach (var arg in args ?? new string[0])
			{
				var parts = arg.TrimStart('-', '/').Split(new[] { '=' }, 2);
				if (parts.Length != 2)
					continue;

				var value = parts[1];
				int.TryParse(value, out var id);
				switch (parts[0].ToLowerInvariant())
				{
					case "user": options.UserId = id > 0 ? id : (int?)null; break;
					case "page": options.Page = value; break;
					case "contact": options.ContactId = id > 0 ? id : (int?)null; break;
					case "company": options.CompanyId = id > 0 ? id : (int?)null; break;
					case "deal": options.DealId = id > 0 ? id : (int?)null; break;
				}
			}
			return options;
		}
	}
}
