using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_API.Models
{
	public class Client
	{
		public int Id { get; set; }
		[StringLength(25)]
		public string Name { get; set; }
		[StringLength(15)]
		public string Contact { get; set; }

	}
}