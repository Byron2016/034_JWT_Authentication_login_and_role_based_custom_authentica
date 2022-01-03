using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginDemo.Migrations
{
    public partial class SeedUserTestsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserTests",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { 1, "a.yahoo.com", "a", "b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserTests",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
