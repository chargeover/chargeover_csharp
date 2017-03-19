using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CurrenciesService : ICurrenciesService
	{
		private readonly IChargeOverApiProvider _provider;

		public CurrenciesService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// List currencies
		/// details: https://developer.chargeover.com/apidocs/rest/#list-currency
		/// </summary>
		public IResponse ListCurrencies()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/currency", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
