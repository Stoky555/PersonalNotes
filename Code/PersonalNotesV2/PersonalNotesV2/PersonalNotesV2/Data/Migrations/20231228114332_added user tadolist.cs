using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalNotesV2.Migrations
{
    /// <inheritdoc />
    public partial class addedusertadolist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("487bda88-684f-474d-932d-e114662ae8b8"));

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("a0b37e82-69a2-4e6c-a397-021eaaf25038"));

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("c58a4c94-b9ba-4d8d-88e5-0ef64ba98e94"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("6bbb40bf-11ad-4a45-be82-c8a8ac783411"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("dca88195-f39d-453d-a2f9-ec99522219e9"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("ddafbee1-f7f9-4aba-8674-7ee8479d761b"));

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "CreatedDate", "Description", "Text", "Title" },
                values: new object[,]
                {
                    { new Guid("552bbf2f-1c61-41a4-9021-988bcbba2859"), "Stoky", new DateTime(2023, 12, 28, 12, 43, 32, 144, DateTimeKind.Local).AddTicks(4679), "TestData2Blog", "testest2", "TestData2Blog" },
                    { new Guid("e963dbf9-5170-4c7d-a5f3-d42bb5b4fa0a"), "Stoky", new DateTime(2023, 12, 28, 12, 43, 32, 144, DateTimeKind.Local).AddTicks(4686), "TestData3Blog", "testest3", "TestData3Blog" },
                    { new Guid("ed436ed6-d1a6-41e9-86a3-f2f6a7d71d0c"), "Stoky", new DateTime(2023, 12, 28, 12, 43, 32, 144, DateTimeKind.Local).AddTicks(4672), "TestData1Blog", "testest1", "TestData1Blog" }
                });

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "CreatedDate", "Description", "DueDate", "Priority", "Rank", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1f93688a-2059-4e33-9e41-475e889580e8"), new DateTime(2023, 12, 28, 12, 43, 32, 144, DateTimeKind.Local).AddTicks(4553), "TestData2", new DateTime(2023, 12, 30, 12, 43, 32, 144, DateTimeKind.Local).AddTicks(4554), 2, 2, 0, "TestData2", null },
                    { new Guid("cb7d68ee-04bf-4f02-abd6-9a45bdf2fe88"), new DateTime(2023, 12, 28, 12, 43, 32, 144, DateTimeKind.Local).AddTicks(4559), "TestData3", new DateTime(2023, 12, 31, 12, 43, 32, 144, DateTimeKind.Local).AddTicks(4560), 3, 3, 0, "TestData3", null },
                    { new Guid("cc05086d-c38c-42b9-9371-69e017c95e03"), new DateTime(2023, 12, 28, 12, 43, 32, 144, DateTimeKind.Local).AddTicks(4537), "TestData1", new DateTime(2023, 12, 29, 12, 43, 32, 144, DateTimeKind.Local).AddTicks(4539), 1, 1, 0, "TestData1", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("552bbf2f-1c61-41a4-9021-988bcbba2859"));

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("e963dbf9-5170-4c7d-a5f3-d42bb5b4fa0a"));

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("ed436ed6-d1a6-41e9-86a3-f2f6a7d71d0c"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("1f93688a-2059-4e33-9e41-475e889580e8"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("cb7d68ee-04bf-4f02-abd6-9a45bdf2fe88"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("cc05086d-c38c-42b9-9371-69e017c95e03"));

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "Author", "CreatedDate", "Description", "Text", "Title" },
                values: new object[,]
                {
                    { new Guid("487bda88-684f-474d-932d-e114662ae8b8"), "Stoky", new DateTime(2023, 12, 27, 21, 30, 54, 675, DateTimeKind.Local).AddTicks(7740), "TestData1Blog", "testest1", "TestData1Blog" },
                    { new Guid("a0b37e82-69a2-4e6c-a397-021eaaf25038"), "Stoky", new DateTime(2023, 12, 27, 21, 30, 54, 675, DateTimeKind.Local).AddTicks(7750), "TestData3Blog", "testest3", "TestData3Blog" },
                    { new Guid("c58a4c94-b9ba-4d8d-88e5-0ef64ba98e94"), "Stoky", new DateTime(2023, 12, 27, 21, 30, 54, 675, DateTimeKind.Local).AddTicks(7746), "TestData2Blog", "testest2", "TestData2Blog" }
                });

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "CreatedDate", "Description", "DueDate", "Priority", "Rank", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("6bbb40bf-11ad-4a45-be82-c8a8ac783411"), new DateTime(2023, 12, 27, 21, 30, 54, 675, DateTimeKind.Local).AddTicks(7604), "TestData1", new DateTime(2023, 12, 28, 21, 30, 54, 675, DateTimeKind.Local).AddTicks(7606), 1, 1, 0, "TestData1", null },
                    { new Guid("dca88195-f39d-453d-a2f9-ec99522219e9"), new DateTime(2023, 12, 27, 21, 30, 54, 675, DateTimeKind.Local).AddTicks(7614), "TestData2", new DateTime(2023, 12, 29, 21, 30, 54, 675, DateTimeKind.Local).AddTicks(7616), 2, 2, 0, "TestData2", null },
                    { new Guid("ddafbee1-f7f9-4aba-8674-7ee8479d761b"), new DateTime(2023, 12, 27, 21, 30, 54, 675, DateTimeKind.Local).AddTicks(7620), "TestData3", new DateTime(2023, 12, 30, 21, 30, 54, 675, DateTimeKind.Local).AddTicks(7621), 3, 3, 0, "TestData3", null }
                });
        }
    }
}
