using System.Configuration;
using System.IO;
using ChargeOver.Wrapper.Services;
using Newtonsoft.Json;

namespace TestsChargeOver.Wrapper
{
	internal sealed class ChargeOverAPIConfiguration : IChargeOverAPIConfiguration
	{
		static ChargeOverAPIConfiguration()
		{
			Config = new ChargeOverAPIConfiguration();
		}

		private ChargeOverAPIConfiguration()
		{
			var info = new FileInfo(ConfigFilePath);
			if (info.Exists)
			{
				var config = JsonConvert.DeserializeObject<ConfigJson>(File.ReadAllText(info.FullName));
				Endpoint = config.Endpoint;
				Username = config.Username;
				Password = config.Password;
				Auth = config.Auth;
			}
			else
			{
				Endpoint = ConfigurationManager.AppSettings["ChargeOverApiEndpoint"];
				Username = ConfigurationManager.AppSettings["ChargeOverApiUsername"];
				Password = ConfigurationManager.AppSettings["ChargeOverApiPassword"];
				Auth = ConfigurationManager.AppSettings["ChargeOverApiAuth"];
			}
		}

		public static IChargeOverAPIConfiguration Config { get; }

		private string ConfigFilePath = @"../../../../../../chargeover.json";
		public string Endpoint { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string Auth { get; set; }

		public sealed class ConfigJson
		{
			public string Endpoint { get; set; }
			public string Username { get; set; }
			public string Password { get; set; }
			public string Auth { get; set; }
		}
	}
}