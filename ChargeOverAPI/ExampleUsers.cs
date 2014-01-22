using System;
using System.Collections.Generic;

namespace ChargeOver
{
	public class ExampleUsers
	{
		private ChargeOverAPI api;

		public ExampleUsers (ChargeOverAPI api)
		{
			this.api = api;
		}

		public void run()
		{
			Console.WriteLine ("\n\n\n");
			Console.WriteLine ("EXAMPLES OF DOING STUFF WITH USERS/CONTACTS");
			Console.WriteLine ("  SEE ExampleUsers.cs FOR SOURCE CODE! Hit [Enter] to continue...");
			Console.WriteLine ("");
			Console.ReadLine();

			// *************
			// Create a user
			// *************
			Console.WriteLine ("");
			Console.WriteLine ("Create a user/contact with .create(...)");
			Console.WriteLine ("");

			User user = new User ();
			user.name = "Keith R Palmer";
			user.email = "keith@chargeover.com";
			user.customer_id = 16340;

			// Send it to ChargeOver
			Response resp1 = api.create (user);

			Console.WriteLine ("Status back was: " + resp1.status + ", new user/contact id is " + resp1.id);


			// ***************
			// Query for users
			// ***************
			Console.WriteLine ("");
			Console.WriteLine ("Query for users with .find(...)");
			Console.WriteLine ("");

			List<string> query2 = new List<string> ();
			Response resp2 = api.find(typeof(User), query2);

			foreach (User myuser in resp2.list)
			{
				Console.WriteLine(myuser.user_id + " => " + myuser.name);
			}
		}
	}
}

