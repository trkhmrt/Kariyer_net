using System;
using Kariyer_net.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Kariyer_net.ViewComponents.Carousels
{
	public class Carousel:ViewComponent
	{
		
			public IViewComponentResult Invoke()
			{
				Context c = new Context();

				var carousels = c.Carousels.ToList();
					

			       return View(carousels);
			}


		
	}
}

