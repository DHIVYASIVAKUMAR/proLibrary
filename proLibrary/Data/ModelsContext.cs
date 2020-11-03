using proLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace proLibrary.Data
{
	public class ModelsContext : DbContext
	{
		public DbSet<Book> books { get; set; }
		public DbSet<Student> students { get; set; }
		public DbSet<IssuedBooks> issuedBook { get; set; }
		public ModelsContext() : base("DefaultConnnection")
			{
		}
	}
}