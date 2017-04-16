namespace ChargeOver.Wrapper
{
	public static class ResponseExtensions
	{
		public static bool IsSuccess(this IResponse @this)
		{
			return @this.Status == "OK";
		}
	}
}