using System;
using Kariyer_net.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kariyer_net.ViewComponents.Jobs
{

	//ViewComponent classı bizim oluşturduğumuz bir class değil.Asp.netCore yapısının kendisine ait olan bir yapısı.
	public class Job:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			Context c = new Context();

			var isler = c.Ilans.Include(k=>k.Kategori).ToList();


			return View(isler);
		}


	}
}

