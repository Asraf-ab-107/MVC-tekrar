using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uniqlo_2.Models;

namespace Uniqlo_2.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

    }
}
