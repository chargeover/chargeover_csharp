using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class CustomerEntity : Entity
	{
		[JsonProperty("superuser_id")]
		public string SuperuserId { get; set; }
		[JsonProperty("company")]
		public string Company { get; set; }
		[JsonProperty("bill_addr1")]
		public string BillAddr1 { get; set; }
		[JsonProperty("bill_addr2 ")]
		public string BillAddr2 { get; set; }
		[JsonProperty("bill_city")]
		public string BillCity { get; set; }
		[JsonProperty("bill_state")]
		public string BillState { get; set; }
	}
}