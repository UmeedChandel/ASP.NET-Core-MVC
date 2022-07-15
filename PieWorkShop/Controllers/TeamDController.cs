using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;
using PieWorkShop.ViewModels;

namespace PieWorkShop.Controllers
{
    public class TeamDController : Controller
    {
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        public TeamDController(IStudentRepository studentRepository) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
        }
        public ViewResult ListD()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuD = students.Where(a => a.TeamName == "D");
            ViewBag.CountD = stuD.Count();
            TempData["CountD"] = stuD.Count();*/

            CustomClass customClass = new CustomClass();
            customClass.students = studentRepository.GetAllStudents().Where(a => a.TeamName == "D");
            customClass.count = customClass.students.Count();

            return View(customClass);
        }
    }
}
