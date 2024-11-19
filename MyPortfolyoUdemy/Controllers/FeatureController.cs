using Microsoft.AspNetCore.Mvc;
using MyPortfolyoUdemy.DAL.Context;
using MyPortfolyoUdemy.DAL.Entities;

namespace MyPortfolyoUdemy.Controllers
{
    public class FeatureController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            var value = context.Features.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult CreateFeature()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateFeature(Feature feature)
        {
            var value = context.Features.Add(feature);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteFeature(int id)
        {
            var value = context.Features.Find(id);
            context.Features.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateFeature(int id)
        {
            var value = context.Features.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateFeature(Feature feature)
        {
            var value = context.Features.Update(feature);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
