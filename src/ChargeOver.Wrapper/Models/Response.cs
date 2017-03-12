namespace ChargeOver.Wrapper.Models
{
	internal sealed class Response : IResponse
	{
		public Response(ChargeOver.Response response)
		{
			Code = response.code;
			Status = response.status;
			Message = response.message;
			Id = response.id;
		}

		public Response(ChargeOverResponse response)
		{
			Code = response.Code;
			Status = response.Status;
			Id = response.Response.Id;
		}

		public int Code { get; }
		public string Status { get; }
		public string Message { get; } = string.Empty;
		public int Id { get; }
	}
}