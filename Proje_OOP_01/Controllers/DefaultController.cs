using Microsoft.AspNetCore.Mvc;
using Proje_OOP_01.Ornekler;

namespace Proje_OOP_01.Controllers
{
    public class DefaultController : Controller
    {
        void mesajlar()
        {
            ViewBag.m1 = "Merhaba bu bir core projesidir....";
            ViewBag.m2 = "Merhaba çok iyi bir projeye benziyor...";
            ViewBag.m3 = "Hello word. I am Asp.Net.Core...";
        }
        public IActionResult Index()
        {
            mesajlar();
            return View();
        }
        public IActionResult Urunler()
        {
            mesajlar();
            ViewBag.t = topla();
            return View();
        }

        int topla()
        {
            int s1 = 20;
            int s2 = 30;
            int toplam = s1 + s2;
            return toplam;
        }
        public IActionResult Deneme() 
        {
            Sehirler sehirler = new Sehirler();

            sehirler.Ad = "Kiev";
            sehirler.Nufus = 100000;
            sehirler.Id = 1;
            sehirler.Ulke = "Ukrayna";
            sehirler.Renk1 = "Sarı";
            sehirler.Renk2 = "Kırmızı";
            sehirler.Renk3 = "Mavi";
            ViewBag.v1 = sehirler.Id;
            ViewBag.v2=sehirler.Ulke;
            ViewBag.v3=sehirler.Ad;
            ViewBag.v4=sehirler.Nufus;
            ViewBag.v5=sehirler.Renk1;
            ViewBag.v6=sehirler.Renk2;
            ViewBag.v7=sehirler.Renk3;

            return View();
        }
    }
}
