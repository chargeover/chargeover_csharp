using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class StoreACHAccount
	{
		/// <summary>
		/// Customer ID #
		/// </summary>
		[JsonProperty("customer_id")]
		public int? CustomerId { get; set; }
		/// <summary>
		/// Unique external key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Bank account type (one of: chec, busi, savi)
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
		/// <summary>
		/// Bank account number
		/// </summary>
		[JsonProperty("number")]
		public string Number { get; set; }
		/// <summary>
		/// Bank account routing number
		/// </summary>
		[JsonProperty("routing")]
		public string Routing { get; set; }
		/// <summary>
		/// Name on bank account
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
		/// <summary>
		/// Bank name
		/// </summary>
		[JsonProperty("bank")]
		public string Bank { get; set; }
	}
}
