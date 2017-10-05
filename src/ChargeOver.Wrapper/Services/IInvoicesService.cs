using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IInvoicesService
	{
		/// <summary>
		/// Create an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#create-an-invoice
		/// </summary>
		IIdentityResponse CreateInvoice(Models.Invoice request);

		/// <summary>
		/// Update an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#update-an-invoice
		/// </summary>
		IIdentityResponse UpdateInvoice(int invoiceId, UpdateInvoice request);

		/// <summary>
		/// Get a specific invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#get-for-invoices
		/// </summary>
		ICustomResponse<InvoiceDetails> GetInvoice(int id);

		/// <summary>
		/// Query for invoices
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-invoices
		/// </summary>
		IResponse<InvoiceDetails> QueryInvoices(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);

		/// <summary>
		/// Credit card payment (specify card details)
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-cc
		/// </summary>
		ICustomResponse<bool> CreditCardPayment(int invoiceId, CreditCardPayment request);

		/// <summary>
		/// ACH/eCheck payment (specify ACH details)
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-ach-new
		/// </summary>
		ICustomResponse<bool> ACHCheckpayment(int invoiceId, ACHCheckPayment request);

		/// <summary>
		/// Apply an open customer balance
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-balance
		/// </summary>
		ICustomResponse<bool> ApplyOpenCustomerBalance(int invoiceId, ApplyOpenCustomerBalance request);

		/// <summary>
		/// Void an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#void-an-invoice
		/// </summary>
		IResponse VoidInvoice(int invoiceId);

		/// <summary>
		/// Email an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#email-an-invoice
		/// </summary>
		ICustomResponse<bool> EmailInvoice(int invoiceId, EmailInvoice request);

		/// <summary>
		/// Print & mail an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#print-an-invoice
		/// </summary>
		ICustomResponse<bool> PrintInvoice(int invoiceId, PrintInvoice request);
	}
}
