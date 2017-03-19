using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class BrandsService : IBrandsService
	{
		private readonly IChargeOverApiProvider _provider;

		public BrandsService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Retrieve brand list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-brand
		/// </summary>
		public IResponse RetrieveBrandList()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/brand", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
