using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
    public class _LayoutSideBarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View();  
        }

    }
}
