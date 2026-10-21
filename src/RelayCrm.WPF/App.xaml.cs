using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using RelayCrm.Data;
using RelayCrm.Dialogs;
using RelayCrm.Services;

namespace RelayCrm
{
	/// <summary>
	/// The application: opens the database, signs the user in and shows the main window.
	/// </summary>
	/// <remarks>
	/// Development switches: --user=1 signs in without the dialog, --page=DealsView opens a page,
	/// --contact=5, --company=5 or --deal=5 open that record.
	/// Unhandled exceptions are written to RelayCrm.WPF.errors.log next to the executable.
	/// </remarks>
	public partial class App : Application
	{
		/// <summary>The log of unhandled exceptions, next to the executable.</summary>
		public static readonly string ErrorLogPath = Path.Combine(AppContext.BaseDirectory, "RelayCrm.WPF.errors.log");

		protected override void OnStartup(StartupEventArgs e)
		{
			base.OnStartup(e);

			this.DispatcherUnhandledException += App_DispatcherUnhandledException;
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
			TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;

			RelayDbContext.DatabasePath = Path.Combine(AppContext.BaseDirectory, "relay.db");

			if (!Notify.Try(DbSeeder.EnsureReady, "Opening the database"))
			{
				Shutdown(1);
				return;
			}

			var options = StartOptions.Parse(e.Args);
			if (options.UserId != null)
				Notify.Try(() => CurrentUser.SignIn(options.UserId.Value), "Signing in");

			if (!CurrentUser.IsSignedIn && !SignInDialog.SignIn())
			{
				Shutdown();
				return;
			}

			var window = new MainWindow(options);
			this.MainWindow = window;
			this.ShutdownMode = ShutdownMode.OnMainWindowClose;
			window.Show();
		}

		/// <summary>Appends an exception to the error log; never throws.</summary>
		public static void LogError(string source, Exception exception)
		{
			try
			{
				File.AppendAllText(ErrorLogPath,
					DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " [" + source + "] " + exception + Environment.NewLine + Environment.NewLine);
			}
			catch
			{
				// the log is a diagnostic aid only.
			}
		}

		private void App_DispatcherUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e)
		{
			LogError("Dispatcher", e.Exception);
			e.Handled = true;
			Notify.Error("Unexpected error: " + e.Exception.GetBaseException().Message);
		}

		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			LogError("AppDomain", e.ExceptionObject as Exception ?? new Exception(Convert.ToString(e.ExceptionObject)));
		}

		private static void TaskScheduler_UnobservedTaskException(object sender, UnobservedTaskExceptionEventArgs e)
		{
			LogError("Task", e.Exception);
			e.SetObserved();
		}
	}
}
