namespace StudentAPI.Models
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext appDbContext;
        public StudentRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var students = appDbContext.Students;
            return students;
        }

        public IEnumerable<Student> GetFemaleStudents()
        {
            return GetAllStudents().Where(a => a.Gender.ToLower() == "f");
        }

        public IEnumerable<Student> GetMaleStudents()
        {
            return GetAllStudents().Where(a => a.Gender.ToLower() == "m");
        }

        public IEnumerable<Student> GetStudentsWithS()
        {
            return GetAllStudents().Where(a => a.FirstName.ToUpper().StartsWith("S"));
        }

        public IEnumerable<Student> GetTeamAStudents()
        {
            return GetAllStudents().Where(a => a.TeamName.ToUpper() == "A");
        }

        public IEnumerable<Student> GetTeamBStudents()
        {
            return GetAllStudents().Where(a => a.TeamName.ToUpper() == "B"); 
        }

        public IEnumerable<Student> GetTeamCStudents()
        {
            return GetAllStudents().Where(a => a.TeamName.ToUpper() == "C"); 
        }

        public IEnumerable<Student> GetTeamDStudents()
        {
            return GetAllStudents().Where(a => a.TeamName.ToUpper() == "D"); 
        }

        public Student InsertStudent(Student students)
        {
            //remove the studentID
            var entry = appDbContext.Students.Add(students);
            appDbContext.SaveChanges();
            return entry.Entity;
        }
        public Student UpdateStudent(Student students)
        {
            var entry = appDbContext.Students.Update(students);
            appDbContext.SaveChanges();
            return entry.Entity;
        }
        public Student DeleteStudent(int studentID)
        {
            var student = GetAllStudents().FirstOrDefault(a => a.StudentID == studentID);
            var entry = appDbContext.Students.Remove(student);
            appDbContext.SaveChanges();
            return entry.Entity;
        }
    }
}
