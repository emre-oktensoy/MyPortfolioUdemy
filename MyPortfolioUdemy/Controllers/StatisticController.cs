using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using System.Linq;

namespace MyPortfolioUdemy.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext  context=new MyPortfolioContext();   
        public IActionResult Index()
        {
            ViewBag.v1 = context.Skills.Count();
            ViewBag.v2 = context.Messages.Count();
            ViewBag.v3=context.Messages.Where(x=>x.IsRead==false).Count();
            ViewBag.v4=context.Messages.Where(x=>x.IsRead==true).Count();

            ViewBag.v5 = context.Experiences.Count();
            ViewBag.v6 = context.Experiences.Select(x=>x.Head).Distinct().Count();
            ViewBag.v7 = context.Experiences.Select(x => x.Title).Distinct().Count();
            ViewBag.v8 = context.ToDoLists.Count();

            ViewBag.v9 = context.ToDoLists.Where(x => x.Status == false).Count();
            ViewBag.v10 = context.ToDoLists.Where(x => x.Status == true).Count();
            ViewBag.v11 = context.ToDoLists.Where(d => d.Status == false).Select(d => d.Date.Year).Distinct().OrderByDescending(t => t).FirstOrDefault();
            ViewBag.v12 = context.ToDoLists.Where(d => d.Status == true).Select(d => d.Date.Year).Distinct().OrderByDescending(t => t).FirstOrDefault();





            return View();
        }
    }
}
