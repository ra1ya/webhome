using homework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace homework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Index(double first, double second)

        {
            var model = Tuple.Create(first, second);
            return View(model);

        }
    }
}