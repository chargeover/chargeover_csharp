using System;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class Payment
	{
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
		/// Transaction external key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Total transaction amount (refunds will be negative)
		/// </summary>
		[JsonProperty("amount")]
		public float? Amount { get; set; }
		/// <summary>
		/// Date of the transaction
		/// </summary>
		[JsonProperty("transaction_date")]
		public DateTime? TransactionDate { get; set; }
		/// <summary>
		/// Transaction type (one of: pay, ref, cre)
		/// </summary>
		[JsonProperty("transaction_type")]
		public string TransactionType { get; set; }
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
		/// Date/time the transaction was voided
		/// </summary>
		[JsonProperty("void_datetime")]
		public DateTime? VoidDatetime { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("applied_to")]
		public AppliedInvoice[] AppliedTo { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("auto_apply")]
		public string AutoApply { get; set; }
	}
}
