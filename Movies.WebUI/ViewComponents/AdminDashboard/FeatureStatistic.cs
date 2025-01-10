using Microsoft.AspNetCore.Mvc;
using Movies.DtoLayer.MovieDtos;
using Movies.EntityLayer.Concrete;
using Newtonsoft.Json;

namespace Core_App.ViewComponents.Dashboard
{
    public class FeatureStatistic : ViewComponent
    {
       private readonly IHttpClientFactory _httpClientFactory;

        public FeatureStatistic(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();


            var responseMessage = await client.GetAsync("http://localhost:5106/api/Movie/MovieCount");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var MovieCount = JsonConvert.DeserializeObject<int>(jsonData);
                ViewBag.MovieCount = MovieCount; 
               
            }

            var responseMessage2 = await client.GetAsync("http://localhost:5106/api/Serie/SerieCount");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage2.Content.ReadAsStringAsync();
                var SerieCount = JsonConvert.DeserializeObject<int>(jsonData);
                ViewBag.SerieCount = SerieCount;

            }
            var responseMessage3 = await client.GetAsync("http://localhost:5106/api/Category/CategoryCount");
            if (responseMessage3.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage3.Content.ReadAsStringAsync();
                var CategoryCount = JsonConvert.DeserializeObject<int>(jsonData);
                ViewBag.CategoryCount = CategoryCount;

            }

            return View();
        }
    }
}
