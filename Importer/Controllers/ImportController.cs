using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace Importer.Controllers
{
	public class ImportController : Controller
	{
		// GET: Import
		public ActionResult Index()
		{
			return View();
		}

		private void Filereader(object sender, System.IO.RenamedEventArgs e)
		{

			string[] Filename = Directory.GetFiles(@"C:\Users\Miguel\Desktop\BatchFiles");

			if (System.IO.File.Exists(@"C:\Users\Miguel\Desktop\BatchFiles"))
			{
				System.Diagnostics.Process proc = new System.Diagnostics.Process();
				proc.StartInfo.FileName = Filename.ToString();
				proc.StartInfo.WorkingDirectory = Filename.ToString();
				proc.Start();


			}
		}
	}
}