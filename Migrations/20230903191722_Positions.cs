using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSS.Migrations
{
    /// <inheritdoc />
    public partial class Positions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StartCount",
                table: "Races");

            migrationBuilder.RenameColumn(
                name: "Postition",
                table: "Results",
                newName: "PosititionRace2");

            migrationBuilder.AddColumn<int>(
                name: "Positition",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PosititionRace1",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Positition",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "PosititionRace1",
                table: "Results");

            migrationBuilder.RenameColumn(
                name: "PosititionRace2",
                table: "Results",
                newName: "Postition");

            migrationBuilder.AddColumn<int>(
                name: "StartCount",
                table: "Races",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
