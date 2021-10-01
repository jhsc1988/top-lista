using Microsoft.EntityFrameworkCore.Migrations;

namespace top_lista.Data.Migrations
{
    public partial class Digits : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Miliseconds",
                table: "Result",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Minutes",
                table: "Result",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Seconds",
                table: "Result",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Miliseconds",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "Minutes",
                table: "Result");

            migrationBuilder.DropColumn(
                name: "Seconds",
                table: "Result");
        }
    }
}
