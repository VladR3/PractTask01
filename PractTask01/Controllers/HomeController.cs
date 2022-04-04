using Microsoft.AspNetCore.Mvc;
using PractTask01.Models;
using System.Diagnostics;

namespace PractTask01.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new UserModel());
        }

        [HttpPost]
        public IActionResult Welcome(UserModel user)
        {
            return View(user);
        }
    }
}