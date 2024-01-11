using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CombineSample.Migrations
{
    /// <inheritdoc />
    public partial class yourmigrations6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "employeeLeave",
                table: "Employee_Details",
                newName: "employee_vacation_req");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "employee_vacation_req",
                table: "Employee_Details",
                newName: "employeeLeave");
        }
    }
}
