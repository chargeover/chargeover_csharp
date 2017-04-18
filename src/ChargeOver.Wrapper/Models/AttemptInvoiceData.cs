using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class AttemptInvoiceData
	{
		[JsonProperty("invoice_id")]
		public int InvoiceId { get; set; }
	}
}