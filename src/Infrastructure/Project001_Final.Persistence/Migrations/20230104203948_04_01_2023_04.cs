using Microsoft.EntityFrameworkCore.Migrations;

namespace Project001_Final.Persistence.Migrations
{
    public partial class _04_01_2023_04 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.DropPrimaryKey(
                name: "PK_SStudents",
                table: "SStudents");

            migrationBuilder.RenameTable(
                name: "SStudents",
                newName: "Students");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Students",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "last_name",
                table: "Students",
                newName: "Surname");

            migrationBuilder.RenameColumn(
                name: "first_name",
                table: "Students",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "birth_date",
                table: "Students",
                newName: "BirthDate");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Students",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");*/
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
                name: "Id",
                table: "SStudents",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "SStudents",
                newName: "last_name");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "SStudents",
                newName: "first_name");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "SStudents",
                newName: "birth_date");

            migrationBuilder.AlterColumn<string>(
                name: "last_name",
                table: "SStudents",
                type: "nvarchar",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "first_name",
                table: "SStudents",
                type: "nvarchar",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_SStudents",
                table: "SStudents",
                column: "id");*/
        }
    }
}
