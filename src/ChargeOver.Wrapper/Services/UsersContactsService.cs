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
		public IResponse GetSpecificContact()
		{
			var api = Provider.Create();

			var result = api.Raw("", "/user", null);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
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
		public IResponse SendPasswordReset()
		{
			var api = Provider.Create();

			var result = api.Raw("", "/user", null);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Set a password
		/// details: https://developer.chargeover.com/apidocs/rest/#set-a-password
		/// </summary>
		public IIdentityResponse SetPassword(SetPassword request)
		{
			var api = Provider.Create();

			var result = api.Raw("", "/user", null, request);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
		}

		/// <summary>
		/// Log in a user
		/// details: https://developer.chargeover.com/apidocs/rest/#login-a-user
		/// </summary>
		public IResponse LogInUser()
		{
			var api = Provider.Create();

			var result = api.Raw("", "/user", null);

			var resultObject = JsonConvert.DeserializeObject<IdentityChargeOverResponse>(result.Item2);

			return new IdentityResponse(resultObject);
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
