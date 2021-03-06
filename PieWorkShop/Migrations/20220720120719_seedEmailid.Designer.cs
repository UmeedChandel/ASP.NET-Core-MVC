// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PieWorkShop.Models;

#nullable disable

namespace PieWorkShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220720120719_seedEmailid")]
    partial class seedEmailid
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PieWorkShop.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(1)
                        .HasColumnType("nvarchar(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasMaxLength(3)
                        .HasColumnType("nvarchar(3)");

                    b.HasKey("StudentID");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            Age = 21,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Amara",
                            Gender = "M",
                            LastName = "Sriram",
                            TeamName = "A"
                        },
                        new
                        {
                            StudentID = 2,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Muskan",
                            Gender = "F",
                            LastName = "Muskan",
                            TeamName = "A"
                        },
                        new
                        {
                            StudentID = 3,
                            Age = 21,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Rahul",
                            Gender = "M",
                            LastName = "Yadav",
                            TeamName = "A"
                        },
                        new
                        {
                            StudentID = 4,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Shraddha",
                            Gender = "F",
                            LastName = "Shraddha",
                            TeamName = "A"
                        },
                        new
                        {
                            StudentID = 5,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Aishwarya",
                            Gender = "F",
                            LastName = "Verma",
                            TeamName = "A"
                        },
                        new
                        {
                            StudentID = 6,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Shreya",
                            Gender = "F",
                            LastName = "Kanoujia",
                            TeamName = "B"
                        },
                        new
                        {
                            StudentID = 7,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Nandhita",
                            Gender = "F",
                            LastName = "Rayapati",
                            TeamName = "B"
                        },
                        new
                        {
                            StudentID = 8,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Shashwat",
                            Gender = "M",
                            LastName = "Shukla",
                            TeamName = "B"
                        },
                        new
                        {
                            StudentID = 9,
                            Age = 21,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Siddarth",
                            Gender = "M",
                            LastName = "Khare",
                            TeamName = "B"
                        },
                        new
                        {
                            StudentID = 10,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Shriya",
                            Gender = "F",
                            LastName = "Porwal",
                            TeamName = "B"
                        },
                        new
                        {
                            StudentID = 11,
                            Age = 21,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Sriram",
                            Gender = "M",
                            LastName = "",
                            TeamName = "C"
                        },
                        new
                        {
                            StudentID = 12,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Sneha",
                            Gender = "F",
                            LastName = "Sinha",
                            TeamName = "C"
                        },
                        new
                        {
                            StudentID = 13,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Simran",
                            Gender = "F",
                            LastName = "Singh",
                            TeamName = "C"
                        },
                        new
                        {
                            StudentID = 14,
                            Age = 21,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Subhash",
                            Gender = "M",
                            LastName = "Gurjar",
                            TeamName = "C"
                        },
                        new
                        {
                            StudentID = 15,
                            Age = 19,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Umeed",
                            Gender = "F",
                            LastName = "Chandel",
                            TeamName = "C"
                        },
                        new
                        {
                            StudentID = 16,
                            Age = 21,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Vaibhav",
                            Gender = "M",
                            LastName = "Bhatnagar",
                            TeamName = "D"
                        },
                        new
                        {
                            StudentID = 17,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Pujitha",
                            Gender = "F",
                            LastName = "Vavilapalli",
                            TeamName = "D"
                        },
                        new
                        {
                            StudentID = 18,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Palak",
                            Gender = "F",
                            LastName = "Soni",
                            TeamName = "D"
                        },
                        new
                        {
                            StudentID = 19,
                            Age = 21,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Saurabh",
                            Gender = "M",
                            LastName = "Kumar",
                            TeamName = "D"
                        },
                        new
                        {
                            StudentID = 20,
                            Age = 20,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Tisha",
                            Gender = "F",
                            LastName = "Varshney",
                            TeamName = "D"
                        },
                        new
                        {
                            StudentID = 21,
                            Age = 21,
                            EmailId = "abc@globallogic.com",
                            FirstName = "Aman",
                            Gender = "M",
                            LastName = "Asati",
                            TeamName = "D"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
