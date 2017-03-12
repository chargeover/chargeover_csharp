using System;

namespace ChargeOver.Wrapper.Services
{
	public sealed class ChargeOverApiProvider : IChargeOverApiProvider
	{
		private readonly IChargeOverAPIConfiguration _config;

		public ChargeOverApiProvider(IChargeOverAPIConfiguration config)
		{
			if (config == null) throw new ArgumentNullException(nameof(config));

			_config = config;
		}

		public ChargeOverApiProvider() : this(new ConfigurationManagerChargeOverApiConfiguration())
		{
		}

		public ChargeOverAPI Create()
		{
			return new ChargeOverAPI(_config.Endpoint, _config.Username, _config.Password, _config.Auth);
		}
	}
}