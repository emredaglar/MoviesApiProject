using Microsoft.AspNetCore.Mvc;
using Movies.WebUI.Dtos;
using Newtonsoft.Json;

namespace Movies.WebUI.Controllers
{
    public class DefaultController : Controller
    {
      
		public IActionResult Index()
        {
            return View();
        }

    }
}
