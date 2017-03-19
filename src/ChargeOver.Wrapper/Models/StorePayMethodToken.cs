using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class StorePayMethodToken
	{
		/// <summary>
		/// Customer ID #
		/// </summary>
		[JsonProperty("customer_id")]
		public int? CustomerId { get; set; }
		/// <summary>
		/// Type of token (usually "customer")
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
		/// <summary>
		/// The token value
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; }
	}
}
