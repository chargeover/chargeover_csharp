using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class CustomersService : BaseService, ICustomersService
	{
		public CustomersService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public CustomersService()
		{
		}

		/// <summary>
		/// Create a Customer
		/// details: https://developer.chargeover.com/apidocs/rest/#create-a-customer
		/// </summary>
		public async Task<IIdentityResponse> CreateCustomer(Customer request)
		{
			return await Create("customer", request);
		}

		/// <summary>
		/// Update a Customer
		/// details: https://developer.chargeover.com/apidocs/rest/#update-a-customer
		/// </summary>
		public async Task<IIdentityResponse> UpdateCustomer(int id, UpdateCustomer request)
		{
			return new IdentityResponse(await Request<UpdateCustomer, IdentityChargeOverResponse>(MethodType.PUT, "/customer/" + id, request));
		}

		/// <summary>
		/// Get a list of Customers
		/// details: https://developer.chargeover.com/apidocs/rest/#list-customers
		/// </summary>
		public async Task<IResponse<CustomerResult>> ListCustomers()
		{
			return await GetList<CustomerResult>("customer");
		}

		/// <summary>
		/// Query for Customers
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-customers
		/// </summary>
		public async Task<IResponse<CustomerResult>> QueryCustomers(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return await Query<CustomerResult>("customer", queries, orders, offset, limit);
		}

		/// <summary>
		/// Delete a Customer
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-customer
		/// </summary>
		public async Task<IResponse>DeleteCustomer(int id)
		{
			return await Delete("customer", id);
		}
	}
}
