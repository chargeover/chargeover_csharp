using System;
using System.Collections.Generic;

namespace ChargeOver
{
	public class Response
	{
		public int code;
		public string status;
		public string message;
		public List<Base> list;
		public Base obj;
		public int id;

		public Response(int code, string status, string message)
		{
			this.code = code;
			this.status = status;
			this.message = message;
		}

		public void setList<Base>(List<ChargeOver.Base> list)
		{
			this.list = list;
		}

		public void setObj(Base obj)
		{
			this.obj = obj;
		}

		public void setId(int id)
		{
			this.id = id;
		}
	}
}

