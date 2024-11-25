using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MyPortfolyoUdemy.DAL.Context;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _SocialMediaComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.SocialMedias.ToList();
            return View(value);
        } 
    }
}
