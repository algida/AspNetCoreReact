using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetReact.DataAccess
{
	public class Project
	{
		public int Id { get; set; }

		[StringLength(250)]
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsDeleted { get; set; }
		public DateTime CreationDate { get; set; }
	}
}
