using System;

namespace ChargeOver
{
	public class Item
	{
		public int item_id { get; set; }

		public string item_type { get; set; }
		public int tierset_id { get; set; }

		public string name { get; set; }
		public string description { get; set; }
		public string accounting_sku { get; set; }
		public string external_key { get; set; }

		public DateTime write_datetime { get; set; }
		public DateTime? mod_datetime { get; set; }
	}
}

