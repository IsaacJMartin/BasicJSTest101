using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {

        public IActionResult Index()
        {

			return View();
        }

		// 
		// GET: /Default/Submitted/
		public string Submitted()
		{
			// ToDo: Get submitted options, sort and return as JSON
			return "Submitted...";
		}

	}
}