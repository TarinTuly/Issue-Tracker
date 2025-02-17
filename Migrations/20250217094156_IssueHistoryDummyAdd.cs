using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Issue.Migrations
{
    /// <inheritdoc />
    public partial class IssueHistoryDummyAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "IssueHistories",
                columns: new[] { "Id", "ChangedAt", "IssueId", "StatusChange" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), 1, "Opened" },
                    { 2, new DateTime(2024, 2, 2, 12, 15, 0, 0, DateTimeKind.Unspecified), 1, "In Progress" },
                    { 3, new DateTime(2024, 2, 3, 14, 45, 0, 0, DateTimeKind.Unspecified), 1, "Resolved" },
                    { 4, new DateTime(2024, 2, 4, 9, 10, 0, 0, DateTimeKind.Unspecified), 2, "Opened" },
                    { 5, new DateTime(2024, 2, 5, 16, 20, 0, 0, DateTimeKind.Unspecified), 2, "Closed" },
                    { 6, new DateTime(2024, 2, 6, 11, 5, 0, 0, DateTimeKind.Unspecified), 3, "Opened" },
                    { 7, new DateTime(2024, 2, 7, 14, 0, 0, 0, DateTimeKind.Unspecified), 3, "In Review" },
                    { 8, new DateTime(2024, 2, 8, 8, 30, 0, 0, DateTimeKind.Unspecified), 4, "Opened" },
                    { 9, new DateTime(2024, 2, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), 5, "Reopened" },
                    { 10, new DateTime(2024, 2, 10, 17, 25, 0, 0, DateTimeKind.Unspecified), 5, "Resolved" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "IssueHistories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "IssueHistories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "IssueHistories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "IssueHistories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "IssueHistories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "IssueHistories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "IssueHistories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "IssueHistories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "IssueHistories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "IssueHistories",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
