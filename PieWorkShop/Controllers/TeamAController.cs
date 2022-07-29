using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;
using PieWorkShop.ViewModels;

namespace PieWorkShop.Controllers
{
    public class TeamAController : Controller
    {
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        private readonly IConfiguration configuration;

        string baseAddress;

        public TeamAController(IStudentRepository studentRepository, IConfiguration configuration) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
            this.configuration = configuration;
            this.configuration = configuration;
            this.baseAddress = configuration.GetValue<string>("BaseAddress");
        }

        [Authorize]
        public ViewResult ListA()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuA = students.Where(a => a.TeamName == "A");
            ViewBag.CountA = stuA.Count();
            TempData["CountA"] = stuA.Count();*/

            var students = StaticApiData.GetApiData(baseAddress + "TeamA");

            CustomClass customClass = new CustomClass();
            customClass.students = students.Result;
            customClass.count = customClass.students.Count();

            return View(customClass);
        }
    }
}
