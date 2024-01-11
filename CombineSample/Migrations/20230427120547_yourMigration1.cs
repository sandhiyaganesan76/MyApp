using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CombineSample.Migrations
{
    /// <inheritdoc />
    public partial class yourMigration1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "employee_project",
                table: "Employee_Details");

            migrationBuilder.DropColumn(
                name: "employee_trainer_name",
                table: "Employee_Details");

            migrationBuilder.DropColumn(
                name: "employee_training_end_time",
                table: "Employee_Details");

            migrationBuilder.DropColumn(
                name: "employee_training_start_time",
                table: "Employee_Details");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "employee_project",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employee_trainer_name",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employee_training_end_time",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "employee_training_start_time",
                table: "Employee_Details",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
