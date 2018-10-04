using System;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class SubscriptionsServiceTests : BaseServiceTests<SubscriptionsService>
	{
		protected override SubscriptionsService Initialize(IChargeOverAPIConfiguration config)
		{
			return new SubscriptionsService(config);
		}

		[Test]
		public void should_call_CreateSubscription()
		{
			//arrange
			var request = new Subscription
			{
				CustomerId = TakeCustomer(),
				HoldUntilDatetime = DateTime.Parse("2013-10-01")
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
			var actual = Sut.UpdateSubscription(AddSubscription(), request);
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
			var actual = Sut.GetSubscription(AddSubscription());
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
			var actual = Sut.QuerySubscriptions();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_UpgradeDowngradesubscription()
		{
			//arrange
			var customer = TakeCustomer();
			var lineId = TakeLineItem();
			var subscription = CreateLineItemFromSubscription(customer, lineId);

			var request = new UpgradeDowngradesubscription
			{
				LineItems = new[]
				{
					new TrialInvoiceLineItem
					{
						Description = "A new description goes here",
						ItemId = lineId,
						LineQuantity = 123,
						LineItemId = subscription.Item2
					}
				}
			};
			//act
			var actual = Sut.UpgradeDowngradeSubscription(subscription.Item1, request);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_ChangePricingOnSubscription()
		{
			//arrange
			var itemId = TakeLineItem();
			var data = CreateLineItemFromSubscription(TakeCustomer(), itemId);

			var request = new ChangePricingOnSubscription
			{
				LineItems = new[]
				{
					new ChangePricingLineItem
					{
						Descrip = "Upgraded description goes here",
						ItemId = itemId,
						LineItemId = data.Item2,
						Tierset = new ChangePricingTierset
						{
							Setup = 10,
							Base = 135,
							Pricemodel = "uni",

							Tiers = new[]
							{
								new ChangePricingTier
								{
									Amount = 60,
									UnitFrom = 1,
									UnitTo = 9999
								}
							}
						}
					}
				}
			};
			//act
			var actual = Sut.ChangePricingOnSubscription(data.Item1, request);
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
			var actual = Sut.InvoiceSubscriptionNow(AddSubscription());
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
			var actual = Sut.SuspendSubscription(AddSubscription());
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
			var actual = Sut.UnsuspendSubscription(AddSubscription());
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
			var actual = Sut.CancelSubscription(AddSubscription());
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_SetThePaymentMethod()
		{
			//arrange
			var customerId = TakeCustomer();
			var request = new SetThePaymentMethod
			{
				PayMethod = "crd",
				CreditCardId = TakeCreditCard(customerId),
			};
			//act
			var addSubscription = AddSubscription(customerId: customerId);
			var actual = Sut.SetPaymentMethod(addSubscription, request);
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
			var actual = Sut.SendWelcomeEmail(AddSubscription());
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int AddSubscription(int? lineId = null, int? customerId = null)
		{
			if (lineId == null)
			{
				lineId = TakeLineItem();
			}

			if (customerId == null)
			{
				customerId = TakeCustomer();
			}

			return Sut.CreateSubscription(new Subscription
			{
				CustomerId = customerId,
				HoldUntilDatetime = DateTime.Parse("2013-10-01"),
				LineItems = new SubscriptionLineItem[]
				{
					new SubscriptionLineItem
					{
						ItemId = lineId.Value,
						Description = "desc"
					}
				}
			}).Id;
		}

		private int TakeCustomer()
		{
			return new CustomersService(Config).CreateCustomer(new Customer
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
				BillState = "CT",
				SuperUserEmail = "mail@mail.com"
			}).Id;
		}

		private int TakeLineItem()
		{
			return new ItemsService(Config).CreateItem(new Item
			{
				Name = "My Test Item " + Guid.NewGuid(),
				Type = "service",
				PriceModel = new ItemPriceModel
				{
					Base = 295.95F,
					PayCycle = "mon",
					PriceModel = "fla"
				}
			}).Id;
		}

		private int TakeCreditCard(int? customerId = null)
		{
			if (customerId == null)
			{
				customerId = TakeCustomer();
			}

			return new CreditCardsService(Config).StoreCreditCard(new StoreCreditCard
			{
				CustomerId = customerId,
				Number = "4111 1111 1111 1111",
				ExpirationDateYear = (DateTime.UtcNow.Year + 1).ToString(),
				ExpirationDateMonth = "11",
				Name = "Keith Palmer",
				Address = "72 E Blue Grass Road",
				City = "Willington",
				PostalCode = "06279",
				Country = "United States",
			}).Id;
		}

		private Tuple<int, int> CreateLineItemFromSubscription(int customerId, int itemId)
		{
			var subscriptionId = Sut.CreateSubscription(new Subscription
			{
				CustomerId = customerId,
				HoldUntilDatetime = DateTime.Parse("2013-10-01"),
				LineItems = new SubscriptionLineItem[]
				{
					new SubscriptionLineItem
					{
						Description = "desc",
						ItemId = itemId
					}
				}
			}).Id;

			var subscriptionDetails = Sut.GetSubscription(subscriptionId).Response;

			return new Tuple<int, int>(subscriptionDetails.PackageId.Value, subscriptionDetails.LineItems[0].LineItemId);
		}
	}
}
