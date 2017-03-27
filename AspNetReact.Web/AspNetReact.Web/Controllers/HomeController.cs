﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetReact.Web.Controllers
{
    public class HomeController : Controller
    {
		public IActionResult Index()
		{
			if (User.Identity.IsAuthenticated)
			{
				return RedirectToAction(nameof(ProjectsController.Index), "Projects");
			}
			else
			{
				return View();
			}
		}

		public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
