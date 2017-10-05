using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ITransactionsService
	{
		/// <summary>
		/// Create a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#create-transaction
		/// </summary>
		IIdentityResponse CreatePayment(Payment request);

		/// <summary>
		/// Get a specific transaction
		/// details: https://developer.chargeover.com/apidocs/rest/#get-transaction
		/// </summary>
		ICustomResponse<TransactionDetails> GetTransaction(int id);

		/// <summary>
		/// List transactions
		/// details: https://developer.chargeover.com/apidocs/rest/#list-all-transactions
		/// </summary>
		IResponse<Transaction> ListTransactions();

		/// <summary>
		/// Query for transactions
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-transactions
		/// </summary>
		IResponse<Transaction> QueryTransactions(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);

		/// <summary>
		/// Attempt a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#pay-transaction
		/// </summary>
		IIdentityResponse AttemptPayment(AttemptPayment request);

		/// <summary>
		/// Create a refund
		/// details: https://developer.chargeover.com/apidocs/rest/#create-transaction-refund
		/// </summary>
		IIdentityResponse CreateRefund(Refund request);

		/// <summary>
		/// Refund a payment
		/// details: https://developer.chargeover.com/apidocs/rest/#refund-transaction
		/// </summary>
		IIdentityResponse RefundPayment(int id, RefundPayment request);

		/// <summary>
		/// Void a transaction
		/// details: https://developer.chargeover.com/apidocs/rest/#void-a-transaction
		/// </summary>
		ICustomResponse<bool> VoidTransaction(int id);

		/// <summary>
		/// Email a receipt
		/// details: https://developer.chargeover.com/apidocs/rest/#email-a-transaction
		/// </summary>
		ICustomResponse<bool> EmailReceipt(int id, EmailInvoice request);
	}
}
