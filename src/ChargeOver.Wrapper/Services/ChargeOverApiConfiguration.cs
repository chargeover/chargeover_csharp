using System;

namespace ChargeOver.Wrapper.Services
{
	/// <summary>
	/// Simple ChargeOverAPI configuration manager
	/// </summary>
	public sealed class ChargeOverApiConfiguration : IChargeOverAPIConfiguration
	{
		public ChargeOverApiConfiguration(string endpoint, string username, string password, string auth)
		{
			if (string.IsNullOrWhiteSpace(endpoint)) throw new ArgumentException("Argument should not be null or white space.", nameof(endpoint));
			Endpoint = endpoint;
			if (string.IsNullOrWhiteSpace(username)) throw new ArgumentException("Argument should not be null or white space.", nameof(username));
			Username = username;
			if (string.IsNullOrWhiteSpace(password)) throw new ArgumentException("Argument should not be null or white space.", nameof(password));
			Password = password;
			if (string.IsNullOrWhiteSpace(auth)) throw new ArgumentException("Argument should not be null or white space.", nameof(auth));
			Auth = auth;
		}

		public string Endpoint { get; }
		public string Username { get; }
		public string Password { get; }
		public string Auth { get; }
	}
}