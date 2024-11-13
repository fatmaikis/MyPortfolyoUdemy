using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
