using Microsoft.AspNetCore.Mvc;
using Movies.WebUI.Dtos;
using Newtonsoft.Json;

namespace Movies.WebUI.ViewComponents.Series
{
    public class _Last3Serie : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _Last3Serie(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5106/api/Serie/Last3Serie");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSerieDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
