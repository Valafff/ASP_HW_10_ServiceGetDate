namespace HW_10_ServiceGetDate
{
	public class ShortDateService : IGetDate
	{
		public string GetDate()
		{
			return DateTime.Now.ToShortDateString();
		}
	}
}
