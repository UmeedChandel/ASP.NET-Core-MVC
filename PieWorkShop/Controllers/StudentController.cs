using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;

namespace PieWorkShop.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        public StudentController(IStudentRepository studentRepository) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
        }
        public ViewResult List()
        {
            var students = studentRepository.GetAllStudents(); //access method in repo using obj
            return View(students); //pass on to view
        }

        public ViewResult ListA()
        {
            var students = studentRepository.GetAllStudents();
            var stuA = students.Where(a => a.TeamName == "A");
            return View(stuA);
        }
        public ViewResult ListB()
        {
            var students = studentRepository.GetAllStudents();
            var stuB = students.Where(a => a.TeamName == "B");

            return View(stuB);

        }
        public ViewResult ListC()
        {
            var students = studentRepository.GetAllStudents();
            var stuC = students.Where(a => a.TeamName == "C");

            return View(stuC);
        }
        public ViewResult ListD()
        {
            var students = studentRepository.GetAllStudents();
            var stuD = students.Where(a => a.TeamName == "D");

            return View(stuD);
        }

        public ViewResult ListMale()
        {
            var students = studentRepository.GetAllStudents();
            var stuM = students.Where(a => a.Gender == "M");

            return View(stuM);
        }

        public ViewResult ListFemale()
        {
            var students = studentRepository.GetAllStudents();
            var stuF = students.Where(a => a.Gender == "F");

            return View(stuF);
        }

        public ViewResult ListSpoc()
        {
            var spoc = studentRepository.GetAllSpoc();
            return View(spoc);
        }
    }
}
