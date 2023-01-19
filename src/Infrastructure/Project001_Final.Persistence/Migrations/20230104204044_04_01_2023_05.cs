using Microsoft.EntityFrameworkCore.Migrations;

namespace Project001_Final.Persistence.Migrations
{
    public partial class _04_01_2023_05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "SStudents");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SStudents",
                table: "SStudents",
                column: "Id");*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          /*  migrationBuilder.DropPrimaryKey(
                name: "PK_SStudents",
                table: "SStudents");

            migrationBuilder.RenameTable(
                name: "SStudents",
                newName: "Students");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");*/
        }
    }
}
