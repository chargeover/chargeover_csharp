using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface IInvoicesService
	{
		/// <summary>
		/// Create an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#create-an-invoice
		/// </summary>
		Task<IIdentityResponse> CreateInvoice(Models.Invoice request);

		/// <summary>
		/// Update an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#update-an-invoice
		/// </summary>
		Task<IIdentityResponse> UpdateInvoice(int invoiceId, UpdateInvoice request);

		/// <summary>
		/// Get a specific invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#get-for-invoices
		/// </summary>
		Task<ICustomResponse<InvoiceDetails>> GetInvoice(int id);

		/// <summary>
		/// Query for invoices
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-invoices
		/// </summary>
		Task<IResponse<InvoiceDetails>> QueryInvoices(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);

        /// <summary>
        /// Credit card payment (specify card details)
        /// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-cc
        /// </summary>
        Task<ICustomResponse<bool>> CreditCardPayment(int invoiceId, CreditCardPayment request);

		/// <summary>
		/// ACH/eCheck payment (specify ACH details)
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-ach-new
		/// </summary>
		Task<ICustomResponse<bool>> ACHCheckpayment(int invoiceId, ACHCheckPayment request);

		/// <summary>
		/// Apply an open customer balance
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-balance
		/// </summary>
		Task<ICustomResponse<bool>> ApplyOpenCustomerBalance(int invoiceId, ApplyOpenCustomerBalance request);

        /// <summary>
        /// Void an invoice
        /// details: https://developer.chargeover.com/apidocs/rest/#void-an-invoice
        /// </summary>
        Task<IResponse> VoidInvoice(int invoiceId);

		/// <summary>
		/// Email an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#email-an-invoice
		/// </summary>
		Task<ICustomResponse<bool>> EmailInvoice(int invoiceId, EmailInvoice request);

		/// <summary>
		/// Print & mail an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#print-an-invoice
		/// </summary>
		Task<ICustomResponse<bool>> PrintInvoice(int invoiceId, PrintInvoice request);
	}
}
