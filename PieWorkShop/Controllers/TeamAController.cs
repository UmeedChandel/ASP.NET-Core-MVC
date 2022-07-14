using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;

namespace PieWorkShop.Controllers
{
    public class TeamAController : Controller
    {
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        public TeamAController(IStudentRepository studentRepository) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
        }
        public ViewResult ListA()
        {
            var students = studentRepository.GetAllStudents();
            var stuA = students.Where(a => a.TeamName == "A");
            ViewBag.CountA = stuA.Count();

            TempData["CountA"] = stuA.Count();

            return View(stuA);
        }
    }
}
