using Microsoft.EntityFrameworkCore;
using Movies.DataAccessLayer.Abstract;
using Movies.DataAccessLayer.Concrete;
using Movies.DataAccessLayer.Repositories;
using Movies.DtoLayer.MovieDtos;
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
		ApiContext apiContext = new ApiContext();
		public EfMovieDal(ApiContext context) : base(context)
		{
		}

		public List<Movie> Last3Movie()
		{
			return _context.Movies.OrderByDescending(x => x.MovieId).Take(3).ToList();
		}

		public int MovieCount()
		{
			var context = new ApiContext();
			int values = context.Movies.Count();
			return values;
		}

		public MovieWithCategoryDto MovieWithCategory(int id)
		{
			var value = _context.Movies
		.Include(x => x.Category)
		.Where(movie => movie.MovieId == id)
		.Select(movie => new MovieWithCategoryDto
		{
			MovieId = movie.MovieId,
			MovieName = movie.MovieName,
			MovieImageUrl = movie.MovieImageUrl,
			MovieDescription = movie.MovieDescription,
			MovieScore = movie.MovieScore,
			MovieCreatedDate = movie.MovieCreatedDate,
			CategoryId = movie.CategoryId,
			CategoryName = movie.Category.CategoryName
		})
		.FirstOrDefault(); 

			return value;
		}
	}
}
