using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project001_Final.Persistence.Migrations
{
    public partial class InitialDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SStudents",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    first_name = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: true),
                    last_name = table.Column<string>(type: "nvarchar", maxLength: 250, nullable: true),
                    birth_date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SStudents", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SStudents");
        }
    }
}
