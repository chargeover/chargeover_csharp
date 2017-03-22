using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CustomersService : BaseService, ICustomersService
	{
		public CustomersService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		public CustomersService()
		{
		}

		/// <summary>
		/// Create a Customer
		/// details: https://developer.chargeover.com/apidocs/rest/#create-a-customer
		/// </summary>
		public IIdentityResponse CreateCustomer(Models.Customer request)
		{
			return Create("customer", request);
		}

		/// <summary>
		/// Update a Customer
		/// details: https://developer.chargeover.com/apidocs/rest/#update-a-customer
		/// </summary>
		public IIdentityResponse UpdateCustomer(int id, UpdateCustomer request)
		{
			var api = Provider.Create();

			var result = api.Raw("modify", "/customer/" + id, null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Get a list of Customers
		/// details: https://developer.chargeover.com/apidocs/rest/#list-customers
		/// </summary>
		public IResponse<CustomerResult> GetListCustomers()
		{
			return GetList<CustomerResult>("customer");
		}

		/// <summary>
		/// Query for Customers
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-customers
		/// </summary>
		public IResponse<CustomerResult> QueryForCustomers(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return Query<CustomerResult>("customer", queries, orders, offset, limit);
		}

		/// <summary>
		/// Delete a Customer
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-customer
		/// </summary>
		public IResponse DeleteCustomer(int id)
		{
			return Delete("customer", id);
		}
	}
}
