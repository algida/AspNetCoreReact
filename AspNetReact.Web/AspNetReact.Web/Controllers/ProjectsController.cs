using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using AspNetReact.Contract.Services;
using AspNetReact.Contract.DataContracts;
using AspNetReact.Web.ViewModels;

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

		[HttpGet]
		public IActionResult Add()
		{
			return View(new ProjectCreateViewModel());
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Add(ProjectCreateViewModel viewModel)
		{
			var result = _projectsService.Add(new AddProjectDto
			{
				Name = viewModel.Name,
				Description = viewModel.Description
			});

			if (result.IsSuccess)
			{
				return RedirectToAction(nameof(ProjectsController.Index), "Projects");
			}
			else
			{
				viewModel.ErrorMessage = result.ErrorMessage;
				return View(viewModel);
			}
		}

		[HttpGet]
		public IActionResult Details(int id)
		{
			var result = _projectsService.GetById(id);

			return View(new ProjectViewModel()
			{
				Id = result.Item.Id,
				Name = result.Item.Name,
				Description = result.Item.Description,
				CreationDate = result.Item.CreationDate
			});
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Delete(int id)
		{
			_projectsService.Delete(id);

			return RedirectToAction(nameof(ProjectsController.Index), "Projects");
		}
	}
}