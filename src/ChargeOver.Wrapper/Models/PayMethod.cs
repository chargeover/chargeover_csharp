using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class PayMethod
	{
		[JsonProperty("creditcard_id")]
		public int CreditCardId { get; set; }
	}
}