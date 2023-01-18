using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface ILanguagesService
	{
        /// <summary>
        /// List languages
        /// details: https://developer.chargeover.com/apidocs/rest/#list-language
        /// </summary>
        Task<IResponse<Language>> ListLanguages();
	}
}
