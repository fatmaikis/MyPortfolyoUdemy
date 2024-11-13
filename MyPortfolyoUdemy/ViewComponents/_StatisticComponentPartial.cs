using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _StatisticComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
