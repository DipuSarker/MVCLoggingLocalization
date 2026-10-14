using Microsoft.AspNetCore.Mvc;
using MVCLoggingLocalization.Models;
using Serilog.Core;
using System.Diagnostics;

namespace MVCLoggingLocalization.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Information: Landing to home page.");
            _logger.LogWarning("Warning: Landing to Warning.");
            _logger.LogError("Error: Landing to Error.");

            return View();
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
