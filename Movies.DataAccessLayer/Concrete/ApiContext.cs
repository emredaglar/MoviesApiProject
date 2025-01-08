using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Movies.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DataAccessLayer.Concrete
{
	public class ApiContext:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=EMRED-PC\\SQLEXPRESS01;database=MoviesApiDb;integrated security=true;TrustServerCertificate=True;");
		}

		public DbSet<Category> Categories { get; set; }
		public DbSet<Movie> Movies { get; set; }
	}
}
