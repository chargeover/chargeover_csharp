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
		public int terms_id { get; set; }
		public int currency_id { get; set; }

		public string external_key { get; set; }
		public string nickname { get; set; }
		public string paymethod { get; set; }
		public string paycycle { get; set; }

		public int creditcard_id { get; set; }
		public int ach_id { get; set; }
		public int tokenized_id { get; set; }

		public string custom_1 { get; set; }
		public string custom_2 { get; set; }
		public string custom_3 { get; set; }

		public DateTime write_datetime { get; set; }
		public DateTime mod_datetime { get; set; }
		public DateTime suspendfrom_datetime { get; set; }
		public DateTime suspendto_datetime { get; set; }
		public DateTime cancel_datetime { get; set; }
		public DateTime? holduntil_datetime { get; set; }



		public List<LineItem> line_items;
	}
}

