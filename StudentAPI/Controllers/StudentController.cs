using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    [ApiController]
    [Route("api/Student")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository studentRepository;
        private readonly IMapper mapper;
        public StudentController(IStudentRepository studentRepository, IMapper mapper)
        {
            this.studentRepository = studentRepository;
            this.mapper = mapper;                
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAllStudents()
        {
            try
            {
                var students = studentRepository.GetAllStudents();      
                //var miniStudent = mapper.Map<StudentMini[]>(students); 
                // mapper.Map<Destination[]>(Source);

                return Ok(students);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }         
        }

        [HttpGet("{id}", Name="GetStudent")]
        public ActionResult<Student> GetStudent(int id = 15)
        {
            try
            {
                var student = studentRepository.GetAllStudents().FirstOrDefault(a => a.StudentID == id); // 6 properties
                if (student == null)
                {
                    return NotFound("No such student exist");
                }
                var miniStudent = mapper.Map<StudentMini>(student);  // 3 properties
                return Ok(miniStudent);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }           
        }

        [HttpGet]
        [Route("TeamA")]
        public IActionResult TeamA()
        {
            try
            {
                return Ok(studentRepository.GetTeamAStudents());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }            
        }

        [HttpGet]
        [Route("TeamB")]
        public IActionResult TeamB()
        {
            try
            {
                return Ok(studentRepository.GetTeamBStudents());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpGet]
        [Route("TeamC")]
        public IActionResult TeamC()
        {
            try
            {
                return Ok(studentRepository.GetTeamCStudents());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }         
        }

        [HttpGet]
        [Route("TeamD")]
        public IActionResult TeamD()
        {
            try
            {
                return Ok(studentRepository.GetTeamDStudents());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }           
        }

        [HttpGet]
        [Route("Male")]
        public IActionResult Male()
        {
            try
            {
                return Ok(studentRepository.GetMaleStudents());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }   
        }

        [HttpGet]
        [Route("Female")]
        public IActionResult Female()
        {
            try
            {
                return Ok(studentRepository.GetFemaleStudents());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }         
        }

        [HttpGet]
        [Route("NameS")]
        public IActionResult NameS()
        {
            try
            {
                return Ok(studentRepository.GetStudentsWithS());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }           
        }

        [HttpPost]
        [Route("Insert")]
        public IActionResult Insert(Student student)
        {
            try
            {
                var insertedStudent = studentRepository.InsertStudent(student);
                return CreatedAtRoute("GetStudent", new { id = insertedStudent.StudentID }, insertedStudent);
                //Ok(insertedStudent);

            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }           
        }

        [HttpPut]
        [Route("Update")]
        public IActionResult Update(Student student)
        {
            try
            {
                var updatedStudent = studentRepository.UpdateStudent(student);
                return CreatedAtRoute("GetStudent", new { id = updatedStudent.StudentID }, updatedStudent);
                //Ok(updatedStudent);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete(int studentID)
        {
            try
            {
                var student = studentRepository.GetAllStudents().FirstOrDefault(a => a.StudentID == studentID);
                if (student == null)
                {
                    return BadRequest("No such student exist");
                }
                var updatedStudent = studentRepository.DeleteStudent(studentID);
                return Ok(updatedStudent);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Server Error");
            }
        }
    }

}
