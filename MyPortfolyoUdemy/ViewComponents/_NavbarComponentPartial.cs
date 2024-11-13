using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _NavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
