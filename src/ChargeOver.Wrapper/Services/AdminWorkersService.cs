using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class AdminWorkersService : BaseService, IAdminWorkersService
	{
		public AdminWorkersService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public AdminWorkersService()
		{
		}

		/// <summary>
		/// Get a list of admin workers
		/// details: https://developer.chargeover.com/apidocs/rest/#list-admins
		/// </summary>
		public IResponse<AdminWorkers> ListAdminWorkers()
		{
			return GetList<AdminWorkers>("admin");
		}

		/// <summary>
		/// Query for admin workers
		/// details: https://developer.chargeover.com/apidocs/rest/#query-admins
		/// </summary>
		public IResponse<AdminWorkers> QueryAdminWorkers(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return Query<AdminWorkers>("admin", queries, orders, offset, limit);
		}

		/// <summary>
		/// Get a specific admin worker
		/// details: https://developer.chargeover.com/apidocs/rest/#get-admin
		/// </summary>
		public ICustomResponse<AdminWorkers> GetAdminWorker(int id)
		{
			return GetCustom<AdminWorkers>("admin", id);
		}
	}
}
