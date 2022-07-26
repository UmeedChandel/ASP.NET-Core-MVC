using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentAPI.Migrations
{
    public partial class Seedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Age", "EmailId", "FirstName", "Gender", "LastName", "TeamName" },
                values: new object[,]
                {
                    { 1, 21, "amara.sriram@globallogic.com", "Amara", "M", "Sriram", "A" },
                    { 2, 20, "muskan.1@globallogic.com", "Muskan", "F", "Muskan", "A" },
                    { 3, 21, "rahul.yadav9@globallogic.com", "Rahul", "M", "Yadav", "A" },
                    { 4, 20, "shraddha.singh2@globallogic.com", "Shraddha", "F", "Shraddha", "A" },
                    { 5, 20, "aishwarya.verma2@globallogic.com", "Aishwarya", "F", "Verma", "A" },
                    { 6, 20, "shreya.kanoujia@globallogic.com", "Shreya", "F", "Kanoujia", "B" },
                    { 7, 20, "rayapati.nanditha@globallogic.com", "Nandhita", "F", "Rayapati", "B" },
                    { 8, 20, "shashwat.shukla@globallogic.com", "Shashwat", "M", "Shukla", "B" },
                    { 9, 21, "siddharth.khare@globallogic.com", "Siddarth", "M", "Khare", "B" },
                    { 10, 20, "shriya.porwal@globallogic.com", "Shriya", "F", "Porwal", "B" },
                    { 11, 21, "sriram.ravipudi@globallogic.com", "Sriram", "M", "Ravipudi", "C" },
                    { 12, 20, "sneha.sinha3@globallogic.com", "Sneha", "F", "Sinha", "C" },
                    { 13, 20, "simran.singh3@globallogic.com", "Simran", "F", "Singh", "C" },
                    { 14, 21, "subhash.gurjar@globallogic.com", "Subhash", "M", "Gurjar", "C" },
                    { 15, 19, "umeed.chandel@globallogic.com", "Umeed", "F", "Chandel", "C" },
                    { 16, 21, "vaibhav.bhatnagar2@globallogic.com", "Vaibhav", "M", "Bhatnagar", "D" },
                    { 17, 20, "vavilapalli.pujitha@globallogic.com", "Pujitha", "F", "Vavilapalli", "D" },
                    { 18, 20, "palak.soni@globallogic.com", "Palak", "F", "Soni", "D" },
                    { 19, 21, "saurabh.k.gupta2@globallogic.com", "Saurabh", "M", "Kumar", "D" },
                    { 20, 20, "tisha.varshney@globallogic.com", "Tisha", "F", "Varshney", "D" },
                    { 21, 21, "aman.asati@globallogic.com", "Aman", "M", "Asati", "D" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 21);
        }
    }
}
