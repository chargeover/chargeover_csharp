using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public sealed class TermsService : BaseService, ITermsService
	{
		public TermsService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public TermsService()
		{
		}

		/// <summary>
		/// List terms
		/// details: https://developer.chargeover.com/apidocs/rest/#list-terms
		/// </summary>
		public async Task<IResponse<Term>> ListTerms()
		{
			return await GetList<Term>("terms");
		}
	}
}
