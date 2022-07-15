namespace PieWorkShop.Models
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        IEnumerable<Student> GetAllSpoc();

        //StudentsCount GetStudentsCount();

    }
}
