using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proje1.Data.Migrations
{
    /// <inheritdoc />
    public partial class mig5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "SensorData");

            migrationBuilder.RenameColumn(
                name: "temperature",
                table: "SensorData",
                newName: "sicaklik");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sicaklik",
                table: "SensorData",
                newName: "temperature");

            migrationBuilder.AddColumn<DateTime>(
                name: "Timestamp",
                table: "SensorData",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
