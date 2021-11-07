using Microsoft.EntityFrameworkCore.Migrations;

namespace GameOfSpace.EFCore.Migrations
{
    public partial class populationpropadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Population",
                table: "Planets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Population",
                table: "Planets");
        }
    }
}
