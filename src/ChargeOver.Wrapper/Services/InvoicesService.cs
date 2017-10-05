using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

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
		public IIdentityResponse CreateInvoice(Models.Invoice request)
		{
			return Create("/invoice ", request);
		}

		/// <summary>
		/// Update an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#update-an-invoice
		/// </summary>
		public IIdentityResponse UpdateInvoice(int invoiceId, UpdateInvoice request)
		{
			return new IdentityResponse(Request<UpdateInvoice, IdentityChargeOverResponse>(MethodType.PUT, $"/invoice/{invoiceId}", request));
		}

		/// <summary>
		/// Get a specific invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#get-for-invoices
		/// </summary>
		public ICustomResponse<InvoiceDetails> GetInvoice(int id)
		{
			return GetCustom<InvoiceDetails>("invoice", id);
		}

		/// <summary>
		/// Query for invoices
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-invoices
		/// </summary>
		public IResponse<InvoiceDetails> QueryInvoices(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return Query<InvoiceDetails>("invoice", queries, orders, offset, limit);
		}

		/// <summary>
		/// Credit card payment (specify card details)
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-cc
		/// </summary>
		public ICustomResponse<bool> CreditCardPayment(int invoiceId, CreditCardPayment request)
		{
			return new CustomResponse<bool>(Request<CreditCardPayment, CustomChargeOverResponse<bool>>(MethodType.POST, $"/invoice/{invoiceId}?action=pay", request));
		}

		/// <summary>
		/// ACH/eCheck payment (specify ACH details)
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-ach-new
		/// </summary>
		public ICustomResponse<bool> ACHCheckpayment(int invoiceId, ACHCheckPayment request)
		{
			return GetCustomBool($"/invoice/{invoiceId}?action=pay", request);
		}

		/// <summary>
		/// Apply an open customer balance
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-balance
		/// </summary>
		public ICustomResponse<bool> ApplyOpenCustomerBalance(int invoiceId, ApplyOpenCustomerBalance request)
		{
			return GetCustomBool($"/invoice/{invoiceId}?action=pay", request);
		}

		/// <summary>
		/// Void an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#void-an-invoice
		/// </summary>
		public IResponse VoidInvoice(int invoiceId)
		{
			return GetCustomBool($"/invoice/{invoiceId}?action=void", new { });
		}

		/// <summary>
		/// Email an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#email-an-invoice
		/// </summary>
		public ICustomResponse<bool> EmailInvoice(int invoiceId, EmailInvoice request)
		{
			return new CustomResponse<bool>(Request<EmailInvoice, CustomChargeOverResponse<bool>>(MethodType.POST, $"/invoice/{invoiceId}?action=email", request));
		}

		/// <summary>
		/// Print & mail an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#print-an-invoice
		/// </summary>
		public ICustomResponse<bool> PrintInvoice(int invoiceId, PrintInvoice request)
		{
			return GetCustomBool($"/invoice/{invoiceId}?action=print", request);
		}
	}
}
