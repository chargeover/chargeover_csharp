using ChargeOver.Wrapper.Models;
using Newtonsoft.Json;

namespace ChargeOver.Wrapper.Services
{
	public sealed class UsersContactsService : BaseService, IUsersContactsService
	{
		public UsersContactsService(IChargeOverApiProvider provider) : base(provider)
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
		public ICustomResponse<ContactDetails> GetSpecificContact(int id)
		{
			return GetCustom<ContactDetails>("user", id);
		}

		/// <summary>
		/// Get a list of contacts
		/// details: https://developer.chargeover.com/apidocs/rest/#list-users
		/// </summary>
		public IResponse<Contact> GetListContacts()
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
			var api = Provider.Create();

			var result = api.Raw(PostRequest, $"/user/{userId}?action=password", null);

			var resultObject = JsonConvert.DeserializeObject<CustomChargeOverResponse<bool>>(result.Item2);

			return new CustomResponse<bool>(resultObject);
		}

		/// <summary>
		/// Set a password
		/// details: https://developer.chargeover.com/apidocs/rest/#set-a-password
		/// </summary>
		public ICustomResponse<bool> SetPassword(int userId, SetPassword request)
		{
			var api = Provider.Create();

			var result = api.Raw(PostRequest, $"/user/{userId}?action=password", null, request);

			var resultObject = JsonConvert.DeserializeObject<CustomChargeOverResponse<bool>>(result.Item2);

			return new CustomResponse<bool>(resultObject);
		}

		/// <summary>
		/// Log in a user
		/// details: https://developer.chargeover.com/apidocs/rest/#login-a-user
		/// </summary>
		public ICustomResponse<string> LogInUser(int id)
		{
			var api = Provider.Create();

			var result = api.Raw(PostRequest, $"/user/{id}?action=login", null);

			var resultObject = JsonConvert.DeserializeObject<CustomChargeOverResponse<string>>(result.Item2);

			return new CustomResponse<string>(resultObject);
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
