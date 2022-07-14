using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;

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
            var students = studentRepository.GetAllStudents();
            var stuD = students.Where(a => a.TeamName == "D");
            ViewBag.CountD = stuD.Count();

            TempData["CountD"] = stuD.Count();

            return View(stuD);
        }
    }
}
