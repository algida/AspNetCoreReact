using AspNetReact.Contract.DataContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspNetReact.Contract.Repositories
{
	public interface IProjectsRepository
	{
		List<ProjectDto> GetAll();
		ProjectDto GetById(int id);
		ProjectDto GetByName(string projectName);
		void Add(AddProjectDto project);
		void Delete(int id);
	}
}
