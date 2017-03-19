using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class InvoicesService : IInvoicesService
	{
		private readonly IChargeOverApiProvider _provider;

		public InvoicesService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Create an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#create-an-invoice
		/// </summary>
		public IIdentityResponse CreateInvoice(Models.Invoice request)
		{
			var api = _provider.Create();

			var result = api.Raw("create", "/invoice ", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Update an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#update-an-invoice
		/// </summary>
		public IIdentityResponse UpdateInvoice(UpdateInvoice request)
		{
			var api = _provider.Create();

			var result = api.Raw("modify", "/invoice", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Get a specific invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#get-for-invoices
		/// </summary>
		public IResponse GetSpecificInvoice()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/invoice", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Query for invoices
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-invoices
		/// </summary>
		public IResponse QueryForInvoices(params string[] queries)
		{
			var api = _provider.Create();

			var result = api.Raw("find", "/invoice", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Credit card payment (specify card details)
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-cc
		/// </summary>
		public IIdentityResponse CreditCardPayment(CreditCardPayment request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/invoice", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// ACH/eCheck payment (specify ACH details)
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-ach-new
		/// </summary>
		public IIdentityResponse ACHCheckpayment(ACHCheckPayment request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/invoice", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Apply an open customer balance
		/// details: https://developer.chargeover.com/apidocs/rest/#payment-for-invoice-balance
		/// </summary>
		public IIdentityResponse ApplyOpenCustomerBalance(ApplyOpenCustomerBalance request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/invoice", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Void an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#void-an-invoice
		/// </summary>
		public IResponse VoidInvoice()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/invoice", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Email an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#email-an-invoice
		/// </summary>
		public IIdentityResponse EmailInvoice(EmailInvoice request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/invoice", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}

		/// <summary>
		/// Print & mail an invoice
		/// details: https://developer.chargeover.com/apidocs/rest/#print-an-invoice
		/// </summary>
		public IIdentityResponse PrintInvoice(PrintInvoice request)
		{
			var api = _provider.Create();

			var result = api.Raw("", "/invoice", null, request);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
