using Microsoft.AspNetCore.Mvc;

namespace Movies.WebUI.Controllers
{
	public class DetailController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
