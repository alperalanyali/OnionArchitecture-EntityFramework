using Microsoft.EntityFrameworkCore.Migrations;

namespace Project001_Final.Persistence.Migrations
{
    public partial class _12_01_2023_06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostLike_User_LikedUserIdId",
                table: "PostLike");

            migrationBuilder.DropIndex(
                name: "IX_PostLike_LikedUserIdId",
                table: "PostLike");

            migrationBuilder.DropColumn(
                name: "LikedUserIdId",
                table: "PostLike");

            migrationBuilder.AddColumn<int>(
                name: "LikedUserId",
                table: "PostLike",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostLike_LikedUserId",
                table: "PostLike",
                column: "LikedUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostLike_User_LikedUserId",
                table: "PostLike",
                column: "LikedUserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostLike_User_LikedUserId",
                table: "PostLike");

            migrationBuilder.DropIndex(
                name: "IX_PostLike_LikedUserId",
                table: "PostLike");

            migrationBuilder.DropColumn(
                name: "LikedUserId",
                table: "PostLike");

            migrationBuilder.AddColumn<int>(
                name: "LikedUserIdId",
                table: "PostLike",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostLike_LikedUserIdId",
                table: "PostLike",
                column: "LikedUserIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostLike_User_LikedUserIdId",
                table: "PostLike",
                column: "LikedUserIdId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
