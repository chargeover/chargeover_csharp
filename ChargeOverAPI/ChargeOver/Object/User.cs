using System;

namespace ChargeOver
{
	public class User : Base
	{
		public int user_id { get; set; }

		public string name { get; set; }
		public string first_name { get; set; }
		public string last_name { get; set; }

		public string phone { get; set; }
		public string email { get; set; }

		public string username { get; set; }
		public string external_key { get; set; }

		public int? customer_id { get; set; }
	}
}

