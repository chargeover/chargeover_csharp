using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class UsageServiceTests : BaseServiceTests<UsageService>
	{
		protected override UsageService Initialize(IChargeOverApiProvider provider)
		{
			return new UsageService(provider);
		}

		[Test]
		public void should_call_StoringUsageData()
		{
			//arrange
			var request = new StoringUsageData
			{
				LineItemId = TakeItemId(),
				UsageValue = 265.2F,
				From = DateTime.Parse("2013-10-16"),
				To = DateTime.Parse("2013-10-16")
			};
			//act
			var actual = Sut.StoringUsageData(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int TakeItemId()
		{
			return new ItemsService(Provider).CreateItem(new Item
			{
				Name = "My Test Item " + Guid.NewGuid(),
				Type = "service",
				Pricemodel = new ItemPricemodel
				{
					Base = 295.95F,
					Paycycle = "mon",
					Pricemodel = "fla"
				}
			}).Id;
		}
	}
}
