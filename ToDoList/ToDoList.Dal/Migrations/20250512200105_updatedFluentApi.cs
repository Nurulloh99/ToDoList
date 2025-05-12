using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToDoList.Dal.Migrations
{
    /// <inheritdoc />
    public partial class updatedFluentApi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "UserID",
                table: "ToDoItems",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_ToDoItems_UserID",
                table: "ToDoItems",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_ToDoItems_Users_UserID",
                table: "ToDoItems",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToDoItems_Users_UserID",
                table: "ToDoItems");

            migrationBuilder.DropIndex(
                name: "IX_ToDoItems_UserID",
                table: "ToDoItems");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "ToDoItems");
        }
    }
}
