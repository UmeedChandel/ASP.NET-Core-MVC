using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PieWorkShop.Models;
using PieWorkShop.ViewModels;

namespace PieWorkShop.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        
        //injection of services
        public StudentController(IStudentRepository studentRepository) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
        }

        private IEnumerable<Student> GetAllStudent()
        {
            return studentRepository.GetAllStudents();
        }


        public ViewResult List()
        {
            //inside controller make object for Custome Class
            //and assign your student and count to property
            //and pass this object to view

            CustomClass customClass = new CustomClass();
            customClass.students = GetAllStudent();
            customClass.count = GetAllStudent().Count();

            //Dictionary objects in ASP.NET MVC
            //view bag - dynamic read only property object
            //access inside controller inside view(action method)

            var students = GetAllStudent(); //access method in repo using obj
            ViewBag.Count = students.Count();

            TempData["Count"] = students.Count();

            return View(customClass); //pass on to view
        }

        //Attribute Routing
        /*[HttpGet]
        [Route("Student/Details/{id1:int}")]*/
        public ViewResult Details(int id1)
        {         
            var student = GetAllStudent().FirstOrDefault(student => student.StudentID == id1);
            return View(student); 
        }

        public ViewResult Edit(int id2)
        {
            //load the data here
            var student = GetAllStudent().FirstOrDefault(student => student.StudentID == id2);
            return View(student);
        }

        // Controller -> (Model)Repository -> AppDbContext -> DataBase

        [HttpPost]
        public IActionResult UpdateStudent(Student student)
        {
            //changes made here sent to repo
            studentRepository.UpdateStudent(student);


            //telling the mvc where to go next
            return RedirectToAction("List");
        }

        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateStudent(Student student)
        {
            studentRepository.CreateStudent(student);
            return RedirectToAction("List");

        }

        public ViewResult Remove(int id3)
        {
            var student = GetAllStudent().FirstOrDefault(student => student.StudentID == id3);
            return View(student);
        }

        public IActionResult RemoveStudent(Student student)
        {
            studentRepository.RemoveStudent(student);
            return RedirectToAction("List");

        }

        [Authorize]
        public ViewResult ListA()
        {

            /*var students = studentRepository.GetAllStudents();
            var stuA = students.Where(a => a.TeamName == "A");
            ViewBag.CountA = stuA.Count();*/

            CustomClass customClass = new CustomClass();
            customClass.students = GetAllStudent().Where(a => a.TeamName.ToUpper() == "A");
            customClass.count = customClass.students.Count();

            return View(customClass);
        }

        [Authorize]
        public ViewResult ListB()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuB = students.Where(a => a.TeamName == "B");
            ViewBag.CountB = stuB.Count();*/

            CustomClass customClass = new CustomClass();
            customClass.students = GetAllStudent().Where(a => a.TeamName.ToUpper() == "B");
            customClass.count = customClass.students.Count();

            return View(customClass);

        }

        [Authorize]
        public ViewResult ListC()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuC = students.Where(a => a.TeamName == "C");
            ViewBag.CountC = stuC.Count();*/

            CustomClass customClass = new CustomClass();
            customClass.students = GetAllStudent().Where(a => a.TeamName.ToUpper() == "C");
            customClass.count = customClass.students.Count();

            return View(customClass);   
        }

        [Authorize]
        public ViewResult ListD()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuD = students.Where(a => a.TeamName == "D");
            ViewBag.CountD = stuD.Count();*/

            CustomClass customClass = new CustomClass();
            customClass.students = GetAllStudent().Where(a => a.TeamName.ToUpper() == "D");
            customClass.count = customClass.students.Count();

            return View(customClass);
        }

        [Authorize]
        public ViewResult ListSpoc()
        {
            CustomClass customClassSpoc = new CustomClass();
            customClassSpoc.students = studentRepository.GetAllSpoc(); 
            customClassSpoc.count = customClassSpoc.students.Count();

            /*var spoc = studentRepository.GetAllSpoc();
            ViewBag.CountSpoc = spoc.Count();*/

            return View(customClassSpoc);
        }

        [Authorize]
        public ViewResult ListMale()
        {
            CustomClass customClassMale = new CustomClass();
            customClassMale.students = studentRepository.
                GetAllStudents().
                Where(a => a.Gender.ToUpper() == "M").
                OrderBy(a => a.FirstName);
            customClassMale.count = customClassMale.students.Count();

            /*var students = studentRepository.GetAllStudents();
            var stuM = students.
                Where(a => a.Gender == "M").
                OrderBy(a => a.FirstName);
            ViewBag.CountM = stuM.Count();*/

            return View(customClassMale);
        }

        [Authorize]
        public ViewResult ListFemale()
        {
            CustomClass customClassFemale = new CustomClass();
            customClassFemale.students = studentRepository.
                GetAllStudents().
                Where(a => a.Gender.ToUpper() == "F").
                OrderByDescending(a => a.FirstName);
            customClassFemale.count = customClassFemale.students.Count();

            /*var students = studentRepository.GetAllStudents();
            var stuF = students.
                Where(a => a.Gender == "F").
                OrderByDescending(a => a.FirstName);
            ViewBag.CountF = stuF.Count();*/

            return View(customClassFemale);
        }

        [Authorize]
        public ViewResult ListSName()
        {
            CustomClass customClassS = new CustomClass();
            customClassS.students = studentRepository.
                GetAllStudents().
                Where(a => a.FirstName.ToUpper().StartsWith("S")).
                OrderBy(a => a.FirstName);
            customClassS.count = customClassS.students.Count();

            /*var stuS = studentRepository.GetAllStudents().
                Where(a => a.FirstName.ToUpper().StartsWith("S")).
                OrderBy(a => a.FirstName);
            ViewBag.CountS = stuS.Count();*/

            return View(customClassS);
        }
    }
}
