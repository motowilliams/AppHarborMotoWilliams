using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AppHarborMotoWilliams.Models;
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
			var motorcycleContext = new MotorcycleContext();
			List<Motorcycle> motorcycles = motorcycleContext.Motorcycles.ToList();
			string bikes = string.Join(",", motorcycles.Select(x => x.Make));
			ViewBag.Message += "Here are all the bikes " + bikes;
			return View();
		}

		public ActionResult About()
		{
			return View();
		}
	}
}
