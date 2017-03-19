using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ICreditCardsService
	{
		/// <summary>
		/// Store a credit card
		/// details: https://developer.chargeover.com/apidocs/rest/#create-card
		/// </summary>
		IIdentityResponse StoreCreditCard(StoreCreditCard request);

		/// <summary>
		/// Querying for credit cards
		/// details: https://developer.chargeover.com/apidocs/rest/#query-card
		/// </summary>
		IResponse<CreditCardDetails> QueryingForCreditCards();

		/// <summary>
		/// Delete a credit card
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-creditcard
		/// </summary>
		IResponse DeleteCreditCard(int id);
	}
}
