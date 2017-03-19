using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class ChargeOverResponse<T>
	{
		[JsonProperty("code")]
		public int Code { get; set; }
		[JsonProperty("status")]
		public string Status { get; set; }
		[JsonProperty("response")]
		public T[] Response { get; set; }
	}

	public sealed class ChargeOverResponse
	{
		[JsonProperty("code")]
		public int Code { get; set; }
		[JsonProperty("status")]
		public string Status { get; set; }
		[JsonProperty("message")]
		public string Message { get; set; }
	}
}