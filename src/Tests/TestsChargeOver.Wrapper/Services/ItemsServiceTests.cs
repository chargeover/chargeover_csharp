using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class ItemsServiceTests : BaseServiceTests<ItemsService>
	{
		protected override ItemsService Initialize(IChargeOverAPIConfiguration config)
		{
			return new ItemsService(config);
		}

		[Test]
		public void should_call_CreateItem()
		{
			//arrange
			var request = new Item
			{
				Name = "My Test Item " + Guid.NewGuid(),
				Type = "service",
				Pricemodel = new ItemPricemodel
				{
					Base = 295.95F,
					Paycycle = "mon",
					Pricemodel = "fla"
				}
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
