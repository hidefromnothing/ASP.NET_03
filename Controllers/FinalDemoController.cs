using Microsoft.AspNetCore.Mvc;

namespace FinalReview.Controllers
{
    public class FinalDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // About us => About
        public IActionResult About()   // About.cshtml
        {
            return View();
        }

        // Contact us => Contact
        public IActionResult Contact()  // Contact.cshtml
        {
            return View();
        }

        // List of products
       


    }
}
