using Microsoft.AspNetCore.Mvc;
using PROG6212POE.Models;
using System.Diagnostics;

namespace PROG6212POE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult LandingPage()
        {
            return View();
        }

        public IActionResult LoginOrRegister()
        {
            return View();
        }
    }
}
