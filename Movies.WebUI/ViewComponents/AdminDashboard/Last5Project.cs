
using Microsoft.AspNetCore.Mvc;

namespace Core_App.ViewComponents.Dashboard
{
    public class Last5Project:ViewComponent
    {
        //Context context=new Context();
        public IViewComponentResult Invoke()
        {
            //var values = context.Portfolios.OrderByDescending(x => x.PortfolioID).Take(5).ToList();
            return View();
        }
    }
}
