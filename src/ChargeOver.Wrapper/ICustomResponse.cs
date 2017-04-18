namespace ChargeOver.Wrapper
{
	public interface ICustomResponse<T> : IResponse
	{
		/// <summary>
		/// Response
		/// </summary>
		T Response { get; }
	}
}