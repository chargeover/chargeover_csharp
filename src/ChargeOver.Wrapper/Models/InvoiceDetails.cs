using System;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Models
{
	public sealed class InvoiceDetails
	{
		/// <summary>
		/// Invoice ID #
		/// </summary>
		[JsonProperty("invoice_id")]
		public int? InvoiceId { get; set; }
		/// <summary>
		/// Invoice reference number
		/// </summary>
		[JsonProperty("refnumber")]
		public string RefNumber { get; set; }
		/// <summary>
		/// External key value
		/// </summary>
		[JsonProperty("external_key")]
		public string ExternalKey { get; set; }
		/// <summary>
		/// Subscription ID # this invoice was generated from
		/// </summary>
		[JsonProperty("package_id")]
		public int? PackageId { get; set; }
		/// <summary>
		/// Customer ID #
		/// </summary>
		[JsonProperty("customer_id")]
		public int? CustomerId { get; set; }
		/// <summary>
		/// Date/time the invoice was created
		/// </summary>
		[JsonProperty("write_datetime")]
		public DateTime? WriteDatetime { get; set; }
		/// <summary>
		/// Date/time the invoice was voided
		/// </summary>
		[JsonProperty("void_datetime")]
		public DateTime? VoidDatetime { get; set; }
		/// <summary>
		/// Invoice date
		/// </summary>
		[JsonProperty("date")]
		public DateTime? Date { get; set; }
		/// <summary>
		/// Currency ID #
		/// </summary>
		[JsonProperty("currency_id")]
		public int? CurrencyId { get; set; }
		/// <summary>
		/// Currency symbol
		/// </summary>
		[JsonProperty("currency_symbol")]
		public string CurrencySymbol { get; set; }
		/// <summary>
		/// Currency ISO 4217 representation
		/// </summary>
		[JsonProperty("currency_iso4217")]
		public string CurrencyIso4217 { get; set; }
		/// <summary>
		/// Terms ID #
		/// </summary>
		[JsonProperty("terms_id")]
		public int? TermsId { get; set; }
		/// <summary>
		/// Terms name
		/// </summary>
		[JsonProperty("terms_name")]
		public string TermsName { get; set; }
		/// <summary>
		/// Terms # of days
		/// </summary>
		[JsonProperty("terms_days")]
		public int? TermsDays { get; set; }
		/// <summary>
		/// Admin/Worker ID #
		/// </summary>
		[JsonProperty("admin_id")]
		public int? AdminId { get; set; }
		/// <summary>
		/// Admin/Worker Name
		/// </summary>
		[JsonProperty("admin_name")]
		public string AdminName { get; set; }
		/// <summary>
		/// Unique token
		/// </summary>
		[JsonProperty("token")]
		public string Token { get; set; }
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
		/// Printable billing address
		/// </summary>
		[JsonProperty("bill_block")]
		public string BillBlock { get; set; }
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
		/// 
		/// </summary>
		[JsonProperty("ship_block")]
		public string ShipBlock { get; set; }
		/// <summary>
		/// For pre-billing, cycle start date
		/// </summary>
		[JsonProperty("cycle_pre_from_date")]
		public DateTime? CyclePreFromDate { get; set; }
		/// <summary>
		/// For pre-billing, cycle end date
		/// </summary>
		[JsonProperty("cycle_pre_to_date")]
		public DateTime? CyclePreToDate { get; set; }
		/// <summary>
		/// Cycle date (generally the invoice date)
		/// </summary>
		[JsonProperty("cycle_this_date")]
		public DateTime? CycleThisDate { get; set; }
		/// <summary>
		/// For post-billing (in arrears), cycle start date
		/// </summary>
		[JsonProperty("cycle_post_from_date")]
		public DateTime? CyclePostFromDate { get; set; }
		/// <summary>
		/// For post-billing (in arrears), cycle end date
		/// </summary>
		[JsonProperty("cycle_post_to_date")]
		public DateTime? CyclePostToDate { get; set; }
		/// <summary>
		/// URL to view the invoice
		/// </summary>
		[JsonProperty("url_permalink")]
		public string UrlPermaLink { get; set; }
		/// <summary>
		/// URL to download the invoice PDF
		/// </summary>
		[JsonProperty("url_pdflink")]
		public string UrlPdfLink { get; set; }
		/// <summary>
		/// URL to pay for the invoice
		/// </summary>
		[JsonProperty("url_paylink")]
		public string UrlPaylink { get; set; }
		/// <summary>
		/// URL for viewing the invoice in the GUI
		/// </summary>
		[JsonProperty("url_self")]
		public string UrlSelf { get; set; }
		/// <summary>
		/// Whether or not the invoice has been paid
		/// </summary>
		[JsonProperty("is_paid")]
		public bool IsPaid { get; set; }
		/// <summary>
		/// Whether or not the invoice has been voided
		/// </summary>
		[JsonProperty("is_void")]
		public bool IsVoid { get; set; }
		/// <summary>
		/// Whether or not the invoice is overdue
		/// </summary>
		[JsonProperty("is_overdue")]
		public bool IsOverdue { get; set; }
		/// <summary>
		/// Date the invoice is due
		/// </summary>
		[JsonProperty("due_date")]
		public DateTime? DueDate { get; set; }
		/// <summary>
		/// # of days overdue the invoice is
		/// </summary>
		[JsonProperty("days_overdue")]
		public int? DaysOverdue { get; set; }
		/// <summary>
		/// Date this invoice was paid
		/// </summary>
		[JsonProperty("paid_date")]
		public DateTime? PaidDate { get; set; }
		/// <summary>
		/// Balance of the invoice
		/// </summary>
		[JsonProperty("balance")]
		public float? Balance { get; set; }
		/// <summary>
		/// Amount applied to the invoice
		/// </summary>
		[JsonProperty("applied")]
		public float? Applied { get; set; }
		/// <summary>
		/// Invoice total
		/// </summary>
		[JsonProperty("total")]
		public float? Total { get; set; }
		/// <summary>
		/// Invoice subtotal
		/// </summary>
		[JsonProperty("subtotal")]
		public float? Subtotal { get; set; }
		/// <summary>
		/// Taxes
		/// </summary>
		[JsonProperty("taxes")]
		public float? Taxes { get; set; }
		/// <summary>
		/// Amount of credits applied to the invoice
		/// </summary>
		[JsonProperty("credits")]
		public float? Credits { get; set; }
		/// <summary>
		/// Amount of payments applied to the invoice
		/// </summary>
		[JsonProperty("payments")]
		public float? Payments { get; set; }
		/// <summary>
		/// Amount written off
		/// </summary>
		[JsonProperty("writeoffs")]
		public float? Writeoffs { get; set; }
		/// <summary>
		/// # of times that payment was attempted and failed for this invoice
		/// </summary>
		[JsonProperty("declines")]
		public int? Declines { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("sum_base")]
		public float? SumBase { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("sum_usage")]
		public float? SumUsage { get; set; }
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("sum_onetime")]
		public float? SumOnetime { get; set; }
		/// <summary>
		/// Human-friendly invoice status
		/// </summary>
		[JsonProperty("invoice_status_name")]
		public string InvoiceStatusName { get; set; }
		/// <summary>
		/// Status string
		/// </summary>
		[JsonProperty("invoice_status_str")]
		public string InvoiceStatusStr { get; set; }
		/// <summary>
		/// Status code
		/// </summary>
		[JsonProperty("invoice_status_state")]
		public string InvoiceStatusState { get; set; }
		/// <summary>
		/// Memo/notes to customer
		/// </summary>
		[JsonProperty("memo")]
		public string Memo { get; set; }
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
		/// A list of line items for the invoice
		/// </summary>
		[JsonProperty("line_items")]
		public object LineItems { get; set; }
	}
}
