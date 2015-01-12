using System;
using System.Collections.Generic;

namespace ChargeOver
{
	public class ExampleCustomerUpdate
	{
		private ChargeOverAPI api;

		public ExampleCustomerUpdate (ChargeOverAPI api)
		{
			this.api = api;
		}

		public void run()
		{
			// Update a customer example
			Console.WriteLine ("Update a customer with .update(...)");

			// Create our customer object
			Customer cust = new Customer ();
			cust.company = "Updated Company Name";

			int customer_id = 1;

			// Send it to ChargeOver
			Response resp1 = api.Modify (customer_id, cust);

			Console.WriteLine ("Status back was: " + resp1.status + " (" + resp1.message + ")");
		}
	}
}

