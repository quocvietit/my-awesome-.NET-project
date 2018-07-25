using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using System.Diagnostics;

namespace Web.Controllers
{
    public class TermController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Điều khoản";
            ViewData["Message"] = "Điều khoản sử dụng ứng dụng!";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}