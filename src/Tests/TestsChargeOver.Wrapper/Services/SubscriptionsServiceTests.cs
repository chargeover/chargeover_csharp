using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class SubscriptionsServiceTests : BaseServiceTests<SubscriptionsService>
	{
		protected override SubscriptionsService Initialize(IChargeOverApiProvider provider)
		{
			return new SubscriptionsService(provider);
		}

		[Test]
		public void should_call_CreateSubscription()
		{
			//arrange
			var request = new Subscription
			{
				CustomerId = 5,
				HolduntilDatetime = DateTime.Parse("2013-10-01")
			};
			//act
			var actual = Sut.CreateSubscription(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_UpdateSubscription()
		{
			//arrange
			var request = new UpdateSubscription
			{
				Nickname = "My new nickname",
			};
			//act
			var actual = Sut.UpdateSubscription(request);
			//assert
			Assert.AreEqual(202, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_GetSpecificSubscription()
		{
			//arrange
			//act
			var actual = Sut.GetSpecificSubscription(AddSubscription());
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_QueryingForSubscriptions()
		{
			//arrange
			//act
			var actual = Sut.QueryingForSubscriptions();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_UpgradeDowngradesubscription()
		{
			//arrange
			var request = new UpgradeDowngradesubscription
			{
				//LineItems = "[  {    "line_item_id": 1953,    "item_id": 239,    "descrip": "A new description goes here",    "line_quantity": 123,    "trial_days": 120  }]"
			};
			//act
			var actual = Sut.UpgradeDowngradesubscription(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_ChangePricingOnSubscription()
		{
			//arrange
			var request = new ChangePricingOnSubscription
			{
				LineItems = new[]
				{
					new ChangePricingLineItem
					{
						Descrip = "Upgraded description goes here",
						ItemId = 1,
						LineItemId = TakeLineItem(),
						Tierset = new []
						{
							new ChangePricingTierset
							{
								Amount = 60,
								UnitFrom = 1,
								UnitTo = 9999
							}
						}
					}
				}
			};
			//act
			var actual = Sut.ChangePricingOnSubscription(AddSubscription(), request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_InvoiceSubscriptionNow()
		{
			//arrange
			//act
			var actual = Sut.InvoiceSubscriptionNow();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_SuspendSubscription()
		{
			//arrange
			//act
			var actual = Sut.SuspendSubscription();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_UnsuspendSubscription()
		{
			//arrange
			//act
			var actual = Sut.UnsuspendSubscription();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_CancelSubscription()
		{
			//arrange
			//act
			var actual = Sut.CancelSubscription();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_SetThePaymentMethod()
		{
			//arrange
			var request = new SetThePaymentMethod
			{
				Paymethod = "crd",
				CreditcardId = "64",
			};
			//act
			var actual = Sut.SetThePaymentMethod(request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_SendWelcomeEmail()
		{
			//arrange
			//act
			var actual = Sut.SendWelcomeEmail();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int AddSubscription()
		{
			return Sut.CreateSubscription(new Subscription
			{
				CustomerId = 5,
				HolduntilDatetime = DateTime.Parse("2013-10-01")
			}).Id;
		}

		private int TakeLineItem()
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
