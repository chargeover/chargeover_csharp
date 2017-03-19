using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CreditCardsService : ICreditCardsService
	{
		private readonly IChargeOverApiProvider _provider;

		public CreditCardsService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Store a credit card
		/// details: https://developer.chargeover.com/apidocs/rest/#create-card
		/// </summary>
		public IIdentityResponse StoreCreditCard(StoreCreditCard request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/creditcard ", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Querying for credit cards
		/// details: https://developer.chargeover.com/apidocs/rest/#query-card
		/// </summary>
		public IResponse<CreditCardDetails> QueryingForCreditCards()
		{
			var api = _provider.Create();

			var result = api.Raw("get", "/creditcard", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ChargeOverResponse<CreditCardDetails>>(result.Item2);
			
			return new Models.Response<CreditCardDetails>(resultObject);
		}

		/// <summary>
		/// Delete a credit card
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-creditcard
		/// </summary>
		public IResponse DeleteCreditCard(int id)
		{
			var api = _provider.Create();

			var result = api.Raw("delete", "/creditcard", null, id);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
