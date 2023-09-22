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
    public class AccountController : Controller
    {
        private readonly SignInManager<Kullanici> _signInManager;
        private readonly UserManager<Kullanici> _userManager;

        public AccountController(SignInManager<Kullanici> signInManager,UserManager<Kullanici> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
      

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserSignInViewModel p)
        {
            if(ModelState.IsValid)
            {
                string ad = p.username.GetType().FullName;
                Console.WriteLine(ad);
                var uu = await _userManager.FindByNameAsync(p.username);

                var result = await _signInManager.PasswordSignInAsync(uu,p.password,false,false);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Index","Home");
                }
            }
          


            return View();
        }


        [HttpPost]
        
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync(); // Oturumu sonlandır
            return RedirectToAction("Index", "Contact"); // Başka bir sayfaya yönlendir
        }
    }
}

