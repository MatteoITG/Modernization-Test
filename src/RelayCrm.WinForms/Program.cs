using System;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Windows.Forms;
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
		/// Development switches: --user=1 signs in without the dialog, --page=DealsView opens a page,
		/// --contact=5, --company=5 or --deal=5 open that record.
		/// </remarks>
		[STAThread]
		static void Main(string[] args)
		{
			ApplicationConfiguration.Initialize();

			// amounts are in USD and dates in US English everywhere (grids, charts), whatever the Windows locale.
			CultureInfo.DefaultThreadCurrentCulture = Fmt.Culture;
			Thread.CurrentThread.CurrentCulture = Fmt.Culture;
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			Application.ThreadException += Application_ThreadException;

			RelayDbContext.DatabasePath = Path.Combine(AppContext.BaseDirectory, "relay.db");

			if (!Notify.Try(DbSeeder.EnsureReady, "Opening the database"))
				return;

			var options = StartOptions.Parse(args);
			if (options.UserId != null)
				Notify.Try(() => CurrentUser.SignIn(options.UserId.Value), "Signing in");

			if (!CurrentUser.IsSignedIn && !SignInDialog.SignIn())
				return;

			Application.Run(new MainForm(options));
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
