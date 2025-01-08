﻿using Microsoft.AspNetCore.Mvc;
using Movies.WebUI.Dtos;
using Newtonsoft.Json;

namespace Movies.WebUI.ViewComponents.Movie
{
	public class _Slider : ViewComponent
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public _Slider(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("http://localhost:5106/api/Movie");
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
