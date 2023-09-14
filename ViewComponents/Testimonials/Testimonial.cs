using System;
using Microsoft.AspNetCore.Mvc;

namespace Kariyer_net.ViewComponents.Testimonials
{
	public class Testimonial:ViewComponent
	{

		public IViewComponentResult Invoke()
		{

			return View();
		}


		
	}
}

