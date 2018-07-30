using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Web.Models;
using Web.Services.Interface;
using Web.Utils;

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
            ViewData["Title"] = Contants.Title.HOME;
            return View();
        }

        [HttpPost]
        public IActionResult Index(ViewModel viewModel)
        {
            ViewData["Title"] = Contants.Title.HOME;

            ResultModel resultModel = new ResultModel();
            RecommendModel recommendModel = new RecommendModel();

            try
            {
                string password = viewModel.PasswordModel.Password;

                resultModel = _checkPasswordService.GetResult(password);
                recommendModel = _checkPasswordService.GetRecommend();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex);
                resultModel.Error = Contants.Message.Result.ERROR;
            }

            viewModel.ResultModel = resultModel;
            viewModel.RecommendModel = recommendModel;

            return View(viewModel);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
