using System;
using System.Collections.Generic;

namespace ChargeOver
{
	public class ExampleCustomers
	{
		private ChargeOverAPI api;

		public ExampleCustomers (ChargeOverAPI api)
		{
			this.api = api;
		}

		public void run()
		{
			Console.WriteLine ("\n\n\n");
			Console.WriteLine ("EXAMPLES OF DOING STUFF WITH CUSTOMERS");
			Console.WriteLine ("  SEE ExampleCustomers.cs FOR SOURCE CODE! Hit [Enter] to continue...");
			Console.WriteLine ("");
			Console.ReadLine();


			// *****************
			// Create a customer
			// *****************
			Console.WriteLine ("");
			Console.WriteLine ("Create a customer with .create(...)");
			Console.WriteLine ("");

			// Create our customer object
			Customer cust = new Customer ();
			cust.company = "Test C# Company";
			cust.bill_addr1 = "72 E Blue Grass Road";
			cust.bill_city = "Mt Pleasant";
			cust.bill_state = "MI";
			cust.bill_postcode = "48858";

			// Send it to ChargeOver
			Response resp1 = api.create (cust);

			Console.WriteLine ("Status back was: " + resp1.status + ", new customer id is " + resp1.id);



			// **********************
			// Querying for customers
			// **********************
			Console.WriteLine ("");
			Console.WriteLine ("Query for customers with .find(...)");
			Console.WriteLine ("");

			List<string> query2 = new List<string> ();
			Response resp2 = api.find(typeof(Customer), query2);

			foreach (Customer mycust in resp2.list)
			{
				Console.WriteLine(mycust.customer_id + " => " + mycust.company);
			}



		}
	}
}

