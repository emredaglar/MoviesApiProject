using Movies.BusinessLayer.Abstract;
using Movies.DataAccessLayer.Abstract;
using Movies.DataAccessLayer.EntityFreamwork;
using Movies.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.BusinessLayer.Concrete
{
	public class MovieManager : GenericManager<Movie>, IMovieService
	{
		private readonly IMovieDal _movieDal;
		public MovieManager(IGenericDal<Movie> genericDal,IMovieDal movieDal) : base(genericDal)
		{
			_movieDal = movieDal;
		}

		public int TMovieCount()
		{
			return _movieDal.MovieCount();
		}
	}
}
