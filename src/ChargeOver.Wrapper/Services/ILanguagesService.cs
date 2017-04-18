using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface ILanguagesService
	{
		/// <summary>
		/// List languages
		/// details: https://developer.chargeover.com/apidocs/rest/#list-language
		/// </summary>
		IResponse<Language> ListLanguages();
	}
}
