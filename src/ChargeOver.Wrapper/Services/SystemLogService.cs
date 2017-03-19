using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class SystemLogService : ISystemLogService
	{
		private readonly IChargeOverApiProvider _provider;

		public SystemLogService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Retrieve the system log
		/// details: https://developer.chargeover.com/apidocs/rest/#list-syslog
		/// </summary>
		public IResponse RetrieveTheSystemLog()
		{
			var api = _provider.Create();

			var result = api.Raw("", "/_log_system", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);
			
			return new Models.IdentityResponse(resultObject);
		}
	}
}
