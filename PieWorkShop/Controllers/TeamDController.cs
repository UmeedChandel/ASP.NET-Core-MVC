using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;
using PieWorkShop.ViewModels;

namespace PieWorkShop.Controllers
{
    public class TeamDController : Controller
    {
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        private readonly IConfiguration configuration;

        string baseAddress;

        public TeamDController(IStudentRepository studentRepository, IConfiguration configuration) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
            this.configuration = configuration;
            this.configuration = configuration;
            this.baseAddress = configuration.GetValue<string>("BaseAddress");
        }

        [Authorize]
        public ViewResult ListD()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuD = students.Where(a => a.TeamName == "D");
            ViewBag.CountD = stuD.Count();
            TempData["CountD"] = stuD.Count();*/

            var students = StaticApiData.GetApiData(baseAddress + "TeamD");

            CustomClass customClass = new CustomClass();
            customClass.students = students.Result;
            customClass.count = customClass.students.Count();

            return View(customClass);
        }
    }
}
