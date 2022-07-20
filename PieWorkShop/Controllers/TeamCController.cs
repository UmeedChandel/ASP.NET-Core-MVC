using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;
using PieWorkShop.ViewModels;

namespace PieWorkShop.Controllers
{
    public class TeamCController : Controller
    {
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        public TeamCController(IStudentRepository studentRepository) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
        }
        public ViewResult ListC()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuC = students.Where(a => a.TeamName == "C");
            ViewBag.CountC = stuC.Count();
            TempData["CountC"] = stuC.Count();*/

            CustomClass customClass = new CustomClass();
            customClass.students = studentRepository.GetAllStudents().Where(a => a.TeamName.ToUpper() == "C");
            customClass.count = customClass.students.Count();

            return View(customClass);
        }
    }
}
