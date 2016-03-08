using System;
using System.Collections.Generic;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Converters;

namespace ChargeOver
{
	public class Package : Base
	{
		public Package ()
		{
			this.line_items = new List<LineItem> ();
		}

		public int package_id { get; set; }
		public int customer_id { get; set; }
		public int class_id { get; set; }
		public int terms_id { get; set; }
		public int currency_id { get; set; }

		public string token { get; set; }
		public string external_key { get; set; }
		public string nickname { get; set; }
		public string paymethod { get; set; }
		public string paycycle { get; set; }

		public int creditcard_id { get; set; }
		public int ach_id { get; set; }
		public int tokenized_id { get; set; }

		public int admin_id { get; set; }
		public int admin_name { get; set; }

		public string custom_1 { get; set; }
		public string custom_2 { get; set; }
		public string custom_3 { get; set; }

		public DateTime write_datetime { get; set; }
		public DateTime mod_datetime { get; set; }
		public DateTime suspendfrom_datetime { get; set; }
		public DateTime suspendto_datetime { get; set; }
		public DateTime cancel_datetime { get; set; }
		public DateTime? holduntil_datetime { get; set; }

		public string currency_iso4217 { get; set; }
		public string currency_symbol { get; set; }
		public float amount_collected { get; set; }
		public float amount_invoiced { get; set; }
		public float amount_due	{ get; set; }

		public bool is_overdue { get; set; }
		public int days_overdue { get; set; }

		public int package_status_id { get; set; }
		public string package_status_name { get; set; }
		public string package_status_str { get; set; }
		public string package_status_state { get; set; }

		public List<LineItem> line_items;
	}
}

