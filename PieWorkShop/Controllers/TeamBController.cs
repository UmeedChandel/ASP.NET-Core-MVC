using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;

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
            var students = studentRepository.GetAllStudents();
            var stuB = students.Where(a => a.TeamName == "B");
            return View(stuB);
        }
    }
}
