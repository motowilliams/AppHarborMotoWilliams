using System;

namespace AppHarborMotoWilliams.Services
{
	public class NullLogger : ILogger
	{
		public void Write(string message)
		{
		}
	}
}