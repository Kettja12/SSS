using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSS.Migrations
{
    /// <inheritdoc />
    public partial class Position : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PosititionRace2",
                table: "Results",
                newName: "PositionRace2");

            migrationBuilder.RenameColumn(
                name: "PosititionRace1",
                table: "Results",
                newName: "PositionRace1");

            migrationBuilder.RenameColumn(
                name: "Positition",
                table: "Results",
                newName: "Position");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PositionRace2",
                table: "Results",
                newName: "PosititionRace2");

            migrationBuilder.RenameColumn(
                name: "PositionRace1",
                table: "Results",
                newName: "PosititionRace1");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Results",
                newName: "Positition");
        }
    }
}
