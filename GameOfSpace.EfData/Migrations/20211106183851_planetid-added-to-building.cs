using Microsoft.EntityFrameworkCore.Migrations;

namespace GameOfSpace.EFCore.Migrations
{
    public partial class planetidaddedtobuilding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Planets_PlanetId",
                table: "Buildings");

            migrationBuilder.AlterColumn<int>(
                name: "PlanetId",
                table: "Buildings",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Planets_PlanetId",
                table: "Buildings",
                column: "PlanetId",
                principalTable: "Planets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Planets_PlanetId",
                table: "Buildings");

            migrationBuilder.AlterColumn<int>(
                name: "PlanetId",
                table: "Buildings",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Planets_PlanetId",
                table: "Buildings",
                column: "PlanetId",
                principalTable: "Planets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
