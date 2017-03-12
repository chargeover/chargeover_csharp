using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper
{
	[TestFixture]
	public sealed class CustomerServiceTests
	{
		private CustomerService Sut { get; set; }

		[SetUp]
		public void SetUp()
		{
			Sut = new CustomerService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_create_customer()
		{
			//arrange
			//act
			var actual = Sut.Create(new CustomerEntity
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
				BillState = "CT"
			});
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsTrue(actual.Id > 0);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}