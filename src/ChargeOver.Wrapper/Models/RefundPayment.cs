using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class RefundPayment
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("amount")]
		public float? Amount { get; set; }
	}
}
