using Microsoft.AspNetCore.Mvc;
using MyPortfolyoUdemy.DAL.Context;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _PortfolioComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Portfolios.ToList();
            return View(value);
        }
    }
}
