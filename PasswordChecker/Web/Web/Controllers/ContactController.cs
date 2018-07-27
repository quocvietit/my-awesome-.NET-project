using Microsoft.AspNetCore.Mvc;
using Web.Models;
using System.Diagnostics;

namespace Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Liên Hệ";
            ViewData["Message"] = "Mọi chi tiết vui lòng liên hệ:";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}