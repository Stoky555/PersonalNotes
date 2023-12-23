using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalNotes.Migrations
{
    /// <inheritdoc />
    public partial class Extend_TodoList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                table: "TodoItems",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "TodoItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "TodoItems",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "Rank",
                table: "TodoItems");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TodoItems",
                newName: "id");
        }
    }
}
