using Microsoft.EntityFrameworkCore.Migrations;

namespace Project001_Final.Persistence.Migrations
{
    public partial class _04_01_2023_06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
         /*   migrationBuilder.DropPrimaryKey(
                name: "PK_SStudents",
                table: "SStudents");

            migrationBuilder.RenameTable(
                name: "SStudents",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Students",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Students",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Students",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Students",
                newName: "birth_date");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "Students",
                type: "nvarchar",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "Students",
                type: "nvarchar",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "id");*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "SStudents");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "SStudents",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "SStudents",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "SStudents",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "birth_date",
                table: "SStudents",
                newName: "BirthDate");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "SStudents",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "SStudents",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SStudents",
                table: "SStudents",
                column: "Id");*/
        }
    }
}
