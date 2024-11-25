using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var value = context.toDoLists.ToList();
            return View(value);
        }


        public IActionResult CreateToDoList()
        {
            return View();
        }

        [HttpPost]

        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.toDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = context.toDoLists.Find(id);
            context.toDoLists.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult UpdateToDoList(int id)
        {
            var values = context.toDoLists.Find(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            context.toDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeIsReadToFalse(int id)
        {
            var values = context.toDoLists.Find(id);
            values.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult ChangeIsReadToTrue(int id)
        {
            var values = context.toDoLists.Find(id);
            values.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }


}
