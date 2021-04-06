using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aplicacion1.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class HealthController : Controller
	{
		/*Path constant of the file to read.*/
		private const string Path = "C:/temp/index.html";

		[HttpGet("details")]
		public IActionResult HeathDetails()
		{
			/* Method to read the html and get the value of the src = to filter */
		   var str = System.IO.File.ReadAllText(Path);
		
			int start = str.IndexOf("src=\"main.") + 5;
			
			string result = str.Substring(start, str.IndexOf("\"", start) - start);

			return Ok(new { JsVersion = result });
		}

	}
}
