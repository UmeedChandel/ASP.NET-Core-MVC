using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/Student")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
                
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAllStudents()
        {
            return Ok(studentRepository.GetAllStudents());
        }

        [HttpGet]
        [Route("GetStudent")]
        public IActionResult GetStudents(int id)
        {
            var student = studentRepository.GetAllStudents().FirstOrDefault(a => a.StudentID == id);
            if (student == null)
            {
                return NotFound("No such student exist");
            }
            return Ok(student);
        }

        [HttpGet]
        [Route("TeamA")]
        public IActionResult TeamA()
        {
            return Ok(studentRepository.GetTeamAStudents());
        }

        [HttpGet]
        [Route("TeamB")]
        public IActionResult TeamB()
        {
            return Ok(studentRepository.GetTeamBStudents());

        }

        [HttpGet]
        [Route("TeamC")]
        public IActionResult TeamC()
        {
            return Ok(studentRepository.GetTeamCStudents());
        }

        [HttpGet]
        [Route("TeamD")]
        public IActionResult TeamD()
        {
            return Ok(studentRepository.GetTeamDStudents());
        }

        [HttpGet]
        [Route("Male")]
        public IActionResult Male()
        {
            return Ok(studentRepository.GetMaleStudents());
        }

        [HttpGet]
        [Route("Female")]
        public IActionResult Female()
        {
            return Ok(studentRepository.GetFemaleStudents());
        }

        [HttpGet]
        [Route("NameS")]
        public IActionResult NameS()
        {
            return Ok(studentRepository.GetStudentsWithS());
        }

        [HttpPost]
        [Route("Insert")]
        public IActionResult Insert(Student student)
        {
            var insertedStudent = studentRepository.InsertStudent(student);
            return Ok(insertedStudent);
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Student student)
        {
            var updatedStudent = studentRepository.UpdateStudent(student);
            return Ok(updatedStudent);
        }

        [HttpPost]
        [Route("Delete")]
        public IActionResult Delete(int studentID)
        {
            var student = studentRepository.GetAllStudents().FirstOrDefault(a => a.StudentID == studentID);
            if (student == null)
            {
                return BadRequest("No such student exist");
            }
            var updatedStudent = studentRepository.DeleteStudent(studentID);
            return Ok(updatedStudent);
        }
    }

}
