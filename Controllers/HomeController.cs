using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Kariyer_net.Models;

namespace Kariyer_net.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {

        return View();
    }

    
}

