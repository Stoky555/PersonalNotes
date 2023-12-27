using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PersonalNotesV2.Migrations
{
    /// <inheritdoc />
    public partial class MigrationNewVersion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
