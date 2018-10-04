using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class CreditCardsServiceTests : BaseServiceTests<CreditCardsService>
	{
		protected override CreditCardsService Initialize(IChargeOverAPIConfiguration config)
		{
			return new CreditCardsService(config);
		}

		[Test]
		public void should_call_StoreCreditCard()
		{
			//arrange
			var request = new StoreCreditCard
			{
				CustomerId = 1,
				Number = "4111 1111 1111 1111",
				ExpirationDateYear = (DateTime.UtcNow.Year + 1).ToString(),
				ExpirationDateMonth = "11",
				Name = "Keith Palmer",
				Address = "72 E Blue Grass Road",
				City = "Willington",
				//state = "CT"
				PostalCode = "06279",
				Country = "United States",
			};
			//act
			var actual = Sut.StoreCreditCard(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_QueryingForCreditCards()
		{
			//arrange
			//act
			var actual = Sut.QueryCreditCards();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_DeleteCreditCard()
		{
			//arrange
			//act
			var actual = Sut.DeleteCreditCard(AddCard());
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int AddCard()
		{
			var request = new StoreCreditCard
			{
				CustomerId = 1,
				Number = "4111 1111 1111 1111",
				ExpirationDateYear = (DateTime.UtcNow.Year + 1).ToString(),
				ExpirationDateMonth = "11",
				Name = "Keith Palmer",
				Address = "72 E Blue Grass Road",
				City = "Willington",
				//state = "CT"
				PostalCode = "06279",
				Country = "United States",
			};
			//act
			return Sut.StoreCreditCard(request).Id;
		}
	}
}
