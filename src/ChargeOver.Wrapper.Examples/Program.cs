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
				new CustomersServiceExample(),
				new InvoiceServiceExample(),
				new SubscriptionServiceExample()
			}.ToList();

			examples.ForEach(e => e.Run());
		}
	}
}
