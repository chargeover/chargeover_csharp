using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public interface IUsersContactsService
	{
		/// <summary>
		/// Add a contact
		/// details: https://developer.chargeover.com/apidocs/rest/#create-a-user
		/// </summary>
		IIdentityResponse AddContact(AddContact request);

		/// <summary>
		/// Get a specific contact
		/// details: https://developer.chargeover.com/apidocs/rest/#get-users
		/// </summary>
		ICustomResponse<ContactDetails> GetContact(int id);

		/// <summary>
		/// Get a list of contacts
		/// details: https://developer.chargeover.com/apidocs/rest/#list-users
		/// </summary>
		IResponse<Contact> ListContacts();

		/// <summary>
		/// Query for contacts
		/// details: https://developer.chargeover.com/apidocs/rest/#query-users
		/// </summary>
		IResponse<Contact> QueryForContacts(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);

		/// <summary>
		/// Send a password reset
		/// details: https://developer.chargeover.com/apidocs/rest/#reset-a-password
		/// </summary>
		ICustomResponse<bool> SendPasswordReset(int userId);

		/// <summary>
		/// Set a password
		/// details: https://developer.chargeover.com/apidocs/rest/#set-a-password
		/// </summary>
		ICustomResponse<bool> SetPassword(int userId, SetPassword request);

		/// <summary>
		/// Log in a user
		/// details: https://developer.chargeover.com/apidocs/rest/#login-a-user
		/// </summary>
		ICustomResponse<string> LogIn(int id);

		/// <summary>
		/// Delete a contact
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-user
		/// </summary>
		IResponse DeleteContact(int id);
	}
}
