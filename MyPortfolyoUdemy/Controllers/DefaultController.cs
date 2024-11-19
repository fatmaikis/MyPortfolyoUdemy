using Microsoft.AspNetCore.Mvc;
using MyPortfolyoUdemy.DAL.Context;
using MyPortfolyoUdemy.DAL.Entities;

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
