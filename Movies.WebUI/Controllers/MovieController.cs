using Microsoft.AspNetCore.Mvc;
using Movies.WebUI.Dtos;
using Newtonsoft.Json;
using System.Net.Http;

namespace Movies.WebUI.Controllers
{
	public class MovieController : Controller
	{
		private readonly IHttpClientFactory _httpClientFactory;

		public MovieController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		
		
	}
}
