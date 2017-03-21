using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class ChangePricingOnSubscription
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("line_items")]
		public ChangePricingLineItem[] LineItems { get; set; }
	}
}
