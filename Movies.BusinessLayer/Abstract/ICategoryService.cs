using Movies.DtoLayer.CategoryDtos;
using Movies.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.BusinessLayer.Abstract
{
	public interface ICategoryService:IGenericService<Category>
	{
        List<Category> TCategoryWithMovie();
        List<CategoryWithMoviesDto> TCategoryWithMovies();
        List<CategoryWithMoviesDto> TCategorysWithMovies(int id);
        int TCategoryCount();

    }
}
