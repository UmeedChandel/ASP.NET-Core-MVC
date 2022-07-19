using Microsoft.EntityFrameworkCore;

// direact file talking to the database

// Migration file
// created by Microsoft EntityFrameworkCore on CMD PM> add-migration InitialMigration
// create table for model by CMD PM> update-database 


namespace PieWorkShop.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //table
        public DbSet<Student> Students { get; set; }
        /*public DbSet<Student> Spocs { get; set; }*/

        // seeding data to student
        // add-migration SeedingAllDataToStudent
        // update-database

        // OnModelCreating IMPORTANT METHOD

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // seed students
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Student>().HasData(
                new List<Student> {
                new Student{ StudentID= 1,FirstName="Amara",LastName="Sriram",Age=21, Gender="M", TeamName="A" },
                new Student{ StudentID= 2,FirstName="Muskan",LastName="Muskan",Age=20, Gender="F", TeamName="A" },
                new Student{ StudentID= 3,FirstName="Rahul",LastName="Yadav",Age=21, Gender="M", TeamName="A" },
                new Student{ StudentID= 4,FirstName="Shraddha",LastName="Shraddha",Age=20, Gender="F", TeamName="A" },
                new Student{ StudentID= 5,FirstName="Aishwarya",LastName="Verma",Age=20, Gender="F", TeamName="A" },

                new Student{ StudentID= 6,FirstName="Shreya",LastName="Kanoujia",Age=20, Gender="F", TeamName="B" },
                new Student{ StudentID= 7,FirstName="Nandhita",LastName="Rayapati",Age=20, Gender="F", TeamName="B" },
                new Student{ StudentID= 8,FirstName="Shashwat",LastName="Shukla",Age=20, Gender="M", TeamName="B" },
                new Student{ StudentID= 9,FirstName="Siddarth",LastName="Khare",Age=21, Gender="M", TeamName="B" },
                new Student{ StudentID= 10,FirstName="Shriya",LastName="Porwal",Age=20, Gender="F", TeamName="B" },

                new Student{ StudentID= 11,FirstName="Sriram",LastName="",Age=21, Gender="M", TeamName="C" },
                new Student{ StudentID= 12,FirstName="Sneha",LastName="Sinha",Age=20, Gender="F", TeamName="C" },
                new Student{ StudentID= 13,FirstName="Simran",LastName="Singh",Age=20, Gender="F", TeamName="C" },
                new Student{ StudentID= 14,FirstName="Subhash",LastName="Gurjar",Age=21, Gender="M", TeamName="C" },
                new Student{ StudentID= 15,FirstName="Umeed",LastName="Chandel",Age=19, Gender="F", TeamName="C" },

                new Student{ StudentID= 16,FirstName="Vaibhav",LastName="Bhatnagar",Age=21, Gender="M", TeamName="D" },
                new Student{ StudentID= 17,FirstName="Pujitha",LastName="Vavilapalli",Age=20, Gender="F", TeamName="D" },
                new Student{ StudentID= 18,FirstName="Palak",LastName="Soni",Age=20, Gender="F", TeamName="D" },
                new Student{ StudentID= 19,FirstName="Saurabh",LastName="Kumar",Age=21, Gender="M", TeamName="D" },
                new Student{ StudentID= 20,FirstName="Tisha",LastName="Varshney",Age=20, Gender="F", TeamName="D" },
                new Student{ StudentID= 21,FirstName="Aman",LastName="Asati",Age=21, Gender="M", TeamName="D" }
                });

            /*modelBuilder.Entity<Student>().HasData(
                new List<Student> {
                new Student{StudentID= 22 ,FirstName="Rajeev",LastName="Kumar", Gender="M" },
                new Student{StudentID= 23,FirstName="Vikas",LastName="Goel", Gender="M"  },
                new Student{StudentID= 3,FirstName="Mrinalini",LastName="Venkatesh", Gender="F" },
                new Student{StudentID= 4,FirstName="Ria",LastName="Bhalla", Gender="F" },
                new Student{StudentID= 5,FirstName="Ankit",LastName="Verma", Gender="M" },
                new Student{StudentID= 6,FirstName="Ravinder",LastName="kumar", Gender="M" },
                new Student{StudentID= 7,FirstName="Mansi",LastName="Arora", Gender="F" },
                new Student{StudentID= 8,FirstName="Vishal",LastName="Karale", Gender="M" },
                new Student{StudentID= 9,FirstName="Rahul",LastName="Kushwaha", Gender="M" }
            });*/
        }
    }
}
