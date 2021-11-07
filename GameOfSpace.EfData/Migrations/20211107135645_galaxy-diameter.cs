using Microsoft.EntityFrameworkCore.Migrations;

namespace GameOfSpace.EFCore.Migrations
{
    public partial class galaxydiameter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LongestDimension",
                table: "Galaxy",
                newName: "Diameter");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Diameter",
                table: "Galaxy",
                newName: "LongestDimension");
        }
    }
}
