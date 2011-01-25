using System.Collections.Generic;

namespace AppHarborMotoWilliams.Services
{
	public interface IMotoService
	{
		IEnumerable<string> GetBikes();
	}
}