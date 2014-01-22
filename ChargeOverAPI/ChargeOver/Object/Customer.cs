using System;

namespace ChargeOver
{
	public class Customer : Base
	{
		public int customer_id { get; set; }

		public int superuser_id { get; set; }

		public string company { get; set; }

		public string bill_addr1 { get; set; }
		public string bill_addr2 { get; set; }
		public string bill_addr3 { get; set; }
		public string bill_city { get; set; }
		public string bill_state { get; set; }
		public string bill_postcode { get; set; }
		public string bill_country { get; set; }

		public int currency_id { get; set; }
		public string currency_symbol { get; set; }
		public string currency_iso4217 { get; set; }

		public DateTime write_datetime { get; set; }
		public DateTime mod_datetime { get; set; }

		public string bill_block { get;  set; }

		public string superuser_name { get; set; }
		public string superuser_first_name { get; set; }
		public string superuser_last_name { get; set; }
		public string superuser_phone { get; set; }
		public string superuser_email { get; set; }

		public string external_key { get; set; }
	}
}

