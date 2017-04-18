namespace ChargeOver.Wrapper.Models
{
	internal sealed class CustomResponse<T> : ICustomResponse<T>
	{
		public CustomResponse(CustomChargeOverResponse<T> response)
		{
			Response = response.Response;
			Code = response.Code;
			Status = response.Status;
		}

		public T Response { get; }
		public int Code { get; }
		public string Status { get; }
		public string Message { get; } = string.Empty;
	}
}