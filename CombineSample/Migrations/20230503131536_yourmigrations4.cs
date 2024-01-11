using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CombineSample.Migrations
{
    /// <inheritdoc />
    public partial class yourmigrations4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordResetToken",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PasswordResetTokenExpiration",
                table: "Employee_Details",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PasswordResetTokenExpiry",
                table: "Employee_Details",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordResetToken",
                table: "Employee_Details");

            migrationBuilder.DropColumn(
                name: "PasswordResetTokenExpiration",
                table: "Employee_Details");

            migrationBuilder.DropColumn(
                name: "PasswordResetTokenExpiry",
                table: "Employee_Details");
        }
    }
}
