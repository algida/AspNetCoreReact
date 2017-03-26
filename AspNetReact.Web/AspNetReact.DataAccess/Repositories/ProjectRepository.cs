using AspNetReact.Contract.DataContracts;
using AspNetReact.Contract.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AspNetReact.DataAccess.Repositories
{
	public class ProjectsRepository : IProjectsRepository
	{
		private readonly ApplicationDbContext _dbContext;

		public ProjectsRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		public List<ProjectDto> GetAll()
		{
			return _dbContext.Projects
				.Where(x => x.IsDeleted == false)
				.Select(x => new ProjectDto
				{
					Id = x.Id,
					Name = x.Name,
					Description = x.Description,
					IsDeleted = x.IsDeleted,
					CreationDate = x.CreationDate
				})
				.ToList();
		}

		public ProjectDto GetById(int id)
		{
			var project = _dbContext.Projects.First(x => x.Id == id);

			return new ProjectDto
			{
				Id = project.Id,
				Name = project.Name,
				Description = project.Description,
				CreationDate = project.CreationDate,
				IsDeleted = project.IsDeleted
			};
		}
	}
}
