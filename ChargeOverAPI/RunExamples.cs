using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.IO;

using ChargeOver;

namespace RunExamples
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Get these from your ChargeOver configuration
			string endpoint = "http://macbookpro.chargeover.com:8888/chargeover/signup/api/v3.php";
			string username = "PtS50vVGLJrpEs1HmyqCi8MhjzBnc3DU";
			string password = "u1tfwimpXGg8bdWELMzPrHxVFZe9DKNa";

			ChargeOverAPI api = new ChargeOverAPI (endpoint, username, password);
			/*
			// Examples about INVOICES
			// 	http://chargeover.com/docs/rest-api.html#invoices
			ExampleInvoices ex1 = new ExampleInvoices (api);
			ex1.run ();

			// Examples about CUSTOMERS
			//	http://chargeover.com/docs/rest-api.html#customers
			ExampleCustomers ex2 = new ExampleCustomers (api);
			ex2.run ();

			// Examples about USERS/CONTACTS
			//	http://chargeover.com/docs/rest-api.html#users
			ExampleUsers ex3 = new ExampleUsers (api);
			ex3.run ();

			// Examples about ITEMS
			//	http://chargeover.com/docs/rest-api.html#items
			// @todo 

			// Examples about BILLING PACKAGES
			// 	http://chargeover.com/docs/rest-api.html#billing-packages
			ExampleBillingPackages ex5 = new ExampleBillingPackages(api);
			ex5.run();
			*/
			// Examples about TRANSACTIONS
			//	http://chargeover.com/docs/rest-api.html#transactions-payments-refunds-credits
			ExampleTransactions ex6 = new ExampleTransactions(api);
			ex6.run();

			// Examples about NOTES
			//	http://chargeover.com/docs/rest-api.html#notes
			// @todo 

			// Alternative ways to use the API
			ExampleTheHardWay ex99 = new ExampleTheHardWay ();
			ex99.run ();

			#if DEBUG
			Console.WriteLine ("\n\n\n");
			Console.WriteLine("All done! Press [Enter] to close...");
			Console.ReadLine();
			#endif
		}

	}
}
