using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class TermsService : ITermsService
	{
		private readonly IChargeOverApiProvider _provider;

		public TermsService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// List terms
		/// details: https://developer.chargeover.com/apidocs/rest/#list-terms
		/// </summary>
		public IResponse ListTerms()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/terms", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
