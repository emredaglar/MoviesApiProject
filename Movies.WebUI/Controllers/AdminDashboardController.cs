using Microsoft.AspNetCore.Mvc;

namespace Core_App.Controllers
{
    public class AdminDashboardController : Controller
    {
        public IActionResult DashboardPage()
        {
            return View();
        }
    }
}
