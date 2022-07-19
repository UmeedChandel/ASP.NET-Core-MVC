using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PieWorkShop.Migrations
{
    public partial class SeedDataDeleteOneRow : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "StudentID",
                keyValue: 22);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentID", "Age", "FirstName", "Gender", "LastName", "TeamName" },
                values: new object[] { 22, 35, "Rajeev", "M", "Kumar", "D" });
        }
    }
}
