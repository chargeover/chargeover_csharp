using System.Configuration;

namespace ChargeOver.Wrapper.Services
{
	/// <summary>
	/// Configuration for ChargeOverAPI from App.config/Web.config
	/// </summary>
	public sealed class ConfigurationManagerChargeOverApiConfiguration : IChargeOverAPIConfiguration
	{
		public ConfigurationManagerChargeOverApiConfiguration()
		{
			Endpoint = ConfigurationManager.AppSettings["ChargeOverAPIEndpoint"];
			Username = ConfigurationManager.AppSettings["ChargeOverAPIUserName"];
			Password = ConfigurationManager.AppSettings["ChargeOverAPIPassword"];
			Auth = ConfigurationManager.AppSettings["ChargeOverAPIAuth"];
		}

		public string Endpoint { get; }
		public string Username { get; }
		public string Password { get; }
		public string Auth { get; }
	}
}