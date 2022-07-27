using System.ComponentModel.DataAnnotations;

namespace StudentAPI.Models
{
    public class Student
    {
        public int StudentID { get; set; }

        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z\s]{1,15}$", ErrorMessage = "Please Enter Valid First Name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z\s]{1,15}$", ErrorMessage = "Please Enter Valid Last Name.")]
        public string LastName { get; set; }

        [RegularExpression(@"^(?:1[8-9]|[2-3][0-6])$", ErrorMessage = "Please Enter Age Between 18-36.")]
        public int Age { get; set; }

        [RegularExpression(@"^[M|F|f|m]$", ErrorMessage = "Enter Either (M)ale Or (F)emale.")]
        public string Gender { get; set; }

        [RegularExpression(@"^[a-dA-D]$", ErrorMessage = "Choose out of: A B C D")]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Display(Name = "Email ID")]
        [StringLength(50)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Enter Valid Email Id.")]
        public string EmailId { get; set; }

        /*[Required(ErrorMessage = "Please provide first name")]
        [StringLength(10, ErrorMessage = "please enter less than 10 characters")]
        [Display(Name = "First Name")]
        [MaxLength(10)]
        [MinLength(2)]
        [RegularExpression()]
        [Compare]
        [DataType]
        [CreditCard]
        [Phone]
        [EmailAddress]
        [RegularExpression("[0-9]")]*/
    }
}
