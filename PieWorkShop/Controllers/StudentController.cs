using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json; // <<<==========
using PieWorkShop.Models;
using PieWorkShop.ViewModels;
using System.Net.Http.Json;
using System.Security.Claims; // <<== needed for getting user info

// Controller -> (Model)Repository -> AppDbContext -> DataBase

namespace PieWorkShop.Controllers
{
    public class StudentController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IStudentRepository studentRepository; //object for interface i.e Repository
        private readonly IHttpContextAccessor httpContextAccessor;

        string baseAddress;

        //injection of services
        public StudentController(IStudentRepository studentRepository, IHttpContextAccessor httpContextAccessor, IConfiguration configuration) //constructor for Controller
        {
            this.studentRepository = studentRepository; //assign parameter to obj
            this.httpContextAccessor = httpContextAccessor; // <<== needed for getting user info
            this.configuration = configuration;
            this.baseAddress = configuration.GetValue<string>("BaseAddress");
        }
     

        private IEnumerable<Student> GetAllStudent()
        {
            var students = StaticApiData.GetApiData(baseAddress + "GetAll");
            return students.Result;
        }

        public async Task<ViewResult> List() // <<<==========
        {
            //var user = httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier); // <<== needed for getting user info

            // Serialize - c# object to json format
            // Deserialize - json format data into c# object

            //inside controller make object for Custome Class
            //and assign your student and count to property
            //and pass this object to view

            CustomClass customClass = new CustomClass();
            customClass.students = GetAllStudent(); 
            customClass.count = customClass.students.Count();

            // Use Result because return is Task 

            //Dictionary objects in ASP.NET MVC
            //view bag - dynamic read only property object
            //access inside controller inside view(action method)

            var student = GetAllStudent(); //access method in repo using obj
            ViewBag.Count = student.Count();
            TempData["Count"] = student.Count();

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

        public async Task<IActionResult> UpdateStudent(Student student) //PutAsync
        {
            /*changes made here sent to repo
            studentRepository.UpdateStudent(student);*/

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PutAsJsonAsync(baseAddress + "Update", student))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            //telling the mvc where to go next
            return RedirectToAction("List");
        }

        public ViewResult Create()
        {
            return View();
        }

        public async Task<IActionResult> CreateStudent(Student student) //PostAsync
        {
            /*studentRepository.CreateStudent(student);*/

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.PostAsJsonAsync(baseAddress + "Insert", student))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("List");
        }

        public ViewResult Remove(int id3)
        {
            var student = GetAllStudent().FirstOrDefault(student => student.StudentID == id3);
            return View(student);
        }

        public async Task<IActionResult> RemoveStudent(int id)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync(baseAddress + "Delete?studentID=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            /*studentRepository.RemoveStudent(student);*/
            return RedirectToAction("List");
        }

        [Authorize]
        public async Task<ViewResult> ListA()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuA = students.Where(a => a.TeamName == "A");
            ViewBag.CountA = stuA.Count();*/

            var students = StaticApiData.GetApiData(baseAddress + "TeamA");

            CustomClass customClass = new CustomClass();
            customClass.students = students.Result;
            customClass.count = customClass.students.Count();

            return View(customClass);
        }

        [Authorize]
        public async Task<ViewResult> ListB()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuB = students.Where(a => a.TeamName == "B");
            ViewBag.CountB = stuB.Count();*/

            var students = StaticApiData.GetApiData(baseAddress + "TeamB");

            CustomClass customClass = new CustomClass();
            customClass.students = students.Result;
            customClass.count = customClass.students.Count();

            return View(customClass);

        }

        [Authorize]
        public async Task<ViewResult> ListC()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuC = students.Where(a => a.TeamName == "C");
            ViewBag.CountC = stuC.Count();*/

            var students = StaticApiData.GetApiData(baseAddress + "TeamC");

            CustomClass customClass = new CustomClass();
            customClass.students = students.Result;
            customClass.count = customClass.students.Count();

            return View(customClass);   
        }

        [Authorize]
        public async Task<ViewResult> ListD()
        {
            /*var students = studentRepository.GetAllStudents();
            var stuD = students.Where(a => a.TeamName == "D");
            ViewBag.CountD = stuD.Count();*/

            var students = StaticApiData.GetApiData(baseAddress + "TeamD");

            CustomClass customClass = new CustomClass();
            customClass.students = students.Result;
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
        public async Task<ViewResult> ListMale()
        {
            var students = StaticApiData.GetApiData(baseAddress + "Male");

            CustomClass customClass = new CustomClass();
            customClass.students = students.Result;
            customClass.count = customClass.students.Count();

            /*var students = studentRepository.GetAllStudents();
            var stuM = students.
                Where(a => a.Gender == "M").
                OrderBy(a => a.FirstName);
            ViewBag.CountM = stuM.Count();*/

            return View(customClass);
        }

        [Authorize]
        public async Task<ViewResult> ListFemale()
        {
            var students = StaticApiData.GetApiData(baseAddress + "Female");

            CustomClass customClass = new CustomClass();
            customClass.students = students.Result;
            customClass.count = customClass.students.Count();

            /*var students = studentRepository.GetAllStudents();
            var stuF = students.
                Where(a => a.Gender == "F").
                OrderByDescending(a => a.FirstName);
            ViewBag.CountF = stuF.Count();*/

            return View(customClass);
        }

        [Authorize]
        public async Task<ViewResult> ListSName()
        {
            var students = StaticApiData.GetApiData(baseAddress + "NameS");

            CustomClass customClass = new CustomClass();
            customClass.students = students.Result;
            customClass.count = customClass.students.Count();

            /*var stuS = studentRepository.GetAllStudents().
                Where(a => a.FirstName.ToUpper().StartsWith("S")).
                OrderBy(a => a.FirstName);
            ViewBag.CountS = stuS.Count();*/

            return View(customClass);
        }
    }
}
