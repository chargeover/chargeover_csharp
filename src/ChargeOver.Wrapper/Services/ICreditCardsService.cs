using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface ICreditCardsService
	{
		/// <summary>
		/// Store a credit card
		/// details: https://developer.chargeover.com/apidocs/rest/#create-card
		/// </summary>
		Task<IIdentityResponse> StoreCreditCard(StoreCreditCard request);

        /// <summary>
        /// Querying for credit cards
        /// details: https://developer.chargeover.com/apidocs/rest/#query-card
        /// </summary>
        Task<IResponse<CreditCardDetails>> QueryCreditCards(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);

        /// <summary>
        /// Delete a credit card
        /// details: https://developer.chargeover.com/apidocs/rest/#delete-a-creditcard
        /// </summary>
        Task<IResponse> DeleteCreditCard(int id);
	}
}
