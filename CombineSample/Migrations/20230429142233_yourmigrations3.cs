using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CombineSample.Migrations
{
    /// <inheritdoc />
    public partial class yourmigrations3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "employeeLocation",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employeeMobile",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employmentStartDate",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employmentStatus",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "employeeLocation",
                table: "Employee_Details");

            migrationBuilder.DropColumn(
                name: "employeeMobile",
                table: "Employee_Details");

            migrationBuilder.DropColumn(
                name: "employmentStartDate",
                table: "Employee_Details");

            migrationBuilder.DropColumn(
                name: "employmentStatus",
                table: "Employee_Details");
        }
    }
}
