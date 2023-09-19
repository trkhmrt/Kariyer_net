using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kariyer_net.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kariyer_net.Controllers
{
    public class AdminController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetIlanlar()
        {

          

            return View();
        }
        [HttpGet]
        public IActionResult GetIlanlar(int id)
        {
            

            Context c = new Context();

            var ilan = c.Ilans.FirstOrDefault(i => i.IlanID == id);

            if(ilan!=null)
            {
                c.Ilans.Remove(ilan);
                c.SaveChanges();
                return RedirectToAction("Index");
            }




            var ilanlar = c.Ilans.Include(k => k.Kategori).ToList();


            return View(ilanlar);
        }

        [HttpGet]
        public IActionResult AdminIlanDetay(int id)
        {
            Context c = new Context();

            var ilandetay = c.Ilans.Include(k => k.Kategori).FirstOrDefault(i => i.IlanID == id);

            return View(ilandetay);
        }

        [HttpPost]
        public IActionResult AdminIlanDetay(int id,string aciklama,string firma)
        {

            Context c = new Context();

            var ilan = c.Ilans.FirstOrDefault(i => i.IlanID == id);
            if(ilan!=null)
            {
                ilan.Firma = firma;
                ilan.IlanAciklama = aciklama;
                c.SaveChanges();
                return RedirectToAction("GetIlanlar");
            }

            return View();
        }

        [HttpGet]
        public IActionResult AdminCarousel()
        {
            Context c = new Context();
            var carousels = c.Carousels.ToList();

            return View(carousels);
        }
        [HttpPost]
        public IActionResult AdminCarousel(int id,string baslik,string aciklama,string fotourl)
        {
            Context c = new Context();
            var carousel = c.Carousels.FirstOrDefault(c => c.CaroueselID == id);
            if(carousel!=null)
            {
                carousel.CarouselAciklama = aciklama;
                carousel.CarouselBaslik = baslik;
                carousel.CarouselFotoUrl = fotourl;
                c.SaveChanges();
                return RedirectToAction("AdminCarousel");
            }



            return View();
        }

    }
}

