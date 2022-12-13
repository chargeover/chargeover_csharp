using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

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
		public async Task<IResponse<AdminWorkers>> ListAdminWorkers()
		{
			return await GetList<AdminWorkers>("admin");
		}

		/// <summary>
		/// Query for admin workers
		/// details: https://developer.chargeover.com/apidocs/rest/#query-admins
		/// </summary>
		public async Task<IResponse<AdminWorkers>> QueryAdminWorkers(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return await Query<AdminWorkers>("admin", queries, orders, offset, limit);
		}

		/// <summary>
		/// Get a specific admin worker
		/// details: https://developer.chargeover.com/apidocs/rest/#get-admin
		/// </summary>
		public async Task<ICustomResponse<AdminWorkers>> GetAdminWorker(int id)
		{
			return await GetCustom<AdminWorkers>("admin", id);
		}
	}
}
