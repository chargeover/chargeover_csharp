using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class EmailInvoice
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("email")]
		public string Email { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("subject")]
		public string Subject { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("body")]
		public string Body { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("from")]
		public string From { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("template_name")]
		public string TemplateName { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("template_opts")]
		public string TemplateOptions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("message_id")]
        public string MessageId { get; set; }
    }
}
