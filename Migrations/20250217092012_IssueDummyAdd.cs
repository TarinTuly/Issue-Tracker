using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Issue.Migrations
{
    /// <inheritdoc />
    public partial class IssueDummyAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "Id", "CreatedById", "Description", "IsOngoing", "ProjectId", "Title" },
                values: new object[,]
                {
                    { 1, 1, "Users can't log in", true, 1, "Login Bug" },
                    { 2, 2, "Alignment issue", true, 2, "UI Glitch" },
                    { 3, 3, "Slow response", false, 3, "Performance Issue" },
                    { 4, 4, "Data leak risk", true, 4, "Security Vulnerability" },
                    { 5, 5, "DB service down", false, 5, "Database Crash" },
                    { 6, 6, "API requests failing", true, 6, "API Timeout" },
                    { 7, 7, "High RAM usage", false, 7, "Memory Leak" },
                    { 8, 8, "404 error", true, 8, "Broken Link" },
                    { 9, 9, "Buttons not responsive", false, 9, "Mobile UI Issue" },
                    { 10, 10, "CI/CD error", true, 10, "Deployment Failure" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Issues",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
