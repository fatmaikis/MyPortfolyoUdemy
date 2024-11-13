using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
