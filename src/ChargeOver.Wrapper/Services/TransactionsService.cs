using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class TransactionsService : BaseService, ITransactionsService
	{
		public TransactionsService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public TransactionsService()
		{
		}

		/// <summary>
		/// Create a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#create-transaction
		/// </summary>
		public async Task<IIdentityResponse> CreatePayment(Payment request)
		{
			return await Create("transaction", request);
		}

		/// <summary>
		/// Get a specific transaction
		/// details: https://developer.chargeover.com/apidocs/rest/#get-transaction
		/// </summary>
		public async Task<ICustomResponse<TransactionDetails>> GetTransaction(int id)
		{
			return await GetCustom<TransactionDetails>("transaction", id);
		}

		/// <summary>
		/// List transactions
		/// details: https://developer.chargeover.com/apidocs/rest/#list-all-transactions
		/// </summary>
		public async Task<IResponse<Transaction>> ListTransactions()
		{
			return await GetList<Transaction>("transaction");
		}

		/// <summary>
		/// Query for transactions
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-transactions
		/// </summary>
		public async Task<IResponse<Transaction>> QueryTransactions(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return await Query<Transaction>("transaction", queries, orders, offset, limit);
		}

		/// <summary>
		/// Attempt a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#pay-transaction
		/// </summary>
		public async Task<IIdentityResponse> AttemptPayment(AttemptPayment request)
		{
			return await Create("transaction?action=pay", request);
		}

		/// <summary>
		/// Create a refund
		/// details: https://developer.chargeover.com/apidocs/rest/#create-transaction-refund
		/// </summary>
		public async Task<IIdentityResponse> CreateRefund(Refund request)
		{
			return await Create("transaction", request);
		}

		/// <summary>
		/// Refund a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#refund-transaction
		/// </summary>
		public async Task<IIdentityResponse> RefundPayment(int id, RefundPayment request)
		{
			return await Create($"transaction/{id}?action=refund", request);
		}

		/// <summary>
		/// Void a transaction
		/// details: https://developer.chargeover.com/apidocs/rest/#void-a-transaction
		/// </summary>
		public async Task<ICustomResponse<bool>> VoidTransaction(int id)
		{
			return new CustomResponse<bool>(await Request<object, CustomChargeOverResponse<bool>>(MethodType.POST, $"/transaction/{id}/?action=void", null));
		}

		/// <summary>
		/// Email a receipt
		/// details: https://developer.chargeover.com/apidocs/rest/#email-a-transaction
		/// </summary>
		public async Task<ICustomResponse<bool>> EmailReceipt(int id, EmailInvoice request)
		{
			return new CustomResponse<bool>(await Request<EmailInvoice, CustomChargeOverResponse<bool>>(MethodType.POST, $"/transaction/{id}?action=email", request));
		}
	}
}
