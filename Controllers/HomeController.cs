using System.Web.Mvc;
using AppHarborMotoWilliams.Services;

namespace AppHarborMotoWilliams.Controllers
{
	public class HomeController : Controller
	{
		private readonly IMotoService _motoService;

		public HomeController(IMotoService motoService)
		{
			_motoService = motoService;
		}

		public ActionResult Index()
		{
			ViewBag.Message = "Welcome to ASP.NET MVC!";
			ViewBag.Message += "Here are all the bikes " + string.Join(",", _motoService.GetBikes());
			return View();
		}

		public ActionResult About()
		{
			return View();
		}
	}
}
