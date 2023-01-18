using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class InvoicesService : BaseService, IInvoicesService
	{
		public InvoicesService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public InvoicesService()
		{
		}

		/// <summary>
		/// Create an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#create-an-invoice
		/// </summary>
		public async Task<IIdentityResponse> CreateInvoice(Models.Invoice request)
		{
			return await Create("/invoice ", request);
		}

		/// <summary>
		/// Update an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#update-an-invoice
		/// </summary>
		public async Task<IIdentityResponse> UpdateInvoice(int invoiceId, UpdateInvoice request)
		{
			return new IdentityResponse(await Request<UpdateInvoice, IdentityChargeOverResponse>(MethodType.PUT, $"/invoice/{invoiceId}", request));
		}

		/// <summary>
		/// Get a specific invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#get-for-invoices
		/// </summary>
		public async Task<ICustomResponse<InvoiceDetails>> GetInvoice(int id)
		{
			return await GetCustom<InvoiceDetails>("invoice", id);
		}

		/// <summary>
		/// Query for invoices
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-invoices
		/// </summary>
		public async Task<IResponse<InvoiceDetails>> QueryInvoices(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return await Query<InvoiceDetails>("invoice", queries, orders, offset, limit);
		}

		/// <summary>
		/// Credit card payment (specify card details)
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-cc
		/// </summary>
		public async Task<ICustomResponse<bool>> CreditCardPayment(int invoiceId, CreditCardPayment request)
		{
			return new CustomResponse<bool>(await Request<CreditCardPayment, CustomChargeOverResponse<bool>>(MethodType.POST, $"/invoice/{invoiceId}?action=pay", request));
		}

		/// <summary>
		/// ACH/eCheck payment (specify ACH details)
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-ach-new
		/// </summary>
		public async Task<ICustomResponse<bool>> ACHCheckpayment(int invoiceId, ACHCheckPayment request)
		{
			return await GetCustomBool($"/invoice/{invoiceId}?action=pay", request);
		}

		/// <summary>
		/// Apply an open customer balance
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-balance
		/// </summary>
		public async Task<ICustomResponse<bool>> ApplyOpenCustomerBalance(int invoiceId, ApplyOpenCustomerBalance request)
		{
			return await GetCustomBool($"/invoice/{invoiceId}?action=pay", request);
		}

		/// <summary>
		/// Void an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#void-an-invoice
		/// </summary>
		public async Task<IResponse>VoidInvoice(int invoiceId)
		{
			return await GetCustomBool($"/invoice/{invoiceId}?action=void", new { });
		}

		/// <summary>
		/// Email an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#email-an-invoice
		/// </summary>
		public async Task<ICustomResponse<bool>> EmailInvoice(int invoiceId, EmailInvoice request)
		{
			return new CustomResponse<bool>(await Request<EmailInvoice, CustomChargeOverResponse<bool>>(MethodType.POST, $"/invoice/{invoiceId}?action=email", request));
		}

		/// <summary>
		/// Print & mail an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#print-an-invoice
		/// </summary>
		public async Task<ICustomResponse<bool>> PrintInvoice(int invoiceId, PrintInvoice request)
		{
			return await GetCustomBool($"/invoice/{invoiceId}?action=print", request);
		}
	}
}
