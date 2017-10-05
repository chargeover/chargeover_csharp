using ChargeOver.Wrapper.Models;

namespace ChargeOver.Wrapper.Services
{
	public sealed class UsersContactsService : BaseService, IUsersContactsService
	{
		public UsersContactsService(IChargeOverAPIConfiguration config) : base(config)
		{
		}

		public UsersContactsService()
		{
		}

		/// <summary>
		/// Add a contact
		/// details: https://developer.chargeover.com/apidocs/rest/#create-a-user
		/// </summary>
		public IIdentityResponse AddContact(AddContact request)
		{
			return Create("user", request);
		}

		/// <summary>
		/// Get a specific contact
		/// details: https://developer.chargeover.com/apidocs/rest/#get-users
		/// </summary>
		public ICustomResponse<ContactDetails> GetContact(int id)
		{
			return GetCustom<ContactDetails>("user", id);
		}

		/// <summary>
		/// Update a contact 
		/// details: 
		/// </summary>
		/// <returns>The contact.</returns>
		/// <param name="id">Identifier.</param>
		/// <param name="request">Request.</param>
		public IIdentityResponse UpdateContact(int id, Contact request)
		{
			return new IdentityResponse(Request<Contact, IdentityChargeOverResponse>(MethodType.PUT, "/user/" + id, request));
		}

		/// <summary>
		/// Get a list of contacts
		/// details: https://developer.chargeover.com/apidocs/rest/#list-users
		/// </summary>
		public IResponse<Contact> ListContacts()
		{
			return GetList<Contact>("user");
		}

		/// <summary>
		/// Query for contacts
		/// details: https://developer.chargeover.com/apidocs/rest/#query-users
		/// </summary>
		public IResponse<Contact> QueryForContacts(string[] queries = null, string[] orders = null, int offset = 0, int limit = 10)
		{
			return Query<Contact>("user", queries, orders, offset, limit);
		}

		/// <summary>
		/// Send a password reset
		/// details: https://developer.chargeover.com/apidocs/rest/#reset-a-password
		/// </summary>
		public ICustomResponse<bool> SendPasswordReset(int userId)
		{
			return GetCustomBool<object>($"/user/{userId}?action=password", null);
		}

		/// <summary>
		/// Set a password
		/// details: https://developer.chargeover.com/apidocs/rest/#set-a-password
		/// </summary>
		public ICustomResponse<bool> SetPassword(int userId, SetPassword request)
		{
			return GetCustomBool($"/user/{userId}?action=password", request);
		}

		/// <summary>
		/// Log in a user
		/// details: https://developer.chargeover.com/apidocs/rest/#login-a-user
		/// </summary>
		public ICustomResponse<string> LogIn(int id)
		{
			return new CustomResponse<string>(Request<object, CustomChargeOverResponse<string>>(MethodType.POST, $"/user/{id}?action=login", null));
		}

		/// <summary>
		/// Delete a contact
		/// details: https://developer.chargeover.com/apidocs/rest/#delete-a-user
		/// </summary>
		public IResponse DeleteContact(int id)
		{
			return Delete("user", id);
		}
	}
}
