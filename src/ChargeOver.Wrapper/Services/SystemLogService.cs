using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class SystemLogService : BaseService, ISystemLogService
	{
		public SystemLogService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public SystemLogService()
		{
		}

		/// <summary>
		/// Retrieve the system log
		/// details: https://developer.chargeover.com/apidocs/rest/#list-syslog
		/// </summary>
		public async Task<IResponse<Log>> ListSystemLogs()
		{
			return await GetList<Log>("_log_system");
		}
	}
}
