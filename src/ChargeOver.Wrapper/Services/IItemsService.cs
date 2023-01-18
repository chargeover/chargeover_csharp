using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface IItemsService
	{
        /// <summary>
        /// Create an item
        /// details: https://developer.chargeover.com/apidocs/rest/#create-item
        /// </summary>
        Task<IIdentityResponse> CreateItem(Models.Item request);

        /// <summary>
        /// Querying for items
        /// details: https://developer.chargeover.com/apidocs/rest/#query-item
        /// </summary>
        Task<IResponse<ItemDetails>> QueryItems(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);
	}
}
