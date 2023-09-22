using System;
using Kariyer_net.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Kariyer_net.ViewComponents.Categories
{
	public class Category:ViewComponent
	{
        public IViewComponentResult Invoke()
        {
            Context c = new Context();

            var kategoriler = c.Kategoris.ToList();
           


            return View(kategoriler);
        }
    }
}

