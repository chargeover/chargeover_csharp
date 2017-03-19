using System;
using System.Linq;
using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public abstract class BaseService
	{
		private readonly IChargeOverApiProvider _provider;
		protected IChargeOverApiProvider Provider => _provider;

		protected string PostRequest => "create";

		protected BaseService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		protected IIdentityResponse Create<T>(string endpoint, T request)
		{
			var api = Provider.Create();

			var result = api.Raw(PostRequest, $"/{endpoint} ", null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		protected IResponse Delete(string endpoint, int id)
		{
			var api = Provider.Create();

			var result = api.Raw("delete", $"/{endpoint}/" + id, null);

			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ChargeOverResponse>(result.Item2);

			return new Models.Response(resultObject);
		}

		protected IResponse<T> GetList<T>(string endpoint)
		{
			var api = Provider.Create();

			var result = api.Raw("get", "/" + endpoint, null);

			var resultObject = JsonConvert.DeserializeObject<ChargeOverResponse<T>>(result.Item2);

			return new Response<T>(resultObject);
		}

		protected ICustomResponse<T> GetCustom<T>(string endpint, int id)
		{
			var api = Provider.Create();

			var result = api.Raw("get", $"/{endpint}/" + id, null);

			var resultObject = JsonConvert.DeserializeObject<CustomChargeOverResponse<T>>(result.Item2);

			return new CustomResponse<T>(resultObject);
		}

		protected IResponse<T> Query<T>(string endpoint, string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			var api = _provider.Create();

			var queriesData = Data(queries, "where");
			var ordersData = Data(orders, "order");

			var result = api.Raw("find", $"/{endpoint}?_dummy=1&limit={limit}&offset={offset}{queriesData}{ordersData}", null);

			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ChargeOverResponse<T>>(result.Item2);

			return new Response<T>(resultObject);
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
	}
}