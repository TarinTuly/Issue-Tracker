using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Issue.Migrations
{
    /// <inheritdoc />
    public partial class AttachmentDummyAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attachments",
                columns: new[] { "Id", "FilePath", "IssueId" },
                values: new object[,]
                {
                    { 1, "/uploads/error_log1.txt", 1 },
                    { 2, "/uploads/screenshot_bug.png", 1 },
                    { 3, "/uploads/stack_trace.log", 2 },
                    { 4, "/uploads/fix_patch.diff", 2 },
                    { 5, "/uploads/test_results.pdf", 3 },
                    { 6, "/uploads/crash_report.txt", 3 },
                    { 7, "/uploads/debug_log.txt", 4 },
                    { 8, "/uploads/final_patch.zip", 4 },
                    { 9, "/uploads/deployment_logs.txt", 5 },
                    { 10, "/uploads/code_review.docx", 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Attachments",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
