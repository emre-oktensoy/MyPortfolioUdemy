using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;


namespace MyPortfolioUdemy.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavBarComponentPartial:ViewComponent
    {
        MyPortfolioContext context= new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount = context.ToDoLists.Where(x => x.Status == false).Count();
            var values=context.ToDoLists.Where(x=>x.Status==false).ToList();
            return View(values);
        }
    }
}
