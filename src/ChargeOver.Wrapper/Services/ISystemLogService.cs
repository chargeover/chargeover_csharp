using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ISystemLogService
	{
		/// <summary>
		/// Retrieve the system log
		/// details: https://developer.chargeover.com/apidocs/rest/#list-syslog
		/// </summary>
		IResponse<Log> ListSystemLogs();
	}
}
