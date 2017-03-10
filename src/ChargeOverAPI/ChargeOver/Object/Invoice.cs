using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ChargeOver
{
	public class Invoice : Base
	{
		public Invoice()
		{
			this.line_items = new List<LineItem> ();
		}

		public int invoice_id  { get; set; }
		public int? currency_id { get; set; }

		public string refnumber { get; set; }

		public DateTime write_datetime { get; set; }
		public DateTime? void_datetime { get; set; }

		public string currency_symbol { get; set; }
		public string currency_iso4217 { get; set; }

		public string invoice_status_name { get; set; }
		public string invoice_status_state { get; set; }

		public float total { get; set; }
		public float balance { get; set; }
		public float credits { get; set; }
		public float payments { get; set; }

		public bool is_paid { get; set; }
		public bool is_overdue { get; set; }
		public bool is_void { get; set; }

		public string bill_block { get; set; }

		public string url_permalink { get; set; }
		public string url_paylink { get; set; }
		public string url_pdflink { get; set; }

		public string bill_addr1 { get; set; }
		public string bill_addr2 { get; set; }
		public string bill_addr3 { get; set; }
		public string bill_city { get; set; }
		public string bill_state { get; set; }
		public string bill_postcode { get; set; }
		public string bill_country { get; set; }

		public int customer_id { get; set; }

		[JsonConverter(typeof(CODateConverter))]
		public Date date { get; set; }

		public List<LineItem> line_items { get; set; }
	}
}

