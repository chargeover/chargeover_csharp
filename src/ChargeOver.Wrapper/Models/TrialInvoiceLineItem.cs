using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class TrialInvoiceLineItem
	{
		[JsonProperty("item_id")]
		public int ItemId { get; set; }
		[JsonProperty("descrip")]
		public string Descrip { get; set; }
		[JsonProperty("line_rate")]
		public float LineRate { get; set; }
		[JsonProperty("line_quantity")]
		public int LineQuantity { get; set; }
		[JsonProperty("trial_days")]
		public int TrialDays { get; set; }
	}
}