using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ILanguagesService
	{
		IFindResponse<Language> Retrieve();
	}
}