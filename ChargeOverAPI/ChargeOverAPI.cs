using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.IO;

namespace ChargeOver
{
	public class ChargeOverAPI
	{
		public const string MethodCreate = "create";
		public const string MethodFind = "find";
		public const string MethodDelete = "delete";
		public const string MethodModify = "modify";
		public const string MethodAction = "action";
		public const string MethodGet = "get";

		protected string endpoint;
		protected string username;
		protected string password;

		protected string lastRequest = "";
		protected string lastResponse = "";
		protected string lastError = "";

		public ChargeOverAPI(string endpoint, string username, string password)
		{
			this.endpoint = endpoint;
			this.username = username;
			this.password = password;
		}

		public string getLastRequest()
		{
			return this.lastRequest;
		}

		public string getLastResponse()
		{
			return this.lastResponse;
		}

		public string getLastError()
		{
			return this.lastError;
		}

		protected string _mapToURI(string coMethod, Type type, int id = 0, List<string> query = null)
		{
			string uri = "";

			if (coMethod == ChargeOverAPI.MethodCreate) {
				id = 0;
			}

			string resource = type.ToString ().Replace ("ChargeOver.", "").ToLower ();
			if (resource == "billingpackage") {
				resource = "billing_package";
			}

			if (id > 0) {
				uri = "/" + resource + "/" + id;
			} else {
				uri = "/" + resource;
			}

			if (query != null && 
			    query.Count > 0) {

				uri += "?where=" + String.Join ("&", query);
			}

			return uri;
		}

		public Response create(Object obj)
		{
			string uri = this._mapToURI (ChargeOverAPI.MethodCreate, obj.GetType ());

			return this.request (ChargeOverAPI.MethodCreate, uri, obj.GetType (), obj);
		}

		public Response find(Type type, List<string> query = null)
		{
			string uri = this._mapToURI (ChargeOverAPI.MethodFind, type, 0, query);

			return this.request (ChargeOverAPI.MethodFind, uri, type);
		}

		public Response get(Type type, int id)
		{
			string uri = this._mapToURI (ChargeOverAPI.MethodGet, type, id);

			return this.request (ChargeOverAPI.MethodGet, uri, type, null, id);
		}

		protected Response request(string coMethod, string uri, Type type, Object obj = null, int id = 0)
		{
			try
			{
				Tuple<int, string> http = this.raw (coMethod, uri, type, obj, id);
			
				// Parse the JSON response
				Response resp = JsonConvert.DeserializeObject<Response>(http.Item2);

				switch (coMethod) {
					case ChargeOverAPI.MethodCreate:
					case ChargeOverAPI.MethodModify:

						JObject ocm = JObject.Parse (http.Item2);
						resp.id = (int) ocm ["response"] ["id"];

						break;
				case ChargeOverAPI.MethodFind:

					JObject objf = JObject.Parse (http.Item2);

					if (type == typeof(Customer)) {
						List<Customer> list = JsonConvert.DeserializeObject < List < Customer >> (objf ["response"].ToString ());
						resp.list = list.ConvertAll (i => i as Base);
					} else if (type == typeof(User)) {
						List<User> list = JsonConvert.DeserializeObject < List < User >> (objf ["response"].ToString ());
						resp.list = list.ConvertAll (i => i as Base);
					} else if (type == typeof(Invoice)) {
						List<Invoice> list = JsonConvert.DeserializeObject < List < Invoice >> (objf ["response"].ToString ());
						resp.list = list.ConvertAll (i => i as Base);
					}

					break;
				case ChargeOverAPI.MethodGet:

					JObject objg = JObject.Parse (http.Item2);

					if (type == typeof(Customer)) {
						Customer cust = JsonConvert.DeserializeObject<Customer> (objg ["response"].ToString ());
						resp.obj = (Customer)cust;
					} else if (type == typeof(User)) {
						User user = JsonConvert.DeserializeObject<User> (objg ["response"].ToString ());
						resp.obj = (User)user;
					} else if (type == typeof(Invoice)) {
						Invoice inv = JsonConvert.DeserializeObject<Invoice>(objg["response"].ToString ());
						resp.obj = (Invoice) inv;
					}

					break;
				}

				return resp;
			}
			catch (WebException ex) {

				string msg = "An exception occurred when communicating with the remote server.";

				if (ex.Status == WebExceptionStatus.ProtocolError)
				{
					var response = ex.Response as HttpWebResponse;
					if (response != null)
					{
						// Can we decode it? 
						Response exresp = JsonConvert.DeserializeObject<Response>(new StreamReader(response.GetResponseStream()).ReadToEnd());

						msg = "Remote server returned [" + exresp.code + ": " + exresp.message + "]";
					}
				}

				throw new COException(msg, ex);
			}
		}

		public Tuple<int, string> raw(string coMethod, string uri, Type type, Object obj = null, int id = 0)
		{
			string httpMethod = "GET";

			string data = "";

			// Find out correct HTTP method 
			switch (coMethod) {
			case ChargeOverAPI.MethodCreate:
				httpMethod = "POST";
				data = JsonConvert.SerializeObject(obj);
				break;
			case ChargeOverAPI.MethodAction:
				httpMethod = "POST";
				break;
			case ChargeOverAPI.MethodDelete:
				httpMethod = "DELETE";
				break;
			case ChargeOverAPI.MethodFind:
			case ChargeOverAPI.MethodGet:
				httpMethod = "GET";
				break;
			case ChargeOverAPI.MethodModify:
				httpMethod = "PUT";
				data = JsonConvert.SerializeObject(obj);
				break;
			}

			this.lastRequest = "";
			this.lastRequest += httpMethod + " " + this.endpoint + uri + " HTTP/1.0" + "\r\n";
			this.lastRequest += "Host: " + "@todo logging" + "\r\n";
			this.lastRequest += "\r\n";
			this.lastRequest += data;

			// Create request
			HttpWebRequest request = (HttpWebRequest) WebRequest.Create(this.endpoint + uri); 

			request.KeepAlive = false;
			request.ProtocolVersion = HttpVersion.Version10;
			request.Method = httpMethod;

			byte[] postBytes = Encoding.ASCII.GetBytes(data);

			request.ContentType = "application/json";
			request.ContentLength = postBytes.Length;

			request.Credentials = new NetworkCredential(this.username, this.password);

			if (postBytes.Length > 0) {

				Stream requestStream = request.GetRequestStream();

				// Send request 
				requestStream.Write (postBytes, 0, postBytes.Length);
				requestStream.Close ();
			}

			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			string httpResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();
			int httpCode = (int) response.StatusCode;

			this.lastResponse = httpResponse;


			return new Tuple<int, string>(httpCode, httpResponse);
		}


	}



}

