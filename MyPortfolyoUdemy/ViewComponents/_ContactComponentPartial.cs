using Microsoft.AspNetCore.Mvc;
using MyPortfolyoUdemy.DAL.Context;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Contacts.ToList();
            return View(value);
        }
    }
}
