using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalNotesV2.Migrations
{
    /// <inheritdoc />
    public partial class addedsomethings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Author",
                table: "BlogPosts");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "TodoItems",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "BlogPosts",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "ApplicationUserId", "CreatedDate", "Description", "Text", "Title" },
                values: new object[,]
                {
                    { new Guid("30b223b5-38e2-438c-a14f-d2bc16de3122"), null, new DateTime(2023, 12, 28, 21, 53, 56, 435, DateTimeKind.Local).AddTicks(3525), "TestData1Blog", "testest1", "TestData1Blog" },
                    { new Guid("34da0f3b-1fd9-4fa0-b876-48a9c207f7e5"), null, new DateTime(2023, 12, 28, 21, 53, 56, 435, DateTimeKind.Local).AddTicks(3530), "TestData2Blog", "testest2", "TestData2Blog" },
                    { new Guid("5270f9e1-260e-4160-8c93-c46ab6761511"), null, new DateTime(2023, 12, 28, 21, 53, 56, 435, DateTimeKind.Local).AddTicks(3536), "TestData3Blog", "testest3", "TestData3Blog" }
                });

            migrationBuilder.InsertData(
                table: "TodoItems",
                columns: new[] { "Id", "ApplicationUserId", "CreatedDate", "Description", "DueDate", "Priority", "Rank", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0eb8d5ae-31ad-46d7-b210-42485ed34254"), null, new DateTime(2023, 12, 28, 21, 53, 56, 435, DateTimeKind.Local).AddTicks(3390), "TestData1", new DateTime(2023, 12, 29, 21, 53, 56, 435, DateTimeKind.Local).AddTicks(3391), 1, 1, 0, "TestData1", null },
                    { new Guid("9d7930ed-00f2-4ecb-afad-26653b4e6af4"), null, new DateTime(2023, 12, 28, 21, 53, 56, 435, DateTimeKind.Local).AddTicks(3406), "TestData2", new DateTime(2023, 12, 30, 21, 53, 56, 435, DateTimeKind.Local).AddTicks(3408), 2, 2, 0, "TestData2", null },
                    { new Guid("b220e757-b497-4244-ab12-e33ff62260c1"), null, new DateTime(2023, 12, 28, 21, 53, 56, 435, DateTimeKind.Local).AddTicks(3412), "TestData3", new DateTime(2023, 12, 31, 21, 53, 56, 435, DateTimeKind.Local).AddTicks(3413), 3, 3, 0, "TestData3", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TodoItems_ApplicationUserId",
                table: "TodoItems",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_ApplicationUserId",
                table: "BlogPosts",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_BlogPosts_AspNetUsers_ApplicationUserId",
                table: "BlogPosts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TodoItems_AspNetUsers_ApplicationUserId",
                table: "TodoItems",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BlogPosts_AspNetUsers_ApplicationUserId",
                table: "BlogPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_TodoItems_AspNetUsers_ApplicationUserId",
                table: "TodoItems");

            migrationBuilder.DropIndex(
                name: "IX_TodoItems_ApplicationUserId",
                table: "TodoItems");

            migrationBuilder.DropIndex(
                name: "IX_BlogPosts_ApplicationUserId",
                table: "BlogPosts");

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("30b223b5-38e2-438c-a14f-d2bc16de3122"));

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("34da0f3b-1fd9-4fa0-b876-48a9c207f7e5"));

            migrationBuilder.DeleteData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: new Guid("5270f9e1-260e-4160-8c93-c46ab6761511"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("0eb8d5ae-31ad-46d7-b210-42485ed34254"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("9d7930ed-00f2-4ecb-afad-26653b4e6af4"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("b220e757-b497-4244-ab12-e33ff62260c1"));

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "BlogPosts");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "BlogPosts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
