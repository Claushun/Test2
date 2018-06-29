using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static System.Net.WebRequestMethods;
using System.IO;

namespace Importer.Logic
{
	public class FileReader
	{
		private void Filereader (object sender, System.IO.RenamedEventArgs e)
		{

			 string[] Filename = Directory.GetFiles(@"C:\Users\Miguel\Desktop\BatchFiles"); 

				if (System.IO.File.Exists(@"C:\Users\Miguel\Desktop\BatchFiles"))
			{
				System.Diagnostics.Process proc = new System.Diagnostics.Process();
				proc.StartInfo.FileName = Filename.ToString();
				proc.StartInfo.WorkingDirectory =Filename.ToString();
				proc.Start();
				

			}
			
		}
	}
}