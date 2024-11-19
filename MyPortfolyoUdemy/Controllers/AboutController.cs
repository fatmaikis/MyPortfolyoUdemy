﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolyoUdemy.DAL.Context;
using MyPortfolyoUdemy.DAL.Entities;

namespace MyPortfolyoUdemy.Controllers
{
	public class AboutController : Controller
	{
		MyPortfolioContext context = new MyPortfolioContext();


		public IActionResult Index()
		{
			var values = context.Abouts.ToList();
			return View(values);
		}
		[HttpGet]
		public IActionResult CreateAbout()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateAbout(About about)
		{
			var values = context.Abouts.Add(about);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult DeleteAbout(int id)
		{
			var values = context.Abouts.Find(id);
			context.Abouts.Remove(values);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult UpdateAbout(int id)
		{
			var values = context.Abouts.Find(id);
			return View(values);
		}
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
			context.Abouts.Update(about);
			context.SaveChanges();
			return RedirectToAction("Index");
        }
    }
}
