using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelPlanning.Migrations
{
    public partial class AddedForms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "email");

            migrationBuilder.CreateTable(
                name: "Forms",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_of_departure = table.Column<DateTime>(type: "date", nullable: false),
                    date_of_arrival = table.Column<DateTime>(type: "date", nullable: false),
                    number_of_adults = table.Column<int>(type: "int", nullable: false),
                    number_of_children = table.Column<int>(type: "int", nullable: false),
                    location = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    type_of_stay = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    transportation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    budget = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Forms", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Forms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "email");
        }
    }
}
