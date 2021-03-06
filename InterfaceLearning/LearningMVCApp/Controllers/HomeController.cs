using BusinessLogic;
using LearningMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LearningMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataDriver dataDriver;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            dataDriver = new TextFileDataDriver();
        }

        public IActionResult Index()
        {
            var model = new HomePageViewModel()
            {
                WelcomeMessage = $"Welcome to your new home {dataDriver.GetUsers().ToArray()[0]}"
            };
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}