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

                MessageModel message1 = _checkPasswordService.GetResultCheckTopPassword(password);
                MessageModel message2 = _checkPasswordService.GetResultCheckLengthPassword(password);
                MessageModel message3 = _analysisPasswordService.BruteForceSearchSpace(password);

                ViewData["TopPassword"] = message1.Message;
                ViewData["LengthPassword"] = message2.Message;
                ViewData["Time"] = message3.Message;

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
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
