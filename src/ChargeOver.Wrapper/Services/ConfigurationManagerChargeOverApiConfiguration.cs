using System;
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
			var chargeoverapiendpoint = "ChargeOverAPIEndpoint";
			Endpoint = ConfigurationManager.AppSettings[chargeoverapiendpoint];
			if (string.IsNullOrWhiteSpace(Endpoint))throw new Exception($"Please specify setting in app.config/web.config {chargeoverapiendpoint}.");

			var chargeoverapiusername = "ChargeOverAPIUserName";
			Username = ConfigurationManager.AppSettings[chargeoverapiusername];
			if (string.IsNullOrWhiteSpace(Username)) throw new Exception($"Please specify setting in app.config/web.config {chargeoverapiusername}.");

			var chargeoverapipassword = "ChargeOverAPIPassword";
			Password = ConfigurationManager.AppSettings[chargeoverapipassword];
			if (string.IsNullOrWhiteSpace(Password)) throw new Exception($"Please specify setting in app.config/web.config {chargeoverapipassword}.");

			var chargeoverapiauth = "ChargeOverAPIAuth";
			Auth = ConfigurationManager.AppSettings[chargeoverapiauth];
			if (string.IsNullOrWhiteSpace(Auth)) throw new Exception($"Please specify setting in app.config/web.config {chargeoverapiauth}.");
		}

		public string Endpoint { get; }
		public string Username { get; }
		public string Password { get; }
		public string Auth { get; }
	}
}