namespace HW_10_ServiceGetDate
{
	public class LongDateService : IGetDate
	{
		public string GetDate()
		{
			return DateTime.Now.ToLongDateString();
		}
	}
}
