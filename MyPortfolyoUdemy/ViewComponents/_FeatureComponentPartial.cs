using Microsoft.AspNetCore.Mvc;
using MyPortfolyoUdemy.DAL.Context;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
