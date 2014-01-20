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

		public ChargeOverAPI(string endpoint, string username, string password)
		{
			this.endpoint = endpoint;
			this.username = username;
			this.password = password;
		}

		/*
		public string mapToURI(string coMethod, Object obj, int id)
		{
			return this._mapToURI (coMethod, obj.GetType (), id);
		}

		public string mapToURI(string coMethod, Type type)
		{
			return this._mapToURI (coMethod, type);
		}
		*/

		public string getLastRequest()
		{
			return this.lastRequest;
		}

		public string getLastResponse()
		{
			return this.lastResponse;
		}

		protected string _mapToURI(string coMethod, Type type, int id = 0, List<string> query = null)
		{
			string uri = "";

			if (coMethod == ChargeOverAPI.MethodCreate) {
				id = 0;
			}

			if (id > 0) {
				uri = "/" + type.ToString().Replace("ChargeOver.", "").ToLower() + "/" + id;
			} else {
				uri = "/" + type.ToString().Replace("ChargeOver.", "").ToLower();
			}

			if (query != null) {

			}

			return uri;
		}

		public Response create(Object obj)
		{
			string uri = this._mapToURI (ChargeOverAPI.MethodCreate, obj.GetType ());

			return this._request (ChargeOverAPI.MethodCreate, uri, obj.GetType (), obj);
		}

		public Response find(Type type, List<string> query = null)
		{
			string uri = this._mapToURI (ChargeOverAPI.MethodFind, type, 0, query);

			return this._request (ChargeOverAPI.MethodFind, uri, type);
		}

		/*
		public Response request(string coMethod, Type type, List<string> query = null)
		{
			string uri = this.mapToURI (coMethod, type, query);

			return this._request (coMethod, uri);
		}
		*/

		/// <summary>
		/// 
		/// </summary>
		/// <param name="httpMethod">Http method.</param>
		/// <param name="uri">URI.</param>
		/// <param name="data">Data.</param>
		/*
		public Response request(string coMethod, Object obj, int id = 0)
		{
			string uri = this.mapToURI (coMethod, obj, 0);	

			return this._request (coMethod, uri, obj, id);
		}
		*/

		protected Response _request(string coMethod, string uri, Type type, Object obj = null, int id = 0)
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

			this.lastRequest = "";
			this.lastRequest += httpMethod + " " + this.endpoint + uri + " HTTP/1.0" + "\r\n";
			this.lastRequest += "Host: " + "@todo logging" + "\r\n";
			this.lastRequest += "\r\n";
			this.lastRequest += data;

			HttpWebResponse response = (HttpWebResponse)request.GetResponse();
			string httpResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();
			int httpCode = (int) response.StatusCode;

			// Parse the JSON response
			Response resp = JsonConvert.DeserializeObject<Response>(httpResponse);

			switch (coMethod) {
			case ChargeOverAPI.MethodCreate:
			case ChargeOverAPI.MethodModify:
					
				JObject ocm = JObject.Parse (httpResponse);
				resp.id = (int) ocm ["response"] ["id"];

				break;
			case ChargeOverAPI.MethodFind:

				JObject og = JObject.Parse (httpResponse);

				if (type == typeof(Customer))
				{
					List<Customer> list = JsonConvert.DeserializeObject < List < Customer >> (og ["response"].ToString ());
					resp.list = list.ConvertAll(i => i as Base);
					break;
				}



				break;
			case ChargeOverAPI.MethodGet:



				break;
			}
						
			return resp;
		}


	}



}

