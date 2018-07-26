using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.Services;
using Web.Services.Interface;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private ICheckPasswordService _checkPasswordService;

        public HomeController(ICheckPasswordService checkPasswordService)
        {
            _checkPasswordService = checkPasswordService;
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
            
                ViewData["TopPassword"] = message1.Message;
                ViewData["LengthPassword"] = message2.Message;

            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: "+ ex);
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
