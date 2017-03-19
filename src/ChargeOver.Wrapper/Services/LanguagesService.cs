using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class LanguagesService : ILanguagesService
	{
		private readonly IChargeOverApiProvider _provider;

		public LanguagesService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// List languages
		/// details: https://developer.chargeover.com/apidocs/rest/#list-language
		/// </summary>
		public IResponse<Language> ListLanguages()
		{
			var api = _provider.Create();

			var result = api.Raw("get", "/language", null);
			
			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ChargeOverResponse<Language>>(result.Item2);
			
			return new Models.Response<Language>(resultObject);
		}
	}
}
