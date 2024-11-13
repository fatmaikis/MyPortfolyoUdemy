using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _HeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
