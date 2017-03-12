using System;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	/// <summary>
	/// Customer service
	/// </summary>
	public sealed class CustomerService : ICustomerService
	{
		private readonly IChargeOverApiProvider _provider;

		/// <summary>
		/// Initialize customer service.
		/// </summary>
		/// <example><see cref="ArgumentNullException"/> if provider is null.</example>
		/// <param name="provider"></param>
		public CustomerService(IChargeOverApiProvider provider)
		{
			if (provider == null) throw new ArgumentNullException(nameof(provider));

			_provider = provider;
		}

		/// <summary>
		/// Initialize customer service with defaul Api Provider
		/// </summary>
		public CustomerService() : this(new ChargeOverApiProvider())
		{
		}

		/// <summary>
		/// Create customer.
		/// </summary>
		/// <param name="customer"></param>
		/// <returns></returns>
		public IResponse Create(CustomerEntity customer)
		{
			var api = _provider.Create();

			var result = api.Raw(ChargeOverAPI.MethodCreate, "/customer", null, customer);

			var resultObject = Newtonsoft.Json.JsonConvert.DeserializeObject<ChargeOverResponse>(result.Item2);

			return new Models.Response(resultObject);
		}

		public IResponse Update(CustomerEntity customer)
		{
			throw new System.NotImplementedException();
		}

		public IFindResponse<CustomerEntity> Query(params string[] queries)
		{
			throw new System.NotImplementedException();
		}

		public IResponse Delete(int id)
		{
			throw new System.NotImplementedException();
		}
	}
}