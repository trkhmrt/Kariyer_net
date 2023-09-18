using System;
using Kariyer_net.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Kariyer_net.ViewComponents.Testimonials
{
	public class Testimonial:ViewComponent
	{

		public IViewComponentResult Invoke()
		{
			Context c = new Context();
			var yazilar = c.Referances.ToList();

			return View(yazilar);
		}


		
	}
}

