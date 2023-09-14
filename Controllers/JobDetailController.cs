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
    public class JobDetailController : Controller
    {
        Context c = new Context();
        // GET: /<controller>/
        public IActionResult Index(int id)
        {
            var ilandetay = c.Ilans.Include(k=>k.Kategori).FirstOrDefault(i=>i.IlanID==id);



            return View(ilandetay);
        }
    }
}

