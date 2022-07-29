using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;
using PieWorkShop.ViewModels;

namespace PieWorkShop.Controllers
{
    public class TeamBController : Controller
    {
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        private readonly IConfiguration configuration;

        string baseAddress;

        public TeamBController(IStudentRepository studentRepository, IConfiguration configuration) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
            this.configuration = configuration;
            this.configuration = configuration;
            this.baseAddress = configuration.GetValue<string>("BaseAddress");
        }
        [Authorize]
        public ViewResult ListB()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuB = students.Where(a => a.TeamName == "B");
            ViewBag.CountB = stuB.Count();
            TempData["CountB"] = stuB.Count();*/

            var students = StaticApiData.GetApiData(baseAddress + "TeamB");

            CustomClass customClass = new CustomClass();
            customClass.students = students.Result;
            customClass.count = customClass.students.Count();

            return View(customClass);
        }
    }
}
