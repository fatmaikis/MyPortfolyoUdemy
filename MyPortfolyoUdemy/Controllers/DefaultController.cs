using Microsoft.AspNetCore.Mvc;

namespace MyPortfolyoUdemy.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
