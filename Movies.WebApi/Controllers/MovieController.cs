using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Movies.BusinessLayer.Abstract;
using Movies.DtoLayer.MovieDtos;
using Movies.EntityLayer.Concrete;

namespace Movies.WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MovieController : ControllerBase
	{
		private readonly IMovieService _movieService;

		public MovieController(IMovieService movieService)
		{
			_movieService = movieService;
		}
		[HttpGet]
		public IActionResult MovieList()
		{
			var values = _movieService.TGetAll();
			return Ok(values);
		}
		[HttpPost]
		public IActionResult CreateMovie(CreateMovieDto createMovieDto)
		{
			Movie movie = new Movie();
			movie.MovieName = createMovieDto.MovieName;
			movie.MovieDescription = createMovieDto.MovieDescription;
			movie.MovieImageUrl = createMovieDto.MovieImageUrl;
			movie.CategoryId = createMovieDto.CategoryId;
			movie.MovieScore = createMovieDto.MovieScore;
			_movieService.TInsert(movie);
			return Ok("Ekleme Başarılı");
		}
		[HttpPut]
		public IActionResult UpdateMovie(UpdateMovieDto updateMovieDto)
		{
			Movie movie = new Movie();
			movie.MovieName = updateMovieDto.MovieName;
			movie.MovieId = updateMovieDto.MovieId;
			movie.MovieDescription = updateMovieDto.MovieDescription;
			movie.MovieImageUrl = updateMovieDto.MovieImageUrl;
			movie.CategoryId = updateMovieDto.CategoryId;
			movie.MovieScore = updateMovieDto.MovieScore;
			_movieService.TUpdate(movie);
			return Ok("Güncelleme Başarılı");
		}
		[HttpGet("GetMovie")]
		public IActionResult GetMovie(int id)
		{
			var value=_movieService.TGetById(id);
			return Ok(value);
		}
		[HttpDelete]
		public IActionResult DeleteMovie(int id)
		{
			_movieService.TDelete(id);
			return Ok("Silme Başarılı");
		}
		[HttpGet("MovieCount")]
		public IActionResult MovieCount()
		{
			var value= _movieService.TMovieCount();
			return Ok(value);
		}
	}
}
