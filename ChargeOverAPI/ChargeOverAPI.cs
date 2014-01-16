using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.IO;

namespace ChargeOverAPI
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

		public ChargeOverAPI(string endpoint, string username, string password)
		{
			this.endpoint = endpoint;
			this.username = username;
			this.password = password;
		}

		public string mapToURI(string method, int id, Object obj)
		{
			string objType = obj.GetType ().ToString().Replace("ChargeOverAPI.", "").ToLower();

			if (method == ChargeOverAPI.MethodCreate) {
				id = 0;
			}

			if (id > 0) {
				return "/" + objType + "/" + id;
			} else {
				return "/" + objType;
			}
		}

		public Response create(Object obj)
		{
			return this.request (ChargeOverAPI.MethodCreate, obj);
		}

		public Response request(string coMethod, Type coType, List<string> query = null)
		{
			return null;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="httpMethod">Http method.</param>
		/// <param name="uri">URI.</param>
		/// <param name="data">Data.</param>
		public Response request(string coMethod, Object obj, int id = 0)
		{
			string httpMethod = "GET";

			string uri = this.mapToURI (coMethod, 0, obj);
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

			Stream requestStream = request.GetRequestStream();

			// Send request 
			requestStream.Write(postBytes, 0, postBytes.Length);
			requestStream.Close();

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
				resp.list = JsonConvert.DeserializeObject < List <Object>> (og ["response"].ToString ());

				break;
			case ChargeOverAPI.MethodGet:



				break;
			}
						
			return resp;
		}

		/** 
		public Response find(string type, List<string> query = null)
		{
			if (query == null)
			{
				query = new List<String> ();
			}


		}
		*/
	}

	public class Response
	{
		public int code;
		public string status;
		public string message;
		public List<Object> list;
		public Object obj;
		public int id;

		public Response(int code, string status, string message)
		{
			this.code = code;
			this.status = status;
			this.message = message;
		}

		public void setList(List<Object> list)
		{
			this.list = list;
		}

		public void setObj(Object obj)
		{
			this.obj = obj;
		}

		public void setId(int id)
		{
			this.id = id;
		}
	}

	public class Object
	{

	}

	public class Customer : Object
	{
		public string company = "";

		public string bill_addr1 = "";
		public string bill_addr2 = "";
		public string bill_addr3 = "";
		public string bill_city = "";
		public string bill_state = "";
		public string bill_postcode = "";
		public string bill_country = "";

		public string external_key = "";
	}
}

