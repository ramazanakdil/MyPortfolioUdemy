using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.experiences.ToList();
            return View(values);
        }
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.experiences.Find(id);
            context.experiences.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");

        }

        public IActionResult UpdateExperience(int id)
        {
            var value = context.experiences.Find(id);
            return View(value);
        }

        [HttpPost]

        public IActionResult UpdateExperience(Experience experience)
        {
            context.experiences.Update(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }

        


    }
}
