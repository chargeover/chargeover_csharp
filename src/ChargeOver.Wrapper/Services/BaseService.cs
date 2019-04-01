using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public abstract class BaseService
	{
		private readonly IChargeOverAPIConfiguration _config;

		protected string PostRequest => "create";

		protected BaseService(IChargeOverAPIConfiguration config)
		{
			if (config == null) throw new ArgumentNullException(nameof(config));

			_config = config;
		}

		protected BaseService() : this(new ConfigurationManagerChargeOverApiConfiguration()) { }

		protected IIdentityResponse Create<T>(string endpoint, T request)
		{
			return new IdentityResponse(Request<T, IdentityChargeOverResponse>(MethodType.POST, $"/{endpoint}", request));
		}

		protected IResponse Delete(string endpoint, int id)
		{
			return new Response(Request<object, ChargeOverResponse>(MethodType.DELETE, $"/{endpoint}/" + id, null));
		}

		protected IResponse<T> GetList<T>(string endpoint)
		{
			return new Response<T>(Request<object, ChargeOverResponse<T>>(MethodType.GET, "/" + endpoint, null));
		}

		protected ICustomResponse<T> GetCustom<T>(string endpoint, int id)
		{
			return new CustomResponse<T>(Request<object, CustomChargeOverResponse<T>>(MethodType.GET, $"/{endpoint}/" + id, null));
		}

		protected ICustomResponse<bool> GetCustomBool<T>(string endpoint, T requeset)
		{
			return new CustomResponse<bool>(Request<T, CustomChargeOverResponse<bool>>(MethodType.POST, endpoint, requeset));
		}

		protected IResponse<T> Query<T>(string endpoint, string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			var queriesData = Data(queries, "where");
			var ordersData = Data(orders, "order");

			var result = Request<object, ChargeOverResponse<T>>(MethodType.GET, $"/{endpoint}?_dummy=1&limit={limit}&offset={offset}{queriesData}{ordersData}", null);

			return new Response<T>(result);
		}

		private string Data(string[] arguments, string name)
		{
			arguments = arguments ?? new string[0];
			var result = string.Empty;
			if (arguments.Any())
			{
				result = "&" + name + "=";
				result += string.Join(",", arguments);
			}

			return result;
		}

		protected TResponse Request<T, TResponse>(MethodType method, string uri, T request)
		{
			string httpMethod = method.ToString(), data = string.Empty;

			if (request != null)
				data = JsonConvert.SerializeObject(request, new JsonSerializerSettings
				{
					NullValueHandling = NullValueHandling.Ignore
				});

			var webRequest = (HttpWebRequest)WebRequest.Create(_config.Endpoint + uri);

			webRequest.KeepAlive = false;
			webRequest.ProtocolVersion = HttpVersion.Version10;
			webRequest.Method = httpMethod;

			byte[] postBytes = Encoding.ASCII.GetBytes(data);

			webRequest.ContentType = "application/json";
			webRequest.ContentLength = postBytes.Length;
            //webRequest.Credentials = new NetworkCredential(_config.Username, _config.Password);

            string credentialsFormatted = string.Format("{0}:{1}", _config.Username, _config.Password);
            byte[] credentialBytes = Encoding.ASCII.GetBytes(credentialsFormatted);
            string basicCredentials = Convert.ToBase64String(credentialBytes);

            webRequest.Headers["Authorization"] = "Basic " + basicCredentials;

            if (postBytes.Length > 0)
			{
				using (Stream requestStream = webRequest.GetRequestStream())
				{
					requestStream.Write(postBytes, 0, postBytes.Length);
					requestStream.Close();
				}
			}

			HttpWebResponse response;

			response = (HttpWebResponse)webRequest.GetResponse();

			string httpResponse = new StreamReader(response.GetResponseStream()).ReadToEnd();

			var result = JsonConvert.DeserializeObject<TResponse>(httpResponse);

			return result;
		}

		#region sealed members

		public override sealed bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		public override sealed int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override sealed string ToString()
		{
			return base.ToString();
		}

		#endregion sealed members

		protected enum MethodType
		{
			POST,
			GET,
			DELETE,
			PUT
		}
	}
}