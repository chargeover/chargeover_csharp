using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface ICustomersService
	{
		/// <summary>
		/// Create a Customer
		/// details: https://developer.chargeover.com/apidocs/rest/#create-a-customer
		/// </summary>
		Task<IIdentityResponse> CreateCustomer(Models.Customer request);

        /// <summary>
        /// Update a Customer
        /// details: https://developer.chargeover.com/apidocs/rest/#update-a-customer
        /// </summary>
        Task<IIdentityResponse> UpdateCustomer(int id, UpdateCustomer request);

        /// <summary>
        /// Get a list of Customers
        /// details: https://developer.chargeover.com/apidocs/rest/#list-customers
        /// </summary>
        Task<IResponse<CustomerResult>> ListCustomers();

        /// <summary>
        /// Query for Customers
        /// details: https://developer.chargeover.com/apidocs/rest/#query-for-customers
        /// </summary>
        Task<IResponse<CustomerResult>> QueryCustomers(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);

        /// <summary>
        /// Delete a Customer
        /// details: https://developer.chargeover.com/apidocs/rest/#delete-a-customer
        /// </summary>
        Task<IResponse> DeleteCustomer(int id);
	}
}
