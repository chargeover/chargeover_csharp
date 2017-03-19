using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class IdentityChargeOverResponse
	{
		[JsonProperty("code")]
		public int Code { get; set; }
		[JsonProperty("status")]
		public string Status { get; set; }
		[JsonProperty("response")]
		public ChargeOverResponseDetails Response { get; set; }
	}
}