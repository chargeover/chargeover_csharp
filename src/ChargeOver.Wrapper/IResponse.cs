namespace ChargeOver.Wrapper
{
	/// <summary>
	/// Response from ChargeOverAPI
	/// </summary>
	public interface IResponse
	{
		/// <summary>
		/// Response code
		/// </summary>
		int Code { get; }
		/// <summary>
		/// Response status
		/// </summary>
		string Status { get; }
		/// <summary>
		/// Response message
		/// </summary>
		string Message { get; }
		/// <summary>
		/// Response Id
		/// </summary>
		int Id { get; }
	}
}