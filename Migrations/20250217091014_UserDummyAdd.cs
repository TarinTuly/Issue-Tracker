using Issue.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Issue.Migrations
{
    /// <inheritdoc />
    public partial class UserDummyAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "PasswordHash", "UserType" },
                values: new object[,]
                {
                    { 1, "alice@example.com", "Alice Smith", "hashedpass1", "Admin" },
                    { 2, "bob@example.com", "Bob Johnson", "hashedpass2", "Developer" },
                    { 3, "charlie@example.com", "Charlie Brown", "hashedpass3", "Reporter" },
                    { 4, "david@example.com", "David Miller", "hashedpass4", "Tester" },
                    { 5, "eva@example.com", "Eva Green", "hashedpass5", "Manager" },
                    { 6, "frank@example.com", "Frank White", "hashedpass6", "Developer" },
                    { 7, "grace@example.com", "Grace Adams", "hashedpass7", "Designer" },
                    { 8, "hannah@example.com", "Hannah Lee", "hashedpass8", "Admin" },
                    { 9, "ian@example.com", "Ian Black", "hashedpass9", "QA" },
                    { 10, "jack@example.com", "Jack Taylor", "hashedpass10", "Developer" }
                });

          
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
