using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSS.Migrations
{
    /// <inheritdoc />
    public partial class DNF_DNS1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DNS",
                table: "Results",
                newName: "DNS1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DNS1",
                table: "Results",
                newName: "DNS");
        }
    }
}
