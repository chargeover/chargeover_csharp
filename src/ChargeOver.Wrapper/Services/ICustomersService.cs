using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ICustomersService
	{
		/// <summary>
		/// Create a Customer
		/// details: https://developer.chargeover.com/apidocs/rest/#create-a-customer
		/// </summary>
		IIdentityResponse CreateCustomer(Models.Customer request);

		/// <summary>
		/// Update a Customer
		/// details: https://developer.chargeover.com/apidocs/rest/#update-a-customer
		/// </summary>
		IIdentityResponse UpdateCustomer(int id, UpdateCustomer request);

		/// <summary>
		/// Get a list of Customers
		/// details: https://developer.chargeover.com/apidocs/rest/#list-customers
		/// </summary>
		IResponse<CustomerResult> ListCustomers();

		/// <summary>
		/// Query for Customers
		/// details: https://developer.chargeover.com/apidocs/rest/#query-for-customers
		/// </summary>
		IResponse<CustomerResult> QueryCustomers(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);

		/// <summary>
		/// Delete a Customer
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-customer
		/// </summary>
		IResponse DeleteCustomer(int id);
	}
}
