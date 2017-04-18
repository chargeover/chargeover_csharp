using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class ChargeOverResponseDetails
	{
		[JsonProperty("id")]
		public int Id { get; set; }
	}
}