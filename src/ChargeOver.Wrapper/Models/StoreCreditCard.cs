using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class StoreCreditCard
	{
		/// <summary>
		/// The customer id #
		/// </summary>
		[JsonProperty("customer_id")]
		public int? CustomerId { get; set; }
		/// <summary>
		/// Unique external key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Name on credit card
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
		/// <summary>
		/// Credit card number
		/// </summary>
		[JsonProperty("number")]
		public string Number { get; set; }
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
		/// Billing state
		/// </summary>
		[JsonProperty("state")]
		public string State { get; set; }
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
	}
}
