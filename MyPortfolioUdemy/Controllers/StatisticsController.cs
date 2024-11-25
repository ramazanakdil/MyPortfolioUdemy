using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class StatisticsController : Controller
    {
        MyPortfolioContext context=new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.v1 = context.skills.Count();
            ViewBag.v2=context.messages.Count();
            ViewBag.v3=context.messages.Where(x=>x.IsRead==false).Count();
            ViewBag.v4=context.messages.Where(x=>x.IsRead==true).Count();
            return View();
        }
    }
}
