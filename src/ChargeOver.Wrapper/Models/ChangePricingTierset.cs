using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class ChangePricingTierset
	{
		[JsonProperty("unit_from")]
		public int UnitFrom { get; set; }
		[JsonProperty("unit_to")]
		public int UnitTo { get; set; }
		[JsonProperty("amount")]
		public int Amount { get; set; }
	}
}