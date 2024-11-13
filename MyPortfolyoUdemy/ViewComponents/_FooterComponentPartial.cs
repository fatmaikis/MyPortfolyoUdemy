using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _FooterComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
