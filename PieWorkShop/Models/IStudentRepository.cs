namespace PieWorkShop.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetAllSpoc();
        StudentsCount GetStudentsCount();
        int UpdateStudent(Student student);
        int CreateStudent(Student student);
        int RemoveStudent(Student student);

    }
}
