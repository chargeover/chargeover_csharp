using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
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

		protected async Task<IIdentityResponse> Create<T>(string endpoint, T request)
		{
			return new IdentityResponse(await Request<T, IdentityChargeOverResponse>(MethodType.POST, $"/{endpoint}", request));
		}

		protected async Task<IResponse> Delete(string endpoint, int id)
		{
			return new Response(await Request<object, ChargeOverResponse>(MethodType.DELETE, $"/{endpoint}/" + id, null));
		}

		protected async Task<IResponse<T>> GetList<T>(string endpoint)
		{
			return new Response<T>(await Request<object, ChargeOverResponse<T>>(MethodType.GET, "/" + endpoint, null));
		}

		protected async Task<ICustomResponse<T>> GetCustom<T>(string endpoint, int id)
		{
			return new CustomResponse<T>(await Request<object, CustomChargeOverResponse<T>>(MethodType.GET, $"/{endpoint}/" + id, null));
		}

		protected async Task<ICustomResponse<bool>> GetCustomBool<T>(string endpoint, T requeset)
		{
			return new CustomResponse<bool>(await Request<T, CustomChargeOverResponse<bool>>(MethodType.POST, endpoint, requeset));
		}

		protected async Task<IResponse<T>> Query<T>(string endpoint, string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			var queriesData = Data(queries, "where");
			var ordersData = Data(orders, "order");

			var result = await Request<object, ChargeOverResponse<T>>(MethodType.GET, $"/{endpoint}?_dummy=1&limit={limit}&offset={offset}{queriesData}{ordersData}", null);

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

		protected async Task<TResponse> Request<T, TResponse>(MethodType method, string uri, T request)
		{
            string httpMethod = method.ToString(), data = string.Empty;

            if (request != null)
                data = JsonConvert.SerializeObject(request, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

            var httpClient = new HttpClient();
            var requestMessage = new HttpRequestMessage
            {
                RequestUri = new Uri(_config.Endpoint + uri),
                Method = new HttpMethod(httpMethod),
                Content = new StringContent(data, Encoding.UTF8, "application/json")
            };

            string credentialsFormatted = string.Format("{0}:{1}", _config.Username, _config.Password);
            byte[] credentialBytes = Encoding.ASCII.GetBytes(credentialsFormatted);
            string basicCredentials = Convert.ToBase64String(credentialBytes);
            requestMessage.Headers.Add("Authorization", "Basic " + basicCredentials);
            var result = JsonConvert.DeserializeObject<TResponse>("{}");

            var response = await httpClient.SendAsync(requestMessage);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<TResponse>(content);
            }
            else
            {
                string error = await response.Content.ReadAsStringAsync();
                throw new Exception(error);
            }

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