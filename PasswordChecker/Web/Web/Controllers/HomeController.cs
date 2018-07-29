using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.Services.Interface;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private ICheckPasswordService _checkPasswordService;
        private IAnalysisPasswordService _analysisPasswordService;

        public HomeController(ICheckPasswordService checkPasswordService,
            IAnalysisPasswordService analysisPasswordService)
        {
            _checkPasswordService = checkPasswordService;
            _analysisPasswordService = analysisPasswordService;
        }

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
                string password = PasswordModel.Password;
                ViewBag.Result = "<p>ahihi</p><br/><p>Ahihi</p>";

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
                ViewData["ShowResult"] = true;
                ViewData["result"] = "Có vẻ đã xảy ra lỗi";
            }
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
