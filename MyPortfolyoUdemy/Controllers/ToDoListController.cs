using Microsoft.AspNetCore.Mvc;
using MyPortfolyoUdemy.DAL.Context;
using MyPortfolyoUdemy.DAL.Entities;

namespace MyPortfolyoUdemy.Controllers
{
    public class ToDoListController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var values = context.ToDoLists.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateToDoList()
        {
            return View();
        }
        public IActionResult ChangeToDoListStatusTrue(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = true;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ChangeToDoListStatusFalse(int id)
        {
            var value = context.ToDoLists.Find(id);
            value.Status = false;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult CreateToDoList(ToDoList toDoList)
        {
            toDoList.Status = false;
            context.ToDoLists.Add(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            context.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateToDoList(int id)
        {
            var value = context.ToDoLists.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateToDoList(ToDoList toDoList)
        {
            context.ToDoLists.Update(toDoList);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
