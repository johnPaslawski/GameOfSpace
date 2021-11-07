using Microsoft.EntityFrameworkCore.Migrations;

namespace GameOfSpace.EFCore.Migrations
{
    public partial class imagepath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Planets",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Planets");
        }
    }
}
