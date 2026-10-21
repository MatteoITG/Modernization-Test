using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Wisej.Core;

namespace RelayCrm
{
	/// <summary>
	/// The Startup class configures services and the app's request pipeline.
	/// It replaces the WPF App.xaml entry point: the web host starts, Wisej then calls Program.Main for every new session.
	/// </summary>
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}
		public IConfiguration Configuration { get; }

		public static void Main(string[] args)
		{
			// WPF (and WinForms) close a modal dialog as soon as DialogResult is set, also by a button with
			// IsCancel / DialogResult. Wisej keeps it open unless this switch is on (Form.AutoCloseModalDialogDefault).
			AppContext.SetSwitch("FormAutoCloseModalDialog", true);

			var builder = WebApplication.CreateBuilder(new WebApplicationOptions
			{
				Args = args,
				WebRootPath = "./"
			});

			var app = builder.Build();
			app.UseWisej();
			app.UseFileServer();
			app.Run();
		}
	}
}
