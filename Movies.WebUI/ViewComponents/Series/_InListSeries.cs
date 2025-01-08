using Microsoft.AspNetCore.Mvc;
using Movies.WebUI.Dtos;
using Newtonsoft.Json;
using System.Net.Http;

namespace Movies.WebUI.ViewComponents.Series
{
	public class _InListSeries:ViewComponent
	{
		public async Task<IViewComponentResult> InvokeAsync()
		{
		
			return View();
		}
	}
}
