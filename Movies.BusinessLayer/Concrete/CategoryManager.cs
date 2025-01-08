using Movies.BusinessLayer.Abstract;
using Movies.DataAccessLayer.Abstract;
using Movies.DtoLayer.CategoryDtos;
using Movies.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.BusinessLayer.Concrete
{
	public class CategoryManager : GenericManager<Category>, ICategoryService
	{
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(IGenericDal<Category> genericDal, ICategoryDal categoryDal) : base(genericDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> TCategoryWithMovie()
        {
            return _categoryDal.CategoryWithMovie();
        }

        public List<CategoryWithMoviesDto> TCategoryWithMovies()
        {
            return _categoryDal.CategoryWithMovies();
        }
    }
}
