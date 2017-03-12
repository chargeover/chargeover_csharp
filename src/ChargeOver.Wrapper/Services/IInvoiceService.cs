using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IInvoiceService
	{
		IResponse Create(InvoiceEntity invoice);
		IResponse Update(InvoiceEntity invoice);
		IFindResponse<InvoiceEntity> Query(params string[] queries);
		IResponse CreditCardPayment(CreditCardPayment payment);
		IResponse ACHPayment(ACHPayment payment);
		IResponse ApplyCustomerBalance(int customerId);
		IResponse VoidInvoice(int id);
		IResponse EmailInvoice(int id);
		IResponse PrintAndMainInvoice(int id);
	}
}