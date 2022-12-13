using ChargeOver.Wrapper.Models;
using System.Threading.Tasks;

namespace ChargeOver.Wrapper.Services
{
	public interface IUsersContactsService
	{
        /// <summary>
        /// Add a contact
        /// details: https://developer.chargeover.com/apidocs/rest/#create-a-user
        /// </summary>
        Task<IIdentityResponse> AddContact(AddContact request);

        /// <summary>
        /// Get a specific contact
        /// details: https://developer.chargeover.com/apidocs/rest/#get-users
        /// </summary>
        Task<ICustomResponse<ContactDetails>> GetContact(int id);

		/// <summary>
		/// Get a list of contacts
		/// details: https://developer.chargeover.com/apidocs/rest/#list-users
		/// </summary>
		Task<IResponse<Contact>> ListContacts();

		/// <summary>
		/// Query for contacts
		/// details: https://developer.chargeover.com/apidocs/rest/#query-users
		/// </summary>
		Task<IResponse<Contact>> QueryForContacts(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);

        /// <summary>
        /// Send a password reset
        /// details: https://developer.chargeover.com/apidocs/rest/#reset-a-password
        /// </summary>
        Task<ICustomResponse<bool>> SendPasswordReset(int userId);

		/// <summary>
		/// Set a password
		/// details: https://developer.chargeover.com/apidocs/rest/#set-a-password
		/// </summary>
		Task<ICustomResponse<bool>> SetPassword(int userId, SetPassword request);

		/// <summary>
		/// Log in a user
		/// details: https://developer.chargeover.com/apidocs/rest/#login-a-user
		/// </summary>
		Task<ICustomResponse<string>> LogIn(int id);

		/// <summary>
		/// Delete a contact
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-user
		/// </summary>
		Task<IResponse> DeleteContact(int id);
	}
}
