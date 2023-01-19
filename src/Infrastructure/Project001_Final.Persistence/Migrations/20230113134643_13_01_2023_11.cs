using Microsoft.EntityFrameworkCore.Migrations;

namespace Project001_Final.Persistence.Migrations
{
    public partial class _13_01_2023_11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostComment_User_PostId",
                table: "PostComment");

            migrationBuilder.DropForeignKey(
                name: "FK_PostComment_Post_PostId1",
                table: "PostComment");

            migrationBuilder.DropIndex(
                name: "IX_PostComment_PostId1",
                table: "PostComment");

            migrationBuilder.DropColumn(
                name: "PostId1",
                table: "PostComment");

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_UserId",
                table: "PostComment",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_Post_PostId",
                table: "PostComment",
                column: "PostId",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_PostComment_Post_PostId",
                table: "PostComment");

            migrationBuilder.DropForeignKey(
                name: "FK_PostComment_User_UserId",
                table: "PostComment");

            migrationBuilder.DropIndex(
                name: "IX_PostComment_UserId",
                table: "PostComment");

            migrationBuilder.AddColumn<int>(
                name: "PostId1",
                table: "PostComment",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PostComment_PostId1",
                table: "PostComment",
                column: "PostId1");

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_User_PostId",
                table: "PostComment",
                column: "PostId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PostComment_Post_PostId1",
                table: "PostComment",
                column: "PostId1",
                principalTable: "Post",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
