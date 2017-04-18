using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class ChangePricingLineItem
	{
		[JsonProperty("line_item_id")]
		public int LineItemId { get; set; }
		[JsonProperty("item_id")]
		public int ItemId { get; set; }
		[JsonProperty("descrip")]
		public string Descrip { get; set; }
		[JsonProperty("tierset")]
		public ChangePricingTierset Tierset { get; set; }
	}
}