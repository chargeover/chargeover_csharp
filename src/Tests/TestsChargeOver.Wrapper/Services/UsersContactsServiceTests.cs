using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class UsersContactsServiceTests:BaseServiceTests<UsersContactsService>
	{
		protected override UsersContactsService Initialize(IChargeOverAPIConfiguration config)
		{
			return new UsersContactsService(config);
		}

		[Test]
		public async void should_call_AddContact()
		{
			//arrange
			var request = new AddContact
			{
				CustomerId = 21,
				Username = "my_test_username_" + Guid.NewGuid(),
				Password = "some test password",
				Name = "Ryan Bantz",
				Email = "ryan@adgadgagadg.com",
				Phone = "888-555-1212",
			};
			//act
			var actual = await Sut.AddContact(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public async void should_call_GetSpecificContact()
		{
			//arrange
			var id = AddContact();
			//act
			var actual = await Sut.GetContact(id);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public async void should_call_GetListContacts()
		{
			//arrange
			//act
			var actual = await Sut.ListContacts();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public async void should_call_QueryForContacts()
		{
			//arrange
			//act
			var actual = await Sut.QueryForContacts();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public async void should_call_SendPasswordReset()
		{
			//arrange
			var userId = AddContact();
			//act
			var actual = await Sut.SendPasswordReset(userId);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public async void should_call_SetPassword()
		{
			//arrange
			var userId = AddContact();
			var request = new SetPassword
			{
				Password = "here is the new password",
			};
			//act
			var actual = await Sut.SetPassword(userId, request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public async void should_call_LogInUser()
		{
			//arrange
			var id = AddContact();
			//act
			var actual = await Sut.LogIn(id);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public async void should_call_DeleteContact()
		{
			//arrange
			var request = AddContact();
			//act
			var actual = await Sut.DeleteContact(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int AddContact()
		{
			var request = new AddContact
			{
				CustomerId = 21,
				Username = "my_test_username_" + Guid.NewGuid(),
				Password = "some test password",
				Name = "Ryan Bantz",
				Email = "ryan@adgadgagadg.com",
				Phone = "888-555-1212",
			};
			return Sut.AddContact(request).Id;
		}
	}
}
