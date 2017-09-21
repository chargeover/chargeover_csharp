using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class SubscriptionDetails
	{
		/// <summary>
		/// Package ID #
		/// </summary>
		[JsonProperty("package_id")]
		public int? PackageId { get; set; }
		/// <summary>
		/// Customer ID #
		/// </summary>
		[JsonProperty("customer_id")]
		public int? CustomerId { get; set; }
		/// <summary>
		/// Class ID #
		/// </summary>
		[JsonProperty("class_id")]
		public int? ClassId { get; set; }
		/// <summary>
		/// External key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Unique token
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; }
		/// <summary>
		/// Nickname for the package
		/// </summary>
		[JsonProperty("nickname")]
		public string Nickname { get; set; }
		/// <summary>
		/// Payment method for the package, one of: cre, inv, ach
		/// </summary>
		[JsonProperty("paymethod")]
		public string PayMethod { get; set; }
		/// <summary>
		/// Credit card ID # (if the package is paid by credit card)
		/// </summary>
		[JsonProperty("creditcard_id")]
		public int? CreditCardId { get; set; }
		/// <summary>
		/// ACH ID # (if the package is paid by ACH)
		/// </summary>
		[JsonProperty("ach_id")]
		public int? AchId { get; set; }
		/// <summary>
		/// Tokenized ID # (if the package is paid by an external service token)
		/// </summary>
		[JsonProperty("tokenized_id")]
		public int? TokenizedId { get; set; }
		/// <summary>
		/// Admin/worker ID #
		/// </summary>
		[JsonProperty("admin_id")]
		public int? AdminId { get; set; }
		/// <summary>
		/// Admin/worker name
		/// </summary>
		[JsonProperty("admin_name")]
		public string AdminName { get; set; }
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
		/// Billing address state
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
		/// 
		/// </summary>
		[JsonProperty("bill_notes")]
		public string BillNotes { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ship_addr1")]
		public string ShipAddr1 { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ship_addr2")]
		public string ShipAddr2 { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ship_addr3")]
		public string ShipAddr3 { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ship_city")]
		public string ShipCity { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ship_state")]
		public string ShipState { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ship_postcode")]
		public string ShipPostalCode { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ship_country")]
		public string ShipCountry { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ship_notes")]
		public string ShipNotes { get; set; }
		/// <summary>
		/// Currency ID #
		/// </summary>
		[JsonProperty("currency_id")]
		public int? CurrencyId { get; set; }
		/// <summary>
		/// Currency ISO 4217 code
		/// </summary>
		[JsonProperty("currency_iso4217")]
		public string CurrencyIso4217 { get; set; }
		/// <summary>
		/// Currency symbol
		/// </summary>
		[JsonProperty("currency_symbol")]
		public string CurrencySymbol { get; set; }
		/// <summary>
		/// Total amount collected so far for this package
		/// </summary>
		[JsonProperty("amount_collected")]
		public float? AmountCollected { get; set; }
		/// <summary>
		/// Total amount invoiced so far
		/// </summary>
		[JsonProperty("amount_invoiced")]
		public float? AmountInvoiced { get; set; }
		/// <summary>
		/// Total amount due (invoiced - collected)
		/// </summary>
		[JsonProperty("amount_due")]
		public float? AmountDue { get; set; }
		/// <summary>
		/// Date/time this package was suspended from
		/// </summary>
		[JsonProperty("suspendfrom_datetime")]
		public DateTime? SuspendfromDatetime { get; set; }
		/// <summary>
		/// Date/time this package was suspended to
		/// </summary>
		[JsonProperty("suspendto_datetime")]
		public DateTime? SuspendtoDatetime { get; set; }
		/// <summary>
		/// The date the next invoice will be generated
		/// </summary>
		[JsonProperty("next_invoice_datetime")]
		public DateTime? NextInvoiceDatetime { get; set; }
		/// <summary>
		/// Whether or not the invoice is overdue
		/// </summary>
		[JsonProperty("is_overdue")]
		public bool IsOverdue { get; set; }
		/// <summary>
		/// # of days overdue the package is
		/// </summary>
		[JsonProperty("days_overdue")]
		public int? DaysOverdue { get; set; }
		/// <summary>
		/// Date/time this package was started/effective
		/// </summary>
		[JsonProperty("start_datetime")]
		public DateTime? StartDatetime { get; set; }
		/// <summary>
		/// Date/time this package was cancelled
		/// </summary>
		[JsonProperty("cancel_datetime")]
		public DateTime? CancelDatetime { get; set; }
		/// <summary>
		/// Date/time this package was created
		/// </summary>
		[JsonProperty("write_datetime")]
		public DateTime? WriteDatetime { get; set; }
		/// <summary>
		/// Date/time this package was last updated
		/// </summary>
		[JsonProperty("mod_datetime")]
		public DateTime? ModDatetime { get; set; }
		/// <summary>
		/// Date/time invoicing for this package is being held until
		/// </summary>
		[JsonProperty("holduntil_datetime")]
		public DateTime? HolduntilDatetime { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("package_status_id")]
		public string PackageStatusId { get; set; }
		/// <summary>
		/// User-friendly subscription status
		/// </summary>
		[JsonProperty("package_status_name")]
		public string PackageStatusName { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("package_status_str")]
		public string PackageStatusStr { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("package_status_state")]
		public string PackageStatusState { get; set; }
		/// <summary>
		/// Date of the next invoice
		/// </summary>
		[JsonProperty("cache_next_invoice")]
		public DateTime? CacheNextInvoice { get; set; }
		/// <summary>
		/// Terms ID #
		/// </summary>
		[JsonProperty("terms_id")]
		public int? TermsId { get; set; }
		/// <summary>
		/// Payment terms
		/// </summary>
		[JsonProperty("terms_name")]
		public string TermsName { get; set; }
		/// <summary>
		/// Terms # of days
		/// </summary>
		[JsonProperty("terms_days")]
		public int? TermsDays { get; set; }
		/// <summary>
		/// Payment cycle
		/// </summary>
		[JsonProperty("paycycle")]
		public string Paycycle { get; set; }
		/// <summary>
		/// Custom field value #1
		/// </summary>
		[JsonProperty("custom_1")]
		public string Custom1 { get; set; }
		/// <summary>
		/// Custom field value #2
		/// </summary>
		[JsonProperty("custom_2")]
		public string Custom2 { get; set; }
		/// <summary>
		/// Custom field value #3
		/// </summary>
		[JsonProperty("custom_3")]
		public string Custom3 { get; set; }
		/// <summary>
		/// Custom field value #4
		/// </summary>
		[JsonProperty("custom_4")]
		public string Custom4 { get; set; }
		/// <summary>
		/// Custom field value #5
		/// </summary>
		[JsonProperty("custom_5")]
		public string Custom5 { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("line_items")]
		public SubscriptionLineItem[] LineItems { get; set; }
		/// <summary>
		/// URL for viewing the subscription in the GUI
		/// </summary>
		[JsonProperty("url_self")]
		public string UrlSelf { get; set; }
	}
}
