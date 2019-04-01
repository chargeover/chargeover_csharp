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
		[JsonProperty("applied_to")]
		public TransactionAppliedTo[] AppliedTo { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("amount")]
		public float? Amount { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("paymethods")]
		public PayMethod[] PayMethods { get; set; }
}
}
