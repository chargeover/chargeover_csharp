using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IRestHooksService
	{
		IResponse Subscribe(RestHook restHook);
		IResponse Unsubscribe(RestHook restHook);
	}
}