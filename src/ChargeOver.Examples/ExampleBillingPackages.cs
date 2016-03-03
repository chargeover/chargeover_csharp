using System;

namespace ChargeOver.Examples
{
	public class ExampleBillingPackages
	{
		private ChargeOverAPI api;
	
		public ExampleBillingPackages(ChargeOverAPI api)
		{
			this.api = api;
		}
		
		public void run()
		{
			Console.WriteLine ("\n\n\n");
			Console.WriteLine ("EXAMPLES OF DOING STUFF WITH BILLING PACKAGES");
			Console.WriteLine ("  SEE ExampleBillingPackages.cs FOR SOURCE CODE! Hit [Enter] to continue...");
			Console.WriteLine ("");
			Console.ReadLine();


			// ************************
			// Create a billing package
			// ************************
			Console.WriteLine ("");
			Console.WriteLine ("Create a billing package with .create(...)");
			Console.WriteLine ("");

			// Create our customer object
			BillingPackage bp = new BillingPackage ();
			bp.customer_id = 16340;
			
			LineItem li = new LineItem();
			li.item_id = 185;
			li.descrip = "Test description";
			
			bp.line_items.Add(li);
			
			// Send it to ChargeOver
			Response resp1 = api.Create (bp);

			Console.WriteLine ("Status back was: " + resp1.status + ", new package id is " + resp1.id);


		}
	}
}


