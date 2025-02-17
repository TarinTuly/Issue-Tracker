using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Issue.Migrations
{
    /// <inheritdoc />
    public partial class CommentDummyAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "CreatedAt", "CreatedById", "IssueId" },
                values: new object[,]
                {
                    { 1, "Initial issue reported", new DateTime(2024, 2, 17, 10, 0, 0, 0, DateTimeKind.Unspecified), 1, 1 },
                    { 2, "Assigned to developer", new DateTime(2024, 2, 17, 10, 30, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 3, "Bug confirmed", new DateTime(2024, 2, 17, 11, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 4, "Fix in progress", new DateTime(2024, 2, 17, 11, 30, 0, 0, DateTimeKind.Unspecified), 4, 2 },
                    { 5, "Fixed and committed", new DateTime(2024, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), 2, 3 },
                    { 6, "Tested and verified", new DateTime(2024, 2, 17, 12, 30, 0, 0, DateTimeKind.Unspecified), 3, 3 },
                    { 7, "Deployed to staging", new DateTime(2024, 2, 17, 13, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 8, "Issue re-opened", new DateTime(2024, 2, 17, 13, 30, 0, 0, DateTimeKind.Unspecified), 1, 4 },
                    { 9, "Final fix applied", new DateTime(2024, 2, 17, 14, 0, 0, 0, DateTimeKind.Unspecified), 2, 5 },
                    { 10, "Closed successfully", new DateTime(2024, 2, 17, 14, 30, 0, 0, DateTimeKind.Unspecified), 4, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
