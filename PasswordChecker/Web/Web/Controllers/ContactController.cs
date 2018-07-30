using Microsoft.AspNetCore.Mvc;
using Web.Models;
using System.Diagnostics;
using Web.Utils;

namespace Web.Controllers
{
    public class ContactController : Controller
    {
        public ContactController()
        {
        }

        public IActionResult Index()
        {
            ViewData["Title"] = Contants.Title.CONTRACT;
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}