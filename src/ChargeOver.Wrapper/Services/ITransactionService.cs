using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ITransactionService
	{
		IResponse Create(Models.Transaction transaction);
		IFindResponse<Models.Transaction> Query(params string[] queries);
		IResponse AttempPayment(Models.Transaction transaction);
		IResponse CreateRefund(Refund refund);
		IResponse RefundPayment(RefundPayment payment);
		IResponse VoidTransaction(int id);
		IResponse EmailReceipt(int id);
	}
}