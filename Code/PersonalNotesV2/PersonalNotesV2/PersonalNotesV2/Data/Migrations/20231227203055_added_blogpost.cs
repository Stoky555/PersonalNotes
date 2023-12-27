using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalNotesV2.Migrations
{
    /// <inheritdoc />
    public partial class added_blogpost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("057fbd43-70e9-483b-b3ed-1f9feda35333"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("2e4e6741-795c-442a-bc7b-6f1f7fb68a18"));

            migrationBuilder.DeleteData(
                table: "TodoItems",
                keyColumn: "Id",
                keyValue: new Guid("dcb7df8f-f25b-4191-8f8a-42015d7f3c2a"));

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogPostId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Images_BlogPostId",
                table: "Images",
                column: "BlogPostId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "BlogPosts");

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
                table: "TodoItems",
                columns: new[] { "Id", "CreatedDate", "Description", "DueDate", "Priority", "Rank", "Status", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("057fbd43-70e9-483b-b3ed-1f9feda35333"), new DateTime(2023, 12, 27, 9, 43, 19, 273, DateTimeKind.Local).AddTicks(7049), "TestData2", new DateTime(2023, 12, 29, 9, 43, 19, 273, DateTimeKind.Local).AddTicks(7051), 2, 2, 0, "TestData2", null },
                    { new Guid("2e4e6741-795c-442a-bc7b-6f1f7fb68a18"), new DateTime(2023, 12, 27, 9, 43, 19, 273, DateTimeKind.Local).AddTicks(7055), "TestData3", new DateTime(2023, 12, 30, 9, 43, 19, 273, DateTimeKind.Local).AddTicks(7056), 3, 3, 0, "TestData3", null },
                    { new Guid("dcb7df8f-f25b-4191-8f8a-42015d7f3c2a"), new DateTime(2023, 12, 27, 9, 43, 19, 273, DateTimeKind.Local).AddTicks(7042), "TestData1", new DateTime(2023, 12, 28, 9, 43, 19, 273, DateTimeKind.Local).AddTicks(7043), 1, 1, 0, "TestData1", null }
                });
        }
    }
}
