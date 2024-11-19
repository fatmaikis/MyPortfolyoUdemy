using Microsoft.AspNetCore.Mvc;
using MyPortfolyoUdemy.DAL.Context;
using MyPortfolyoUdemy.DAL.Entities;

namespace MyPortfolyoUdemy.Controllers
{
    public class ContactController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
             
        public IActionResult Index()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }
        [HttpGet]
        public IActionResult CreateContact ()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateContact(Contact contact)
        {
            var value = context.Contacts.Add(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult DeleteContact(int id )
        {
            var value = context.Contacts.Find(id);
            context.Contacts.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet] 
        public IActionResult UpdateContact(int id)
        {
            var value = context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            var value = context.Contacts.Update(contact);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
