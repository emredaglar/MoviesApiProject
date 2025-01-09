﻿using Movies.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DataAccessLayer.Abstract
{
	public interface IMovieDal:IGenericDal<Movie>
	{
		public int MovieCount();
		public List<Movie> Last3Movie();
	}
}
