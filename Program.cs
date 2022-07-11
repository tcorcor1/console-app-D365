using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Extensions.Configuration;
using Microsoft.PowerPlatform.Dataverse.Client;

namespace DataverseConsole
{
	internal class Program
	{
		public IConfiguration Configuration { get; }

		private Program ()
		{
			Configuration = new ConfigurationBuilder()
				.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
				.Build();
		}

		private static void Main (string[] args)
		{
			#region SETUP

			Program app = new();
			ServiceClient service = new(app.Configuration.GetConnectionString("DATAVERSE_CONN_OAUTH"));
			WhoAmIResponse whoAmIResp = (WhoAmIResponse)service.Execute(new WhoAmIRequest());
			Console.WriteLine("Logged in User GUID: {0}", whoAmIResp.UserId);

			#endregion SETUP

			Console.WriteLine("Press any key to continue");
			Console.ReadKey();
			service.Dispose();
		}
	}
}