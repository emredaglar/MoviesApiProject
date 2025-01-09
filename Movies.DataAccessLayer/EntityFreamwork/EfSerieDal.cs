using Microsoft.EntityFrameworkCore;
using Movies.DataAccessLayer.Abstract;
using Movies.DataAccessLayer.Concrete;
using Movies.DataAccessLayer.Repositories;
using Movies.DtoLayer.SerieDto;
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

        public List<Serie> Last3Serie()
        {
           return _context.Series.OrderByDescending(x=>x.SerieId).Take(3).ToList();
        }

		public SerieWithCategoryDto SerieWithCategory(int id)
		{
			var value = _context.Series
		.Include(x => x.Category)
		.Where(serie => serie.SerieId == id)
		.Select(serie => new SerieWithCategoryDto
		{
			SerieId = serie.SerieId,
			SerieName = serie.SerieName,
			SerieImageUrl = serie.SerieImageUrl,
			SerieDescription = serie.SerieDescription,
			SerieScore = serie.SerieScore,
			SerieCreatedDate = serie.SerieCreatedDate,
			CategoryId = serie.CategoryId,
			CategoryName = serie.Category.CategoryName
		})
		.FirstOrDefault();

			return value;
		}
	}
}
