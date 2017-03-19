using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class ItemsServiceTests
	{
		private ItemsService Sut{get;set;}

		[SetUp]
		public void SetUp()
		{
			Sut = new ItemsService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_CreateItem()
		{
			//arrange
			var request = new Item
			{
				Name = "My Test Item 832",
				Type = "service",
				//Pricemodel = "{  "base": 295.95,  "paycycle": "mon",  "pricemodel": "fla"}"
			};
			//act
			var actual = Sut.CreateItem(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_QueryingForItems()
		{
			//arrange
			//act
			var actual = Sut.QueryingForItems();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
