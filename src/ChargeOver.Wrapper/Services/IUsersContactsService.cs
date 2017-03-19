using System;
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
		IResponse GetSpecificContact();

		/// <summary>
		/// Get a list of contacts
		/// details: https://developer.chargeover.com/apidocs/rest/#list-users
		/// </summary>
		IResponse<Contact> GetListContacts();

		/// <summary>
		/// Query for contacts
		/// details: https://developer.chargeover.com/apidocs/rest/#query-users
		/// </summary>
		IResponse<Contact> QueryForContacts(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10);

		/// <summary>
		/// Send a password reset
		/// details: https://developer.chargeover.com/apidocs/rest/#reset-a-password
		/// </summary>
		IResponse SendPasswordReset();

		/// <summary>
		/// Set a password
		/// details: https://developer.chargeover.com/apidocs/rest/#set-a-password
		/// </summary>
		IIdentityResponse SetPassword(SetPassword request);

		/// <summary>
		/// Log in a user
		/// details: https://developer.chargeover.com/apidocs/rest/#login-a-user
		/// </summary>
		IResponse LogInUser();

		/// <summary>
		/// Delete a contact
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-user
		/// </summary>
		IResponse DeleteContact(int id);
	}
}
