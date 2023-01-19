using Microsoft.EntityFrameworkCore.Migrations;

namespace Project001_Final.Persistence.Migrations
{
    public partial class _13_01_2023_08 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "UserId",
                table: "PostLike",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PostLike_User_UserId",
                table: "PostLike");

            migrationBuilder.DropIndex(
                name: "IX_PostLike_UserId",
                table: "PostLike");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PostLike");

            migrationBuilder.AddColumn<int>(
                name: "LikedUserId",
                table: "PostLike",
                type: "int",
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
    }
}
