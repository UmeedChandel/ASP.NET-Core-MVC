using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PieWorkShop.Migrations
{
    public partial class updateCorrectEmailId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TeamName",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(3)",
                oldMaxLength: 3);

            migrationBuilder.AlterColumn<string>(
                name: "EmailId",
                table: "Students",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1,
                column: "EmailId",
                value: "amara.sriram@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "EmailId",
                value: "muskan.1@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 3,
                column: "EmailId",
                value: "rahul.yadav9@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 4,
                column: "EmailId",
                value: "shraddha.singh2@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 5,
                column: "EmailId",
                value: "aishwarya.verma2@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 6,
                column: "EmailId",
                value: "shreya.kanoujia@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 7,
                column: "EmailId",
                value: "rayapati.nanditha@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 8,
                column: "EmailId",
                value: "shashwat.shukla@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 9,
                column: "EmailId",
                value: "siddharth.khare@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 10,
                column: "EmailId",
                value: "shriya.porwal@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 11,
                columns: new[] { "EmailId", "LastName" },
                values: new object[] { "sriram.ravipudi@globallogic.com", "Ravipudi" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 12,
                column: "EmailId",
                value: "sneha.sinha3@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 13,
                column: "EmailId",
                value: "simran.singh3@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 14,
                column: "EmailId",
                value: "subhash.gurjar@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 15,
                column: "EmailId",
                value: "umeed.chandel@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 16,
                column: "EmailId",
                value: "vaibhav.bhatnagar2@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 17,
                column: "EmailId",
                value: "vavilapalli.pujitha@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 18,
                column: "EmailId",
                value: "palak.soni@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 19,
                column: "EmailId",
                value: "saurabh.k.gupta2@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 20,
                column: "EmailId",
                value: "tisha.varshney@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 21,
                column: "EmailId",
                value: "aman.asati@globallogic.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TeamName",
                table: "Students",
                type: "nvarchar(3)",
                maxLength: 3,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailId",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 1,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 2,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 3,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 4,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 5,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 6,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 7,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 8,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 9,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 10,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 11,
                columns: new[] { "EmailId", "LastName" },
                values: new object[] { "abc@globallogic.com", "" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 12,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 13,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 14,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 15,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 16,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 17,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 18,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 19,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 20,
                column: "EmailId",
                value: "abc@globallogic.com");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 21,
                column: "EmailId",
                value: "abc@globallogic.com");
        }
    }
}
