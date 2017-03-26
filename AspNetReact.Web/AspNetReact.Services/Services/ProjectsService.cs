using AspNetReact.Contract.Common;
using AspNetReact.Contract.DataContracts;
using AspNetReact.Contract.Repositories;
using AspNetReact.Contract.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetReact.Services.Services
{
	public class ProjectsService : IProjectsService
	{
		private readonly IProjectsRepository _projectsRepository;

		public ProjectsService(IProjectsRepository projectsRepository)
		{
			_projectsRepository = projectsRepository;
		}

		public List<ProjectDto> GetAll()
		{
			return _projectsRepository.GetAll();
		}

		public CommonResult<ProjectDto> GetById(int id)
		{
			var project = _projectsRepository.GetById(id);

			if (project == null || project.IsDeleted)
			{
				return CommonResult<ProjectDto>.Failure("Problem occured during fetching project with given id.");
			}
			else
			{
				return CommonResult<ProjectDto>.Success(project);
			}
		}

		public CommonResult Add(AddProjectDto project)
		{
			if (string.IsNullOrEmpty(project.Name))
			{
				return CommonResult.Failure("Cannot create project without name provided.");
			}

			if (string.IsNullOrEmpty(project.Description))
			{
				return CommonResult.Failure("Cannot create project without description provided.");
			}

			var existingProject = _projectsRepository.GetByName(project.Name);

			if (existingProject != null && !existingProject.IsDeleted && existingProject.Name == project.Name)
			{
				return CommonResult.Failure("Project name already exists.");
			}

			_projectsRepository.Add(project);

			return CommonResult.Success();
		}
	}
}
