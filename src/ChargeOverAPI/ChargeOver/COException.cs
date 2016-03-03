using System;

namespace ChargeOver
{
	[Serializable()]
	public class COException : System.Exception
	{
		public COException() : base() { }
		public COException(string message) : base(message) { }
		public COException(string message, System.Exception inner) : base(message, inner) { }

		// A constructor is needed for serialization when an 
		// exception propagates from a remoting server to the client.  
		protected COException(System.Runtime.Serialization.SerializationInfo info,
		                                     System.Runtime.Serialization.StreamingContext context) { }
	}
}

