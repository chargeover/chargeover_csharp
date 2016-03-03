using System;
using System.Collections.Generic;

namespace ChargeOver.Examples
{
	public class ExampleTransactions
	{
		private ChargeOverAPI api;

		public ExampleTransactions(ChargeOverAPI api)
		{
			this.api = api;
		}

		public void run()
		{
			Console.WriteLine ("\n\n\n");
			Console.WriteLine ("EXAMPLES OF DOING STUFF WITH TRANSACTIONS");
			Console.WriteLine ("  SEE ExampleTransactions.cs FOR SOURCE CODE! Hit [Enter] to continue...");
			Console.WriteLine ("");
			Console.ReadLine();

			// ********************************
			// Query for a list of transactions
			// ********************************
			Console.WriteLine ("");
			Console.WriteLine ("Query for transactions with .find(...)");
			Console.WriteLine ("");

			// Build our query
			List<string> query1 = new List<string> ();
			query1.Add ("gateway_status:EQUALS:1");

			// Find our invoices
			Response resp1 = api.Find (typeof(Transaction), query1);

			foreach (Transaction trans in resp1.list)
			{
				Console.WriteLine ("#" + trans.gateway_transid + " => " + trans.transaction_datetime.ToString ());
			}

		}
	}
}

