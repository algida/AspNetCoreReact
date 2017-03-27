using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AspNetReact.Contract.Services;

namespace AspNetReact.Web.Controllers
{
	[Authorize]
	public class ProjectsController : Controller
	{
		private IProjectsService _projectsService;

		public ProjectsController(IProjectsService projectsService)
		{
			_projectsService = projectsService;
		}

		[HttpGet]
		public IActionResult Index()
		{
			return View();
		}
	}
}