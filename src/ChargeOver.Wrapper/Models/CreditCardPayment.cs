using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class CreditCardPayment
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("number")]
		public string Number { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("expdate_year")]
		public string ExpdateYear { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("expdate_month")]
		public string ExpdateMonth { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("address")]
		public string Address { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("city")]
		public string City { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("state")]
		public string State { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("postcode")]
		public string Postcode { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("country")]
		public string Country { get; set; }
	}
}
