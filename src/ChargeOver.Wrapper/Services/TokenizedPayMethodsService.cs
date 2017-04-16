using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class TokenizedPayMethodsService : BaseService, ITokenizedPayMethodsService
	{
		public TokenizedPayMethodsService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public TokenizedPayMethodsService()
		{
		}

		/// <summary>
		/// Store a pay method token
		/// details: https://developer.chargeover.com/apidocs/rest/#create-tokenized
		/// </summary>
		public IIdentityResponse StorePayMethodToken(StorePayMethodToken request)
		{
			return Create("tokenized", request);
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
