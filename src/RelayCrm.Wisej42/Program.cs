using System;
using RelayCrm.Data;
using RelayCrm.Services;
using Wisej.Web;

namespace RelayCrm
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			RelayDbContext.DatabasePath = Application.MapPath("relay.db");
			CurrentUser.Bag = new WisejSessionBag();
			Icons.Prefix = "resource.wx/Wisej.Ext.BootstrapIcons/";
			Icons.Suffix = ".svg";

			if (!Notify.Try(DbSeeder.EnsureReady, "Opening the database"))
				return;

			Application.MainPage = new Page1();
		}

		//
		// You can use the entry method below
		// to receive the parameters from the URL in the args collection.
		//
		//static void Main(NameValueCollection args)
		//{
		//}
	}
}
