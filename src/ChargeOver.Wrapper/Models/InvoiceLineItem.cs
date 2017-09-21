using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class InvoiceLineItem
	{
		[JsonProperty("item_id")]
		public int ItemId { get; set; }
		[JsonProperty("descrip")]
		public string Description { get; set; }
		[JsonProperty("line_rate")]
		public float LineRate { get; set; }
		[JsonProperty("line_quantity")]
		public int LineQuantity { get; set; }
	}
}