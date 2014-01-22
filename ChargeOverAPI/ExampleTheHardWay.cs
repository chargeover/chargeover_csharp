using System;
using System.Net;
using System.Text;
using System.IO;

namespace ChargeOver
{
	public class ExampleTheHardWay
	{
		public ExampleTheHardWay ()
		{
		}

		public void run()
		{
			Console.WriteLine ("\n\n\n");
			Console.WriteLine ("EXAMPLES OF USING HttpWebRequest TO TALK TO CHARGEOVER");
			Console.WriteLine ("  SEE ExampleTheHardWay.cs FOR SOURCE CODE! Hit [Enter] to continue...");
			Console.WriteLine ("");
			Console.ReadLine();

			// ******************************
			// Sending raw JSON to ChargeOver
			// ******************************
			Console.WriteLine ("");
			Console.WriteLine ("Sending raw JSON to ChargeOver");
			Console.WriteLine ("");

			// You can find these within ChargeOver
			string endpoint = "http://dev.chargeover.com/signup/api/v3.php";
			string username = "7sutWFEO2zKVYIGmZMJ3Nij5hfLxDRb8";
			string password = "9vCJbmdZKSieVchyrRItFQw8MBN4lOH3";

			// Our JSON string 
			string data = @"{
						    ""company"": ""Test Company Name"",
						    ""bill_addr1"": ""16 Dog Lane"",
						    ""bill_addr2"": ""Suite D"",
						    ""bill_city"": ""Storrs"",
						    ""bill_state"": ""CT"",
						    ""email"": ""keith@chargeover.com""
						}";

			string httpMethod = "POST";

			HttpWebRequest request = (HttpWebRequest) WebRequest.Create(endpoint + "/customer"); 

			request.KeepAlive = false;
			request.ProtocolVersion = HttpVersion.Version10;
			request.Method = httpMethod;

			byte[] postBytes = Encoding.ASCII.GetBytes(data);

			request.ContentType = "application/json";
			request.ContentLength = postBytes.Length;

			request.Credentials = new NetworkCredential(username, password);

			Stream requestStream = request.GetRequestStream();

			requestStream.Write(postBytes, 0, postBytes.Length);
			requestStream.Close();

			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			string httpResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();

			Console.WriteLine ("Response from ChargeOver API: " + httpResponse);
		}
	}
}

