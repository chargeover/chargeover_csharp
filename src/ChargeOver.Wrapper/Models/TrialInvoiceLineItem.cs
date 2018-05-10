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
		[JsonProperty("subscribe_prorate")]
        	public bool Prorate{get;set;}
        	[JsonProperty("external_key")]
        	public string ExternalKey { get; set; }
        	[JsonProperty("subscribe_prorate_cycle")]
        	public string ProrateCycle { get; set; }
	}
}
