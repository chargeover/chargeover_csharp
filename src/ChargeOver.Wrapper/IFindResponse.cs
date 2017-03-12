using System.Collections.Generic;
using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper
{
	/// <summary>
	/// Find response
	/// </summary>
	public interface IFindResponse<T> : IResponse
		where T : Entity
	{
		/// <summary>
		/// Entities related to request
		/// </summary>
		IEnumerable<T> Entities { get; }
	}
}