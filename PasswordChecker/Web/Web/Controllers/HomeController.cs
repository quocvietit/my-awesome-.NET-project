using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.Services;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["ShowResult"] = false;
            ViewData["Title"] = "Kiểm tra mật khẩu";

            return View();
        }

        [HttpPost]
        public IActionResult Index(PasswordModel PasswordModel)
        {
            try
            {
                ViewData["ShowResult"] = true;
                CheckTopPassword check = new CheckTopPassword();
                ViewData["result"] = check.Check(PasswordModel.Password);
            }
            catch (Exception)
            {
                ViewData["ShowResult"] = true;
                ViewData["result"] = "Wrong Input Provided.";
            }
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
