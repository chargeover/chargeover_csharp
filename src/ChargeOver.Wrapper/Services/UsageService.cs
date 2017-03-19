using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class UsageService : IUsageService
	{
		private readonly IChargeOverApiProvider _provider;

		public UsageService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Storing Usage Data
		/// details: https://developer.chargeover.com/apidocs/rest/#create-usage
		/// </summary>
		public IIdentityResponse StoringUsageData(StoringUsageData request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/usage ", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
