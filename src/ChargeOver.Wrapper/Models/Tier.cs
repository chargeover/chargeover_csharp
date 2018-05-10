using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class Tier
	{
		[JsonProperty("unit_from")]
		public double UnitFrom { get; set; }
		[JsonProperty("unit_to")]
		public double UnitTo { get; set; }
		[JsonProperty("amount")]
		public double Amount { get; set; }
		[JsonProperty("tier_id")]
        	public int Id { get; set; }
	}
}
