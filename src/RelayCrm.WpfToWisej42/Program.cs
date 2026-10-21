using System;
using System.Collections.Specialized;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm
{
	/// <summary>
	/// The application: opens the database, signs the user in and shows the main page.
	/// Wisej calls <see cref="Main"/> once for every browser session (it was App.OnStartup in WPF).
	/// </summary>
	/// <remarks>
	/// Development switches, now URL arguments: ?user=1 signs in without the dialog, ?page=DealsView opens a page,
	/// ?contact=5, ?company=5 or ?deal=5 open that record.
	/// Unhandled exceptions are written to RelayCrm.WpfToWisej42.errors.log next to the application.
	/// </remarks>
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application; <paramref name="args"/> are the arguments of the URL.
		/// </summary>
		static void Main(NameValueCollection args)
		{
			App.AddExceptionHandlers();

			RelayDbContext.DatabasePath = Application.MapPath("relay.db");
			CurrentUser.Bag = new WisejSessionBag();

			// step 2: the icon names of the services ("person", "briefcase"...) are the SVG files of the
			// Wisej BootstrapIcons extension (navigation bar, command palette, timelines, action cards).
			Icons.Prefix = "resource.wx/Wisej.Ext.BootstrapIcons/";
			Icons.Suffix = ".svg";

			if (!Notify.Try(DbSeeder.EnsureReady, "Opening the database"))
				return;

			var options = StartOptions.Parse(args);
			if (options.UserId != null)
				Notify.Try(() => CurrentUser.SignIn(options.UserId.Value), "Signing in");

			// the sign-in dialog is modal: without a user there is no main page (WPF shut the application down).
			if (!CurrentUser.IsSignedIn && !SignInDialog.SignIn())
			{
				SignInDialog.ShowSignedOut();
				return;
			}

			Application.MainPage = new MainWindow(options);
		}
	}
}
