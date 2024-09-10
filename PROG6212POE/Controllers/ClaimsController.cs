using Microsoft.AspNetCore.Mvc;
using PROG6212POE.Areas.Identity.Data;
using PROG6212POE.Models;

namespace PROG6212POE.Controllers
{
    public class ClaimsController : Controller
    {
        //variables for db and hosting
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        //ctor
        public ClaimsController(ApplicationDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }

        //http get
        [HttpGet]
        public IActionResult CreateClaim()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        //http post
        [HttpPost]
        public async Task<IActionResult> ClaimSubmitted(Claims claims)
        {
            if (ModelState.IsValid)
            {
                //do a calculation
                //draw a toaster (n.b Not the actual kitchen applicance, more like the notification that
                //pops up when an action is done, which has a smooth animation and a timer line underneath
                //it that goes down and when it reaches zero it goes away in a nice animation.
                //This shouldnt be my job, but the job of the css team but for some reason im the judge, jury
                //and executioner for this entire application, so it is up to me to do this toaster thingy
                //btw, why is it called a toaster, all i think about is delious toast that i wanna eat atm,
                //but nope, it refers to a NOTIFICATION on a WEBSITE, like wtf, be clear.)
                claims.TotalAmount = claims.HoursWorked * claims.RatePerHour;
                //part 2
                //_context.Add(claims);
                //await _context.SaveChangesAsync();
                TempData["message"] = "Claim submitted successfully";
                return RedirectToAction("LandingPage", "Home"); //after your claim
            }
            else
            {
                TempData["message"] = "Error! One of more fields are blank or incorrectly formatted";
                return View(claims);
            }
        }

        public IActionResult ClaimSubmitted()
        {
            return View();
        }


        public IActionResult ListLecturerClaims()
        {
            return View();
        }

        public IActionResult AllClaims()
        {
            return View();
        }

        public async Task<IActionResult> ApproveClaim()
        {
            TempData["message"] = "Claim approved successfully!";
            return RedirectToAction("AllClaims", "Claims");
        }

        public async Task<IActionResult> DenyClaim()
        {
            TempData["errormessage"] = "Claim denied!";
            return RedirectToAction("AllClaims", "Claims");
        }
    }
}
