using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;

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
            var students = studentRepository.GetAllStudents();
            var stuC = students.Where(a => a.TeamName == "C");
            return View(stuC);
        }
    }
}
