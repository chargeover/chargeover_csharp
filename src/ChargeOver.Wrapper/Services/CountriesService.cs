using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CountriesService : ICountriesService
	{
		private readonly IChargeOverApiProvider _provider;

		public CountriesService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Retrieve country list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-country
		/// </summary>
		public IResponse RetrieveCountryList()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/country", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
