using Newtonsoft.Json;

namespace  ChargeOver.Wrapper.Models
{
	public sealed class Customer
	{
		/// <summary>
		/// Main contact ID #
		/// </summary>
		[JsonProperty("superuser_id")]
		public int? SuperUserId { get; set; }
		/// <summary>
		/// External key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Company/customer name
		/// </summary>
		[JsonProperty("company")]
		public string Company { get; set; }
		/// <summary>
		/// Language ID #
		/// </summary>
		[JsonProperty("language_id")]
		public int? LanguageId { get; set; }
		/// <summary>
		/// Currency ID #
		/// </summary>
		[JsonProperty("currency_id")]
		public int? CurrencyId { get; set; }
		/// <summary>
		/// Default terms ID #
		/// </summary>
		[JsonProperty("terms_id")]
		public int? TermsId { get; set; }
		/// <summary>
		/// Default class tracking ID #
		/// </summary>
		[JsonProperty("class_id")]
		public int? ClassId { get; set; }
		/// <summary>
		/// Admin/Worker ID #
		/// </summary>
		[JsonProperty("admin_id")]
		public int? AdminId { get; set; }
		/// <summary>
		/// Campaign/lead source ID #
		/// </summary>
		[JsonProperty("campaign_id")]
		public int? CampaignId { get; set; }
		/// <summary>
		/// Campaign/lead source details
		/// </summary>
		[JsonProperty("campaign_details")]
		public string CampaignDetails { get; set; }
		/// <summary>
		/// Customer type ID #
		/// </summary>
		[JsonProperty("custtype_id")]
		public int? CustomerTypeId { get; set; }
		/// <summary>
		/// Flag to disable charging of taxes
		/// </summary>
		[JsonProperty("no_taxes")]
		public bool NoTaxes { get; set; }
		/// <summary>
		/// Flag to disable dunning
		/// </summary>
		[JsonProperty("no_dunning")]
		public bool NoDunning { get; set; }
		/// <summary>
		/// Main contact username
		/// </summary>
		[JsonProperty("superuser_username")]
		public string SuperUserUsername { get; set; }
		/// <summary>
		/// Main contact e-mail address
		/// </summary>
		[JsonProperty("superuser_email")]
		public string SuperUserEmail { get; set; }
		/// <summary>
		/// Main contact name
		/// </summary>
		[JsonProperty("superuser_name")]
		public string SuperUserName { get; set; }
		/// <summary>
		/// Main contact first name
		/// </summary>
		[JsonProperty("superuser_first_name")]
		public string SuperUserFirstName { get; set; }
		/// <summary>
		/// Main contact last name
		/// </summary>
		[JsonProperty("superuser_last_name")]
		public string SuperUserLastName { get; set; }
		/// <summary>
		/// Main contact phone number
		/// </summary>
		[JsonProperty("superuser_phone")]
		public string SuperuserPhone { get; set; }
		/// <summary>
		/// Billing address line 1
		/// </summary>
		[JsonProperty("bill_addr1")]
		public string BillAddr1 { get; set; }
		/// <summary>
		/// Billing address line 2
		/// </summary>
		[JsonProperty("bill_addr2")]
		public string BillAddr2 { get; set; }
		/// <summary>
		/// Billing address line 3
		/// </summary>
		[JsonProperty("bill_addr3")]
		public string BillAddr3 { get; set; }
		/// <summary>
		/// Billing address city
		/// </summary>
		[JsonProperty("bill_city")]
		public string BillCity { get; set; }
		/// <summary>
		/// Billing address state/province
		/// </summary>
		[JsonProperty("bill_state")]
		public string BillState { get; set; }
		/// <summary>
		/// Billing address postal code
		/// </summary>
		[JsonProperty("bill_postcode")]
		public string BillPostalCode { get; set; }
		/// <summary>
		/// Billing address country
		/// </summary>
		[JsonProperty("bill_country")]
		public string BillCountry { get; set; }
		/// <summary>
		/// Shipping address line 1
		/// </summary>
		[JsonProperty("ship_addr1")]
		public string ShipAddr1 { get; set; }
		/// <summary>
		/// Shipping address line 2
		/// </summary>
		[JsonProperty("ship_addr2")]
		public string ShipAddr2 { get; set; }
		/// <summary>
		/// Shipping address line 3
		/// </summary>
		[JsonProperty("ship_addr3")]
		public string ShipAddr3 { get; set; }
		/// <summary>
		/// Shipping address city
		/// </summary>
		[JsonProperty("ship_city")]
		public string ShipCity { get; set; }
		/// <summary>
		/// Shipping address state
		/// </summary>
		[JsonProperty("ship_state")]
		public string ShipState { get; set; }
		/// <summary>
		/// Shipping address postal code
		/// </summary>
		[JsonProperty("ship_postcode")]
		public string ShipPostalCode { get; set; }
		/// <summary>
		/// Shipping address country
		/// </summary>
		[JsonProperty("ship_country")]
		public string ShipCountry { get; set; }
		/// <summary>
		/// Custom field #1
		/// </summary>
		[JsonProperty("custom_1")]
		public string Custom1 { get; set; }
		/// <summary>
		/// Custom field #2
		/// </summary>
		[JsonProperty("custom_2")]
		public string Custom2 { get; set; }
		/// <summary>
		/// Custom field #3
		/// </summary>
		[JsonProperty("custom_3")]
		public string Custom3 { get; set; }
		/// <summary>
		/// Custom field #4
		/// </summary>
		[JsonProperty("custom_4")]
		public string Custom4 { get; set; }
		/// <summary>
		/// Custom field #5
		/// </summary>
		[JsonProperty("custom_5")]
		public string Custom5 { get; set; }
		/// <summary>
		/// Custom field #6
		/// </summary>
		[JsonProperty("custom_6")]
		public string Custom6 { get; set; }
		/// <summary>
		/// Brand ID #
		/// </summary>
		[JsonProperty("brand_id")]
		public int? BrandId { get; set; }
		/// <summary>
		/// Delivery method for initial invoices ("email" or "print" for printed hard-copy)
		/// </summary>
		[JsonProperty("invoice_delivery")]
		public string InvoiceDelivery { get; set; }
		/// <summary>
		/// Delivery method for dunning/reminder invoices ("email" or "print" for printed hard-copy via Docsaway, Lob, etc.)
		/// </summary>
		[JsonProperty("dunning_delivery")]
		public string DunningDelivery { get; set; }
	}
}
