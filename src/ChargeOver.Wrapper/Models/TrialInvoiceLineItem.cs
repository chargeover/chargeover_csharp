using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class TrialInvoiceLineItem
	{
		[JsonProperty("item_id")]
		public int ItemId { get; set; }
		[JsonProperty("descrip")]
		public string Description { get; set; }
		[JsonProperty("line_item_id")]
		public float LineItemId { get; set; }
		[JsonProperty("line_quantity")]
		public int LineQuantity { get; set; }
	}
}