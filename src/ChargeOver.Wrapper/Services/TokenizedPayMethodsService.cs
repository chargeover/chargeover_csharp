using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class TokenizedPayMethodsService : BaseService, ITokenizedPayMethodsService
	{
		public TokenizedPayMethodsService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		/// <summary>
		/// Store a pay method token
		/// details: https://developer.chargeover.com/apidocs/rest/#create-tokenized
		/// </summary>
		public IIdentityResponse StorePayMethodToken(StorePayMethodToken request)
		{
			return Create("tokenized", request);
			//var api = _provider.Create();

			//var result = api.Raw("", "/tokenized ", null, request);

			//var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			//return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Delete tokenized pay method
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-tokenized
		/// </summary>
		public IResponse DeleteTokenizedPayMethod(int id)
		{
			return Delete("tokenized", id);
		}
	}
}
