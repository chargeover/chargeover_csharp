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
		public const string MethodBulk = "bulk";

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

		public string GetLastRequest()
		{
			return this.lastRequest;
		}

		public string GetLastResponse()
		{
			return this.lastResponse;
		}

		public string GetLastError()
		{
			return this.lastError;
		}

		protected string _mapToURI(string coMethod, Type type, int id = 0, List<string> query = null, List<string> sort = null, int offset = 0, int limit = 10)
		{
			string uri = "";

			if (coMethod == ChargeOverAPI.MethodBulk) {
				return "/_bulk";
			}

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

			uri += "?_dummy=1";

			if (query != null && 
			    query.Count > 0) {

				uri += "&where=" + String.Join (",", query);
			}

			if (sort != null && 
			    sort.Count > 0) {

				uri += "&order=" + String.Join (",", sort);
			}

			if (offset > 0) {
				uri += "&offset=" + offset;
			}

			if (limit > 0) {
				uri += "&limit=" + limit;
			}

			return uri;
		}

		public Response Bulk(List<Bulk> bulk)
		{
			string uri = this._mapToURI (ChargeOverAPI.MethodBulk, null);

			return this.Request (ChargeOverAPI.MethodBulk, uri, null, null, 0, bulk);
		}

		public Response Create(Object obj)
		{
			string uri = this._mapToURI (ChargeOverAPI.MethodCreate, obj.GetType ());

			return this.Request (ChargeOverAPI.MethodCreate, uri, obj.GetType (), obj);
		}

		public Response Modify(int id, Object obj)
		{
			string uri = this._mapToURI (ChargeOverAPI.MethodModify, obj.GetType (), id);

			return this.Request (ChargeOverAPI.MethodModify, uri, obj.GetType(), obj);
		}

		public Response Find(Type type, List<string> query = null, List<string> sort = null, int offset = 0, int limit = 10)
		{
			string uri = this._mapToURI (ChargeOverAPI.MethodFind, type, 0, query, sort, offset, limit);

			return this.Request (ChargeOverAPI.MethodFind, uri, type);
		}

		public Response Get(Type type, int id)
		{
			string uri = this._mapToURI (ChargeOverAPI.MethodGet, type, id);

			return this.Request (ChargeOverAPI.MethodGet, uri, type, null, id);
		}

		protected Response Request(string coMethod, string uri, Type type, Object obj = null, int id = 0, List <Bulk> bulk = null)
		{
			try
			{
				Tuple<int, string> http = this.Raw (coMethod, uri, type, obj, id, bulk);
			
				// Parse the JSON response
				Response resp = JsonConvert.DeserializeObject<Response>(http.Item2);

				switch (coMethod) {
				case ChargeOverAPI.MethodCreate:

					JObject oc = JObject.Parse (http.Item2);
					resp.id = (int) oc ["response"] ["id"];

					break;
				case ChargeOverAPI.MethodModify:
					
					//JObject om = JObject.Parse (http.Item2);

					
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
					} else if (type == typeof(Transaction)) {
						List<Transaction> list = JsonConvert.DeserializeObject < List < Transaction >> (objf ["response"].ToString ());
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
					} else if (type == typeof(Transaction)) {
						Transaction trans = JsonConvert.DeserializeObject<Transaction>(objg["response"].ToString ());
						resp.obj = (Transaction) trans;
					}

					break;
				case ChargeOverAPI.MethodBulk:

					JObject objb = JObject.Parse(http.Item2);

					List<Response> listb = JsonConvert.DeserializeObject<List<Response>>(objb["response"]["_bulk"].ToString());
					resp.bulk = listb;

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
						string resp = new StreamReader (response.GetResponseStream ()).ReadToEnd ();

						try 
						{
							// Can we decode it? 
							Response exresp = JsonConvert.DeserializeObject<Response>(resp);

							msg = "Remote server returned [" + exresp.code + ": " + exresp.message + "]";
						}
						catch (Exception ex2)
						{
							msg = "Remote server returned non-JSON response: " + resp;
						}
					}
				}


				throw new COException(msg, ex);
			}
		}

		public Tuple<int, string> Raw(string coMethod, string uri, Type type, Object obj = null, int id = 0, List<Bulk> bulk = null)
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
			case ChargeOverAPI.MethodBulk:
				httpMethod = "POST";
				data = JsonConvert.SerializeObject(bulk);
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

