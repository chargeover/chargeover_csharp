using System;
using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class CommitChargeOver
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("commit")]
		public string Commit { get; set; }
	}
}
