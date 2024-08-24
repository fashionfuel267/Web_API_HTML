using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_API.Models
{
	public class ContextAPI: DbContext
	{
		public DbSet<Client> Clients { get; set; }
	}
}