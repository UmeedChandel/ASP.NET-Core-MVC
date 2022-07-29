using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;
using PieWorkShop.ViewModels;

namespace PieWorkShop.Controllers
{
    public class TeamCController : Controller
    {
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        private readonly IConfiguration configuration;

        string baseAddress;

        public TeamCController(IStudentRepository studentRepository, IConfiguration configuration) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
            this.configuration = configuration;
            this.configuration = configuration;
            this.baseAddress = configuration.GetValue<string>("BaseAddress");
        }

        [Authorize]
        public ViewResult ListC()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuC = students.Where(a => a.TeamName == "C");
            ViewBag.CountC = stuC.Count();
            TempData["CountC"] = stuC.Count();*/

            var students = StaticApiData.GetApiData(baseAddress + "TeamC");

            CustomClass customClass = new CustomClass();
            customClass.students = students.Result;
            customClass.count = customClass.students.Count();

            return View(customClass);
        }
    }
}
