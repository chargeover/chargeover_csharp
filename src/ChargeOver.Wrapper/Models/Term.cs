using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class Term
	{
		/// <summary>
		/// Terms ID #
		/// </summary>
		[JsonProperty("terms_id")]
		public int? TermsId { get; set; }
		/// <summary>
		/// Terms name
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
		/// <summary>
		/// # of days
		/// </summary>
		[JsonProperty("days")]
		public int? Days { get; set; }
	}
}
