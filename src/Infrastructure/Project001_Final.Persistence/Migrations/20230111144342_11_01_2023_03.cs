using Microsoft.EntityFrameworkCore.Migrations;

namespace Project001_Final.Persistence.Migrations
{
    public partial class _11_01_2023_03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostLike_User_UserId",
                table: "PostLike");

            migrationBuilder.DropIndex(
                name: "IX_PostLike_UserId",
                table: "PostLike");

            migrationBuilder.DropColumn(
                name: "LikedUserId",
                table: "PostLike");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PostLike");

            migrationBuilder.AddColumn<int>(
                name: "LikedUserIdId",
                table: "PostLike",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "PostLike",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostLike_UserId",
                table: "PostLike",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PostLike_User_UserId",
                table: "PostLike",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
