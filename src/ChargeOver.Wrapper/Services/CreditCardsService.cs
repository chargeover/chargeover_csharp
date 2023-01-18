using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CreditCardsService : BaseService, ICreditCardsService
	{
		public CreditCardsService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public CreditCardsService()
		{
		}

		/// <summary>
		/// Store a credit card
		/// details: https://developer.chargeover.com/apidocs/rest/#create-card
		/// </summary>
		public async Task<IIdentityResponse> StoreCreditCard(StoreCreditCard request)
		{
			return await Create("creditcard", request);
		}

		/// <summary>
		/// Querying for credit cards
		/// details: https://developer.chargeover.com/apidocs/rest/#query-card
		/// </summary>
		public async Task<IResponse<CreditCardDetails>> QueryCreditCards(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return await Query<CreditCardDetails>("creditcard", queries, orders, offset, limit);
		}

		/// <summary>
		/// Delete a credit card
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-creditcard
		/// </summary>
		public async Task<IResponse>DeleteCreditCard(int id)
		{
			return await Delete("creditcard", id);
		}
	}
}
