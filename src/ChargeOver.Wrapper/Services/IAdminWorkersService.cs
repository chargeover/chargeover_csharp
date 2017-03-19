using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IAdminWorkersService
	{
		/// <summary>
		/// Get a list of admin workers
		/// details: https://developer.chargeover.com/apidocs/rest/#list-admins
		/// </summary>
		IResponse<AdminWorkers> GetListAdminWorkers();

		/// <summary>
		/// Query for admin workers
		/// details: https://developer.chargeover.com/apidocs/rest/#query-admins
		/// </summary>
		IResponse QueryForAdminWorkers(params string[] queries);

		/// <summary>
		/// Get a specific admin worker
		/// details: https://developer.chargeover.com/apidocs/rest/#get-admin
		/// </summary>
		IResponse GetSpecificAdminWorker();
	}
}
