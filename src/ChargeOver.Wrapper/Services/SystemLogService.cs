using ChargeOver.Wrapper.Models;

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
		public IResponse<Log> ListSystemLogs()
		{
			return GetList<Log>("_log_system");
		}
	}
}
