using System;

namespace ChargeOver
{
	public class LineItem : Base
	{
		public int invoice_line_id { get; set; }
		public int invoice_id { get; set; }

		public int item_id { get; set; }
		public int? tierset_id { get; set; }
		public int? contract_line_id { get; set; }

		public string descrip { get; set; }

		public float line_rate { get; set; }
		public float line_quantity { get; set; }
		public float? line_usage { get; set; }

		public bool is_base { get; set; }
		public bool is_free { get; set; }
		public bool is_recurring { get; set; }
	}
}

