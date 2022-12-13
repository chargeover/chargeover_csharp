using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class LanguagesService : BaseService, ILanguagesService
	{
		public LanguagesService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public LanguagesService()
		{
		}

		/// <summary>
		/// List languages
		/// details: https://developer.chargeover.com/apidocs/rest/#list-language
		/// </summary>
		public async Task<IResponse<Language>> ListLanguages()
		{
			return await GetList<Language>("/language");
		}
	}
}
