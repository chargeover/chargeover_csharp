using System;
using System.Collections.Generic;

namespace ChargeOver.Examples
{
	public class ExampleBulk
	{
		private ChargeOverAPI api;

		public ExampleBulk (ChargeOverAPI api)
		{
			this.api = api;
		}

		public void run()
		{
			// Update a customer example
			Console.WriteLine ("Make a bulk request with .bulk(...)");

			// Create our customer object
			Customer cust1 = new Customer ();
			cust1.company = "New Bulk Customer 1";

			Customer cust2 = new Customer ();
			cust2.company = "New Bulk Customer 2";

			List<Bulk> bulk = new List<Bulk> ();
			bulk.Add (new Bulk ( "POST", "/api/v3/customer", cust1 ));
			bulk.Add (new Bulk ( "POST", "/api/v3/customer", cust2 ));

			// Send it to ChargeOver
			Response resp = api.Bulk (bulk);

			Console.WriteLine ("Overall status back was: " + resp.status + " (" + resp.message + ")");

			// Iterate through the response
			foreach (Response bulkresp in resp.bulk) {
				Console.WriteLine ("This item got returned as code: " + bulkresp.code);
			}

			//Console.WriteLine ("Request was: " + api.GetLastRequest ());
			//Console.WriteLine ("Response was: " + api.GetLastResponse());
		}
	}
}

