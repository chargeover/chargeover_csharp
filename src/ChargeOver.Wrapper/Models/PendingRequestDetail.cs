using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class PendingRequestDetail
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("action")]
		public string Action { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("payload")]
		public string Payload { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("chargeoverjs_id")]
		public int? ChargeOverJsId { get; set; }
	}
}
