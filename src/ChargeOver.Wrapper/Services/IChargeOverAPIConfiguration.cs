namespace ChargeOver.Wrapper.Services
{
	/// <summary>
	/// ChargeOverAPI configuration provider
	/// </summary>
	public interface IChargeOverAPIConfiguration
	{
		/// <summary>
		/// Endpoint <see cref="https://developer.chargeover.com/apidocs/rest/#authentication"/>
		/// </summary>
		string Endpoint { get; }
		/// <summary>
		/// Username <see cref="https://developer.chargeover.com/apidocs/rest/#authentication"/>
		/// </summary>
		string Username { get; }
		/// <summary>
		/// Password <see cref="https://developer.chargeover.com/apidocs/rest/#authentication"/>
		/// </summary>
		string Password { get; }
		/// <summary>
		/// Auth <see cref="https://developer.chargeover.com/apidocs/rest/#authentication"/>
		/// </summary>
		string Auth { get; }
	}
}