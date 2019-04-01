using System.Linq;
using ChargeOver.Wrapper.Examples.Services;

namespace ChargeOver.Wrapper.Examples
{
	class Program
	{
		static void Main()
		{
			var examples = new IServiceExample[]
			{
				// CustomersServiceExample(),
				new InvoiceServiceExample(),
				//new SubscriptionServiceExample(),
				new TransactionsServiceExample(),
			    //new CreditCardServiceExample(),
				//new ACHeCheckAccountsServiceExample()
			}.ToList();

			examples.ForEach(e => e.Run());
		}
	}
}
