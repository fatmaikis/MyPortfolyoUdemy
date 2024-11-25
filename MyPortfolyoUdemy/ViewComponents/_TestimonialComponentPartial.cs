﻿using Microsoft.AspNetCore.Mvc;
using MyPortfolyoUdemy.DAL.Context;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _TestimonialComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Testimonials.ToList();
            return View(value);
        }
    }
}
