using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm
{
	/// <summary>
	/// What is left of the WPF App class: the error log and the handlers of unhandled exceptions.
	/// Startup moved to <see cref="Program.Main"/>; there is no Application subclass in Wisej.
	/// </summary>
	/// <remarks>
	/// The log is global (one file for the server, not per user), so it can stay static.
	/// </remarks>
	public static class App
	{
		/// <summary>The log of unhandled exceptions, next to the application.</summary>
		public static readonly string ErrorLogPath = Path.Combine(AppContext.BaseDirectory, "RelayCrm.WpfToWisej42.errors.log");

		private static int handlersAdded;

		/// <summary>Adds the handlers of unhandled exceptions; the process-wide ones only once.</summary>
		public static void AddExceptionHandlers()
		{
			// per session: the exceptions of the Wisej events of this user.
			Application.ThreadException += Application_ThreadException;

			if (Interlocked.Exchange(ref handlersAdded, 1) == 0)
			{
				AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
				TaskScheduler.UnobservedTaskException += TaskScheduler_UnobservedTaskException;
			}
		}

		/// <summary>Appends an exception to the error log; never throws.</summary>
		public static void LogError(string source, Exception exception)
		{
			try
			{
				lock (ErrorLogPath)
				{
					File.AppendAllText(ErrorLogPath,
						DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " [" + source + "] " + exception + Environment.NewLine + Environment.NewLine);
				}
			}
			catch
			{
				// the log is a diagnostic aid only.
			}
		}

		private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
		{
			LogError("Wisej", e.Exception);
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
