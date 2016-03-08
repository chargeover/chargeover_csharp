using System;
using System.Collections.Generic;

namespace ChargeOver.Examples
{
	public class ExamplePackages
	{
		private ChargeOverAPI api;

		public ExamplePackages(ChargeOverAPI api)
		{
			this.api = api;
		}

		public void run()
		{
			Console.WriteLine ("\n\n\n");
			Console.WriteLine ("EXAMPLES OF DOING STUFF WITH PACKAGES (SUBSCRIPTIONS)");
			Console.WriteLine ("  SEE ExamplePackages.cs FOR SOURCE CODE! Hit [Enter] to continue...");
			Console.WriteLine ("");
			Console.ReadLine();


			// ****************
			// Create a package
			// ****************
			/*
			Console.WriteLine ("");
			Console.WriteLine ("Create a package (subscription) with .create(...)");
			Console.WriteLine ("");

			// Create our customer object
			Package p = new Package ();
			p.customer_id = 1;

			LineItem li = new LineItem();
			li.item_id = 1;
			li.descrip = "Test description";

			p.line_items.Add(li);

			// Send it to ChargeOver
			Response resp1 = api.Create (p);

			Console.WriteLine ("Status back was: " + resp1.status + ", new package id is " + resp1.id);
			*/

			// ******************
			// Query for packages
			// ******************
			Console.WriteLine ("");
			Console.WriteLine ("Query packages (subscriptions) with .find(...)");
			Console.WriteLine ("");

			// Find all packages belonging to a specific customer
			List<string> query2 = new List<string> ();
			query2.Add ("customer_id:EQUALS:1");
			Response resp2 = api.Find(typeof(Package), query2);

			foreach (Package mypkg in resp2.list)
			{
				Console.WriteLine("Package ID: " + mypkg.package_id);
			}

		}
	}
}


