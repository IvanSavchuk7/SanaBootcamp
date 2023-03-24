using HelloWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HelloWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("/")]
        public IActionResult SayHello(UserViewModel user)
        {
            if (user.Name == null)
                return View(nameof(Index));

            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}