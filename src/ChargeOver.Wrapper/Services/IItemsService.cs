namespace ChargeOver.Wrapper.Services
{
	public interface IItemsService
	{
		IResponse Create(Models.Item item);
		IFindResponse<Models.Item> Query(params string[] queries);
	}
}