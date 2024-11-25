using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = context.abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = context.abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDescription = context.abouts.Select(x => x.Deatils).FirstOrDefault();
            return View();

        }
    }
}
