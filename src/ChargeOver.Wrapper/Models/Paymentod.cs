using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class Paymentod
	{
		[JsonProperty("creditcard_id")]
		public int CreditcardId { get; set; }
	}
}