using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IItemsService
	{
		/// <summary>
		/// Create an item
		/// details: https://developer.chargeover.com/apidocs/rest/#create-item
		/// </summary>
		IIdentityResponse CreateItem(Models.Item request);

		/// <summary>
		/// Querying for items
		/// details: https://developer.chargeover.com/apidocs/rest/#query-item
		/// </summary>
		IResponse<ItemDetails> QueryItems(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);
	}
}
