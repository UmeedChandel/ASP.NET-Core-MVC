
namespace PieWorkShop.Models
{
    public class StudentRepository : IStudentRepository
    {
        //implementation of IStudentRepository Interface Method
        public IEnumerable<Student> GetAllStudents()
        {
            List<Student> students = new List<Student> {
                new Student{FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
                new Student{FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
                new Student{FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
                new Student{FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
                new Student{FirstName="Aishwarya",LastName="Verma",Age=20, Gender="F", TeamName="A" },

                new Student{FirstName="Shreya",LastName="Kanoujia",Age=20, Gender="F", TeamName="B" },
                new Student{FirstName="Nandhita",LastName="Rayapati",Age=20, Gender="F", TeamName="B" },
                new Student{FirstName="Shashwat",LastName="Shukla",Age=20, Gender="M", TeamName="B" },
                new Student{FirstName="Siddarth",LastName="Khare",Age=21, Gender="M", TeamName="B" },
                new Student{FirstName="Shriya",LastName="Porwal",Age=20, Gender="F", TeamName="B" },

                new Student{FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
                new Student{FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
                new Student{FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
                new Student{FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
                new Student{FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },

                new Student{FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" },
                new Student{FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
                new Student{FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
                new Student{FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
                new Student{FirstName="Tisha",LastName="Varshney",Age=20, Gender="F", TeamName="D" },
                new Student{FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" }
                };

            return students;
        }
        public IEnumerable<Student> GetAllSpoc()
        {
            List<Student> spoc = new List<Student> {
                new Student{FirstName="Rajeev",LastName="Kumar", Gender="M" },
                new Student{FirstName="Vikas",LastName="Goel", Gender="M"  },
                new Student{FirstName="Mrinalini",LastName="Venkatesh", Gender="F" },
                new Student{FirstName="Ria",LastName="Bhalla", Gender="F" },
                new Student{FirstName="Ankit",LastName="Verma", Gender="M" },
                new Student{FirstName="Ravinder",LastName="kumar", Gender="M" },
                new Student{FirstName="Mansi",LastName="Arora", Gender="F" },
                new Student{FirstName="Vishal",LastName="Karale", Gender="M" },
                new Student{FirstName="Rahul",LastName="Kushwaha", Gender="M" }
            };
            return spoc;
        }

        public StudentsCount GetStudentsCount()
        {
            var studentsCount = new StudentsCount();
            studentsCount.Count = GetAllStudents().Count();
            studentsCount.CountA = GetAllStudents().Where(a => a.TeamName == "A").Count();
            studentsCount.CountB = GetAllStudents().Where(a => a.TeamName == "B").Count();
            studentsCount.CountC = GetAllStudents().Where(a => a.TeamName == "C").Count();
            studentsCount.CountD = GetAllStudents().Where(a => a.TeamName == "D").Count();

            return studentsCount;
        }
    }
}
