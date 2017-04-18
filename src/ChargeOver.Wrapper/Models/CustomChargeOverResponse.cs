using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class CustomChargeOverResponse<T>
	{
		[JsonProperty("code")]
		public int Code { get; set; }
		[JsonProperty("status")]
		public string Status { get; set; }
		[JsonProperty("response")]
		public T Response { get; set; }
	}
}