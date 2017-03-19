using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class AttemptPayment
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("customer_id")]
		public int? CustomerId { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("_comment")]
		public string Comment { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("applied_to")]
		public string AppliedTo { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("amount")]
		public float? Amount { get; set; }
	}
}
