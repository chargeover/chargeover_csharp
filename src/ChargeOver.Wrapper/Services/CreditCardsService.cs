using ChargeOver.Wrapper.Models;

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
		public IIdentityResponse StoreCreditCard(StoreCreditCard request)
		{
			return Create("creditcard", request);
		}

		/// <summary>
		/// Querying for credit cards
		/// details: https://developer.chargeover.com/apidocs/rest/#query-card
		/// </summary>
		public IResponse<CreditCardDetails> QueryCreditCards(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return Query<CreditCardDetails>("creditcard", queries, orders, offset, limit);
		}

		/// <summary>
		/// Delete a credit card
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-creditcard
		/// </summary>
		public IResponse DeleteCreditCard(int id)
		{
			return Delete("creditcard", id);
		}
	}
}
