using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;
using System.Diagnostics;

namespace PieWorkShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IStudentRepository studentRepository)
        {
            _logger = logger;
            this.studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            //var studentsCount = studentRepository.GetStudentsCount();
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