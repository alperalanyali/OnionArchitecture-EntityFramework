using Microsoft.EntityFrameworkCore.Migrations;

namespace Project001_Final.Persistence.Migrations
{
    public partial class _19_01_2023_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "SavedPost",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SavedPost_UserId",
                table: "SavedPost",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_SavedPost_User_UserId",
                table: "SavedPost",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SavedPost_User_UserId",
                table: "SavedPost");

            migrationBuilder.DropIndex(
                name: "IX_SavedPost_UserId",
                table: "SavedPost");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "SavedPost");
        }
    }
}
