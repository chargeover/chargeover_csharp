using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IUsagesService
	{
		IResponse Storing(Usage usage);
	}
}