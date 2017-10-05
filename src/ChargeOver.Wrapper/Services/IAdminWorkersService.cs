using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IAdminWorkersService
	{
		/// <summary>
		/// Get a list of admin workers
		/// details: https://developer.chargeover.com/apidocs/rest/#list-admins
		/// </summary>
		IResponse<AdminWorkers> ListAdminWorkers();

		/// <summary>
		/// Query for admin workers
		/// details: https://developer.chargeover.com/apidocs/rest/#query-admins
		/// </summary>
		IResponse<AdminWorkers> QueryAdminWorkers(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);

		/// <summary>
		/// Get a specific admin worker
		/// details: https://developer.chargeover.com/apidocs/rest/#get-admin
		/// </summary>
		ICustomResponse<AdminWorkers> GetAdminWorker(int id);
	}
}
