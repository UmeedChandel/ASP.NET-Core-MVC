using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;
using PieWorkShop.ViewModels;

namespace PieWorkShop.Controllers
{
    public class TeamAController : Controller
    {
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        public TeamAController(IStudentRepository studentRepository) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
        }

        [Authorize]
        public ViewResult ListA()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuA = students.Where(a => a.TeamName == "A");
            ViewBag.CountA = stuA.Count();
            TempData["CountA"] = stuA.Count();*/

            CustomClass customClass = new CustomClass();
            customClass.students = studentRepository.GetAllStudents().Where(a => a.TeamName.ToUpper() == "A");
            customClass.count = customClass.students.Count();

            return View(customClass);
        }
    }
}
