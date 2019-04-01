using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class TransactionDetails
	{
		/// <summary>
		/// Transaction ID #
		/// </summary>
		[JsonProperty("transaction_id")]
		public int? TransactionId { get; set; }
		/// <summary>
		/// Customer ID #
		/// </summary>
		[JsonProperty("customer_id")]
		public int? CustomerId { get; set; }
		/// <summary>
		/// Payment gateway ID #
		/// </summary>
		[JsonProperty("gateway_id")]
		public int? GatewayId { get; set; }
		/// <summary>
		/// Payment gateway status (1 for success, 0 for failure)
		/// </summary>
		[JsonProperty("gateway_status")]
		public int? GatewayStatus { get; set; }
		/// <summary>
		/// Payment gateway transaction identifier
		/// </summary>
		[JsonProperty("gateway_transid")]
		public string GatewayTransid { get; set; }
		/// <summary>
		/// Payment gateway method
		/// </summary>
		[JsonProperty("gateway_method")]
		public string GatewayMethod { get; set; }
		/// <summary>
		/// An error message or note from the payment gateway
		/// </summary>
		[JsonProperty("gateway_msg")]
		public string GatewayMsg { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("gateway_err_code")]
		public int? GatewayErrCode { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("gateway_err_detail")]
		public string GatewayErrDetail { get; set; }
		/// <summary>
		/// A unique token for the transaction
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; }
		/// <summary>
		/// Transaction external key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Currency ID #
		/// </summary>
		[JsonProperty("currency_id")]
		public int? CurrencyId { get; set; }
		/// <summary>
		/// Currency ISO 4217 code
		/// </summary>
		[JsonProperty("currency_iso4217")]
		public string CurrencyIso4217 { get; set; }
		/// <summary>
		/// Currency symbol
		/// </summary>
		[JsonProperty("currency_symbol")]
		public string CurrencySymbol { get; set; }
		/// <summary>
		/// Total transaction amount (refunds will be negative)
		/// </summary>
		[JsonProperty("amount")]
		public float? Amount { get; set; }
		/// <summary>
		/// Transaction fee (if gateway provides this data)
		/// </summary>
		[JsonProperty("fee")]
		public float? Fee { get; set; }
		/// <summary>
		/// Amount that is applied to invoices
		/// </summary>
		[JsonProperty("applied")]
		public float? Applied { get; set; }
		/// <summary>
		/// Amount that is unapplied (not applied to any invoices)
		/// </summary>
		[JsonProperty("unapplied")]
		public float? Unapplied { get; set; }
		/// <summary>
		/// Date of the transaction
		/// </summary>
		[JsonProperty("transaction_date")]
		public DateTime? TransactionDate { get; set; }
		/// <summary>
		/// Human-friendly transaction status
		/// </summary>
		[JsonProperty("transaction_status_name")]
		public string TransactionStatusName { get; set; }
		/// <summary>
		/// Status string
		/// </summary>
		[JsonProperty("transaction_status_str")]
		public string TransactionStatusStr { get; set; }
		/// <summary>
		/// State code
		/// </summary>
		[JsonProperty("transaction_status_state")]
		public string TransactionStatusState { get; set; }
		/// <summary>
		/// Transaction type (one of: pay, ref, cre)
		/// </summary>
		[JsonProperty("transaction_type")]
		public string TransactionType { get; set; }
		/// <summary>
		/// Transaction type name
		/// </summary>
		[JsonProperty("transaction_type_name")]
		public string TransactionTypeName { get; set; }
		/// <summary>
		/// Transaction method
		/// </summary>
		[JsonProperty("transaction_method")]
		public string TransactionMethod { get; set; }
		/// <summary>
		/// Transaction details
		/// </summary>
		[JsonProperty("transaction_detail")]
		public string TransactionDetail { get; set; }
		/// <summary>
		/// Date/time of the transaction was created
		/// </summary>
		[JsonProperty("transaction_datetime")]
		public DateTime? TransactionDatetime { get; set; }
		/// <summary>
		/// IP address that created the transaction
		/// </summary>
		[JsonProperty("transaction_ipaddr")]
		public string TransactionIpaddr { get; set; }
		/// <summary>
		/// Date/time the transaction was voided
		/// </summary>
		[JsonProperty("void_datetime")]
		public DateTime? VoidDatetime { get; set; }
		/// <summary>
		/// URL for viewing the transaction in the GUI
		/// </summary>
		[JsonProperty("url_self")]
		public string UrlSelf { get; set; }
        /// <summary>
        /// A list of invoices this payment is applied to
        /// </summary>
        [JsonProperty("applied_to")]
        public TransactionAppliedTo[] AppliedTo { get; set; }
    }
}
