using ChargeOver.Wrapper.Models;
using ChargeOver.Wrapper.Services;
using NUnit.Framework;

namespace TestsChargeOver.Wrapper.Services
{
	[TestFixture]
	public sealed class NotesServiceTests
	{
		private NotesService Sut { get; set; }

		[SetUp]
		public void SetUp()
		{
			Sut = new NotesService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config));
		}

		[Test]
		public void should_call_CreateNote()
		{
			//arrange
			var result = new CustomersService(new ChargeOverApiProvider(ChargeOverAPIConfiguration.Config)).CreateCustomer(new Customer
			{
				Company = "Test Company Name",
				BillAddr1 = "16 Dog Lane",
				BillAddr2 = "Suite D",
				BillCity = "Storrs",
				BillState = "CT",
			});

			var request = new Note
			{
				NoteDetails = "Here is my test note",
				ObjType = "customer",
				ObjId = result.Id
			};
			//act
			var actual = Sut.CreateNote(request);
			//assert
			Assert.AreEqual(201, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}

		[Test]
		public void should_call_QueryNotesForObject()
		{
			//arrange
			//act
			var actual = Sut.QueryNotesForObject("where=obj_type:EQUALS:customer");
			//assert
			Assert.AreEqual(200, actual.Code);
			Assert.IsEmpty(actual.Message);
			Assert.AreEqual("OK", actual.Status);
		}
	}
}
