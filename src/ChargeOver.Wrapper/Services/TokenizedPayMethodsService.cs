using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

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
		public async Task<IIdentityResponse> StorePayMethodToken(StorePayMethodToken request)
		{
			return await Create("tokenized", request);
		}

		/// <summary>
		/// Delete tokenized pay method
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-tokenized
		/// </summary>
		public async Task<IResponse>DeleteTokenizedPayMethod(int id)
		{
			return await Delete("tokenized", id);
		}
	}
}
