using Movies.DataAccessLayer.Abstract;
using Movies.DataAccessLayer.Concrete;
using Movies.DataAccessLayer.Repositories;
using Movies.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DataAccessLayer.EntityFreamwork
{
	public class EfMovieDal : GenericRepository<Movie>, IMovieDal
	{
		public EfMovieDal(ApiContext context) : base(context)
		{
		}

		public List<Movie> Last3Movie()
		{
			return _context.Movies.OrderByDescending(x => x.MovieId).Take(3).ToList();
		}

		public int MovieCount()
		{
			var context=new ApiContext();
			int values=context.Movies.Count();
			return values;
		}
	}
}
