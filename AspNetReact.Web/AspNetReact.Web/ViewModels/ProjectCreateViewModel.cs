using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspNetReact.Web.ViewModels
{
	public class ProjectCreateViewModel
	{
		[Required]
		public string Name { get; set; }

		[Required]
		public string Description { get; set; }

		public string ErrorMessage { get; set; }
	}
}