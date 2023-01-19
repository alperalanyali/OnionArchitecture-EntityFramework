using Microsoft.EntityFrameworkCore.Migrations;

namespace Project001_Final.Persistence.Migrations
{
    public partial class _13_01_23 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_postComment",
                table: "postComment");

            migrationBuilder.DropColumn(
                name: "CommentUserId",
                table: "postComment");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "postComment");

            migrationBuilder.RenameTable(
                name: "postComment",
                newName: "PostComment");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PostComment",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PostComment",
                table: "PostComment",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_UserId",
                table: "PostComment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_User_UserId",
                table: "PostComment",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostComment_User_UserId",
                table: "PostComment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PostComment",
                table: "PostComment");

            migrationBuilder.DropIndex(
                name: "IX_PostComment_UserId",
                table: "PostComment");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PostComment");

            migrationBuilder.RenameTable(
                name: "PostComment",
                newName: "postComment");

            migrationBuilder.AddColumn<int>(
                name: "CommentUserId",
                table: "postComment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "postComment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_postComment",
                table: "postComment",
                column: "Id");
        }
    }
}
