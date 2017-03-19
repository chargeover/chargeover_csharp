using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class ItemsService : BaseService, IItemsService
	{
		public ItemsService(IChargeOverApiProvider provider) : base(provider)
		{
		}

		/// <summary>
		/// Create an item
		/// details: https://developer.chargeover.com/apidocs/rest/#create-item
		/// </summary>
		public IIdentityResponse CreateItem(Models.Item request)
		{
			return Create("item", request);
		}

		/// <summary>
		/// Querying for items
		/// details: https://developer.chargeover.com/apidocs/rest/#query-item
		/// </summary>
		public IResponse<ItemDetails> QueryingForItems(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return Query<ItemDetails>("item");
		}
	}
}
