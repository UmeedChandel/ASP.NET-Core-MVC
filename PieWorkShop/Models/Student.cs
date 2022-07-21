using System.ComponentModel.DataAnnotations;

namespace PieWorkShop.Models
{

    //code first approach database second 
    public class Student
    {
        public int StudentID { get; set; } //primary key

        // Annotations 
        // attributes used to decorate
        // extra functionality to your property

        [Display(Name = "First Name")]
        [RegularExpression(@"^[a-zA-Z\s]{1,15}$",ErrorMessage ="Please Enter Valid First Name.")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [RegularExpression(@"^[a-zA-Z\s]{1,15}$", ErrorMessage = "Please Enter Valid Last Name.")]
        public string LastName { get; set; }

        [Range(18,36)]
        [Required(ErrorMessage ="Enter Age Between 18 to 36.")]
        [RegularExpression(@"^(?:1[8-9]|[2-3][0-6])$", ErrorMessage = "Please Enter Age Between 18-36.")]
        public int Age { get; set; }

        [StringLength(1)]
        [RegularExpression(@"^[M|F|f|m]$", ErrorMessage = "Enter Either (M)ale Or (F)emale.")]
        public string Gender { get; set; }

        [RegularExpression(@"^[a-dA-D]$", ErrorMessage = "Choose out of: A B C D")]
        [Display(Name = "Team Name")]
        public string TeamName { get; set; }

        [Display(Name = "Email Id")]
        [StringLength(50)]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Enter Valid Email Id.")]
        public string EmailId { get; set; } 

    }
}
