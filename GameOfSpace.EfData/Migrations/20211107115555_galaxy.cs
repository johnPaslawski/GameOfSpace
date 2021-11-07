using Microsoft.EntityFrameworkCore.Migrations;

namespace GameOfSpace.EFCore.Migrations
{
    public partial class galaxy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GalaxyId",
                table: "PlanetarySystems",
                type: "int",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Galaxy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LongestDimension = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfStars = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galaxy", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanetarySystems_GalaxyId",
                table: "PlanetarySystems",
                column: "GalaxyId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlanetarySystems_Galaxy_GalaxyId",
                table: "PlanetarySystems",
                column: "GalaxyId",
                principalTable: "Galaxy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlanetarySystems_Galaxy_GalaxyId",
                table: "PlanetarySystems");

            migrationBuilder.DropTable(
                name: "Galaxy");

            migrationBuilder.DropIndex(
                name: "IX_PlanetarySystems_GalaxyId",
                table: "PlanetarySystems");

            migrationBuilder.DropColumn(
                name: "GalaxyId",
                table: "PlanetarySystems");
        }
    }
}
