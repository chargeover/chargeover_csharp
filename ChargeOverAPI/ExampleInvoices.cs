using System;
using System.Collections.Generic;

namespace ChargeOver
{
	public class ExampleInvoices
	{
		private ChargeOverAPI api;

		public ExampleInvoices(ChargeOverAPI api)
		{
			this.api = api;
		}

		public void run()
		{
			Console.WriteLine ("\n\n\n");
			Console.WriteLine ("EXAMPLES OF DOING STUFF WITH INVOICES");
			Console.WriteLine ("  SEE ExampleInvoices.cs FOR SOURCE CODE! Hit [Enter] to continue...");
			Console.WriteLine ("");
			Console.ReadLine();

			// ****************************
			// Query for a list of invoices
			// ****************************
			Console.WriteLine ("");
			Console.WriteLine ("Query for invoices with .find(...)");
			Console.WriteLine ("");

			// Build our query
			List<string> query1 = new List<string> ();
			query1.Add ("invoice_status_state:EQUALS:o");

			// Find our invoices
			Response resp1 = api.find (typeof(Invoice), query1);

			foreach (Invoice inv in resp1.list)
			{
				Console.WriteLine ("#" + inv.refnumber + " => " + inv.date.ToString ());

				// Get the whole invoice
				Response resp4 = api.get (typeof(Invoice), inv.invoice_id);
				Invoice thisinv = (Invoice) resp4.obj;

				int count = thisinv.line_items.Count;
				Console.WriteLine ("    has " + count + " line items");
			}


			// ************************
			// Get one specific invoice
			// ************************
			Console.WriteLine ("");
			Console.WriteLine ("Get a specific invoice with .get(...)");
			Console.WriteLine ("");

			int the_invoice_id = 2718;
			Response resp2 = api.get (typeof(Invoice), the_invoice_id);

			Invoice myinv = (Invoice) resp2.obj;

			Console.WriteLine ("Fetched invoice #" + myinv.refnumber + " for customer #" + myinv.customer_id);
		}
	}
}

