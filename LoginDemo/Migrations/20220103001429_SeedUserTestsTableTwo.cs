using Microsoft.EntityFrameworkCore.Migrations;

namespace LoginDemo.Migrations
{
    public partial class SeedUserTestsTableTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserTests",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "UserTests",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { 11, "a11.yahoo.com", "a11", "b" });

            migrationBuilder.InsertData(
                table: "UserTests",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { 12, "a212.yahoo.com", "a2", "b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserTests",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "UserTests",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.InsertData(
                table: "UserTests",
                columns: new[] { "Id", "Email", "Name", "Password" },
                values: new object[] { 1, "a.yahoo.com", "a", "b" });
        }
    }
}
