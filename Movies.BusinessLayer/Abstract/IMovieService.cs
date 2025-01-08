using Movies.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.BusinessLayer.Abstract
{
	public interface IMovieService:IGenericService<Movie>
	{
		public int TMovieCount();
	}
}
