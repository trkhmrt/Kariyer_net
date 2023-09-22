using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kariyer_net.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kariyer_net.Controllers
{
    public class JobListController : Controller
    {
        // GET: /<controller>/
        [Authorize]
        public IActionResult Index(int id)
        {

            Context c = new Context();
            var ilanlar = c.Ilans.Include(k => k.Kategori).Where(k=>k.KategoriID == id).ToList();

            



            return View(ilanlar);
        }
    }
}

