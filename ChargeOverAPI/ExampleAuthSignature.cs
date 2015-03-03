using System;
using System.Collections.Generic;

namespace ChargeOver
{
	public class ExampleAuthSignature
	{
		private ChargeOverAPI api;

		public ExampleAuthSignature (ChargeOverAPI api)
		{
			this.api = api;
		}

		public void run()
		{
			// Set the API to use signature auth
			//   Auth signatures are a bit more secure vs. HTTP Basic auth
			api.SetAuth (ChargeOverAPI.AuthSignatureV1);

			// Add a customer
			Console.WriteLine ("Add a customer with signature auth...");

			// Create our customer object
			Customer cust = new Customer ();
			cust.company = "New Company Name";

			// Send it to ChargeOver
			Response resp1 = api.Create(cust);

			Console.WriteLine ("Status back was: " + resp1.status + " (" + resp1.message + ")");
		}
	}
}

