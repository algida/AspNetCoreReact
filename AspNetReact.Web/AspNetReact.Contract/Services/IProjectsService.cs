using AspNetReact.Contract.Common;
using AspNetReact.Contract.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetReact.Contract.Services
{
	public interface IProjectsService
	{
		List<ProjectDto> GetAll();
		CommonResult<ProjectDto> GetById(int id);

		CommonResult Add(AddProjectDto project);
	}
}
