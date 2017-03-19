using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class TransactionsService : ITransactionsService
	{
		private readonly IChargeOverApiProvider _provider;

		public TransactionsService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Create a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#create-transaction
		/// </summary>
		public IIdentityResponse CreatePayment(Payment request)
		{
			var api = _provider.Create();

			var result = api.Raw("create", "/transaction ", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Get a specific transaction
		/// details: https://developer.chargeover.com/apidocs/rest/#get-transaction
		/// </summary>
		public IResponse GetSpecificTransaction()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/transaction", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// List transactions
		/// details: https://developer.chargeover.com/apidocs/rest/#list-all-transactions
		/// </summary>
		public IResponse<Transaction> ListTransactions()
		{
			var api = _provider.Create();

			var result = api.Raw("get", "/transaction", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ChargeOverResponse<Transaction>>(result.Item2);
			
			return new Models.Response<Transaction>(resultObject);
		}

		/// <summary>
		/// Query for transactions
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-transactions
		/// </summary>
		public IResponse<Transaction> QueryForTransactions(params string[] queries)
		{
			var api = _provider.Create();

			var result = api.Raw("find", "/transaction", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ChargeOverResponse<Transaction>>(result.Item2);
			
			return new Models.Response<Transaction>(resultObject);
		}

		/// <summary>
		/// Attempt a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#pay-transaction
		/// </summary>
		public IIdentityResponse AttemptPayment(AttemptPayment request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/transaction", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Create a refund
		/// details: https://developer.chargeover.com/apidocs/rest/#create-transaction-refund
		/// </summary>
		public IIdentityResponse CreateRefund(Refund request)
		{
			var api = _provider.Create();

			var result = api.Raw("create", "/transaction", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Refund a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#refund-transaction
		/// </summary>
		public IIdentityResponse RefundPayment(RefundPayment request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/transaction", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Void a transaction
		/// details: https://developer.chargeover.com/apidocs/rest/#void-a-transaction
		/// </summary>
		public IResponse VoidTransaction()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/transaction", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Email a receipt
		/// details: https://developer.chargeover.com/apidocs/rest/#email-a-transaction
		/// </summary>
		public IIdentityResponse EmailReceipt(EmailInvoice request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/transaction", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
