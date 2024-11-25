using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyPortfolyoUdemy.DAL.Context;
using MyPortfolyoUdemy.DAL.Entities;
using Newtonsoft.Json.Linq;

namespace MyPortfolyoUdemy.ViewComponents
{
    public class _MessageComponentPartial:ViewComponent
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value = context.Messages.ToList();
            return View(value);
        }
        public IViewComponentResult SendMessage()
        {
            return View(); // Mesaj gönderme formu
        }

        // Mesaj gönderme işlemi: Post metodunda kullanıcıdan alınan veriyi kaydediyoruz.
        [HttpPost]
        public IViewComponentResult SendMessage(Message message)
        {
            if (ModelState.IsValid) // Model doğrulama kontrolü
            {
                context.Messages.Add(message);
                context.SaveChanges(); // Mesajı veritabanına kaydet
                ViewData["MessageSent"] = true; // Mesajın gönderildiğini belirtiyoruz
            }
            else
            {
                ViewData["MessageSent"] = false; // Eğer bir hata varsa
            }

            return ViewBag.sonuc = "----";


        }
    }
}
