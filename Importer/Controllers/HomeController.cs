using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Importer.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";
			String[] A = Directory.GetFiles(@"C:\Users\Miguel\Desktop\BatchFiles");
			SelectList list = new SelectList(A.ToList());
			ViewBag.myList = list;

			return View();
		}



	}
}