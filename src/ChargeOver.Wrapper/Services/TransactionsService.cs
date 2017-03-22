using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public sealed class TransactionsService : BaseService, ITransactionsService
	{
		public TransactionsService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		public TransactionsService()
		{
		}

		/// <summary>
		/// Create a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#create-transaction
		/// </summary>
		public IIdentityResponse CreatePayment(Payment request)
		{
			return Create("transaction", request);
		}

		/// <summary>
		/// Get a specific transaction
		/// details: https://developer.chargeover.com/apidocs/rest/#get-transaction
		/// </summary>
		public ICustomResponse<TransactionDetails> GetSpecificTransaction(int id)
		{
			return GetCustom<TransactionDetails>("transaction", id);
		}

		/// <summary>
		/// List transactions
		/// details: https://developer.chargeover.com/apidocs/rest/#list-all-transactions
		/// </summary>
		public IResponse<Transaction> ListTransactions()
		{
			return GetList<Transaction>("transaction");
		}

		/// <summary>
		/// Query for transactions
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-transactions
		/// </summary>
		public IResponse<Transaction> QueryForTransactions(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return Query<Transaction>("transaction", queries, orders, offset, limit);
		}

		/// <summary>
		/// Attempt a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#pay-transaction
		/// </summary>
		public IIdentityResponse AttemptPayment(AttemptPayment request)
		{
			return Create("/transaction?action=pay", request);
		}

		/// <summary>
		/// Create a refund
		/// details: https://developer.chargeover.com/apidocs/rest/#create-transaction-refund
		/// </summary>
		public IIdentityResponse CreateRefund(Refund request)
		{
			return Create("transaction", request);
		}

		/// <summary>
		/// Refund a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#refund-transaction
		/// </summary>
		public IIdentityResponse RefundPayment(int id, RefundPayment request)
		{
			return Create($"/transaction/{id}?action=refund", request);
		}

		/// <summary>
		/// Void a transaction
		/// details: https://developer.chargeover.com/apidocs/rest/#void-a-transaction
		/// </summary>
		public ICustomResponse<bool> VoidTransaction(int id)
		{
			var api = Provider.Create();

			var result = api.Raw(PostRequest, $"/transaction/{id}/?action=void", null);

			var resultObject = JsonConvert.DeserializeObject<CustomChargeOverResponse<bool>>(result.Item2);

			return new CustomResponse<bool>(resultObject);
		}

		/// <summary>
		/// Email a receipt
		/// details: https://developer.chargeover.com/apidocs/rest/#email-a-transaction
		/// </summary>
		public ICustomResponse<bool> EmailReceipt(int id, EmailInvoice request)
		{
			var api = Provider.Create();

			var result = api.Raw(PostRequest, $"/transaction/{id}?action=email", null, request);

			var resultObject = JsonConvert.DeserializeObject<CustomChargeOverResponse<bool>>(result.Item2);

			return new CustomResponse<bool>(resultObject);
		}
	}
}
