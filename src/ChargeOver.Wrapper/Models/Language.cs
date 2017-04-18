using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class Language
	{
		/// <summary>
		/// Language ID #
		/// </summary>
		[JsonProperty("language_id")]
		public int? LanguageId { get; set; }
		/// <summary>
		/// Language
		/// </summary>
		[JsonProperty("language")]
		public string Name { get; set; }
		/// <summary>
		/// ISO 639 code
		/// </summary>
		[JsonProperty("iso639")]
		public string Iso639 { get; set; }
	}
}
