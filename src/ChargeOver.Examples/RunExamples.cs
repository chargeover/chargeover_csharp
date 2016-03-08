using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.IO;

using ChargeOver;

namespace ChargeOver.Examples
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			// Get these from your ChargeOver configuration
			string endpoint = "http://dev.chargeover.com/api/v3";

			// HTTP basic auth
			// string username = "1EkcsIZRUJwdWmyT6lzqa4Y0pXvgNKCB";
			// string username = "IZah9p134R7OLtHl26BCmFXWUjVQxsNM";
			//string auth = ChargeOverAPI.AuthHttpBasic;

			// Signature auth  (you will have a different set of API tokens for signature auth)
			string username = "78Tvnla2XsSQOtyzCfxqG1uRZ3ejgpLo";
			string password = "dESOhlc56BfXVko27w9MsvDHui8nWeAI";
			string auth = ChargeOverAPI.AuthSignatureV1;

			ChargeOverAPI api = new ChargeOverAPI (endpoint, username, password, auth);

			/*
			// Examples about INVOICES
			// 	https://developer.chargeover.com/apidocs/rest/#invoices
			ExampleInvoices ex1 = new ExampleInvoices (api);
			ex1.run ();

			// Examples about CUSTOMERS
			//	https://developer.chargeover.com/apidocs/rest/#customers
			ExampleCustomers ex2 = new ExampleCustomers (api);
			ex2.run ();

			// Examples about USERS/CONTACTS
			//	https://developer.chargeover.com/apidocs/rest/#users
			ExampleUsers ex3 = new ExampleUsers (api);
			ex3.run ();

			// Examples about ITEMS
			//	https://developer.chargeover.com/apidocs/rest/#items
			// @todo 
			*/

			// Examples about PACKAGES
			// 	https://developer.chargeover.com/apidocs/rest/#recurring-packages
			ExamplePackages ex5 = new ExamplePackages(api);
			ex5.run();

			/*
			// Examples about TRANSACTIONS
			//	https://developer.chargeover.com/apidocs/rest/#transactions
			ExampleTransactions ex6 = new ExampleTransactions(api);
			ex6.run();

			// Examples about NOTES
			//	https://developer.chargeover.com/apidocs/rest/#notes
			// @todo 

			// Alternative ways to use the API
			ExampleTheHardWay ex99 = new ExampleTheHardWay ();
			ex99.run ();

			// Updating a CUSTOMER
			ExampleCustomerUpdate ex7 = new ExampleCustomerUpdate (api);
			ex7.run ();
			*/

			/*
			// Bulk requests
			//  https://developer.chargeover.com/apidocs/rest/#bulk-batch-requests
			ExampleBulk ex8 = new ExampleBulk (api);
			ex8.run ();
			*/

			/*
			// Signature auth example
			ExampleAuthSignature ex9 = new ExampleAuthSignature (api);
			ex9.run ();
			*/

			#if DEBUG
			Console.WriteLine ("\n\n\n");
			Console.WriteLine("All done! Press [Enter] to close...");
			Console.ReadLine();
			#endif
		}

	}
}
