using Microsoft.AspNetCore.Mvc;
using Web.Models;
using System.Diagnostics;

namespace Web.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Giới Thiệu";
            ViewData["Message"] = "Mô tả ứng dụng:";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}