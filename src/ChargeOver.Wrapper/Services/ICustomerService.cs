using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	/// <summary>
	/// Customers service
	/// </summary>
	public interface ICustomerService
	{
		/// <summary>
		/// Create customer
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		IResponse Create(CustomerEntity customer);
		/// <summary>
		/// Update customer
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		IResponse Update(CustomerEntity customer);
		/// <summary>
		/// Query customers
		/// </summary>
		/// <param name="queries"></param>
		/// <returns></returns>
		IFindResponse<CustomerEntity> Query(params string[] queries);
		/// <summary>
		/// Delete customer by <param name="id"></param>
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		IResponse Delete(int id);
	}
}
