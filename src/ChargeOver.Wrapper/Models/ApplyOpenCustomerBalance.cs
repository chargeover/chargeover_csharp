using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class ApplyOpenCustomerBalance
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("use_customer_balance")]
		public string UseCustomerBalance { get; set; }
	}
}
