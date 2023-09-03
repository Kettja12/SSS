﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SSS.Migrations
{
    /// <inheritdoc />
    public partial class addPaceToResult2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Place",
                table: "Results",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Place",
                table: "Results");
        }
    }
}
