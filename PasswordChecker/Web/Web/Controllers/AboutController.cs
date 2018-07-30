using Microsoft.AspNetCore.Mvc;
using Web.Models;
using System.Diagnostics;
using Web.Utils;

namespace Web.Controllers
{
    public class AboutController : Controller
    {
        public AboutController()
        {
        }

        public IActionResult Index()
        {
            ViewData["Title"] = Contants.Title.ABOUT;
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}