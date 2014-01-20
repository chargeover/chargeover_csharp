using System;

namespace ChargeOver
{
	public class Invoice : Base
	{
		public int invoice_id;

		public string bill_addr1 = "";
		public string bill_addr2 = "";
		public string bill_addr3 = "";
		public string bill_city = "";
		public string bill_state = "";
		public string bill_postcode = "";
		public string bill_country = "";

		public int customer_id;

		public Date invoice_date;
	}
}

