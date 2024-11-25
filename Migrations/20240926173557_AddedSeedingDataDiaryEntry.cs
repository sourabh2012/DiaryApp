using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Went hiking with joe", new DateTime(2024, 9, 26, 23, 5, 57, 90, DateTimeKind.Local).AddTicks(8397), "Went Hiking" },
                    { 2, "Went Shopping with joe", new DateTime(2024, 9, 26, 23, 5, 57, 90, DateTimeKind.Local).AddTicks(8664), "Went Shopping" },
                    { 3, "Went Diving with joe", new DateTime(2024, 9, 26, 23, 5, 57, 90, DateTimeKind.Local).AddTicks(8666), "Went Divivg" },
                    { 4, "Went Dancing with joe", new DateTime(2024, 9, 26, 23, 5, 57, 90, DateTimeKind.Local).AddTicks(8667), "Went Dancing" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
