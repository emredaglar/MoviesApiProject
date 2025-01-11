using Microsoft.AspNetCore.Mvc;
using Movies.WebUI.Dtos;
using Newtonsoft.Json;

namespace Movies.WebUI.Controllers
{
    public class AdminMoviesController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminMoviesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> MovieList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5106/api/Category/CategoryWithMovieList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultCategoryWithMovieDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
