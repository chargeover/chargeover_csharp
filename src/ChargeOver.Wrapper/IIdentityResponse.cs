namespace ChargeOver.Wrapper
{
	/// <summary>
	/// Response from ChargeOverAPI
	/// </summary>
	public interface IIdentityResponse : IResponse
	{
		/// <summary>
		/// Response Id
		/// </summary>
		int Id { get; }
	}
}