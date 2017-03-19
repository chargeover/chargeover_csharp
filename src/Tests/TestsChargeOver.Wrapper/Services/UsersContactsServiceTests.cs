using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class UsersContactsServiceTests
	{
		private UsersContactsService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new UsersContactsService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_AddContact()
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
			var actual = Sut.AddContact(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_GetSpecificContact()
		{
			//arrange
			//act
			var actual = Sut.GetSpecificContact();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_GetListContacts()
		{
			//arrange
			//act
			var actual = Sut.GetListContacts();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_QueryForContacts()
		{
			//arrange
			//act
			var actual = Sut.QueryForContacts();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_SendPasswordReset()
		{
			//arrange
			//act
			var actual = Sut.SendPasswordReset();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_SetPassword()
		{
			//arrange
			var request = new SetPassword
			{
				Password = "here is the new password",
			};
			//act
			var actual = Sut.SetPassword(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_LogInUser()
		{
			//arrange
			//act
			var actual = Sut.LogInUser();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_DeleteContact()
		{
			//arrange
			var request = new int
			{
			};
			//act
			var actual = Sut.DeleteContact(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
