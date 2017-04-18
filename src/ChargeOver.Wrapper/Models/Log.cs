using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class Log
	{
		[JsonProperty("log_id")]
		public int LogId { get; set; }
		[JsonProperty("msg")]
		public string Msg { get; set; }
		[JsonProperty("log_datetime")]
		public string LogDatetime { get; set; }
	}
}