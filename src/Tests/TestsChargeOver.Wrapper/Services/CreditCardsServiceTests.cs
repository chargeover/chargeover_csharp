using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class CreditCardsServiceTests
	{
		private CreditCardsService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new CreditCardsService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_StoreCreditCard()
		{
			//arrange
			var request = new StoreCreditCard
			{
				CustomerId = 475,
				Number = "4111 1111 1111 1111",
				ExpdateYear = "2015",
				ExpdateMonth = "11",
				Name = "Keith Palmer",
				Address = "72 E Blue Grass Road",
				City = "Willington",
				//state = "CT"
				Postcode = "06279",
				Country = "United States",
			};
			//act
			var actual = Sut.StoreCreditCard(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_QueryingForCreditCards()
		{
			//arrange
			//act
			var actual = Sut.QueryingForCreditCards();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_DeleteCreditCard()
		{
			//arrange
			var request = new int
			{
			};
			//act
			var actual = Sut.DeleteCreditCard(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
