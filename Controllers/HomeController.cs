using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;
using System.Xml.Linq;
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

		public JsonResult Hello()
		{
			var foo = new[]{ 
			new { Name = "Dakota", Age = 5 },
			new { Name = "Logan", Age = 3 },
			new { Name = "Shiloh", Age = 1 }
			};
			return Json(foo, JsonRequestBehavior.AllowGet);
		}

		public ActionResult HandleCall(string To, string From, string CallSid)
		{
			var doc = new XDocument();
			var response = new XElement("Response");

			response.Add(new XElement("Say", "Thank you for calling, please leave a message."));
			response.Add(new XElement("Record",
							new XAttribute("maxLength", 30),
							new XAttribute("action", Url.Action("HandleRecording"))
						));

			doc.Add(response);

			return new ContentResult
			{
				ContentType = "text/xml",
				Content = doc.ToString()
			};
		}

		public ActionResult HandleRecording(string RecordingUrl, string RecordingDuration, string Digits)
		{
			var connectionString = ConfigurationManager.ConnectionStrings["TwilioDB"].ConnectionString;
			var sqlConnection = new SqlConnection(connectionString);
			var cmdText = string.Format("INSERT INTO [db765].[dbo].[CallLog]([RecordingUrl],[RecordingDuration],[Digits])VALUES('{0}','{1}','{2}')", RecordingUrl, RecordingDuration, Digits);
			sqlConnection.Open();
			var sqlCommand = new SqlCommand(cmdText,sqlConnection);
			sqlCommand.ExecuteNonQuery();
			sqlConnection.Close();
			return new EmptyResult();
		}
	}
}
