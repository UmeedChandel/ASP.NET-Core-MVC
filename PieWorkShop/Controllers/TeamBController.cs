using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;
using PieWorkShop.ViewModels;

namespace PieWorkShop.Controllers
{
    public class TeamBController : Controller
    {
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        public TeamBController(IStudentRepository studentRepository) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
        }
        public ViewResult ListB()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuB = students.Where(a => a.TeamName == "B");
            ViewBag.CountB = stuB.Count();
            TempData["CountB"] = stuB.Count();*/

            CustomClass customClass = new CustomClass();
            customClass.students = studentRepository.GetAllStudents().Where(a => a.TeamName == "B");
            customClass.count = customClass.students.Count();

            return View(customClass);
        }
    }
}
