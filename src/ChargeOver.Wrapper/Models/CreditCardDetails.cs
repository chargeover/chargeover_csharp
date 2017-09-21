using System;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class CreditCardDetails
	{
		/// <summary>
		/// The customer id #
		/// </summary>
		[JsonProperty("customer_id")]
		public int? CustomerId { get; set; }
		/// <summary>
		/// The credit card ID #
		/// </summary>
		[JsonProperty("creditcard_id")]
		public int? CreditcardId { get; set; }
		/// <summary>
		/// Unique external key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Credit card type
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
		/// <summary>
		/// Credit card type user-friendly name
		/// </summary>
		[JsonProperty("type_name")]
		public string TypeName { get; set; }
		/// <summary>
		/// Credit card token
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; }
		/// <summary>
		/// Name on credit card
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
		/// <summary>
		/// Credit card number (masked for security)
		/// </summary>
		[JsonProperty("mask_number")]
		public string MaskNumber { get; set; }
		/// <summary>
		/// Expiration date
		/// </summary>
		[JsonProperty("expdate")]
		public string ExpirationDate { get; set; }
		/// <summary>
		/// Expiration year (only required if you do not provide expdate)
		/// </summary>
		[JsonProperty("expdate_year")]
		public string ExpirationDateYear { get; set; }
		/// <summary>
		/// Expiration month (only required if you do not provide expdate)
		/// </summary>
		[JsonProperty("expdate_month")]
		public string ExpirationDateMonth { get; set; }
		/// <summary>
		/// Expiration date (formatted)
		/// </summary>
		[JsonProperty("expdate_formatted")]
		public string ExpirationDateFormatted { get; set; }
		/// <summary>
		/// Billing street address
		/// </summary>
		[JsonProperty("address")]
		public string Address { get; set; }
		/// <summary>
		/// Billing city
		/// </summary>
		[JsonProperty("city")]
		public string City { get; set; }
		/// <summary>
		/// Billing postal code
		/// </summary>
		[JsonProperty("postcode")]
		public string PostalCode { get; set; }
		/// <summary>
		/// Billing country
		/// </summary>
		[JsonProperty("country")]
		public string Country { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("url_updatelink")]
		public string UrlUpdatelink { get; set; }
		/// <summary>
		/// Date/time the credit card was stored
		/// </summary>
		[JsonProperty("write_datetime")]
		public DateTime? WriteDatetime { get; set; }
		/// <summary>
		/// IP address that created the card
		/// </summary>
		[JsonProperty("write_ipaddr")]
		public string WriteIpaddr { get; set; }
	}
}
