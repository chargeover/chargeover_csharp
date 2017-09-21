using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class SetThePaymentMethod
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("paymethod")]
		public string PayMethod { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("creditcard_id")]
		public int CreditCardId { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ach_id")]
		public string AchId { get; set; }
	}
}
