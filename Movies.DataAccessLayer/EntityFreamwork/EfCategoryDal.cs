using Microsoft.EntityFrameworkCore;
using Movies.DataAccessLayer.Abstract;
using Movies.DataAccessLayer.Concrete;
using Movies.DataAccessLayer.Repositories;
using Movies.DtoLayer.CategoryDtos;
using Movies.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Movies.DataAccessLayer.EntityFreamwork
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        ApiContext context = new ApiContext();
        public EfCategoryDal(ApiContext context) : base(context)
        {
        }

        public int CategoryCount()
        {
            return _context.Categories.Count();
        }

        public List<Category> CategoryWithMovie()
        {
            var values = context.Categories.Include(x => x.Movies).ToList();
            return values;
        }

        public List<CategoryWithMoviesDto> CategoryWithMovies()
        {
            var values = context.Categories.Include(x => x.Movies).Select(category => new CategoryWithMoviesDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Movies = category.Movies.Select(movie => new Movie
                {
                    MovieId = movie.MovieId,
                    MovieName = movie.MovieName,
                    MovieScore = movie.MovieScore

                }).ToList()
            })
        .ToList();

            return values;
        }
        public List<CategoryWithMoviesDto> CategorysWithMovies(int id)
        {
            var values = context.Categories.Include(x => x.Movies).Where(x => x.CategoryId == id).Select(category => new CategoryWithMoviesDto
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Movies = category.Movies.Select(movie => new Movie
                {
                    MovieId = movie.MovieId,
                    MovieName = movie.MovieName,
                    MovieScore = movie.MovieScore,
                    MovieImageUrl = movie.MovieImageUrl,
                    MovieCreatedDate = movie.MovieCreatedDate,
                    MovieDescription = movie.MovieDescription

                }).ToList()
            })
        .ToList();

            return values;
        }
    }
}