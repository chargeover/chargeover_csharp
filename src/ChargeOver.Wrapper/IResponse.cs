using System.Collections.Generic;

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
	}

	/// <summary>
	/// Response from ChargeOverAPI
	/// </summary>
	public interface IResponse<T> : IResponse
	{
		/// <summary>
		/// Response
		/// </summary>
		IEnumerable<T> Response { get; }
	}
}