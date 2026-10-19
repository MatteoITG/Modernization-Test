using Microsoft.AspNetCore.Builder;
using Wisej.Core;

namespace RelayCrm
{
	/// <summary>
	/// Hosts the Wisej.NET application in ASP.NET Core (added by the migration: a web app needs a host).
	/// </summary>
	public class Startup
	{
		public static void Main(string[] args)
		{
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
