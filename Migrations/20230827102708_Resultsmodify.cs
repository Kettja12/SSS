using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSS.Migrations
{
    /// <inheritdoc />
    public partial class Resultsmodify : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExceptionStatus",
                table: "Results");

            migrationBuilder.AddColumn<bool>(
                name: "DNF",
                table: "Results",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DNF",
                table: "Results");

            migrationBuilder.AddColumn<string>(
                name: "ExceptionStatus",
                table: "Results",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
