using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kariyer_net.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kariyer_net.Controllers
{
    [AllowAnonymous]
    public class RegisterUserController : Controller
    {

        private readonly UserManager<Kullanici> _usermanager; //UserManager identitye ait kayıt olma metodu

        public RegisterUserController(UserManager<Kullanici> userManager)
        {
            _usermanager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel p)
        {
             if(ModelState.IsValid)
            {
                //DOSYA ÇEVİRME İŞLEMİ
                if(p.Cv!=null)
                {
                    var extension = Path.GetExtension(p.Cv.FileName);
                    var newimagename = Guid.NewGuid() + extension;
                    var location = Path.Combine(Directory.GetCurrentDirectory(), "CVFILE/",newimagename);
                    var stream = new FileStream(location, FileMode.Create);
                    p.Cv.CopyTo(stream);

                    Kullanici kullanici = new Kullanici()
                    {
                        Email = p.Mail,
                        UserName = p.UserName,
                        NameSurname = p.NameSurname,
                        Cv = newimagename





                    };

                    var result = await _usermanager.CreateAsync(kullanici, p.Password);

                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Contact");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }
                    }

                }

            }


               

            return View(p);
        }


    }
}

