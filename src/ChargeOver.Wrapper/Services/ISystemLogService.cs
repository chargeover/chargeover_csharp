using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface ISystemLogService
	{
		/// <summary>
		/// Retrieve the system log
		/// details: https://developer.chargeover.com/apidocs/rest/#list-syslog
		/// </summary>
		Task<IResponse<Log>> ListSystemLogs();
	}
}
