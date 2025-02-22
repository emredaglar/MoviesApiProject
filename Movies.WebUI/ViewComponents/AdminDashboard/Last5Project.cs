﻿
using Microsoft.AspNetCore.Mvc;
using Movies.WebUI.Dtos;
using Newtonsoft.Json;

namespace Core_App.ViewComponents.Dashboard
{
    public class Last5Project : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public Last5Project(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();

            var responseMessage = await client.GetAsync("http://localhost:5106/api/Movie/Last5Movie");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMovieDto>>(jsonData);
                return View(values);

            }
            return View();
        }
    }
}
