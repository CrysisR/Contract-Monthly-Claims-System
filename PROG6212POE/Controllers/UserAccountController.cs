using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PROG6212POE.Areas.Identity.Data;

namespace PROG6212POE.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;

        public UserAccountController(SignInManager<ApplicationUser> signInManager)
        {
            _signInManager = signInManager;
        }
        public IActionResult UserAccountDetails()
        {
            return View();
        }

        public IActionResult UpdateLecturerInformation()
        {
            return View();
        }



    }
}
