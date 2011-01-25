using System;
using System.Collections.Generic;

namespace AppHarborMotoWilliams.Services
{
	public class MotoService : IMotoService
	{
		private readonly ILogger _logger;

		public MotoService(ILogger logger)
		{
			_logger = logger;
		}

		public IEnumerable<string> GetBikes()
		{
			_logger.Write("Returning all bikes!");
			return new[] { "Harley Davidson", "Buell" };
		}
	}
}