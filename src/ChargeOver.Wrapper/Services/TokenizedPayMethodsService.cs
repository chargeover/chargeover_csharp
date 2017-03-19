using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class TokenizedPayMethodsService : ITokenizedPayMethodsService
	{
		private readonly IChargeOverApiProvider _provider;

		public TokenizedPayMethodsService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Store a pay method token
		/// details: https://developer.chargeover.com/apidocs/rest/#create-tokenized
		/// </summary>
		public IIdentityResponse StorePayMethodToken(StorePayMethodToken request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/tokenized ", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Delete tokenized pay method
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-tokenized
		/// </summary>
		public IResponse DeleteTokenizedPayMethod(int id)
		{
			var api = _provider.Create();

			var result = api.Raw("delete", "/tokenized", null, id);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
