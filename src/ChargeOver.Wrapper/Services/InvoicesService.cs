using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public sealed class InvoicesService : BaseService, IInvoicesService
	{
		public InvoicesService(IChargeOverApiProvider provider) : base(provider)
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
			var api = Provider.Create();

			var result = api.Raw("create", "/invoice ", null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Update an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#update-an-invoice
		/// </summary>
		public IIdentityResponse UpdateInvoice(int invoiceId, UpdateInvoice request)
		{
			var api = Provider.Create();

			var result = api.Raw("modify", $"/invoice/{invoiceId}", null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Get a specific invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#get-for-invoices
		/// </summary>
		public ICustomResponse<InvoiceDetails> GetSpecificInvoice(int id)
		{
			return GetCustom<InvoiceDetails>("invoice", id);
		}

		/// <summary>
		/// Query for invoices
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-invoices
		/// </summary>
		public IResponse<InvoiceDetails> QueryForInvoices(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return Query<InvoiceDetails>("invoice", queries, orders, offset, limit);
		}

		/// <summary>
		/// Credit card payment (specify card details)
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-cc
		/// </summary>
		public ICustomResponse<bool> CreditCardPayment(int invoiceId, CreditCardPayment request)
		{
			var api = Provider.Create();

			var result = api.Raw(PostRequest, $"/invoice/{invoiceId}?action=pay", null, request);

			var resultObject = JsonConvert.DeserializeObject<CustomChargeOverResponse<bool>>(result.Item2);

			return new CustomResponse<bool>(resultObject);
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
			var api = Provider.Create();

			var result = api.Raw(PostRequest, $"/invoice/{invoiceId}?action=email", null, request);

			var resultObject = JsonConvert.DeserializeObject<CustomChargeOverResponse<bool>>(result.Item2);

			return new CustomResponse<bool>(resultObject);
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
