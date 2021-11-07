using Microsoft.EntityFrameworkCore.Migrations;

namespace GameOfSpace.EFCore.Migrations
{
    public partial class galaxywithoutnumberofstars : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfStars",
                table: "Galaxy");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "NumberOfStars",
                table: "Galaxy",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
