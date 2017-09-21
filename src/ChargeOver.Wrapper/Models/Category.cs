using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class Category
	{
		/// <summary>
		/// Item category ID #
		/// </summary>
		[JsonProperty("item_category_id")]
		public int? CategoryId { get; set; }
		/// <summary>
		/// Category name
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
		/// <summary>
		/// External key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
	}
}
