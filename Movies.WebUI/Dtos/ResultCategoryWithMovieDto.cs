using Movies.EntityLayer.Concrete;

namespace Movies.WebUI.Dtos
{
    public class ResultCategoryWithMovieDto
    {



        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public Movie[] movies { get; set; }



        public int movieId { get; set; }
        public string movieName { get; set; }
        public object movieImageUrl { get; set; }
        public object movieDescription { get; set; }
        public object movieScore { get; set; }

        public object category { get; set; }
    }

    //public int CategoryId { get; set; }
    //public string CategoryName { get; set; }
    //public string ImageUrl { get; set; }
    //public string Title { get; set; }
    //public List<Movie> Movies { get; set; }
}
