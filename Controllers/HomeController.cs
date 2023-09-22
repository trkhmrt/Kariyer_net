using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Kariyer_net.Models;
using Microsoft.AspNetCore.Authorization;

namespace Kariyer_net.Controllers;

public class HomeController : Controller
{

    [AllowAnonymous]
    public IActionResult Index()
    {

        var user = User.Identity.Name;
        ViewBag.veri = user;

        return View();
    }

    
}

