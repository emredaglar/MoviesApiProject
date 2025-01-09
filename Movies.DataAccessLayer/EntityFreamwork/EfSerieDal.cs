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
	public class EfSerieDal : GenericRepository<Serie>, ISerieDal
	{
		public EfSerieDal(ApiContext context) : base(context)
		{
		}
	}
}
