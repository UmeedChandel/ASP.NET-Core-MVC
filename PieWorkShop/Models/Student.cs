namespace PieWorkShop.Models
{

    //code first approach database second 
    public class Student
    {
        public int StudentID { get; set; } //primary key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string TeamName { get; set; }

    }
}
