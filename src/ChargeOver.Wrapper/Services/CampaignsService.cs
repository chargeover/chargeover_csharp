using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CampaignsService : ICampaignsService
	{
		private readonly IChargeOverApiProvider _provider;

		public CampaignsService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Retrieve campaign list
		/// details: https://developer.chargeover.com/apidocs/rest/#list-campaign
		/// </summary>
		public IResponse RetrieveCampaignList()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/campaign", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
