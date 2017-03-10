using System;

namespace ChargeOver
{
	public class Transaction : Base
	{
		public int transaction_id { get; set; }

		public int? gateway_id { get; set; }
		public int? currency_id { get; set; }

		public bool gateway_status { get; set; }
		public string gateway_transid { get; set; }
		public string gateway_msg { get; set; }

		public float amount { get; set; }

		public string transaction_type { get; set; }
		public string transaction_method { get; set; }
		public string transaction_detail { get; set; }
		public DateTime transaction_datetime { get; set; }

		public DateTime? void_datetime { get; set; }

		public string currency_symbol { get; set; }
		public string currency_iso4217 { get; set; }

		public int customer_id { get; set; }
	}
}

