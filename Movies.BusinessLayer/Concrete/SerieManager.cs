using Movies.BusinessLayer.Abstract;
using Movies.DataAccessLayer.Abstract;
using Movies.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.BusinessLayer.Concrete
{
	public class SerieManager : GenericManager<Serie>,ISerieService
	{
		public SerieManager(IGenericDal<Serie> genericDal) : base(genericDal)
		{
		}
	}
}
