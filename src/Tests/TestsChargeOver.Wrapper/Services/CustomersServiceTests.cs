using System.Linq;
using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class CustomersServiceTests : BaseServiceTests<CustomersService>
	{
		protected override CustomersService Initialize(IChargeOverAPIConfiguration config)
		{
			return new CustomersService(config);
		}

		[Test]
		public void should_call_CreateCustomer()
		{
			//arrange
			var request = new Customer
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
				BillState = "CT"
			};
			//act
			var actual = Sut.CreateCustomer(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_UpdateCustomer()
		{
			//arrange
			var customerId = CreateCustomer();

			var request = new UpdateCustomer
			{
				Company = "Test API Company, LLC",
				BillAddr1 = "220 ChargeOver Street",
				BillAddr2 = "Suite 10",
				BillCity = "Minneapolis",
				BillState = "MN",
				BillPostalCode = "55416",
				BillCountry = "USA"
			};
			//act
			var actual = Sut.UpdateCustomer(customerId, request);
			//assert
			Assert.AreEqual(202, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
			var customer = Sut.QueryCustomers(new[] { "customer_id:EQUALS:" + customerId }).Response.First();
			Assert.AreEqual(request.BillAddr1, customer.BillAddr1);
		}

		[Test]
		public void should_call_GetListCustomers()
		{
			//arrange
			//act
			var actual = Sut.ListCustomers();
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_QueryForCustomers()
		{
			//arrange
			//act
			var actual = Sut.QueryCustomers(orders: new[] { "company:DESC" }, limit: 5);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
			Assert.AreEqual(5, actual.Response.Count());
		}

		[Test]
		public void should_call_DeleteCustomer()
		{
			//arrange
			var customerId = CreateCustomer();
			//act
			var actual = Sut.DeleteCustomer(customerId);
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		private int CreateCustomer()
		{
			var customerId = Sut.CreateCustomer(new Customer
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
				BillState = "CT"
			}).Id;
			return customerId;
		}
	}
}
